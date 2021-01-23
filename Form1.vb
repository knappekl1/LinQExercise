Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim S1 As New Student With {.FirstName = "Bob", .LastName = "Smith", .Grade = "A"}
        Dim S2 As New Student With {.FirstName = "Jane", .LastName = "Stark", .Grade = "B"}
        Dim S3 As New Student With {.FirstName = "Ian", .LastName = "Moth", .Grade = "C"}
        Dim S4 As New Student With {.FirstName = "Shane", .LastName = "Sawyer", .Grade = "F"}

        Dim StudentList As New List(Of Student)({S1, S2, S3, S4})

        Dim Agraders = From student As Student In StudentList 'linq query instantiation
                       Where student.Grade = "A"'condition
                       Select student 'target class, variable

        Dim ABCgraders = From student As Student In StudentList
                         Where student.Grade = "A" Or student.Grade = "B" Or student.Grade = "C"
                         Select student

        Dim Fgraders = From student As Student In StudentList 'linq query instantiation
                       Where student.Grade = "F"'condition
                       Select student 'target class, variable

        'output results
        For Each agr As Student In Agraders
            lbA.Items.Add(agr.ToString)
        Next agr

        For Each abcgr As Student In ABCgraders
            lbABC.Items.Add(abcgr.ToString)
        Next abcgr

        For Each fgr As Student In Fgraders
            lbF.Items.Add(fgr.ToString)
        Next fgr
    End Sub
End Class
