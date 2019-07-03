<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SDR0000
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SDR0000))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Passlbl = New System.Windows.Forms.Label()
        Me.IDlbl = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.UserNM = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Text2)
        Me.Panel2.Controls.Add(Me.Text1)
        Me.Panel2.Controls.Add(Me.Passlbl)
        Me.Panel2.Controls.Add(Me.IDlbl)
        Me.Panel2.Location = New System.Drawing.Point(91, 138)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(401, 193)
        Me.Panel2.TabIndex = 27
        Me.Panel2.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(35, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(334, 35)
        Me.Panel1.TabIndex = 31
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("メイリオ", 9.5!)
        Me.RichTextBox1.Location = New System.Drawing.Point(119, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(190, 26)
        Me.RichTextBox1.TabIndex = 30
        Me.RichTextBox1.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 9.5!)
        Me.Label1.Location = New System.Drawing.Point(7, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 20)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Now Instance is "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.Button1.Location = New System.Drawing.Point(89, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(219, 41)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Select DB"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Text2
        '
        Me.Text2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Text2.Location = New System.Drawing.Point(148, 103)
        Me.Text2.Name = "Text2"
        Me.Text2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text2.Size = New System.Drawing.Size(158, 25)
        Me.Text2.TabIndex = 29
        '
        'Text1
        '
        Me.Text1.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Text1.Location = New System.Drawing.Point(147, 63)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(158, 25)
        Me.Text1.TabIndex = 28
        '
        'Passlbl
        '
        Me.Passlbl.AutoSize = True
        Me.Passlbl.BackColor = System.Drawing.Color.Transparent
        Me.Passlbl.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Passlbl.ForeColor = System.Drawing.Color.Black
        Me.Passlbl.Location = New System.Drawing.Point(88, 103)
        Me.Passlbl.Name = "Passlbl"
        Me.Passlbl.Size = New System.Drawing.Size(37, 20)
        Me.Passlbl.TabIndex = 27
        Me.Passlbl.Text = "Pass"
        '
        'IDlbl
        '
        Me.IDlbl.AutoSize = True
        Me.IDlbl.BackColor = System.Drawing.Color.Transparent
        Me.IDlbl.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.IDlbl.ForeColor = System.Drawing.Color.Black
        Me.IDlbl.Location = New System.Drawing.Point(88, 63)
        Me.IDlbl.Name = "IDlbl"
        Me.IDlbl.Size = New System.Drawing.Size(24, 20)
        Me.IDlbl.TabIndex = 26
        Me.IDlbl.Text = "ID"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(91, 138)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(401, 193)
        Me.Panel3.TabIndex = 29
        Me.Panel3.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(94, 122)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(219, 41)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "L O G I N "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.ComboBox1)
        Me.Panel4.Location = New System.Drawing.Point(31, 40)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(334, 57)
        Me.Panel4.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.5!)
        Me.Label3.Location = New System.Drawing.Point(6, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Connect Database is "
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("メイリオ", 9.5!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(152, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(171, 28)
        Me.ComboBox1.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 342)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 18)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Ver. Unknown"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(389, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 18)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Presented by SSR-Project 2015."
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.UserNM)
        Me.Panel5.Controls.Add(Me.Button3)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Location = New System.Drawing.Point(91, 183)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(401, 148)
        Me.Panel5.TabIndex = 32
        '
        'UserNM
        '
        Me.UserNM.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.UserNM.Location = New System.Drawing.Point(120, 56)
        Me.UserNM.Name = "UserNM"
        Me.UserNM.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.UserNM.Size = New System.Drawing.Size(158, 25)
        Me.UserNM.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.Button3.Location = New System.Drawing.Point(89, 94)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(219, 41)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Select DB"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(82, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "UserName"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Button4.Location = New System.Drawing.Point(500, 281)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(74, 50)
        Me.Button4.TabIndex = 3
        Me.Button4.TabStop = False
        Me.Button4.Text = "Custom Login"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'SDR0000
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 363)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SDR0000"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Passlbl As System.Windows.Forms.Label
    Friend WithEvents IDlbl As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UserNM As System.Windows.Forms.TextBox
End Class
