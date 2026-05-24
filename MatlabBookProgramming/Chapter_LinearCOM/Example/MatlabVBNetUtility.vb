Public Class MatlabVBNet

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

  ' ******************************** 
  Public Function CopyToMatrixDouble(ByVal myArr As Object) As Double(,)
    Dim myEnumerator As System.Collections.IEnumerator = _
       myArr.GetEnumerator()

    Dim i As Integer = 0
    Dim j As Integer = 0

    Dim col As Integer = myArr.GetLength(myArr.Rank - 1)
    Dim row As Integer = myArr.GetLength(myArr.Rank - 2)

    'Dim m As Integer
    Dim db_matrix(row - 1, col - 1) As Double

    For i = 0 To row - 1
      For j = 0 To col - 1
        myEnumerator.MoveNext()
        db_matrix(i, j) = myEnumerator.Current
      Next
    Next

    Return db_matrix
  End Function

  ' ******************************** 
  Public Function CopyToVectorDouble(ByVal myArr As Object) As Double()
    Dim myEnumerator As System.Collections.IEnumerator = _
       myArr.GetEnumerator()

    Dim i As Integer = 0
    Dim row = myArr.Length
    Dim db_vector(row - 1) As Double

    For i = 0 To row - 1
      myEnumerator.MoveNext()
      db_vector(i) = myEnumerator.Current

    Next

    Return db_vector

  End Function

  ' ******************************** 
  Public Sub ConvertComplexObjToObjs(ByRef obj_Real As Object, _
              ByRef obj_Imag As Object, ByVal objML As Object)

    Dim check As Boolean = False
    check = objML.GetType().IsCOMObject()

    If (check = True) Then
      'for complex number
      obj_Real = objML.Real()
      obj_Imag = objML.Imag()

    Else
      'for real number
      ConvertRealObjToDouble(obj_Real, obj_Imag, objML)

    End If

  End Sub

  ' ******************************** 
  Public Sub ConvertRealObjToDouble(ByRef obj_Real As Object, _ 
             ByRef obj_Imag As Object, ByVal objML As Object)

    'assign values for real terms
    obj_Real = objML

    'assign zeros for all imaginary terms		
    'for a vector or a scalar
    If (objML.Rank = 1) Then

      Dim row = objML.Length

      'for a scalar
      If (row <= 1) Then
        Dim db_scalar As Double
        db_scalar = 0
        obj_Imag = CObj(db_scalar)

        'for a vector
      Else
        Dim db_vector(row - 1) As Double
        Dim i As Integer

        For i = 0 To row - 1
          db_vector(i) = 0
        Next

        obj_Imag = CObj(db_vector)
      End If

    End If

    'for a matrix
    If (objML.Rank = 2) Then

      Dim i As Integer = 0
      Dim j As Integer = 0

      Dim col As Integer = objML.GetLength(objML.Rank - 1)
      Dim row As Integer = objML.GetLength(objML.Rank - 2)

      'Dim m As Integer
      Dim db_matrix(row - 1, col - 1) As Double

      For i = 0 To row - 1
        For j = 0 To col - 1

          db_matrix(i, j) = 0
        Next
      Next

      obj_Imag = CObj(db_matrix)
    End If


  End Sub

End Class