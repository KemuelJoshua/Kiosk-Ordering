
Imports System.Data.OleDb
Imports System.IO


Public Class ACCOUNT_REG


    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")





    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click

        imagepath.Enabled = False

        If storeCode.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR USERNAME", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



            storeCode.Focus()

            Exit Sub
        End If


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

        If imagepath.Text = "" Then
            MessageBox.Show("PLEASE CHOOSE AN IMAGE FOR YOUR STORE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            imagepath.Focus()
            Exit Sub
        End If




        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("UPDATE `tblaccts1` SET `StoreCODE`=[@STORE CODE],`USERNAME`=@USERNAME,`PASSWORD`=@PASSWORD,`StoreNAME`=[@STORE NAME], `ImagePath`= [@IMAGE PATH],`IMAGE`=@IMAGE WHERE `StoreCODE`=[@STORE CODE]", conn)
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
            cmd.Parameters.AddWithValue("@StoreCODE", storeCode.Text)
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("YOUR RECORD IS SUCCESFULLY UPDATED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else

                MessageBox.Show("YOUR MUST SELECT A ROW TO DELETE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If

            storeCode.Clear()
            usr1.Clear()
            password1.Clear()
            storeName.Clear()
            imagepath.Clear()
            PictureBox1.Image = Nothing
            storeCode.Enabled = True
            addbtn.Enabled = True
            updatebtn.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        DGV_load()
        DASHBOARD.imageload()






    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles editbtn.Click


        Dim i As Integer

        i = DataGridView1.CurrentRow.Index
        storeCode.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        usr1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        password1.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        storeName.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        imagepath.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

        Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(5).Value
        Dim ms As New MemoryStream(bytes)
        PictureBox1.Image = Image.FromStream(ms)
        addbtn.Enabled = False
        imagepath.Enabled = False
        storeCode.Enabled = False
        addbtn.Enabled = False
        updatebtn.Enabled = True
        deletebtn.Enabled = True

    End Sub

    Private Sub addbtn_Click(sender As Object, e As EventArgs) Handles addbtn.Click

        imagepath.Enabled = False

        If storeCode.Text = "" Then
            MessageBox.Show("PLEASE ENTER YOUR USERNAME", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



            storeCode.Focus()

            Exit Sub
        End If




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


        If imagepath.Text = "" Then
            MessageBox.Show("PLEASE CHOOSE AN IMAGE FOR YOUR STORE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            imagepath.Focus()
            Exit Sub
        End If



        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("insert into tblaccts1(`StoreCODE`,`USERNAME`,`PASSWORD`,`StoreNAME`,`ImagePath`,`IMAGE`) values (@StoreCODE,@USERNAME,@PASSWORD,@StoreNAME,@ImagePath,@IMAGE)", conn)
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

            storeCode.Clear()
            usr1.Clear()
            password1.Clear()
            storeName.Clear()
            imagepath.Clear()
            PictureBox1.Image = Nothing
            editbtn.Enabled = True
            updatebtn.Enabled = True
            deletebtn.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
        DGV_load()
        DASHBOARD.imageload()
    End Sub


    Private Sub deletebtn_Click(sender As Object, e As EventArgs) Handles deletebtn.Click

        Dim i As Integer
        i = DataGridView1.CurrentRow.Index

        If (MessageBox.Show("Are you sure you want to delete this record?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then

            conn.Open()
            storeCode.Text = DataGridView1.Item(0, i).Value.ToString()
            Dim cmd As New OleDb.OleDbCommand("DELETE FROM tblaccts1 WHERE StoreCODE= @StoreCODE", conn)
            cmd.Parameters.AddWithValue("@StoreCODE", storeCode.Text)
            cmd.ExecuteNonQuery()

            Dim cd As New OleDb.OleDbCommand("DELETE * FROM tblmerchant WHERE txtCode = @StoreCODE", conn)
            cd.Parameters.AddWithValue("@StoreCODE", storeCode.Text)
            cd.ExecuteNonQuery()


            MessageBox.Show("YOUR RECORD IS SUCCESFULLY DELETED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)


            conn.Close()
            DGV_load()
            DASHBOARD.imageload()
            storeCode.Clear()
        Else


            MessageBox.Show("YOUR MUST SELECT A ROW TO DELETE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If DialogResult.No Then
                Me.Show()
            End If

        End If






    End Sub

    Private Sub ACCOUNT_REG_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        storeCode.Clear()
        usr1.Clear()
        password1.Clear()
        storeName.Clear()
        PictureBox1.Image = Nothing
        imagepath.Enabled = False


        DGV_load()

    End Sub

    Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("SELECT * FROM tblaccts1", conn)
            dr = cmd.ExecuteReader


            While dr.Read
                DataGridView1.Rows.Add(dr.Item("StoreCODE"), dr.Item("USERNAME"), dr.Item("PASSWORD"), dr.Item("StoreNAME"), dr.Item("ImagePath"), dr.Item("IMAGE"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
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

    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        OpenFileDialog1.ShowDialog()
        imagepath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub change_Click(sender As Object, e As EventArgs) Handles change.Click
        ChangePass.Show()
        Me.Hide()
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click

        If MessageBox.Show("ARE YOU SURE YOU WANT TO LOGOUT?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub browse_MouseHover(sender As Object, e As EventArgs) Handles browse.MouseHover

        browse.ForeColor = Color.White
        browse.BackColor = Color.DarkGreen




    End Sub

    Private Sub browse_MouseLeave(sender As Object, e As EventArgs) Handles browse.MouseLeave

        browse.ForeColor = Color.Black
        browse.BackColor = Color.Yellow

    End Sub



    Private Sub deletebtn_MouseHover(sender As Object, e As EventArgs) Handles deletebtn.MouseHover

        deletebtn.ForeColor = Color.Black
        deletebtn.BackColor = Color.Yellow




    End Sub

    Private Sub deletebtn_MouseLeave(sender As Object, e As EventArgs) Handles deletebtn.MouseLeave

        deletebtn.ForeColor = Color.White
        deletebtn.BackColor = Color.Red

    End Sub

    Private Sub updatebtn_MouseHover(sender As Object, e As EventArgs) Handles updatebtn.MouseHover

        updatebtn.ForeColor = Color.White
        updatebtn.BackColor = Color.Green




    End Sub

    Private Sub updatebtn_MouseLeave(sender As Object, e As EventArgs) Handles updatebtn.MouseLeave

        updatebtn.ForeColor = Color.Black
        updatebtn.BackColor = Color.Yellow

    End Sub

    Private Sub addbtn_MouseHover(sender As Object, e As EventArgs) Handles addbtn.MouseHover

        addbtn.ForeColor = Color.White
        addbtn.BackColor = Color.Green




    End Sub

    Private Sub addbtn_MouseLeave(sender As Object, e As EventArgs) Handles addbtn.MouseLeave

        addbtn.ForeColor = Color.Black
        addbtn.BackColor = Color.Yellow



    End Sub

    Private Sub change_MouseHover(sender As Object, e As EventArgs)

        change.ForeColor = Color.Black
        change.BackColor = Color.Yellow




    End Sub

    Private Sub change_MouseLeave(sender As Object, e As EventArgs)

        change.ForeColor = Color.White
        change.BackColor = Color.DarkGreen

    End Sub
    Private Sub logout_MouseHover(sender As Object, e As EventArgs)

        logout.ForeColor = Color.Black
        logout.BackColor = Color.Yellow




    End Sub

    Private Sub logout_MouseLeave(sender As Object, e As EventArgs)

        logout.ForeColor = Color.White
        logout.BackColor = Color.Red

    End Sub

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridView1.CellFormatting
        If CheckBox1.Checked = False Then
            If e.ColumnIndex = 2 Then
                If e.Value IsNot Nothing Then
                    e.Value = New String("•", e.Value.ToString().Length)
                End If
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        DGV_load()
    End Sub
End Class
