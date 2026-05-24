Imports System
Imports CreateCOM

Module Module1

  Sub Main()
    Dim objPro As Example = New Example()

    Dim result As Double = objPro.CalculatePlus(1.2, 3.4)
    Console.WriteLine("Result :{0}", result.ToString())

  End Sub

  Public Class Example

    Public Function CalculatePlus(ByVal db_a As Double, _
                       ByVal db_b As Double) As Double

      Dim objMatlab As MyCOM = New MyCOM()

      Dim obj_A As Object
      obj_A = CObj(db_a)

      Dim obj_B As Object
      obj_B = CObj(db_b)

      Dim obj_C As Object
      obj_C = CObj(0)

      ' call the implemental function
      objMatlab.myplus(1, obj_C, obj_A, obj_B)

      Dim db_c As Double = CDbl(obj_C)

      Return db_c

    End Function

  End Class

End Module
