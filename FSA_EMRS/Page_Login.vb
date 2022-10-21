Imports FSA_EMRS.DatabaseLibrary

Public Class Page_Login
    'If the user clicks the cancel button
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        frm_MainWindow.ShowPage(Pages.Index)
    End Sub

    'Check if the user has left any fields empty
    Private Function CheckEmpty() As Boolean
        Return String.IsNullOrWhiteSpace(txtbx_usrnm.Text) Or String.IsNullOrWhiteSpace(txtbx_psswrd.Text)
    End Function

    'If the user clicks the login button
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        'If the form is not empty
        If Not CheckEmpty() Then
            'If the account does not exist
            If Not CheckAccount(txtbx_usrnm.Text) Then
                MessageBox.Show("The username entry does not exist in the database!", "Error: Account not found", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'The account exists, let's load it into memory
            Dim account As Account = GetAccount(txtbx_usrnm.Text)
            'If th password is incorrect
            If account.password <> txtbx_psswrd.Text Then
                MessageBox.Show("The password you entered is incorrect!", "Error: Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            'If the user as admin privileges
            If account.isAdmin Then
                frm_MainWindow.listPage.LoadUser(account)
                frm_MainWindow.ShowPage(Pages.UserList)
            Else
                frm_MainWindow.recordPage.isAdmin = False
                frm_MainWindow.recordPage.LoadAccountData(account)
            End If
        End If
    End Sub

    'If the login form is displayed
    Private Sub Page_Login_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            txtbx_usrnm.Clear()
            txtbx_psswrd.Clear()
            txtbx_usrnm.Focus()
        End If
    End Sub

    Private Sub lnklbl_help_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnklbl_help.LinkClicked
        Dim details As String = "Need help? Call us at 821-2691 or talk with us at: fr.simplicianoacademy@yahoo.com" + Environment.NewLine + "You can also give us a visit at: Fr. Simpliciano Street, Malacañang Dulo, Barangay Don Bosco, Parañaque City"
        MessageBox.Show(details, "Contact us")
    End Sub
End Class
