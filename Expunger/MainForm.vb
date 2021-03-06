﻿Public Class MainForm



    Private Sub buttonExitClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonExit.Click

        Application.Exit()

    End Sub

    Private Sub buttonDeleteClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonDelete.Click


        If comboboxExtensions.Text = "" Then

            ' If the user hasn't selected/written any extension
            ' in the combobox, throw a MsgBox notifying him to enter an extension
            ' for the files to be deleted.
            MsgBox("Enter a file extension to continue...", MsgBoxStyle.Exclamation)
        Else
            Try

                ' Get file extension from the extensions combobox
                Dim fileExtension As String
                fileExtension = comboboxExtensions.Text

                ' Merge the extension from the combobox with the
                ' shell command and execute the whole command in the
                ' folder where the Expunger.exe lies.
                ' The command to delete all files of a particular extension is
                ' del *.extension
                Dim expungeCommand As String
                expungeCommand = "del *." & fileExtension
                Shell("cmd /c " & expungeCommand, vbHide)

            Catch ex As Exception
                MsgBox("Oops! Some Error Occured.", MsgBoxStyle.Critical)
            End Try
        End If


    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboboxExtensions.LostFocus


        If comboboxExtensions.Text = "" Then
            labelExtension.Text = "extension"
        Else
            labelExtension.Text = comboboxExtensions.Text
        End If


    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick

        updateExtensionLabel()

    End Sub

    Private Sub updateExtensionLabel()

        If comboboxExtensions.Text = "" Then
            labelExtension.Text = "extension"
        Else
            labelExtension.Text = comboboxExtensions.Text
        End If

    End Sub

    Private Sub comboboxExtensions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboboxExtensions.SelectedIndexChanged

        updateExtensionLabel()

    End Sub

    Private Sub comboboxExtensions_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboboxExtensions.SelectedValueChanged

        updateExtensionLabel()

    End Sub
End Class
