Public Class SecureVariables
    <System.Serializable>
    Public Structure SafeInt
        Private value As Integer
        Private key1 As Integer
        Private key2 As Integer

        Sub New(number As Integer)
            SetValue(number)
        End Sub

        Public Sub SetValue(number As Integer)
            Dim randomizer As New System.Random
            Dim offset = randomizer.Next(10, 10000)
            key2 = offset Mod 2
            key1 = (offset - key2) / 2
            value = number + offset
        End Sub

        Public Function GetValue() As Integer
            Return value - ((key1 * 2) + key2)
        End Function

        Public Overloads Function ToString() As String
            Return GetValue().ToString()
        End Function

        Public Shared Operator +(num1 As SafeInt, num2 As SafeInt) As Integer
            Return num1.GetValue() + num2.GetValue()
        End Operator

        Public Shared Operator -(num1 As SafeInt, num2 As SafeInt) As Integer
            Return num1.GetValue() - num2.GetValue()
        End Operator

        Public Shared Operator *(num1 As SafeInt, num2 As SafeInt) As Integer
            Return num1.GetValue() * num2.GetValue()
        End Operator

        Public Shared Operator /(num1 As SafeInt, num2 As SafeInt) As Integer
            Return num1.GetValue() / num2.GetValue()
        End Operator

        Public Shared Operator Mod(num1 As SafeInt, num2 As SafeInt) As Integer
            Return num1.GetValue() Mod num2.GetValue()
        End Operator
    End Structure
End Class