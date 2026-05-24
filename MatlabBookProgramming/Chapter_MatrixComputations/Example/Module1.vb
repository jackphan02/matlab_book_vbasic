Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports MatrixComputationsNameSpace
Module Module1

  Sub Main()

    Dim objVB As Example = New Example()

    Console.WriteLine("Matrix Computations")
    Console.WriteLine("Matrix addition")

    objVB.addMatrix()

    Console.WriteLine("Matrix subtraction")
    objVB.subtractMatrix()

    Console.WriteLine("Matrix multiplication")
    objVB.multipleMatrix()

    Console.WriteLine("Matrix determinant")
    objVB.determinantMatrix()

    Console.WriteLine("Inverse matrix")
    objVB.inverseMatrix()

    Console.WriteLine("Transpose matrix")
    objVB.transposeMatrix()


  End Sub

  Public Class Example

    ' ***************************************** 
    Public Sub AddMatrix()

      Dim A(,) As Double = New Double(,) {{1.1, 2.2, 3.3}, {4.4, 5.5, 6.6}, {7.7, 8.8, 9.9}}
      Dim B(,) As Double = New Double(,) {{11, 12, 13}, {14, 15, 16}, {17, 18, 19}}

      ' declare variables 
      Dim mw_A As MWNumericArray = New MWNumericArray(A)
      Dim mw_B As MWNumericArray = New MWNumericArray(B)
      Dim mw_C As MWNumericArray = Nothing

      ' call an implemental function 
      Dim obj As MatrixComputationsNameSpace.MatrixComputations = _
             New MatrixComputationsNameSpace.MatrixComputations()

      mw_C = obj.myplus(mw_A, mw_B)

      ' convert back to double  
      Dim C(,) As Double = mw_C.ToArray(MWArrayComponent.Real)

      'print out  
      Console.WriteLine(ControlChars.Tab + "result=")
      Console.WriteLine("{0}", mw_C)
      Console.WriteLine()

      ' or 
      PrintValues(C)

      ' free memory 
      mw_A.Dispose()
      mw_B.Dispose()
      mw_C.Dispose()

    End Sub

    ' ***************************************** 
    Public Sub SubtractMatrix()

      Dim A(,) As Double = New Double(,) {{1.1, 2.2, 3.3}, {4.4, 5.5, 6.6}, {7.7, 8.8, 9.9}}
      Dim B(,) As Double = New Double(,) {{11, 12, 13}, {14, 15, 16}, {17, 18, 19}}

      ' declare variables 
      Dim mw_A As MWNumericArray = New MWNumericArray(A)
      Dim mw_B As MWNumericArray = New MWNumericArray(B)
      Dim mw_C As MWNumericArray = Nothing

      ' call an implemental function 
      Dim obj As MatrixComputationsNameSpace.MatrixComputations = _
             New MatrixComputationsNameSpace.MatrixComputations()

      mw_C = obj.myminus(mw_A, mw_B)

      ' convert back to double  '
      Dim C(,) As Double = mw_C.ToArray(MWArrayComponent.Real)

      ' print out 
      Console.WriteLine(ControlChars.Tab + "result=")
      Console.WriteLine("{0}", mw_C)
      Console.WriteLine()

      ' or 
      PrintValues(C)

      ' free memory 
      mw_A.Dispose()
      mw_B.Dispose()
      mw_C.Dispose()

    End Sub

    ' ***************************************** 
    Public Sub MultipleMatrix()

      Dim A(,) As Double = New Double(,) {{1.1, 2.2, 3.3, 4.4}, _
                                  {5.5, 6.6, 7.7, 8.8}, _
                                  {9.9, 10.1, 11.11, 12.12}}

      Dim B(,) As Double = New Double(,) {{10, 11}, {12, 13}, {14, 15}, {16, 17}}

      ' declare variables 
      Dim mw_A As MWNumericArray = New MWNumericArray(A)
      Dim mw_B As MWNumericArray = New MWNumericArray(B)
      Dim mw_C As MWNumericArray = Nothing


      ' call an implemental function 
      Dim obj As MatrixComputationsNameSpace.MatrixComputations = _
             New MatrixComputationsNameSpace.MatrixComputations()

      mw_C = obj.mymtimes(mw_A, mw_B)

      ' convert back to double 
      Dim C(,) As Double = mw_C.ToArray(MWArrayComponent.Real)

      ' print out 
      Console.WriteLine(ControlChars.Tab + "result=")
      Console.WriteLine("{0}", mw_C)
      Console.WriteLine()

      ' or 
      PrintValues(C)

      ' free memory 
      mw_A.Dispose()
      mw_B.Dispose()
      mw_C.Dispose()

    End Sub

    ' ***************************************** 
    Public Sub DeterminantMatrix()

      Dim A(,) As Double = New Double(,) {{1.1, 2.2, 3.3}, {7.7, 4.4, 9.9}, {4.4, 5.5, 8.8}}

      ' declare variables */
      Dim mw_A As MWNumericArray = New MWNumericArray(A)
      Dim mw_detA As MWNumericArray = Nothing

      ' call an implemental function 
      Dim obj As MatrixComputationsNameSpace.MatrixComputations = _
             New MatrixComputationsNameSpace.MatrixComputations()

      mw_detA = obj.mydet(mw_A)

      ' convert back to double  
      Dim detA As Double = mw_detA.ToScalarDouble()

      ' print out 
      Console.WriteLine(ControlChars.Tab + "result=")
      Console.WriteLine("{0}", mw_detA)
      Console.WriteLine()

      ' or 
      Console.WriteLine(ControlChars.Tab + "result=")
      Console.WriteLine("{0}", detA)
      Console.WriteLine()

      ' free memory 
      mw_A.Dispose()
      mw_detA.Dispose()

    End Sub

    ' ***************************************** 
    Public Sub InverseMatrix()

      Dim A(,) As Double = New Double(,) {{-1, 1, 2}, {3, -1, 1}, {-1, 3, 4}}

      ' declare variables 
      Dim mw_A As MWNumericArray = New MWNumericArray(A)
      Dim mw_inverseA As MWNumericArray = Nothing

      ' call an implemental function 
      Dim obj As MatrixComputationsNameSpace.MatrixComputations = _
             New MatrixComputationsNameSpace.MatrixComputations()

      mw_inverseA = obj.myinv(mw_A)

      ' convert back to double  
      Dim inverseA(,) As Double = mw_inverseA.ToArray(MWArrayComponent.Real)

      ' print out 
      Console.WriteLine(ControlChars.Tab + "result=")
      Console.WriteLine("{0}", mw_inverseA)
      Console.WriteLine()

      ' or 
      PrintValues(inverseA)

      ' free memory 
      mw_A.Dispose()
      mw_inverseA.Dispose()

    End Sub

    ' ***************************************** 
    Public Sub TransposeMatrix()

      Dim A(,) As Double = New Double(,) {{-1, 1, 2}, {3, -1, 1}, {-1, 3, 4}}

      ' declare variables 
      Dim mw_A As MWNumericArray = New MWNumericArray(A)
      Dim mw_transposeA As MWNumericArray = Nothing

      ' call an implemental function
      Dim obj As MatrixComputationsNameSpace.MatrixComputations = _
             New MatrixComputationsNameSpace.MatrixComputations()

      mw_transposeA = obj.mytranspose(mw_A)

      ' convert back to double 
      Dim transposeA(,) As Double = mw_transposeA.ToArray(MWArrayComponent.Real)

      ' print out 
      Console.WriteLine(ControlChars.Tab + "result=")
      Console.WriteLine("{0}", mw_transposeA)
      Console.WriteLine()

      ' or 
      PrintValues(transposeA)

      ' free memory 
      mw_A.Dispose()
      mw_transposeA.Dispose()

    End Sub

    ' ******************************** 
    Public Sub PrintValues(ByVal myArr As Array)
      Dim myEnumerator As System.Collections.IEnumerator = _
         myArr.GetEnumerator()
      Dim i As Integer = 0
      Dim cols As Integer = myArr.GetLength(myArr.Rank - 1)

      'for row vector or column vector
      If myArr.Rank = 1 Then

        While myEnumerator.MoveNext()
          Console.WriteLine(ControlChars.Tab + "{0}", myEnumerator.Current)
        End While

      Else
        'for other
        While myEnumerator.MoveNext()
          If i < cols Then
            i += 1
          Else
            Console.WriteLine()
            i = 1
          End If
          Console.Write(ControlChars.Tab + "{0}", myEnumerator.Current)
        End While
      End If

      Console.WriteLine()
    End Sub


  End Class

End Module