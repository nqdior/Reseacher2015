Public Class SSR1330

    Private Sub JoinForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SSR1000.MenuBtn.Enabled = True
    End Sub

    Private Sub JoinForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = SSR1000.Top + 86
        Me.Left = SSR1000.Left + SSR1000.Width - Me.Width - 11

        '■フォームロード時各OBJ設定----------------------------

        strSQL = "select o.name, i.Rows from sysindexes i, sysobjects o where o.xtype = 'U' "
        strSQL = strSQL & "and o.id = i.id and i.indid < 2 and o.name <> 'dtproperties' order by o.name; "

        '▼SQLServer接続部分-----------------------//

        SQLDS = Nothing
        SQLDS = New DataSet

        'SQL接続を開き、データ取得
        SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST")

        '▲----------------------------------------//

        '▼Combobox連結------------------------//
        ComboBox1.DataSource = SQLDS.Tables("TEST")
        ComboBox1.ValueMember = "Name"
        ComboBox1.SelectedIndex = -1

        '▲----------------------------------------//

        '▼Combo1にアイテム追加----------------------

        With ComboBox4
            .Items.Add("SUM") : .Items.Add("MAX")
            .Items.Add("MIN") : .Items.Add("AVG") : .Items.Add("COUNT")
        End With

        '▲------------------------------------------

        With DGV1
            .Columns(0).Width = 160
            '.Columns(1).Width = 160
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
            .Font = New Font("メイリオ", 9) 'Fontsize
        End With
        With DGV2
            .Columns(0).Width = 160
            '.Columns(1).Width = 160
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
            .Font = New Font("メイリオ", 9) 'Fontsize
        End With

    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.LostFocus

        On Error GoTo SQLERR

        '▼DataCombo2にカラム一覧を表示する------------------------

        strSQL = "SELECT name FROM syscolumns WHERE id = object_id('" & ComboBox1.Text & "')"

        '▼SQLServer接続部分-----------------------//

        SQLDS = Nothing
        SQLDS = New DataSet

        'SQL接続を開き、データ取得
        SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST")

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST2")

        '▼Combobox連結------------------------//
        ComboBox3.DataSource = SQLDS.Tables("TEST")
        ComboBox3.ValueMember = "Name"

        ComboBox2.DataSource = SQLDS.Tables("TEST2")
        ComboBox2.ValueMember = "Name"

        '▲----------------------------------------//
        ComboBox2.SelectedIndex = -1
        ComboBox3.SelectedIndex = -1

        '▲--------------------------------------------------------

SQLERR:
        Exit Sub
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '▼結合キーの設定----------------------------------------------------//
        If ComboBox3.Text = "" Then
            MsgBox("設定項目が選択されていません", MsgBoxStyle.Critical)
        Else
            DGV1.Rows.Add(ComboBox3.Text)
        End If
        '▲------------------------------------------------------------------//
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        '▼結合キーの設定----------------------------------------------------//
        If ComboBox2.Text = "" Then
            MsgBox("設定項目が選択されていません", MsgBoxStyle.Critical)
        ElseIf ComboBox4.Text = "" Then
            MsgBox("設定項目が選択されていません", MsgBoxStyle.Critical)
        Else
            DGV2.Rows.Add(ComboBox2.Text, ComboBox4.Text)
        End If
        '▲------------------------------------------------------------------//
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = False
        Panel4.Visible = True
        Button4.Visible = False
        Button6.Visible = True
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CallF = "C"

        If Button1.Tag <> 1 Then
            Button1.Tag = 1
        Else
            Button1.Tag = ""
        End If
        SSR1301.Show()
    End Sub

    Private Sub ComboBox3_Click(sender As Object, e As EventArgs) Handles ComboBox3.Click
        ComboBox1.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim selcol1 As String
        Dim selcol2 As String
        Dim ssql As String = 0
        For i = 0 To DGV1.Rows.Count - 1
            DGV1.CurrentCell = DGV1(0, i)
            If selcol1 = "" Then
                selcol1 = DGV1(0, i).Value
            Else
                selcol1 = selcol1 & "," & DGV1(0, i).Value 'キー項目一覧
            End If
        Next i

        For i = 0 To DGV2.Rows.Count - 1
            DGV2.CurrentCell = DGV1(0, i)
            If selcol2 = "" Then
                selcol2 = DGV2(1, i).Value & "(" & DGV2(0, i).Value & ")"
            Else
                selcol2 = selcol2 & "," & DGV2(1, i).Value & "(" & DGV2(0, i).Value & ")"  'キー項目一覧
            End If
        Next i

        ssql = "Select " & selcol1 & "," & selcol2 & " From " & ComboBox1.Text & " Group By " & selcol1
        SSR1000.Label1.Text = "名称未設定"
        SSR1000.SQLcmd.Text = ssql
        Me.Close()
        Call SSR1000.Reseach()

    End Sub
End Class