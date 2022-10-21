Imports FSA_EMRS.MedicalRecordLibrary
Imports System.Collections.Generic
Imports FSA_EMRS.DatabaseLibrary

Public Class Page_UserList
    Private current_username As String

    Public Sub LoadUser(user As Account)
        current_username = user.username
        lbl_name.Text = user.userInfo.name.GetCompleteName(5)
        If user.userInfo.userPhoto IsNot Nothing Then
            userPic.BackgroundImage = user.userInfo.userPhoto
        Else
            If user.userInfo.sex = Sex.Female Then
                userPic.BackgroundImage = My.Resources.FemaleProfilePlaceholder
            Else
                userPic.BackgroundImage = My.Resources.MaleProfilePlaceholder
            End If
        End If
    End Sub

    Public Sub LoadList()
        If Not CheckAccountList() Then
            MessageBox.Show("There are no existing accounts to load!", "Error: No Accounts", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        pnl_ListContainer.Controls.Clear()
        Dim accountList() As Account = GetAccountList()
        Dim newCells As New List(Of CellButton)

        For Each user As Account In accountList
            Dim newCell As New CellButton
            newCell.btn_name.Text = user.userInfo.name.GetCompleteName(2)
            newCell.userName = user.username
            newCells.Add(newCell)
        Next

        pnl_ListContainer.Controls.AddRange(newCells.ToArray())
    End Sub

    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_logout.Click
        frm_MainWindow.ShowPage(Pages.Index)
    End Sub

    Private Sub Page_UserList_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        LoadList()
        btn_select.Text = "Select All"
        btn_delete.Visible = False
    End Sub

    Public Function AllChecked()
        For Each element As Control In pnl_ListContainer.Controls
            If element.GetType() Is GetType(CellButton) Then
                Dim button As CellButton = CType(element, CellButton)
                If Not button.chkbx_selected.Checked Then
                    btn_select.Text = "Select None"
                    Return False
                End If
            End If
        Next
        btn_select.Text = "Select All"
        Return True
    End Function

    Public Function HasCheck()
        For Each element As Control In pnl_ListContainer.Controls
            If element.GetType() Is GetType(CellButton) Then
                Dim button As CellButton = CType(element, CellButton)
                If button.chkbx_selected.Checked Then
                    btn_delete.Show()
                    Return True
                End If
            End If
        Next
        btn_delete.Hide()
        Return False
    End Function

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        Dim state As Boolean = AllChecked()
        For Each element As Control In pnl_ListContainer.Controls
            If element.GetType() Is GetType(CellButton) Then
                Dim button As CellButton = CType(element, CellButton)
                button.chkbx_selected.Checked = Not state
            End If
        Next
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MessageBox.Show("Are you sure you want to delete the selected accounts?", "Warning: Delete selected accounts?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            Exit Sub
        End If

        Me.SuspendLayout()
        For Each element As Control In pnl_ListContainer.Controls
            If element.GetType() Is GetType(CellButton) Then
                Dim button As CellButton = CType(element, CellButton)
                If button.chkbx_selected.Checked Then
                    Dim userName As String = button.userName
                    DeleteAccount(userName)
                    If (userName = current_username) Then
                        frm_MainWindow.ShowPage(Pages.Login)
                    End If
                End If
            End If
        Next
        LoadList()
        Me.ResumeLayout()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        pnl_ListContainer.Controls.Clear()
        Dim accountList() As Account = GetAccountList()
        Dim newCells As New List(Of CellButton)

        For Each user As Account In accountList
            If user.userInfo.name.GetCompleteName(1).ToUpper().Contains(txtbx_searchBox.Text.ToUpper()) Then
                Dim newCell As New CellButton
                newCell.btn_name.Text = user.userInfo.name.GetCompleteName(2)
                newCell.userName = user.username
                newCells.Add(newCell)
            End If
        Next

        pnl_ListContainer.Controls.AddRange(newCells.ToArray())
    End Sub
End Class
