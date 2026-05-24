Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports RandomNumberNameSpace

Module Module1

  Sub Main()

    Console.WriteLine("Random Number")
 
    Dim objProgram As Example = New Example()
    Console.WriteLine()     

    Console.WriteLine("1. Vector of uniform random number from 0 to 1") 
    objProgram.UniformRandom_vector() 

    Console.WriteLine() 
    Console.WriteLine("2. Vector of uniform random numbers from a to b ") 
    objProgram.UniformRandom_vector2() 

    Console.WriteLine() 
    Console.WriteLine("3. Matrix of random numbers") 
    objProgram.UniformRandom_matrix() 

    Console.WriteLine() 
    Console.WriteLine("4. Matrix of random numbers from a to b") 
    objProgram.UniformRandom_matrix2() 

    Console.WriteLine() 
    Console.WriteLine("5. Vector of normal random number") 
    objProgram.NormalRandom_vector() 

    Console.WriteLine() 
    Console.WriteLine("6. Vector of normal random number with mean and variance") 
    objProgram.NormalRandom_vector2() 

    Console.WriteLine() 
    Console.WriteLine("7. Matrix of normal random number") 
    objProgram.NormalRandom_matrix() 

    Console.WriteLine() 
    Console.WriteLine("8. Matrix of normal random number with mean and variance") 
    objProgram.NormalRandom_matrix2() 

  End Sub

  Public Class Example

    ' ****************************
    Public Sub UniformRandom_vector()  
      Dim row As Integer = 1 
      Dim col As Integer = 5 
      
      Dim uniformRandVector As MWNumericArray = Nothing
      Dim mw_row As MWNumericArray = New MWNumericArray(row) 
      Dim mw_col As MWNumericArray = new MWNumericArray(col) 
      
      Dim objMatlab  As RandomNumberNameSpace.RandomNumber = _
                    New RandomNumberNameSpace.RandomNumber()
       
      uniformRandVector = objMatlab.myrand(mw_row, mw_col)

      Console.WriteLine("Uniform random numbers from 0 to 1:")
      Console.WriteLine(uniformRandVector)

      ' Or convert back to double  
      Dim db_uniformRandVector() As Double = _ 
        uniformRandVector.ToVector(MWArrayComponent.Real) 
      Console.WriteLine() 
      PrintValues(db_uniformRandVector) 

      uniformRandVector.Dispose()                  
      
    End Sub

    '  *********************************** 
    Public Sub UniformRandom_vector2()  
    
      Dim a As Double = 2.0	
      Dim b As Double = 18.0

      Dim row As Integer = 1 
      Dim col As Integer = 6 
      Dim i As Integer
            
      ' Get random numbers in [0, 1] 
      Dim uniformRandVector As MWNumericArray = Nothing

      Dim mw_row As MWNumericArray = New MWNumericArray(row) 
      Dim mw_col As MWNumericArray = New MWNumericArray(col) 

      Dim objMatlab  As RandomNumberNameSpace.RandomNumber = _
                    New RandomNumberNameSpace.RandomNumber()
        
      uniformRandVector = objMatlab.myrand(mw_row, mw_col)
        
      ' Convert back to double 
      Dim db_uniformRandVector() As Double = _ 
       uniformRandVector.ToVector(MWArrayComponent.Real) 
      
      Console.WriteLine() 
      Console.WriteLine("Uniform random numbers from a=2 to b=18 : ") 

      For i=0 to (db_uniformRandVector.Length -1) 
        Dim aVal As Double = a + (b-a)*db_uniformRandVector(i) 
        Console.WriteLine( aVal.ToString() ) 
      Next

      ' Free memories        
      uniformRandVector.Dispose() 

    End Sub

    ' ************************************* 
    Public Sub UniformRandom_matrix()  
    
      Dim row As Integer = 8
      Dim col As Integer = 5 

      Dim mw_uniformRandMatrix As MWNumericArray = Nothing
      Dim mw_row As MWNumericArray = New MWNumericArray(row) 
      Dim mw_col As MWNumericArray = New MWNumericArray(col) 

      Dim objMatlab  As RandomNumberNameSpace.RandomNumber = _
                    New RandomNumberNameSpace.RandomNumber()

      mw_uniformRandMatrix = objMatlab.myrand(mw_row, mw_col)

      Console.WriteLine("The matrix of uniform random numbers from 0 to 1 :" ) 
      Console.WriteLine(mw_uniformRandMatrix)

      ' Or convert back to  double 
      Dim db_uniformRandMatrix(,) As Double = _ 
        mw_uniformRandMatrix.ToArray(MWArrayComponent.Real) 
      Console.WriteLine() 
      PrintValues(db_uniformRandMatrix) 

      mw_uniformRandMatrix.Dispose() 

    End Sub

    ' ********************************* 
    Public Sub UniformRandom_matrix2()  
    
      Dim row As Integer = 8 
      Dim col As Integer = 5 
      Dim i, j As Integer

      Dim a As Double = 4.0  
      Dim b As Double = 17.0 

      Dim mw_uniformRandMatrix As MWNumericArray = Nothing
      Dim mw_row As MWNumericArray = New MWNumericArray(row) 
      Dim mw_col As MWNumericArray = New MWNumericArray(col) 

      ' Get matrix of random number from 0 to 1
      Dim objMatlab  As RandomNumberNameSpace.RandomNumber = _
                    New RandomNumberNameSpace.RandomNumber()
      mw_uniformRandMatrix = objMatlab.myrand(mw_row, mw_col)

      '' Convert to double
      Dim db_uniformRandMatrix(,) As Double = _ 
        mw_uniformRandMatrix.ToArray(MWArrayComponent.Real) 

      ' Print out 
      Console.WriteLine() 
      Console.WriteLine("The matrix of uniform random numbers from a=4.0 to b=17.0:") 

      For i=0 to (row - 1) 
        For j=0 to (col-1)
          Console.WriteLine("{0}", a + (b-a)*db_uniformRandMatrix(i,j)  )
        Next
      Console.WriteLine() 
      Next

      Console.WriteLine() 

      ' Free memories  
      mw_uniformRandMatrix.Dispose() 

    End Sub

    ' ********************************* */
    Public Sub NormalRandom_vector()  
    
      Dim row As Integer = 1 
      Dim col As Integer = 5 

      Dim mw_normalRandVector As MWNumericArray = Nothing
      Dim mw_row As MWNumericArray = New MWNumericArray(row) 
      Dim mw_col As MWNumericArray = New MWNumericArray(col) 

      Dim objMatlab  As RandomNumberNameSpace.RandomNumber = _
                    New RandomNumberNameSpace.RandomNumber()
      mw_normalRandVector = objMatlab.myrandn(mw_row, mw_col) 

      Console.WriteLine("Normal random numbers :") 
      Console.WriteLine(mw_normalRandVector) 

      ' Or convert back to double  
      Dim db_normalRandVector() As Double = _ 
        mw_normalRandVector.ToVector(MWArrayComponent.Real) 
      Console.WriteLine() 
      PrintValues(db_normalRandVector) 

      ' Free memories 
      mw_normalRandVector.Dispose() 

    End Sub

    ' **************************** 
    Public Sub NormalRandom_vector2()  
    
      ' Generate a vector of normal random numbers at 
      ' particular mean and variance 
      Dim row As Integer = 1 
      Dim col As Integer = 5 

      Dim mean_mu As Double = 0.56 
      Dim variance As Double = 0.12 
      Dim i As Integer

      Dim mw_normalRandVector As MWNumericArray = Nothing
      Dim mw_row As MWNumericArray = New MWNumericArray(row) 
      Dim mw_col As MWNumericArray = new MWNumericArray(col) 

      Dim objMatlab  As RandomNumberNameSpace.RandomNumber = _
                    New RandomNumberNameSpace.RandomNumber()

      mw_normalRandVector = objMatlab.myrandn(mw_row, mw_col) 

      ' Convert to double
      Dim db_normalRandVector() As Double = _ 
        mw_normalRandVector.ToVector(MWArrayComponent.Real) 

      Dim standard_deviation As Double = Math.Sqrt(variance) 

      ' Print out 
      Console.WriteLine("Normal random numbers with mean = 0.56 and variance = 0.12 :") 

      For i=0 to (col-1) 
        Dim aVal As Double = mean_mu + standard_deviation*db_normalRandVector(i)
        Console.WriteLine(aVal.ToString() + ControlChars.Tab) 
      Next

      Console.WriteLine() 

      ' Free memories
      mw_normalRandVector.Dispose() 

    End Sub

    ' ************************************* *
    Public Sub NormalRandom_matrix()  
    
      Dim row As Integer = 8 
      Dim col As Integer = 5 

      Dim objMatlab  As RandomNumberNameSpace.RandomNumber = _
                    New RandomNumberNameSpace.RandomNumber()

      Dim mw_normalRandMatrix As MWNumericArray = Nothing
      Dim mw_row As MWNumericArray = New MWNumericArray(row) 
      Dim mw_col As MWNumericArray = New MWNumericArray(col) 

      ' Get matrix of random number from 0 to 1
      mw_normalRandMatrix = objMatlab.myrandn(mw_row, mw_col)

      Console.WriteLine(mw_normalRandMatrix) 

      ' Or convert to double
      Dim db_normalRandMatrix(,) As Double = _ 
        mw_normalRandMatrix.ToArray(MWArrayComponent.Real) 
      Console.WriteLine() 
      PrintValues(db_normalRandMatrix) 

      ' Free memories  
      mw_normalRandMatrix.Dispose() 

    End Sub

    ' **************************** *
    Public Sub NormalRandom_matrix2()  
    
      Dim row As Integer = 8 
      Dim col As Integer = 5 
      Dim i, j As Integer

      Dim mean_mu As Double = 0.56 
      Dim variance As Double = 0.12 

      Dim standard_deviation As Double = Math.Sqrt(variance) 

      Dim objMatlab  As RandomNumberNameSpace.RandomNumber = _
                    New RandomNumberNameSpace.RandomNumber()

      Dim mw_normalRandMatrix As MWNumericArray = Nothing
      Dim mw_row As MWNumericArray = New MWNumericArray(row) 
      Dim mw_col As MWNumericArray = New MWNumericArray(col) 

      ' Get matrix of normal random number 
      mw_normalRandMatrix = objMatlab.myrandn(mw_row, mw_col)

      ' Convert to double
      Dim db_normalRandMatrix(,) As Double = _ 
        mw_normalRandMatrix.ToArray(MWArrayComponent.Real)

      ' Print out 
      Console.WriteLine() 
      Console.WriteLine("The matrix of normal random numbers ")
      Console.WriteLine("at specified mean and variance" )

      For i=0 to (row-1) 
        For j=0 to (col-1) 

          Dim aVal As Double = mean_mu + standard_deviation*db_normalRandMatrix(i,j) 
          Console.WriteLine( aVal.ToString() ) 
        Next     
      Console.WriteLine() 
      Next

      Console.WriteLine() 

      ' Free memories  
      mw_normalRandMatrix.Dispose() 

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
