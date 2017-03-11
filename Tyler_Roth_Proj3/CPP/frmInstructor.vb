Public Class frmInstructor
    Dim instructorList As New List(Of clsInstructor)

    Public Sub setMode(strMode As String)
        'CONTROL THE DISPLAY OF LIST VS DETAIL OF InstructorS

        If strMode = "L" Then
            'MODE IS LIST

            Me.gbInstructorDetail.Hide()
            Me.gbInstructorList.Left = 0
            Me.gbInstructorList.Top = 0
            Me.Width = gbInstructorList.Width + 50
            Me.Height = gbInstructorList.Height + 50

            Me.gbInstructorList.Visible = True
        Else
            'MODE IS DETAIL

            Me.gbInstructorList.Hide()
            Me.gbInstructorDetail.Left = 0
            Me.gbInstructorDetail.Top = 0
            Me.Width = gbInstructorDetail.Width + 50
            Me.Height = gbInstructorDetail.Height + 50

            Me.gbInstructorDetail.Visible = True
        End If
    End Sub

    Private Sub frmInstructor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CPP_DB.dbOpen()
        instructorList = CPP_DB.loadInstructors()
        CPP_DB.dbClose()

        If (CPP_DB.dbGetError = "") Then
            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If
    End Sub

    Private Sub refreshDataGrid()
        Dim InstructorBindingSource As New BindingSource

        InstructorBindingSource.DataSource = instructorList

        Me.CPP_INSTRUCTORSDataGridView.DataSource = InstructorBindingSource

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnCancel.PerformClick()
        Me.setMode("D")
        Me.PROF_IDTextBox.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim anInstructor As New clsInstructor

        clsValidator.clearErrors()

        anInstructor.profID = Me.PROF_IDTextBox.Text
        anInstructor.firstName = Me.FIRST_NAMETextBox.Text
        anInstructor.lastName = Me.LAST_NAMETextBox.Text
        anInstructor.phone = Me.PHONETextBox.Text
        anInstructor.department = Me.DEPARTMENTTextBox.Text


        If clsValidator.getError <> "" Then
            MessageBox.Show(clsValidator.getError())
            Exit Sub
        End If

        If (btnSave.Text = "&Save") Then

            CPP_DB.dbOpen()
            CPP_DB.insertInstructor(anInstructor)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else
                instructorList.Add(anInstructor)
                refreshDataGrid()
                MessageBox.Show("Instructor Saved!")
                Me.setMode("L")
            End If
        Else

            CPP_DB.dbOpen()
            CPP_DB.updateInstructor(anInstructor)
            CPP_DB.dbClose()

            If CPP_DB.dbGetError <> "" Then
                MessageBox.Show(CPP_DB.dbGetError)
            Else

                For Each instructor In instructorList
                    If instructor.profID = anInstructor.profID Then
                        instructorList.Remove(instructor)
                        Exit For
                    End If
                Next
                instructorList.Add(anInstructor)
                refreshDataGrid()
                MessageBox.Show("Instructor Updated!")
                Me.setMode("L")
                Me.btnSave.Text = "&Save"
            End If
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim row As DataGridViewRow = Me.CPP_INSTRUCTORSDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing Selected!")
            Exit Sub
        End If

        Dim anInstructor As clsInstructor = TryCast(row.DataBoundItem, clsInstructor)

        Me.PROF_IDTextBox.Text = anInstructor.profID
        Me.FIRST_NAMETextBox.Text = anInstructor.firstName
        Me.LAST_NAMETextBox.Text = anInstructor.lastName
        Me.PHONETextBox.Text = anInstructor.phone
        Me.DEPARTMENTTextBox.Text = anInstructor.department

        Me.PROF_IDTextBox.Focus()

        Me.btnSave.Text = "&Update"

        Me.setMode("D")
        refreshDataGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim row As DataGridViewRow = Me.CPP_INSTRUCTORSDataGridView.CurrentRow

        If IsNothing(row) Then
            MessageBox.Show("Nothing selected!")
            Exit Sub
        End If

        Dim anInstructor As clsInstructor = TryCast(row.DataBoundItem, clsInstructor)

        CPP_DB.dbOpen()
        CPP_DB.deleteInstructor(anInstructor.profID)
        CPP_DB.dbClose()

        If CPP_DB.dbGetError = "" Then
            MessageBox.Show("Instructor Deleted!")

            For Each instructor In instructorList
                If instructor.profID = anInstructor.profID Then
                    instructorList.Remove(anInstructor)
                    Exit For
                End If
            Next

            refreshDataGrid()
        Else
            MessageBox.Show(CPP_DB.dbGetError)
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        For Each ctrl In gbInstructorDetail.Controls
            If TypeOf (ctrl) Is TextBox Then
                TryCast(ctrl, TextBox).Clear()
            End If
        Next

        btnSave.Text = "&Save"

        setMode("L")
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim strProfId As String = InputBox("Enter Prof ID")

        For Each row As DataGridViewRow In CPP_INSTRUCTORSDataGridView.Rows
            If row.Cells(0).Value = strProfId Then
                row.Selected = True
                MessageBox.Show("Found!")
                Exit Sub
            End If
        Next

        MessageBox.Show("Not found!")
    End Sub

End Class