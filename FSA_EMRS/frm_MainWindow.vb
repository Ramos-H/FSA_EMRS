Imports FSA_EMRS.MedicalRecordLibrary

Public Class frm_MainWindow
    Public indexPage As New Page_Index
    Public loginPage As New Page_Login
    Public registerPage As New Page_Register
    Public recordPage As New Page_Record
    Public listPage As New Page_UserList

    'Sets up stuff as the form opens
    Private Sub frm_MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddAllPages()
        ShowPage(Pages.Index)
    End Sub

    Public Sub AddAllPages()
        loginPage.Hide()
        registerPage.Hide()
        recordPage.Hide()
        listPage.Hide()
        Dim newControls As Control() = {indexPage, registerPage, loginPage, recordPage, listPage}
        Me.Controls.AddRange(newControls)
    End Sub

    Public Sub ShowPage(pageIndex As Integer)
        Me.SuspendLayout()
        Dim pageToShow As Control

        For Each element As Control In Me.Controls
            element.Dock = DockStyle.None
            element.Hide()
        Next

        Select Case pageIndex
            Case Pages.Index
                pageToShow = indexPage
            Case Pages.Register
                pageToShow = registerPage
            Case Pages.Login
                pageToShow = loginPage
            Case Pages.Record
                pageToShow = recordPage
            Case Pages.UserList
                pageToShow = listPage
            Case Else
                Exit Sub
        End Select

        Dim controlIndex As Integer = Me.Controls.IndexOf(pageToShow)
        Me.Controls(controlIndex).Dock = DockStyle.Fill
        Me.Controls(controlIndex).Visible = True
        Me.ResumeLayout()
        Me.Refresh()
    End Sub
End Class