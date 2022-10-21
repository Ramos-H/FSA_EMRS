Imports FSA_EMRS.DatabaseLibrary

Public Class CellButton

    Public userName As String

    Private Sub btn_userCell_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Top
    End Sub

    Private Sub btn_name_Click(sender As Object, e As EventArgs) Handles btn_name.Click
        Dim user As Account = GetAccount(userName)
        frm_MainWindow.recordPage.isAdmin = True
        frm_MainWindow.recordPage.LoadAccountData(user)
    End Sub

    Private Sub chkbx_selected_CheckedChanged(sender As Object, e As EventArgs) Handles chkbx_selected.CheckedChanged
        Dim listPage As Page_UserList = frm_MainWindow.listPage
        listPage.HasCheck()
    End Sub
End Class
