Imports Microsoft.VisualBasic.ControlChars

Public Class SDR0000

#Region "ini取得"
    Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" ( _
          ByVal lpApplicationName As String, _
          ByVal lpKeyName As String, _
          ByVal lpDefault As String, _
          ByVal lpReturnedString As String, _
          ByVal nSize As Integer, _
          ByVal lpFileName As String) As Integer
    Dim filepath As String

    Private Sub iniget(ByVal section1 As String, ByVal section2 As String, ByRef value As String)

        value = ""
        Const DEF_STR As String = vbNullString
        Dim buffer As String = New String(" ", 1024) 'Spaceが1024文字
        Dim AppPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim iniFileName As String = "C:\SQLReseacher" & "\SR.ini" 'INIファイル名
        Dim ret1 As Integer = GetPrivateProfileString(section1, section2, DEF_STR, buffer, buffer.Length, iniFileName)
        value = buffer.Substring(0, buffer.IndexOf(vbNullChar))

    End Sub

#End Region

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RichTextBox1.Text = instance

        '■INIファイルからMDB情報取得-------------------------------------

        Dim value As String = ""

        Call iniget("SQLReseacher", "System_MDB", value)
        filepath = value

        Call iniget("UserSetting", "Default_Form", value)
        Dim LoginCus As String = "0"
        LoginCus = value

        Call iniget("System", "Version", value)
        Label2.Text = "Ver " & value

        Call iniget("UserSetting", "Menu_Bar", value)
        MenuBar = value

        '■---------------------------------------------------------------

        If LoginCus = "0" Then
            Panel2.Visible = True
            Panel5.Visible = False
        Else
            Panel2.Visible = False
            Panel5.Visible = True
        End If

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        On Error GoTo SQLERR

        '■IDパスワード入力確認-------------------------------------

        If Text1.Text = "" And Text2.Text = "" Then
            MsgBox("Error: ID、パスワードが入力されていません。")
            Exit Sub
        End If

        SQLid = Text1.Text
        SQLpass = Text2.Text

        '▼SQL取得文字列設定部分 -----------------------//

        strConnectSQL = "Server=" & RichTextBox1.Text & ";"
        strConnectSQL = strConnectSQL & "Initial Catalog=master;"
        strConnectSQL = strConnectSQL & "User ID=" & SQLid & ";"
        strConnectSQL = strConnectSQL & "Password=" & SQLpass & ";"
        strConnectSQL = strConnectSQL & "Integrated Security=false"

        '▲--------------------------------------------//

        '■---------------------------------------------------------


        '■Datacombo1表示設定---------------------------------------


        '▼ログイン成功時：挙動設定----------------------

        strSQL = "select name from sysdatabases"

        '▼SQLServer接続部分-----------------------//

        SQLDS = Nothing
        SQLDS = New DataSet

        'SQL接続を開き、データ取得
        SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST")
        '▲----------------------------------------//

        ComboFlg = "0"
        ComboBox1.DataSource = SQLDS.Tables("TEST")
        SSR1000.ComboBox1.DataSource = SQLDS.Tables("TEST")
        ComboBox1.DisplayMember = "Name"
        SSR1000.ComboBox1.DisplayMember = "Name"

        SQLDS = Nothing
        SQLDS = New DataSet

        '▲----------------------------------------------

        '■---------------------------------------------------------

        Panel2.Visible = False
        Panel3.Visible = True

SQLERR:
        Exit Sub
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        '▼SQL取得文字列設定部分 -----------------------//

        strConnectSQL = "Server=" & RichTextBox1.Text & ";"
        strConnectSQL = strConnectSQL & "Initial Catalog=" & ComboBox1.Text & ";"
        strConnectSQL = strConnectSQL & "User ID=" & SQLid & ";"
        strConnectSQL = strConnectSQL & "Password=" & SQLpass & ";"
        strConnectSQL = strConnectSQL & "Integrated Security=false"

        '▲--------------------------------------------//

        ComboFlg = "0"
        SSR1000.ComboBox1.Text = ComboBox1.Text
        SuperBox.strConnectSQL = strConnectSQL
        SSR1000.Show()
        Me.Hide()

    End Sub

    Private Sub Iniget(sender As Object, e As EventArgs) Handles Button3.Click
        On Error GoTo SQLERR

        'ユーザー名等取得===============================================================================================

        Dim cn As New System.Data.OleDb.OleDbConnection
        Dim command As System.Data.OleDb.OleDbCommand
        Dim reader As System.Data.OleDb.OleDbDataReader

        cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
        "Data Source=" & Quote & filepath & Quote & ";"

        command = cn.CreateCommand
        command.CommandText = "SELECT * FROM UserInfo where UserNM = " & "'" & UserNM.Text & "'"
        cn.Open()

        reader = command.ExecuteReader()
        If reader.Read = True Then
            Dim User As String = reader("UserNM")
            SQLid = reader("SQLid")
            SQLpass = reader("SQLpass")
            instance = reader("instance")
            catalog = reader("catalog")
        Else
            MsgBox("入力されたユーザーは存在しません。", MsgBoxStyle.Critical)
        End If

        cn.Close()
        command.Dispose()
        cn.Dispose()

        'ユーザー名等取得===============================================================================================

        '▼SQL取得文字列設定部分 -----------------------//

        strConnectSQL = "Server=" & instance & ";"
        strConnectSQL = strConnectSQL & "Initial Catalog=master;"
        strConnectSQL = strConnectSQL & "User ID=" & SQLid & ";"
        strConnectSQL = strConnectSQL & "Password=" & SQLpass & ";"
        strConnectSQL = strConnectSQL & "Integrated Security=false"

        '▲--------------------------------------------//

        '■---------------------------------------------------------


        '■Datacombo1表示設定---------------------------------------


        '▼ログイン成功時：挙動設定----------------------

        strSQL = "select name from sysdatabases"

        '▼SQLServer接続部分-----------------------//

        SQLDS = Nothing
        SQLDS = New DataSet

        'SQL接続を開き、データ取得
        SQLDA = New SqlClient.SqlDataAdapter(strSQL, strConnectSQL)

        '取得したデータをデータセットに格納
        SQLDA.Fill(SQLDS, "TEST")
        '▲----------------------------------------//

        ComboFlg = "0"
        ComboBox1.DataSource = SQLDS.Tables("TEST")
        SSR1000.ComboBox1.DataSource = SQLDS.Tables("TEST")
        ComboBox1.DisplayMember = "Name"
        SSR1000.ComboBox1.DisplayMember = "Name"

        SQLDS = Nothing
        SQLDS = New DataSet

        '▲----------------------------------------------

        '■---------------------------------------------------------

        '▼SQL取得文字列設定部分 -----------------------//

        strConnectSQL = "Server=" & instance & ";"
        strConnectSQL = strConnectSQL & "Initial Catalog=" & catalog & ";"
        strConnectSQL = strConnectSQL & "User ID=" & SQLid & ";"
        strConnectSQL = strConnectSQL & "Password=" & SQLpass & ";"
        strConnectSQL = strConnectSQL & "Integrated Security=false"

        Debug.Print(strConnectSQL)

        '▲--------------------------------------------//

        Me.Hide()
        ComboFlg = "0"
        SSR1000.ComboBox1.Text = catalog
        SuperBox.strConnectSQL = strConnectSQL
        SSR1000.Show()

SQLERR:
        Exit Sub
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Panel2.Visible = False Then
            Panel2.Visible = True
            Panel5.Visible = False
        Else
            Panel2.Visible = False
            Panel5.Visible = True
        End If
    End Sub

End Class