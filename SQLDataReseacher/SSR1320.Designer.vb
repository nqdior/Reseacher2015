<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSR1320
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Combo2 = New System.Windows.Forms.ComboBox()
        Me.Combo3 = New System.Windows.Forms.ComboBox()
        Me.Text1 = New System.Windows.Forms.RichTextBox()
        Me.Text2 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Combo1 = New System.Windows.Forms.ComboBox()
        Me.DataCombo1 = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Combo2
        '
        Me.Combo2.FormattingEnabled = True
        Me.Combo2.Location = New System.Drawing.Point(201, 202)
        Me.Combo2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Combo2.Name = "Combo2"
        Me.Combo2.Size = New System.Drawing.Size(75, 26)
        Me.Combo2.TabIndex = 1
        '
        'Combo3
        '
        Me.Combo3.FormattingEnabled = True
        Me.Combo3.Location = New System.Drawing.Point(44, 125)
        Me.Combo3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Combo3.Name = "Combo3"
        Me.Combo3.Size = New System.Drawing.Size(177, 26)
        Me.Combo3.TabIndex = 2
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(44, 202)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(150, 29)
        Me.Text1.TabIndex = 3
        Me.Text1.Text = ""
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(181, 248)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(150, 29)
        Me.Text2.TabIndex = 4
        Me.Text2.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(150, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 21)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "～"
        '
        'Combo1
        '
        Me.Combo1.FormattingEnabled = True
        Me.Combo1.Location = New System.Drawing.Point(277, 128)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.Size = New System.Drawing.Size(43, 26)
        Me.Combo1.TabIndex = 6
        '
        'DataCombo1
        '
        Me.DataCombo1.FormattingEnabled = True
        Me.DataCombo1.Location = New System.Drawing.Point(44, 50)
        Me.DataCombo1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataCombo1.Name = "DataCombo1"
        Me.DataCombo1.Size = New System.Drawing.Size(177, 26)
        Me.DataCombo1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(278, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 50)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(29, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 59)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TableName"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(29, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(206, 59)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ColumnName"
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(255, 101)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 59)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Type"
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(29, 178)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(319, 65)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Value"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(255, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 30)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Call"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'SearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 362)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataCombo1)
        Me.Controls.Add(Me.Combo1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Combo3)
        Me.Controls.Add(Me.Combo2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SearchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "SearchForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Combo2 As System.Windows.Forms.ComboBox
    Friend WithEvents Combo3 As System.Windows.Forms.ComboBox
    Friend WithEvents Text1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Text2 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Combo1 As System.Windows.Forms.ComboBox
    Friend WithEvents DataCombo1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
