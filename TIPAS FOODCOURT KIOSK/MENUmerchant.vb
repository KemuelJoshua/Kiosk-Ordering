
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class MENUmerchant

    Public Property StringPass As String
    Dim cn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")




    Private Sub MENUmerchant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dv_Load()

        fcode.Clear()
        descrip.Clear()
        price.Clear()
        path1.Clear()
        status1.SelectedIndex = -1
        PictureBox1.Image = Nothing
        path1.Enabled = False
        txtCode.Enabled = False






    End Sub

    Sub Dv_Load()
        DataGridView1.Rows.Clear()
        Dim plos As String
        plos = StringPass

        cn.Open()
        Dim dd As New OleDb.OleDbCommand("SELECT StoreCode FROM tblaccts1 where USERNAME = @plos", cn)
        dd.Parameters.AddWithValue("@plos", StringPass)
        Dim reader As OleDbDataReader
        reader = dd.ExecuteReader()


        reader.Read()
        txtCode.Text = reader("StoreCode")

        Try

            Dim cmd As New OleDb.OleDbCommand("SELECT * FROM tblmerchant Where txtCode = @code", cn)
        cmd.Parameters.AddWithValue("@code", reader("StoreCode"))
        dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("FoodCode").ToString, dr.Item("DESCRIPTION").ToString, dr.Item("PRICE").ToString, dr.Item("STATUS").ToString, dr.Item("ImagePath").ToString, dr.Item("txtCode").ToString, dr.Item("IMAGE"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
        End Try
    End Sub


    Private Sub Insert_Click(sender As Object, e As EventArgs) Handles Insert.Click
        txtCode.Enabled = False

        path1.Enabled = False

        If fcode.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE FOOD CODE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            fcode.Focus()

            Exit Sub
        End If

        If price.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE PRICE OF FOOD", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            price.Focus()

            Exit Sub
        End If

        If descrip.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE FOOD DESCRIPTION", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            descrip.Focus()

            Exit Sub
        End If


        If status1.Text = "" Then
            MessageBox.Show("PLEASE CHOOSE FOR STATUS", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            status1.Focus()

            Exit Sub
        End If





        If path1.Text = "" Then
            MessageBox.Show("PLEASE CHOOSE AN IMAGE FOR FOOD", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            path1.Focus()
            Exit Sub
        End If



        Try

            If MessageBox.Show("DO YOU WANT TO SAVE THIS RECORD?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cn.Open()

                Dim cg = New OleDbCommand("Select * from tblmerchant where (txtCode = @txtCode AND FoodCode like '%" & fcode.Text & "%') OR (txtCode = @txtCode AND DESCRIPTION like '%" & descrip.Text & "%') ", cn)
                cg.Parameters.AddWithValue("@txtCode", txtCode.Text)
                Dim dr As Int16 = cg.ExecuteScalar
                If dr > 0 Then
                    MessageBox.Show("YOUR CODE OR DESCRIPTION IS ALREADY EXISTS. PLEASE CHANGE IT.", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else

                    cm = New OleDbCommand("insert into tblmerchant(`FoodCode`,`DESCRIPTION`,`PRICE`,`STATUS`,`ImagePath`,`txtCode`,`IMAGE`) values (@FoodCode,@DESCRIPTION,@PRICE,@STATUS,@ImagePath ,@txtCode ,@IMAGE)", cn)
                    Dim i As New Integer


                    cm.Parameters.AddWithValue("@FoodCode", fcode.Text)
                    cm.Parameters.AddWithValue("@DESCRIPTION", descrip.Text)
                    cm.Parameters.AddWithValue("@PRICE", price.Text)
                    cm.Parameters.AddWithValue("@STATUS", status1.Text)
                    cm.Parameters.AddWithValue("@ImagePath", path1.Text)
                    cm.Parameters.AddWithValue("@txtCode", txtCode.Text)

                    Dim FileSize As New UInt32
                    Dim mstream As New System.IO.MemoryStream
                    PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim picture() As Byte = mstream.GetBuffer
                    FileSize = mstream.Length
                    mstream.Close()
                    cm.Parameters.AddWithValue("@IMAGE", picture)

                    i = cm.ExecuteNonQuery
                    If i > 0 Then

                        MessageBox.Show("YOUR RECORD IS SUCCESFULLY ADDED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else

                        MessageBox.Show("YOUR RECORD IS NOT ADDED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    fcode.Clear()
                    descrip.Clear()
                    price.Clear()
                    path1.Clear()
                    status1.SelectedIndex = -1
                    PictureBox1.Image = Nothing
                    txtCode.Enabled = False
                End If




            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
        Dv_Load()
        FOODMENU.imageload1()


    End Sub


    Private Sub Insert_MouseHover(sender As Object, e As EventArgs) Handles Insert.MouseHover

        Insert.ForeColor = Color.White
        Insert.BackColor = Color.Green




    End Sub
    Private Sub Insert_MouseLeave(sender As Object, e As EventArgs) Handles Insert.MouseLeave

        Insert.ForeColor = Color.Black
        Insert.BackColor = Color.Yellow

    End Sub

    Private Sub edit1_MouseHover(sender As Object, e As EventArgs) Handles edit1.MouseHover

        edit1.ForeColor = Color.White
        edit1.BackColor = Color.Green




    End Sub

    Private Sub edit1_MouseLeave(sender As Object, e As EventArgs) Handles edit1.MouseLeave

        edit1.ForeColor = Color.Black
        edit1.BackColor = Color.Yellow
    End Sub

    Private Sub update1_MouseHover(sender As Object, e As EventArgs) Handles update1.MouseHover

        update1.ForeColor = Color.White
        update1.BackColor = Color.Green




    End Sub

    Private Sub update1_MouseLeave(sender As Object, e As EventArgs) Handles update1.MouseLeave

        update1.ForeColor = Color.Black
        update1.BackColor = Color.Yellow

    End Sub


    Private Sub remove1_MouseHover(sender As Object, e As EventArgs) Handles remove1.MouseHover

        remove1.ForeColor = Color.Black
        remove1.BackColor = Color.Yellow




    End Sub


    Private Sub remove1_MouseLeave(sender As Object, e As EventArgs) Handles remove1.MouseLeave

        remove1.ForeColor = Color.White
        remove1.BackColor = Color.Red

    End Sub






    Private Sub btnbrowse_Click(sender As Object, e As EventArgs) Handles btnbrowse.Click
        OpenFileDialog1.ShowDialog()
        path1.Text = OpenFileDialog1.FileName

    End Sub


    Private Sub path1_TextChanged(sender As Object, e As EventArgs) Handles path1.TextChanged
        If (System.IO.File.Exists(path1.Text)) Then
            PictureBox1.Image = Image.FromFile(path1.Text)
            path1.Enabled = True
        End If

        If path1.Text = " " Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
        End If
        path1.Enabled = False

    End Sub

    Private Sub price_KeyPress(sender As Object, e As KeyPressEventArgs) Handles price.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("THIS FIELD IS ONLY ACCEPT NUMBERS", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub edit1_Click(sender As Object, e As EventArgs) Handles edit1.Click

        txtCode.Enabled = False
        path1.Enabled = False
        fcode.Enabled = False

        Dim b As Integer

        b = DataGridView1.CurrentRow.Index
        fcode.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
        descrip.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
        price.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        status1.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
        path1.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

        Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(6).Value
        Dim ms As New MemoryStream(bytes)
        PictureBox1.Image = Image.FromStream(ms)
        Insert.Enabled = False
        path1.Enabled = False
        fcode.Enabled = False
        txtCode.Enabled = False

    End Sub



    Private Sub update1_Click(sender As Object, e As EventArgs) Handles update1.Click
        txtCode.Enabled = False
        path1.Enabled = False
        descrip.Enabled = True
        If price.Text = "" Then
            MessageBox.Show("PLEASE ENTER THE PRICE OF FOOD", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            price.Focus()

            Exit Sub
        End If

        If path1.Text = "" Then
            MessageBox.Show("PLEASE CHOOSE AN IMAGE FOR YOUR STORE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            path1.Focus()
            Exit Sub
        End If



        Try

            If MessageBox.Show("DO YOU WANT TO UPDATE YOUR RECORD?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                cn.Open()
                cm = New OleDbCommand("UPDATE `tblmerchant` set `FoodCode` = [@FOOD CODE], `DESCRIPTION`=@DESCRIPTION, `PRICE`=@PRICE, `STATUS`=@STATUS, `ImagePath`= [@IMAGE PATH], `IMAGE`=@IMAGE WHERE `FoodCode`= [@FOOD CODE]", cn)


                Dim i As New Integer



                cm.Parameters.AddWithValue("@FoodCode", fcode.Text)
                cm.Parameters.AddWithValue("@DESCRIPTION", descrip.Text)
                cm.Parameters.AddWithValue("@PRICE", price.Text)
                cm.Parameters.AddWithValue("@STATUS", status1.Text)
                cm.Parameters.AddWithValue("@ImagePath", path1.Text)


                Dim FileSize As New UInt32
                Dim mstream As New System.IO.MemoryStream
                PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim picture() As Byte = mstream.GetBuffer
                FileSize = mstream.Length
                mstream.Close()
                cm.Parameters.AddWithValue("@IMAGE", picture)
                cm.Parameters.AddWithValue("@FoodCode", fcode.Text)
                i = cm.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("YOUR RECORD IS SUCCESFULLY UPDATED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Insert.Enabled = True
                Else

                    MessageBox.Show("YOUR MUST SELECT A ROW TO DELETE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If


                cn.Close()

                fcode.Clear()
                descrip.Clear()
                price.Clear()
                path1.Clear()
                status1.SelectedIndex = -1
                PictureBox1.Image = Nothing
                fcode.Enabled = True
                txtCode.Enabled = False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
        Dv_Load()
        FOODMENU.imageload1()



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If MessageBox.Show("ARE YOU SURE YOU WANT TO LOGOUT?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Form1.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub remove1_Click(sender As Object, e As EventArgs) Handles remove1.Click

        txtCode.Enabled = False
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index


        If (MessageBox.Show("Are you sure you want to delete this record?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then

            cn.Open()
            fcode.Text = DataGridView1.Item(0, i).Value.ToString()
            Dim cmd As New OleDb.OleDbCommand("DELETE FROM tblmerchant WHERE FoodCode= @FoodCode", cn)
            cmd.Parameters.AddWithValue("@FoodCode", fcode.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("YOUR RECORD IS SUCCESFULLY DELETED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cn.Close()
            Dv_Load()
            FOODMENU.imageload1()
            fcode.Clear()
            txtCode.Enabled = False
        Else


            MessageBox.Show("YOUR MUST SELECT A ROW TO DELETE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)

            If DialogResult.No Then
                Me.Show()
            End If


            cn.Close()

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        FOODMENU.Show()
        Me.Hide()
    End Sub

    Private Sub descrip_TextChanged(sender As Object, e As EventArgs) Handles descrip.TextChanged

    End Sub
End Class