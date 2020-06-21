'
' Created by SharpDevelop.
' User: Daniel
' Date: 18/06/2020
' Time: 09:19 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MovimientoProUpdate
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Private Function Buscar As data.DataTable
		Dim t As New Data.DataTable
		Dim sql As String="SELECT * FROM producto where IDProducto= "& Me.txtIDPro.Text & "" 
		
		Dim cadcon As String="server=localhost; user id=root; password=; database=britolin; pooling=false"
		
		Dim conn As New MySql.Data.MySqlClient.MySqlConnection(cadcon)
		Dim comando As New MySql.Data.MySqlClient.MySqlDataAdapter(sql,conn)
		conn.Open()
		comando.fill(t)
		conn.Close()
		Return t
		
	End Function
	
	
	Sub MovimientoProUpdateLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub BtnModificarClick(sender As Object, e As EventArgs)
		Actualizar()
		MsgBox("Producto modificado")
		Me.pnl1.Visible=False
		Me.txtIDPro.Enabled=True
		Me.txtIDPro.Text=""
	End Sub
	
	Sub BtnBuscarClick(sender As Object, e As EventArgs)
	 Dim t As Data.DataTable
		t=Me.Buscar()
		If t.Rows.Count=0 Then
			MsgBox("No existe")
		Else
			Me.txtPro.Text=t.Rows(0).Item("Producto").ToString
			Me.txtPrecio.Text=t.Rows(0).Item("Precio").ToString
			Me.txtIDPro.Enabled=False
			Me.pnl1.Visible=True
		End If					
	End Sub
	Private Sub Actualizar
		 
		 
		Dim t As New Data.DataTable
		Dim sql As String="update producto set Producto='" & Me.txtPro.Text & "'," & _ 
			"Precio='" & Me.txtPrecio.Text & "'" & _ 
			"where IDProducto='" & Me.txtIDPro.Text & "'"
		Dim cadcon As String="server=localhost; user id=root; password=; database=britolin; pooling=false"
		Dim conn As New MySql.Data.MySqlClient.MySqlConnection(cadcon)
		Dim comando As New MySql.Data.MySqlClient.MySqlCommand(sql,conn)
		conn.Open()
		comando.executeNonQuery
		conn.Close()
		
	
	End Sub
End Class
