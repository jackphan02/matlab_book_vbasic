Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports MLApp

' For MATLAB Version 7.9 (2009b) and MATLAB Compiler 4.11
Namespace UtilityMatlabVBAPIVer4p11
  Class MatlabVBAPI

    Dim matlab As MLApp.MLApp = New MLApp.MLApp()

    'Instantiate MATLAB Engine Interface through COM MLApp

    ''* ***************************** 
    ''* ********** I. Scalar ******** 
    ''* ***************************** 
    Public Sub PutScalarReal(ByVal ml_a As String, ByVal a As Double)
      Dim obj_a As Object = CObj(a)

      matlab.PutWorkspaceData(ml_a, "base", obj_a)
    End Sub

    ' *****************************
    Public Sub GetScalarReal(ByVal ml_a As String, ByRef a As Double)
      Dim obj_a As Object = Nothing
      matlab.GetWorkspaceData(ml_a, "base", obj_a)
      a = CDbl(obj_a)
    End Sub

    ' **************************** 
    Public Sub PlusComplexNumbers()

      ' 1. Set number
      Dim aReal As Double = 1.1
      Dim aImag As Double = 101.1

      Dim bReal As Double = 2.2
      Dim bImag As Double = 202.2

      ' 2. Perform tasks in Matlab Workspace
      matlab.PutWorkspaceData("ml_aReal", "base", aReal) 
      matlab.PutWorkspaceData("ml_aImag", "base", aImag) 
      matlab.Execute(" ml_aComp = complex(ml_aReal, ml_aImag) ; ") 

      matlab.PutWorkspaceData("ml_bReal", "base", bReal) 
      matlab.PutWorkspaceData("ml_bImag", "base", bImag) 
      matlab.Execute(" ml_bComp = complex(ml_bReal, ml_bImag) ; ") 

      matlab.Execute(" ml_cComp = ml_aComp + ml_bComp ; " ) 

      matlab.Execute(" ml_cReal = real(ml_cComp) ; ") 
      matlab.Execute(" ml_cImag = imag(ml_cComp) ; ") 

      ' 3. Get data from Matlab Workspace
      Dim obj_cReal As Object = Nothing
      Dim obj_cImag As Object = Nothing
      matlab.GetWorkspaceData("ml_cReal", "base", obj_cReal) 
      matlab.GetWorkspaceData("ml_cImag", "base", obj_cImag) 

      '4. Print out
      Dim cReal As Double = 0
      Dim cImag As Double = 0

      cReal = CDbl(obj_cReal)
      cImag = CDbl(obj_cImag)

      Console.WriteLine("Result of a complex number :")
      Console.WriteLine("Real Part: {0}", cReal.ToString())
      Console.WriteLine("Imag Part: {0}", cImag.ToString())

    End Sub

    ' ******************************** 
    ' *************II. Vector ******** 
    ' ******************************** 
    Public Sub PutVectorReal(ByVal ml_vector As String, ByVal vector As Array)

      Dim dummy As Array = Array.CreateInstance(GetType(Double), vector.Length)
      Array.Clear(dummy, 0, vector.Length)

      matlab.PutFullMatrix(ml_vector, "base", vector, dummy)

    End Sub

    ' ******************************** 
    Public Sub PutVectorComplex(ByVal ml_vectorComplex As String, _ 
                                ByVal vectorReal As Array, ByVal vectorImag As Array)

      matlab.PutFullMatrix(ml_vectorComplex, "base", vectorReal, vectorImag)

    End Sub

    ' ******************************** 
    Public Sub GetVectorReal(ByVal ml_vector As String, ByRef vector As Array)

      Dim dummy As Array = Array.CreateInstance(GetType(Double), vector.Length)
      Array.Clear(dummy, 0, vector.Length)

      matlab.GetFullMatrix(ml_vector, "base", vector, dummy)

    End Sub

    ' ******************************** 
    Public Sub GetVectorComplex(ByVal ml_vectorComplex As String, _ 
                                ByRef vectorReal As Array, ByRef vectorImag As Array)

      matlab.GetFullMatrix(ml_vectorComplex, "base", vectorReal, vectorImag)

    End Sub

    '******************************** 
    '********** III. Matrix ********* 
    '******************************** 
    Public Sub PutMatrixReal(ByVal ml_matrix As String, ByRef matrix As Array)

      Dim row As Integer
      Dim col As Integer

      row = matrix.GetUpperBound(0) - matrix.GetLowerBound(0) + 1
      col = matrix.GetUpperBound(1) - matrix.GetLowerBound(1) + 1

      Dim dummy As Array = Array.CreateInstance(GetType(Double), row, col)
      Array.Clear(dummy, 0, row * col)

      matlab.PutFullMatrix(ml_matrix, "base", matrix, dummy)

    End Sub

    ' ******************************** 
    Public Sub GetMatrixReal(ByVal ml_matrix As String, ByRef matrix As Array)

      Dim row As Integer
      Dim col As Integer

      row = matrix.GetUpperBound(0) - matrix.GetLowerBound(0) + 1
      col = matrix.GetUpperBound(1) - matrix.GetLowerBound(1) + 1

      Dim dummy As Array = Array.CreateInstance(GetType(Double), row, col)
      Array.Clear(dummy, 0, row * col)

      matlab.GetFullMatrix(ml_matrix, "base", matrix, dummy)

    End Sub

    ' ******************************** 
    Public Sub PutMatrixComplex(ByVal ml_matrixComplex As String, _ 
                                ByRef matrixReal As Array, ByRef matrixImag As Array)

      matlab.PutFullMatrix(ml_matrixComplex, "base", matrixReal, matrixImag)

    End Sub

    ' ******************************** 
    Public Sub GetMatrixComplex(ByVal ml_matrixComplex As String, _ 
                                ByRef matrixReal As Array, ByRef matrixImag As Array)

      matlab.GetFullMatrix(ml_matrixComplex, "base", matrixReal, matrixImag)

    End Sub

    ' ******************************** 
    ' ************* Print out ******* 
    ' ******************************** 
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

    '    /* ******************************** */
    Public Sub Execute(ByVal commandName As String)

      matlab.Execute(commandName)
    End Sub

    ' ******************************** */
    Public Sub PutString(ByVal ml_str As String, ByVal str As String)

      matlab.PutCharArray(ml_str, "base", str)

    End Sub

    '********************************
    '********************************
    '********************************

  End Class

End Namespace