Imports Microsoft.VisualBasic.ControlChars

Public Class test

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'ユーザー名等取得===============================================================================================

        Dim cn As New System.Data.OleDb.OleDbConnection
        Dim command As System.Data.OleDb.OleDbCommand
        Dim reader As System.Data.OleDb.OleDbDataReader

        Dim FilePath As String = "C:\SQLReseacher\SRLocal.mdb"

        Try


            cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
            "Data Source=" & Quote & FilePath & Quote & ";"

            command = cn.CreateCommand
            command.CommandText = "SELECT * FROM UserInfo where UserNM = " & "'" & UserNM.Text & "'"
            cn.Open()

            reader = command.ExecuteReader()
            If reader.Read = True Then
                Dim User As String = reader("UserNM")
                SQLid = reader("SQLid")
                SQLpass = reader("SQLpass")
                catalog = reader("catalog")
                instance = reader("instance")
            End If

            cn.Close()
            command.Dispose()
            cn.Dispose()

        Catch ex As Exception

            MessageBox.Show(ex.Message, "エラー")

        End Try

        'ユーザー名等取得===============================================================================================

    End Sub

End Class