Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays

Imports GeneratingGraphicsNameSpace

Module Module1

  Sub Main()

    Dim objVB As Example = New Example()

    Console.WriteLine(" Using the plot function. Please wait. ")

    ' Prolem 1: Plot a simple 2D figure
    'objVB.SimplePlot()

    ' Prolem : Plot a 2D figure by passing arrays            

    'Dim db_vectorX() As Double = New Double() {0, 50, 100, 150, 200, 250, _
    '                                      300, 350, 400, 450, 500, 550, 600}

    'Dim db_vectorY() As Double = New Double() {0.4, 0.2426, 0.1472, 0.0893, _
    '    0.0541, 0.0328, 0.0199, 0.0121, 0.0073, 0.0044, 0.0027, 0.0016, 0.001}

    'objVB.AnotherSimplePlot(db_vectorX, db_vectorY)

    ' Prolem 2: Plot a 2D figure with data from a file
    ' objVB.PloPlotDataFromFile()


    'Problem 3: Plot multiple figures with data from math functions
    'objVB.PlotFromFunctions()

    'Problem 4: Plot multiple figures with data from arrays
    'objVB.MultiPlotFromArrays()

    'Problem 5: Plot multiple figures with data from a file
    objVB.MultiPlotFromFile()

  End Sub

  Public Class Example

    ' **************************** 
    Public Sub SimplePlot()

      Dim db_vectorX() As Double = New Double() {11.1, 22.2, 33.3}
      Dim db_vectorY() As Double = New Double() {110.1, 220.2, 330.3}

      Dim strColor As String = "k" ' k: black, b: blue, r: red

      ' declare mwArray variables 
      Dim mw_X As MWNumericArray = New MWNumericArray(db_vectorX)
      Dim mw_Y As MWNumericArray = New MWNumericArray(db_vectorY)

      ' set color, see color symbols in MATLAB Graphics
      Dim mw_strColor As MWCharArray = New MWCharArray(strColor)

      ' call the implemental function
      Dim objMatlab As GeneratingGraphicsClass = New GeneratingGraphicsClass()
      objMatlab.simplePlot(mw_X, mw_Y, mw_strColor)

      objMatlab.WaitForFiguresToDie()

      'Typically you use WaitForFiguresToDie when:
      '. There are one or more figures open that were created 
      '  by a .NET component created by the builder.
      '. The method that displays the graphics requires user input before continuing.
      '. The method that calls the figures was called from main() in a console program.

      'When WaitForFiguresToDie is called, execution of the calling program is blocked 
      'if any figures created by the calling object remain open.

      mw_strColor.Dispose()
      mw_X.Dispose()
      mw_Y.Dispose()

    End Sub

    ' **************************** 
    Public Sub AnotherSimplePlot(ByVal arrayX() As Double, ByVal arrayY() As Double)

      Dim strColor As String = "b" ' k: black, b: blue, r: red

      ' declare mwArray variables 
      Dim mw_X As MWNumericArray = New MWNumericArray(arrayX)
      Dim mw_Y As MWNumericArray = New MWNumericArray(arrayY)

      ' set color, see color symbols in MATLAB Graphics
      Dim mw_strColor As MWCharArray = New MWCharArray(strColor)

      ' call the implemental function 
      Dim objMatlab As GeneratingGraphicsClass = New GeneratingGraphicsClass()

      objMatlab.simplePlot(mw_X, mw_Y, mw_strColor)
      objMatlab.WaitForFiguresToDie()

      mw_strColor.Dispose()
      mw_X.Dispose()
      mw_Y.Dispose()

    End Sub

    ' **************************** 
    Public Sub PloPlotDataFromFile()

      ' Read data from a file
      Dim fileName As String = "PlottingFile.txt"
      Dim mw_ArrayOut() As MWArray = Nothing
      Dim mw_X As MWNumericArray = Nothing
      Dim mw_Y As MWNumericArray = Nothing

      Dim objMatlab As GeneratingGraphicsClass = New GeneratingGraphicsClass()
      Dim delimiter As String = " " ' blank
      Dim numCol As Integer = 2

      'Value of the first 2 is two of ouput of varargout in mytextread.m
      mw_ArrayOut = objMatlab.mytextread(2, fileName, numCol, delimiter)

      mw_X = mw_ArrayOut(0)
      mw_Y = mw_ArrayOut(1)

      'End of Reading data from a file

      'Set color, see color symbols in MATLAB Graphics
      'Plot graphic
      Dim strColor As String = "r"  'k: black, b: blue, r: red
      Dim mw_strColor As MWCharArray = New MWCharArray(strColor)
      objMatlab.simplePlot(mw_X, mw_Y, mw_strColor)

      objMatlab.WaitForFiguresToDie()

      MWNumericArray.DisposeArray(mw_ArrayOut)
      mw_strColor.Dispose()
      mw_X.Dispose()
      mw_Y.Dispose()

    End Sub

    ' **************************** 
    Public Sub PlotFromFunctions()

      Dim strfunc1 As String = "cos(t)"
      Dim strfunc2 As String = "cos(t + pi/3)"
      Dim strfunc3 As String = "cos(t + 2*pi/3)"

      Dim strPlot1 As MWCharArray = New MWCharArray(strfunc1)
      Dim strPlot2 As MWCharArray = New MWCharArray(strfunc2)
      Dim strPlot3 As MWCharArray = New MWCharArray(strfunc3)

      Dim markerPlot1 As MWCharArray = New MWCharArray("*")
      Dim markerPlot2 As MWCharArray = New MWCharArray("^")
      Dim markerPlot3 As MWCharArray = New MWCharArray("o")

      Dim colorPlot1 As MWCharArray = New MWCharArray("r")    ' red
      Dim colorPlot2 As MWCharArray = New MWCharArray("b")    ' blue
      Dim colorPlot3 As MWCharArray = New MWCharArray("k")    ' black

      Dim strTitle As MWCharArray = New MWCharArray("Figure Legends ")
      Dim strxlabel As MWCharArray = New MWCharArray("My x label ")
      Dim strylabel As MWCharArray = New MWCharArray("My y label ")

      ' call the implemental function 
      Dim objMatlab As GeneratingGraphicsClass = New GeneratingGraphicsClass()

      'Call the implemental function 
      objMatlab.multiPlotForFuncs(strPlot1, colorPlot1, markerPlot1, _
                                  strPlot2, colorPlot2, markerPlot2, _
                                  strPlot3, colorPlot3, markerPlot3, _
                                  strTitle, strxlabel, strylabel)

      objMatlab.WaitForFiguresToDie() 'program will continue after close this figure

      strPlot1.Dispose()
      strPlot2.Dispose()
      strPlot3.Dispose()

      markerPlot1.Dispose()
      markerPlot2.Dispose()
      markerPlot3.Dispose()

      colorPlot1.Dispose()
      colorPlot2.Dispose()
      colorPlot3.Dispose()

      strTitle.Dispose()
      strxlabel.Dispose()
      strylabel.Dispose()

    End Sub

    '    ' **************************** 
    Public Sub MultiPlotFromArrays()

      Dim db_vectort() As Double = New Double() {0.1, 0.2, 0.3}

      Dim db_vectorY1() As Double = New Double() {11.1, 22.2, 33.3}
      Dim db_vectorY2() As Double = New Double() {40.1, 50.2, 60.3}
      Dim db_vectorY3() As Double = New Double() {70.1, 80.2, 90.3}
      Dim db_vectorY4() As Double = New Double() {100.1, 110.2, 120.3}

      ' declare mwArray variables 
      Dim mw_t As MWNumericArray = New MWNumericArray(db_vectort)

      Dim mw_y1 As MWNumericArray = New MWNumericArray(db_vectorY1)
      Dim mw_y2 As MWNumericArray = New MWNumericArray(db_vectorY2)
      Dim mw_y3 As MWNumericArray = New MWNumericArray(db_vectorY3)
      Dim mw_y4 As MWNumericArray = New MWNumericArray(db_vectorY4)

      ' set properties for MATLAB Graphics
      Dim mw_Title As MWCharArray = New MWCharArray("The Title")
      Dim mw_xlabel As MWCharArray = New MWCharArray("time")
      Dim mw_ylabel As MWCharArray = New MWCharArray("voltage")

      ' call the implemental function 
      Dim objMatlab As GeneratingGraphicsClass = New GeneratingGraphicsClass()
      objMatlab.multiPlotForArrays(mw_t, mw_y1, mw_y2, mw_y3, mw_y4, _
                                mw_Title, mw_xlabel, mw_ylabel)

      objMatlab.WaitForFiguresToDie() 'program will continue after close this figure

      mw_t.Dispose()

      mw_y1.Dispose()
      mw_y2.Dispose()
      mw_y3.Dispose()
      mw_y4.Dispose()

      mw_Title.Dispose()
      mw_xlabel.Dispose()
      mw_ylabel.Dispose()

    End Sub

    ''    ' **************************** 
    Public Sub MultiPlotFromFile()

      ' Read data from a file
      Dim fileName As String = "MultiArrays.csv"

      Dim mw_ArrayOut() As MWArray = Nothing

      Dim mw_Col0 As MWNumericArray = Nothing
      Dim mw_Col1 As MWNumericArray = Nothing
      Dim mw_Col2 As MWNumericArray = Nothing
      Dim mw_Col3 As MWNumericArray = Nothing
      Dim mw_Col4 As MWNumericArray = Nothing

      Dim objMatlab As GeneratingGraphicsClass = New GeneratingGraphicsClass()

      Dim delimiter As String = ","  ' comma
      Dim numCol As Integer = 5

      ' Value of the first 5 is five of ouput of varargout in mytextread.m
      mw_ArrayOut = objMatlab.mytextread(5, fileName, numCol, delimiter)

      mw_Col0 = mw_ArrayOut(0)
      mw_Col1 = mw_ArrayOut(1)
      mw_Col2 = mw_ArrayOut(2)
      mw_Col3 = mw_ArrayOut(3)
      mw_Col4 = mw_ArrayOut(4)

      ' End of Reading data from a file

      ' set properties for MATLAB Graphics
      Dim mw_Title As MWCharArray = New MWCharArray("The Title")
      Dim mw_xlabel As MWCharArray = New MWCharArray("time")
      Dim mw_ylabel As MWCharArray = New MWCharArray("voltage")

      ' Call the implemental function
      objMatlab.multiPlotForArrays(mw_Col0, mw_Col1, mw_Col2, mw_Col3, mw_Col4, _
                                mw_Title, mw_xlabel, mw_ylabel)

      objMatlab.WaitForFiguresToDie() ' program will continue after close this figure

      MWNumericArray.DisposeArray(mw_ArrayOut)
      mw_Col0.Dispose()
      mw_Col1.Dispose()
      mw_Col2.Dispose()
      mw_Col3.Dispose()
      mw_Col4.Dispose()

      mw_Title.Dispose()
      mw_xlabel.Dispose()
      mw_ylabel.Dispose()

    End Sub

  End Class

End Module

