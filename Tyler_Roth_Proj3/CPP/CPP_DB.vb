Imports System.Data.SqlClient
Public Class CPP_DB
    Private Shared cn As SqlConnection
    Private Shared strError As String

    Public Shared Function loadStudents() As List(Of clsStudent)
        'List of students that will be returned
        Dim studentList As New List(Of clsStudent)

        'DB variables
        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader

        'clear the errors
        strError = ""

        Try
            strSQL = "Select * From CPP_STUDENTS"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text
            rdr = cmd.ExecuteReader()

            Do While rdr.Read()
                'Add basic student information
                Dim aStudent As New clsStudent
                aStudent.broncoID = rdr("BRONCO_ID")
                aStudent.firstName = rdr("FIRST_NAME")
                aStudent.lastName = rdr("LAST_NAME")
                aStudent.email = rdr("EMAIL")
                aStudent.phone = rdr("PHONE")

                studentList.Add(aStudent)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try
        Return studentList
    End Function

    Public Shared Function deleteStudent(strStudentID As String) As Integer
        'Result that will be returned
        Dim intResult As Integer = 0

        'DB variables
        Dim cmd As New SqlCommand
        Dim strSQL As String

        'Clear errors
        strError = ""

        'Delete from database
        Try
            strSQL = "Delete from CPP_STUDENTS where BRONCO_ID = '" & strStudentID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            If (intResult < 1) Then
                dbAddError("DELETE Failed, Student id " & strStudentID & " was not found!")
            End If

            dbClose()
        Catch ex As Exception
            dbAddError("DELETE Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Sub updateStudent(aStudent As clsStudent)
        strError = ""

        'To update we remove old student and add new student
        'there are other ways to do this as well using the update statement
        deleteStudent(aStudent.broncoID)
        insertStudent(aStudent)

        If strError <> "" Then
            strError = "Could not Update student " & aStudent.broncoID & vbCrLf & vbCrLf & strError
        End If
    End Sub

    Public Shared Function insertStudent(aStudent As clsStudent) As Integer
        'Result that will be returned
        Dim intResult As Integer = 0

        'DB variables
        Dim cmd As New SqlCommand
        Dim strStudentSQL As String

        'clear the errors
        strError = ""

        'insert into database
        Try
            dbConnect()
            strStudentSQL = "INSERT INTO CPP_STUDENTS (BRONCO_ID, FIRST_NAME, LAST_NAME, PHONE, EMAIL) " &
                            "values('" & aStudent.broncoID & "','" & aStudent.firstName & "','" & aStudent.lastName & "','" & aStudent.phone & "', '" &
                            aStudent.email & "')"

            cmd.Connection = cn
            cmd.CommandText = strStudentSQL
            cmd.ExecuteNonQuery()

            dbClose()
        Catch ex As Exception
            dbAddError("Insert Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Function findStudent(strStudentID As String) As clsStudent
        'student that will be returned
        Dim aStudent As clsStudent = New clsStudent
        
        'db variables
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader
        Dim strSQL As String

        'clear error
        strError = ""

        Try
            Dim MyData As New ArrayList

            strSQL = "Select * From CPP_STUDENT Where ID = '" & strStudentID & "'"
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text

            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                aStudent.broncoID = rdr("BRONCO_ID")
                aStudent.firstName = rdr("FIRST_NAME")
                aStudent.lastName = rdr("LAST_NAME")
                aStudent.email = rdr("EMAIL")
                aStudent.phone = rdr("PHONE")
            Else
                dbAddError("Student not found")
            End If

        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try

        Return aStudent
    End Function

    Public Shared Function loadEnrollment() As List(Of clsEnrollment)

        Dim enrollmentList As New List(Of clsEnrollment)

        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader

        strError = ""

        Try
            strSQL = "Select * From CPP_ENROLLMENT"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text
            rdr = cmd.ExecuteReader()

            Do While rdr.Read()

                Dim anErollment As New clsEnrollment
                anErollment.BroncoId = rdr("BRONCO_ID")
                anErollment.catalogId = rdr("CATALOG_ID")

                enrollmentList.Add(anErollment)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try
        Return enrollmentList
    End Function

    Public Shared Function deleteEnrollment(strEnrollmentID As String) As Integer

        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strSQL As String

        strError = ""

        Try
            strSQL = "Delete from CPP_ENROLLMENT where BRONCO_ID = '" & strEnrollmentID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            If (intResult < 1) Then
                dbAddError("DELETE Failed, Enrollment id " & strEnrollmentID & " was not found!")
            End If

            dbClose()
        Catch ex As Exception
            dbAddError("DELETE Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Sub updateEnrollment(anEnrollment As clsEnrollment)
        strError = ""

        deleteEnrollment(anEnrollment.BroncoId)
        insertEnrollment(anEnrollment)

        If strError <> "" Then
            strError = "Could not Update student " & anEnrollment.BroncoId & vbCrLf & vbCrLf & strError
        End If
    End Sub

    Public Shared Function insertEnrollment(anEnrollment As clsEnrollment) As Integer

        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        '    Dim strFKstudents As String
        '  Dim strFKcatalog As String
        Dim strEnrollmentSQL As String

        strError = ""

        Try
            dbConnect()
            'Insert foreign key into students
            '     strFKstudents = "INSERT INTO CPP_STUDENTS (BRONCO_ID, FIRST_NAME, LAST_NAME, PHONE, EMAIL) " &
            '        "values('" & anEnrollment.broncoId & "', ' ', ' ', ' ', ' ') "
            'Insernt foreign key into catalog
            '       strFKcatalog = "INSERT INTO CPP_CATALOG (CATALOG_ID, YEAR,QUARTER, COURSE_ID, PROF_ID) " & "values('" & anEnrollment.catalogId & "', 0, ' ', ' ', ' ') "

            strEnrollmentSQL = "INSERT INTO CPP_ENROLLMENT (BRONCO_ID, CATALOG_ID) " &
                           "values('" & anEnrollment.broncoId & "','" & anEnrollment.catalogId & "')"

            cmd.Connection = cn
            '        cmd.CommandText = strFKstudents  & strFKcatalog & strEnrollmentSQL
            cmd.CommandText = strEnrollmentSQL
            cmd.ExecuteNonQuery()

            dbClose()
        Catch ex As Exception
            dbAddError("Insert Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Function findEnrollment(strEnrollmentID As String) As clsEnrollment

        Dim anEnrollment As clsEnrollment = New clsEnrollment

        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader
        Dim strSQL As String

        strError = ""

        Try
            Dim MyData As New ArrayList

            strSQL = "Select * From CPP_ENROLLMENT Where ID = '" & strEnrollmentID & "'"
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text

            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                anEnrollment.BroncoId = rdr("BRONCO_ID")
                anEnrollment.CatalogId = rdr("CATALOG_ID")
            Else
                dbAddError("Enrollment not found")
            End If

        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try

        Return anEnrollment
    End Function

    Public Shared Function loadCatalog() As List(Of clsCatalog)

        Dim catalogList As New List(Of clsCatalog)

        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader

        strError = ""

        Try
            strSQL = "Select * From CPP_CATALOG"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text
            rdr = cmd.ExecuteReader()

            Do While rdr.Read()

                Dim aCatalog As New clsCatalog
                aCatalog.catalogID = rdr("CATALOG_ID")
                aCatalog.year = rdr("YEAR")
                aCatalog.quarter = rdr("QUARTER")
                aCatalog.courseID = rdr("COURSE_ID")
                aCatalog.profID = rdr("PROF_ID")

                catalogList.Add(aCatalog)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try
        Return catalogList
    End Function

    Public Shared Function deleteCatalog(strCatalogID As String) As Integer

        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strSQL As String

        strError = ""

        Try
            strSQL = "Delete from CPP_CATALOG where CATALOG_ID = '" & strCatalogID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            If (intResult < 1) Then
                dbAddError("DELETE Failed, Catalog id " & strCatalogID & " was not found!")
            End If

            dbClose()

        Catch ex As Exception
            dbAddError("DELETE Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Sub updateCatalog(aCatalog As clsCatalog)
        strError = ""

        If strError <> "" Then
            strError = "Could not Update catalog " & aCatalog.catalogID & vbCrLf & vbCrLf & strError
        End If
    End Sub

    Public Shared Function insertCatalog(aCatalog As clsCatalog) As Integer

        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strCatalogSQL As String

        strError = ""

        Try
            dbConnect()

            strCatalogSQL = "INSERT INTO CPP_CATALOG (CATALOG_ID, YEAR, QUARTER, COURSE_ID, PROF_ID) " &
                "values('" & aCatalog.catalogID & "'," & aCatalog.year & ",'" & aCatalog.quarter & "','" &
             aCatalog.courseID & "','" & aCatalog.profID & "')"

            cmd.Connection = cn
            cmd.CommandText = strCatalogSQL
            cmd.ExecuteNonQuery()

            dbClose()
        Catch ex As Exception
            dbAddError("insert Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Function findCatalog(strCatalogID As String) As clsCatalog

        Dim aCatalog As clsCatalog = New clsCatalog

        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader
        Dim strSQL As String

        strError = ""

        Try
            Dim MyData As New ArrayList

            strSQL = "Select * From CPP_CATALOG Where ID = '" & strCatalogID & "'"
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text

            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                aCatalog.catalogID = rdr("CATALOG_ID")
                aCatalog.year = rdr("YEAR")
                aCatalog.quarter = rdr("QUARTER")
                aCatalog.courseID = rdr("COURSE_ID")
                aCatalog.profID = rdr("PROF_ID")
            Else
                dbAddError("Catalog not found")
            End If

        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try

        Return aCatalog
    End Function

    Public Shared Function loadInstructors() As List(Of clsInstructor)
        Dim instructorList As New List(Of clsInstructor)

        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader

        strError = ""

        Try
            strSQL = "Select * From CPP_INSTRUCTORS"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text
            rdr = cmd.ExecuteReader()

            Do While rdr.Read()

                Dim anInstructor As New clsInstructor
                anInstructor.profID = rdr("PROF_ID")
                anInstructor.firstName = rdr("FIRST_NAME")
                anInstructor.lastName = rdr("LAST_NAME")
                anInstructor.phone = rdr("PHONE")
                anInstructor.department = rdr("DEPARTMENT")

                instructorList.Add(anInstructor)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try
        Return instructorList
    End Function

    Public Shared Function deleteInstructor(strInstructorID As String) As Integer
        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strSQL As String

        strError = ""

        Try
            strSQL = "Delete from CPP_INSTRUCTORS where PROF_ID = '" & strInstructorID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            If (intResult < 1) Then
                dbAddError("DELETE Failed, Instructor id " & strInstructorID & " was not found!")
            End If

            dbClose()
        Catch ex As Exception
            dbAddError("DELETE Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Sub updateInstructor(anInstructor As clsInstructor)
        strError = ""

        deleteInstructor(anInstructor.profID)
        insertInstructor(anInstructor)

        If strError <> "" Then
            strError = "Could not Update Instructor " & anInstructor.profID & vbCrLf & vbCrLf & strError
        End If
    End Sub

    Public Shared Function insertInstructor(anInstructor As clsInstructor) As Integer
        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strInstructorSQL As String

        strError = ""

        Try
            dbConnect()
            strInstructorSQL = "INSERT INTO CPP_INSTRUCTORS (PROF_ID, FIRST_NAME, LAST_NAME, PHONE, DEPARTMENT) " &
                "values('" & anInstructor.profID & "','" & anInstructor.firstName & "','" & anInstructor.lastName & "','" & anInstructor.phone &
                "','" & anInstructor.department & "')"

            cmd.Connection = cn
            cmd.CommandText = strInstructorSQL
            cmd.ExecuteNonQuery()

            dbClose()
        Catch ex As Exception
            dbAddError("Insert Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Function findInstructor(strInstructorID As String) As clsInstructor
        Dim anInstructor As clsInstructor = New clsInstructor

        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader
        Dim strSQL As String

        strError = ""

        Try
            Dim MyData As New ArrayList

            strSQL = "Select * From CPP_INSTRUCTORS Where ID = '" & strInstructorID & "'"
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text

            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                anInstructor.profID = rdr("PROF_ID")
                anInstructor.firstName = rdr("FIRST_NAME")
                anInstructor.lastName = rdr("LAST_NAME")
                anInstructor.phone = rdr("PHONE")
                anInstructor.department = rdr("DEPARTMENT")
            Else
                dbAddError("Instructor not found")
            End If

        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)

        End Try

        Return anInstructor
    End Function

    Public Shared Function loadCourse() As List(Of clsCourse)
        Dim courseList As New List(Of clsCourse)

        Dim strSQL As String
        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader

        strError = ""

        Try
            strSQL = "Select * From CPP_COURSES"

            dbConnect()
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text
            rdr = cmd.ExecuteReader()

            Do While rdr.Read()

                Dim aCourse As New clsCourse
                aCourse.courseID = rdr("COURSE_ID")
                aCourse.description = rdr("DESCRIPTION")
                aCourse.units = rdr("UNITS")

                courseList.Add(aCourse)
            Loop
        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try
        Return courseList
    End Function

    Public Shared Function deleteCourse(strCourseID As String) As Integer
        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strSQL As String

        strError = ""

        Try
            strSQL = "Delete from CPP_COURSES where COURSE_ID = '" & strCourseID & "'"

            dbConnect()
            cmd.Connection = cn
            cmd.CommandText = strSQL

            intResult = cmd.ExecuteNonQuery()

            If (intResult < 1) Then
                dbAddError("DELETE Failed, Course id " & strCourseID & " was not found!")
            End If

            dbClose()
        Catch ex As Exception
            dbAddError("DELETE Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Sub updateCourse(aCourse As clsCourse)
        strError = ""

        deleteCourse(aCourse.courseID)
        insertCourse(aCourse)

        If strError <> "" Then
            strError = "Could not Update course " & aCourse.courseID & vbCrLf & vbCrLf & strError
        End If
    End Sub

    Public Shared Function insertCourse(aCourse As clsCourse) As Integer
        Dim intResult As Integer = 0

        Dim cmd As New SqlCommand
        Dim strCourseSQL As String

        strError = ""

        Try
            dbConnect()
            strCourseSQL = "INSERT INTO CPP_COURSES (COURSE_ID, DESCRIPTION, UNITS) " & "values('" & aCourse.courseID & "','" &
                aCourse.description & "','" & aCourse.units & "')"

            cmd.Connection = cn
            cmd.CommandText = strCourseSQL
            cmd.ExecuteNonQuery()

            dbClose()
        Catch ex As Exception
            dbAddError("Insert Failed " & vbCrLf & ex.Message)
        Finally
            cmd.Dispose()
        End Try

        Return intResult
    End Function

    Public Shared Function findCourse(strCourseID As String) As clsCourse
        Dim aCourse As clsCourse = New clsCourse

        Dim cmd As SqlCommand
        Dim rdr As SqlDataReader
        Dim strSQL As String

        strError = ""

        Try
            Dim MyData As New ArrayList

            strSQL = "Select * From CPP_COURSES Where ID = '" & strCourseID & "'"
            cmd = New SqlCommand(strSQL, cn)
            cmd.CommandType = CommandType.Text

            rdr = cmd.ExecuteReader()
            If rdr.Read() Then
                aCourse.courseID = rdr("COURSE_ID")
                aCourse.description = rdr("DESCRIPTION")
                aCourse.units = rdr("UNITS")
            Else
                dbAddError("Course not found")
            End If

        Catch ex As SqlException
            dbAddError(ex.Message)
        Catch ex As Exception
            dbAddError(ex.Message)
        End Try

        Return aCourse
    End Function

    Public Shared Sub dbOpen()
        'Only assign one reference to the connection
        If IsNothing(cn) Then
            cn = New SqlConnection
            'EXAMPLE OF CONNECTION STRING TO A SQL SERVER INSTANCE
            'cn.ConnectionString = "Data Source=SKYNET\SQLEXPRESS;Initial Catalog=CPP;Integrated Security=True"

            'EXAMPLE OF CONNECTION TO A LOCAL DATABASE FILE. YOU MIGHT NEED TO ADJUST THE CONNECTION STRING
            'BASED ON YOUR PROJECT DATABASE VERSION. 
            cn.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\CPP.mdf;Integrated Security=True"

        End If
    End Sub

    Public Shared Sub dbConnect()
        'Only open if connection is closed
        If cn.State = ConnectionState.Closed Then
            cn.Open()
        End If
    End Sub

    Public Shared Sub dbClose()
        'Only close if open
        If cn.State = ConnectionState.Open Then
            cn.Close()
        End If
    End Sub

    Private Shared Sub dbAddError(ByVal s As String)
        'build error
        If strError = "" Then
            strError = s
        Else
            strError += vbCrLf & s
        End If
    End Sub

    Public Shared Function dbGetError() As String
        'return error
        Return strError
    End Function

End Class
