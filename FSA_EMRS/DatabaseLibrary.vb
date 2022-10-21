Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary

Public Class DatabaseLibrary
    Public Shared appDataPath As String
    Public Shared appDataRoot As String
    Public Shared accountFolderPath As String
    Public Shared userAccountExtension As String = ".acct"

    Public Shared Sub InitializeLibrary()
        appDataPath = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        appDataRoot = System.IO.Directory.CreateDirectory(appDataPath + "\AppData").FullName
        accountFolderPath = System.IO.Directory.CreateDirectory(appDataRoot + "\Accounts").FullName
    End Sub

    <System.Serializable>
    Public Class Name
        Public firstName As String = String.Empty
        Public middleName As String = String.Empty
        Public lastName As String = String.Empty

        Public Function GetCompleteName(format As Integer) As String
            'FORMATS:
            '0 - first last
            '1 - first middle last
            '2 - first m. last
            '3 - last, first
            '4 - last, first middle
            '5 - last, first m.
            '6 - f. m. last
            Dim output As String
            Select Case format
                Case 0
                    output = firstName + " " + lastName
                Case 1
                    output = firstName + " " + middleName + "" + lastName
                Case 2
                    output = firstName + " " + middleName.Chars(0) + ". " + lastName
                Case 3
                    output = lastName + ", " + firstName
                Case 4
                    output = lastName + ", " + firstName + " " + middleName
                Case 5
                    output = lastName + ", " + firstName + " " + middleName.Chars(0) + "."
                Case 6
                    output = firstName.Chars(0) + ". " + middleName.Chars(0) + ". " + lastName
                Case Else
                    output = "Can't determine valid format"
            End Select
            Return output
        End Function

        Public Function GetIncompleteName(index As Integer)
            'INDEX:
            '0 - First Name
            '1 - Last Name
            '2 - Middle Name
            Dim output As String

            If index = 0 Then
                output = firstName
            ElseIf index = 1 Then
                output = lastName
            ElseIf index = 2 Then
                output = middleName
            Else
                output = "Can't determine index"
            End If

            Return output
        End Function
    End Class

    Public Enum Sex
        Male
        Female
    End Enum

    <System.Serializable>
    Public Class Identity
        Public name As New Name
        Public sex As Sex = DatabaseLibrary.Sex.Male
        Public contactNum As String
        Public birthdate As DateTime = Nothing
        Public address As String
        Public userPhoto As Image

        Public Function GetAge() As Integer
            Return CalculateAge(birthdate)
        End Function

        Public Shared Function CalculateAge(newdate As DateTime) As Integer
            Dim age As Integer = 0

            If Date.IsLeapYear(newdate.Year) = True Then 'Check if their birthyear is a leap year
                For currentYear = newdate.Year To Date.Today.Year 'Loops from their birthyear to the current year
                    If Date.IsLeapYear(currentYear) = True Then 'If the current year(in the loop) is a leap year, increment the age
                        age += 1
                    End If
                Next
            Else 'If their birthyear is not a leap year...
                age = Date.Today.Year - newdate.Year
            End If

            ' Checks if the birthday has passed on the current year, if it hasn't then decrement the age.
            If Date.Today.Month = newdate.Month Then
                If Date.Today.Day < newdate.Day Then
                    age -= 1
                End If
            ElseIf Date.Today.Month < newdate.Month Then
                age -= 1
            End If

            Return age
        End Function
    End Class

    <System.Serializable>
    Public Class Account
        Public userInfo As Identity
        Public additionalData As Object
        Public username As String = String.Empty
        Public password As String = String.Empty
        Public isAdmin As Boolean = False
    End Class

    Public Shared Sub SaveAccount(theAccount As Account)
        Dim bFormatter As New BinaryFormatter
        Dim destination As New FileStream(accountFolderPath + "\" + theAccount.username + userAccountExtension, FileMode.Create)
        bFormatter.Serialize(destination, theAccount)
        destination.Close()
    End Sub

    Public Shared Function CheckAccount(username As String) As Boolean
        Return File.Exists(accountFolderPath + "\" + username + userAccountExtension)
    End Function

    Public Shared Function GetAccount(username As String) As Account
        Dim path As String = accountFolderPath + "\" + username + userAccountExtension
        Dim bFormatter As New BinaryFormatter
        Dim destination As New FileStream(path, FileMode.Open)
        Dim theAccount As Account = bFormatter.Deserialize(destination)
        destination.Close()
        Return theAccount
    End Function

    Public Shared Sub DeleteAccount(username As String)
        File.Delete(accountFolderPath + "\" + username + userAccountExtension)
    End Sub

    Public Shared Function CheckAccountList() As Boolean
        Return Directory.GetFiles(accountFolderPath, "*" + userAccountExtension).Length > 0
    End Function

    Public Shared Function GetAccountList() As Account()
        Dim accounts() As String = Directory.GetFiles(accountFolderPath, "*" + userAccountExtension)
        Dim usernames(accounts.Length - 1) As String
        'Remove the path to the folder and the extension
        For index = 0 To accounts.Length - 1
            usernames(index) = Path.GetFileNameWithoutExtension(accounts(index))
        Next

        Dim result(usernames.Length - 1) As Account
        For index = 0 To usernames.Length - 1
            result(index) = GetAccount(usernames(index))
        Next
        Return result
    End Function
End Class
