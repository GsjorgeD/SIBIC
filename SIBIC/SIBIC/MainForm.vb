'
' Created by SharpDevelop.
' User: Daniel
' Date: 13/06/2020
' Time: 08:04 p. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class MainForm
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Me.CenterToScreen()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	
	End Sub
	
	Function verificar As Boolean
				Dim t As Control
		For Each  t In Me.Controls
			If TypeOf t Is TextBox Then
				If Trim(t.Text)="" Then
					MsgBox("Ingrese datos")
					t.Select
					Return False
				End If
			End If
		Next
		Return True
	End Function
	

	
	Sub BtnEntrarClick(sender As Object, e As EventArgs)
		If Me.verificar()=True Then
		MsgBox("Bienvenido "&Me.txtUsuario.Text)
		My.Forms.bitacora.ShowDialog
		End If
	End Sub
	
	
	
	
	
	Sub LblNewCuentaClick(sender As Object, e As EventArgs)
		Dim f As New Usuario 
		f.ShowDialog
		Me.txtUsuario.Text=f.p.usuario
	    Me.txtPass.Text=f.p.pass
		
		'My.Forms.Usuario.ShowDialog
		
	End Sub
	
	
	
	Sub Panel1Paint(sender As Object, e As PaintEventArgs)
		
	End Sub
End Class
