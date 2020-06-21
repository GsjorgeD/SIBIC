'
' Created by SharpDevelop.
' User: Daniel
' Date: 18/06/2020
' Time: 08:50 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MoviientoCl
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	
		Private Function Buscar As data.DataTable
		Dim t As New Data.DataTable
		Dim sql As String="SELECT * FROM cliente where IDCliente= "& Me.txtIDCl.Text & "" 
		
		Dim cadcon As String="server=localhost; user id=root; password=; database=britolin; pooling=false"
		
		Dim conn As New MySql.Data.MySqlClient.MySqlConnection(cadcon)
		Dim comando As New MySql.Data.MySqlClient.MySqlDataAdapter(sql,conn)
		conn.Open()
		comando.fill(t)
		conn.Close()
		Return t
		End function
		
	
	
	
	
	Sub BtnBuscarClick(sender As Object, e As EventArgs)
	Dim t As Data.DataTable
		t=Me.Buscar()
		If t.Rows.Count=0 Then
			MsgBox("No existe")
		Else
			Me.txtNombre.Text=t.Rows(0).Item("Nombre").ToString
			Me.TxtDireccion.Text=t.Rows(0).Item("Direccion").ToString
			Me.txtCorreo.Text=t.Rows(0).Item("Correo").ToString
			Me.txtTel.Text=t.Rows(0).Item("Telefono").ToString
			Me.txtProducto.Text=t.Rows(0).Item("IDPro").ToString
			Me.txtCantidad.Text=t.Rows(0).Item("CantidadP").ToString
			Me.txtIDCl.Enabled=False
			Me.pnl1.Visible=True
		End If		
	End Sub
	
	Private Sub Actualizar
		     Dim t As New Data.DataTable
		Dim sql As String="update cliente set Nombre='" & Me.txtNombre.Text & "'," & _ 
			"Direccion='"& Me.txtDireccion.Text & "'," & _ 
			"Correo='" & Me.txtCorreo.Text & "'," & _ 
			"Telefono='" & Me.txtTel.Text &"'," & _ 
			"IDPro='" & Me.txtProducto.Text & "'," & _ 
			"CantidadP='" & Me.txtCantidad.Text & "'" & _ 
			"where IDCliente='" & Me.txtIDCl.Text & "'"
		Dim cadcon As String="server=localhost; user id=root; password=; database=britolin; pooling=false"
		Dim conn As New MySql.Data.MySqlClient.MySqlConnection(cadcon)
		Dim comando As New MySql.Data.MySqlClient.MySqlCommand(sql,conn)
		conn.Open()
		comando.executeNonQuery
		conn.Close()
	End Sub
	
	Sub BtnModificarClick(sender As Object, e As EventArgs)
		Actualizar()
		MsgBox("Cliente modificado")
		Me.pnl1.Visible=False
		Me.txtIDCl.Enabled=True
		Me.txtIDCl.Text=""
	End Sub
End Class
