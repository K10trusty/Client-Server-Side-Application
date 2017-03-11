Public Class frmEnrollment
    Dim enrollmentList As New List(Of clsEnrollment)
    Dim studentList As New List(Of clsStudent)
    Dim catalogList As New List(Of clsCatalog)


    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF EnrollmentS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbEnrollmentDetail.Hide()
            Me.gbEnrollmentList.Left = 0
            Me.gbEnrollmentList.Top = 0
            Me.Width = gbEnrollmentList.Width + 50
            Me.Height = gbEnrollmentList.Height + 50

            Me.gbEnrollmentList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbEnrollmentList.Hide()
            Me.gbEnrollmentDetail.Left = 0
            Me.gbEnrollmentDetail.Top = 0
            Me.Width = gbEnrollmentDetail.Width + 50
            Me.Height = gbEnrollmentDetail.Height + 50

            Me.gbEnrollmentDetail.Visible = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnCancel.PerformClick()
        setMode("D")
        Me.BRONCO_IDComboBox.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim anEnrollment As New clsEnrollment

        clsValidator.clearErrors()

        anEnrollment.broncoId = Me.BRONCO_IDComboBox.Text.Split(" ")(0)
        anEnrollment.catalogId = Me.CATALOG_IDComboBox.Text.Split(" ")(0)

        If clsValidator.getError <> "" Then
            MessageBox.Show(clsValidator.getError())
            Exit Sub
        End If


        If (btnSave.Text = "&Save") Then

            CPP_DB.dbOpen()
            CPP_DB.insertEnrollment(anEnrollment)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                enrollmentList.Add(anEnrollment)
                refreshDataGrid()
                MessageBox.Show("Enrollment Saved!")
                Me.setMode("L")
            End If
        Else

            CPP_DB.dbOpen()
            CPP_DB.updateEnrollment(anEnrollment)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else

                For Each enrollment In enrollmentList
                    If enrollment.BroncoId = anEnrollment.BroncoId Then
                        enrollmentList.Remove(enrollment)
                        Exit For
                    End If
                Next
                enrollmentList.Add(anEnrollment)
                refreshDataGrid()
                MessageBox.Show("Enrollment Upadted!")
                Me.setMode("L")
                Me.btnSave.Text = "&Save"
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click

        For Each ctrl In gbEnrollmentDetail.Controls
            If TypeOf (ctrl) Is ComboBox Then
                TryCast(ctrl, ComboBox).ResetText()
            End If
        Next

        btnSave.Text = "&save"

        setMode("L")
    End Sub

    Private Sub frmEnrollment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load students into the combobox
        CPP_DB.dbOpen()
        studentList = CPP_DB.loadStudents()
        CPP_DB.dbClose()

        Dim strStudentList As New List(Of String)
        For Each student As clsStudent In studentList
            strStudentList.Add(student.broncoID & " - (" & student.firstName & "," & student.lastName & ")")
        Next
        BRONCO_IDComboBox.DataSource = strStudentList

        CPP_DB.dbOpen()
        catalogList = CPP_DB.loadCatalog
        CPP_DB.dbClose()

        Dim strCatalogList As New List(Of String)
        For Each catalog As clsCatalog In catalogList
            strCatalogList.Add(catalog.catalogID & " - (" & catalog.year & ", " & catalog.quarter & ", " & catalog.courseID & ")")
        Next

        CATALOG_IDComboBox.DataSource = strCatalogList
        'LOAD FROM DB
        CPP_DB.dbOpen()
        enrollmentList = CPP_DB.loadEnrollment()
        CPP_DB.dbClose()

        'WHEN ENTERING INTO DB MAKE SURE TO GET THE SUBSTRING "-" AND ADD EVERYTHING BEHIND IT

        'CHECK ERRORS
        If (CPP_DB.dbGetError = "") Then
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If
    End Sub

    Private Sub refreshDataGrid()
        'CREATE A BINDING SOURCE AND 
        Dim EnrollmentBindingSource As New BindingSource

        'ASSIGN THE DATAROUCE TO THE STUDENT LIST
        EnrollmentBindingSource.DataSource = enrollmentList

        'SET THE GRID DATASOURCE TO THE BINDING SOURCE
        Me.CPP_ENROLLMENTDataGridView.DataSource = EnrollmentBindingSource

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim row As DataGridViewRow = Me.CPP_ENROLLMENTDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing Selected!")
            Exit Sub
        End If

        Dim anEnrollment As clsEnrollment = TryCast(row.DataBoundItem, clsEnrollment)

        Me.BRONCO_IDComboBox.Text = anEnrollment.BroncoId
        Me.CATALOG_IDComboBox.Text = anEnrollment.CatalogId

        Me.BRONCO_IDComboBox.Focus()

        Me.btnSave.Text = "&Update"

        Me.setMode("D")
        refreshDataGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim row As DataGridViewRow = Me.CPP_ENROLLMENTDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing selected!")
            Exit Sub
        End If

        Dim anEnrollment As clsEnrollment = TryCast(row.DataBoundItem, clsEnrollment)

        CPP_DB.dbOpen()
        CPP_DB.deleteEnrollment(anEnrollment.BroncoId)
        CPP_DB.dbClose()

        If CPP_DB.dbGetError = "" Then
            MessageBox.Show("Enrollment Deleted!")

            For Each enrollment In enrollmentList
                If enrollment.BroncoId = anEnrollment.BroncoId Then
                    enrollmentList.Remove(enrollment)
                    Exit For
                End If
            Next

            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strBroncoId As String = InputBox("Enter Bronco ID")

        For Each row As DataGridViewRow In CPP_ENROLLMENTDataGridView.Rows
            If row.Cells(0).Value = strBroncoId Then
                row.Selected = True
                MessageBox.Show("Found!")
                Exit Sub
            End If
        Next

        MessageBox.Show("Not found!")
    End Sub

End Class