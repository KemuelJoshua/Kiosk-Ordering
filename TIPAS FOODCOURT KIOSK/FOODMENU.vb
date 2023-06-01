Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class FOODMENU
    Public Property StringCode As String
    Public Property Quan2 As String
    Dim gen As Random = New Random()

    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 240
    End Sub

    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")
    Private WithEvents pic As New PictureBox
    Dim dr As OleDbDataReader
    Dim rd As OleDbDataReader

    Private Sub MENU_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mylabs As String
        mylabs = StringCode
        TextBox1.Text = StringCode
        TextBox2.Text = 1
        DataGridView1.MultiSelect = False
        imageload1()
        generate()


    End Sub

    Sub generate()
        random.Text = (gen.Next(1000))
    End Sub



    Sub imageload1()
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("SELECT `IMAGE`,`FoodCode`,`DESCRIPTION`,`PRICE`,`STATUS` FROM tblmerchant WHERE txtCODE = @Codes ", conn)
        cmd.Parameters.AddWithValue("@Codes", TextBox1.Text)
        dr = cmd.ExecuteReader
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)


            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            pic = New PictureBox
            pic.Width = 230
            pic.Height = 210
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("DESCRIPTION").ToString
            pic.BorderStyle = BorderStyle.FixedSingle


            lblStatus = New Label
            lblStatus.ForeColor = Color.Red
            lblStatus.Width = 130
            lblStatus.BackColor = Color.Yellow
            lblStatus.Dock = DockStyle.Bottom
            lblStatus.TextAlign = ContentAlignment.MiddleCenter
            lblStatus.Font = New Font("CAMBRIA", 9, FontStyle.Bold)
            lblStatus.Tag = dr.Item("DESCRIPTION").ToString

            lbldesc = New Label
            lbldesc.ForeColor = Color.Yellow
            lbldesc.BackColor = Color.Red
            lbldesc.TextAlign = ContentAlignment.MiddleCenter
            lbldesc.Dock = DockStyle.Bottom
            lbldesc.Font = New Font("CAMBRIA", 14, FontStyle.Bold)
            lbldesc.Tag = dr.Item("DESCRIPTION").ToString


            lbldesc1 = New Label
            lbldesc1.ForeColor = Color.White
            lbldesc1.Width = 80
            lbldesc1.BackColor = Color.Red
            lbldesc1.TextAlign = ContentAlignment.BottomLeft
            lbldesc1.Font = New Font("CAMBRIA", 14, FontStyle.Bold)
            lbldesc1.Tag = dr.Item("DESCRIPTION").ToString




            lblprice = New Label
            lblprice.ForeColor = Color.White
            lblprice.BackColor = Color.Green
            lblprice.Dock = DockStyle.Bottom
            lblprice.TextAlign = ContentAlignment.MiddleCenter
            lblprice.AutoSize = False
            lblprice.Font = New Font("CAMBRIA", 14, FontStyle.Bold)
            lblprice.Tag = dr.Item("DESCRIPTION").ToString


            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lbldesc.Text = dr.Item("DESCRIPTION").ToString
            lblprice.Text = dr.Item("PRICE").ToString
            lbldesc1.Text = dr.Item("FoodCode").ToString
            lblStatus.Text = dr.Item("STATUS").ToString


            pic.Controls.Add(lbldesc)
            If (dr.Item("STATUS") = "UNAVAILABLE") Then
                pic.Controls.Add(lblStatus)
            End If
            pic.Controls.Add(lblprice)
            pic.Controls.Add(lbldesc1)

            FlowLayoutPanel1.Controls.Add(pic)

            AddHandler pic.Click, AddressOf Selectimg_Click
            AddHandler lbldesc.Click, AddressOf Selectimg_Click
            AddHandler lblprice.Click, AddressOf Selectimg_Click
            AddHandler lbldesc1.Click, AddressOf Selectimg_Click

        End While
        dr.Close()
        dr.Dispose()
        conn.Close()
    End Sub

    Public Sub Selectimg_Click(sender As Object, e As EventArgs)

        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("select * from tblmerchant where (txtCode = @txtCode AND DESCRIPTION like '" & sender.tag.ToString & "%') AND (txtCode = @txtCode AND STATUS = 'AVAILABLE') ", conn)
        cmd.Parameters.AddWithValue("@txtCode", TextBox1.Text)
        Dim dr As Int16 = cmd.ExecuteScalar
        If dr > 0 Then
            Dim cd As New OleDb.OleDbCommand("select * from tblmerchant where (txtCode = @txtCode AND DESCRIPTION like '" & sender.tag.ToString & "%') AND (txtCode = @txtCode AND STATUS = 'AVAILABLE') ", conn)
            cd.Parameters.AddWithValue("@txtCode", TextBox1.Text)
            rd = cd.ExecuteReader
            While rd.Read = True

                QUANTITY.StoreName = rd.Item("DESCRIPTION").ToString
                QUANTITY.Price = rd.Item("PRICE").ToString
                QUANTITY.textCode = StringCode


                QUANTITY.ShowDialog()

                TextBox2.Text = Quan2
                DataGridView1.Rows.Add(New String() {DataGridView1.Rows.Count + 1, rd.Item("FoodCode").ToString, rd.Item("DESCRIPTION").ToString, rd.Item("PRICE"), TextBox2.Text})

            End While
        Else
            MessageBox.Show("SORRY, THIS MENU IS NOT AVAILABLE RIGHT NOW.  PLEASE CHOOSE OTHER MENU", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If

        overalltotal()
        conn.Close()

    End Sub

    Sub overalltotal()
        Dim i As Decimal
        Dim sum As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            sum += DataGridView1.Rows(i).Cells(3).Value * DataGridView1.Rows(i).Cells(4).Value
        Next

        totalno.Text = CDec(sum)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        overalltotal()
    End Sub
    Sub clear()

        DataGridView1.Rows.Clear()


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If (MessageBox.Show("ARE YOU SURE YOU WANT TO EXIT?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            Form1.Show()
            Me.Dispose()
        End If
    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As EventArgs) Handles Label2.MouseHover
        Label2.ForeColor = Color.Black
        Label2.BackColor = Color.Yellow


    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave

        Label2.ForeColor = Color.White
        Label2.BackColor = Color.Transparent

    End Sub

    Private Sub storeCode_TextChanged(sender As Object, e As EventArgs) Handles storeCode.TextChanged
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("SELECT `IMAGE`,`FoodCode`,`DESCRIPTION`,`PRICE`,`STATUS` FROM tblmerchant Where (txtCode = '" & TextBox1.Text & "' AND FoodCode like '%" & storeCode.Text & "%' ) OR (txtCode = '" & TextBox1.Text & "' AND DESCRIPTION like '%" & storeCode.Text & "%')", conn)

        dr = cmd.ExecuteReader
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            pic = New PictureBox
            pic.Width = 230
            pic.Height = 210
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("DESCRIPTION").ToString
            pic.BorderStyle = BorderStyle.FixedSingle


            lblStatus = New Label
            lblStatus.ForeColor = Color.Red
            lblStatus.Width = 130
            lblStatus.BackColor = Color.Yellow
            lblStatus.Dock = DockStyle.Bottom
            lblStatus.TextAlign = ContentAlignment.MiddleCenter
            lblStatus.Font = New Font("CAMBRIA", 9, FontStyle.Bold)
            lblStatus.Tag = dr.Item("DESCRIPTION").ToString



            lbldesc = New Label
            lbldesc.ForeColor = Color.Yellow
            lbldesc.BackColor = Color.Red
            lbldesc.TextAlign = ContentAlignment.MiddleCenter
            lbldesc.Dock = DockStyle.Bottom
            lbldesc.Font = New Font("CAMBRIA", 14, FontStyle.Bold)
            lbldesc.Tag = dr.Item("DESCRIPTION").ToString



            lbldesc1 = New Label
            lbldesc1.ForeColor = Color.White
            lbldesc1.Width = 70
            lbldesc1.BackColor = Color.Red
            lbldesc1.TextAlign = ContentAlignment.BottomLeft
            lbldesc1.Font = New Font("CAMBRIA", 14, FontStyle.Bold)
            lbldesc1.Tag = dr.Item("DESCRIPTION").ToString


            lblprice = New Label
            lblprice.ForeColor = Color.White
            lblprice.BackColor = Color.Green
            lblprice.Dock = DockStyle.Bottom
            lblprice.TextAlign = ContentAlignment.MiddleCenter
            lblprice.AutoSize = False
            lblprice.Font = New Font("CAMBRIA", 14, FontStyle.Bold)
            lblprice.Tag = dr.Item("DESCRIPTION").ToString



            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lbldesc.Text = dr.Item("DESCRIPTION").ToString
            lblprice.Text = dr.Item("PRICE").ToString
            lbldesc1.Text = dr.Item("FoodCode").ToString
            lblStatus.Text = dr.Item("STATUS").ToString



            pic.Controls.Add(lbldesc)
            pic.Controls.Add(lblprice)
            pic.Controls.Add(lbldesc1)
            If (dr.Item("STATUS").ToString = "UNAVAILABLE") Then
                pic.Controls.Add(lblStatus)
            End If


            FlowLayoutPanel1.Controls.Add(pic)

            AddHandler pic.Click, AddressOf Selectimg_Click
            AddHandler lbldesc.Click, AddressOf Selectimg_Click
            AddHandler lblprice.Click, AddressOf Selectimg_Click



        End While
        dr.Dispose()
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles can.Click
        Me.Dispose()
        DASHBOARD.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles del.Click
        If (MessageBox.Show("ARE YOU SURE YOU WANT TO REMOVE THIS?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then
            If DataGridView1.SelectedRows.Count > 0 Then
                DataGridView1.Rows.RemoveAt(DataGridView1.CurrentRow.Index)
                MessageBox.Show("SUCCESFULLY DELETED!", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else


                MessageBox.Show("YOU MUST SELECT A ROW TO DELETE", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)

                If DialogResult.No Then
                    Me.Show()

                End If
            End If
        End If

        overalltotal()
    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        changelongpaper()
        PPD.Document = PD




        If DataGridView1.RowCount = 0 Then
            MessageBox.Show("YOUR MUST CHOOSE A FOOD TO PROCEED", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf (MessageBox.Show("ARE YOU SURE YOU WANT TO PROCEED?", "TIPAS FOODCOURT KIOSK", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes) Then

            conn.Open()
                Dim cmd As New OleDb.OleDbCommand("DELETE * FROM tbl_Orders", conn)
            cmd.ExecuteNonQuery()
            conn.Close()

            PPD.ShowDialog()
            DataGridView1.Rows.Clear()

            If DialogResult.No Then
                Me.Show()


            End If
            End If


        generate()

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As Printing.PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings

        pagesetup.PaperSize = New PaperSize("Custom", 330, 900)
        PD.DefaultPageSettings = pagesetup


    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage

        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("select * from tblaccts1 where StoreCODE = @txtCode", conn)
        cmd.Parameters.AddWithValue("@txtCode", TextBox1.Text)
        rd = cmd.ExecuteReader
        Dim Storename As String
        While rd.Read = True
            Storename = rd.Item("StoreNAME").ToString
        End While



        Dim f8 As New Font("Cambria", 9, FontStyle.Regular)
        Dim f10 As New Font("Cambria", 10, FontStyle.Regular)
        Dim f11 As New Font("Cambria", 12, FontStyle.Bold)
        Dim f10b As New Font("Cambria", 10, FontStyle.Bold)
        Dim f14 As New Font("Cambria", 14, FontStyle.Bold)
        Dim f16 As New Font("Cambria", 40, FontStyle.Bold)

        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width


        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        Dim line As String
        Dim line1 As String
        line = "────────────────────────────────────────────────────────────────────────────────────────────────────────────"
        line1 = "============================================================================================================"
        e.Graphics.DrawString("TIPAS FOODCOURT KIOSK", f14, Brushes.Red, centermargin, 5, center)
        e.Graphics.DrawString("Calzada Street, Tipas Taguig City", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Contact Number : 091234567910", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("STORE NAME : " + Storename, f10b, Brushes.Black, centermargin, 120, center)

        Dim logoImage As Image = My.Resources.ResourceManager.GetObject("LOGO")
        e.Graphics.DrawImage(logoImage, CInt((e.PageBounds.Height - 670) / 2), 60, 90, 60)

        e.Graphics.DrawString(line1, f8, Brushes.Black, 0, 135)
        e.Graphics.DrawString("FOOD RECEIPT", f11, Brushes.Red, centermargin, 147, center)
        e.Graphics.DrawString(line1, f8, Brushes.Black, 0, 160)
        e.Graphics.DrawString("QTY", f10b, Brushes.Black, 0, 175)
        e.Graphics.DrawString("FOOD DESCRIPTION", f10b, Brushes.Black, 50, 175)
        e.Graphics.DrawString("PRICE", f10b, Brushes.Black, 250, 175, right)
        e.Graphics.DrawString("TOTAL", f10b, Brushes.Black, rightmargin, 175, right)
        e.Graphics.DrawString(line1, f8, Brushes.Black, 0, 188)


        Dim height As Integer
        Dim i As Long
        DataGridView1.AllowUserToAddRows = False
        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 15, 190 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString, f8, Brushes.Black, 50, 190 + height)

            i = DataGridView1.Rows(row).Cells(3).Value
            DataGridView1.Rows(row).Cells(3).Value = Format(i, "##,##0")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 240, 190 + height, right)

            Dim totalprice As Long
            totalprice = Val(DataGridView1.Rows(row).Cells(4).Value * DataGridView1.Rows(row).Cells(3).Value)
            e.Graphics.DrawString(totalprice.ToString("##,##0"), f8, Brushes.Black, 315, 190 + height, right)
        Next
        Dim height2 As Integer
        height2 = 270 + height
        sumprice()
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, height2)
        e.Graphics.DrawString("TOTAL AMOUNT : " & Format(t_price, "##,##0"), f10b, Brushes.Black, 320, 15 + height2, right)
        e.Graphics.DrawString(t_qty, f10b, Brushes.Black, 15, 15 + height2)
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 30 + height2)
        e.Graphics.DrawString("YOUR ORDER NUMBER IS", f10b, Brushes.Red, centermargin, 45 + height2, center)
        e.Graphics.DrawString("" + random.Text, f16, Brushes.Black, centermargin, 55 + height2, center)
        e.Graphics.DrawString("THANKYOU FOR USING TIPAS FOODCOURT KIOSK", f10b, Brushes.Black, centermargin, 160 + height2, center)
        e.Graphics.DrawString("PLEASE PROCEED TO YOUR CHOSEN STORE", f8, Brushes.Black, centermargin, 175 + height2, center)
        e.Graphics.DrawString("HAVE A GREAT DAY AHEAD!", f8, Brushes.Black, centermargin, 190 + height2, center)

        Dim gbarcode As New MessagingToolkit.Barcode.BarcodeEncoder
        Try
            Dim barcodeimage As Image
            barcodeimage = New Bitmap(gbarcode.Encode(MessagingToolkit.Barcode.BarcodeFormat.Code128, "TIPASFOODCOURTKIOSK"))
            e.Graphics.DrawImage(barcodeimage, CInt((e.PageBounds.Width - 130) / 2), 115 + height2, 155, 35)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()

    End Sub
    Dim t_price As Long
    Dim t_qty As Long
    Sub sumprice()
        Dim countprice As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countprice = countprice + Val(DataGridView1.Rows(rowitem).Cells(4).Value * DataGridView1.Rows(rowitem).Cells(3).Value)
        Next
        t_price = countprice
        Dim countqty As Long = 0
        For rowitem As Long = 0 To DataGridView1.RowCount - 1
            countqty = countqty + DataGridView1.Rows(rowitem).Cells(4).Value
        Next
        t_qty = countqty
    End Sub
    Private Sub del_MouseHover(sender As Object, e As EventArgs) Handles del.MouseHover

        del.ForeColor = Color.Black
        del.BackColor = Color.Yellow




    End Sub

    Private Sub del_MouseLeave(sender As Object, e As EventArgs) Handles del.MouseLeave

        del.ForeColor = Color.White
        del.BackColor = Color.Red

    End Sub
    Private Sub btnpay_MouseHover(sender As Object, e As EventArgs) Handles btnpay.MouseHover

        btnpay.ForeColor = Color.Black
        btnpay.BackColor = Color.Yellow



    End Sub

    Private Sub btnpay_MouseLeave(sender As Object, e As EventArgs) Handles btnpay.MouseLeave


        btnpay.ForeColor = Color.White
        btnpay.BackColor = Color.DarkGreen



    End Sub


    Private Sub can_MouseHover(sender As Object, e As EventArgs) Handles can.MouseHover

        can.ForeColor = Color.Black
        can.BackColor = Color.Yellow




    End Sub

    Private Sub can_MouseLeave(sender As Object, e As EventArgs) Handles can.MouseLeave

        can.ForeColor = Color.White
        can.BackColor = Color.Red

    End Sub
    Private Sub PD_endprint(sender As Object, e As PrintEventArgs) Handles PD.EndPrint
        Me.Hide()

    End Sub

End Class