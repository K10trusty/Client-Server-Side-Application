Public Class clsCatalog
    Private strCatalogId As String
    Private strYear As String
    Private strQuarter As String
    Private strCourseId As String
    Private strProfId As String

    Public Property catalogID As String
        Get
            Return strCatalogId
        End Get
        Set(value As String)
            If clsValidator.isValidCatalogId(value) Then
                strCatalogId = value
            End If
        End Set
    End Property

    Public Property year As String
        Get
            Return strYear
        End Get
        Set(value As String)
            If clsValidator.isValidYear(value) Then
                strYear = Long.Parse(value)

                strYear = value
            End If
        End Set
    End Property

    Public Property quarter As String
        Get
            Return strQuarter
        End Get
        Set(value As String)
            If clsValidator.isValidQuarter(value) Then
                strQuarter = value
            End If
        End Set
    End Property

    Public Property courseID As String
        Get
            Return strCourseId
        End Get
        Set(value As String)
            If clsValidator.isValidCourseId(value) Then
                strCourseId = value
            End If
        End Set
    End Property

    Public Property profID As String
        Get
            Return strProfId
        End Get
        Set(value As String)
            If clsValidator.isValidProfId(value) Then
                strProfId = value
            End If
        End Set
    End Property


End Class
