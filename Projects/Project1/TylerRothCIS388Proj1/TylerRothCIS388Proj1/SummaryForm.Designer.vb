<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SummaryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblSummary = New System.Windows.Forms.Label()
        Me.pnpSummaryResults = New System.Windows.Forms.Panel()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.lblDisplayVehiclesTested = New System.Windows.Forms.Label()
        Me.lblDisplayNumberOfTests = New System.Windows.Forms.Label()
        Me.lblDisplayTotalCost = New System.Windows.Forms.Label()
        Me.lblDisplayTotalFuelCellsUsed = New System.Windows.Forms.Label()
        Me.lblDisplayTotalMilesTravelled = New System.Windows.Forms.Label()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.lblTotalFuleCellsUsed = New System.Windows.Forms.Label()
        Me.lblTotalMilesTravelled = New System.Windows.Forms.Label()
        Me.lblVehiclesTested = New System.Windows.Forms.Label()
        Me.lblNumberOfTest = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.pnpSummaryResults.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSummary
        '
        Me.lblSummary.AutoSize = True
        Me.lblSummary.Location = New System.Drawing.Point(13, 34)
        Me.lblSummary.Name = "lblSummary"
        Me.lblSummary.Size = New System.Drawing.Size(53, 13)
        Me.lblSummary.TabIndex = 0
        Me.lblSummary.Text = "Summary:"
        '
        'pnpSummaryResults
        '
        Me.pnpSummaryResults.AutoScroll = True
        Me.pnpSummaryResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnpSummaryResults.Controls.Add(Me.VScrollBar1)
        Me.pnpSummaryResults.Controls.Add(Me.lblDisplayVehiclesTested)
        Me.pnpSummaryResults.Controls.Add(Me.lblDisplayNumberOfTests)
        Me.pnpSummaryResults.Controls.Add(Me.lblDisplayTotalCost)
        Me.pnpSummaryResults.Controls.Add(Me.lblDisplayTotalFuelCellsUsed)
        Me.pnpSummaryResults.Controls.Add(Me.lblDisplayTotalMilesTravelled)
        Me.pnpSummaryResults.Controls.Add(Me.lblTotalCost)
        Me.pnpSummaryResults.Controls.Add(Me.lblTotalFuleCellsUsed)
        Me.pnpSummaryResults.Controls.Add(Me.lblTotalMilesTravelled)
        Me.pnpSummaryResults.Controls.Add(Me.lblVehiclesTested)
        Me.pnpSummaryResults.Controls.Add(Me.lblNumberOfTest)
        Me.pnpSummaryResults.Location = New System.Drawing.Point(12, 50)
        Me.pnpSummaryResults.Name = "pnpSummaryResults"
        Me.pnpSummaryResults.Size = New System.Drawing.Size(260, 148)
        Me.pnpSummaryResults.TabIndex = 1
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Enabled = False
        Me.VScrollBar1.Location = New System.Drawing.Point(240, 0)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(18, 146)
        Me.VScrollBar1.TabIndex = 10
        '
        'lblDisplayVehiclesTested
        '
        Me.lblDisplayVehiclesTested.AutoSize = True
        Me.lblDisplayVehiclesTested.Location = New System.Drawing.Point(89, 12)
        Me.lblDisplayVehiclesTested.Name = "lblDisplayVehiclesTested"
        Me.lblDisplayVehiclesTested.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayVehiclesTested.TabIndex = 9
        '
        'lblDisplayNumberOfTests
        '
        Me.lblDisplayNumberOfTests.AutoSize = True
        Me.lblDisplayNumberOfTests.Location = New System.Drawing.Point(89, -1)
        Me.lblDisplayNumberOfTests.Name = "lblDisplayNumberOfTests"
        Me.lblDisplayNumberOfTests.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayNumberOfTests.TabIndex = 8
        '
        'lblDisplayTotalCost
        '
        Me.lblDisplayTotalCost.AutoSize = True
        Me.lblDisplayTotalCost.Location = New System.Drawing.Point(58, 61)
        Me.lblDisplayTotalCost.Name = "lblDisplayTotalCost"
        Me.lblDisplayTotalCost.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayTotalCost.TabIndex = 7
        '
        'lblDisplayTotalFuelCellsUsed
        '
        Me.lblDisplayTotalFuelCellsUsed.AutoSize = True
        Me.lblDisplayTotalFuelCellsUsed.Location = New System.Drawing.Point(107, 48)
        Me.lblDisplayTotalFuelCellsUsed.Name = "lblDisplayTotalFuelCellsUsed"
        Me.lblDisplayTotalFuelCellsUsed.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayTotalFuelCellsUsed.TabIndex = 6
        '
        'lblDisplayTotalMilesTravelled
        '
        Me.lblDisplayTotalMilesTravelled.AutoSize = True
        Me.lblDisplayTotalMilesTravelled.Location = New System.Drawing.Point(107, 35)
        Me.lblDisplayTotalMilesTravelled.Name = "lblDisplayTotalMilesTravelled"
        Me.lblDisplayTotalMilesTravelled.Size = New System.Drawing.Size(0, 13)
        Me.lblDisplayTotalMilesTravelled.TabIndex = 5
        '
        'lblTotalCost
        '
        Me.lblTotalCost.AutoSize = True
        Me.lblTotalCost.Location = New System.Drawing.Point(0, 61)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(58, 13)
        Me.lblTotalCost.TabIndex = 4
        Me.lblTotalCost.Text = "Total Cost:"
        '
        'lblTotalFuleCellsUsed
        '
        Me.lblTotalFuleCellsUsed.AutoSize = True
        Me.lblTotalFuleCellsUsed.Location = New System.Drawing.Point(-1, 48)
        Me.lblTotalFuleCellsUsed.Name = "lblTotalFuleCellsUsed"
        Me.lblTotalFuleCellsUsed.Size = New System.Drawing.Size(110, 13)
        Me.lblTotalFuleCellsUsed.TabIndex = 3
        Me.lblTotalFuleCellsUsed.Text = "Total Fuel Cells Used:"
        '
        'lblTotalMilesTravelled
        '
        Me.lblTotalMilesTravelled.AutoSize = True
        Me.lblTotalMilesTravelled.Location = New System.Drawing.Point(-1, 35)
        Me.lblTotalMilesTravelled.Name = "lblTotalMilesTravelled"
        Me.lblTotalMilesTravelled.Size = New System.Drawing.Size(108, 13)
        Me.lblTotalMilesTravelled.TabIndex = 2
        Me.lblTotalMilesTravelled.Text = "Total Miles Travelled:"
        '
        'lblVehiclesTested
        '
        Me.lblVehiclesTested.AutoSize = True
        Me.lblVehiclesTested.Location = New System.Drawing.Point(3, 13)
        Me.lblVehiclesTested.Name = "lblVehiclesTested"
        Me.lblVehiclesTested.Size = New System.Drawing.Size(86, 13)
        Me.lblVehiclesTested.TabIndex = 1
        Me.lblVehiclesTested.Text = "Vehicles Tested:"
        '
        'lblNumberOfTest
        '
        Me.lblNumberOfTest.AutoSize = True
        Me.lblNumberOfTest.Location = New System.Drawing.Point(3, 0)
        Me.lblNumberOfTest.Name = "lblNumberOfTest"
        Me.lblNumberOfTest.Size = New System.Drawing.Size(88, 13)
        Me.lblNumberOfTest.TabIndex = 0
        Me.lblNumberOfTest.Text = "Number of Tests:"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(154, 204)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(118, 32)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "&Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'SummaryForm
        '
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 244)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.pnpSummaryResults)
        Me.Controls.Add(Me.lblSummary)
        Me.Name = "SummaryForm"
        Me.Text = "Summary"
        Me.pnpSummaryResults.ResumeLayout(False)
        Me.pnpSummaryResults.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSummary As Label
    Friend WithEvents pnpSummaryResults As Panel
    Friend WithEvents lblDisplayVehiclesTested As Label
    Friend WithEvents lblDisplayNumberOfTests As Label
    Friend WithEvents lblDisplayTotalCost As Label
    Friend WithEvents lblDisplayTotalFuelCellsUsed As Label
    Friend WithEvents lblDisplayTotalMilesTravelled As Label
    Friend WithEvents lblTotalCost As Label
    Friend WithEvents lblTotalFuleCellsUsed As Label
    Friend WithEvents lblTotalMilesTravelled As Label
    Friend WithEvents lblVehiclesTested As Label
    Friend WithEvents lblNumberOfTest As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
