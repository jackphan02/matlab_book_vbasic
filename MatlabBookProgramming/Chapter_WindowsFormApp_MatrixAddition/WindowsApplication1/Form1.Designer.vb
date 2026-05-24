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
    Me.ButtonMatrixAddition = New System.Windows.Forms.Button
    Me.Label1 = New System.Windows.Forms.Label
    Me.Label2 = New System.Windows.Forms.Label
    Me.Label3 = New System.Windows.Forms.Label
    Me.labelPlusSign = New System.Windows.Forms.Label
    Me.labelEqualSign = New System.Windows.Forms.Label
    Me.labelCalcInfo = New System.Windows.Forms.Label
    Me.SuspendLayout()
    '
    'ButtonMatrixAddition
    '
    Me.ButtonMatrixAddition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.ButtonMatrixAddition.Location = New System.Drawing.Point(145, 182)
    Me.ButtonMatrixAddition.Name = "ButtonMatrixAddition"
    Me.ButtonMatrixAddition.Size = New System.Drawing.Size(75, 23)
    Me.ButtonMatrixAddition.TabIndex = 0
    Me.ButtonMatrixAddition.Text = "Calculate"
    Me.ButtonMatrixAddition.UseVisualStyleBackColor = True
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label1.Location = New System.Drawing.Point(25, 9)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(49, 13)
    Me.Label1.TabIndex = 1
    Me.Label1.Text = "MatrixA"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label2.Location = New System.Drawing.Point(157, 9)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(49, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "MatrixB"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.Label3.Location = New System.Drawing.Point(282, 9)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(49, 13)
    Me.Label3.TabIndex = 1
    Me.Label3.Text = "MatrixC"
    '
    'labelPlusSign
    '
    Me.labelPlusSign.AutoSize = True
    Me.labelPlusSign.Location = New System.Drawing.Point(94, 64)
    Me.labelPlusSign.Name = "labelPlusSign"
    Me.labelPlusSign.Size = New System.Drawing.Size(13, 13)
    Me.labelPlusSign.TabIndex = 2
    Me.labelPlusSign.Text = "+"
    '
    'labelEqualSign
    '
    Me.labelEqualSign.AutoSize = True
    Me.labelEqualSign.Location = New System.Drawing.Point(247, 64)
    Me.labelEqualSign.Name = "labelEqualSign"
    Me.labelEqualSign.Size = New System.Drawing.Size(13, 13)
    Me.labelEqualSign.TabIndex = 2
    Me.labelEqualSign.Text = "="
    '
    'labelCalcInfo
    '
    Me.labelCalcInfo.AutoSize = True
    Me.labelCalcInfo.Location = New System.Drawing.Point(172, 135)
    Me.labelCalcInfo.Name = "labelCalcInfo"
    Me.labelCalcInfo.Size = New System.Drawing.Size(16, 13)
    Me.labelCalcInfo.TabIndex = 3
    Me.labelCalcInfo.Text = "..."
    Me.labelCalcInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(373, 241)
    Me.Controls.Add(Me.labelCalcInfo)
    Me.Controls.Add(Me.labelEqualSign)
    Me.Controls.Add(Me.labelPlusSign)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Controls.Add(Me.ButtonMatrixAddition)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents ButtonMatrixAddition As System.Windows.Forms.Button
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents labelPlusSign As System.Windows.Forms.Label
  Friend WithEvents labelEqualSign As System.Windows.Forms.Label
  Friend WithEvents labelCalcInfo As System.Windows.Forms.Label

End Class
