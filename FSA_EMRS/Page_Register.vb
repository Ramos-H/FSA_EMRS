Imports FSA_EMRS.DatabaseLibrary
Imports FSA_EMRS.MedicalRecordLibrary

Public Class Page_Register
    Private registerPhase As Integer = 0
    Private subPage1 As New SubPage_Register1
    Private subPage2 As New SubPage_Register2
    Public newAccount As New Account

    Private Sub Page_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnl_subPageContainer.Controls.Add(subPage1)
        pnl_subPageContainer.Controls.Add(subPage2)
    End Sub

    'Changes which subpage to show
    Private Sub ChangeSubPage(ByVal subPageIndex As Integer, Optional ByVal clear As Boolean = False)
        Me.SuspendLayout()
        Select Case subPageIndex
            Case 0
                If clear Then
                    subPage1.Reset()
                End If
                subPage2.Hide()
                subPage1.Show()
                btn_cancel.Text = "Cancel"
                btn_ok.Text = "Next"
            Case 1
                subPage1.Hide()
                subPage2.Reset()
                subPage2.Show()
                btn_cancel.Text = "Back"
                btn_ok.Text = "Register"
            Case Else
                Exit Sub
        End Select
        Me.ResumeLayout()
        Me.Refresh()
    End Sub

    'If the user clicks the cancel button
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        If registerPhase = 0 Then
            If Not subPage1.CheckEmpty() Then
                If DialogResult.No = MessageBox.Show("Are you sure you want to cancel your registration?", "Confirmation", MessageBoxButtons.YesNo) Then
                    Exit Sub
                End If
                subPage1.Reset()
            End If

            frm_MainWindow.ShowPage(Pages.Index)
        Else
            ChangeSubPage(0)
            registerPhase -= 1
        End If
    End Sub

    'If the user clicks the OK/Next/Register button 
    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click
        If registerPhase = 0 Then
            If subPage1.CheckEmpty() Then
                MessageBox.Show("One of the fields are unfilled!", "Error: Incomplete information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If Not subPage1.CheckHeightAndWeight() Then
                MessageBox.Show("Please enter numbers only for the height and weight fields!", "Error: Incorrect Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            newAccount.userInfo = subPage1.GetIdentity()
            newAccount.additionalData = subPage1.GetMedData()
            ChangeSubPage(1)
            registerPhase += 1
        Else
            If subPage2.ValidateForm() Then
                Dim accountData As Account = subPage2.GetAccount()
                newAccount.username = accountData.username
                newAccount.password = accountData.password
                newAccount.isAdmin = accountData.isAdmin
                newAccount.userInfo.userPhoto = accountData.userInfo.userPhoto
                SaveAccount(newAccount)

                subPage1.Reset()
                subPage2.Reset()

                frm_MainWindow.recordPage.LoadAccountData(GetAccount(newAccount.username))
            End If
        End If
    End Sub

    Private Sub Page_Register_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        ChangeSubPage(0, True)
    End Sub
End Class
