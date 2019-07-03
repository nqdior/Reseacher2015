Public Class SSR1100

    Public SQLid As String
    Public SQLpass As String
    Public instance As String = CreateObject("WScript.Network").ComputerName
    Public strConnectSQL As String '接続文字列
    Public strSQL As String 'SQL文格納
    Public strSQL2 As String
    Public SQLDA As SqlClient.SqlDataAdapter 'SQLアダプタ
    Public SQLDS As New DataSet() 'データセット
    Public retcode As String

    Private Sub TableList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SSR1000.STBLBtn.Enabled = True
    End Sub

    Private Sub MenuWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Me.TopMost = True
        Me.Top = SSR1000.Top + 86
        Me.Left = SSR1000.Left + 10
        DGV1.ReadOnly = True

        strSQL = "select o.name, i.Rows from sysindexes i, sysobjects o where o.xtype = 'U' "
        strSQL = strSQL & "and o.id = i.id and i.indid < 2 and o.name <> 'dtproperties' order by o.name; "

        Try '▼SQLServer接続部分-----------------------//

            SQLDS = Nothing
            SQLDS = New DataSet

            'SQL接続を開き、データ取得
            SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

            '取得したデータをデータセットに格納
            SQLDA.Fill(SQLDS, "TEST")


            '▼DataGridView連結------------------------//

            DGV1.DataSource = SQLDS.Tables("TEST")
            'Dgv1.ContextMenuStrip = ContextMenuStrip1

            '▲----------------------------------------//

            DGV1.Columns(0).DataPropertyName = SQLDS.Tables("TEST").Columns(0).ColumnName


            '▼DataGridView表示設定--------------------//

            With DGV1
                .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
                .Font = New Font("メイリオ", 9) 'Fontsize
                .Columns(0).Width = 238
                .Columns(3).Width = 70
                .Columns(1).Visible = False
                .Columns(2).Visible = False
                .Columns(3).DefaultCellStyle.Alignment = _
                    DataGridViewContentAlignment.MiddleRight
            End With



            '▲----------------------------------------//
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGV1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV1.CellContentClick
        Dim retcode As Integer = DGV1.CurrentCellAddress.Y
        Dim StrSQL As String = DGV1(0, retcode).Value

        SSR1000.Label1.Text = StrSQL
        SSR1000.SQLcmd.Text = "Select * from " & StrSQL
        Call SSR1000.Reseach()
        Me.Close()
    End Sub

    Private Sub OpenBtn_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click
        SSR1000.Label1.Text = TblName.Text
        SSR1000.SQLcmd.Text = "Select * from " & TblName.Text
        Call SSR1000.Reseach()
        Me.Close()
    End Sub
End Class