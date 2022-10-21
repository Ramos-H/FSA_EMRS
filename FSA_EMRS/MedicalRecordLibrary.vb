Imports FSA_EMRS.DatabaseLibrary

Public Class MedicalRecordLibrary
    <System.Serializable>
    Public Class MedicalRecordData

        Public Enum BloodTypes
            A
            A_POSITIVE
            A_NEGATIVE
            B
            B_POSITIVE
            B_NEGATIVE
            AB
            AB_POSITIVE
            AB_NEGATIVE
            O
            O_POSITIVE
            O_NEGATIVE
        End Enum

        <System.Serializable>
        Public Class DropdownNoteData
            Public subject As String
            Public content As String
            Public isPrivate As String
        End Class

        Public heightInFeet As Decimal
        Public weightInKilos As Decimal
        Public bloodType As BloodTypes
        Public knownDiseases As New List(Of DropdownNoteData)
        Public medication As New List(Of DropdownNoteData)
        Public notes As New List(Of DropdownNoteData)

        Public Function GetBloodType() As String
            Return bloodType.ToString().Replace("_POSITIVE", "+").Replace("_NEGATIVE", "-")
        End Function

        Public Function SetHeight(h As String) As Boolean
            Return Decimal.TryParse(h, heightInFeet)
        End Function

        Public Function SetWeight(w As String) As Boolean
            Return Decimal.TryParse(w, weightInKilos)
        End Function
    End Class
End Class
