Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports IntegrationNameSpace

Module Module1

  Sub Main()

  Console.WriteLine("Single integration:") 
      
  Dim objVB As Example = New Example()
   
  objVB.SingleIntegration() 

  Console.WriteLine("Double-integration:") 
  objVB.DoubleIntegration() 

  End Sub

  Public Class Example

    ' ******************************************* */
    Public Sub SingleIntegration()  

      Dim strfunc As String = "sin(x) + x.^2" 

      Dim db_beginInterval As Double = 0 
      Dim db_endInterval As Double = 3*Math.PI  ' using the value pi in .NET

      ' declare mxArray variables */
      Dim mw_strfunc As MWCharArray = New MWCharArray(strfunc)  
      Dim mw_y As MWNumericArray    = Nothing  

      ' call an implemental function */
      Dim obj As IntegrationNameSpace.Integration = New IntegrationNameSpace.Integration()
      
      mw_y = obj.myquad(mw_strfunc, db_beginInterval, db_endInterval) 

      ' print out
      Console.WriteLine(" I = {0}", mw_y ) 

      ' or 
      Dim db_y As Double = mw_y.ToScalarDouble() 
      Console.WriteLine(" I = {0}", db_y ) 

      ' free memory */
      mw_strfunc.Dispose() 
      mw_y.Dispose() 
            
    End Sub

    ' ******************************************* */
    Public Sub DoubleIntegration()  

      Dim strfunc As String= "sin(x) + x.^2 + y.^3" 

      Dim db_x1 As Double = 0 
      Dim db_x2 As Double = 3*Math.PI  ' using the value pi in NET

      Dim db_y1 As Double = 0 
      Dim db_y2 As Double = Math.PI  

      ' declare mxArray variables */
      Dim mw_strfunc As MWCharArray = New MWCharArray(strfunc)      
      Dim mw_ArrayOut() As MWArray  = Nothing
      Dim mw_II As MWNumericArray   = Nothing 

      ' call an implemental function */
      Dim obj As IntegrationNameSpace.Integration = New IntegrationNameSpace.Integration() 
                  
      mw_II = obj.mydblquad(mw_strfunc, db_x1, db_x2, db_y1, db_y2) 

      ' print out
      Console.WriteLine(" II = {0}", mw_II ) 

      ' or 
      Dim db_II As Double = mw_II.ToScalarDouble()
      Console.WriteLine(" II = {0}", db_II ) 

      ' free memory */
      mw_strfunc.Dispose() 
      mw_II.Dispose() 

    End Sub

  End Class

End Module

