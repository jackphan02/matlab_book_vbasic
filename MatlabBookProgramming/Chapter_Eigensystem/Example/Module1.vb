Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays


Module Module1

    Sub Main()

			Dim objVB As Example = New Example()
			Console.WriteLine() 

			Console.WriteLine("Eigenvalues and eigenvectors" ) 
			objVB.EigValueVector() 

    End Sub

  Public Class Example

		' **************************** 
		Public Sub EigValueVector()  
		
			Dim A(,) As Double = New Double(,) _
							 {{ 0, -6, -1} , {6, 2, -16} ,  {-5, 20, -10} } 

			Dim row As Integer = 3 
			Dim col As Integer = 3 
			Dim i, j As Integer

			' declare mx_Array variables '
			Dim mw_A			    As MWNumericArray = New MWNumericArray(A) 
			Dim mw_ArrayOut() As MWArray			  = Nothing 

			Dim mw_eigenvectors As MWNumericArray = Nothing 
			Dim mw_eigenvalues  As MWNumericArray = Nothing 

			' call an implemental function 
			Dim obj  As EigensystemNameSpace.Eigensystem = _
									  New EigensystemNameSpace.Eigensystem()

			mw_ArrayOut = obj.myeig(2, mw_A) 
			Console.WriteLine("Eigen of the matrix A : ")
			Console.WriteLine("{0}", mw_ArrayOut) 

			mw_eigenvectors = mw_ArrayOut(0) 
			mw_eigenvalues  = mw_ArrayOut(1) 

			' convert back to double  
			Dim db_eigenvectorsReal(row-1, col-1) As Double
			Dim db_eigenvectorsImag(row-1, col-1) As Double

			Dim db_eigenvaluesReal(row-1, col-1) As Double 
			Dim db_eigenvaluesImag(row-1, col-1) As Double 

			db_eigenvectorsReal = mw_eigenvectors.ToArray(MWArrayComponent.Real) 
			db_eigenvaluesReal  = mw_eigenvalues.ToArray(MWArrayComponent.Real)  

			Try						
			  db_eigenvectorsImag = mw_eigenvectors.ToArray(MWArrayComponent.Imaginary)
			  db_eigenvaluesImag  = mw_eigenvalues.ToArray (MWArrayComponent.Imaginary)
						
			Catch						
			  ' nothing, db_eigenvectorsImag and db_eigenvaluesImag will be assigned value of zero						
			End Try

			' print out 
			Console.WriteLine("Eigenvalues of the matrix A : " ) 

			for i=0 to (row-1) 
						
			  Console.Write( db_eigenvaluesReal.GetValue(i,i).ToString() +  " + "  ) 
			  Console.Write( db_eigenvaluesImag.GetValue(i,i).ToString() +  "i"    )
			  Console.WriteLine() 

			Next
			Console.WriteLine() 
			' or
			Console.WriteLine("Eigenvectors of the matrix A : " ) 

			for j=0 to (col-1)
						
			  Console.WriteLine("Eigenvector {0} is : ", (j+1).ToString()  ) 

			  for i=0 to (row-1)

			    Console.Write( db_eigenvectorsReal.GetValue(i,j).ToString() + " + "  ) 
			    Console.Write( db_eigenvectorsImag.GetValue(i,j).ToString() + "i"    )
			    Console.WriteLine()
			  Next

			  Console.WriteLine()
			Next

			Console.WriteLine()

			' free memory 
			mw_A.Dispose() 
			MWNumericArray.DisposeArray(mw_ArrayOut) 

			mw_eigenvectors.Dispose() 
			mw_eigenvalues.Dispose() 
			
		End Sub


  End Class

End Module

