'
' Created by SharpDevelop.
' User: Daniel
' Date: 15/06/2020
' Time: 02:26 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class Movimiento
Private t As Data.DataTable
	Private v As Data.DataView 		
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Me.CenterToScreen()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub MovimientoLoad(sender As Object, e As EventArgs)
		Dim al As New clsCl
		Me.t=al.traCliente
		Me.v= New Data.DataView(t)
		Me.dgvDatos.DataSource=Me.v.ToTable
	End Sub
	
	Sub TabPage2Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub Label14Click(sender As Object, e As EventArgs)
		
	End Sub
	
	Sub TxtBusTextChanged(sender As Object, e As EventArgs)
	  Me.v= New Data.DataView(t)
		Me.v.RowFilter= "Nombre like '%" &  Me.txtBus.Text & "%'"
		Me.dgvDatos.DataSource= me.v.ToTable
		
	End Sub
End Class
