Imports MySql.Data.MySqlClient

Module ModuleDB
    Public pengguna As String = "nadine"
    Public password As String = "nadine"
    Public myStrCon As MySqlConnectionStringBuilder = New MySqlConnectionStringBuilder()
    Public myConn As MySqlConnection
    Public myCommand As MySqlCommand
    Public myDataReader As MySqlDataReader
    Public myDataAdapter As MySqlDataAdapter
    Public jns As String = String.Empty
    Public tbluser As String = "users" 'nama tabel user
    Public tbllangganan As String = "tbllangganan"
    Public bts As Integer = 5
    Public Sub CreateConnection()
        myStrCon.UserID = "root"
        myStrCon.Server = "127.0.0.1"
        myStrCon.Port = "3307"
        myStrCon.Password = ""
        myStrCon.Database = "progdesk" 'sesuaikan nama databasenya
        myConn = New MySqlConnection(myStrCon.ToString)
    End Sub

End Module
