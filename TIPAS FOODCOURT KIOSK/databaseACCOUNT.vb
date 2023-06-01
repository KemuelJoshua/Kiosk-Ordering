
Imports System.Data.OleDb
Imports System.IO
Imports System.Windows
Imports System.Windows.Forms.DataFormats




Public Class databaseACCOUNT
    Dim conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb")

    Dim dr As OleDbDataReader



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

    Private Sub DataGridView1_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        If CheckBox1.Checked = False Then

            If e.ColumnIndex = 1 Then
                If e.Value IsNot Nothing Then
                    e.Value = New String("•", e.Value.ToString().Length)
                End If

            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub databaseACCOUNT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_load()

    End Sub

    Sub DGV_load()
        DataGridView1.Rows.Clear()
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("SELECT * FROM tblaccts1", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("StoreCODE"), dr.Item("USERNAME"), dr.Item("PASSWORD"), dr.Item("StoreNAME"), dr.Item("ImagePath"),dr.Item("IMAGE"))

            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub editbtn_Click(sender As Object, e As EventArgs) Handles addbtn1.Click
        ACC_REG.ShowDialog()
    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub addbtn1_MouseHover(sender As Object, e As EventArgs)

        addbtn1.ForeColor = Color.White
        addbtn1.BackColor = Color.Green




    End Sub

    Private Sub addbtn1_MouseLeave(sender As Object, e As EventArgs)

        addbtn1.ForeColor = Color.Black
        addbtn1.BackColor = Color.Yellow

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        With ACC_REG

            .storeCode.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString()
            .usr1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString()
            .password1.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString()
            .storeName.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString()
            .imagepath.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString()

            Dim bytes As [Byte]() = DataGridView1.CurrentRow.Cells(5).Value
            Dim ms As New MemoryStream(bytes)
            .PictureBox1.Image = Image.FromStream(ms)
            .addbtn.Enabled = False
            .storeCode.ReadOnly = True
            .ShowDialog()


        End With
    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub change_Click(sender As Object, e As EventArgs) Handles change.Click

    End Sub
End Class