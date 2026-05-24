Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports FindingRootsNameSpace

Module Module1

  Sub Main()

    Dim objVB As Example = New Example()
    Console.WriteLine("Roots of functions.") 
    objVB.FindingRootsPolynormial() 
    Console.WriteLine()  
    Console.WriteLine() 
    objVB.FindingZeroFunction() 

  End Sub

  Public Class Example

		' **************************** */
		Public Sub FindingRootsPolynormial()  		
			' 
			'Find the solutions of polynomial function:
			'	f(x) = -x^3 + 7.2x^2 -21x -5  
			'
			Dim order As Integer = 3 
			Dim db_coefs() As Double = New Double(){ -1, 7.2, -21, -5 } 
			
			' declare mxArray variables 
			Dim mw_coefs As MWNumericArray = New MWNumericArray(db_coefs) 
			Dim mw_x     As MWNumericArray = Nothing 

			' call an implemental function 
			Dim obj As FindingRootsNameSpace.FindingRoots = _
									  New FindingRootsNameSpace.FindingRoots()

			mw_x = obj.myroots(mw_coefs) 
									
			Console.WriteLine("Solutions of the polynomial function:")
			Console.WriteLine("{0}", mw_x) 
			Console.WriteLine()
			' convert back to double  
			Dim db_xReal(order-1) As Double
			Dim db_xImag(order-1) As Double

			db_xReal = mw_x.ToVector(MWArrayComponent.Real)			

			Try
			  db_xImag = mw_x.ToVector(MWArrayComponent.Imaginary)

			Catch						
			  'nothing, db_xImag will be assigned value of zero
			End Try 

			' or 
			Console.WriteLine("Solutions of the polynomial function : ")    
			Dim i As Integer 
			for i=0 to (order-1)						 						    
        Console.Write( db_xReal(i).ToString() +  " + " ) 
        Console.Write( db_xImag(i).ToString() +  "i" + ControlChars.Tab) 
        Console.WriteLine()						
      Next

      ' free memory */
			mw_coefs.Dispose()  
			mw_x.Dispose()			
 
		End Sub

    ' **************************** 
		Public Sub FindingZeroFunction () 
		
			' Find the solution of the function f(x) = sin(2*x) + cos(x) + 1  
			'	fzero(..) returns ONLY ONE SOLUTION near a initial guess value	
			'	If your problem is complicated, please look at functions 
			'	in Optimization Tool Box
			
			Dim db_initialGuess As Double = 0.9 
			Dim strfunc			   As String = "sin(2*x) + cos(x) + 1" 

			' declare mxArray variables 
			Dim mw_strfunc As MWCharArray = New MWCharArray(strfunc)			
			Dim mw_x As MWNumericArray = Nothing 

			' call an implemental function 
			Dim obj As FindingRootsNameSpace.FindingRoots = _
									  New FindingRootsNameSpace.FindingRoots()

			mw_x = obj.myfzero(mw_strfunc, db_initialGuess) 

			Console.WriteLine("Solutions of the given function :")
			Console.WriteLine("{0}", mw_x ) 			
			     
			' or convert back to double  
			Dim db_xReal As Double = mw_x.ToScalarDouble() 

			Console.WriteLine("Solutions of the given function : " ) 
			Console.WriteLine( db_xReal.ToString() ) 

			' free memory */
			mw_strfunc.Dispose()    
			mw_x.Dispose()			    

		End Sub

  End Class

End Module

