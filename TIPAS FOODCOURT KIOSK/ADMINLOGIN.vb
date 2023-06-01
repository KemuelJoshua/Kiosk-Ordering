
Imports System.Data.OleDb

Public Class ADMIN_LOGIN


    Dim drag As Boolean


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If passW.UseSystemPasswordChar Then

            passW.UseSystemPasswordChar = False

        Else
            passW.UseSystemPasswordChar = True

        End If

    End Sub

    Private Sub btnlogin_MouseHover(sender As Object, e As EventArgs) Handles btnlogin.MouseHover

        btnlogin.ForeColor = Color.White
        btnlogin.BackColor = Color.Red




    End Sub

    Private Sub btnlogin_MouseLeave(sender As Object, e As EventArgs) Handles btnlogin.MouseLeave

        btnlogin.ForeColor = Color.Black
        btnlogin.BackColor = Color.Yellow


    End Sub
    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tbladmin WHERE username = '" & _usr.Text & "' AND [password] = '" & passW.Text & "' ", con)

        Dim user As String = ""

        Dim pass As String = ""


        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then

            user = sdr("username")

            pass = sdr("password")

            ACCOUNT_REG.Show()
            usr.Clear()
            passW.Clear()
            Me.Hide()

        Else

            MessageBox.Show("Invalid username or password", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)
            usr.Clear()
            passW.Clear()

        End If




    End Sub

    Private Sub ADMIN_LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class