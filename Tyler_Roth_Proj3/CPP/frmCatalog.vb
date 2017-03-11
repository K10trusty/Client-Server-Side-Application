Public Class frmCatalog
    Dim catalogList As New List(Of clsCatalog)
    Dim courseList As New List(Of clsCourse)
    Dim instructorList As New List(Of clsInstructor)



    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF CatalogS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbCatalogDetail.Hide()
            Me.gbCatalogList.Left = 0
            Me.gbCatalogList.Top = 0
            Me.Width = gbCatalogList.Width + 50
            Me.Height = gbCatalogList.Height + 50

            Me.gbCatalogList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbCatalogList.Hide()
            Me.gbCatalogDetail.Left = 0
            Me.gbCatalogDetail.Top = 0
            Me.Width = gbCatalogDetail.Width + 50
            Me.Height = gbCatalogDetail.Height + 50

            Me.gbCatalogDetail.Visible = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnCancel.PerformClick()
        setMode("D")
        Me.CATALOG_IDTextBox.Focus()
    End Sub

    Private Sub frmCatalog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CPP_DB.dbOpen()
        courseList = CPP_DB.loadCourse()
        CPP_DB.dbClose()

        Dim strCourseList As New List(Of String)
        For Each course As clsCourse In courseList
            strCourseList.Add(course.courseID & " - (" & course.description & ")")
        Next
        COURSE_IDComboBox.DataSource = strCourseList

        CPP_DB.dbOpen()
        instructorList = CPP_DB.loadInstructors()
        CPP_DB.dbClose()

        Dim strInstructorList As New List(Of String)
        For Each instructor As clsInstructor In instructorList
            strInstructorList.Add(instructor.profID & " - (" & instructor.firstName & ", " & instructor.lastName & ")")
        Next

        PROF_IDComboBox.DataSource = strInstructorList

        'TODO: This line of code loads data into the 'CPPDataSet.CPP_COURSES' table. You can move, or remove it, as needed.
        Me.CPP_COURSESTableAdapter.Fill(Me.CPPDataSet.CPP_COURSES)
        'TODO: This line of code loads data into the 'CPPDataSet.CPP_CATALOG' table. You can move, or remove it, as needed.
        Me.CPP_CATALOGTableAdapter.Fill(Me.CPPDataSet.CPP_CATALOG)
        CPP_DB.dbOpen()
        catalogList = CPP_DB.loadCatalog()


        CPP_DB.dbClose()



        If (CPP_DB.dbGetError = "") Then
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If


    End Sub

    Private Sub refreshDataGrid()

        Dim CatalogBindingSource As New BindingSource

        CatalogBindingSource.DataSource = catalogList

        Me.CPP_CATALOGDataGridView.DataSource = CatalogBindingSource
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click


        Dim aCatalog As New clsCatalog

        clsValidator.clearErrors()

        aCatalog.catalogID = Me.CATALOG_IDTextBox.Text
        aCatalog.year = Me.YEARTextBox.Text
        aCatalog.quarter = Me.QUARTERComboBox.Text
        aCatalog.courseID = Me.COURSE_IDComboBox.Text.Split(" ")(0)
        aCatalog.profID = Me.PROF_IDComboBox.Text.Split(" ")(0)

        If (btnSave.Text = "&Save") Then

            CPP_DB.dbOpen()
            CPP_DB.insertCatalog(aCatalog)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                catalogList.Add(aCatalog)
                refreshDataGrid()
                MessageBox.Show("Catalog Saved!")
                Me.setMode("L")
            End If
        Else

            CPP_DB.dbOpen()
            CPP_DB.updateCatalog(aCatalog)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else

                For Each catalog In catalogList
                    If catalog.catalogID = aCatalog.catalogID Then
                        catalogList.Remove(catalog)
                        Exit For
                    End If
                Next
                catalogList.Add(aCatalog)
                refreshDataGrid()
                MessageBox.Show("Catalog Updated!")
                Me.setMode("L")
                Me.btnSave.Text = "&Save"
            End If

        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim row As DataGridViewRow = Me.CPP_CATALOGDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing Selected!")
            Exit Sub
        End If

        Dim aCatalog As clsCatalog = TryCast(row.DataBoundItem, clsCatalog)

        Me.CATALOG_IDTextBox.Text = aCatalog.catalogID
        Me.YEARTextBox.Text = aCatalog.year
        Me.QUARTERComboBox.Text = aCatalog.quarter
        Me.COURSE_IDComboBox.Text = aCatalog.courseID
        Me.PROF_IDComboBox.Text = aCatalog.profID

        Me.CATALOG_IDTextBox.Focus()

        Me.btnSave.Text = "&Update"

        Me.setMode("D")

        refreshDataGrid()

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim row As DataGridViewRow = Me.CPP_CATALOGDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing Selected!")
            Exit Sub
        End If

        Dim aCatalog As clsCatalog = TryCast(row.DataBoundItem, clsCatalog)

        CPP_DB.dbOpen()
        CPP_DB.deleteStudent(aCatalog.catalogID)
        CPP_DB.dbClose()

        If CPP_DB.dbGetError = "" Then
            MessageBox.Show("Catalog Deleted!")

            For Each catalog In catalogList
                If catalog.catalogID = aCatalog.catalogID Then
                    catalogList.Remove(catalog)
                    Exit For
                End If
            Next

            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        For Each ctrl In gbCatalogDetail.Controls
            If TypeOf (ctrl) Is TextBox Then
                TryCast(ctrl, TextBox).Clear()
            End If
        Next

        btnSave.Text = "&Save"

    setMode("L")
       End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strCatalogId As String = InputBox("Enter a Catalog ID")

        For Each row As DataGridViewRow In CPP_CATALOGDataGridView.Rows
            If row.Cells(0).Value = strCatalogId Then
                row.Selected = True
                MessageBox.Show("Found!")
                Exit Sub
            End If
        Next

        MessageBox.Show("Not found!")
    End Sub

End Class