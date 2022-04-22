<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CálculoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LimpiarVectoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblNit = New System.Windows.Forms.Label()
        Me.lblDias = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbPago = New System.Windows.Forms.ComboBox()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNiot = New System.Windows.Forms.TextBox()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.txtImpuesto = New System.Windows.Forms.TextBox()
        Me.cbHabitacion = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CálculoToolStripMenuItem, Me.MostrarToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.EliminarToolStripMenuItem, Me.LimpiarVectoresToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'CálculoToolStripMenuItem
        '
        Me.CálculoToolStripMenuItem.Name = "CálculoToolStripMenuItem"
        Me.CálculoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CálculoToolStripMenuItem.Text = "Cálculo"
        '
        'MostrarToolStripMenuItem
        '
        Me.MostrarToolStripMenuItem.Name = "MostrarToolStripMenuItem"
        Me.MostrarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MostrarToolStripMenuItem.Text = "Mostrar"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'LimpiarVectoresToolStripMenuItem
        '
        Me.LimpiarVectoresToolStripMenuItem.Name = "LimpiarVectoresToolStripMenuItem"
        Me.LimpiarVectoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LimpiarVectoresToolStripMenuItem.Text = "Limpiar Vectores"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(270, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "201700598_HOTEL"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(13, 111)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(94, 15)
        Me.lblCliente.TabIndex = 3
        Me.lblCliente.Text = "Nombre Cliente:"
        '
        'lblNit
        '
        Me.lblNit.AutoSize = True
        Me.lblNit.Location = New System.Drawing.Point(12, 141)
        Me.lblNit.Name = "lblNit"
        Me.lblNit.Size = New System.Drawing.Size(25, 15)
        Me.lblNit.TabIndex = 4
        Me.lblNit.Text = "NIT"
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Location = New System.Drawing.Point(13, 171)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(86, 15)
        Me.lblDias.TabIndex = 5
        Me.lblDias.Text = "Días hospedaje"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Valor del impuesto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Tipo habitacion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 270)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Tipo de pago"
        '
        'cbPago
        '
        Me.cbPago.FormattingEnabled = True
        Me.cbPago.Items.AddRange(New Object() {"Efectivo", "Tarjeta", "Transferencia", "Depósito"})
        Me.cbPago.Location = New System.Drawing.Point(124, 267)
        Me.cbPago.Name = "cbPago"
        Me.cbPago.Size = New System.Drawing.Size(121, 23)
        Me.cbPago.TabIndex = 9
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(124, 314)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 10
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(124, 108)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 23)
        Me.txtNombre.TabIndex = 11
        '
        'txtNiot
        '
        Me.txtNiot.Location = New System.Drawing.Point(124, 138)
        Me.txtNiot.Name = "txtNiot"
        Me.txtNiot.Size = New System.Drawing.Size(100, 23)
        Me.txtNiot.TabIndex = 12
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(124, 168)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(100, 23)
        Me.txtDias.TabIndex = 13
        '
        'txtImpuesto
        '
        Me.txtImpuesto.Location = New System.Drawing.Point(124, 198)
        Me.txtImpuesto.Name = "txtImpuesto"
        Me.txtImpuesto.Size = New System.Drawing.Size(100, 23)
        Me.txtImpuesto.TabIndex = 14
        '
        'cbHabitacion
        '
        Me.cbHabitacion.FormattingEnabled = True
        Me.cbHabitacion.Items.AddRange(New Object() {"Sencilla", "Doble", "Cabana"})
        Me.cbHabitacion.Location = New System.Drawing.Point(124, 238)
        Me.cbHabitacion.Name = "cbHabitacion"
        Me.cbHabitacion.Size = New System.Drawing.Size(121, 23)
        Me.cbHabitacion.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cbHabitacion)
        Me.Controls.Add(Me.txtImpuesto)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.txtNiot)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.cbPago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblDias)
        Me.Controls.Add(Me.lblNit)
        Me.Controls.Add(Me.lblCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CálculoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LimpiarVectoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents lblNit As Label
    Friend WithEvents lblDias As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbPago As ComboBox
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNiot As TextBox
    Friend WithEvents txtDias As TextBox
    Friend WithEvents txtImpuesto As TextBox
    Friend WithEvents cbHabitacion As ComboBox
End Class
