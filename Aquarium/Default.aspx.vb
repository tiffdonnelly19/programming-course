
Partial Class _Default
    Inherits System.Web.UI.Page
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Dim dblLength As Double
        Dim dblWidth As Double
        Dim dblHeight As Double
        Dim dblVolume As Double
        Dim dblGals As Double

        Double.TryParse(txtLength.Text, dblLength)
        Double.TryParse(txtWidth.Text, dblWidth)
        Double.TryParse(txtHeight.Text, dblHeight)

        dblVolume = dblLength * dblWidth * dblHeight

        dblGals = dblVolume / 231

        lblGals.Text = dblGals.ToString("n1")

    End Sub

End Class
