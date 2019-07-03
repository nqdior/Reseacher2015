<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSR1100
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
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpenBtn = New System.Windows.Forms.Button()
        Me.TblName = New System.Windows.Forms.RichTextBox()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.AllowUserToAddRows = False
        Me.DGV1.AllowUserToDeleteRows = False
        Me.DGV1.AllowUserToResizeColumns = False
        Me.DGV1.AllowUserToResizeRows = False
        Me.DGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DGV1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DGV1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.DGV1.Location = New System.Drawing.Point(2, 55)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DGV1.RowTemplate.Height = 21
        Me.DGV1.Size = New System.Drawing.Size(368, 308)
        Me.DGV1.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.Frozen = True
        Me.Column1.HeaderText = "TableList"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.Frozen = True
        Me.Column2.HeaderText = "RowCount"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 82
        '
        'OpenBtn
        '
        Me.OpenBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.OpenBtn.Location = New System.Drawing.Point(300, 2)
        Me.OpenBtn.Name = "OpenBtn"
        Me.OpenBtn.Size = New System.Drawing.Size(70, 50)
        Me.OpenBtn.TabIndex = 1
        Me.OpenBtn.Text = "Table    Open"
        Me.OpenBtn.UseVisualStyleBackColor = True
        '
        'TblName
        '
        Me.TblName.Location = New System.Drawing.Point(146, 28)
        Me.TblName.Name = "TblName"
        Me.TblName.Size = New System.Drawing.Size(145, 24)
        Me.TblName.TabIndex = 0
        Me.TblName.Text = ""
        '
        'TableList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 363)
        Me.Controls.Add(Me.TblName)
        Me.Controls.Add(Me.OpenBtn)
        Me.Controls.Add(Me.DGV1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TableList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuWindow"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpenBtn As System.Windows.Forms.Button
    Friend WithEvents TblName As System.Windows.Forms.RichTextBox
End Class
