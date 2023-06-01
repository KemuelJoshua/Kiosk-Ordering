
Imports System.Data.OleDb
Imports System.Data

Module MerchantMenuConnection
    Public cn As New OleDbConnection
    Public cm As New OleDbCommand
    Public dr As OleDbDataReader


    Sub ConnectToDatabase()
        Try
            cn = New OleDbConnection

            With cn
                .ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\TIPASdatabase.mdb"

            End With
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub


End Module
