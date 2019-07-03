<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSR1300
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
        Me.JoinBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.CalcBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'JoinBtn
        '
        Me.JoinBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.JoinBtn.Location = New System.Drawing.Point(116, 75)
        Me.JoinBtn.Name = "JoinBtn"
        Me.JoinBtn.Size = New System.Drawing.Size(120, 50)
        Me.JoinBtn.TabIndex = 35
        Me.JoinBtn.Text = "Join"
        Me.JoinBtn.UseVisualStyleBackColor = True
        '
        'SearchBtn
        '
        Me.SearchBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SearchBtn.Location = New System.Drawing.Point(116, 146)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(120, 50)
        Me.SearchBtn.TabIndex = 36
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'CalcBtn
        '
        Me.CalcBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.CalcBtn.Location = New System.Drawing.Point(116, 227)
        Me.CalcBtn.Name = "CalcBtn"
        Me.CalcBtn.Size = New System.Drawing.Size(120, 50)
        Me.CalcBtn.TabIndex = 37
        Me.CalcBtn.Text = "Calc"
        Me.CalcBtn.UseVisualStyleBackColor = True
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 363)
        Me.Controls.Add(Me.CalcBtn)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.JoinBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "MenuForm"
        Me.Text = "MenuWindow"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents JoinBtn As System.Windows.Forms.Button
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents CalcBtn As System.Windows.Forms.Button
End Class
