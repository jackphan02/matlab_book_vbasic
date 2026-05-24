<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.Label4 = New System.Windows.Forms.Label
    Me.Label5 = New System.Windows.Forms.Label
    Me.Label6 = New System.Windows.Forms.Label
    Me.tbMatrixA_row = New System.Windows.Forms.TextBox
    Me.tbMatrixA_col = New System.Windows.Forms.TextBox
    Me.tbMatrixB_row = New System.Windows.Forms.TextBox
    Me.tbMatrixB_col = New System.Windows.Forms.TextBox
    Me.btSetNumber = New System.Windows.Forms.Button
    Me.btCalculation = New System.Windows.Forms.Button
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(79, 35)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(49, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "MatrixA"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(368, 35)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(49, 13)
    Me.Label2.TabIndex = 0
    Me.Label2.Text = "MatrixB"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(12, 61)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(74, 13)
    Me.Label3.TabIndex = 0
    Me.Label3.Text = "number of row"
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label4.Location = New System.Drawing.Point(122, 61)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(91, 13)
    Me.Label4.TabIndex = 0
    Me.Label4.Text = "number of column"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label5.Location = New System.Drawing.Point(288, 61)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(74, 13)
    Me.Label5.TabIndex = 0
    Me.Label5.Text = "number of row"
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label6.Location = New System.Drawing.Point(412, 61)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(91, 13)
    Me.Label6.TabIndex = 0
    Me.Label6.Text = "number of column"
    '
    'tbMatrixA_row
    '
    Me.tbMatrixA_row.Location = New System.Drawing.Point(25, 92)
    Me.tbMatrixA_row.Name = "tbMatrixA_row"
    Me.tbMatrixA_row.Size = New System.Drawing.Size(48, 20)
    Me.tbMatrixA_row.TabIndex = 1
    '
    'tbMatrixA_col
    '
    Me.tbMatrixA_col.Location = New System.Drawing.Point(136, 92)
    Me.tbMatrixA_col.Name = "tbMatrixA_col"
    Me.tbMatrixA_col.Size = New System.Drawing.Size(46, 20)
    Me.tbMatrixA_col.TabIndex = 1
    '
    'tbMatrixB_row
    '
    Me.tbMatrixB_row.Location = New System.Drawing.Point(300, 92)
    Me.tbMatrixB_row.Name = "tbMatrixB_row"
    Me.tbMatrixB_row.ReadOnly = True
    Me.tbMatrixB_row.Size = New System.Drawing.Size(48, 20)
    Me.tbMatrixB_row.TabIndex = 1
    '
    'tbMatrixB_col
    '
    Me.tbMatrixB_col.Location = New System.Drawing.Point(434, 92)
    Me.tbMatrixB_col.Name = "tbMatrixB_col"
    Me.tbMatrixB_col.Size = New System.Drawing.Size(48, 20)
    Me.tbMatrixB_col.TabIndex = 1
    '
    'btSetNumber
    '
    Me.btSetNumber.Location = New System.Drawing.Point(204, 112)
    Me.btSetNumber.Name = "btSetNumber"
    Me.btSetNumber.Size = New System.Drawing.Size(75, 23)
    Me.btSetNumber.TabIndex = 2
    Me.btSetNumber.Text = "Set Number"
    Me.btSetNumber.UseVisualStyleBackColor = True
    '
    'btCalculation
    '
    Me.btCalculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.btCalculation.Location = New System.Drawing.Point(25, 318)
    Me.btCalculation.Name = "btCalculation"
    Me.btCalculation.Size = New System.Drawing.Size(86, 23)
    Me.btCalculation.TabIndex = 3
    Me.btCalculation.Text = "Calculation"
    Me.btCalculation.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(593, 437)
    Me.Controls.Add(Me.btCalculation)
    Me.Controls.Add(Me.btSetNumber)
    Me.Controls.Add(Me.tbMatrixA_col)
    Me.Controls.Add(Me.tbMatrixB_col)
    Me.Controls.Add(Me.tbMatrixB_row)
    Me.Controls.Add(Me.tbMatrixA_row)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.Label4)
    Me.Controls.Add(Me.Label5)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label6 As System.Windows.Forms.Label
  Friend WithEvents tbMatrixA_row As System.Windows.Forms.TextBox
  Friend WithEvents tbMatrixA_col As System.Windows.Forms.TextBox
  Friend WithEvents tbMatrixB_row As System.Windows.Forms.TextBox
  Friend WithEvents tbMatrixB_col As System.Windows.Forms.TextBox
  Friend WithEvents btSetNumber As System.Windows.Forms.Button
  Friend WithEvents btCalculation As System.Windows.Forms.Button

End Class
