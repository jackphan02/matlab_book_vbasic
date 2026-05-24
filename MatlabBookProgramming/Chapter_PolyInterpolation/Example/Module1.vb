Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports PolyInterpolationNameSpace

Module Module1

  Sub Main()
    Dim objVB As Example = New Example()
    Console.WriteLine("Curve Fitting") 

    Console.WriteLine() 
    Console.WriteLine("1. Polynomial") 
    objVB.PolynomialFittingCurve() 

    Console.WriteLine() 
    Console.WriteLine("2. One-dimensional interplation" ) 
    objVB.OneDimensionInterpolation() 

    Console.WriteLine() 
    Console.WriteLine("3. Two-dimensional interpolation") 
    objVB.TwoDimensionsInterpolation() 

    Console.WriteLine() 
    Console.WriteLine("4. Two-dimensional interpolation with fine grid") 
    objVB.TwoDimensionsInterpolationFineSolution() 

  End Sub
  Public Class Example
    ' ******************** 
    Public Sub PolynomialFittingCurve()  
    
      Dim db_X() As Double = { 1, 2, 3, 4, 5, 6 } 
      Dim db_Y() As Double = { 6.8, 50.2, 140.8, 280.5, 321.4, 428.6 }

      Dim db_oneValue As Double = 2.2  

      ' declare mwArray variables 
      Dim mw_X As MWNumericArray          = New MWNumericArray(db_X) 
      Dim mw_Y As MWNumericArray          = New MWNumericArray(db_Y) 
      Dim mw_coefs As MWNumericArray      = Nothing
      Dim mw_funcValue As MWNumericArray  = Nothing 

      ' call an implemental function 
      ' mw_coefs is a matrix with row = 1 
      Dim obj As PolyInterpolationNameSpace.PolyInterpolation = _ 
             New PolyInterpolationNameSpace.PolyInterpolation() 
      mw_coefs = obj.mypolyfit(mw_X, mw_Y, 3) 

      ' print out 
      Console.WriteLine("The coefficient value :")
      Console.WriteLine("{0}", mw_coefs)
            
      ' convert back to double  
      Dim db_coefs() As Double = mw_coefs.ToVector(MWArrayComponent.Real) 

      ' print out 
      Console.WriteLine("The polynomial:" ) 
      Console.Write( " {0}x^3 + ",  db_coefs(0).ToString() ) 
      Console.Write( " {0}x^2 + ",  db_coefs(1).ToString() ) 
      Console.Write( " {0}x + "  ,  db_coefs(2).ToString() ) 
      Console.Write(                db_coefs(3).ToString() ) 
      Console.WriteLine() 

      ' calculate the function value at oneValue 
      mw_funcValue = obj.mypolyval(mw_coefs, db_oneValue) 

      Dim db_funcValue As Double = mw_funcValue.ToScalarDouble()

      Console.WriteLine("The function value at 2.2 is:")     
      Console.WriteLine("{0}", mw_funcValue )       

      Console.WriteLine("The function value at 2.2 is") 
      Console.WriteLine("{0}", db_funcValue) 
   
      ' free memory 
      mw_X.Dispose()        
      mw_Y.Dispose()       
      mw_coefs.Dispose()     
      mw_funcValue.Dispose()   

    End Sub

    ' *************************** 
    Public Sub OneDimensionInterpolation()  

      Dim db_X() As Double = { 1, 2, 3, 4, 5, 6, 7, 8 } 
      Dim db_Y() As Double = { 6.8, 24.6, 50.2, 74, 140.8, 280.5, 321.4, 428.6 }

      Dim db_oneValue As Double  = 2.1  

      ' declare mwArray variables 
      Dim mw_X As MWNumericArray = New MWNumericArray(db_X) 
      Dim mw_Y As MWNumericArray = New MWNumericArray(db_Y) 
      Dim mw_funcValue As MWNumericArray = Nothing 

      ' call an implemental function 
      Dim obj As PolyInterpolationNameSpace.PolyInterpolation = _ 
             New PolyInterpolationNameSpace.PolyInterpolation() 
      mw_funcValue = obj.myinterp1(mw_X, mw_Y, db_oneValue) 

      ' print out 
      Console.WriteLine( "The function value at 2.1 is:")
      Console.WriteLine( "{0}", mw_funcValue )

      ' convert back to double  
      Dim db_funcValue As Double = mw_funcValue.ToScalarDouble()
      Console.WriteLine( "The function value at 2.1 is:") 
      Console.WriteLine("{0}", db_funcValue.ToString() )

      ' free memory 
      mw_X.Dispose()       
      mw_Y.Dispose()       
      mw_funcValue.Dispose()   

    End Sub

    ' **************************** 
    Public Sub TwoDimensionsInterpolation()  
    
      ' function values z at 47 points, (x_i, y_j) are : 
      ' matrix z values
    Dim z(,) As Double = { _
    {  0.0001,  0.0034, -0.0299, -0.2450, -0.1100, -0.0043,  0.0000  }  , _
    {  0.0007,  0.0468, -0.5921, -4.7596, -2.1024, -0.0616,  0.0004  }  , _
    { -0.0088, -0.1301,  1.8559, -0.7239, -0.2729,  0.4996,  0.0130  }  , _
    { -0.0365, -1.3327, -1.6523,  0.9810,  2.9369,  1.4122,  0.0331  }  , _
    { -0.0137, -0.4808,  0.2289,  3.6886,  2.4338,  0.5805,  0.0125  }  , _
    {  0.0000,  0.0797,  2.0967,  5.8591,  2.2099,  0.1328,  0.0013  }  , _
    {  0.0000,  0.0053,  0.1099,  0.2999,  0.1107,  0.0057,  0.0000  }  }

      Dim db_vectorstep() As Double = {-3, 1, 3} 
      Dim db_a As Double = 2.3 
      Dim db_b As Double = 0.7 

      ' declare mwArray variables 
      Dim interp2method As String = "cubic"

      Dim mw_interp2z As MWNumericArray = Nothing
      Dim mw_z As MWNumericArray = New MWNumericArray(z)  
      Dim mw_x As MWNumericArray = Nothing
      Dim mw_y As MWNumericArray = Nothing

      ' same for two step-vectors 
      Dim mw_vectorstepx As MWNumericArray = New MWNumericArray(db_vectorstep) 
      Dim mw_vectorstepy As MWNumericArray = New MWNumericArray(db_vectorstep) 

      Dim mw_method As MWCharArray = New MWCharArray(interp2method)  
      Dim mw_ArrayGrid() As MWArray = Nothing

      ' call implemental functions
      Dim obj As PolyInterpolationNameSpace.PolyInterpolation = _ 
             New PolyInterpolationNameSpace.PolyInterpolation() 

      ' create values for the matrix x and matrix y 
      mw_ArrayGrid = obj.mymeshgrid(2, mw_vectorstepx, mw_vectorstepy)

      mw_x =  mw_ArrayGrid(0)
      mw_y =  mw_ArrayGrid(1) 

      mw_interp2z = obj.myinterp2(mw_x, mw_y, mw_z, db_a, db_b, mw_method)

      'convert back to double  
      Dim db_x(,) As Double = mw_x.ToArray(MWArrayComponent.Real) 
      Dim db_y(,) As Double = mw_y.ToArray(MWArrayComponent.Real) 

      ' print out 
      Console.WriteLine("Matrix x") 
      Console.WriteLine("{0}", mw_x ) 
      
      ' or 
      Console.WriteLine("Matrix x") 
      PrintValues(db_x) 

      Console.WriteLine("Matrix y :") 
      Console.WriteLine("{0}", mw_y ) 
      
      ' or 
      Console.WriteLine("Matrix y :") 
      PrintValues(db_y) 

      Console.WriteLine("Interpolation in two dimensions with cubic method at 2.3 and 0.7  " )     
      Console.WriteLine(" z = " ) 
      Console.WriteLine("{0}", mw_interp2z ) 

      'or
      Console.WriteLine("Interpolation in two dimensions with cubic method at 2.3 and 0.7  " )     
      Dim db_interp2z As Double = mw_interp2z.ToScalarDouble()
      Console.WriteLine(" z = ")
      Console.WriteLine("{0}", db_interp2z.ToString() ) 

      ' free memory 
      mw_interp2z.Dispose() 
      mw_z.Dispose() 
      mw_x.Dispose() 
      mw_y.Dispose() 
      mw_vectorstepx.Dispose() 
      mw_vectorstepy.Dispose() 
      mw_method.Dispose() 

      MWNumericArray.DisposeArray(mw_ArrayGrid) 

    End Sub

    '* **************************** 
    Public Sub TwoDimensionsInterpolationFineSolution()  
  
      ' function values z, (x_i, y_j) are : 
      ' matrix z values

      Dim z(,) As Double = { _
  {  0.0001,  0.0034, -0.0299, -0.2450, -0.1100, -0.0043,  0.0000  }  , _
  {  0.0007,  0.0468, -0.5921, -4.7596, -2.1024, -0.0616,  0.0004  }  , _
  { -0.0088, -0.1301,  1.8559, -0.7239, -0.2729,  0.4996,  0.0130  }  , _
  { -0.0365, -1.3327, -1.6523,  0.9810,  2.9369,  1.4122,  0.0331  }  , _
  { -0.0137, -0.4808,  0.2289,  3.6886,  2.4338,  0.5805,  0.0125  }  , _
  {  0.0000,  0.0797,  2.0967,  5.8591,  2.2099,  0.1328,  0.0013  }  , _
  {  0.0000,  0.0053,  0.1099,  0.2999,  0.1107,  0.0057,  0.0000  }  }

      Dim db_vectorstep() As Double     = {-3,  1 , 3} ' interval = 1
      Dim db_finevectorstep() As Double = {-3, 0.2, 3} ' interval = 0.2

      Dim db_a As Double = 2.3 
      Dim db_b As Double = 0.7 
      Dim interp2method As String = "cubic"

      ' declare mwArray variables 
      Dim mw_interp2z  As MWNumericArray = Nothing
      Dim mw_z As MWNumericArray = New MWNumericArray(z)  
      Dim mw_finez As MWNumericArray = New MWNumericArray(z)  

      Dim mw_x As MWNumericArray = Nothing
      Dim mw_y As MWNumericArray = Nothing

      Dim mw_finex As MWNumericArray = Nothing
      Dim mw_finey As MWNumericArray = Nothing

      ' same for two step-vectors 
      Dim mw_vectorstepx As MWNumericArray = New MWNumericArray(db_vectorstep) 
      Dim mw_vectorstepy As MWNumericArray = new MWNumericArray(db_vectorstep) 

      Dim mw_method As MWCharArray = New MWCharArray(interp2method)  

      Dim mw_finevectorstepx As MWNumericArray = New MWNumericArray(db_finevectorstep)  
      Dim mw_finevectorstepy As MWNumericArray = New MWNumericArray(db_finevectorstep)  

      Dim mw_ArrayGridXY() As MWArray = Nothing

      Dim mw_ArrayMatrixXY() As MWArray = Nothing
      Dim mw_ArrayMatrixXY_fine() As MWArray = Nothing

      Dim mw_ArrayGridXY_fine() As MWArray = Nothing
      Dim mw_ArrayFineVector() As MWArray = Nothing

      ' call implemental functions 
      ' get size for fine matrixes 
      Dim obj As PolyInterpolationNameSpace.PolyInterpolation = _ 
             New PolyInterpolationNameSpace.PolyInterpolation() 

      ' create values for the matrix x and matrix y 
      mw_ArrayMatrixXY = obj.mymeshgrid(2, mw_vectorstepx, mw_vectorstepy) 
      mw_x = mw_ArrayMatrixXY(0)
      mw_y = mw_ArrayMatrixXY(1)

      'Console.WriteLine(" see normal x = ",  mw_x ) ; 

      ' create values for the fine matrix x and fine matrix y 
      mw_ArrayMatrixXY_fine = obj.mymeshgrid(2, mw_finevectorstepx, mw_finevectorstepy) 
      mw_finex = mw_ArrayMatrixXY_fine(0)
      mw_finey = mw_ArrayMatrixXY_fine(1)

      'Console.WriteLine(" see fine x = ",  mw_finex ) 

      ' get a fine matrix mx_finez from mx_z 
      mw_finez = obj.mygriddata(mw_x, mw_y, mw_z, mw_finex, mw_finey)

      Console.WriteLine(" see fine z = {0}",  mw_finez ) 

      mw_interp2z = obj.myinterp2(mw_finex, mw_finey, mw_finez, db_a, db_b, mw_method)
      ' convert back to double  
      Dim db_interp2finez As Double = mw_interp2z.ToScalarDouble()
      
      Console.Write("Interpolation in two dimensions with cubic method ")
      Console.WriteLine("and a fine grid")
      Console.WriteLine(" z = {0}",  mw_interp2z ) 
      Console.WriteLine(" z = {0}",  db_interp2finez.ToString() ) 

      ' free memory 
      mw_interp2z.Dispose() 
      mw_z.Dispose() 
      mw_finez.Dispose() 

      mw_x.Dispose() 
      mw_y.Dispose() 

      mw_vectorstepx.Dispose() 
      mw_vectorstepy.Dispose() 
      mw_method.Dispose() 

      mw_finevectorstepx.Dispose() 
      mw_finevectorstepy.Dispose() 

      MWNumericArray.DisposeArray(mw_ArrayGridXY)     
      MWNumericArray.DisposeArray(mw_ArrayGridXY_fine)  
      MWNumericArray.DisposeArray(mw_ArrayFineVector)     
    
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
