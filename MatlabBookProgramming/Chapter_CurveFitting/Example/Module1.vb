Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports CurveFittingNameSpace

Module Module1

  Sub Main()
    Dim objVB As Example = New Example()

    Console.WriteLine(" Matlab VB .NET for Curve Fititng Toolbox. ") 

    'objVB.CurveFittingInfo() 
    'objVB.CurveFittingPlots() 
    objVB.CurveFittingPlotsAdvance() 

  End Sub

  Public Class Example

    ' **************************** 
    Public Sub CurveFittingInfo()
    
      Dim X() As Double = {0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600} 

      Dim Y() As Double = {0.4000, 0.2426, 0.1472, 0.0893, 0.0541, 0.0328, 0.0199,  _ 
            0.0121, 0.0073, 0.0044, 0.0027, 0.0016,  0.0010 } 

      Dim mw_X As MWNumericArray = New MWNumericArray(X) 
      Dim mw_Y As MWNumericArray = New MWNumericArray(Y) 

      Dim mw_ArrayOut()         As MWArray        = Nothing
      Dim mwChar_formula        As MWCharArray    = Nothing
      Dim mwCell_coeffnames     As MWCellArray    = Nothing
      Dim mwDouble_coeffvalues  As MWNumericArray = Nothing
      Dim mwDouble_confint      As MWNumericArray = Nothing
      Dim mwStructure_info      As MWStructArray  = Nothing
      Dim curveFitLib           As String         = "exp2" 
     
      Dim objMatlab As CurveFittingNameSpace.CurveFitting = _ 
                   New CurveFittingNameSpace.CurveFitting()

      mw_X = objMatlab.mytranspose(mw_X) 
      mw_Y = objMatlab.mytranspose(mw_Y) 

      mw_ArrayOut = objMatlab.CurveFittings(5,mw_X, mw_Y, curveFitLib) 

      mwChar_formula       = CType( mw_ArrayOut(0), MWCharArray   )   
      mwCell_coeffnames    = CType( mw_ArrayOut(1), MWCellArray   ) 
      mwDouble_coeffvalues = CType( mw_ArrayOut(2), MWNumericArray) 
      mwDouble_coeffvalues = CType( mw_ArrayOut(2), MWNumericArray)
      mwDouble_confint     = CType( mw_ArrayOut(3), MWNumericArray)
      mwStructure_info     = CType( mw_ArrayOut(4), MWStructArray )

      ' This output works as well      
      'Console.WriteLine(mwChar_formula      ) 
      'Console.WriteLine(mwCell_coeffnames   ) 
      'Console.WriteLine(mwDouble_coeffvalues) 
      'Console.WriteLine(mwDouble_confint    ) 
      'Console.WriteLine(mwStructure_info    ) 

      Dim str_formula As String  = mwChar_formula.ToString()  
      Console.WriteLine("Curve fitting formula :") 
      Console.WriteLine(str_formula) 
      Console.WriteLine() 

      Dim str_coeffnames As String = mwCell_coeffnames.ToString() 
      Console.WriteLine("Coefficient names:") 
      Console.WriteLine(str_coeffnames) 
      Console.WriteLine() 

      Dim db_coeffvalues() As Double = mwDouble_coeffvalues.ToVector(MWArrayComponent.Real) 
      Console.WriteLine("Coefficient values:") 
      PrintValues(db_coeffvalues)
      Console.WriteLine() 

      Dim confidentInterval(,) As Double = mwDouble_confint.ToArray(MWArrayComponent.Real) 
      Console.WriteLine("Confidence interval:")
      PrintValues(confidentInterval) 
      Console.WriteLine() 

      Console.WriteLine("Error info:") 
      Dim str_info As String = mwStructure_info.ToString() 
      Console.WriteLine(str_info) 

      ' Free memory
      mw_X.Dispose() 
      mw_Y.Dispose() 

      MWNumericArray.DisposeArray(mw_ArrayOut) 

      mwChar_formula.Dispose()      
      mwCell_coeffnames.Dispose()     
      mwDouble_coeffvalues.Dispose() 
      mwDouble_confint.Dispose()   

      mwStructure_info.Dispose()    
    End Sub

    ' **************************** 
    Public Sub CurveFittingPlots()
    
      Dim X() As Double = {0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600} 

      Dim Y() As Double = {0.4000, 0.2426, 0.1472, 0.0893, 0.0541, 0.0328, 0.0199, _ 
            0.0121, 0.0073, 0.0044, 0.0027, 0.0016,  0.0010 } 

      Dim mw_X As MWNumericArray = New MWNumericArray(X) 
      Dim mw_Y As MWNumericArray = New MWNumericArray(Y) 

      Dim mw_ArrayOut()         As MWArray          = Nothing
      Dim mwChar_formula        As MWCharArray      = Nothing
      Dim mwCell_coeffnames     As MWCellArray      = Nothing
      Dim mwDouble_coeffvalues  As MWNumericArray   = Nothing
      Dim mwDouble_confint      As MWNumericArray   = Nothing
      Dim mwStructure_info      As MWStructArray    = Nothing
      Dim curveFitLib           As String           = "poly3" 

      Dim objMatlab As CurveFittingNameSpace.CurveFitting = _ 
                   New CurveFittingNameSpace.CurveFitting()

      mw_X = objMatlab.mytranspose(mw_X) 
      mw_Y = objMatlab.mytranspose(mw_Y) 

      mw_ArrayOut = objMatlab.CurveFittingWithPlots(5,mw_X, mw_Y, curveFitLib) 

      mwChar_formula       = CType( mw_ArrayOut(0), MWCharArray    )
      mwCell_coeffnames    = CType( mw_ArrayOut(1), MWCellArray    )
      mwDouble_coeffvalues = CType( mw_ArrayOut(2), MWNumericArray )
      mwDouble_confint     = CType( mw_ArrayOut(3), MWNumericArray )
      mwStructure_info     = CType( mw_ArrayOut(4), MWStructArray  )

      ' This output works as well
      '
      'Console.WriteLine(mwChar_formula      ) 
      'Console.WriteLine(mwCell_coeffnames   ) 
      'Console.WriteLine(mwDouble_coeffvalues) 
      'Console.WriteLine(mwDouble_confint    ) 
      'Console.WriteLine(mwStructure_info    ) 


      Dim str_formula As String = mwChar_formula.ToString() 
      Console.WriteLine("Curve fitting formula :") 
      Console.WriteLine(str_formula) 
      Console.WriteLine() 

      Dim str_coeffnames As String = mwCell_coeffnames.ToString()
      Console.WriteLine("Coefficient names:") 
      Console.WriteLine(str_coeffnames) 
      Console.WriteLine() 

      Dim db_coeffvalues() As Double = mwDouble_coeffvalues.ToVector(MWArrayComponent.Real) 
      Console.WriteLine("Coefficient values:") 
      PrintValues(db_coeffvalues)
      Console.WriteLine()

      Dim confidentInterval(,) As Double = mwDouble_confint.ToArray(MWArrayComponent.Real) 
      Console.WriteLine("Confidence interval:")
      PrintValues(confidentInterval) 
      Console.WriteLine() 

      Console.WriteLine("Error info:") 
      Dim str_info As String = mwStructure_info.ToString() 
      Console.WriteLine(str_info) 

      objMatlab.WaitForFiguresToDie() 

      ' Free memory
      mw_X.Dispose() 
      mw_Y.Dispose() 

      MWNumericArray.DisposeArray(mw_ArrayOut) 

      mwChar_formula.Dispose()      
      mwCell_coeffnames.Dispose()     
      mwDouble_coeffvalues.Dispose() 
      mwDouble_confint.Dispose()   

      mwStructure_info.Dispose()    
    
    End Sub
    ' **************************** 

    Public Sub CurveFittingPlotsAdvance()
    
      Dim X() As Double = {0, 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600} 

      Dim Y() As Double = {0.4000, 0.2426, 0.1472, 0.0893, 0.0541, 0.0328, 0.0199, _ 
            0.0121, 0.0073, 0.0044, 0.0027, 0.0016,  0.0010 } 

      Dim mw_X As MWNumericArray = New MWNumericArray(X) 
      Dim mw_Y As MWNumericArray = new MWNumericArray(Y) 

      Dim mw_ArrayOut()         As MWArray        = Nothing
      Dim mwChar_formula        As MWCharArray    = Nothing
      Dim mwCell_coeffnames     As MWCellArray    = Nothing
      Dim mwDouble_coeffvalues  As MWNumericArray = Nothing
      Dim mwDouble_confint      As MWNumericArray = Nothing
      Dim mwStructure_info      As MWStructArray  = Nothing
      Dim curveFitLib           As String         = "poly3" 
      
      Dim objMatlab As CurveFittingNameSpace.CurveFitting = _ 
                   New CurveFittingNameSpace.CurveFitting()

      mw_X = objMatlab.mytranspose(mw_X) 
      mw_Y = objMatlab.mytranspose(mw_Y) 

      Dim graphicTitle As String = "Curve Fitting Graphics" 
      Dim xlabel       As String = "Force" 
      Dim ylabel       As String = "Voltage" 

      Dim curveFittingColor As String = "r" 
      Dim curveDataColor    As String = "g"

      Dim curveFittingLegend As String = "My curve fitting" 
      Dim dataLegend         As String = "My data" 

      mw_ArrayOut = objMatlab.CurveFittingWithPlotsAdvance(5,mw_X, mw_Y, curveFitLib, _
              graphicTitle,xlabel,ylabel, _ 
              curveFittingColor,curveDataColor,curveFittingLegend,dataLegend) 
      
      mwChar_formula       = CType( mw_ArrayOut(0), MWCharArray     )
      mwCell_coeffnames    = CType( mw_ArrayOut(1), MWCellArray     )
      mwDouble_coeffvalues = CType( mw_ArrayOut(2), MWNumericArray  )
      mwDouble_confint     = CType( mw_ArrayOut(3), MWNumericArray  )
      mwStructure_info     = CType( mw_ArrayOut(4), MWStructArray   )

      ' This output works as well
      
      'Console.WriteLine(mwChar_formula      ) 
      'Console.WriteLine(mwCell_coeffnames   ) 
      'Console.WriteLine(mwDouble_coeffvalues) 
      'Console.WriteLine(mwDouble_confint    ) 
      'Console.WriteLine(mwStructure_info    ) 
      
      Dim str_formula As String = mwChar_formula.ToString() 
      Console.WriteLine("Curve fitting formula :") 
      Console.WriteLine(str_formula) 
      Console.WriteLine() 

      Dim str_coeffnames As String = mwCell_coeffnames.ToString()
      Console.WriteLine("Coefficient names:") 
      Console.WriteLine(str_coeffnames) 
      Console.WriteLine() 

      Dim db_coeffvalues() As Double = mwDouble_coeffvalues.ToVector( _ 
                                                    MWArrayComponent.Real) 
      Console.WriteLine("Coefficient values:") 
      PrintValues(db_coeffvalues)
      Console.WriteLine() 

      Dim confidentInterval(,) As Double = mwDouble_confint.ToArray( _ 
                                                    MWArrayComponent.Real) 
      Console.WriteLine("Confidence interval:")
      PrintValues(confidentInterval) 
      Console.WriteLine() 

      Console.WriteLine("Error info:") 
      Dim str_info As String = mwStructure_info.ToString()
      Console.WriteLine(str_info) 
      objMatlab.WaitForFiguresToDie() 

      ' Free memory
      mw_X.Dispose() 
      mw_Y.Dispose() 

      MWNumericArray.DisposeArray(mw_ArrayOut) 

      mwChar_formula.Dispose()      
      mwCell_coeffnames.Dispose()     
      mwDouble_coeffvalues.Dispose() 
      mwDouble_confint.Dispose()   

      mwStructure_info.Dispose()    
    
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
