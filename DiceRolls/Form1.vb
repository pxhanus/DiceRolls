Public Class Form1

    Private Sub btnRollDice_Click(sender As Object, e As EventArgs) Handles btnRollDice.Click
        Dim numRolls As Integer = Val(Me.txtNumRolls.Text)
        Dim rollOutcomes(18) As Integer

        Me.lstResults.Items.Clear()

        Call RollDice(rollOutcomes, numRolls)
        Call DisplayRolls(Me.lstResults, rollOutcomes)
    End Sub
    '********************************************************************************************
    'RollDice
    'fall an array with indexed results of the sum of two dice rolls
    'pre:   An appropriately sized array - size 13
    'post:  Returns a filled array
    '********************************************************************************************
    Sub RollDice(ByRef array() As Integer, ByVal num As Integer)
        Dim rollSum As Integer


        For count As Integer = 1 To num
            rollSum = RndInt(1, 6) + RndInt(1, 6) + RndInt(1, 6)
            array(rollSum) += 1
        Next
    End Sub
    '********************************************************************************************
    'RndInt
    'Returns a random integer between max and min
    '
    'post:  A number is returned
    '********************************************************************************************
    Function RndInt(ByVal min As Integer, ByVal max As Integer) As Integer
        Randomize()
        Return Int((max - min + 1) * Rnd() + min)
    End Function
    '********************************************************************************************
    'DisplayRolls
    'Displays the contents of the passed array in the passed list box
    '
    'post:  Array results displayed in list box 
    '********************************************************************************************
    Sub DisplayRolls(ByRef lstbox As ListBox, ByRef array() As Integer)
        For index As Integer = 3 To array.Length - 1
            lstbox.Items.Add(index & vbTab & array(index))
        Next
    End Sub
End Class
