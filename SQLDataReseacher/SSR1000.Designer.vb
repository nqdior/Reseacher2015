<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SSR1000
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
        Me.components = New System.ComponentModel.Container()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.CtlPanel = New System.Windows.Forms.Panel()
        Me.ExePanel = New System.Windows.Forms.Panel()
        Me.RSBtn = New System.Windows.Forms.Button()
        Me.DelBtn = New System.Windows.Forms.Button()
        Me.CleBtn = New System.Windows.Forms.Button()
        Me.ModeBtn = New System.Windows.Forms.Button()
        Me.SelBtn = New System.Windows.Forms.Button()
        Me.InsBtn = New System.Windows.Forms.Button()
        Me.SQLcmd = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.InsertRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteRow = New System.Windows.Forms.ToolStripMenuItem()
        Me.Cancel = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RecCnt = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ファイルFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.クエリファイルを開くToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.テーブルセットを開くToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.テーブルを開くTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.サブテーブルを開くToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.終了ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.終了ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.編集ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.切り取りToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.コピーToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.貼り付けToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.全て選択ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.更新ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.拡大ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.縮小ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.全画面表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.最小化ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.SQL入力画面非表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.メニューバー非表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SQLテキスト非表示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ツールToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.横結合ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.検索ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.集計ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ソートToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.設定ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ヘルプHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SizeDown = New System.Windows.Forms.Button()
        Me.SizeUp = New System.Windows.Forms.Button()
        Me.MenuBtn = New System.Windows.Forms.Button()
        Me.SortBtn = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SubBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.STBLBtn = New System.Windows.Forms.Button()
        Me.UDBtn = New System.Windows.Forms.Button()
        Me.OutBtn = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CtlPanel.SuspendLayout()
        Me.ExePanel.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(2, 78)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowTemplate.Height = 21
        Me.DGV1.Size = New System.Drawing.Size(782, 370)
        Me.DGV1.TabIndex = 9
        '
        'CtlPanel
        '
        Me.CtlPanel.Controls.Add(Me.ExePanel)
        Me.CtlPanel.Controls.Add(Me.SQLcmd)
        Me.CtlPanel.Location = New System.Drawing.Point(1, 452)
        Me.CtlPanel.Name = "CtlPanel"
        Me.CtlPanel.Size = New System.Drawing.Size(782, 80)
        Me.CtlPanel.TabIndex = 15
        '
        'ExePanel
        '
        Me.ExePanel.Controls.Add(Me.RSBtn)
        Me.ExePanel.Controls.Add(Me.DelBtn)
        Me.ExePanel.Controls.Add(Me.CleBtn)
        Me.ExePanel.Controls.Add(Me.ModeBtn)
        Me.ExePanel.Controls.Add(Me.SelBtn)
        Me.ExePanel.Controls.Add(Me.InsBtn)
        Me.ExePanel.Location = New System.Drawing.Point(647, 0)
        Me.ExePanel.Name = "ExePanel"
        Me.ExePanel.Size = New System.Drawing.Size(132, 81)
        Me.ExePanel.TabIndex = 16
        '
        'RSBtn
        '
        Me.RSBtn.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.RSBtn.Location = New System.Drawing.Point(4, 29)
        Me.RSBtn.Name = "RSBtn"
        Me.RSBtn.Size = New System.Drawing.Size(125, 50)
        Me.RSBtn.TabIndex = 7
        Me.RSBtn.Text = "Reseach (F5)"
        Me.RSBtn.UseVisualStyleBackColor = True
        '
        'DelBtn
        '
        Me.DelBtn.Font = New System.Drawing.Font("メイリオ", 9.5!)
        Me.DelBtn.Location = New System.Drawing.Point(4, 85)
        Me.DelBtn.Name = "DelBtn"
        Me.DelBtn.Size = New System.Drawing.Size(125, 34)
        Me.DelBtn.TabIndex = 18
        Me.DelBtn.Text = "Delete (F7)"
        Me.DelBtn.UseVisualStyleBackColor = True
        '
        'CleBtn
        '
        Me.CleBtn.Font = New System.Drawing.Font("メイリオ", 9.5!)
        Me.CleBtn.Location = New System.Drawing.Point(4, 182)
        Me.CleBtn.Name = "CleBtn"
        Me.CleBtn.Size = New System.Drawing.Size(125, 34)
        Me.CleBtn.TabIndex = 17
        Me.CleBtn.Text = "Clear (F9)"
        Me.CleBtn.UseVisualStyleBackColor = True
        '
        'ModeBtn
        '
        Me.ModeBtn.Font = New System.Drawing.Font("メイリオ", 9.5!)
        Me.ModeBtn.Location = New System.Drawing.Point(4, 2)
        Me.ModeBtn.Name = "ModeBtn"
        Me.ModeBtn.Size = New System.Drawing.Size(125, 27)
        Me.ModeBtn.TabIndex = 6
        Me.ModeBtn.Text = "▲ EditMode"
        Me.ModeBtn.UseVisualStyleBackColor = True
        '
        'SelBtn
        '
        Me.SelBtn.Font = New System.Drawing.Font("メイリオ", 9.5!)
        Me.SelBtn.Location = New System.Drawing.Point(4, 133)
        Me.SelBtn.Name = "SelBtn"
        Me.SelBtn.Size = New System.Drawing.Size(125, 34)
        Me.SelBtn.TabIndex = 8
        Me.SelBtn.Text = "Select (F8)"
        Me.SelBtn.UseVisualStyleBackColor = True
        '
        'InsBtn
        '
        Me.InsBtn.Font = New System.Drawing.Font("メイリオ", 9.5!)
        Me.InsBtn.Location = New System.Drawing.Point(4, 39)
        Me.InsBtn.Name = "InsBtn"
        Me.InsBtn.Size = New System.Drawing.Size(125, 34)
        Me.InsBtn.TabIndex = 20
        Me.InsBtn.Text = "Insert (F6)"
        Me.InsBtn.UseVisualStyleBackColor = True
        '
        'SQLcmd
        '
        Me.SQLcmd.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SQLcmd.Location = New System.Drawing.Point(3, 3)
        Me.SQLcmd.Name = "SQLcmd"
        Me.SQLcmd.Size = New System.Drawing.Size(643, 75)
        Me.SQLcmd.TabIndex = 6
        Me.SQLcmd.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InsertRow, Me.DeleteRow, Me.Cancel})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 70)
        '
        'InsertRow
        '
        Me.InsertRow.Name = "InsertRow"
        Me.InsertRow.Size = New System.Drawing.Size(160, 22)
        Me.InsertRow.Text = "レコードの挿入"
        '
        'DeleteRow
        '
        Me.DeleteRow.Name = "DeleteRow"
        Me.DeleteRow.Size = New System.Drawing.Size(160, 22)
        Me.DeleteRow.Text = "レコードの削除"
        '
        'Cancel
        '
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(160, 22)
        Me.Cancel.Text = "キャンセル"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RecCnt)
        Me.Panel1.Location = New System.Drawing.Point(-1, 537)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(785, 26)
        Me.Panel1.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(591, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Presented by SSR-Project 2015"
        '
        'RecCnt
        '
        Me.RecCnt.AutoSize = True
        Me.RecCnt.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.RecCnt.Location = New System.Drawing.Point(3, 2)
        Me.RecCnt.Name = "RecCnt"
        Me.RecCnt.Size = New System.Drawing.Size(66, 18)
        Me.RecCnt.TabIndex = 0
        Me.RecCnt.Text = "Non Table"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ファイルFToolStripMenuItem, Me.編集ToolStripMenuItem, Me.表示ToolStripMenuItem, Me.ツールToolStripMenuItem, Me.設定ToolStripMenuItem, Me.ヘルプHToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 26)
        Me.MenuStrip1.TabIndex = 39
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ファイルFToolStripMenuItem
        '
        Me.ファイルFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.クエリファイルを開くToolStripMenuItem, Me.テーブルセットを開くToolStripMenuItem, Me.ToolStripMenuItem1, Me.テーブルを開くTToolStripMenuItem, Me.サブテーブルを開くToolStripMenuItem, Me.終了ToolStripMenuItem, Me.ToolStripMenuItem8, Me.終了ToolStripMenuItem1})
        Me.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem"
        Me.ファイルFToolStripMenuItem.Size = New System.Drawing.Size(85, 22)
        Me.ファイルFToolStripMenuItem.Text = "ファイル(&F)"
        '
        'クエリファイルを開くToolStripMenuItem
        '
        Me.クエリファイルを開くToolStripMenuItem.Name = "クエリファイルを開くToolStripMenuItem"
        Me.クエリファイルを開くToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.クエリファイルを開くToolStripMenuItem.Text = "ファイルを開く(&O)"
        '
        'テーブルセットを開くToolStripMenuItem
        '
        Me.テーブルセットを開くToolStripMenuItem.Name = "テーブルセットを開くToolStripMenuItem"
        Me.テーブルセットを開くToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.テーブルセットを開くToolStripMenuItem.Text = "テーブルセットを開く"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 6)
        '
        'テーブルを開くTToolStripMenuItem
        '
        Me.テーブルを開くTToolStripMenuItem.Name = "テーブルを開くTToolStripMenuItem"
        Me.テーブルを開くTToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.テーブルを開くTToolStripMenuItem.Text = "テーブルを開く"
        '
        'サブテーブルを開くToolStripMenuItem
        '
        Me.サブテーブルを開くToolStripMenuItem.Name = "サブテーブルを開くToolStripMenuItem"
        Me.サブテーブルを開くToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.サブテーブルを開くToolStripMenuItem.Text = "サブテーブルを開く"
        '
        '終了ToolStripMenuItem
        '
        Me.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem"
        Me.終了ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.終了ToolStripMenuItem.Text = "テーブル出力"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(193, 6)
        '
        '終了ToolStripMenuItem1
        '
        Me.終了ToolStripMenuItem1.Name = "終了ToolStripMenuItem1"
        Me.終了ToolStripMenuItem1.Size = New System.Drawing.Size(196, 22)
        Me.終了ToolStripMenuItem1.Text = "終了"
        '
        '編集ToolStripMenuItem
        '
        Me.編集ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.切り取りToolStripMenuItem, Me.コピーToolStripMenuItem, Me.貼り付けToolStripMenuItem, Me.ToolStripMenuItem3, Me.全て選択ToolStripMenuItem})
        Me.編集ToolStripMenuItem.Name = "編集ToolStripMenuItem"
        Me.編集ToolStripMenuItem.Size = New System.Drawing.Size(61, 22)
        Me.編集ToolStripMenuItem.Text = "編集(&E)"
        '
        '切り取りToolStripMenuItem
        '
        Me.切り取りToolStripMenuItem.Name = "切り取りToolStripMenuItem"
        Me.切り取りToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.切り取りToolStripMenuItem.Text = "切り取り"
        '
        'コピーToolStripMenuItem
        '
        Me.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem"
        Me.コピーToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.コピーToolStripMenuItem.Text = "コピー"
        '
        '貼り付けToolStripMenuItem
        '
        Me.貼り付けToolStripMenuItem.Name = "貼り付けToolStripMenuItem"
        Me.貼り付けToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.貼り付けToolStripMenuItem.Text = "貼り付け"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(121, 6)
        '
        '全て選択ToolStripMenuItem
        '
        Me.全て選択ToolStripMenuItem.Name = "全て選択ToolStripMenuItem"
        Me.全て選択ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.全て選択ToolStripMenuItem.Text = "全て選択"
        '
        '表示ToolStripMenuItem
        '
        Me.表示ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.更新ToolStripMenuItem, Me.ToolStripMenuItem5, Me.拡大ToolStripMenuItem, Me.縮小ToolStripMenuItem, Me.全画面表示ToolStripMenuItem, Me.最小化ToolStripMenuItem, Me.ToolStripMenuItem6, Me.SQL入力画面非表示ToolStripMenuItem, Me.メニューバー非表示ToolStripMenuItem, Me.SQLテキスト非表示ToolStripMenuItem})
        Me.表示ToolStripMenuItem.Name = "表示ToolStripMenuItem"
        Me.表示ToolStripMenuItem.Size = New System.Drawing.Size(62, 22)
        Me.表示ToolStripMenuItem.Text = "表示(&V)"
        '
        '更新ToolStripMenuItem
        '
        Me.更新ToolStripMenuItem.Name = "更新ToolStripMenuItem"
        Me.更新ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.更新ToolStripMenuItem.Text = "更新"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(193, 6)
        '
        '拡大ToolStripMenuItem
        '
        Me.拡大ToolStripMenuItem.Name = "拡大ToolStripMenuItem"
        Me.拡大ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.拡大ToolStripMenuItem.Text = "拡大"
        '
        '縮小ToolStripMenuItem
        '
        Me.縮小ToolStripMenuItem.Name = "縮小ToolStripMenuItem"
        Me.縮小ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.縮小ToolStripMenuItem.Text = "縮小"
        '
        '全画面表示ToolStripMenuItem
        '
        Me.全画面表示ToolStripMenuItem.Name = "全画面表示ToolStripMenuItem"
        Me.全画面表示ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.全画面表示ToolStripMenuItem.Text = "全画面表示"
        '
        '最小化ToolStripMenuItem
        '
        Me.最小化ToolStripMenuItem.Name = "最小化ToolStripMenuItem"
        Me.最小化ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.最小化ToolStripMenuItem.Text = "最小化"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(193, 6)
        '
        'SQL入力画面非表示ToolStripMenuItem
        '
        Me.SQL入力画面非表示ToolStripMenuItem.Name = "SQL入力画面非表示ToolStripMenuItem"
        Me.SQL入力画面非表示ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SQL入力画面非表示ToolStripMenuItem.Text = "メニューバー非表示"
        '
        'メニューバー非表示ToolStripMenuItem
        '
        Me.メニューバー非表示ToolStripMenuItem.Name = "メニューバー非表示ToolStripMenuItem"
        Me.メニューバー非表示ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.メニューバー非表示ToolStripMenuItem.Text = "メニューボタン非表示"
        '
        'SQLテキスト非表示ToolStripMenuItem
        '
        Me.SQLテキスト非表示ToolStripMenuItem.Name = "SQLテキスト非表示ToolStripMenuItem"
        Me.SQLテキスト非表示ToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SQLテキスト非表示ToolStripMenuItem.Text = "SQLテキスト非表示"
        '
        'ツールToolStripMenuItem
        '
        Me.ツールToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.横結合ToolStripMenuItem, Me.検索ToolStripMenuItem, Me.集計ToolStripMenuItem, Me.ソートToolStripMenuItem})
        Me.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem"
        Me.ツールToolStripMenuItem.Size = New System.Drawing.Size(74, 22)
        Me.ツールToolStripMenuItem.Text = "ツール(&T)"
        '
        '横結合ToolStripMenuItem
        '
        Me.横結合ToolStripMenuItem.Name = "横結合ToolStripMenuItem"
        Me.横結合ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.横結合ToolStripMenuItem.Text = "横結合"
        '
        '検索ToolStripMenuItem
        '
        Me.検索ToolStripMenuItem.Name = "検索ToolStripMenuItem"
        Me.検索ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.検索ToolStripMenuItem.Text = "検索"
        '
        '集計ToolStripMenuItem
        '
        Me.集計ToolStripMenuItem.Name = "集計ToolStripMenuItem"
        Me.集計ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.集計ToolStripMenuItem.Text = "集計"
        '
        'ソートToolStripMenuItem
        '
        Me.ソートToolStripMenuItem.Name = "ソートToolStripMenuItem"
        Me.ソートToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.ソートToolStripMenuItem.Text = "ソート"
        '
        '設定ToolStripMenuItem
        '
        Me.設定ToolStripMenuItem.Name = "設定ToolStripMenuItem"
        Me.設定ToolStripMenuItem.Size = New System.Drawing.Size(59, 22)
        Me.設定ToolStripMenuItem.Text = "設定(&I)"
        '
        'ヘルプHToolStripMenuItem
        '
        Me.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem"
        Me.ヘルプHToolStripMenuItem.Size = New System.Drawing.Size(82, 22)
        Me.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H）"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.SizeDown)
        Me.Panel2.Controls.Add(Me.SizeUp)
        Me.Panel2.Controls.Add(Me.MenuBtn)
        Me.Panel2.Controls.Add(Me.SortBtn)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.SubBtn)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.STBLBtn)
        Me.Panel2.Controls.Add(Me.UDBtn)
        Me.Panel2.Controls.Add(Me.OutBtn)
        Me.Panel2.Location = New System.Drawing.Point(2, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(782, 51)
        Me.Panel2.TabIndex = 40
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(3, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "DB Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(116, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Table Name"
        '
        'SizeDown
        '
        Me.SizeDown.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SizeDown.Location = New System.Drawing.Point(297, 27)
        Me.SizeDown.Name = "SizeDown"
        Me.SizeDown.Size = New System.Drawing.Size(49, 22)
        Me.SizeDown.TabIndex = 49
        Me.SizeDown.Text = "▼A"
        Me.SizeDown.UseVisualStyleBackColor = True
        '
        'SizeUp
        '
        Me.SizeUp.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SizeUp.Location = New System.Drawing.Point(297, 2)
        Me.SizeUp.Name = "SizeUp"
        Me.SizeUp.Size = New System.Drawing.Size(49, 23)
        Me.SizeUp.TabIndex = 48
        Me.SizeUp.Text = "▲A"
        Me.SizeUp.UseVisualStyleBackColor = True
        '
        'MenuBtn
        '
        Me.MenuBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.MenuBtn.Location = New System.Drawing.Point(492, 1)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(70, 48)
        Me.MenuBtn.TabIndex = 42
        Me.MenuBtn.Text = "SQL"
        Me.MenuBtn.UseVisualStyleBackColor = True
        '
        'SortBtn
        '
        Me.SortBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SortBtn.Location = New System.Drawing.Point(564, 1)
        Me.SortBtn.Name = "SortBtn"
        Me.SortBtn.Size = New System.Drawing.Size(70, 48)
        Me.SortBtn.TabIndex = 43
        Me.SortBtn.Text = "Sort"
        Me.SortBtn.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("メイリオ", 10.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(4, 20)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(109, 28)
        Me.ComboBox1.TabIndex = 47
        '
        'SubBtn
        '
        Me.SubBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.SubBtn.Location = New System.Drawing.Point(420, 1)
        Me.SubBtn.Name = "SubBtn"
        Me.SubBtn.Size = New System.Drawing.Size(70, 48)
        Me.SubBtn.TabIndex = 40
        Me.SubBtn.Text = "Sub     Table"
        Me.SubBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("メイリオ", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(117, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(173, 26)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "名称未設定"
        '
        'STBLBtn
        '
        Me.STBLBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.STBLBtn.Location = New System.Drawing.Point(348, 1)
        Me.STBLBtn.Name = "STBLBtn"
        Me.STBLBtn.Size = New System.Drawing.Size(70, 48)
        Me.STBLBtn.TabIndex = 39
        Me.STBLBtn.Text = "Open     Table"
        Me.STBLBtn.UseVisualStyleBackColor = True
        '
        'UDBtn
        '
        Me.UDBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.UDBtn.Location = New System.Drawing.Point(636, 1)
        Me.UDBtn.Name = "UDBtn"
        Me.UDBtn.Size = New System.Drawing.Size(70, 48)
        Me.UDBtn.TabIndex = 44
        Me.UDBtn.Text = "Update"
        Me.UDBtn.UseVisualStyleBackColor = True
        '
        'OutBtn
        '
        Me.OutBtn.Font = New System.Drawing.Font("メイリオ", 9.0!)
        Me.OutBtn.Location = New System.Drawing.Point(708, 1)
        Me.OutBtn.Name = "OutBtn"
        Me.OutBtn.Size = New System.Drawing.Size(70, 48)
        Me.OutBtn.TabIndex = 45
        Me.OutBtn.Text = "Output"
        Me.OutBtn.UseVisualStyleBackColor = True
        '
        'DataEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CtlPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.DGV1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "DataEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SQL Reseacher"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CtlPanel.ResumeLayout(False)
        Me.ExePanel.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents CtlPanel As System.Windows.Forms.Panel
    Friend WithEvents SQLcmd As System.Windows.Forms.RichTextBox
    Friend WithEvents ExePanel As System.Windows.Forms.Panel
    Friend WithEvents ModeBtn As System.Windows.Forms.Button
    Friend WithEvents SelBtn As System.Windows.Forms.Button
    Friend WithEvents RSBtn As System.Windows.Forms.Button
    Friend WithEvents CleBtn As System.Windows.Forms.Button
    Friend WithEvents DelBtn As System.Windows.Forms.Button
    Friend WithEvents InsBtn As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents InsertRow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteRow As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Cancel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RecCnt As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ファイルFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents クエリファイルを開くToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents テーブルセットを開くToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents テーブルを開くTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents サブテーブルを開くToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 終了ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 編集ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 切り取りToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents コピーToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 貼り付けToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 全て選択ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 表示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 更新ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 拡大ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 縮小ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 全画面表示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 最小化ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SQL入力画面非表示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents メニューバー非表示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 終了ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SQLテキスト非表示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ツールToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 横結合ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 検索ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 集計ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ソートToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 設定ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ヘルプHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SizeDown As System.Windows.Forms.Button
    Friend WithEvents SizeUp As System.Windows.Forms.Button
    Friend WithEvents MenuBtn As System.Windows.Forms.Button
    Friend WithEvents SortBtn As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents SubBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents STBLBtn As System.Windows.Forms.Button
    Friend WithEvents UDBtn As System.Windows.Forms.Button
    Friend WithEvents OutBtn As System.Windows.Forms.Button

End Class
