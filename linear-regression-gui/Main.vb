Option Explicit On

Imports System
Imports System.IO
Imports System.Text

Public Class frmMain


    Public fileCreated As Boolean
    Public outputFileName As String

    ' File and Directory Variables
    Dim userName As String
    Dim outputDirectory As String
    Dim filename As String
    Dim filenameAndPath As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub btnAddDatapoint_Click(sender As Object, e As EventArgs) Handles btnAddDatapoint.Click

    End Sub

    Private Sub refreshControls()

        ' Set Datapoints button will not work until the user has created an output file to use
        If fileCreated = False Then
            With btnAddDatapoint
                .Text = "[No Output File]"
                .Enabled = False
            End With

        Else
            ' Dataset file has not yet been generated


            ' Logic for Create File button in the File Operations group box
            If outputFileName = txtOutputFileName.Text Then
                With btnCreateFile
                    .Text = "Replace Dataset"
                End With
            Else
                With btnCreateFile
                    .Text = "Create New File"
                End With
            End If


            ' User has created a dataset file

            With btnAddDatapoint
                .Text = "Add Datapoint"
                .Enabled = True
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
            ' No file has been created yet, so make one
            createDatasetFile()

        End If
    End Sub

    Private Sub createDatasetFile()

        getFilePathAndDirectory()

        Dim input As String
        input = txtXValue.Text + ", " + txtYValue.Text

        FileOpen(1, filenameAndPath, OpenMode.Append)
        PrintLine(1, input)
        FileClose(1)

    End Sub

    Private Sub fileOutput(ByVal iterations As Int64, ByVal randBulk As Boolean)

        If randBulk = True Then
            Dim counter As Int64
            counter = 0


            Do Until (counter = iterations)


                ' Increase counter
                counter = counter + 1
            Loop

        End If

    End Sub

    Private Sub getFilePathAndDirectory()

        userName = My.User.Name
        outputDirectory = "C:\Users\" + userName + "\Desktop\"
        filename = txtOutputFileName.Text
        filenameAndPath = outputDirectory + filename

    End Sub

End Class
