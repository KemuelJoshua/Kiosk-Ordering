Public Class QUANTITY
    Public Property StoreName As String
    Public Property Price As String
    Public Property Quan As String
    Public Property StoreCode As String
    Public Property textCode As String




    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")
    Private Sub QUANTITY_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TP.Text = Price
        lblStorename.Text = StoreName
        lblPrice.Text = Price
        TextBox1.Text = 1
        lblstore.Text = StoreCode
        lblhide.Text = Quan
        TextBox1.Enabled = False

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Try
            conn.Open()


            cm = New OleDb.OleDbCommand("insert into tbl_Orders(`FoodCode`,`Description`,`Price`,`quantity`) values (@FoodCode,@Description,@price,@quan)", conn)
            cm.Parameters.AddWithValue("@FoodCode", lblstore.Text)
            cm.Parameters.AddWithValue("@Description", lblStorename.Text)
            cm.Parameters.AddWithValue("@price", lblPrice.Text)
            cm.Parameters.AddWithValue("@quan", TextBox1.Text)
            cm.ExecuteNonQuery()

            FOODMENU.Quan2 = TextBox1.Text
            FOODMENU.StringCode = textCode
            FOODMENU.Show()



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Me.Dispose()
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Add_btn.Click
        TextBox1.Text = Val(TextBox1.Text) + 1

        TP.Text = Val(TextBox1.Text) * Price


    End Sub

    Private Sub minus_btn_Click(sender As Object, e As EventArgs) Handles minus_btn.Click
        If Val(TextBox1.Text) = 1 Then
            TextBox1.Text = 1
        Else
            TextBox1.Text = Val(TextBox1.Text) - 1
            TP.Text = Val(TextBox1.Text) * Price
        End If


    End Sub
End Class