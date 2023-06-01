Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()

    End Sub


    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.Black
        Label1.BackColor = Color.Yellow


    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave

        Label1.ForeColor = Color.White
        Label1.BackColor = Color.Transparent

    End Sub

    Private Sub merchantbtn_Click(sender As Object, e As EventArgs) Handles merchantbtn.Click
        MERCHANT_LOGIN.Show()
        Me.Hide()

    End Sub
    Private Sub merchantbtn_MouseHover(sender As Object, e As EventArgs) Handles merchantbtn.MouseHover

        merchantbtn.ForeColor = Color.Black
        merchantbtn.BackColor = Color.OrangeRed




    End Sub

    Private Sub merchantbtn_MouseLeave(sender As Object, e As EventArgs) Handles merchantbtn.MouseLeave

        merchantbtn.ForeColor = Color.White
        merchantbtn.BackColor = Color.Red


    End Sub

    Private Sub dashbtn_Click(sender As Object, e As EventArgs) Handles dashbtn.Click
        DASHBOARD.Show()
        Me.Hide()
    End Sub

    Private Sub dashbtn_MouseHover(sender As Object, e As EventArgs) Handles dashbtn.MouseHover

        dashbtn.ForeColor = Color.Black
        dashbtn.BackColor = Color.OrangeRed




    End Sub

    Private Sub dashbtn_MouseLeave(sender As Object, e As EventArgs) Handles dashbtn.MouseLeave

        dashbtn.ForeColor = Color.White
        dashbtn.BackColor = Color.Red


    End Sub

    Private Sub adminbtn_Click(sender As Object, e As EventArgs) Handles adminbtn.Click
        ADMIN_LOGIN.Show()
        Me.Hide()
    End Sub

    Private Sub adminbtn_MouseHover(sender As Object, e As EventArgs) Handles adminbtn.MouseHover

        adminbtn.ForeColor = Color.Black
        adminbtn.BackColor = Color.OrangeRed




    End Sub

    Private Sub adminbtn_MouseLeave(sender As Object, e As EventArgs) Handles adminbtn.MouseLeave

        adminbtn.ForeColor = Color.White
        adminbtn.BackColor = Color.Red


    End Sub
End Class
