Public Class MainForm


    Public location1 As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    'Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ' FolderBrowserDialog1.ShowDialog()

    ' TextBox1.Text = FolderBrowserDialog1.SelectedPath
    '  End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'If TextBox1.Text = "" Or ComboBox1.Text = "" Then
        If comboboxExtensions.Text = "" Then
            MsgBox("Please Choose the Required Details!", MsgBoxStyle.Exclamation)
        Else
            Try
                Dim ext As String
                ext = comboboxExtensions.Text
                'location1 = TextBox1.Text & "\" & "*." & ext

                'MsgBox(location1)

                Dim sYourCommand As String
                sYourCommand = "del *." & ext
                'MsgBox(sYourCommand)
                Shell("cmd /c " & sYourCommand, vbHide)


            Catch ex As Exception
                MsgBox("Oops! Some Error Occured.", MsgBoxStyle.Critical)
            End Try
        End If


    End Sub

    Private Sub ComboBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles comboboxExtensions.LostFocus
        If comboboxExtensions.Text = "" Then
            Label4.Text = "extension"
        Else
            Label4.Text = comboboxExtensions.Text
        End If

    End Sub

    Private Sub Form1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        If comboboxExtensions.Text = "" Then
            Label4.Text = "extension"
        Else
            Label4.Text = comboboxExtensions.Text
        End If


    End Sub
End Class
