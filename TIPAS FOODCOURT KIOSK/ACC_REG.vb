Imports System.Data.OleDb
Imports System.Text.RegularExpressions


Public Class ACC_REG

    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")




    Private Sub ACC_REG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        usr1.Clear()
        password1.Clear()
        storeName.Clear()
        PictureBox1.Image = Nothing



    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs)
        Form1.Show()
        Me.Close()
    End Sub
    Private Sub addbtn_MouseHover(sender As Object, e As EventArgs) Handles addbtn.MouseHover

        addbtn.ForeColor = Color.White
        addbtn.BackColor = Color.Green




    End Sub

    Private Sub addbtn_MouseLeave(sender As Object, e As EventArgs) Handles addbtn.MouseLeave

        addbtn.ForeColor = Color.Black
        addbtn.BackColor = Color.Yellow



    End Sub








    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click



        If usr1.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR USERNAME", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



            usr1.Focus()

            Exit Sub
        End If

        If password1.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR PASSWORD", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            password1.Focus()

            Exit Sub
        End If

        If storeName.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR STORE NAME", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            storeName.Focus()
            Exit Sub
        End If




        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("insert into tblaccts12(`StoreCODE`,`USERNAME`,`PASSWORD`,`StoreNAME`,`ImagePath`,`IMAGE`) values (@StoreCODE,@USERNAME,@PASSWORD,@StoreNAME,@ImagePath,@IMAGE)", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@StoreCODE", storeCode.Text)
            cmd.Parameters.AddWithValue("@USERNAME", usr1.Text)
            cmd.Parameters.AddWithValue("@PASSWORD", password1.Text)
            cmd.Parameters.AddWithValue("@StoreNAME", storeName.Text)
            cmd.Parameters.AddWithValue("@ImagePath", imagepath.Text)

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@IMAGE", picture)
            i = cmd.ExecuteNonQuery
            If i > 0 Then

                MessageBox.Show("YOUR RECORD IS SUCCESFULLY ADDED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                MessageBox.Show("YOUR RECORD IS NOT ADDED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        databaseACCOUNT.DGV_load()
        DASHBOARD.imageload()


    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles updatebtn.Click


        If usr1.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR USERNAME", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



            usr1.Focus()

            Exit Sub
        End If

        If password1.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR PASSWORD", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            password1.Focus()

            Exit Sub
        End If

        If storeName.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR STORE NAME", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            storeName.Focus()
            Exit Sub
        End If

        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("UPDATE `tblaccts1` SET `StoreCODE`=@StoreCODE,`USERNAME`=@USERNAME,`PASSWORD`=@PASSWORD,`StoreNAME`=@StoreNAME, `ImagePath`=@ImagePath,`IMAGE`=@IMAGE WHERE `StoreCODE`=@StoreCODE", conn)
            Dim i As New Integer
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@StoreCODE", storeCode.Text)
            cmd.Parameters.AddWithValue("@USERNAME", usr1.Text)
            cmd.Parameters.AddWithValue("@PASSWORD", password1.Text)
            cmd.Parameters.AddWithValue("@StoreNAME", storeName.Text)

            Dim FileSize As New UInt32
            Dim mstream As New System.IO.MemoryStream
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim picture() As Byte = mstream.GetBuffer
            FileSize = mstream.Length
            mstream.Close()
            cmd.Parameters.AddWithValue("@IMAGE", picture)
            cmd.Parameters.AddWithValue("@StoreCODE", storeCode.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("YOUR RECORD IS SUCCESFULLY UPDATED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("YOUR RECORD IS FAILED TO UPDATED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            Me.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        databaseACCOUNT.DGV_load()
        DASHBOARD.imageload()











    End Sub
    Private Sub updatebtn_MouseHover(sender As Object, e As EventArgs) Handles updatebtn.MouseHover

        updatebtn.ForeColor = Color.White
        updatebtn.BackColor = Color.Green




    End Sub

    Private Sub updatebtn_MouseLeave(sender As Object, e As EventArgs) Handles updatebtn.MouseLeave

        updatebtn.ForeColor = Color.Black
        updatebtn.BackColor = Color.Yellow

    End Sub

    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click


        If (MessageBox.Show("Are you sure you want to delete this record?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Try
                conn.Open()
                Dim cmd As New OleDb.OleDbCommand("DELETE FROM `tblaccts1` WHERE `StoreCODE`=@StoreCODE", conn)
                Dim i As New Integer
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@StoreCODE", storeCode.Text)

                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("YOUR RECORD IS SUCCESFULLY DELETED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("YOUR RECORD IS FAILED TO DELETE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
                Me.Dispose()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
            databaseACCOUNT.DGV_load()
            DASHBOARD.imageload()
            storeCode.Clear()

        End If

     



    End Sub
    Private Sub deletebtn_MouseHover(sender As Object, e As EventArgs) Handles deletebtn.MouseHover

        deletebtn.ForeColor = Color.Black
        deletebtn.BackColor = Color.Yellow




    End Sub

    Private Sub deletebtn_MouseLeave(sender As Object, e As EventArgs) Handles deletebtn.MouseLeave

        deletebtn.ForeColor = Color.White
        deletebtn.BackColor = Color.Red

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles browse.Click
        OpenFileDialog1.ShowDialog()
        imagepath.Text = OpenFileDialog1.FileName

    End Sub
    Sub clear()

        storeCode.Clear()
        usr1.Clear()
        password1.Clear()
        storeName.Clear()

        PictureBox1.Image = Nothing







    End Sub
    Private Sub browse_MouseHover(sender As Object, e As EventArgs) Handles browse.MouseHover

        browse.ForeColor = Color.White
        browse.BackColor = Color.DarkGreen




    End Sub

    Private Sub browse_MouseLeave(sender As Object, e As EventArgs) Handles browse.MouseLeave

        browse.ForeColor = Color.Black
        browse.BackColor = Color.Yellow

    End Sub


    Private Sub change_Click(sender As Object, e As EventArgs)
        ChangePass.Show()
        Me.Hide()
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles cls.Click
        Me.Close()
    End Sub

    Private Sub cls_MouseHover(sender As Object, e As EventArgs) Handles cls.MouseHover
        cls.ForeColor = Color.Black
        cls.BackColor = Color.Yellow


    End Sub

    Private Sub cls_MouseLeave(sender As Object, e As EventArgs) Handles cls.MouseLeave

        cls.ForeColor = Color.Red
        cls.BackColor = Color.Transparent

    End Sub

    Private Sub imagepath_TextChanged(sender As Object, e As EventArgs) Handles imagepath.TextChanged
        If (System.IO.File.Exists(imagepath.Text)) Then
            PictureBox1.Image = Image.FromFile(imagepath.Text)
            imagepath.Enabled = True
        End If

        If imagepath.Text = " " Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
        imagepath.Enabled = False
    End Sub
End Class
