Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports PlusNameSpace

Public Class Form1

  Public TextBoxMatrixA(,) As TextBox
  Public TextBoxMatrixB(,) As TextBox
  Public TextBoxMatrixC(,) As TextBox

  Public StartPoint As Point = New Point()
  Public TextboxLength As Integer
  Public TextboxHeight As Integer

  Public NumRow As Integer = 3
  Public NumCol As Integer = 2

  Public MatrixA_data(,) As Double
  Public MatrixB_data(,) As Double
  Public MatrixC_data(,) As Double

  Public Sub New()
    InitializeComponent()
    InitMatrixes()

  End Sub

  ' *************************** 
  Public Sub InitMatrixes()

    TextBoxMatrixA = New TextBox(NumRow, NumCol) {}
    TextBoxMatrixB = New TextBox(NumRow, NumCol) {}
    TextBoxMatrixC = New TextBox(NumRow, NumCol) {}

    MatrixA_data = New Double(NumRow, NumCol) {}
    MatrixB_data = New Double(NumRow, NumCol) {}
    MatrixC_data = New Double(NumRow, NumCol) {}

    StartPoint.X = 16
    StartPoint.Y = 30

    TextboxLength = 38
    TextboxHeight = 20

    SetTextBoxPositionMatrixA()
    SetTextBoxPositionMatrixB()

    labelPlusSign.Location = New System.Drawing.Point(StartPoint.X - 30, _
                                                        (StartPoint.Y + 24))

    SetTextBoxPositionMatrixC()
    labelEqualSign.Location = New System.Drawing.Point(StartPoint.X - 30, _
                                                         (StartPoint.Y + 24))
  End Sub

  ' *************************** 
  Public Sub SetTextBoxPositionMatrixA()

    Dim i, j As Integer

    For i = 0 To NumRow - 1
      For j = 0 To NumCol - 1

        TextBoxMatrixA(i, j) = New System.Windows.Forms.TextBox()
        TextBoxMatrixA(i, j).Location = New System.Drawing.Point( _
               StartPoint.X + (TextboxLength + 2) * j, StartPoint.Y + (TextboxHeight + 2) * i)
        TextBoxMatrixA(i, j).Name = "textBox1"
        TextBoxMatrixA(i, j).Size = New System.Drawing.Size(TextboxLength, TextboxHeight)
        TextBoxMatrixA(i, j).TabIndex = i
        TextBoxMatrixA(i, j).Text = "0.0"
        Me.Controls.Add(TextBoxMatrixA(i, j))

      Next
    Next

  End Sub

  ' *************************** */
  Public Sub SetTextBoxPositionMatrixB()

    Dim i, j As Integer

    StartPoint.X = StartPoint.X + (NumRow * TextboxLength + 10)

    For i = 0 To NumRow - 1
      For j = 0 To NumCol - 1

        TextBoxMatrixB(i, j) = New System.Windows.Forms.TextBox()
        TextBoxMatrixB(i, j).Location = New System.Drawing.Point( _
               StartPoint.X + (TextboxLength + 2) * j, StartPoint.Y + (TextboxHeight + 2) * i)
        TextBoxMatrixB(i, j).Name = "textBox1"
        TextBoxMatrixB(i, j).Size = New System.Drawing.Size(TextboxLength, TextboxHeight)
        TextBoxMatrixB(i, j).TabIndex = i
        TextBoxMatrixB(i, j).Text = "0.0"
        Me.Controls.Add(TextBoxMatrixB(i, j))

      Next
    Next

  End Sub

  ' *************************** */
  Public Sub SetTextBoxPositionMatrixC()

    Dim i, j As Integer

    StartPoint.X = StartPoint.X + (NumRow * TextboxLength + 10)

    For i = 0 To NumRow - 1
      For j = 0 To NumCol - 1

        TextBoxMatrixC(i, j) = New System.Windows.Forms.TextBox()
        TextBoxMatrixC(i, j).Location = New System.Drawing.Point( _
         StartPoint.X + (TextboxLength + 2) * j, StartPoint.Y + (TextboxHeight + 2) * i)
        TextBoxMatrixC(i, j).Name = "textBox1"
        TextBoxMatrixC(i, j).Size = New System.Drawing.Size(TextboxLength, TextboxHeight)
        TextBoxMatrixC(i, j).TabIndex = i
        TextBoxMatrixC(i, j).Text = "0.0"
        Me.Controls.Add(TextBoxMatrixC(i, j))

      Next
    Next

  End Sub

  ' *************************** */
  Private Sub ButtonMatrixAddition_Click(ByVal sender As System.Object, _ 
            ByVal e As System.EventArgs) Handles ButtonMatrixAddition.Click

    '////////// get matrix A /////////////
    Try
      GetMatrixA()
    Catch
      MessageBox.Show("Data in matrix A is not valid")
      Return
    End Try

    '////////// get matrix B /////////////
    Try
      GetMatrixB()
    Catch
      MessageBox.Show("Data in matrix B is not valid")
      Return
    End Try

    '///////////

    Me.labelCalcInfo.Text = "Calculation is in process. Please wait."
    Me.Invalidate()
    Me.Refresh()

    '  /////////////// calculate matrix C ////////////
    GetMatrixC()

  End Sub

  ' *************************** */
  Public Sub GetMatrixA()

    Dim i, j As Integer

    For i = 0 To (NumRow - 1)
      For j = 0 To (NumCol - 1)

        MatrixA_data(i, j) = Convert.ToDouble(TextBoxMatrixA(i, j).Text)

      Next
    Next

  End Sub

  ' *************************** 
  Public Sub GetMatrixB()

    Dim i, j As Integer

    For i = 0 To (NumRow - 1)
      For j = 0 To (NumCol - 1)

        MatrixB_data(i, j) = Convert.ToDouble(TextBoxMatrixB(i, j).Text)

      Next
    Next
  End Sub

  ' *************************** 
  Public Sub GetMatrixC()

    'calculate matrix multiplication
    Dim mw_A As MWNumericArray = New MWNumericArray(MatrixA_data)
    Dim mw_B As MWNumericArray = New MWNumericArray(MatrixB_data)
    Dim mw_C As MWNumericArray = Nothing

    Dim objMatlab As PlusNameSpace.Plus = New PlusNameSpace.Plus() 

    mw_C = objMatlab.myplus(mw_A, mw_B)

    ' convert back to double  
    MatrixC_data = mw_C.ToArray(MWArrayComponent.Real)

    ' display to GUI
    Dim i, j As Integer
    For i = 0 To (NumRow - 1)
      For j = 0 To (NumCol - 1)

        TextBoxMatrixC(i, j).Text = MatrixC_data(i, j).ToString()

      Next
    Next

    'Show message

    labelCalcInfo.Text = "Calculation has done"

    mw_A.Dispose()
    mw_B.Dispose()
    mw_C.Dispose()

  End Sub

  ' *************************** 
  ' *************************** 
  ' *************************** 
End Class
