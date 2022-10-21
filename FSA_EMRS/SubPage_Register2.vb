Imports System.IO
Imports FSA_EMRS.MedicalRecordLibrary
Imports FSA_EMRS.DatabaseLibrary

Public Class SubPage_Register2
    Private newAccount As New Account
    'If the user clicks on the picture slot
    Private Sub btn_userPic_Click(sender As Object, e As EventArgs) Handles btn_userPic.Click
        Dim fileDialogue As New OpenFileDialog 'Open a window that allows the user to select a file
        fileDialogue.InitialDirectory = Environment.SpecialFolder.DesktopDirectory 'Set the intital directory of the file browser to the Desktop
        fileDialogue.RestoreDirectory = True 'Allow the file browser to open to the last path it was on when it was closed
        fileDialogue.Filter = "Image files|*.png;*.jpg" 'Apply a filter to the file browser so it only shows image files
        'If the user clicks 'OK'
        If fileDialogue.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Check if the file the user chose exists
            If File.Exists(fileDialogue.FileName) Then
                'Set the background image of the picture slot to the image selected
                btn_userPic.BackgroundImage = System.Drawing.Image.FromFile(fileDialogue.FileName)
            End If
        End If
    End Sub

    'Checks if the essential fields of the form are empty
    Public Function CheckEmpty() As Boolean
        Return String.IsNullOrWhiteSpace(txtbx_usrName.Text) Or String.IsNullOrWhiteSpace(txtbx_pass.Text) Or String.IsNullOrWhiteSpace(txtbx_confirmPass.Text)
    End Function

    'Checks if the password and the confirm password fields match
    Public Function ConfirmPass() As Boolean
        If txtbx_pass.Text <> txtbx_confirmPass.Text Then
            MessageBox.Show("The password and confirm password fields don't match!", "Different passwords", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Return True
    End Function

    'Checks if the password is 8 characters long
    Public Function CheckPassLength() As Boolean
        If txtbx_pass.Text.Length < 8 Then
            MessageBox.Show("Your password should be at least 8 characters long!", "Insecure Password!")
            Return False
        End If

        Return True
    End Function

    'Retrieves the login data
    Public Function GetAccount() As Account
        Dim result As New Account
        result.userInfo = New Identity

        If btn_userPic.BackgroundImage IsNot Nothing Then
            result.userInfo.userPhoto = btn_userPic.BackgroundImage
        End If

        result.username = txtbx_usrName.Text
        result.password = txtbx_pass.Text
        result.isAdmin = False

        Return result
    End Function

    'Checks if the form has been filled appropriately
    Public Function ValidateForm() As Boolean
        If CheckEmpty() Then
            Return False
        End If

        If Not CheckPassLength() Then
            Return False
        End If

        If Not ConfirmPass() Then
            Return False
        End If

        Return True
    End Function

    'Shows and hides the text in the password textbox
    Private Sub btn_showPass_Click(sender As Object, e As EventArgs) Handles btn_showPass.Click
        txtbx_pass.UseSystemPasswordChar = Not txtbx_pass.UseSystemPasswordChar
        If btn_showPass.ImageIndex = 0 Then
            btn_showPass.ImageIndex = 1
        Else
            btn_showPass.ImageIndex = 0
        End If
    End Sub

    'Shows and hides the text in the confirm password textbox
    Private Sub btn_showConfirmPass_Click(sender As Object, e As EventArgs) Handles btn_showConfirmPass.Click
        txtbx_confirmPass.UseSystemPasswordChar = Not txtbx_confirmPass.UseSystemPasswordChar
        If btn_showConfirmPass.ImageIndex = 0 Then
            btn_showConfirmPass.ImageIndex = 1
        Else
            btn_showConfirmPass.ImageIndex = 0
        End If
    End Sub

    Private Sub SubPage_Register2_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Me.Dock = DockStyle.Top
            txtbx_usrName.Focus()
        End If
    End Sub

    Public Sub Reset()
        If frm_MainWindow.registerPage.newAccount.userInfo.sex = Sex.Female Then
            btn_userPic.BackgroundImage = My.Resources.FemaleProfilePlaceholder
        Else
            btn_userPic.BackgroundImage = My.Resources.MaleProfilePlaceholder
        End If
        txtbx_usrName.Clear()
        txtbx_pass.Clear()
        txtbx_confirmPass.Clear()
        txtbx_pass.UseSystemPasswordChar = True
        txtbx_confirmPass.UseSystemPasswordChar = True
        btn_showPass.ImageIndex = 0
        btn_showConfirmPass.ImageIndex = 0
    End Sub
End Class
