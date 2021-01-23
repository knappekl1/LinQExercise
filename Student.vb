Public Class Student

    Public Property FirstName As String
    Public Property LastName As String
    Public Property Grade As String


    Public Overrides Function ToString() As String
        Dim result As String = FirstName & " " & LastName & ", " & Grade
        Return result
    End Function
End Class
