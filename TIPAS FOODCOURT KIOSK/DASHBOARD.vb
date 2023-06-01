Imports System.Data.OleDb



Public Class DASHBOARD
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")
    Private WithEvents pic As New PictureBox

    Dim dr As OleDbDataReader
    Private Sub DASHBOARD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        imageload()

    End Sub
    Sub imageload()
        conn.Open()
        Dim cmd As New OleDb.OleDbCommand("SELECT `IMAGE`,`StoreCODE`,`USERNAME`,`PASSWORD`,`StoreNAME` FROM tblaccts1", conn)
        dr = cmd.ExecuteReader
        FlowLayoutPanel1.AutoScroll = True
        FlowLayoutPanel1.Controls.Clear()

        While dr.Read
            Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
            Dim array(CInt(len)) As Byte
            dr.GetBytes(0, 0, array, 0, CInt(len))

            pic = New PictureBox
            pic.Width = 300
            pic.Height = 300
            pic.BackgroundImageLayout = ImageLayout.Stretch
            pic.Tag = dr.Item("StoreCODE").ToString
            pic.BorderStyle = BorderStyle.FixedSingle

            lbldesc = New Label
            lbldesc.ForeColor = Color.White
            lbldesc.BackColor = Color.Red
            lbldesc.TextAlign = ContentAlignment.MiddleCenter
            lbldesc.Dock = DockStyle.Bottom
            lbldesc.Font = New Font("CAMBRIA", 14, FontStyle.Bold)
            lbldesc.Tag = dr.Item("StoreCODE").ToString





            Dim ms As New System.IO.MemoryStream(array)
            Dim bitmap As New System.Drawing.Bitmap(ms)
            pic.BackgroundImage = bitmap
            lbldesc.Text = dr.Item("StoreNAME").ToString


            pic.Controls.Add(lbldesc)
            FlowLayoutPanel1.Controls.Add(pic)

            AddHandler pic.Click, AddressOf Selectimg_Click
            AddHandler lbldesc.Click, AddressOf Selectimg_Click

        End While
        dr.Dispose()
        conn.Close()
    End Sub
    Public Sub Selectimg_Click(sender As Object, e As EventArgs)
        FOODMENU.StringCode = sender.tag.ToString
        FOODMENU.Show()
        Me.Dispose()

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Form1.Show()
        Me.Dispose()

    End Sub


    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        Label1.ForeColor = Color.Black
        Label1.BackColor = Color.Yellow


    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave

        Label1.ForeColor = Color.White
        Label1.BackColor = Color.Transparent

    End Sub
End Class