<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Me.lblProjectName = New System.Windows.Forms.Label()
        Me.lblAuthorName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblProjectName
        '
        Me.lblProjectName.AutoSize = True
        Me.lblProjectName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProjectName.Location = New System.Drawing.Point(12, 27)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(90, 18)
        Me.lblProjectName.TabIndex = 0
        Me.lblProjectName.Text = "Project Halo"
        '
        'lblAuthorName
        '
        Me.lblAuthorName.AutoSize = True
        Me.lblAuthorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblAuthorName.Location = New System.Drawing.Point(12, 45)
        Me.lblAuthorName.Name = "lblAuthorName"
        Me.lblAuthorName.Size = New System.Drawing.Size(127, 18)
        Me.lblAuthorName.TabIndex = 1
        Me.lblAuthorName.Text = "Author: Tyler Roth"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.lblEmail.Location = New System.Drawing.Point(12, 63)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(158, 18)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email: tcroth@cpp.edu"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(191, 106)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(75, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "&OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'FrmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(278, 141)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblAuthorName)
        Me.Controls.Add(Me.lblProjectName)
        Me.Name = "FrmAbout"
        Me.Text = "Contact Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProjectName As Label
    Friend WithEvents lblAuthorName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents btnOk As Button
End Class
