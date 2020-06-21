'
' Created by SharpDevelop.
' User: Daniel
' Date: 15/06/2020
' Time: 01:47 a. m.
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Public Partial Class bitacora
	Public Sub New()
		' The Me.InitializeComponent call is required for Windows Forms designer support.
		Me.InitializeComponent()
		Me.CenterToScreen()
		
		'
		' TODO : Add constructor code after InitializeComponents
		'
	End Sub
	
	Sub BitacoraLoad(sender As Object, e As EventArgs)
		
	End Sub
	
	
	'Sub MantenimientoToolStripMenuItemClick(sender As Object, e As EventArgs)
		'My.Forms.Mantenimiento.ShowDialog    	
		
	'End Sub
	
	'Sub MovimientoToolStripMenuItemClick(sender As Object, e As EventArgs)
	'	My.Forms.Movimiento.ShowDialog
		
	'End Sub
	
	
	Sub AltaToolStripMenuItemClick(sender As Object, e As EventArgs)
       My.Forms.Mantenimiento.ShowDialog		
	End Sub
	
	Sub AltaToolStripMenuItem1Click(sender As Object, e As EventArgs)
 	   My.Forms.MantenimientoAC.ShowDialog	
	End Sub
	
	Sub BusquedaToolStripMenuItemClick(sender As Object, e As EventArgs)
		My.Forms.Movimiento.ShowDialog
	End Sub
	
	Sub ModificarToolStripMenuItemClick(sender As Object, e As EventArgs)
       	My.Forms.MoviientoCl.ShowDialog	
	End Sub
	
	Sub EliminarToolStripMenuItemClick(sender As Object, e As EventArgs)
        My.Forms.MovimientoClDelete.ShowDialog		
	End Sub
	
	Sub ModificarToolStripMenuItem1Click(sender As Object, e As EventArgs)
		My.Forms.MovimientoProUpdate.ShowDialog
	End Sub
	
	Sub EliminarToolStripMenuItem1Click(sender As Object, e As EventArgs)
        My.Forms.MovimientoProDelete.ShowDialog		
	End Sub
End Class
