Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports LinearSystemNameSpace

Module Module1

  Sub Main()
    Dim objVB As Example = New Example()

    Console.WriteLine(" Linear System Equations")

    objVB.LinearSystemEquations()

    Console.WriteLine("ControlChars.NewLine + LU_decompression") 
    objVB.LU_decompression() 

    Console.WriteLine(ControlChars.NewLine + "Spare System") 
    objVB.SparseSystem() 

    Console.WriteLine() 
    objVB.TridiagonalSystem() 

    Console.WriteLine() 
    objVB.BandMatrixSystem() 

  End Sub

  Public Class Example
    Public Sub LinearSystemEquations()

      ' Solve general linear system equations Ax = b 
      Dim A(,) As Double = New Double(,) {{1.1, 5.6 , 3.3}, _
                                          {4.4, 12.3, 6.6}, _
                                          {7.7, 8.8 , 9.9}}

      Dim vectorb() As Double = New Double() { 12.5, 32.2 , 45.6 } 

      ' declare variables 
      Dim mw_A        As MWNumericArray = New MWNumericArray(A) 
      Dim mw_vectorb  As MWNumericArray = New MWNumericArray(vectorb) 
      Dim mw_x        As MWNumericArray = Nothing

      ' call an implemental function 
      Dim obj As LinearSystem = New LinearSystem()

      mw_vectorb  = obj.mytranspose(mw_vectorb) 
      mw_x        = obj.mymldivide(mw_A, mw_vectorb) 

      ' convert back to double  
      Dim x() As Double = mw_x.ToVector(MWArrayComponent.Real) 

      ' print out 
      Console.WriteLine(ControlChars.Tab + "result=")
      Console.WriteLine("{0}", mw_x)

      ' or 
      Console.WriteLine(ControlChars.Tab + "result=")
      PrintValues(x) 

      ' free memory 
      mw_A.Dispose() 
      mw_vectorb.Dispose() 
      mw_x.Dispose() 

    End Sub
    
    ' **************************** 
    Public Sub LU_decompression()  
    
      ' Find lower and upper matrixes 
      Dim A(,) As Double = New Double (,) { {1.1,  5.6, 3.3}  , _
                                            {4.4, 12.3, 6.6}  , _ 
                                            {7.7,  8.8, 9.9}  }

      ' Declare variables 
      Dim mw_A As MWNumericArray = new MWNumericArray(A) 

      Dim mw_ArrayOut() As MWArray = Nothing 
       
      Dim mw_L As MWNumericArray = Nothing
      Dim mw_U As MWNumericArray = Nothing
      Dim mw_P As MWNumericArray = Nothing

      ' call an implemental function 
      ' value of 3 is three of ouput in mylu.m
      Dim obj As LinearSystem = New LinearSystem()
      mw_ArrayOut = obj.mylu(3, mw_A) 

      'LinearSystem objLinear = new LinearSystem() ;
      mw_L = mw_ArrayOut(0) 
      mw_U = mw_ArrayOut(1) 
      mw_P = mw_ArrayOut(2)

      ' convert back to double  
      Dim L(,) As Double = mw_L.ToArray(MWArrayComponent.Real) 
      Dim U(,) As Double = mw_U.ToArray(MWArrayComponent.Real) 
      Dim P(,) As Double = mw_P.ToArray(MWArrayComponent.Real) 

      ' print out 
      Console.WriteLine("The lower matrix L = ") 
      Console.WriteLine("{0}", mw_L)  

      Console.WriteLine("The upper matrix U = ")   
      Console.WriteLine("{0}", mw_U)    

      Console.WriteLine("P = ")    
      Console.WriteLine("{0}", mw_P)    

      ' or 
      Console.WriteLine("Printing matrix L")
      PrintValues(L) 

      Console.WriteLine("Printing matrix U")
      PrintValues(U) 

      Console.WriteLine("Printing matrix P")
      PrintValues(P) 

      ' free memory 
      mw_A.Dispose() 
      MWNumericArray.DisposeArray(mw_ArrayOut) 
      mw_L.Dispose() 
      mw_U.Dispose() 
      mw_P.Dispose() 

    End Sub

    ' **************************** 
    Public Sub SparseSystem()      
      
      'A = 0        0        0        0        1.1
      '    0        2.2      0        0        0    
      '    3.3      0        0        0        0
      '    0        0        0        6.6      0
      '    0        0        5.5      0        0

      'b =  11.1    0        22.2     0        33.3
      

      ' Solve general linear system equations Ax = b 
      Dim A(,) As Double = { {0  ,    0  ,    0  ,   0  ,    1.1 } , _ 
                             {0  ,    2.2,    0  ,   0  ,    0   } , _ 
                             {3.3,    0  ,    0  ,   0  ,    0   } , _ 
                             {0  ,    0  ,    0  ,   6.6,    0   } , _ 
                             {0  ,    0  ,    5.5,   0  ,    0   } } 

      Dim vectorb() As Double =  {11.1,   0  ,    22.2,  0  ,    33.3} 

      ' declare variables 
      Dim mw_A        As MWNumericArray = New MWNumericArray(A) 
      Dim mw_vectorb  As MWNumericArray = New MWNumericArray(vectorb) 
      Dim mw_x        As MWNumericArray = Nothing

      ' call an implemental function 
      Dim obj As LinearSystem = New LinearSystem()

      mw_vectorb = obj.mytranspose(mw_vectorb) 

      mw_A       = obj.mysparse(mw_A) 
      mw_vectorb = obj.mysparse(mw_vectorb) 

      mw_x       = obj.mymldivide(mw_A, mw_vectorb) 
      mw_x       = obj.myfull(mw_x) 

      'convert back to double  
      Dim x() As Double = mw_x.ToVector(MWArrayComponent.Real) 

      ' print out 
      Console.WriteLine("Solution x :")
      Console.WriteLine("{0}", mw_x)

      'or 
      Console.WriteLine("Printing vector x:")
      PrintValues(x) 

      ' free memory 
      mw_A.Dispose() 
      mw_vectorb.Dispose() 
      mw_x.Dispose() 

    End Sub

    ' **************************** */
    Public Sub TridiagonalSystem()  
    
      Dim B(5,2) As Double

      ' columns 1 
      B(0, 0) = 1.1
      B(1, 0) = 1.2
      B(2, 0) = 1.3
      B(3, 0) = 1.4
      B(4, 0) = 1.5
      B(5, 0) = 1.6

      ' columns 2
      B(0, 1) = 4.1
      B(1, 1) = 4.2
      B(2, 1) = 4.3
      B(3, 1) = 4.4
      B(4, 1) = 4.5
      B(5, 1) = 4.6

      ' columns 3 
      B(0, 2) = 2.1
      B(1, 2) = 2.2
      B(2, 2) = 2.3
      B(3, 2) = 2.4
      B(4, 2) = 2.5
      B(5, 2) = 2.6

      Dim db_vectord(5) As Double 
      db_vectord(0) = 1.2
      db_vectord(1) = 4.5
      db_vectord(2) = 5.6
      db_vectord(3) = 12.4
      db_vectord(4) = 7.8
      db_vectord(5) = 6.8

      ' The size of the matrix A
      Dim row As Integer = 6
      Dim col AS Integer = 6

      Dim band As Integer = 3  ' tridiagnal, band width 

      ' Establish the row size=m, and column size=n
      ' of the bufferA

      Dim m As Integer = row
      Dim n As Integer = col + (band - 1)

      Dim d() As Double = { 0, 1, 2 } ' for band=3, start from 0 

      Dim rowB As Integer = row
      Dim colB As Integer = band

      ' declare mxArray variables '
      Dim mw_B As MWNumericArray       = New MWNumericArray(B)
      Dim mw_bufferA As MWNumericArray = Nothing
      Dim mw_A As MWNumericArray       = Nothing

      Dim mw_d As MWNumericArray = New MWNumericArray(d)

      Dim mw_vectord As MWNumericArray = New MWNumericArray(db_vectord)
      Dim mw_x As MWNumericArray       = Nothing

      ' call an implemental function 
      Dim obj As LinearSystemNameSpace.LinearSystem =     _ 
             New LinearSystemNameSpace.LinearSystem()

      ' create a sparse matrix mw_bufferA from column-matrix B  
      mw_bufferA = obj.myspdiags(mw_B, mw_d, m, n)
      mw_bufferA = obj.myfull(mw_bufferA)

      ' plot to see 
      Console.WriteLine("The buffer matrix A:")
      Console.WriteLine(mw_bufferA)

       'extract the need-matrix from the buffter matrix, 
       ' (start at 1 following MATLAB in m.file )
       '  from row 1 to row 6(=m) and from column 2(=start+1) to column 7(=n-1) 
      mw_A = obj.myextractmatrix(mw_bufferA, 1, row, 2, 7)

      ' plot to see 
      Console.WriteLine("The need-matrix A:")
      Console.WriteLine(mw_A)

      ' solve the tridiagnal system equations 
      mw_A = obj.mysparse(mw_A)

      mw_vectord = obj.mytranspose(mw_vectord)
      mw_vectord = obj.mysparse(mw_vectord)

      mw_x = obj.mymldivide(mw_A, mw_vectord)
      mw_x = obj.myfull(mw_x)

      ' convert back to double  
      Dim x() As Double = mw_x.ToVector(MWArrayComponent.Real)

      'print out 
      Console.WriteLine("Tridiagnal system solution:")
      Console.WriteLine(mw_x)

      ' or 
      PrintValues(x)

      ' free memory 
      mw_B.Dispose()
      mw_bufferA.Dispose()
      mw_A.Dispose()

      mw_d.Dispose()

      mw_vectord.Dispose()
      mw_x.Dispose()
       
    End Sub

    ' **************************** 
    Public Sub BandMatrixSystem()

      Dim B(5,3) As Double

      ' columns 1 
      B(0, 0) = 1.1
      B(1, 0) = 1.2
      B(2, 0) = 1.3
      B(3, 0) = 1.4
      B(4, 0) = 1.5
      B(5, 0) = 1.6

      ' columns 2 
      B(0, 1) = 4.1
      B(1, 1) = 4.2
      B(2, 1) = 4.3
      B(3, 1) = 4.4
      B(4, 1) = 4.5
      B(5, 1) = 4.6

      ' columns 3 
      B(0, 2) = 2.1
      B(1, 2) = 2.2
      B(2, 2) = 2.3
      B(3, 2) = 2.4
      B(4, 2) = 2.5
      B(5, 2) = 2.6

      ' columns 4 
      B(0, 3) = 7.1
      B(1, 3) = 7.2
      B(2, 3) = 7.3
      B(3, 3) = 7.4
      B(4, 3) = 7.5
      B(5, 3) = 7.6

      Dim db_vectord(5) As Double
      db_vectord(0) = 1.2
      db_vectord(1) = 4.5
      db_vectord(2) = 5.6
      db_vectord(3) = 12.4
      db_vectord(4) = 7.8
      db_vectord(5) = 6.8

      ' The size of the matrix A
      Dim row As Double = 6
      Dim col As Double = 6

      Dim band As Integer = 4  ' band width 

      ' Establish the row size=m, and column size=n
      ' of the bufferA

      Dim m As Integer = row
      Dim n As Integer = col + (band - 1)

      Dim d() As Double = New Double() { 0, 1, 2, 3 } ' for band = 4 start from 0 

      Dim rowB As Double = row
      Dim colB As Double = band

      'declare mxArray variables 
      Dim mw_B As MWNumericArray       = New MWNumericArray(B)
      Dim mw_bufferA As MWNumericArray = Nothing
      Dim mw_A As MWNumericArray       = Nothing

      Dim mw_d As MWNumericArray= new MWNumericArray(d)

      Dim  mw_vectord As MWNumericArray= New MWNumericArray(db_vectord)
      Dim  mw_x As MWNumericArray= Nothing

      ' call an implemental function 
      ' create a sparse matrix, size mxn, from column-matrix B  

      Dim obj As LinearSystemNameSpace.LinearSystem =     _ 
             New LinearSystemNameSpace.LinearSystem()

      mw_bufferA = obj.myspdiags(mw_B, mw_d, m, n)
      mw_bufferA = obj.myfull(mw_bufferA)

      ' plot to see 
      Console.WriteLine("The buffer band-matrix A:")
      Console.WriteLine(mw_bufferA)

      ' extract the need-matrix A from the buffter matrix,
      '    from row 1 to row 6 and from column 2 to column 7 */

      ' extract the need-matrix from the buffter matrix, 
      '  (start at 1 following MATLAB in m.file )
      '  from row 1 to row 6(=m) and from column 2(=start+1) to column 7(=n-1) */
      mw_A = obj.myextractmatrix(mw_bufferA, 1, row, 2, 7)

      ' plot to see 
      Console.WriteLine("The band-need-matrix A:")
      Console.WriteLine(mw_A)

      ' solve the system equations 
      mw_A = obj.mysparse(mw_A)

      mw_vectord = obj.mytranspose(mw_vectord)
      mw_vectord = obj.mysparse(mw_vectord)

      mw_x = obj.mymldivide(mw_A, mw_vectord)
      mw_x = obj.myfull(mw_x)

      ' convert back to double  
      Dim solution_x() As Double = mw_x.ToVector(MWArrayComponent.Real)

      ' print out 
      ' convert back to double 
      Console.WriteLine("Band matrix system solution:")
      Console.WriteLine(mw_x)

      ' or 
      PrintValues(solution_x)

      ' free memory 
      mw_B.Dispose()
      mw_bufferA.Dispose()
      mw_A.Dispose()

      mw_d.Dispose()

      mw_vectord.Dispose()
      mw_x.Dispose()

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
