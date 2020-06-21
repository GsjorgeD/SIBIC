'
' Created by SharpDevelop.
' User: Daniel
' Date: 18/06/2020
' Time: 07:45 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient
Public Partial Class MantenimientoAC
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BtnGuardarClick(sender As Object, e As EventArgs)
		
		Dim sentencia As String ="insert into cliente values("
		
		sentencia = sentencia & Me.txtIDCli.Text & ","					
		
		sentencia = sentencia & "'" & Me.txtNombre.Text & "',"	
		
		sentencia = sentencia & "'" & Me.txtDirccio.Text & "',"		
		
		sentencia = sentencia & "'" & Me.txtCorreo.Text & "',"	
		
		sentencia = sentencia & "'" & Me.txtTel.Text & "',"	
		
		sentencia = sentencia & Me.txtIdPro.Text & ","	
			
		
		
		sentencia = sentencia & Me.txtCantidad.Text & ")"			
		
		Dim conn As New MySqlConnection("server=localhost; user id=root; password=; database=britolin; pooling=false")
		Dim comando As New MySqlCommand(sentencia,conn)
		conn.Open()
		comando.ExecuteNonQuery()
		conn.Close()
		
		MsgBox("Cliente dado de alta")
				
	End Sub
	
	Sub DataGridView1CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
		
	End Sub
	
	Sub MantenimientoACLoad(sender As Object, e As EventArgs)
		Dim inv As New clsinventario
		Me.dgvPro.DataSource=inv.traePartes()
	End Sub
End Class
