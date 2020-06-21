'
' Created by SharpDevelop.
' User: Daniel
' Date: 18/06/2020
' Time: 09:24 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient
Public Partial Class MovimientoProDelete
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnEliminarClick(sender As Object, e As EventArgs)
        Dim sentencia As String ="delete from producto where IDProducto=("
		
		sentencia = sentencia & Me.txtProducto.Text & ")"	
		
		Dim conn As New MySqlConnection("server=localhost; user id=root; password=; database=britolin; pooling=false")
		Dim comando As New MySqlCommand(sentencia,conn)
		conn.Open()
		comando.ExecuteNonQuery()
		conn.Close()
		
		Me.txtProducto.Text= ""
		
		MsgBox("ELIMINADO")
			
	End Sub
End Class
