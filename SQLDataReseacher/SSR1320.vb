Public Class SSR1320

    Private Sub SearchForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SSR1000.MenuBtn.Enabled = True
    End Sub

    Private Sub SearchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        On Error GoTo SQLERR
        Me.Top = SSR1000.Top + 86
        Me.Left = SSR1000.Left + SSR1000.Width - Me.Width - 11
        Label5.Height = 65
        Button1.Top = Label5.Top + Label5.Height + 15

        '■フォームロード時各OBJ設定----------------------------

        '▼各条件を初期状態に----------------------

        Combo1.ResetText() : Combo1.Text = "="
        Text1.Text = "" : Text2.Text = ""
        Text2.Visible = False : Label1.Visible = False : Combo2.Visible = False

        '▲----------------------------------------

        strSQL = "select o.name, i.Rows from sysindexes i, sysobjects o where o.xtype = 'U' "
        strSQL = strSQL & "and o.id = i.id and i.indid < 2 and o.name <> 'dtproperties' order by o.name; "

        '▼SQLServer接続部分-----------------------//

        SQLDS = Nothing
        SQLDS = New DataSet

        'SQL接続を開き、データ取得
        SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST")

        '▼Combobox連結------------------------//

        DataCombo1.DataSource = SQLDS.Tables("TEST")
        DataCombo1.ValueMember = "Name"
        DataCombo1.SelectedIndex = -1
        '▲----------------------------------------//


        '▼Combo1にアイテム追加----------------------

        With Combo1
            .Items.Add("=") : .Items.Add("<") : .Items.Add(">")
            .Items.Add("<=") : .Items.Add(">=") : .Items.Add("<>")
            .Items.Add("bet") : .Items.Add("like") : .Items.Add("null")
        End With

        '▲------------------------------------------


        '▼Combo2にアイテム追加----------------------

        With Combo2
            .Items.Add("前方") : .Items.Add("後方") : .Items.Add("部分")
        End With

        '▲------------------------------------------



SQLERR:
        Exit Sub
    End Sub


    Private Sub DataCombo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DataCombo1.LostFocus

        On Error GoTo SQLERR

        '▼DataCombo2にカラム一覧を表示する------------------------

        strSQL = "SELECT name FROM syscolumns WHERE id = object_id('" & DataCombo1.Text & "')"

        '▲--------------------------------------------------------

        '▼SQLServer接続部分-----------------------//

        SQLDS = Nothing
        SQLDS = New DataSet

        'SQL接続を開き、データ取得
        SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST")

        '▼Combobox連結------------------------//
        Combo3.DataSource = SQLDS.Tables("TEST")
        Combo3.ValueMember = "Name"
        '▲----------------------------------------//

        If DataCombo1.Text = "" Then
            Combo3.SelectedIndex = -1
        End If

SQLERR:
        Exit Sub
    End Sub

    Private Sub Combo1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Combo1.SelectedIndexChanged
        If Combo1.Text = "bet" Then
            Label1.Visible = True
            Text2.Visible = True
            Combo2.Visible = False
            Label5.Height = 115
            Button1.Top = Label5.Top + Label5.Height + 10

        ElseIf Combo1.Text = "like" Then
            Label1.Visible = False
            Text2.Visible = False
            Combo2.Visible = True
            Label5.Height = 65
        Else
            Label1.Visible = False
            Text2.Visible = False
            Combo2.Visible = False
            Label5.Height = 65
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'On Error GoTo SQLERR

        Dim ssql As String = ""


        '■SQL文作成部分---------------------------------------------------------

        If DataCombo1.Text <> NMBox(int) Then

            '▼検索条件を指定するか否か-------------------------------------

            If Combo1.Text = "null" Then
                ssql = "Select * From " & DataCombo1.Text & " where " & Combo3.Text & " is null"

            ElseIf Combo1.Text = "Nnull" Then
                ssql = "Select * From " & DataCombo1.Text & " where " & Combo3.Text & " is not null"

            ElseIf Text1.Text = "" Or Text1.Text = " KeyWord1" Or Combo3.Text = "Column Name" Or Combo3.Text = "" Then
                '        '条件文もしくはカラム選択がなされていない場合テーブルを表示するだけのSQL発行
                ssql = "Select * From " & DataCombo1.Text


            ElseIf Combo1.Text = "like" Then

                If Combo2.Text = "前方" Then
                    ssql = "Select * From " & DataCombo1.Text & " Where " & Combo3.Text & " " & Combo1.Text & " '" & Text1.Text & "%'"

                ElseIf Combo2.Text = "後方" Then
                    ssql = "Select * From " & DataCombo1.Text & " Where " & Combo3.Text & " " & Combo1.Text & " '%" & Text1.Text & "'"

                ElseIf Combo2.Text = "部分" Then
                    ssql = "Select * From " & DataCombo1.Text & " Where " & Combo3.Text & " " & Combo1.Text & " '%" & Text1.Text & "%'"

                End If


            ElseIf Combo1.Text <> "=" And Combo1.Text <> "bet" Then
                ssql = "Select * From " & DataCombo1.Text & " Where " & Combo3.Text & " " & Combo1.Text & " '" & Text1.Text & "'"

            ElseIf Combo1.Text = "=" Then
                ssql = "Select * From " & DataCombo1.Text & " Where " & Combo3.Text & " = '" & Text1.Text & "'"

            ElseIf Combo1.Text = "bet" Then
                ssql = "Select * From " & DataCombo1.Text & " where " & Combo3.Text & " between '" & Text1.Text & "' and '" & Text2.Text & "'"

            End If

            '▲-------------------------------------------------------------

        Else

            '▼検索条件を指定するか否か-------------------------------------

            If Combo1.Text = "null" Then
                ssql = "Select * From (" & JointSQL & ") as " & DataCombo1.Text & " where " & Combo3.Text & " is null"

            ElseIf Combo1.Text = "Nnull" Then
                ssql = "Select * From (" & JointSQL & ") as " & DataCombo1.Text & " where " & Combo3.Text & " is not null"

            ElseIf Text1.Text = "" Or Text1.Text = " KeyWord1" Or Combo3.Text = "Column Name" Or Combo3.Text = "" Then
                '        '条件文もしくはカラム選択がなされていない場合テーブルを表示するだけのSQL発行
                ssql = "Select * From " & DataCombo1.Text


            ElseIf Combo1.Text = "like" Then

                If Combo2.Text = "前方" Then
                    ssql = "Select * From (" & JointSQL & ") as " & DataCombo1.Text & " Where " & Combo3.Text & " " & Combo1.Text & " '" & Text1.Text & "%'"

                ElseIf Combo2.Text = "後方" Then
                    ssql = "Select * From (" & JointSQL & ") as " & DataCombo1.Text & " Where " & Combo3.Text & " " & Combo1.Text & " '%" & Text1.Text & "'"

                ElseIf Combo2.Text = "部分" Then
                    ssql = "Select * From (" & JointSQL & ") as " & DataCombo1.Text & " Where " & Combo3.Text & " " & Combo1.Text & " '%" & Text1.Text & "%'"

                End If


            ElseIf Combo1.Text <> "=" And Combo1.Text <> "bet" Then
                ssql = "Select * From (" & JointSQL & ") as " & DataCombo1.Text & " Where " & Combo3.Text & " " & Combo1.Text & " '" & Text1.Text & "'"

            ElseIf Combo1.Text = "=" Then
                ssql = "Select * From (" & JointSQL & ") as " & DataCombo1.Text & " Where " & Combo3.Text & " = '" & Text1.Text & "'"

            ElseIf Combo1.Text = "bet" Then
                ssql = "Select * From (" & JointSQL & ") as " & DataCombo1.Text & " where " & Combo3.Text & " between '" & Text1.Text & "' and '" & Text2.Text & "'"

            End If

            '▲-------------------------------------------------------------

        End If

        '■----------------------------------------------------------------------

        SSR1000.Label1.Text = "名称未設定"
        SSR1000.SQLcmd.Text = ssql
        Me.Close()
        Call SSR1000.Reseach()

        'SQLERR:
        '        Exit Sub
    End Sub
    '■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CallF = "S"
        SSR1301.Show()

    End Sub
End Class