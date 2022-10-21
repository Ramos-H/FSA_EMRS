Imports FSA_EMRS.DatabaseLibrary
Imports FSA_EMRS.MedicalRecordLibrary

Public Class SubPage_Register1

    Public Function CheckHeightAndWeight() As Boolean
        Dim period As Char = "."
        For Each letter As Char In txtbx_height.Text.ToCharArray()
            If Char.IsLetter(letter) Then
                Return False
            End If
        Next

        For Each letter As Char In txtbx_weight.Text.ToCharArray()
            If Char.IsLetter(letter) Then
                Return False
            End If
        Next

        Return True
    End Function

    'Checks if any parts of the form are unanswered
    Public Function CheckEmpty() As Boolean
        Return String.IsNullOrWhiteSpace(txtbx_firstName.Text) Or String.IsNullOrWhiteSpace(txtbx_middleName.Text) Or String.IsNullOrWhiteSpace(txtbx_lastName.Text) Or
            String.IsNullOrWhiteSpace(txtbx_address.Text) Or String.IsNullOrWhiteSpace(txtbx_height.Text) Or String.IsNullOrWhiteSpace(txtbx_weight.Text)
    End Function

    Public Function GetIdentity() As Identity
        Dim result As New Identity
        result.name.firstName = txtbx_firstName.Text
        result.name.middleName = txtbx_middleName.Text
        result.name.lastName = txtbx_lastName.Text
        result.address = txtbx_address.Text
        result.sex = cmbx_sex.SelectedIndex
        result.birthdate = dtp_bDay.Value
        Return result
    End Function

    Public Function GetMedData() As MedicalRecordData
        Dim medData As New MedicalRecordData
        medData.SetHeight(txtbx_height.Text)
        medData.SetWeight(txtbx_weight.Text)
        medData.bloodType = cmbx_bloodType.SelectedIndex
        Return medData
    End Function

    Public Sub Reset()
        txtbx_firstName.Clear()
        txtbx_middleName.Clear()
        txtbx_lastName.Clear()
        txtbx_address.Clear()
        txtbx_height.Clear()
        txtbx_weight.Clear()

        cmbx_sex.SelectedIndex = 0
        cmbx_bloodType.SelectedIndex = 0

        txtbx_firstName.Focus()
    End Sub

    Private Sub SubPage_Register1_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        If Me.Visible Then
            Me.Dock = DockStyle.Top
            txtbx_firstName.Focus()
        End If
    End Sub
End Class
