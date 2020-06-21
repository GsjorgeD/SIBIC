'
' Created by SharpDevelop.
' User: Daniel
' Date: 14/06/2020
' Time: 12:57 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Imports MySql.Data.MySqlClient
Public Partial Class Usuario
    Public p As New clsUsuario	
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	Function verificarVacios As Boolean
		Dim t As Control
		For Each  t In Me.Controls
			If TypeOf t Is TextBox Then
				If Trim(t.Text)="" Then
					MsgBox("debes de capturar un dato")
					t.Select
					Return False
				End If
			End If
		Next
		Return True  	
	End Function
	
	
	
	
	Sub BtnRegistroClick(sender As Object, e As EventArgs)
		Dim sentencia As String ="insert into usuario values(" 
		
		
		sentencia = sentencia & "'" & Me.txtUsuario.Text & "',"				'Nombre	
		
		sentencia = sentencia & "'" & Me.txtPass.Text & "')"			'FN
		
		Dim conn As New MySqlConnection("server=localhost; user id=root; password=; database=britolin; pooling=false")
		Dim comando As New MySqlCommand(sentencia,conn)
		conn.Open()
		comando.ExecuteNonQuery()
		conn.Close()
		p.usuario=Me.txtUsuario.Text
		p.pass=Me.txtPass.Text
		
		
		
		MsgBox("Registrado con exito")
		Me.Close
		
	End Sub
	
	Sub LblCodiClick(sender As Object, e As EventArgs)
		MsgBox("Necesita el codigo para registrarse")
	End Sub
	
	

	
	Sub BtnVerifyClick(sender As Object, e As EventArgs)
		 If  Me.verificarVacios()=True Then 
		 	If Me.txtCodi.Text="5ty68" Then
		 	   Me.btnRegistro.Enabled=True
			End If
		End If
		
	End Sub
End Class
