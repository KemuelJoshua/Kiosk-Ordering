Imports System.Data.OleDb

Public Class ChangePass
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")
    Dim dr As OleDbDataReader
    Dim previous As String

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If confirmPass.UseSystemPasswordChar Then

            confirmPass.UseSystemPasswordChar = False
            newpass.UseSystemPasswordChar = False
            oldpass.UseSystemPasswordChar = False
        Else
            confirmPass.UseSystemPasswordChar = True
            newpass.UseSystemPasswordChar = True
            oldpass.UseSystemPasswordChar = True

        End If

    End Sub
    Private Sub btnsubmit_MouseHover(sender As Object, e As EventArgs) Handles btnsubmit.MouseHover

        btnsubmit.ForeColor = Color.White
        btnsubmit.BackColor = Color.Green




    End Sub

    Private Sub btnsubmit_MouseLeave(sender As Object, e As EventArgs) Handles btncancel.MouseLeave

        btncancel.ForeColor = Color.Black
        btncancel.BackColor = Color.Yellow


    End Sub
    Private Sub btncancel_MouseHover(sender As Object, e As EventArgs) Handles btncancel.MouseHover

        btncancel.ForeColor = Color.Black
        btncancel.BackColor = Color.Yellow




    End Sub

    Private Sub btncancel_MouseLeave(sender As Object, e As EventArgs) Handles btncancel.MouseLeave

        btncancel.ForeColor = Color.White
        btncancel.BackColor = Color.Green


    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        Try
            If previous <> oldpass.Text Then
                MessageBox.Show("Old Password did not match.", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            End If

            If newpass.Text <> confirmPass.Text Then
                MessageBox.Show("Confirm Password did not match.", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            End If
            con.Open()
            Dim cm = New OleDbCommand("update tbladmin set [password] = @password where [username] = @username", con)
            With cm
                .Parameters.AddWithValue("@password", newpass.Text)
                .Parameters.AddWithValue("@username", usr2.Text)
                .ExecuteNonQuery()
            End With
            con.Close()
            newpass.Clear()
            oldpass.Clear()
            confirmPass.Clear()
            usr2.Clear()
            MessageBox.Show("Your Password has succefully changed", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)


        Catch ex As Exception

        End Try


    End Sub

    Private Sub usr2_TextChanged(sender As Object, e As EventArgs) Handles usr2.TextChanged
        Try
            con.Open()
            Dim cm = New OleDbCommand("SELECT * FROM tbladmin WHERE [username] = @username ", con)
            cm.Parameters.AddWithValue("@user", usr2.Text)
            dr = cm.ExecuteReader
            dr.Read()

            If dr.HasRows Then
                oldpass.Enabled = True
                newpass.Enabled = True
                confirmPass.Enabled = True
                previous = dr.Item("password").ToString

            Else
                previous = ""
                oldpass.Enabled = False
                newpass.Enabled = False
                confirmPass.Enabled = False


            End If
            con.Close()


        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical
                   )

        End Try

    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        ACCOUNT_REG.Show()
        Me.Hide()
    End Sub

    Private Sub oldpass_TextChanged(sender As Object, e As EventArgs) Handles oldpass.TextChanged

    End Sub

    Private Sub ChangePass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        newpass.Clear()
        oldpass.Clear()
        confirmPass.Clear()
        usr2.Clear()
    End Sub
End Class