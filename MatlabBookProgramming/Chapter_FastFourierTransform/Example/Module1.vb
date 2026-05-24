Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports FFTNameSpace


Module Module1

  Sub Main()

    Dim objVB As Example = New Example()

    Console.WriteLine("Fast Fourier Transform.") 
    Console.WriteLine("Fast Fourier Transform in 1D.") 

    objVB.FastFourierTrans1D() 
    Console.WriteLine()

    Console.WriteLine("Fast Fourier Transform in inverse of 1D.") 
    objVB.InverseFastFourierTrans1D() 
    Console.WriteLine()

    Console.WriteLine("Fast Fourier Transform in 2D.") 
    objVB.FastFourierTrans2D() 
    Console.WriteLine()

    Console.WriteLine("Fast Fourier Transform in inverse of 2D.") 
    objVB.InverseFastFourierTrans2D() 

  End Sub

  Public Class Example

	  ' **************************** 
		Public Sub FastFourierTrans1D()  

      Dim db_X() As Double = New Double() { 6, 3, 7, -9, 0, 3, -2, 1 }  
      Dim vectorSize As Integer = 8 

      ' declare mxArray variables 
  
      Dim mw_X As MWNumericArray = New MWNumericArray(db_X) 
      Dim mw_Y As MWNumericArray = Nothing 

      ' call an implemental function 
      Dim obj As FFTNameSpace.FFT = New FFTNameSpace.FFT()

      mw_Y = obj.myfft(mw_X) 
      Console.WriteLine("Fast Fourier Transform of X :")
      Console.WriteLine("{0}", mw_Y) 

      ' convert back to double  
      Dim db_YReal(vectorSize-1) As Double 
      Dim db_YImag(vectorSize-1) As Double

      db_YReal = mw_Y.ToVector(MWArrayComponent.Real) 

      Try
        db_YImag = mw_Y.ToVector(MWArrayComponent.Imaginary)
      Catch
        ' nothing, db_YImag() will be assigned value of zero 
      End Try

      'or print out 
      Console.WriteLine("Fast Fourier Transform of X " + ControlChars.NewLine) 
      Dim i As Integer
      
      for i=0 to (vectorSize-1)        
        Console.Write( db_YReal(i).ToString() +  " + " ) 
        Console.Write( db_YImag(i).ToString() +  "i"  + ControlChars.NewLine ) 
      Next

      Console.WriteLine() 

      mw_X.Dispose() 
      mw_Y.Dispose() 

    End Sub

    '**************************** 
    Public Sub InverseFastFourierTrans1D() 

      Dim db_YReal() As Double = New Double() _
	              { 9.00, 13.0711,   1.00, -1.0711, 13.00, -1.0711 , 1.00 , 13.0711 } 
      Dim db_YImag() As Double = New Double() _
	              { 0   , -1.9289, -14.00, 16.0711, 0    , -16.0711, 14.00, 1.9289  } 

      Dim vectorSize As Integer = 8 

      ' declare mxArray variables 
      Dim mw_Y As MWNumericArray = New MWNumericArray(db_YReal, db_YImag) 
      Dim mw_X As MWNumericArray = New MWNumericArray (MWArrayComplexity.Complex, _ 
                                                       MWNumericType.Double, 7) 

      ' call an implemental function 
      Dim obj As FFTNameSpace.FFT = New FFTNameSpace.FFT()

      mw_X = obj.myifft(mw_Y) 
      Console.WriteLine("Inverse Fast Fourier Transform of Y :")
      Console.WriteLine("{0}", mw_X ) 
      Console.WriteLine()

      ' convert back to double  
      Dim db_XReal() As Double = mw_X.ToVector(MWArrayComponent.Real)      
      Dim db_XImag(vectorSize - 1) As Double 
          
      Try
        db_XImag = mw_X.ToVector(MWArrayComponent.Imaginary)
      Catch
        ' nothing, db_XImag() will be assigned value of zero
      End Try

      'or, print out 
      Console.WriteLine("Inverse Fast Fourier Transform of Y : " ) 

      Dim i As Integer
      for i=0 to (vectorSize - 1)        
        Console.Write( db_XReal(i).ToString() +  " + " ) 
        Console.Write( db_XImag(i).ToString() +  "i" + ControlChars.NewLine ) 
      Next

      Console.WriteLine() 

      mw_X.Dispose() 
      mw_Y.Dispose() 

    End Sub

    ' ****************************
    Public Sub FastFourierTrans2D()  
		
      Dim X(,) As Double = New Double(,)  _ 
              { {4  ,  3.2,  6.8,  9.1  }  , _
              {-4 ,  1.2,  4.3,  5.4  }  , _
              {2.2, -6.7,  8  ,  12.2 }  } 
      Dim row As Integer = 3 
      Dim col As Integer = 4 

      Dim i, j As Integer

      ' declare mxArray variables 
      Dim mw_X As MWNumericArray = New MWNumericArray(X) 
      Dim mw_Y As MWNumericArray = Nothing 

      ' call an implemental function 
      Dim obj As FFTNameSpace.FFT = New FFTNameSpace.FFT()

      mw_Y = obj.myfft2(mw_X) 
      Console.WriteLine("2-D Fast Fourier Transform of X:" )
      Console.WriteLine("{0}", mw_Y) 
      Console.WriteLine()

      ' convert back to double  
      Dim db_YReal(row-1,col-1) As Double
      Dim db_YImag(row-1,col-1) As Double

      db_YReal = mw_Y.ToArray(MWArrayComponent.Real)      

      Try
        db_YImag = mw_Y.ToArray(MWArrayComponent.Imaginary)
      Catch
        ' nothing, db_YImag will be assigned value of zero
      End Try

      ' or, print out 
      Console.WriteLine("2-D Fast Fourier Transform of X : ") 

      for i=0 to (row-1)  
			
        for j=0 to (col-1) 
				
          Console.Write( db_YReal.GetValue(i,j).ToString() + " + " )
          Console.Write( db_YImag.GetValue(i,j).ToString() + "i"   )
          Console.Write(ControlChars.Tab + ControlChars.Tab)
				
        Next

        Console.WriteLine()
			    
      Next
        Console.WriteLine() 

        ' free memory 
        mw_X.Dispose() 
        mw_Y.Dispose() 

    End Sub

 		' ****************************
    Public Sub InverseFastFourierTrans2D()  
        
      Dim YReal(,) As Double = New Double (,) _
              {	{ 45.7000,  -16.9000,  -3.1000,  -16.9000 }	, _
		            { 11.8000,   -8.4806,  -0.7000,   16.9806 }	, _
		            { 11.8000,   16.9806,  -0.7000,  -8.4806  }	}

      Dim YImag(,) As Double = New Double(,) _
               {{ 0,       29.0000,   0		, -29.0000 }	, _
		            { 7.6210,  -3.4849,   9.5263,   7.8151 }	, _
		            {-7.6210,  -7.8151,  -9.5263,   3.4849 }	}

      Dim row As Integer = 3 
      Dim col As Integer = 4 
    
      Dim i, j As Integer

      ' declare mxArray variables 
      Dim mw_X As MWNumericArray = Nothing 
      Dim mw_Y As MWNumericArray = New MWNumericArray(YReal, YImag) 

      ' call an implemental function 
      Dim obj As FFTNameSpace.FFT = New FFTNameSpace.FFT()

      mw_X = obj.myifft2(mw_Y) 
      Console.WriteLine("Inverse 2-D Fast Fourier Transform of Y :")
      Console.WriteLine("{0}", mw_X ) 

      ' convert back to double  
      Dim db_XReal(row-1, col-1) As Double
      Dim db_XImag(row-1, col-1) As Double

      db_XReal = mw_X.ToArray(MWArrayComponent.Real)      

      Try
        db_XImag = mw_X.ToArray(MWArrayComponent.Imaginary)
      Catch
        ' nothing, db_XImag will be assigned value of zero
      End Try

      'or print out 
      Console.WriteLine()
      Console.WriteLine("Inverse 2-D Fast Fourier Transform of Y : " ) 		

      for i=0 to (row-1)  
      
        for j=0 to (col-1)
        
          Console.Write( db_XReal.GetValue(i,j).ToString() +  " + " ) 
          Console.Write( db_XImag.GetValue(i,j).ToString() +  "i"   )
          Console.Write(ControlChars.Tab + ControlChars.Tab)
        Next
      Console.WriteLine() 

      Next
      Console.WriteLine() 

      ' free memory 
      mw_X.Dispose() 
      mw_Y.Dispose() 

    End Sub

  End Class

End Module
