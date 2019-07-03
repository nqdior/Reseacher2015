Public Class SSR1340

    Private Sub SortForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SSR1000.SortBtn.Enabled = True
    End Sub


    Private Sub SortForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Top = SSR1000.Top + 150
        Me.Left = SSR1000.Left + SSR1000.Width - Me.Width - 100

    End Sub

    Private Sub SortBtn_Click_1(sender As Object, e As EventArgs) Handles SortBtn.Click
        '▼OrderBy判定、存在すればOrderBy以降切捨------------------

        strSQL = SSR1000.SQLcmd.Text
        tmp = InStr(1, strSQL, "order by")
        'tmp2 = InStr(1, strSQL, "ORDER BY")
        If tmp = 0 Then
            strSQL = SSR1000.SQLcmd.Text
            tmp = InStr(1, strSQL, "ORDER BY")
            If tmp = 0 Then
                strSQL2 = SSR1000.SQLcmd.Text
            Else
                strSQL2 = Strings.Left(SSR1000.SQLcmd.Text, tmp - 2)
            End If
        Else
            strSQL2 = Strings.Left(SSR1000.SQLcmd.Text, tmp - 2)
        End If

        '▲--------------------------------------------------------

        '▼ソート条件重複空白判定--------------------------------------

        If SortCmb1.Text = "" And SortCmb2.Text = "" And SortCmb3.Text = "" Then
            MsgBox("ソートキーが設定されていません")
            Exit Sub

        ElseIf SortCmb1.Text = SortCmb2.Text And SortCmb1.Text <> "" Then
            MsgBox("ソートキーが重複しています")
            Exit Sub

        ElseIf SortCmb1.Text = SortCmb3.Text And SortCmb1.Text <> "" Then
            MsgBox("ソートキーが重複しています")
            Exit Sub

        ElseIf SortCmb2.Text = SortCmb3.Text And SortCmb2.Text <> "" Then
            MsgBox("ソートキーが重複しています")
            Exit Sub

        End If

        '▲------------------------------------------------------------

        '▼SQL発行部分-------------------------------------------------

        If SortCmb1.Text <> "" Then
            strSQL = strSQL2 & " order by " & SortCmb1.Text
            If DescChk1.CheckState = 1 Then
                strSQL = strSQL & " desc"
            End If
        Else : Exit Sub
        End If

        If SortCmb2.Text <> "" Then
            strSQL = strSQL & ", " & SortCmb2.Text
            If DescChk2.CheckState = 1 Then
                strSQL = strSQL & " desc"
            End If
        Else
        End If

        If SortCmb3.Text <> "" Then
            strSQL = strSQL & ", " & SortCmb3.Text
            If DescChk3.CheckState = 1 Then
                strSQL = strSQL & " desc"
            End If
        Else
        End If

        '▲-----------------------------------------------------------

        SSR1000.SQLcmd.Text = strSQL
        Call SSR1000.Reseach()

    End Sub
End Class