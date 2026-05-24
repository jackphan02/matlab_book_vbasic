Imports System
Imports MathWorks.MATLAB.NET.Arrays
Imports MathWorks.MATLAB.NET.Utility
Imports MatrixComputationsNameSpace

Public Class Form1
  Public arrTextBoxMatrixA(,) As TextBox
  Public db_MatrixA(,) As Double

  Public arrTextBoxMatrixB(,) As TextBox
  Public db_MatrixB(,) As Double

  Public arrTextBoxMatrixC(,) As TextBox
  Public db_MatrixC(,) As Double

  Public m_numRowMatricATextBox As Integer
  Public m_numColMatricATextBox As Integer

  Public m_tbLength As Integer
  Public m_tbHeight As Integer

  Public m_startPoint As Point = New Point()
  Public m_startPointMatrixB As Point = New Point()
  Public m_startPointMatrixC As Point = New Point()

  Public m_numRowMatrixBTextBox As Integer
  Public m_numColMatrixBTextBox As Integer

  Public m_FormLength As Integer
  Public m_FormHeight As Integer

  Public m_numRowMatriCTextBox As Integer
  Public m_numColMatriCTextBox As Integer

  Public Sub New()
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call
    m_startPoint.X = 16
    m_startPoint.Y = 24 + 28 + 120 + 30

    m_numRowMatricATextBox = 5
    m_numColMatricATextBox = 7

    m_numRowMatrixBTextBox = m_numColMatricATextBox
    m_numColMatrixBTextBox = 4

    m_numRowMatriCTextBox = m_numRowMatricATextBox
    m_numColMatriCTextBox = m_numColMatrixBTextBox

    m_tbLength = 38
    m_tbHeight = 20

    Dim adistance As Integer = 50
    ' = length of A + a distance
    m_startPointMatrixB.X = m_startPoint.X + (m_numColMatricATextBox) * _ 
                                             (m_tbLength + 2) - 2 + adistance
    m_startPointMatrixB.Y = m_startPoint.Y

    Dim lbMatrixBlength As Integer = (m_numColMatrixBTextBox) * (m_tbLength + 2) - 2
    m_FormLength = m_startPointMatrixB.X + lbMatrixBlength + adistance
    m_FormHeight = 500

    arrTextBoxMatrixA = New TextBox(m_numRowMatricATextBox, m_numColMatricATextBox) {}
    db_MatrixA = New Double(m_numRowMatricATextBox, m_numColMatricATextBox) {}

    arrTextBoxMatrixB = New TextBox(m_numRowMatrixBTextBox, m_numColMatrixBTextBox) {}
    db_MatrixB = New Double(m_numRowMatrixBTextBox, m_numColMatrixBTextBox) {}

    arrTextBoxMatrixC = New TextBox(m_numRowMatriCTextBox, m_numColMatriCTextBox) {}
    db_MatrixC = New Double(m_numRowMatriCTextBox, m_numColMatriCTextBox) {}

    SetProperty()

  End Sub

  Private Sub btSetNumber_Click(ByVal sender As System.Object, _
              ByVal e As System.EventArgs) Handles btSetNumber.Click

    Dim rowA As Integer
    Dim colA As Integer

    Dim rowB As Integer
    Dim colB As Integer

    Try
      rowA = Convert.ToInt32(tbMatrixA_row.Text)
      colA = Convert.ToInt32(tbMatrixA_col.Text)

      rowB = Convert.ToInt32(tbMatrixB_row.Text)
      colB = Convert.ToInt32(tbMatrixB_col.Text)

    Catch

      MessageBox.Show("Please enter the number")
      Return
    End Try

    ' update row and col of A & B
    m_numRowMatricATextBox = rowA
    m_numColMatricATextBox = colA

    m_numRowMatrixBTextBox = m_numColMatricATextBox
    m_numColMatrixBTextBox = colB

    m_numRowMatriCTextBox = m_numRowMatricATextBox
    m_numColMatriCTextBox = m_numColMatrixBTextBox

    'resize of arrays
    ReDim arrTextBoxMatrixA(rowA, colA)
    ReDim arrTextBoxMatrixB(rowB, colB)
    ReDim arrTextBoxMatrixC(rowA, colB)

    SetProperty()

  End Sub

  Private Sub btCalculation_Click(ByVal sender As System.Object, _
                                  ByVal e As System.EventArgs) Handles btCalculation.Click

    '////////// get matrix A /////////////
    Try
      GetMatrixA()
    Catch

      MessageBox.Show("We have wrong data")
      Return
    End Try

    '////////// get matrix B /////////////
    Try
      GetMatrixB()
    Catch

      MessageBox.Show("We have wrong data")
      Return
    End Try

    '/////////////// calculate matrix C ////////////
    GetMatrixC()

  End Sub

  Public Sub GetMatrixA()

    Dim rowA As Integer
    Dim colA As Integer

    '//////////////////
    Try
      rowA = Convert.ToInt32(tbMatrixA_row.Text)
      colA = Convert.ToInt32(tbMatrixA_col.Text)

    Catch
      MessageBox.Show("Please enter the number")
      Return

    End Try

    '///////////////////
    Dim i, j As Integer

    Try
      For i = 0 To (m_numRowMatricATextBox - 1)
        For j = 0 To (m_numColMatricATextBox - 1)

          db_MatrixA(i, j) = Convert.ToDouble(arrTextBoxMatrixA(i, j).Text)

        Next
      Next

    Catch
      MessageBox.Show("Please enter the number in Matrix A")
      Return
    End Try

  End Sub

  Public Sub GetMatrixB()

    Dim rowB As Integer
    Dim colB As Integer

    '///////////////////
    Try

      rowB = Convert.ToInt32(tbMatrixB_row.Text)
      colB = Convert.ToInt32(tbMatrixB_col.Text)

    Catch
      MessageBox.Show("Please enter the number")
      Return
    End Try

    '///////////////////

    Dim i As Integer
    Dim j As Integer

    Try
      For i = 0 To (m_numRowMatrixBTextBox - 1)

        For j = 0 To (m_numColMatrixBTextBox - 1)

          db_MatrixB(i, j) = Convert.ToDouble(arrTextBoxMatrixB(i, j).Text)
        Next
      Next

    Catch
      MessageBox.Show("Please enter the number in Matrix B")
      Return

    End Try

  End Sub

  Public Sub GetMatrixC()

    ' calculate matrix multiplication

    Dim mw_A As MWNumericArray = New MWNumericArray(db_MatrixA)
    Dim mw_B As MWNumericArray = New MWNumericArray(db_MatrixB)
    Dim mw_C As MWNumericArray = Nothing

    ' call an implemental function
    Dim obj As MatrixComputationsNameSpace.MatrixComputations = _
            New MatrixComputationsNameSpace.MatrixComputations()

    mw_C = obj.mymtimes(mw_A, mw_B)

    ' convert back to double  
    db_MatrixC = mw_C.ToArray(MWArrayComponent.Real)

    ' display to GUI
    Dim i, j As Integer
    For i = 0 To (m_numRowMatriCTextBox - 1)
      For j = 0 To (m_numColMatriCTextBox - 1)

        arrTextBoxMatrixC(i, j).Text = db_MatrixC(i, j).ToString()

      Next
    Next

    MessageBox.Show("It has done")

    mw_A.Dispose()
    mw_B.Dispose()
    mw_C.Dispose()

  End Sub

  Public Sub SetProperty()

    Me.Controls.Clear()

    m_tbLength = 38
    m_tbHeight = 20

    Dim adistance As Integer = 50
    ' = length of A + a distance
    m_startPointMatrixB.X = m_startPoint.X + (m_numColMatricATextBox) * _ 
                                             (m_tbLength + 2) - 2 + adistance
    m_startPointMatrixB.Y = m_startPoint.Y

    Dim lbMatrixBlength As Integer = (m_numColMatrixBTextBox) * (m_tbLength + 2) - 2

    m_startPointMatrixC.X = m_startPoint.X
    Dim aheight_A As Integer = m_startPoint.Y + (m_numRowMatricATextBox) * _ 
                                                (m_tbHeight + 2) + 3 * adistance
    Dim aheight_B As Integer = m_startPoint.Y + (m_numRowMatrixBTextBox) * _ 
                                                (m_tbHeight + 2) + 3 * adistance

    Dim aheight As Integer = Math.Max(aheight_A, aheight_B)
    m_startPointMatrixC.Y = aheight

    ' reset form size
    InitializeComponent()
    tbMatrixA_row.Text = m_numRowMatricATextBox.ToString()
    tbMatrixA_col.Text = m_numColMatricATextBox.ToString()

    tbMatrixB_row.Text = m_numRowMatrixBTextBox.ToString()
    tbMatrixB_col.Text = m_numColMatrixBTextBox.ToString()

    m_numRowMatriCTextBox = m_numRowMatricATextBox
    m_numColMatriCTextBox = m_numColMatrixBTextBox

    SetLabelMatrixA()
    SetLabelMatrixB()
    SetLabelMatrixC()

    ' set calculation button
    Me.btCalculation.Location = New System.Drawing.Point(m_startPoint.X, aheight - 100)

    SetTextBoxMatrixA()
    SetTextBoxMatrixB()
    SetTextBoxMatrixC()

    m_FormLength = m_startPointMatrixB.X + lbMatrixBlength + adistance
    m_FormHeight = m_startPointMatrixC.Y + m_numRowMatriCTextBox * (m_tbHeight + 2) + adistance

    m_FormLength = Math.Max(544, m_FormLength)
    Me.ClientSize = New System.Drawing.Size(m_FormLength, m_FormHeight)

    Me.Refresh()

  End Sub

  Public Sub SetLabelMatrixA()

    Dim lbMatrixA As Label = New System.Windows.Forms.Label()

    Dim lbMatrixAlength As Integer = (m_numColMatricATextBox) * (m_tbLength + 2) - 2
    lbMatrixA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, _
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))
    lbMatrixA.Location = New System.Drawing.Point(m_startPoint.X, m_startPoint.Y - 40)
    lbMatrixA.Size = New System.Drawing.Size(lbMatrixAlength, 28)
    lbMatrixA.Name = "lbMatrixA"
    lbMatrixA.Text = "Matrix A"
    lbMatrixA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter

    Me.Controls.Add(lbMatrixA)

  End Sub

  Public Sub SetLabelMatrixB()

    Dim lbMatrixB As Label = New System.Windows.Forms.Label()
    lbMatrixB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, _
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))

    ' row B = col A
    Dim lbMatrixBlength As Integer = (m_numColMatrixBTextBox) * (m_tbLength + 2) - 2
    lbMatrixB.Location = New System.Drawing.Point( _ 
                                     m_startPointMatrixB.X, m_startPoint.Y - 40)
    lbMatrixB.Size = New System.Drawing.Size(lbMatrixBlength, 28)
    lbMatrixB.Name = "lbMatrixB"
    lbMatrixB.Text = "Matrix B"

    lbMatrixB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.Controls.Add(lbMatrixB)

  End Sub

  Public Sub SetLabelMatrixC()

    Dim lbMatrixC As Label = New System.Windows.Forms.Label()
    lbMatrixC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, _
            System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CByte(0))

    ' row B = col A
    Dim lbMatrixClength As Integer = (m_numColMatriCTextBox) * (m_tbLength + 2) - 2
    lbMatrixC.Location = New System.Drawing.Point( _ 
                                  m_startPointMatrixC.X, m_startPointMatrixC.Y - 40)
    lbMatrixC.Size = New System.Drawing.Size(lbMatrixClength, 28)
    lbMatrixC.Name = "lbMatrixC"
    lbMatrixC.Text = "Matrix C"

    lbMatrixC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
    Me.Controls.Add(lbMatrixC)

  End Sub

  Public Sub SetTextBoxMatrixA()

    Dim i As Integer
    Dim j As Integer

    For i = 0 To (m_numRowMatricATextBox - 1)
      For j = 0 To (m_numColMatricATextBox - 1)

        arrTextBoxMatrixA(i, j) = New System.Windows.Forms.TextBox()
        arrTextBoxMatrixA(i, j).Location = New System.Drawing.Point( _
            m_startPoint.X + (m_tbLength + 2) * j, m_startPoint.Y + (m_tbHeight + 2) * i)
        arrTextBoxMatrixA(i, j).Name = "textBox1"
        arrTextBoxMatrixA(i, j).Size = New System.Drawing.Size(m_tbLength, m_tbHeight)
        arrTextBoxMatrixA(i, j).TabIndex = i
        arrTextBoxMatrixA(i, j).Text = "0.0"
        Me.Controls.Add(arrTextBoxMatrixA(i, j))

      Next
    Next

  End Sub

  Public Sub SetTextBoxMatrixB()

    Dim i As Integer
    Dim j As Integer

    For i = 0 To (m_numRowMatrixBTextBox - 1)
      For j = 0 To (m_numColMatrixBTextBox - 1)

        arrTextBoxMatrixB(i, j) = New System.Windows.Forms.TextBox()
        arrTextBoxMatrixB(i, j).Location = New System.Drawing.Point( _
           m_startPointMatrixB.X + (m_tbLength + 2) * j, m_startPointMatrixB.Y + _ 
                                                         (m_tbHeight + 2) * i)
        arrTextBoxMatrixB(i, j).Name = "textBox2"
        arrTextBoxMatrixB(i, j).Size = New System.Drawing.Size(m_tbLength, m_tbHeight)
        arrTextBoxMatrixB(i, j).TabIndex = i
        arrTextBoxMatrixB(i, j).Text = "0.0"
        Me.Controls.Add(arrTextBoxMatrixB(i, j))

      Next
    Next

  End Sub

  Public Sub SetTextBoxMatrixC()

    Dim i As Integer
    Dim j As Integer

    For i = 0 To (m_numRowMatriCTextBox - 1)
      For j = 0 To (m_numColMatriCTextBox - 1)

        arrTextBoxMatrixC(i, j) = New System.Windows.Forms.TextBox()
        arrTextBoxMatrixC(i, j).Location = New System.Drawing.Point( _
          m_startPointMatrixC.X + (m_tbLength + 2) * j, m_startPointMatrixC.Y + _ 
                                                       (m_tbHeight + 2) * i)
        arrTextBoxMatrixC(i, j).Name = "textBox2"
        arrTextBoxMatrixC(i, j).Size = New System.Drawing.Size(m_tbLength, m_tbHeight)
        arrTextBoxMatrixC(i, j).TabIndex = i
        arrTextBoxMatrixC(i, j).Text = "0.0"
        arrTextBoxMatrixC(i, j).ReadOnly = True
        Me.Controls.Add(arrTextBoxMatrixC(i, j))

      Next
    Next

  End Sub

  Private Sub tbMatrixA_col_TextChanged(ByVal sender As System.Object, _
          ByVal e As System.EventArgs) Handles tbMatrixA_col.TextChanged

    tbMatrixB_row.Text = tbMatrixA_col.Text

  End Sub

  '///////////////////
  '///////////////////
  '///////////////////
End Class
