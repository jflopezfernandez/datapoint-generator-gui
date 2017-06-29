Option Explicit On

Imports System
Imports System.IO
Imports System.Text

Public Class frmMain

    Public usernameHasBeenSet As Boolean

    Public fileCreated As Boolean
    Public outputFileName As String

    ' File and Directory Variables
    Dim userName As String
    Dim outputDirectory As String
    Dim filename As String
    Dim filenameAndPath As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        usernameHasBeenSet = False

        ' File is not created until the user explicitly tells the program to generate it
        fileCreated = False

        outputFileName = txtOutputFileName.Text

        ' After initializing variables, refresh the GUI controls
        refreshControls()

    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Try
            outputFileName = txtOutputFileName.Text

        Catch conversion_error As System.IO.IOException
            MsgBox("You must enter a valid filename.", vbInformation + vbOKOnly, "Error")
        End Try

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        If cbPromptToSaveOnExit.Checked = vbTrue Then
            Dim response = MsgBox("Are you sure you want to exit?", vbYesNo, "Exit?")

            If response = vbNo Then
                Exit Sub
            Else
                End
            End If
        Else
            End
        End If
    End Sub

    Private Sub refreshControls()

        If usernameHasBeenSet = True Then
            ' Once the username has been set, let the user proceed as normal

            ' Set Datapoints button will not work until the user has created an output file to use
            If fileCreated = False Then
                With btnAddDatapoint
                    .Text = "[No Output File]"
                    .Enabled = False
                End With

                With btnBulkGenerate
                    .Text = "[No Output File]"
                    .Enabled = False
                End With

                With btnUseConsole
                    .Text = "[No Output File]"
                    .Enabled = False
                End With

                With btnCreateFile
                    .Text = "Create File"
                    .Enabled = True
                End With

            Else
                ' Username has been set
                ' Dataset file has been generated
                '       [READY TO GENERATE DATA]
                ' Re-enable all controls

                ' [DISABLED DUE TO LACK OF USEFULNESS FOR NOW]
                '' Logic for Create File button in the File Operations group box
                'If outputFileName = txtOutputFileName.Text Then
                '    With btnCreateFile
                '        .Text = "Replace Dataset"
                '    End With
                'Else
                '    With btnCreateFile
                '        .Text = "Create New File"
                '    End With
                'End If


                With btnAddDatapoint
                    .Text = "Add Datapoint"
                    .Enabled = True
                End With

                With btnBulkGenerate
                    .Text = "Generate Random Datapoints in Bulk"
                    .Enabled = True
                End With

                With btnUseConsole
                    .Text = "Use Console to Input Data"
                    .Enabled = True
                End With

                With btnCreateFile
                    .Text = "File Created"
                    .Enabled = False
                End With

            End If

        Else
            ' Username needs to be set, disable controls
            With btnCreateFile
                .Text = "[Need to Set User Name]"
                .Enabled = False
            End With

            With btnAddDatapoint
                .Text = "[Need to Set User Name]"
                .Enabled = False
            End With

            With btnBulkGenerate
                .Text = "[Need to Set User Name]"
                .Enabled = False
            End With

            With btnUseConsole
                .Text = "[Need to Set User Name]"
                .Enabled = False
            End With

        End If

    End Sub

    Private Sub btnCreateFile_Click(sender As Object, e As EventArgs) Handles btnCreateFile.Click
        If fileCreated = True Then
            ' If the user has already created one file, verify they are not accidentally creating a second one
            Dim createSecondFile = MsgBox("Are you sure you want to create another file?", vbYesNo + vbQuestion, "Continue?")

            If createSecondFile = vbYes Then
                ' Make sure the new output file name is different. If it's not, ask the user whether they want to replace their old
                ' dataset or change the new file name
                Dim replaceOriginalFile = MsgBox("The current file name that will be used to create the new dataset file is already taken. Replace the original?", vbCritical + vbYesNo, "Continue?")

                If replaceOriginalFile = vbYes Then
                    ' Replace original file (might have to close it first)

                End If
            Else
                ' User did not want to replace the file, so they'll have to exit the sub, change the output name, and try again
                Exit Sub
            End If
        Else
            ' If a file has not been previously created, generate the file and turn on the fileCreated switch


            Dim verifyUsername = MsgBox("Your username is currently set to " + userName + ", is this correct? This program will not work if your username does not match your Windows profile.", vbYesNo, "Please confirm user name.")

            If verifyUsername = vbYes Then

                ' No file has been created yet, so make one
                getFilePathAndDirectory()

                createDatasetFile()
                fileCreated = True

                refreshControls()

                ' Let the user know what the knew path is
                MsgBox("Full Path: " + filenameAndPath + " ", vbOK, "Update Completed")

            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub createDatasetFile()

        Dim input As String
        input = txtXValue.Text + ", " + txtYValue.Text

        ' If the file does not exist, create it, otherwise just append to it
        If IO.File.Exists(filenameAndPath) Then
            FileOpen(1, filenameAndPath, OpenMode.Append)
        Else
            FileOpen(1, filenameAndPath, OpenMode.Output)
        End If

        FileClose(1)

    End Sub

    Private Sub fileOutput(ByVal iterations As Int64, ByVal randBulk As Boolean)

        If randBulk = True Then
            Randomize()

            Dim randomDouble As New Random

            Dim rand_x As Double
            Dim rand_y As Double

            Dim counter As Int64
            counter = 0


            Do Until (counter = iterations)
                rand_x = randomDouble.NextDouble()
                rand_y = randomDouble.NextDouble()

                Dim input As String = Conversion.Str(rand_x) + ", " + Conversion.Str(rand_y)
                PrintLine(1, input)

                ' Increase counter
                counter = counter + 1
            Loop
        Else
            Dim input As String
            input = txtXValue.Text + ", " + txtYValue.Text

            PrintLine(1, input)
        End If

        refreshControls()

    End Sub

    Private Sub getFilePathAndDirectory()

        userName = txtUsername.Text
        outputDirectory = "C:\Users\" + userName + "\Desktop\"
        filename = txtOutputFileName.Text
        filenameAndPath = outputDirectory + filename

    End Sub

    Private Sub enterDataWithConsole()

        ' If file does not exist, create it, otherwise just append to it
        If IO.File.Exists(filenameAndPath) Then
            FileOpen(1, filenameAndPath, OpenMode.Append)
        Else
            FileOpen(1, filenameAndPath, OpenMode.Output)
        End If


        Dim input As String = ""

        Console.WriteLine("Enter x and y values on the same line separated by a comma and a space: 1.00, 1.00 ")
        Console.WriteLine("You may enter [stop] or [STOP] to exit console data entry mode. ")

        While input.ToUpper <> "STOP"

            input = Console.ReadLine

            If input.ToUpper <> "STOP" Then
                Exit While
            End If
        End While

        FileClose(1)
    End Sub

    Private Sub btnSetUsername_Click(sender As Object, e As EventArgs) Handles btnSetUsername.Click
        userName = txtUsername.Text
        usernameHasBeenSet = True

        refreshControls()
    End Sub

    Private Sub btnBulkGenerate_Click(sender As Object, e As EventArgs) Handles btnBulkGenerate.Click

        ' If file does not exist, create it, otherwise just append to it
        If IO.File.Exists(filenameAndPath) Then
            FileOpen(1, filenameAndPath, OpenMode.Append)
        Else
            FileOpen(1, filenameAndPath, OpenMode.Output)
        End If

        fileOutput(Int(txtIterations.Text), True)

        FileClose(1)
    End Sub

    Private Sub btnAddDatapoint_Click(sender As Object, e As EventArgs) Handles btnAddDatapoint.Click
        ' If file does not exist, create it, otherwise just append to it
        If IO.File.Exists(filenameAndPath) Then
            FileOpen(1, filenameAndPath, OpenMode.Append)
        Else
            FileOpen(1, filenameAndPath, OpenMode.Output)
        End If

        fileOutput(1, False)

        FileClose(1)
    End Sub
End Class
