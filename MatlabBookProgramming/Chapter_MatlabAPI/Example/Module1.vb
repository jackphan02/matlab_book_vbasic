Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays

Module Module1

  Dim ObjVBAPI As UtilityMatlabVBAPIVer4p11.MatlabVBAPI = _
                                  New UtilityMatlabVBAPIVer4p11.MatlabVBAPI()

  Sub Main()
    Dim objVB As Example = New Example()

    ' I . Scalar
    ' 1. Put scalars in MATLAB Workspace
    ' 2. Get a scalar from MATLAB Workspace
    Console.WriteLine()
    objVB.SimplePlus()

    Console.WriteLine()
    objVB.PlusComplexNumbers()

    ' II. Vector & Matrix
    ' 1. Put a vector in MATLAB API
    ' 2. Get a vecotr from MATLAB API
    Console.WriteLine()
    objVB.PlusRealVectors()

    Console.WriteLine()
    objVB.PlusComplexVectors()

    ' III. Matrix
    ' 1. Put a matrix in MATLAB  Workspace
    ' 2. Get a matrix from MATLAB Workspace
    Console.WriteLine()
    objVB.PlusRealMatrixes()

    Console.WriteLine()
    objVB.PlusComplexMatrixes()

    Console.WriteLine()
    objVB.LinearSolve()

    'IV. Plot 
    ' 1. Put a string in MATLAB Workspace
    ' 2. Plot graphic from MATLAB Workspace
    Console.WriteLine()
    objVB.API_Plot()

  End Sub

  ' ******************************** 
  ' ******************************** 
  ' ******************************** 
  Public Class Example

    ' ******************************** 
    Public Sub SimplePlus()

      Dim db_a As Double = 1.1
      Dim db_b As Double = 2.2

      ObjVBAPI.PutScalarReal("ml_a", db_a)
      ObjVBAPI.PutScalarReal("ml_b", db_b)

      ObjVBAPI.Execute(" ml_c = ml_a + ml_b ; ")

      Dim db_c As Double = 0
      ObjVBAPI.GetScalarReal("ml_c", db_c)

      ' print out
      Console.WriteLine("The result from simple addition: ")
      Console.WriteLine(db_c.ToString())

    End Sub

    ' **************************** 
    Public Sub PlusComplexNumbers()

      ObjVBAPI.PlusComplexNumbers() 

    End Sub

    ' **************************** 
    Public Sub PlusRealVectors()

      Dim vecA() As Double = {0.1, 1.1, 11.1}
      Dim vecB() As Double = {0.2, 2.2, 22.2}

      ObjVBAPI.PutVectorReal("ml_vecA", vecA)
      ObjVBAPI.PutVectorReal("ml_vecB", vecB)

      ObjVBAPI.Execute(" ml_vecC = ml_vecA + ml_vecB ; ")

      Dim vectorC As Array = Array.CreateInstance(GetType(Double), vecA.Length)

      ObjVBAPI.GetVectorReal("ml_vecC", vectorC)

      ' Print out
      Console.WriteLine("Result of a real vector")
      ObjVBAPI.PrintValues(vectorC)

    End Sub

    ' **************************** 
    Public Sub PlusComplexVectors()

      Dim vecAReal() As Double = {0.1, 1.1, 11.1}
      Dim vecAImag() As Double = {100.1, 101.1, 111.1}

      Dim vecBReal() As Double = {0.2, 2.2, 22.2}
      Dim vecBImag() As Double = {200.2, 202.2, 222.2}

      ObjVBAPI.PutVectorComplex("ml_vecAComp", vecAReal, vecAImag)
      ObjVBAPI.PutVectorComplex("ml_vecBComp", vecBReal, vecBImag)

      ObjVBAPI.Execute(" ml_vecCComp = ml_vecAComp + ml_vecBComp ; ")

      Dim vectorC_Real As Array = Array.CreateInstance(GetType(Double), vecAReal.Length)
      Dim vectorC_Imag As Array = Array.CreateInstance(GetType(Double), vecAImag.Length)

      ObjVBAPI.GetVectorComplex("ml_vecCComp", vectorC_Real, vectorC_Imag)

      ' Print out
      Console.WriteLine("Result of a real vector")
      ObjVBAPI.PrintValues(vectorC_Real)

      Console.WriteLine("Result of an imag vector")
      ObjVBAPI.PrintValues(vectorC_Imag)

    End Sub

    ' *****************************
    Public Sub PlusRealMatrixes()

      Dim A(,) As Double = New Double(,) {{1.1, 2.2, 3.3}, {4.4, 5.5, 6.6}, _ 
                                                           {7.7, 8.8, 9.9}}
      Dim B(,) As Double = New Double(,) {{11, 12, 13}, {14, 15, 16}, {17, 18, 19}}

      ObjVBAPI.PutMatrixReal("ml_matrixA", A)
      ObjVBAPI.PutMatrixReal("ml_matrixB", B)

      ObjVBAPI.Execute(" ml_matrixC = ml_matrixA + ml_matrixB ; ")

      Dim row As Integer
      Dim col As Integer

      row = A.GetUpperBound(0) - A.GetLowerBound(0) + 1
      col = A.GetUpperBound(1) - A.GetLowerBound(1) + 1

      Dim matrixC As Array = Array.CreateInstance(GetType(Double), row, col)
      ObjVBAPI.GetMatrixReal("ml_matrixC", matrixC)

      ' Printer out
      Console.WriteLine("Result of a real matrix")
      ObjVBAPI.PrintValues(matrixC)

    End Sub

    ' **************************** 
    Public Sub PlusComplexMatrixes()

      Dim matrixA_real(,) As Double = New Double(,) _
                                   {{1.1, 2.2, 3.3}, {4.4, 5.5, 6.6}, {7.7, 8.8, 9.9}}
      Dim matrixA_imag(,) As Double = New Double(,) _
                 {{100.1, 200.2, 300.3}, {400.4, 500.5, 600.6}, {700.7, 800.8, 900.9}}


      Dim matrixB_real(,) As Double = New Double(,) _
                                    {{11, 12, 13}, {14, 15, 16}, {17, 18, 19}}
      Dim matrixB_imag(,) As Double = New Double(,) _
                                    {{111, 112, 113}, {114, 115, 16}, {117, 118, 119}}

      ObjVBAPI.PutMatrixComplex("ml_matrixA", matrixA_real, matrixA_imag)
      ObjVBAPI.PutMatrixComplex("ml_matrixB", matrixB_real, matrixB_imag)
      ObjVBAPI.Execute(" ml_matrixC = ml_matrixA + ml_matrixB ; ")

      Dim row As Integer
      Dim col As Integer

      row = matrixA_real.GetUpperBound(0) - matrixA_real.GetLowerBound(0) + 1
      col = matrixA_real.GetUpperBound(1) - matrixA_real.GetLowerBound(1) + 1

      Dim matrixC_real As Array = Array.CreateInstance(GetType(Double), row, col)
      Dim matrixC_imag As Array = Array.CreateInstance(GetType(Double), row, col)

      ObjVBAPI.GetMatrixComplex("ml_matrixC", matrixC_real, matrixC_imag)

      ' Print out
      Console.WriteLine("Result of a real matrix")
      ObjVBAPI.PrintValues(matrixC_real)

      Console.WriteLine("Result of an imag matrix")
      ObjVBAPI.PrintValues(matrixC_imag)

    End Sub

    ' ****************************
    Public Sub LinearSolve()

      Dim A(,) As Double = New Double(,) {{1.1, 5.6, 3.3}, {4.4, 12.3, 6.6}, _ 
                                                            {7.7, 8.8, 9.9}}
      Dim b() As Double = {12.5, 32.2, 45.6}

      ' Put values to MATLAB variables
      ObjVBAPI.PutMatrixReal("ml_A", A)
      ObjVBAPI.PutVectorReal("ml_b", b)

      'MATLAB workspace tasks : Solve Ax = b, and get a vector x and an upper matrix U. 
      'The problem Ax = b is solved here as the purpose 
      'of showing the use of the MATLAB workspace in a VB function. 
      ObjVBAPI.Execute(" ml_vectorX = mldivide(ml_A, ml_b) ; ")
      ObjVBAPI.Execute(" [ml_L, ml_U, ml_P] = lu( ml_A )   ; ")

      'Get results from MATLAB workspace
      Dim vectorX As Array = Array.CreateInstance(GetType(Double), b.Length)
      ObjVBAPI.GetVectorReal("ml_vectorX", vectorX)

      Dim row As Integer
      Dim col As Integer

      row = A.GetUpperBound(0) - A.GetLowerBound(0) + 1
      col = A.GetUpperBound(1) - A.GetLowerBound(1) + 1

      Dim matrixU As Array = Array.CreateInstance(GetType(Double), row, col)
      ObjVBAPI.GetMatrixReal("ml_U", matrixU)

      ' Print out
      Console.WriteLine("Linear system: result of the vector solution")
      ObjVBAPI.PrintValues(vectorX)

      Console.WriteLine()
      Console.WriteLine("Linear system: result of the U matrix")
      ObjVBAPI.PrintValues(matrixU)

    End Sub

    ' ******************************** 
    Public Sub API_Plot()

      Dim X() As Double = {0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600}

      Dim Y() As Double = {0.4, 0.2426, 0.1472, 0.0893, 0.0541, 0.0328, 0.0199, _
             0.0121, 0.0073, 0.0044, 0.0027, 0.0016, 0.001}

      Dim myColor As String = "blue"

      ObjVBAPI.PutVectorReal("ml_X", X)
      ObjVBAPI.PutVectorReal("ml_Y", Y)

      ObjVBAPI.PutString("ml_plotColor", myColor)

      ObjVBAPI.Execute("plot(ml_X, ml_Y, ml_plotColor); ")
      ObjVBAPI.Execute("grid on; ")

      Console.WriteLine("Close the figure and hit Enter key to continue.")
      Console.ReadLine()  ' Keep figure staying

    End Sub

  End Class

End Module
