Public Class Form1
    Dim v1 As Double
    Dim v2 As Double
    Dim total As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        v1 = txtvalor01.Text
        v2 = txtvalor02.Text

        total = v1 + v2

        txttotal.Text = total






    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        v1 = txtvalor01.Text
        v2 = txtvalor02.Text

        total = v1 - v2
        txttotal.Text = total







    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        v1 = txtvalor01.Text
        v2 = txtvalor02.Text

        total = v1 / v2

        txttotal.Text = total



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        v1 = txtvalor01.Text
        v2 = txtvalor02.Text

        total = v1 * v2

        txttotal.Text = total



    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtvalor01.Text = ""
        txtvalor02.Text = ""
        txttotal.Text = ""
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        End

    End Sub
End Class
