Imports System
Imports MathWorks.MATLAB.NET.Utility
Imports MathWorks.MATLAB.NET.Arrays
Imports PlusNameSpace

Module Module1

  Sub Main()

    Dim objVB As PlusClass = New PlusClass()

    Dim a As Double = 1.1
    Dim b As Double = 2.2
    Dim c As Double

    Dim mw_a As MWNumericArray = New MWNumericArray(a)
    Dim mw_b As MWNumericArray = New MWNumericArray(b)
    Dim mw_c As MWNumericArray = Nothing

    mw_c = objVB.myplus(mw_a, mw_b)

    c = mw_c.ToScalarDouble()

    Console.WriteLine(mw_c)
    mw_a.Dispose()
    mw_b.Dispose()
    mw_c.Dispose()

    Console.WriteLine()
    Console.WriteLine(c)

  End Sub

End Module