Public Class endScreen

    Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
        mainShift.Show()
        Me.Close()
        gameShift.Close()
    End Sub
End Class