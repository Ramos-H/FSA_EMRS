Public Class DropdownPanel
    Public isPrivate As Boolean = False
    Private Property _editMode As Boolean = False
    Public Property editMode As Boolean
        Get
            Return _editMode
        End Get
        Set(value As Boolean)
            _editMode = value
            ToggleEdit()
        End Set
    End Property

    Private Sub rtxtbx_text_ContentsResized(sender As Object, e As ContentsResizedEventArgs) Handles rtxtbx_text.ContentsResized
        rtxtbx_text.Height = e.NewRectangle.Height
    End Sub

    Private Sub ToggleEdit()
        If _editMode Then
            txtbx_subject.Show()
            btn_remove.Show()
            btn_togglePrivate.Show()
            rtxtbx_text.ReadOnly = False
        Else
            txtbx_subject.Hide()
            btn_remove.Hide()
            btn_togglePrivate.Hide()
            rtxtbx_text.ReadOnly = True
        End If
    End Sub

    Private Sub btn_subject_Click(sender As Object, e As EventArgs) Handles btn_subject.Click
        If _editMode Then
            If rtxtbx_text.Visible Then
                rtxtbx_text.Focus()
            End If
        End If

        rtxtbx_text.Visible = Not rtxtbx_text.Visible
    End Sub

    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Parent.Controls.Remove(Me)
        Me.Dispose()
    End Sub

    Private Sub Italic_Click(sender As Object, e As EventArgs) Handles Italic.Click
        If rtxtbx_text.SelectionFont.Italic Then
            rtxtbx_text.SelectionFont = New Font(rtxtbx_text.SelectionFont, FontStyle.Regular)
        Else
            rtxtbx_text.SelectionFont = New Font(rtxtbx_text.SelectionFont, FontStyle.Italic)
        End If
    End Sub

    Private Sub Bold_Click(sender As Object, e As EventArgs) Handles Bold.Click
        If rtxtbx_text.SelectionFont.Bold Then
            rtxtbx_text.SelectionFont = New Font(rtxtbx_text.SelectionFont, FontStyle.Regular)
        Else
            rtxtbx_text.SelectionFont = New Font(rtxtbx_text.SelectionFont, FontStyle.Bold)
        End If
    End Sub

    Private Sub Underline_Click(sender As Object, e As EventArgs) Handles Underline.Click
        If rtxtbx_text.SelectionFont.Underline Then
            rtxtbx_text.SelectionFont = New Font(rtxtbx_text.SelectionFont, FontStyle.Regular)
        Else
            rtxtbx_text.SelectionFont = New Font(rtxtbx_text.SelectionFont, FontStyle.Underline)
        End If
    End Sub

    Private Sub IncreaseFontSize_Click(sender As Object, e As EventArgs) Handles IncreaseFontSize.Click
        rtxtbx_text.SelectionFont = New Font(rtxtbx_text.SelectionFont, rtxtbx_text.SelectionFont.Size + 1)
    End Sub

    Private Sub DecreaseFontSize_Click(sender As Object, e As EventArgs) Handles DecreaseFontSize.Click
        rtxtbx_text.SelectionFont = New Font(rtxtbx_text.SelectionFont, rtxtbx_text.SelectionFont.Size - 1)
    End Sub

    Private Sub SelectText_Click(sender As Object, e As EventArgs) Handles SelectText.Click
        If rtxtbx_text.SelectedText.Count <> rtxtbx_text.Text.Count Then
            rtxtbx_text.SelectAll()
        Else
            rtxtbx_text.Select(0, 0)
        End If
    End Sub

    Private Sub CutSelection_Click(sender As Object, e As EventArgs) Handles CutSelection.Click
        rtxtbx_text.Cut()
    End Sub

    Private Sub CopySelection_Click(sender As Object, e As EventArgs) Handles CopySelection.Click
        rtxtbx_text.Copy()
    End Sub

    Private Sub PasteText_Click(sender As Object, e As EventArgs) Handles PasteText.Click
        rtxtbx_text.Paste()
    End Sub

    Private Sub ClearAll_Click(sender As Object, e As EventArgs) Handles ClearAll.Click
        rtxtbx_text.Clear()
    End Sub

    Private Sub btn_togglePrivate_Click(sender As Object, e As EventArgs) Handles btn_togglePrivate.Click
        If isPrivate Then
            isPrivate = False
            btn_togglePrivate.BackgroundImage = My.Resources.PassShowImg
        Else
            isPrivate = True
            btn_togglePrivate.BackgroundImage = My.Resources.PassHideImg
        End If
        'add indicator if note is private or not
    End Sub
End Class
