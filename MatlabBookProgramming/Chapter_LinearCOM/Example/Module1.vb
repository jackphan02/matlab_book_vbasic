Imports System
Imports MATLABCOMLinear

Module Module1

  Sub Main()

    Dim objVB As Example = New Example()

    Console.WriteLine("MATLAB Builder for .NET")
    Console.WriteLine("Example of Matrix Computations and Linear Equations")
    Console.WriteLine()

    Console.WriteLine("Matrix Multiplication")
    objVB.MatrixMultiplication()
    Console.WriteLine()

    Console.WriteLine("Linear System Equation")
    objVB.LinearSystemEquations()

    Console.WriteLine()
    Console.WriteLine("LU decompression")
    objVB.LU_decompression()

  End Sub

  Public Class Example

    Dim MatlabVBNetObj As MatlabVBNet

    Public Sub New()
      MatlabVBNetObj = New MatlabVBNet
    End Sub

    ' ******************************** 
    Public Sub MatrixMultiplication()

      Dim objMatlab As MATLABCOMLinear.COMLinear = _
                   New MATLABCOMLinear.COMLinear()

      Dim db_A(,) As Double = {{1.1, 2.2, 3.3, 4.4}, _
                              {5.5, 6.6, 7.7, 8.8}, _
                              {9.9, 10.1, 11.11, 12.12}}

      Dim db_B(,) As Double = {{10, 11}, {12, 13}, {14, 15}, {16, 17}}

      Dim obj_A As Object
      obj_A = CObj(db_A)

      Dim obj_B As Object
      obj_B = CObj(db_B)

      Dim obj_C As Object
      obj_C = CObj(0)

      ' call the implemental function
      objMatlab.mymtimes(1, obj_C, obj_A, obj_B)

      'convert back to Double  
      Dim C(,) As Double = New Double(,) {}

      C = MatlabVBNetObj.CopyToMatrixDouble(obj_C)

      'print out 
      MatlabVBNetObj.PrintValues(C)

    End Sub

    ' ******************************** 
    Public Sub LinearSystemEquations()

      Dim obj_Matrix As MATLABCOMLinear.COMLinear = _
                   New MATLABCOMLinear.COMLinear()

      ' Solve general linear system equations Ax = b 
      Dim db_A(,) As Double = New Double(,) _
                              {{1.1, 5.6, 3.3}, _
                               {4.4, 12.3, 6.6}, _
                               {7.7, 8.8, 9.9}}

      Dim db_vectorb() As Double = New Double() {12.5, 32.2, 45.6}

      Dim obj_A As Object = CObj(db_A)
      Dim obj_b As Object = CObj(db_vectorb)
      Dim obj_Transb As Object = CObj(0)

      ' to get a comlumn vector b
      ' note: type of obj_Transb is Double(,)
      obj_Matrix.mytranspose(1, obj_Transb, obj_b)

      Dim obj_x As Object = CObj(0)
      obj_Matrix.mymldivide(1, obj_x, obj_A, obj_Transb)

      ' note: type of obj_x is a matrix with column = 1
      Dim aLength As Integer = db_vectorb.Length
      Dim db_x(,) As Double = New Double(,) {}

      db_x = MatlabVBNetObj.CopyToMatrixDouble(obj_x)

      'print out 
      MatlabVBNetObj.PrintValues(db_x)

    End Sub

    ' **************************** 
    Public Sub LU_decompression()

      ' find lower and upper matrixes 
      Dim db_A(,) As Double = New Double(,) _
                          {{1.1, 5.6, 3.3}, _
         {4.4, 12.3, 6.6}, _
         {7.7, 8.8, 9.9}}

      Dim obj_A As Object = CObj(db_A)
      Dim obj_L As Object = CObj(0)
      Dim obj_U As Object = CObj(0)
      Dim obj_P As Object = CObj(0)

      ' call an implemental function 
      Dim obj_Linear As MATLABCOMLinear.COMLinear = _
                   New MATLABCOMLinear.COMLinear()

      obj_Linear.mylu(3, obj_L, obj_U, obj_P, obj_A)

      Dim db_L(,) As Double = New Double(,) {}
      Dim db_U(,) As Double = New Double(,) {}

      db_L = MatlabVBNetObj.CopyToMatrixDouble(obj_L)
      db_U = MatlabVBNetObj.CopyToMatrixDouble(obj_U)

      ' print out 
      Console.WriteLine()
      Console.WriteLine("The lower matrix")
      MatlabVBNetObj.PrintValues(db_L)

      Console.WriteLine()
      Console.WriteLine("The upper matrix")
      MatlabVBNetObj.PrintValues(db_U)

    End Sub

  End Class

End Module
