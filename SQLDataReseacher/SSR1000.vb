Imports System.Data.SqlClient

Public Class SSR1000

    '▼ソース内容---------------------------//
    '　ソート押下
    '　更新押下
    '　クリア押下
    '　実行ボタン押下
    '　SQL実行ギミック
    '▲-------------------------------------//

    Private Sub DataEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboFlg = "1"

    End Sub

#Region "メインメニューボタン群"

    Private Sub STBLBtn_Click(sender As Object, e As EventArgs) Handles STBLBtn.Click

        STBLBtn.Enabled = False
        Dim opn As New SSR1100()
        opn.strConnectSQL = strConnectSQL
        opn.Show(Me)

    End Sub

    Private Sub OutBtn_Click(sender As Object, e As EventArgs) Handles OutBtn.Click

        On Error GoTo SQLERR

        If DGV1.Rows.Count = 0 Then
            MsgBox("保存するテーブルがありません。")
            Exit Sub
        End If

        OutTBLNM = Label1.Text
        Filter = "CSVファイル(*.csv;)|*.csv;|すべてのファイル(*.*)|*.*"
        Call SuperBox.OpenSaveWindow(Filter, OutTBLNM)
        Call SaveToCsv(DGV1, OutAddress)

SQLERR:
        Exit Sub
    End Sub

    Private Sub SavBtn_Click(sender As Object, e As EventArgs) Handles SubBtn.Click
        SubBtn.Enabled = False
        Dim sav As New SubTBLWindow()
        sav.Show(Me)
        Cursor = Cursors.Arrow
    End Sub

    Private Sub UDBtn_Click(sender As Object, e As EventArgs) Handles UDBtn.Click

        Dim TBLNMmemo As String = Label1.Text

        'SQLCBによる更新用SQLの生成
        Try
            DGV1.Refresh()
            Dim builder As SqlCommandBuilder = New SqlCommandBuilder(SQLDA)
            builder.GetUpdateCommand()

            result = SQLDA.Update(SQLDS.Tables(0))

            Call RSBtn_Click(sender, e)

            Label1.Text = TBLNMmemo

        Catch ex As Exception
            'If ex.HResult = "-2146233079" Then
            '    MsgBox("エラーが発生しました。 -2146233079", MsgBoxStyle.Critical)
            '    Exit Sub
            'End If
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ComboBox1_DockChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboFlg = "1" Then

            Dim Ans As String = MsgBox("接続しているデータベースを変更してよろしいですか？" & Environment.NewLine & _
                                       "現在保持しているデータは破棄されます。", MsgBoxStyle.OkCancel)

            If Ans = 1 Then 'キャンセルの場合、値を元に戻す

                strConnectSQL = "Server=" & instance & ";"
                strConnectSQL = strConnectSQL & "Initial Catalog=" & ComboBox1.Text & ";"
                strConnectSQL = strConnectSQL & "User ID=" & SQLid & ";"
                strConnectSQL = strConnectSQL & "Password=" & SQLpass & ";"
                strConnectSQL = strConnectSQL & "Integrated Security=false"

                ComboBox1.Refresh()
                Label1.Text = "名称未設定"
                SQLDS = Nothing
                SQLDS = New DataSet
                DGV1.DataSource = ""
                DGV1.Refresh()

            End If

        End If

    End Sub

    Private Sub SortBtn_Click(sender As Object, e As EventArgs) Handles SortBtn.Click
        SortBtn.Enabled = False
        '▼ソート用コンボボックスの値をTDBGridより取得-----------------
        Dim sor As New SSR1340()

        sor.SortCmb1.Items.Clear()
        For i = 0 To DGV1.ColumnCount - 1
            sor.SortCmb1.Items.Add(DGV1.Columns(i).HeaderText)
        Next i
        sor.SortCmb1.Refresh()

        sor.SortCmb2.Items.Clear()
        For i = 0 To DGV1.ColumnCount - 1
            sor.SortCmb2.Items.Add(DGV1.Columns(i).HeaderText)
        Next i
        sor.SortCmb2.Refresh()
        sor.SortCmb3.Items.Clear()
        For i = 0 To DGV1.ColumnCount - 1
            sor.SortCmb3.Items.Add(DGV1.Columns(i).HeaderText)
        Next i
        SSR1340.SortCmb3.Refresh()

        '▲------------------------------------------------------------

        sor.Show(Me)
    End Sub

    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click
        MenuBtn.Enabled = False
        Dim men As New SSR1300()
        men.Show(Me)
    End Sub

    Private Sub SizeUp_Click(sender As Object, e As EventArgs) Handles SizeUp.Click

        DGV1.Font = New Font(DGV1.Font.Name, DGV1.Font.Size + 1)
        DGV1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

    End Sub

    Private Sub SizeDown_Click(sender As Object, e As EventArgs) Handles SizeDown.Click
        If DGV1.Font.Size > 1 Then
            DGV1.Font = New Font(DGV1.Font.Name, DGV1.Font.Size - 1)
            DGV1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        End If
    End Sub

#End Region

#Region "SQLコマンドメニュー群"
    Private Sub ModeBtn_Click(sender As Object, e As EventArgs) Handles ModeBtn.Click

        If ModeBtn.Text = "▲ EditMode" Then
            CtlPanel.Top = CtlPanel.Top - 300
            CtlPanel.Height = CtlPanel.Height + 300
            SQLcmd.Height = SQLcmd.Height + 300
            ExePanel.Height = ExePanel.Height + 300
            RSBtn.Top = RSBtn.Top + 300
            ModeBtn.Text = "▼ UserMode"
            Me.Text = "SQL Reseacher - EditMode"


            MaximizeBox = False
            MinimizeBox = False

        Else
            CtlPanel.Top = DGV1.Top + DGV1.Height
            SQLcmd.Height = SQLcmd.Height - 300
            ExePanel.Height = ExePanel.Height - 300
            RSBtn.Top = RSBtn.Top - 300
            ModeBtn.Text = "▲ EditMode"
            Me.Text = "SQL Reseacher"

            MaximizeBox = True
            MinimizeBox = True

        End If

    End Sub

    Private Sub InsBtn_Click(sender As Object, e As EventArgs) Handles InsBtn.Click
        SQLcmd.Text = "Insert into "
        SQLcmd.Select(SQLcmd.Text.Length, 0)
        SQLcmd.Focus()
    End Sub

    Private Sub DelBtn_Click(sender As Object, e As EventArgs) Handles DelBtn.Click
        SQLcmd.Text = "Delete from "
        SQLcmd.Select(SQLcmd.Text.Length, 0)
        SQLcmd.Focus()
    End Sub

    Private Sub SelBtn_Click(sender As Object, e As EventArgs) Handles SelBtn.Click
        SQLcmd.Text = "Select * from "
        SQLcmd.Select(SQLcmd.Text.Length, 0)
        SQLcmd.Focus()
    End Sub

    Private Sub CleBtn_Click(sender As Object, e As EventArgs) Handles CleBtn.Click
        SQLcmd.Text = ""
    End Sub

    Private Sub SQLcmd_KeyDown(sender As Object, e As KeyEventArgs) Handles SQLcmd.KeyDown

        '▼F5キー押下時アクション-ERR001補填に作成---------------------
        If e.KeyData = Keys.F5 Then
            Call RSBtn_Click(sender, e)
        ElseIf e.KeyData = Keys.F4 Then
            Call ModeBtn_Click(sender, e)
        ElseIf e.KeyData = Keys.F6 Then
            Call InsBtn_Click(sender, e)
        ElseIf e.KeyData = Keys.F7 Then
            Call DelBtn_Click(sender, e)
        ElseIf e.KeyData = Keys.F8 Then
            Call SelBtn_Click(sender, e)
        ElseIf e.KeyData = Keys.F9 Then
            Call CleBtn_Click(sender, e)
        ElseIf e.KeyData = Keys.F11 Then
            Me.WindowState = FormWindowState.Maximized
        End If
        '▲------------------------------------------------------------

    End Sub

    Public Sub RSBtn_Click(sender As Object, e As EventArgs) Handles RSBtn.Click

        Label1.Text = "名称未設定"
        Call Reseach()

    End Sub

#End Region

#Region "CSV保存部分"
    Public Sub SaveToCsv(ByVal tempDgv As DataGridView, ByVal outAddoress As String)

        '保存したいDataGridViewコントロールの名前を引数として
        '設定します。
        '1行もデータが無い場合は、保存を中止します。
        If tempDgv.Rows.Count = 0 Then
            Exit Sub
        End If

        '変数を定義します。
        Dim i As Integer
        Dim j As Integer
        Dim strFileName As String
        Dim strResult As New System.Text.StringBuilder

        '保存ダイアログでファイル名を設定した場合に処理を実行します。

        'コラムヘッダを1行目に列記します。
        '※ヘッダ行が不要な場合は削除可能です。
        For i = 0 To tempDgv.Columns.Count - 1
            Select Case i
                Case 0
                    strResult.Append("""" & _
                    tempDgv.Columns(i).HeaderText.ToString & """")

                Case tempDgv.Columns.Count - 1
                    strResult.Append("," & """" & _
                    tempDgv.Columns(i).HeaderText.ToString & _
                    """" & vbCrLf)

                Case Else
                    strResult.Append("," & """" & _
                    tempDgv.Columns(i).HeaderText.ToString & """")
            End Select

        Next

        'データを保存します。
        '※新規行の追加を認めている場合は、次行の
        '「tempDgv.Columns.Count - 1」を
        '「tempDgv.Columns.Count - 2」としてください。
        For i = 0 To tempDgv.Rows.Count - 2
            For j = 0 To tempDgv.Columns.Count - 1
                Select Case j
                    Case 0
                        strResult.Append("""" & _
                        tempDgv.Rows(i).Cells(j).Value.ToString & _
                        """")

                    Case tempDgv.Columns.Count - 1
                        strResult.Append("," & """" & _
                        tempDgv.Rows(i).Cells(j).Value.ToString & _
                        """" & vbCrLf)

                    Case Else
                        strResult.Append("," & """" & _
                        tempDgv.Rows(i).Cells(j).Value.ToString & _
                        """")
                End Select

            Next
        Next

        'ファイル名を保存ダイアログで指定した値に設定します。
        strFileName = outAddoress

        'Shift-JISで保存します。
        Dim swText As New System.IO.StreamWriter(strFileName, _
         False, System.Text.Encoding.GetEncoding(932))
        swText.Write(strResult.ToString)
        swText.Dispose()

    End Sub
#End Region

#Region "コンテキストメニュー設定部分"
    '▼コンテキストメニュー設定部分===========================//
    Private Sub InsertRow_Click(sender As Object, e As EventArgs) Handles InsertRow.Click

        '▼インサート------------------------------//

        SQLDA.Fill(SQLDS)
        '挿入する行を新規作成する
        Row = SQLDS.Tables(0).NewRow()

        Dim i As Integer 'For用変数

        'カラム数文ループを行い、各項目にNULL値を入力
        For i = 0 To DGV1.ColumnCount - 1
            Row(DGV1.Columns(i).Name) = ""
        Next i

        'データセットの選択している位置に上記行を挿入し、更新
        x = DGV1.CurrentCell.RowIndex + 1
        SQLDS.Tables(0).Rows.InsertAt(Row, x)
        SQLDA.Update(SQLDS)

        SQLDA.MissingSchemaAction = MissingSchemaAction.AddWithKey

        '!!ここまでではDBには反映されない
        '▲----------------------------------------//

    End Sub

    Private Sub DeleteRow_Click(sender As Object, e As EventArgs) Handles DeleteRow.Click

        '▼デリート--------------------------------//

        x = DGV1.CurrentCell.RowIndex '選択中の座標取得
        SQLDS.Tables(0).Rows(x).Delete() '指定座標削除 

        '▲----------------------------------------//

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click

        '▼キャンセル------------------------------//

        ContextMenuStrip1.Close()

        '▲----------------------------------------//

    End Sub

#End Region

    Public Sub Reseach()

        '■■■■■■■■■■■■　SQL 実行部分　■■■■■■■■■■■■■

        '▼SQL構文を指定---------------------------//
        strSQL = SQLcmd.Text
        '▲----------------------------------------//

        If SQLcmd.Text <> "" Then

            Try '▼SQLServer接続部分-----------------------//

                SQLDS = Nothing
                SQLDS = New DataSet

                'SQL接続を開き、データ取得
                SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

                '取得したデータをデータセットに格納
                SQLDA.Fill(SQLDS, "TEST")
                '▲----------------------------------------//


                '▼DataGridView連結------------------------//

                DGV1.DataSource = SQLDS.Tables("TEST")
                RecCnt.Text = "Column : " & SQLDS.Tables("TEST").Columns.Count & "   Row : " & SQLDS.Tables("TEST").Rows.Count
                DGV1.ContextMenuStrip = ContextMenuStrip1

                '▲----------------------------------------//


                '▼DataGridView表示設定--------------------//

                With DGV1
                    .Columns(0).Width = 125
                    .Columns(1).Width = 400
                    .AlternatingRowsDefaultCellStyle.BackColor = Color.Azure
                    .Font = New Font("メイリオ", 8) 'Fontsize
                End With

                '▲----------------------------------------//

                '▼ソート用コンボボックスの値をTDBGridより取得-----------------

                SSR1340.SortCmb1.Items.Clear()
                For i = 0 To DGV1.ColumnCount - 1
                    SSR1340.SortCmb1.Items.Add(DGV1.Columns(i).HeaderText)
                Next i
                SSR1340.SortCmb1.Refresh()

                SSR1340.SortCmb2.Items.Clear()
                For i = 0 To DGV1.ColumnCount - 1
                    SSR1340.SortCmb2.Items.Add(DGV1.Columns(i).HeaderText)
                Next i
                SSR1340.SortCmb2.Refresh()
                SSR1340.SortCmb3.Items.Clear()
                For i = 0 To DGV1.ColumnCount - 1
                    SSR1340.SortCmb3.Items.Add(DGV1.Columns(i).HeaderText)
                Next i
                SSR1340.SortCmb3.Refresh()

                '▲------------------------------------------------------------

                '■■■■■■■■■■■■　SQL 実行部分　■■■■■■■■■■■■■


            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

        Else
        End If

    End Sub

    Private Sub Form1_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize

        Dim myControl As Control
        myControl = sender

        Select Case MenuBar
            Case 0 'メニューバー非表示

                MenuStrip1.Visible = False
                DGV1.Top = 58
                DGV1.Left = 1
                DGV1.Width = Me.Width - 20
                DGV1.Height = Me.Height - DGV1.Top - SQLcmd.Height - 68


                Panel2.Top = 4
                Panel2.Left = 2
                CtlPanel.Top = DGV1.Top + DGV1.Height
                CtlPanel.Left = 0
                CtlPanel.Width = Me.Width
                SQLcmd.Width = CtlPanel.Width - 150

                Panel1.Left = 0
                Panel1.Top = CtlPanel.Top + 82
                Panel1.Width = SQLcmd.Width + 140
                Label2.Left = Panel1.Left + Panel1.Width - Label2.Width - 10

                ExePanel.Left = SQLcmd.Width

            Case 1

                MenuStrip1.Visible = True
                Panel2.Top = 28
                Panel2.Left = 1

                DGV1.Top = 80
                DGV1.Left = 2
                DGV1.Width = Me.Width - 20
                DGV1.Height = Me.Height - DGV1.Top - SQLcmd.Height - 68

                CtlPanel.Top = DGV1.Top + DGV1.Height
                CtlPanel.Left = 0
                CtlPanel.Width = Me.Width
                SQLcmd.Width = CtlPanel.Width - 150

                Panel1.Left = 0
                Panel1.Top = CtlPanel.Top + 82
                Panel1.Width = SQLcmd.Width + 140
                Label2.Left = Panel1.Left + Panel1.Width - Label2.Width - 10

                ExePanel.Left = SQLcmd.Width
        End Select

    End Sub

    Private Sub DataEditor_FormClosing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing

        If SQLcmd.Text <> "" Then

            If MessageBox.Show("終了すると保持している一時テーブルは削除されます。" & Environment.NewLine & "SQL Reseacherを終了してよろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                e.Cancel = True
            End If
        End If

    End Sub

End Class
