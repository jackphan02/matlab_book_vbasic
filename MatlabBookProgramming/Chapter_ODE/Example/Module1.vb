Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports ODENameSpace

Module Module1

  Sub Main()
    Dim objVB As Example = New Example()
    Console.WriteLine("ODE problems.") 

    Console.WriteLine("First order ODE.") 
    objVB.FirstOrder() 

    Console.WriteLine("First order ODE. Get particular values") 
    objVB.FirstOrderGetParticularValues() 

    Console.WriteLine("Second order ODE.") 
    objVB.SecondOrder()  

  End Sub

  Public Class Example

    ' **************************** 
    Public Sub FirstOrder()  
    
      ' Calculating first order ODE  
      ' Dim strfunc As String = "2+y" 

      Dim strfunc As String = "cos(t)" 

      Dim db_y0 As Double = 2.2   ' initial condition at t0    

      Dim db_tspan(1) As Double 
      db_tspan(0) = 0.2   ' begin interval t0 = 0.2    
      db_tspan(1) = 6.5   ' end interval, we choose this  

      ' declare mxArray variables 
      Dim mw_strfunc As MWCharArray  = New MWCharArray(strfunc)      
      Dim mw_tspan As MWNumericArray = New MWNumericArray(db_tspan) 

      Dim mw_ArrayOut() As MWArray = Nothing

      Dim mw_t As MWNumericArray = Nothing 
      Dim mw_y As MWNumericArray = Nothing 

      ' call an implemental function 
      Dim obj As ODENameSpace.ODE = New ODENameSpace.ODE()

      ' mx_tspan is a column vector when using in the following function 
      ' call an implemental function 
      mw_ArrayOut = obj.myode45firstorder(2, mw_strfunc, mw_tspan, db_y0) 
      mw_t        = mw_ArrayOut(0) 
      mw_y        = mw_ArrayOut(1) 

      ' convert back to double  
      Dim db_t() As Double = mw_t.ToVector(MWArrayComponent.Real)
      Dim db_y() As Double = mw_y.ToVector(MWArrayComponent.Real)

      Console.WriteLine("The column of time")
      Console.WriteLine(mw_t) 

      ' or 
      PrintValues(db_t) 

      Console.WriteLine("The column of the function values y") 
      Console.WriteLine(mw_y) 
                  
      ' or 
      PrintValues(db_y) 

      ' free memory 
      mw_strfunc.Dispose()  
      mw_tspan.Dispose()  
      mw_t.Dispose()      
      mw_y.Dispose()      

      MWNumericArray.DisposeArray(mw_ArrayOut) 

    End Sub

    ' **************************** 
    Public Sub FirstOrderGetParticularValues()  
    
      ' Calculating first order ODE  
      Dim strfunc As String = "6.4*t.^2 - 3.8*t*y" 
      Dim db_y0 As Double = 1.24   ' initial condition at t0            

      Dim db_tspan(3) As Double  
      db_tspan(0) = 0.15   ' begin interval t0 = 0.15           
      db_tspan(1) = 0.2    ' choose a particular time t = 0.2   
      db_tspan(2) = 2.6    ' choose a particular time t = 2.6   
      db_tspan(3) = 5.0    ' choose a particular time t = 5.0   

      Dim mw_strfunc As MWCharArray    = New MWCharArray(strfunc)      
      Dim mw_tspan   As MWNumericArray = New MWNumericArray(db_tspan)  

      Dim mw_ArrayOut() As MWArray = Nothing 
      Dim  mw_t As MWNumericArray  = Nothing 
      Dim  mw_y As MWNumericArray  = Nothing 

      ' mx_tspan is a column vector when using in the following function 
      ' convert double to mxArray 

      ' call an implemental function 

      Dim obj As ODENameSpace.ODE = New ODENameSpace.ODE()
      mw_ArrayOut = obj.myode45firstorder(2, mw_strfunc, mw_tspan, db_y0) 
      mw_t        = mw_ArrayOut(0) 
      mw_y        = mw_ArrayOut(1) 

      ' convert back to double  
      Dim db_t() As Double = mw_t.ToVector(MWArrayComponent.Real)
      Dim db_y() As Double = mw_y.ToVector(MWArrayComponent.Real)

      Console.WriteLine("The column of time") 
      Console.WriteLine(mw_t) 

      ' or 
      PrintValues(db_t) 

      Console.WriteLine("The column of the function values y" ) 
      Console.WriteLine(mw_y) 

      ' or 
      PrintValues(db_y)

      ' free memory 
      mw_strfunc.Dispose()  
      mw_tspan.Dispose()  
      mw_t.Dispose()      
      mw_y.Dispose()      

      MWNumericArray.DisposeArray(mw_ArrayOut) 

    End Sub

    ' **************************** 
    Public Sub SecondOrder()  
    
      ' Calculating second order ODE 
      Dim strfunc As String= "cos(3*t) + 2*yprime + 6*y" 

      Dim db_ybc(1) As Double         ' y boundary conditions      
      db_ybc(0)  = 0.2              ' initial condition of y  at t0  
      db_ybc(1)  = 1.1              ' initial condition of y' at t0  

      Dim db_tspan(1) As Double
      db_tspan(0) = 1.2   ' begin interval t0 = 1.2    
      db_tspan(1) = 2.5   ' end interval, we choose this  

      ' declare mxArray variables 
      Dim mw_strfunc As MWCharArray  = New MWCharArray(strfunc)      
      Dim mw_tspan As MWNumericArray = New MWNumericArray(db_tspan)  
      Dim mw_ybc As MWNumericArray   = New MWNumericArray(db_ybc)    

      Dim mw_ArrayOut() As MWArray = Nothing

      Dim mw_t As MWNumericArray = Nothing 
      Dim mw_y As MWNumericArray = Nothing 

      ' call an implemental function 
      Dim obj As ODENameSpace.ODE = New ODENameSpace.ODE()

      mw_ArrayOut = obj.myode45secondorder(2, mw_strfunc, mw_tspan, mw_ybc) 
      mw_t        = mw_ArrayOut(0) 
      mw_y        = mw_ArrayOut(1) 
            
      ' convert back to double  
      Dim db_t()  As Double = mw_t.ToVector(MWArrayComponent.Real)
      Dim db_y(,) As Double = mw_y.ToArray(MWArrayComponent.Real) 

      Console.WriteLine("The column of time") 
      Console.WriteLine(mw_t) 

      ' or 
      PrintValues(db_t) 

      Console.WriteLine("The column of the function values y :") 
      ' first column of the matrix y 
      Dim i As Integer 
      Dim aLength As Integer = db_t.Length 

      For i=0 to (aLength-1)

        Console.Write("{0} ", db_y.GetValue(i,0).ToString() ) 
        Console.WriteLine() 

      Next

      Console.WriteLine("The column of the first derivative y' :") 
      ' second column of the matrix y 
      For i=0 to (aLength-1)

        Console.Write("{0} ", db_y.GetValue(i,1).ToString() ) 
        Console.WriteLine() 

      Next

      ' free memory 
      mw_strfunc.Dispose()  
      mw_tspan.Dispose()  
      mw_ybc.Dispose() 
      mw_t.Dispose()      
      mw_y.Dispose()      

      MWNumericArray.DisposeArray(mw_ArrayOut) 

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
