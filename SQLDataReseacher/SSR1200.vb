Public Class SubTBLWindow

    Public BtnStr As String
    Public i As Integer
    Public j As Integer

    Private Sub SubTBLWindow_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SSR1000.SubBtn.Enabled = True
    End Sub

    Private Sub SaveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SuperBox.RtbBox(1) = TextBox1 : SuperBox.RtbBox(2) = TextBox2
        SuperBox.RtbBox(3) = TextBox3 : SuperBox.RtbBox(4) = TextBox4
        SuperBox.RtbBox(5) = TextBox5

        For j = 1 To 5
            SuperBox.RtbBox(j).Text = SuperBox.NMBox(j)
        Next

        Me.Top = SSR1000.Top + 86
        Me.Left = SSR1000.Left + 11

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click
        Dim Ans As Integer
        Dim Btn As Button = CType(sender, Button)
        BtnStr = Btn.Name.Substring(6, 1)
        i = Integer.Parse(BtnStr)

        If SSR1000.SQLcmd.Text = "" Then

            MsgBox("保持しているテーブル定義が見つかりません。")
            Exit Sub

        Else
            If TextBox1.Text <> "" Or TextBox2.Text <> "" Or TextBox3.Text <> "" Or TextBox4.Text <> "" Or TextBox5.Text <> "" Then

                If NMBox(i) <> "" Then '名前保持が既にあり、

                    Ans = MsgBox("テーブルが既に保持されています。上書きしてよろしいですか？", MsgBoxStyle.OkCancel)

                    If Ans = 2 Then 'キャンセルの場合、値を元に戻す

                        RtbBox(i).Text = SuperBox.NMBox(i)

                        Exit Sub
                    End If
                End If

                SuperBox.SQLBox(i) = SSR1000.SQLcmd.Text
                SuperBox.NMBox(i) = SuperBox.RtbBox(i).Text
                MsgBox("表示中のテーブルを保存しました。")

            Else

                MsgBox("保存する一時テーブル名を入力してください。")

            End If

        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click

        Dim Btn As Button = CType(sender, Button)

        If Btn.Name <> "Button10" Then
            BtnStr = Btn.Name.Substring(6, 1)
        Else
            BtnStr = Btn.Name.Substring(6, 2)
        End If

        i = Integer.Parse(BtnStr) - 5

        If SQLBox(i) = "" Then
            MsgBox("ロードするテーブルがありません。")
            Exit Sub
        End If

        SSR1000.Label1.Text = SuperBox.NMBox(i)
        SSR1000.SQLcmd.Text = SuperBox.SQLBox(i)
        Call SSR1000.Reseach()

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click
        On Error GoTo SQLERR

        Filter = "SQLファイル(*.sql;)|*.sql;|すべてのファイル(*.*)|*.*"

        Dim Btn As Button = CType(sender, Button)
        BtnStr = Btn.Name.Substring(6, 2)

        i = Integer.Parse(BtnStr) - 10

        If SQLBox(i) = "" Then
            MsgBox("テーブルが保持されていないため、出力は行えません。")
            Exit Sub
        End If

        OutTBLNM = NMBox(i)
        Call SuperBox.OpenSaveWindow(Filter, OutTBLNM)

        'Shift JISで書き込む
        '書き込むファイルが既に存在している場合は、上書きする
        Dim sw As New System.IO.StreamWriter(OutAddress, False, System.Text.Encoding.GetEncoding("shift_jis"))

        'TextBox1.Textの内容を書き込む
        sw.Write(SQLBox(i))
        '閉じる
        sw.Close()

SQLERR:
        Exit Sub
    End Sub
End Class