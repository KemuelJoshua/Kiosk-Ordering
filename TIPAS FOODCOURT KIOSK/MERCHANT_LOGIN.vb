Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class MERCHANT_LOGIN


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If passWord.UseSystemPasswordChar Then

            passWord.UseSystemPasswordChar = False

        Else
            passWord.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin1.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tblaccts1 WHERE USERNAME = '" & _usrr.Text & "' AND [PASSWORD] = '" & passWord.Text & "' ", con)

        Dim user1 As String = ""

        Dim pass1 As String = ""

        MENUmerchant.StringPass = usrr.Text

        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then

            user1 = sdr("USERNAME")
            pass1 = sdr("PASSWORD")

            MENUmerchant.Show()
            Me.Dispose()

            con.Close()
        Else

            MessageBox.Show("Invalid username or password", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If


    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
    Private Sub usrr_MouseEnter(sender As Object, e As EventArgs) Handles usrr.MouseEnter
        If usrr.Text = "USERNAME" Then
            usrr.Text = ""
            usrr.ForeColor = Color.Black
        End If
    End Sub

    Private Sub usrr_MouseLeave(sender As Object, e As EventArgs) Handles usrr.MouseLeave
        If usrr.Text = " " Then
            usrr.Text = "USERNAME"
            usrr.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub passWord_MouseEnter(sender As Object, e As EventArgs) Handles passWord.MouseEnter
        If passWord.Text = "PASSWORD" Then
            passWord.Text = ""
            passWord.ForeColor = Color.Black
        End If
    End Sub

    Private Sub passWord_MouseLeave(sender As Object, e As EventArgs) Handles passWord.MouseLeave
        If passWord.Text = " " Then
            passWord.Text = "PASSWORD"
            passWord.ForeColor = Color.Gray

        End If
    End Sub

    Private Sub MERCHANT_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class