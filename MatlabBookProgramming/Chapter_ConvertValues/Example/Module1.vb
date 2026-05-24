Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports PlusNameSpace
Module Module1

  Sub Main()
    Dim obj As Example = New Example()

    Console.WriteLine("1. Transfer values of a scalar")
    Console.WriteLine()
    obj.TransferScalarValues()
    Console.WriteLine()

    Console.WriteLine("2. Transfer values of a vector")
    Console.WriteLine()
    obj.TransferVectorValues()

    Console.WriteLine()
    Console.WriteLine("3. Transfer values of a matrix")
    obj.TransferMatrixValues()


  End Sub

  Public Class Example

    ' 1. scalar 
    Public Sub TransferScalarValues()

      '1a. transfer real value from double to MWNumericArray
      Dim db_a As Double = 1.1
      Dim mw_a As MWNumericArray = New MWNumericArray(db_a)

      Dim db_b As Double = 2.2
      Dim mw_b As MWNumericArray = New MWNumericArray(db_b)

      Console.WriteLine("1a. double to MWNumericArray: mw_a = {0}", mw_a)
      Console.WriteLine("    double to MWNumericArray: mw_b = {0}", mw_b)
      Console.WriteLine()

      '1b. transfer real value from MWNumericArray to double
      Dim objVB As PlusClass = New PlusClass()
      Dim mw_c As MWNumericArray = Nothing
      mw_c = objVB.myplus(mw_a, mw_b)

      Dim db_c As Double
      db_c = mw_c.ToScalarDouble()
      Console.WriteLine("1b. MWNumericArray to double: db_c = {0}", db_c)
      Console.WriteLine()

      '1c. transfer complex value from double to MWNumericArray
      Dim dbReal_a As Double = 1.1
      Dim dbImag_a As Double = 2.2
      Dim mwComplex_a As MWNumericArray = New MWNumericArray(dbReal_a, dbImag_a)

      Dim dbReal_b As Double = 3.3
      Dim dbImag_b As Double = 4.4
      Dim mwComplex_b As MWNumericArray = New MWNumericArray(dbReal_b, dbImag_b)

      Console.WriteLine("1c. double to MWNumericArray Complex: mwComplex_a = {0}", mwComplex_a)
      Console.WriteLine("    double to MWNumericArray Complex: mwComplex_b = {0}", mwComplex_b)
      Console.WriteLine()

      '1d. transfer complex value from MWNumericArray to double
      Dim mwComplex_c As MWNumericArray = Nothing
      mwComplex_c = objVB.myplus(mwComplex_a, mwComplex_b)


      Dim dbReal_c(1) As Double
      Dim dbImag_c(1) As Double

      dbReal_c = mwComplex_c.ToVector(MWArrayComponent.Real)
      ' In converting imaginary part to double,
      ' we'll get error if MWNumericArray mwComplex_c doesn't contain an imaginary part.

      If mwComplex_c.IsComplex Then
        dbImag_c = mwComplex_c.ToVector(MWArrayComponent.Imaginary)
      Else
        'dbImag_c will be assigned value of zero 
      End If

      Console.WriteLine("1d. The real value dbReal_c = {0}: ", dbReal_c(0))
      Console.WriteLine("    The imag value dbImag_c = {0}: ", dbImag_c(0))
      Console.WriteLine()

      mw_a.Dispose()
      mw_b.Dispose()
      mw_c.Dispose()

      mwComplex_a.Dispose()
      mwComplex_b.Dispose()
      mwComplex_c.Dispose()

    End Sub

    ' ******************************** 
    ' 2. vector 
    Public Sub TransferVectorValues()

      '2a. transfer real value of a vector from double to MWNumericArray
      Dim db_a() As Double = New Double() {1.1, 2.2, 3.3}
      Dim db_b() As Double = New Double() {4.4, 5.5, 6.6}

      Dim mw_a As MWNumericArray = New MWNumericArray(db_a)
      Dim mw_b As MWNumericArray = New MWNumericArray(db_b)

      Console.WriteLine("2a. double to MWNumericArray in a real vector mw_a: {0}", mw_a)
      Console.WriteLine("    double to MWNumericArray in a real vector mw_b: {0}", mw_b)
      Console.WriteLine()

      '2b. transfer real value of a vector from MWNumericArray to double
      Dim objVB As PlusClass = New PlusClass()
      Dim mw_c As MWNumericArray = Nothing
      mw_c = objVB.myplus(mw_a, mw_b)

      Dim db_c() As Double = mw_c.ToVector(MWArrayComponent.Real)

      Console.WriteLine("2b. MWNumericArray to double in a real vector:")
      PrintValues(db_c)
      Console.WriteLine()

      '2c. transfer complex value of a vector from double to MWNumericArray
      Dim dbReal_a() As Double = {1.1, 2.2, 3.3}
      Dim dbImag_a() As Double = {11.1, 22.2, 33.3}
      Dim mwComplex_a As MWNumericArray = New MWNumericArray(dbReal_a, dbImag_a)

      Dim dbReal_b() As Double = {4.4, 5.5, 6.6}
      Dim dbImag_b() As Double = {44.4, 55.5, 66.6}
      Dim mwComplex_b As MWNumericArray = New MWNumericArray(dbReal_b, dbImag_b)

      Console.WriteLine("2c. double to MWNumericArray in a complex vector:")
      Console.WriteLine(ControlChars.Tab + "mwComplex_a = {0}", mwComplex_a)
      Console.WriteLine(ControlChars.Tab + "mwComplex_b = {0}", mwComplex_b)
      Console.WriteLine()

      '2d. transfer complex value of a vector from MWNumericArray to double
      Dim mwComplex_c As MWNumericArray = Nothing
      mwComplex_c = objVB.myplus(mwComplex_a, mwComplex_b)

      Dim vectorSize As Integer = mwComplex_c.ToArray(MWArrayComponent.Real).GetUpperBound(0) - _
                                  mwComplex_c.ToArray(MWArrayComponent.Real).GetLowerBound(0) + 1

      Dim dbReal_c(vectorSize) As Double
      Dim dbImag_c(vectorSize) As Double

      dbReal_c = mwComplex_c.ToVector(MWArrayComponent.Real)

      Console.WriteLine("2d. MWNumericArray to double in a complex vector.")
      Console.WriteLine(ControlChars.Tab + "mwComplex_c = {0}", mwComplex_c)

      Console.WriteLine(ControlChars.Tab + "The real value dbReal_c :")
      PrintValues(dbReal_c)

      If mwComplex_c.IsComplex Then
        dbImag_c = mwComplex_c.ToVector(MWArrayComponent.Imaginary)
      Else
        'nothing, dbImag_a2 will be assigned value of zero 
      End If

      Console.WriteLine(ControlChars.Tab + "The imag value dbImag_c :")
      PrintValues(dbImag_c)

      mw_a.Dispose()
      mw_b.Dispose()
      mw_c.Dispose()

      mwComplex_a.Dispose()
      mwComplex_b.Dispose()
      mwComplex_a.Dispose()

    End Sub

    ' 3. matrix ******************** 
    Public Sub TransferMatrixValues()

      '3a. transfer real value of a matrix from double to MWNumericArray
      Dim db_A(,) As Double = New Double(,) {{1.1, 2.2, 3.3}, {4.4, 5.5, 6.6}, {7.7, 8.8, 9.9}}
      Dim db_B(,) As Double = New Double(,) {{101.1, 102.2, 103.3}, {104.4, 105.5, 106.6}, _
                                             {107.7, 108.8, 109.9}}

      Dim mw_A As MWNumericArray = New MWNumericArray(db_A)
      Dim mw_B As MWNumericArray = New MWNumericArray(db_B)

      Console.WriteLine("3a. double to MWNumericArray in a real matrix mw_A:")
      Console.WriteLine("{0}", mw_A)

      Console.WriteLine("    double to MWNumericArray in a real matrix mw_B:")
      Console.WriteLine("{0}", mw_B)
      Console.WriteLine()

      '3b. transfer real value of a matrix from MWNumericArray to double
      Dim objVB As PlusClass = New PlusClass()
      Dim mw_C As MWNumericArray = Nothing
      mw_C = objVB.myplus(mw_A, mw_B)

      Dim db_C(,) As Double = mw_C.ToArray(MWArrayComponent.Real)
      Console.WriteLine("3b. MWNumericArray to double in a real matrix mw_C:")
      PrintValues(db_C)
      Console.WriteLine()

      '3c. transfer complex value of a matrix from double to MWNumericArray
      Dim dbReal_A(,) As Double = New Double(,) {{1.1, 2.2, 3.3}, {4.4, 5.5, 6.6}, _
                                                 {7.7, 8.8, 9.9}}
      Dim dbImag_A(,) As Double = New Double(,) {{11, 12, 13}, {14, 15, 16}, {17, 18, 19}}

      Dim dbReal_B(,) As Double = New Double(,) {{10.1, 20.2, 30.3}, {40.4, 50.5, 60.6}, _
                                                 {70.7, 80.8, 90.9}}
      Dim dbImag_B(,) As Double = New Double(,) {{101, 102, 103}, {104, 105, 106}, _
                                                 {107, 108, 109}}

      Dim mwComplex_A As MWNumericArray = New MWNumericArray(dbReal_A, dbImag_A)
      Dim mwComplex_B As MWNumericArray = New MWNumericArray(dbReal_B, dbImag_B)

      Console.WriteLine("3c. double to MWNumericArray in a complex matrix mwComplex_A")
      Console.WriteLine("{0}", mwComplex_A)
      Console.WriteLine()

      '3d. transfer complex value of a matrix from MWNumericArray to double
      Dim mwComplex_C As MWNumericArray = Nothing
      mwComplex_C = objVB.myplus(mwComplex_A, mwComplex_B)

      Dim row As Integer = mwComplex_A.ToArray(MWArrayComponent.Real).GetUpperBound(0) - _
                           mwComplex_A.ToArray(MWArrayComponent.Real).GetLowerBound(0) + 1

      Dim col As Integer = mwComplex_A.ToArray(MWArrayComponent.Real).GetUpperBound(1) - _
                           mwComplex_A.ToArray(MWArrayComponent.Real).GetLowerBound(1) + 1

      Dim dbReal_C(row, col) As Double
      Dim dbImag_C(row, col) As Double
      dbReal_C = mwComplex_C.ToArray(MWArrayComponent.Real)

      Console.WriteLine("3d. MWNumericArray to double in a complex matrix")
      Console.WriteLine(ControlChars.Tab + "mwComplex_C = {0}", mwComplex_C)

      Console.WriteLine(ControlChars.Tab + "The real value of the matrix dbReal_C :")
      PrintValues(dbReal_C)


      If mwComplex_C.IsComplex Then
        dbImag_C = mwComplex_C.ToArray(MWArrayComponent.Imaginary)
      Else
        'nothing, dbImag_C will be assigned value of zero 

      End If

      Console.WriteLine(ControlChars.Tab + "The imag value of the matrix dbImag_C :")
      PrintValues(dbImag_C)

      mw_A.Dispose()
      mw_B.Dispose()
      mw_C.Dispose()

      mwComplex_A.Dispose()
      mwComplex_B.Dispose()
      mwComplex_C.Dispose()

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