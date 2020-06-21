'
' Created by SharpDevelop.
' User: Daniel
' Date: 20/06/2020
' Time: 12:42 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class clsCl
	Public Function traCliente As Data.DataTable
		Dim t As New Data.DataTable
		Dim cadCon As String= "server=localhost; user id=root; passsword=; database=britolin; pooling=false"
		Dim conn As New MySql.Data.MySqlClient.MySqlConnection(cadCon)
		Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM cliente", conn)
		conn.Open
		da.Fill(t)
		conn.Close
		Return t
	End Function
End Class
