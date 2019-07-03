Module SuperBox
    '▼関数定義部分----------------------------------//
    Public SQLid As String
    Public SQLpass As String
    Public instance As String = CreateObject("WScript.Network").ComputerName
    Public catalog As String
    Public strConnectSQL As String '接続文字列
    Public strSQL As String 'SQL文格納
    Public strSQL2 As String
    Public SQLDA As SqlClient.SqlDataAdapter 'SQLアダプタ
    Public SQLDS As New DataSet() 'データセット
    Public x As Integer 'Grid座標格納
    Public y As Integer 'Grid座標格納
    Public Row As DataRow
    Public result As Integer
    Public keycode As Integer
    Public tmp As String
    Public tmp2 As String
    '▲---------------------------------------------//
    'せーぶのやつ
    Public NMBox(5) As String
    Public SQLBox(5) As String
    Public RtbBox(5) As TextBox
    Public LblBox(5) As Label
    Public CallBtn(5) As Button
    'せーぶのやつおしまい--
    Public OutAddress As String
    Public Filter As String
    Public ComboFlg As String
    Public OutTBLNM As String
    'こーるのやつ
    Public BtnStr As String
    Public JointSQL As String
    Public i As Integer
    Public j As Integer
    Public int As Integer
    Public CallF As String
    'こーるおわり

    Public MenuBar As String

    Public Sub OpenSaveWindow(ByVal Filter As String, ByVal OutTBLNM As String)

        'SaveFileDialogクラスのインスタンスを作成
        Dim sfd As New SaveFileDialog()

        'はじめのファイル名を指定する
        sfd.FileName = OutTBLNM
        'はじめに表示されるフォルダを指定する
        sfd.InitialDirectory = "C:\"
        '[ファイルの種類]に表示される選択肢を指定する
        sfd.Filter = Filter
        '[ファイルの種類]ではじめに
        '「すべてのファイル」が選択されているようにする
        sfd.FilterIndex = 1
        'タイトルを設定する
        sfd.Title = "保存先のファイルを選択してください"
        'ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
        sfd.RestoreDirectory = True
        '既に存在するファイル名を指定したとき警告する
        'デフォルトでTrueなので指定する必要はない
        sfd.OverwritePrompt = True
        '存在しないパスが指定されたとき警告を表示する
        'デフォルトでTrueなので指定する必要はない
        sfd.CheckPathExists = True

        'ダイアログを表示する
        If sfd.ShowDialog() = DialogResult.OK Then
            OutAddress = sfd.FileName
        End If

    End Sub

End Module
