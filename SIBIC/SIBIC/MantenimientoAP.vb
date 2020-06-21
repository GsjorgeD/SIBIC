'
' Created by SharpDevelop.
' User: Daniel
' Date: 15/06/2020
' Time: 02:10 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient
Public Partial Class Mantenimiento
Public p As New clsProducto	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Me.CenterToScreen()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	
	
	
	Sub MantenimientoLoad(sender As Object, e As EventArgs)
		Me.cmbElegir.DataSource=Me.creartabla
		Me.cmbElegir.ValueMember="id"
		Me.cmbElegir.DisplayMember="descripcion"
		Me.cmbElegir.SelectedIndex=0
	End Sub
	
	Function verificar As Boolean
		Dim t As Control
		For Each t In Me.Controls
			If TypeOf t Is TextBox Then
				If Trim(t.Text)="" Then
					MsgBox("debe llenar este dato")
					t.Select
					Return False
					End If
				End If
		Next
		Return True
	End Function
	
	
	Private Function creartabla As Data.DataTable
		Dim t As New Data.DataTable
		t.Columns.Add("id",Type.GetType("System.String"))
		t.Columns.Add("descripcion",Type.GetType("System.String"))
		t.Rows.Add("01","Neutralizador de olores")
		t.Rows.Add("02","Espuma limpiadora")
		t.Rows.Add("03","Limpiador quita grasa")
		t.Rows.Add("04","Limpiador blanqueado")
		t.Rows.Add("05","Aromatizante")
		t.Rows.Add("06","Limpiador de piso")
		t.Rows.Add("07","Limpiador de alfombra")
		t.Rows.Add("08","Legia")
		t.Rows.Add("09","Limpiador multi-usos")
		t.Rows.Add("10","Desinfectante de superficies")
		t.Rows.Add("11","Suavizante")
		t.Rows.Add("12","Detergente industrial")
		t.Rows.Add("13","Desengrasante Industrial")
		Return t

	End Function
	
	
	
	Sub BtnGuardarClick(sender As Object, e As EventArgs)
		
		Dim sentencia As String ="insert into producto values(" 
		
		sentencia = sentencia & Me.txtIdProducto.Text & ","					
		
		sentencia = sentencia & "'" & Me.cmbElegir.Text & "',"				
		
		
		sentencia = sentencia & "'" & Me.txtPrecio.Text & "')"			
		
		Dim conn As New MySqlConnection("server=localhost; user id=root; password=; database=britolin; pooling=false")
		Dim comando As New MySqlCommand(sentencia,conn)
		conn.Open()
		comando.ExecuteNonQuery()
		conn.Close()
		
		MsgBox("Producto dado de alta")
		
		p.id=Me.txtIdProducto.text
		p.elegir=Me.cmbElegir.SelectedValue.ToString
		p.precio=Me.txtPrecio.text
		'MsgBox("tipo:"& p.elegir &"precio:"& p.precio)
		
	End Sub
	
	Sub BtnVerificarClick(sender As Object, e As EventArgs)
		verificar()
		
	End Sub
	
	Sub TabPage2Click(sender As Object, e As EventArgs)
		
	End Sub
End Class
