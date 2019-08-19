Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        If TxtUserName.Text = "" Then
            MessageBox.Show("Please Enter the UserName")
            TxtUserName.Focus()
        ElseIf TxtPassword.Text = "" Then
            MessageBox.Show("Please Enter the Password")
            TxtPassword.Show()
        ElseIf TxtUserName.Text.ToLower = "admin" And TxtPassword.Text.ToLower = "admin@123" Then
            Form1.Show()
            TxtUserName.Clear()
            TxtPassword.Clear()
            'Here the next step is to hide the login page this is done in load method of a Second form
        Else
            MessageBox.Show("UserName And Password Mismatch")
        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        TxtUserName.Clear()
        TxtPassword.Clear()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()

        'Me.Close() Method will exit from the whole application
    End Sub
End Class