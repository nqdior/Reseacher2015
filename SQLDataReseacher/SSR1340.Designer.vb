<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSR1340
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
        Me.MenuPanel = New System.Windows.Forms.Panel()
        Me.DescChk3 = New System.Windows.Forms.CheckBox()
        Me.SortCmb3 = New System.Windows.Forms.ComboBox()
        Me.DescChk2 = New System.Windows.Forms.CheckBox()
        Me.SortCmb2 = New System.Windows.Forms.ComboBox()
        Me.DescChk1 = New System.Windows.Forms.CheckBox()
        Me.SortCmb1 = New System.Windows.Forms.ComboBox()
        Me.SortBtn = New System.Windows.Forms.Button()
        Me.MenuPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuPanel
        '
        Me.MenuPanel.Controls.Add(Me.DescChk3)
        Me.MenuPanel.Controls.Add(Me.SortCmb3)
        Me.MenuPanel.Controls.Add(Me.DescChk2)
        Me.MenuPanel.Controls.Add(Me.SortCmb2)
        Me.MenuPanel.Controls.Add(Me.DescChk1)
        Me.MenuPanel.Controls.Add(Me.SortCmb1)
        Me.MenuPanel.Location = New System.Drawing.Point(3, 9)
        Me.MenuPanel.Name = "MenuPanel"
        Me.MenuPanel.Size = New System.Drawing.Size(497, 52)
        Me.MenuPanel.TabIndex = 12
        '
        'DescChk3
        '
        Me.DescChk3.AutoSize = True
        Me.DescChk3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.DescChk3.Location = New System.Drawing.Point(441, 14)
        Me.DescChk3.Name = "DescChk3"
        Me.DescChk3.Size = New System.Drawing.Size(55, 22)
        Me.DescChk3.TabIndex = 16
        Me.DescChk3.Text = "Desc"
        Me.DescChk3.UseVisualStyleBackColor = True
        '
        'SortCmb3
        '
        Me.SortCmb3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SortCmb3.FormattingEnabled = True
        Me.SortCmb3.Location = New System.Drawing.Point(336, 12)
        Me.SortCmb3.Name = "SortCmb3"
        Me.SortCmb3.Size = New System.Drawing.Size(101, 26)
        Me.SortCmb3.TabIndex = 15
        '
        'DescChk2
        '
        Me.DescChk2.AutoSize = True
        Me.DescChk2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.DescChk2.Location = New System.Drawing.Point(276, 14)
        Me.DescChk2.Name = "DescChk2"
        Me.DescChk2.Size = New System.Drawing.Size(55, 22)
        Me.DescChk2.TabIndex = 14
        Me.DescChk2.Text = "Desc"
        Me.DescChk2.UseVisualStyleBackColor = True
        '
        'SortCmb2
        '
        Me.SortCmb2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SortCmb2.FormattingEnabled = True
        Me.SortCmb2.Location = New System.Drawing.Point(171, 12)
        Me.SortCmb2.Name = "SortCmb2"
        Me.SortCmb2.Size = New System.Drawing.Size(101, 26)
        Me.SortCmb2.TabIndex = 13
        '
        'DescChk1
        '
        Me.DescChk1.AutoSize = True
        Me.DescChk1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.DescChk1.Location = New System.Drawing.Point(113, 12)
        Me.DescChk1.Name = "DescChk1"
        Me.DescChk1.Size = New System.Drawing.Size(55, 22)
        Me.DescChk1.TabIndex = 12
        Me.DescChk1.Text = "Desc"
        Me.DescChk1.UseVisualStyleBackColor = True
        '
        'SortCmb1
        '
        Me.SortCmb1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SortCmb1.FormattingEnabled = True
        Me.SortCmb1.Location = New System.Drawing.Point(5, 10)
        Me.SortCmb1.Name = "SortCmb1"
        Me.SortCmb1.Size = New System.Drawing.Size(101, 26)
        Me.SortCmb1.TabIndex = 11
        '
        'SortBtn
        '
        Me.SortBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SortBtn.Location = New System.Drawing.Point(504, 8)
        Me.SortBtn.Name = "SortBtn"
        Me.SortBtn.Size = New System.Drawing.Size(70, 50)
        Me.SortBtn.TabIndex = 17
        Me.SortBtn.Text = "SORT"
        Me.SortBtn.UseVisualStyleBackColor = True
        '
        'SortForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 63)
        Me.Controls.Add(Me.SortBtn)
        Me.Controls.Add(Me.MenuPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SortForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SortForm"
        Me.MenuPanel.ResumeLayout(False)
        Me.MenuPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuPanel As System.Windows.Forms.Panel
    Friend WithEvents DescChk3 As System.Windows.Forms.CheckBox
    Friend WithEvents SortCmb3 As System.Windows.Forms.ComboBox
    Friend WithEvents DescChk2 As System.Windows.Forms.CheckBox
    Friend WithEvents SortCmb2 As System.Windows.Forms.ComboBox
    Friend WithEvents DescChk1 As System.Windows.Forms.CheckBox
    Friend WithEvents SortCmb1 As System.Windows.Forms.ComboBox
    Friend WithEvents SortBtn As System.Windows.Forms.Button
End Class
