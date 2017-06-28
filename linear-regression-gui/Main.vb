Public Class frmMain

    ' Variables
    Public outputFileName As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        outputFileName = txtOutputFileName.Text
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
End Class
