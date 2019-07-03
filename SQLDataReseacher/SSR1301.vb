Public Class SSR1301

    Private Sub CallForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SuperBox.LblBox(1) = Label1 : SuperBox.LblBox(2) = Label2
        SuperBox.LblBox(3) = Label3 : SuperBox.LblBox(4) = Label4
        SuperBox.LblBox(5) = Label5
        SuperBox.CallBtn(1) = Button1 : SuperBox.CallBtn(2) = Button2
        SuperBox.CallBtn(3) = Button3 : SuperBox.CallBtn(4) = Button4
        SuperBox.CallBtn(5) = Button5

        For j = 1 To 5
            SuperBox.LblBox(j).Text = SuperBox.NMBox(j)
        Next

        For i = 1 To 5
            If LblBox(i).Text = "" Then
                CallBtn(i).Enabled = False
            End If
        Next


        Me.TopMost = True
        Me.Top = SSR1000.Top + 86
        Me.Left = SSR1000.Left + 11
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click

        Dim Btn As Button = CType(sender, Button)
        BtnStr = Btn.Name.Substring(6, 1)
        i = Integer.Parse(BtnStr)

        '▼OrderBy判定、存在すればOrderBy以降切捨------------------

        tmp = InStr(1, SuperBox.SQLBox(i), "order")
        If tmp = 0 Then
            tmp2 = SuperBox.SQLBox(i)
        Else
            tmp2 = SuperBox.SQLBox(i).Substring(0, tmp - 2)
        End If

        '▲--------------------------------------------------------


        JointSQL = tmp2
        strSQL = SuperBox.SQLBox(i)
        int = i

        '▲--------------------------------------------------------

        '▼SQLServer接続部分-----------------------//

        SQLDS = Nothing
        SQLDS = New DataSet

        'SQL接続を開き、データ取得
        SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST")



        '▼テーブル引渡し部分------------------------------------------------//
        Select Case CallF

            Case "S" 'SearchFormに引渡し


                SSR1320.DataCombo1.Text = SuperBox.NMBox(i)
                SSR1320.DataCombo1.Enabled = False

                SSR1320.Combo3.DataSource = Nothing
                SSR1320.Combo3.Items.Clear()

                For i = 0 To SQLDS.Tables("TEST").Columns.Count - 1
                    SSR1320.Combo3.Items.Add(SQLDS.Tables("TEST").Columns(i).ColumnName)
                Next i


            Case "J" 'JoinFormに引渡し
                SSR1310.Tag = "(" & SuperBox.SQLBox(i) & ") as " & SuperBox.NMBox(i)
                With SSR1310.ComboBox3
                    .DataSource = Nothing
                    .Items.Clear()
                End With
                With SSR1310.ComboBox1
                    .DataSource = Nothing
                    .Text = SuperBox.NMBox(i)
                    .Enabled = False
                End With

                '項目一覧引渡し--------------------------------------------------
                For i = 0 To SQLDS.Tables("TEST").Columns.Count - 1
                    SSR1310.ComboBox3.Items.Add(SQLDS.Tables("TEST").Columns(i).ColumnName)
                Next i

                '表示項目選択グリッド--------------------------------------------
                SSR1310.DGVA.Columns.Add("clmName1", SSR1310.ComboBox1.Text)
                For i = 0 To SQLDS.Tables("TEST").Columns.Count - 1
                    SSR1310.DGVA.Rows.Add()
                    Dim idx As Integer = SSR1310.DGVA.Rows.Count - 1
                    SSR1310.DGVA.Item(0, i).Value = SQLDS.Tables("TEST").Columns(i).ColumnName
                Next i

            Case "C"

                With SSR1330.ComboBox3
                    .DataSource = Nothing
                    .Items.Clear()
                End With
                With SSR1330.ComboBox1
                    .DataSource = Nothing
                    .Text = SuperBox.NMBox(i)
                    .Enabled = False
                End With


                '項目一覧引渡し--------------------------------------------------
                For i = 0 To SQLDS.Tables("TEST").Columns.Count - 1
                    SSR1330.ComboBox3.Items.Add(SQLDS.Tables("TEST").Columns(i).ColumnName)
                Next i
                For i = 0 To SQLDS.Tables("TEST").Columns.Count - 1
                    SSR1330.ComboBox2.Items.Add(SQLDS.Tables("TEST").Columns(i).ColumnName)
                Next i

                ''表示項目選択グリッド--------------------------------------------
                'JoinForm.DGVA.Columns.Add("clmName1", CalcForm.ComboBox1.Text)
                'For i = 0 To SQLDS.Tables("TEST").Columns.Count - 1
                '    CalcForm.DGVA.Rows.Add()
                '    Dim idx As Integer = CalcForm.DGVA.Rows.Count - 1
                '    CalcForm.DGVA.Item(0, i).Value = SQLDS.Tables("TEST").Columns(i).ColumnName
                'Next i

        End Select

        '▲------------------------------------------------------------------//

        Me.Close()

    End Sub


    Private Sub Callform_FormClosing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing

        For i = 1 To 5
            CallBtn(i).Enabled = True
        Next i

    End Sub


End Class