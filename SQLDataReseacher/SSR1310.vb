Public Class SSR1310

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

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST2")
        '▲----------------------------------------//

        '▼Combobox連結------------------------//
        ComboBox1.DataSource = SQLDS.Tables("TEST")
        ComboBox1.ValueMember = "Name"
        ComboBox1.SelectedIndex = -1

        ComboBox2.DataSource = SQLDS.Tables("TEST2")
        ComboBox2.ValueMember = "Name"
        ComboBox2.SelectedIndex = -1
        '▲----------------------------------------//


        '▼Combo1にアイテム追加----------------------

        With ComboBox5
            .Items.Add("INNER JOIN") : .Items.Add("OUTER JOIN")
        End With

        '▲------------------------------------------

        '▼Combo2にアイテム追加----------------------

        With ComboBox6
            .Items.Add("LEFT") : .Items.Add("RIGHT") : .Items.Add("FULL")
        End With

        '▲------------------------------------------

        With DGV1
            .Columns(0).Width = 160
            .Columns(1).Width = 160
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
            .Font = New Font("メイリオ", 9) 'Fontsize
        End With

    End Sub

    Private Sub ComboBox3_Click(sender As Object, e As EventArgs) Handles ComboBox3.Click
        Button1.Enabled = False
        ComboBox1.Enabled = False
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

        '▼Combobox連結------------------------//
        ComboBox3.DataSource = SQLDS.Tables("TEST")
        ComboBox3.ValueMember = "Name"

        With DGVA
            .DataSource = SQLDS.Tables("TEST")
            .Refresh()
            .Columns(0).Width = 132
            .Columns(0).HeaderText = ComboBox1.Text
            .Font = New Font("メイリオ", 9) 'Fontsize
        End With
        '▲----------------------------------------//

        ComboBox3.SelectedIndex = -1

        '▲--------------------------------------------------------

SQLERR:
        Exit Sub
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.LostFocus

        On Error GoTo SQLERR

        '▼DataCombo2にカラム一覧を表示する------------------------

        strSQL = "SELECT name FROM syscolumns WHERE id = object_id('" & ComboBox2.Text & "')"


        '▼SQLServer接続部分-----------------------//

        SQLDS = Nothing
        SQLDS = New DataSet

        'SQL接続を開き、データ取得
        SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST2")

        '▼Combobox連結------------------------//
        ComboBox4.DataSource = SQLDS.Tables("TEST2")
        ComboBox4.ValueMember = "Name"

        With DGVB
            .DataSource = SQLDS.Tables("TEST2")
            .Refresh()
            .Columns(0).Width = 132
            .Columns(0).HeaderText = ComboBox2.Text
            .Font = New Font("メイリオ", 9) 'Fontsize
        End With
        '▲----------------------------------------//

        ComboBox4.SelectedIndex = -1

        '▲--------------------------------------------------------

SQLERR:
        Exit Sub
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CallF = "J"

        If Button1.Tag <> 1 Then
            Button1.Tag = 1
        Else
            Button1.Tag = ""
        End If
        SSR1301.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '▼結合キーの設定----------------------------------------------------//
        If ComboBox3.Text = "" Then
            MsgBox("設定項目が選択されていません", MsgBoxStyle.Critical)
        ElseIf ComboBox4.Text = "" Then
            MsgBox("設定項目が選択されていません", MsgBoxStyle.Critical)
        Else
            DGV1.Rows.Add(ComboBox3.Text, ComboBox4.Text)
        End If
        '▲------------------------------------------------------------------//
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If ComboBox3.Text = "" Then
            MsgBox("設定項目が選択されていません", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf ComboBox4.Text = "" Then
            MsgBox("設定項目が選択されていません", MsgBoxStyle.Critical)
            Exit Sub
        ElseIf DGV1.RowCount = 0 Then
            MsgBox("結合項目が設定されていません", MsgBoxStyle.Critical)
            Exit Sub
        End If


        '▼Nextボタン押下時各表示項目切替------------------------------------//
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = True
        Button3.Visible = True
        Button4.Visible = False
        '▲------------------------------------------------------------------//

    End Sub

    Private Sub DGVA_Click(sender As Object, e As EventArgs) Handles DGVA.Click
        Dim retcode As Integer = DGVA.CurrentCellAddress.Y
        DGVA.Tag = 1
        If DGVA.Rows(retcode).DefaultCellStyle.Font.Bold = False Then
            DGVA.Rows(retcode).DefaultCellStyle.Font = _
                New Font(DGVA.Rows(retcode).DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold)
        Else
            DGVA.Rows(retcode).DefaultCellStyle.Font = _
                New Font(DGVA.Rows(retcode).DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
        End If
    End Sub

    Private Sub DGVB_Click(sender As Object, e As EventArgs) Handles DGVB.Click
        Dim retcode As Integer = DGVB.CurrentCellAddress.Y
        DGVB.Tag = 1
        If DGVB.Rows(retcode).DefaultCellStyle.Font.Bold = False Then
            DGVB.Rows(retcode).DefaultCellStyle.Font = _
                New Font(DGVB.Rows(retcode).DefaultCellStyle.Font.FontFamily, 9, FontStyle.Bold)
        Else
            DGVB.Rows(retcode).DefaultCellStyle.Font = _
                New Font(DGVB.Rows(retcode).DefaultCellStyle.Font.FontFamily, 9, FontStyle.Regular)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim ssql As String

        If DGVA.Tag = 1 Then
            If DGVB.Tag = 1 Then

                '▼1テーブル目の表示項目判定・selcol1に格納---------------------------------------//
                Dim selcol1 As String = ""
                For i = 0 To DGVA.Rows.Count - 1
                    DGVA.CurrentCell = DGVA(0, i)
                    If DGVA.Rows(i).DefaultCellStyle.Font.Bold = True Then
                        If selcol1 = "" Then
                            selcol1 = ComboBox1.Text & "." & DGVA(0, i).Value
                        Else
                            selcol1 = selcol1 & "," & ComboBox1.Text & "." & DGVA(0, i).Value
                        End If
                    End If
                Next i
                '▲------------------------------------------------------------------//

                '▼2テーブル目の表示項目判定・selcol2に格納---------------------------------------//
                Dim selcol2 As String = ""
                For i = 0 To DGVB.Rows.Count - 1
                    DGVB.CurrentCell = DGVB(0, i)
                    If DGVB.Rows(i).DefaultCellStyle.Font.Bold = True Then
                        If selcol2 = "" Then
                            selcol2 = ComboBox2.Text & "." & DGVB(0, i).Value
                        Else
                            selcol2 = selcol2 & "," & ComboBox2.Text & "." & DGVB(0, i).Value
                        End If
                    End If
                Next i
                '▲------------------------------------------------------------------//

                Dim selcol As String = selcol1 & "," & selcol2

                If Button1.Tag <> 1 Then
                    ssql = "SELECT " & selcol & " FROM " & ComboBox1.Text
                Else
                    ssql = "SELECT " & selcol & " FROM " & Me.Tag
                End If


                '▼結合キーの取得・連結----------------------------------------------//

                Dim joinKey As String
                For i = 0 To DGV1.RowCount - 1
                    joinKey = joinKey & _
                              ComboBox1.Text & "." & DGV1(0, i).Value & " = " & _
                              ComboBox2.Text & "." & DGV1(1, i).Value
                    If i <> DGV1.RowCount - 1 Then
                        joinKey = joinKey & ","
                    End If
                Next i

                '▲------------------------------------------------------------------//

                '▼結合条件設定・SQL文構築-------------------------------------------//

                If ComboBox5.Text = "INNER JOIN" Then
                    ssql = ssql & " " & ComboBox5.Text & " " & _
                            ComboBox2.Text & " ON (" & joinKey

                ElseIf ComboBox5.Text = "OUTER JOIN" Then
                    ssql = ssql & " " & ComboBox6.Text & " " & ComboBox5.Text & " " & _
                            ComboBox2.Text & " ON (" & joinKey
                Else
                    MsgBox("結合条件を指定してください" & vbNewLine & _
                           "内部結合、外部結合が選択できます", MsgBoxStyle.Critical)
                    Exit Sub

                End If

                ssql = ssql & ")"

                '▲------------------------------------------------------------------//
            Else
                MsgBox("表示項目が選択されていません", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox("設定項目が選択されていません", MsgBoxStyle.Critical)
            Exit Sub
        End If

        DGVA.Tag = ""
        DGVB.Tag = ""

        SSR1000.Label1.Text = "名称未設定"
        SSR1000.SQLcmd.Text = ssql
        Me.Close()
        Call SSR1000.Reseach()

    End Sub

    Private Sub ComboBox4_Click(sender As Object, e As EventArgs) Handles ComboBox4.Click
        ComboBox2.Enabled = False
    End Sub


    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        If ComboBox5.Text <> "OUTER JOIN" Then
            ComboBox6.Enabled = False
        Else
            ComboBox6.Enabled = True
        End If
    End Sub
End Class