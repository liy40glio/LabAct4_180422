Public Class Form1
    Private Function BMI(Height As Single, weight As Single) As Double
        BMI = weight / Height ^ 2
    End Function
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim h As Single, w As Single
        h = Val(TextBox1.Text)
        w = Val(TextBox2.Text)
        LblBMI.Text = BMI(h, w)
    End Sub
End Class
