'
' Created by SharpDevelop.
' User: Daniel
' Date: 17/06/2020
' Time: 01:19 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Class clsinventario
	 
	Public Function traePartes As Data.DataTable
		Dim t As New Data.DataTable
		Dim cadcon As String="server=localhost; user id=root; password=; database=britolin;  pooling=false"
		Dim conn As New MySql.Data.MySqlClient.MySqlConnection(cadcon)
		Dim da As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM producto",conn)
		conn.Open
		da.Fill(t)
		conn.Close
		Return t
	End Function
End Class
