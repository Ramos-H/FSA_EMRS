Imports FSA_EMRS.MedicalRecordLibrary
Imports FSA_EMRS.DatabaseLibrary
Imports FSA_EMRS.MedicalRecordLibrary.MedicalRecordData

Public Class Page_Record
    Private Property _state As Integer = 0 '(0 = View Mode | 1 = Edit Mode | 2 = Advanced Edit Mode)
    Public Property state As Integer
        Get
            Return _state
        End Get
        Set(value As Integer)
            _state = value
            ToggleState()
        End Set
    End Property
    Public isAdmin As Boolean = False
    Public previousPageIndex As Integer = Pages.Login
    Private loadedAccount As Account

    'Loads the data in the account
    Public Sub LoadAccountData(account As Account)
        loadedAccount = account
        'Personal Info
        'Name
        lbl_name.Text = account.userInfo.name.GetCompleteName(4)
        txtbx_firstName.Text = account.userInfo.name.firstName
        txtbx_middleName.Text = account.userInfo.name.middleName
        txtbx_lastName.Text = account.userInfo.name.lastName
        lbl_age.Text = account.userInfo.GetAge() 'Age
        'Sex
        lbl_sex.Text = account.userInfo.sex.ToString()
        cmbx_sex.SelectedIndex = account.userInfo.sex
        'Birthday
        lbl_bDay.Text = account.userInfo.birthdate.ToString("MMMM dd, yyyy")
        dtp_bDay.Value = account.userInfo.birthdate
        'Address
        lbl_address.Text = account.userInfo.address
        txtbx_address.Text = account.userInfo.address
        'Medical Info
        Dim medicalData As MedicalRecordData = CType(account.additionalData, MedicalRecordData) 'Gets the medical record data of the account
        'Height
        lbl_height.Text = medicalData.heightInFeet.ToString() + "FT"
        txtbx_height.Text = medicalData.heightInFeet.ToString()
        'Weight
        lbl_weight.Text = medicalData.weightInKilos.ToString() + "KG"
        txtbx_weight.Text = medicalData.weightInKilos.ToString()
        'Blood Type
        lbl_bloodType.Text = medicalData.GetBloodType()
        cmbx_bloodType.SelectedIndex = medicalData.bloodType
        'If the user has a photo
        If account.userInfo.userPhoto IsNot Nothing Then
            btn_userPic.BackgroundImage = account.userInfo.userPhoto 'Display the user photo
        Else 'If they don't
            'Display the placeholder profiles based on their sex
            If account.userInfo.sex = Sex.Female Then
                btn_userPic.BackgroundImage = My.Resources.FemaleProfilePlaceholder 'Female
            Else
                btn_userPic.BackgroundImage = My.Resources.MaleProfilePlaceholder 'Male
            End If
        End If
        'Load the medical notes
        For index = 0 To 4
            ClearNoteList(pnl_diseases) 'Clear the "Known Diseases" Note Container
            ClearNoteList(pnl_medication) 'Clear the "Medication" Note Container
            ClearNoteList(pnl_notes) 'Clear the "Other Notes" Note Container
        Next
        'Known Diseases
        If medicalData.knownDiseases.Count > 0 Then
            PopulateNoteContainer(pnl_diseases, medicalData.knownDiseases)
            ShowHidePrivateNotes(pnl_diseases, False)
            lbl_noDisease.Hide()
        Else
            lbl_noDisease.Show()
        End If
        'Medication
        If medicalData.medication.Count > 0 Then
            PopulateNoteContainer(pnl_medication, medicalData.medication)
            ShowHidePrivateNotes(pnl_medication, False)
            lbl_noMedication.Hide()
        Else
            lbl_noMedication.Show()
        End If
        'Other Notes
        If medicalData.notes.Count > 0 Then
            PopulateNoteContainer(pnl_notes, medicalData.notes)
            ShowHidePrivateNotes(pnl_notes, False)
            lbl_noNotes.Hide()
        Else
            lbl_noNotes.Show()
        End If

        pnl_diseases.Hide()
        pnl_medication.Hide()
        pnl_notes.Hide()

        If isAdmin Then
            btn_edit.Show()
            btn_cancel.Text = "Cancel"
        Else
            btn_edit.Hide()
            btn_cancel.Text = "Log out"
        End If

        'Account Data
        txtbx_username.Text = account.username
        txtbx_password.Text = account.password
        frm_MainWindow.ShowPage(Pages.Record)
    End Sub

    'Makes sure controls are removed properly from memory
    Private Sub DisposeControl(ByRef control As Control)
        control.Parent.Controls.Remove(control)
        control.Dispose()
    End Sub

    'Clears the Medical Note Containers
    Private Sub ClearNoteList(ByRef container As Panel)
        For Each ctrl As Control In container.Controls
            If ctrl.GetType() Is GetType(DropdownPanel) Then
                DisposeControl(ctrl)
            End If
        Next
    End Sub

    'Populates the Medical Note Containers
    Private Sub PopulateNoteContainer(ByRef container As Panel, ByRef notes As List(Of DropdownNoteData))
        Dim dropdowns As New List(Of DropdownPanel)
        For Each note As DropdownNoteData In notes
            Dim newDropdown As New DropdownPanel
            newDropdown.btn_subject.Text = note.subject
            newDropdown.txtbx_subject.Text = note.subject
            newDropdown.rtxtbx_text.Rtf = note.content
            newDropdown.Dock = DockStyle.Top
            dropdowns.Add(newDropdown)
        Next
        container.Controls.AddRange(dropdowns.ToArray())
    End Sub

    'Shows or hides private notes
    Private Sub ShowHidePrivateNotes(ByRef container As Panel, state As Boolean)
        For Each ctrl As Control In container.Controls
            If ctrl.GetType() Is GetType(DropdownPanel) Then
                Dim dropdown As DropdownPanel = CType(ctrl, DropdownPanel)
                If dropdown.isPrivate Then
                    ctrl.Visible = state
                End If
            End If
        Next
    End Sub

    Private Sub ToggleEditDropdown(ByRef container As Panel, state As Boolean)
        For Each ctrl As Control In container.Controls
            If ctrl.GetType() Is GetType(DropdownPanel) Then
                Dim dropdown As DropdownPanel = CType(ctrl, DropdownPanel)
                dropdown.editMode = state
            End If
        Next
    End Sub

    'Changes how the user sees and interacts with the record page
    Private Sub ToggleState()
        'VIEW MODE
        If _state = 0 Then
            'Name
            flp_name.Show()
            flp_editName.Hide()
            'Sex
            lbl_sex.Show()
            cmbx_sex.Hide()
            'Birthday
            lbl_bDay.Show()
            dtp_bDay.Hide()
            'Address
            lbl_address.Show()
            txtbx_address.Hide()
            'Height
            lbl_height.Show()
            txtbx_height.Hide()
            'Weight
            lbl_weight.Show()
            txtbx_weight.Hide()
            'Blood Type
            lbl_bloodType.Show()
            cmbx_bloodType.Hide()
            'Account Details
            gbx_acctDetails.Hide()
            'Edit Button
            btn_edit.Show()
            'Save Button
            btn_save.Hide()
            'Delete Button
            btn_delete.Hide()

            btn_addDisease.Hide()
            btn_addMedication.Hide()
            btn_addNotes.Hide()
            Exit Sub
        End If

        'EDIT MODE
        'Name
        flp_editName.Show()
        flp_name.Hide()
        'Sex
        cmbx_sex.Show()
        lbl_sex.Hide()
        'Birthday
        dtp_bDay.Show()
        lbl_bDay.Hide()
        'Address
        txtbx_address.Show()
        lbl_address.Hide()
        'Height
        txtbx_height.Show()
        lbl_height.Hide()
        'Weight
        txtbx_weight.Show()
        lbl_weight.Hide()
        'Blood Type
        cmbx_bloodType.Show()
        lbl_bloodType.Hide()
        'Account Details
        gbx_acctDetails.Show()
        'Edit Button
        btn_edit.Hide()
        'Save Button
        btn_save.Show()

        'ADVANCED EDIT MODE
        If state > 1 Then
            ShowHidePrivateNotes(pnl_diseases, True)
            ShowHidePrivateNotes(pnl_medication, True)
            ShowHidePrivateNotes(pnl_notes, True)
            btn_addDisease.Show()
            btn_addMedication.Show()
            btn_addNotes.Show()
            ToggleEditDropdown(pnl_diseases, True)
            ToggleEditDropdown(pnl_medication, True)
            ToggleEditDropdown(pnl_notes, True)
            'Delete button
            btn_delete.Show()
        End If
    End Sub

    'Shows or hides the containers for the Medical Notes
    Private Sub ShowHidelist(list As Panel)
        list.Visible = Not list.Visible
    End Sub

    Private Sub ShowHideDiseaseList(sender As Object, e As EventArgs) Handles btn_diseases.Click
        ShowHidelist(pnl_diseases)
    End Sub

    Private Sub ShowHideMedication(sender As Object, e As EventArgs) Handles btn_medication.Click
        ShowHidelist(pnl_medication)
    End Sub

    Private Sub ShowHideNotes(sender As Object, e As EventArgs) Handles btn_notes.Click
        ShowHidelist(pnl_notes)
    End Sub

    Private Sub CancelButton(sender As Object, e As EventArgs) Handles btn_cancel.Click
        If state = 0 Then
            If isAdmin Then
                frm_MainWindow.ShowPage(Pages.UserList)
            Else
                frm_MainWindow.ShowPage(Pages.Login)
            End If
        Else
                state = 0
            LoadAccountData(GetAccount(loadedAccount.username))
        End If
    End Sub

    Private Sub ChooseNewPic(sender As Object, e As EventArgs) Handles btn_userPic.Click
        If state = 0 Then
            Exit Sub
        Else
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
        End If
    End Sub

    Private Sub EditButton(sender As Object, e As EventArgs) Handles btn_edit.Click
        If isAdmin Then
            state = 2
        Else
            state = 1
        End If
    End Sub

    Private Sub DeleteButton(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MessageBox.Show("Are you sure you want to delete this account?", "Confirmation: Account Deletion", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            DeleteAccount(loadedAccount.username)
            frm_MainWindow.ShowPage(Pages.UserList)
        End If
    End Sub

    Private Sub SaveButton(sender As Object, e As EventArgs) Handles btn_save.Click
        Dim newAccountData As New Account
        newAccountData.username = txtbx_username.Text
        newAccountData.password = txtbx_password.Text
        newAccountData.isAdmin = loadedAccount.isAdmin

        newAccountData.userInfo = New Identity
        newAccountData.userInfo.name.firstName = txtbx_firstName.Text
        newAccountData.userInfo.name.middleName = txtbx_middleName.Text
        newAccountData.userInfo.name.lastName = txtbx_lastName.Text
        newAccountData.userInfo.sex = cmbx_sex.SelectedIndex
        newAccountData.userInfo.birthdate = dtp_bDay.Value
        newAccountData.userInfo.address = txtbx_address.Text
        newAccountData.userInfo.userPhoto = btn_userPic.BackgroundImage

        Dim newMedicalData As New MedicalRecordData
        newMedicalData.SetHeight(txtbx_height.Text)
        newMedicalData.SetWeight(txtbx_weight.Text)
        newMedicalData.bloodType = cmbx_bloodType.SelectedIndex

        If pnl_diseases.Controls.Count > 2 Then
            newMedicalData.knownDiseases = GetMedicalNotes(pnl_diseases)
        End If

        If pnl_medication.Controls.Count > 2 Then
            newMedicalData.medication = GetMedicalNotes(pnl_medication)
        End If

        If pnl_notes.Controls.Count > 2 Then
            newMedicalData.notes = GetMedicalNotes(pnl_notes)
        End If

        newAccountData.additionalData = newMedicalData

        If isAdmin Then
            DeleteAccount(loadedAccount.username)
            SaveAccount(newAccountData)
            LoadAccountData(GetAccount(newAccountData.username))
            state = 0
        Else
            'Add request change notif for admin here
        End If
    End Sub

    Private Function GetMedicalNotes(ByRef container As Panel) As List(Of DropdownNoteData)
        Dim result As New List(Of DropdownNoteData)

        For Each ctrl As Control In container.Controls
            If ctrl.GetType() Is GetType(DropdownPanel) Then
                Dim dropdown As DropdownPanel = CType(ctrl, DropdownPanel)
                Dim newData As New DropdownNoteData

                If String.IsNullOrWhiteSpace(dropdown.txtbx_subject.Text) Then
                    Continue For
                End If

                newData.subject = dropdown.txtbx_subject.Text
                newData.content = dropdown.rtxtbx_text.Rtf
                newData.isPrivate = dropdown.isPrivate
                result.Add(newData)
            End If
        Next

        Return result
    End Function

    Private Sub AddMedicalNote(ByRef container As Panel)
        lbl_noDisease.Show()
        lbl_noMedication.Show()
        lbl_noNotes.Show()

        Dim newNote As New DropdownPanel
        newNote.editMode = True
        newNote.Dock = DockStyle.Top
        container.Controls.Add(newNote)

        If container.Controls.Count > 2 Then
            If container.Name = "pnl_diseases" Then
                lbl_noDisease.Hide()
            ElseIf container.Name = "pnl_medication" Then
                lbl_noMedication.Hide()
            Else
                lbl_noNotes.Hide()
            End If
        End If
    End Sub

    Private Sub btn_addDisease_Click(sender As Object, e As EventArgs) Handles btn_addDisease.Click
        AddMedicalNote(pnl_diseases)
    End Sub

    Private Sub btn_addMedication_Click(sender As Object, e As EventArgs) Handles btn_addMedication.Click
        AddMedicalNote(pnl_medication)
    End Sub

    Private Sub btn_addNotes_Click(sender As Object, e As EventArgs) Handles btn_addNotes.Click
        AddMedicalNote(pnl_notes)
    End Sub
End Class
