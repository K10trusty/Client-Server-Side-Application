Imports System.Text.RegularExpressions

Public Class clsValidator



    Shared sError As String

    Public Shared Function isValidUnits(ByVal s As String) As Boolean
        Dim coolResults As Integer
        Dim bResult As Boolean

        Try
            If s <> "" AndAlso Integer.TryParse(s, coolResults) = True AndAlso coolResults > 0 Then
                bResult = True
            Else
                addError("Enter in a valid unit number")
            End If
        Catch ex As Exception
            addError("Unit:" & s & " Invalid Unit")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidProfId(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a valid Professor ID")
            End If
        Catch ex As Exception
            addError("Prof ID:" & s & " Invalid Professor")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidFirstName(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a First name")
            End If
        Catch ex As Exception
            addError("First name:" & s & " Invalid First Name")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidLastName(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a Last Name")
            End If
        Catch ex As Exception
            addError("Last name:" & s & " Invalid Last Name")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidPhone(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Dim coolResults As Long

        Try
            If s <> "" AndAlso Long.TryParse(s, coolResults) AndAlso s.Length < 11 AndAlso s.Length > 9 Then
                bResult = True
            Else
                addError("Enter in a 10 digit Phone #")
            End If
        Catch ex As Exception
            addError("Phone:" & s & " Invalid Phone #")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidDepartment(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a Department")
            End If
        Catch ex As Exception
            addError("Department:" & s & " Invalid Department")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidCourseId(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a Course ID")
            End If
        Catch ex As Exception
            addError("Course ID:" & s & " Invalid Course")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidDescription(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a Description")
            End If
        Catch ex As Exception
            addError("Description:" & s & " Invalid Description")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidCatalogId(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a Catalog ID")
            End If
        Catch ex As Exception
            addError("Catalog ID:" & s & " Invalid Catalog")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidYear(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a Year")
            End If
        Catch ex As Exception
            addError("Year:" & s & " Invalid Year")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidQuarter(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a Quarter")
            End If
        Catch ex As Exception
            addError("Quarter:" & s & " Invalid Quarter")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidBroncoId(ByVal s As String) As Boolean
        Dim bResult As Boolean

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in a Bronco ID")
            End If
        Catch ex As Exception
            addError("Bronco ID:" & s & " Invalid Bronco ID")
            bResult = False
        End Try

        Return bResult
    End Function

    Public Shared Function isValidEmail(ByVal s As String) As Boolean
        Dim bResult As Boolean
        Dim emailConformity As String = "^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$"
        Dim emailMatchMaker As Match = Regex.Match(s, emailConformity)

        Try
            If s <> "" Then
                bResult = True
            Else
                addError("Enter in an Email")
            End If

            If emailMatchMaker.Success = True Then
                bResult = True
            Else
                addError("Invalid Email Format")
            End If
        Catch ex As Exception
            addError("Email:" & s & " Invalid Email")
            bResult = False
        End Try

        Return bResult
    End Function


    Public Shared Sub clearErrors()
        sError = ""

    End Sub

    Public Shared Function getError() As String
        Return sError

    End Function

    Public Shared Sub addError(ByVal s As String)

        If sError = "" Then
            sError = s
        Else
            sError += vbCrLf & s
        End If

    End Sub

End Class
