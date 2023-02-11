Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblInstructions.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        lblFrench.Text = "un"
        lblFrench.Visible = True
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        lblFrench.Text = "deux"
        lblFrench.Visible = True

    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        lblFrench.Text = "trios"
        lblFrench.Visible = True

    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        lblFrench.Text = "quatre"
        lblFrench.Visible = True

    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        lblFrench.Text = "cinq"
        lblFrench.Visible = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub lblFrench_Click(sender As Object, e As EventArgs) Handles lblFrench.Click

    End Sub
End Class
