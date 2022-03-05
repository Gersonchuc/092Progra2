<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.AGREGARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LVECTORESToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBPAGO = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBSERVICIO = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBHABITACION = New System.Windows.Forms.ComboBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LST_DIAS = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LST_HABITACION = New System.Windows.Forms.ListBox()
        Me.LST_SERVICIO = New System.Windows.Forms.ListBox()
        Me.LST_TOTAL = New System.Windows.Forms.ListBox()
        Me.LST_PAGO = New System.Windows.Forms.ListBox()
        Me.LST_subtotal = New System.Windows.Forms.ListBox()
        Me.LST_RECARGO = New System.Windows.Forms.ListBox()
        Me.LST_DESCUENTO1 = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXTDIAS = New System.Windows.Forms.TextBox()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGREGARToolStripMenuItem1, Me.LIMPIARToolStripMenuItem1, Me.SALIRToolStripMenuItem1, Me.LVECTORESToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(774, 24)
        Me.MenuStrip2.TabIndex = 13
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'AGREGARToolStripMenuItem1
        '
        Me.AGREGARToolStripMenuItem1.Name = "AGREGARToolStripMenuItem1"
        Me.AGREGARToolStripMenuItem1.Size = New System.Drawing.Size(71, 20)
        Me.AGREGARToolStripMenuItem1.Text = "AGREGAR"
        '
        'LIMPIARToolStripMenuItem1
        '
        Me.LIMPIARToolStripMenuItem1.Name = "LIMPIARToolStripMenuItem1"
        Me.LIMPIARToolStripMenuItem1.Size = New System.Drawing.Size(64, 20)
        Me.LIMPIARToolStripMenuItem1.Text = "LIMPIAR"
        '
        'SALIRToolStripMenuItem1
        '
        Me.SALIRToolStripMenuItem1.Name = "SALIRToolStripMenuItem1"
        Me.SALIRToolStripMenuItem1.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem1.Text = "SALIR"
        '
        'LVECTORESToolStripMenuItem1
        '
        Me.LVECTORESToolStripMenuItem1.Name = "LVECTORESToolStripMenuItem1"
        Me.LVECTORESToolStripMenuItem1.Size = New System.Drawing.Size(121, 20)
        Me.LVECTORESToolStripMenuItem1.Text = "LIMPIAR VECTORES"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBPAGO)
        Me.GroupBox3.Location = New System.Drawing.Point(611, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(128, 55)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIPO DE PAGO"
        '
        'CBPAGO
        '
        Me.CBPAGO.FormattingEnabled = True
        Me.CBPAGO.Items.AddRange(New Object() {"EFECTIVO", "CHEQUE", "T. CREDITO", "T. DEBITO"})
        Me.CBPAGO.Location = New System.Drawing.Point(17, 19)
        Me.CBPAGO.Name = "CBPAGO"
        Me.CBPAGO.Size = New System.Drawing.Size(89, 21)
        Me.CBPAGO.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBSERVICIO)
        Me.GroupBox2.Location = New System.Drawing.Point(477, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(128, 55)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SERVICIO"
        '
        'CBSERVICIO
        '
        Me.CBSERVICIO.FormattingEnabled = True
        Me.CBSERVICIO.Items.AddRange(New Object() {"ENCAMAMIENTO", "OPERACION", "MATERNIDAD"})
        Me.CBSERVICIO.Location = New System.Drawing.Point(21, 19)
        Me.CBSERVICIO.Name = "CBSERVICIO"
        Me.CBSERVICIO.Size = New System.Drawing.Size(89, 21)
        Me.CBSERVICIO.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CBHABITACION)
        Me.GroupBox1.Location = New System.Drawing.Point(343, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(128, 55)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "HABITACION"
        '
        'CBHABITACION
        '
        Me.CBHABITACION.FormattingEnabled = True
        Me.CBHABITACION.Items.AddRange(New Object() {"PRIVADA", "SEMI-PRIVADA", "NO PRIVADA"})
        Me.CBHABITACION.Location = New System.Drawing.Point(20, 19)
        Me.CBHABITACION.Name = "CBHABITACION"
        Me.CBHABITACION.Size = New System.Drawing.Size(89, 21)
        Me.CBHABITACION.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Controls.Add(Me.LST_DIAS)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.LST_HABITACION)
        Me.GroupBox5.Controls.Add(Me.LST_SERVICIO)
        Me.GroupBox5.Controls.Add(Me.LST_TOTAL)
        Me.GroupBox5.Controls.Add(Me.LST_PAGO)
        Me.GroupBox5.Controls.Add(Me.LST_subtotal)
        Me.GroupBox5.Controls.Add(Me.LST_RECARGO)
        Me.GroupBox5.Controls.Add(Me.LST_DESCUENTO1)
        Me.GroupBox5.Location = New System.Drawing.Point(28, 176)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(711, 164)
        Me.GroupBox5.TabIndex = 22
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DETALLE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(298, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "DIAS"
        '
        'LST_DIAS
        '
        Me.LST_DIAS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_DIAS.FormattingEnabled = True
        Me.LST_DIAS.Location = New System.Drawing.Point(301, 47)
        Me.LST_DIAS.Name = "LST_DIAS"
        Me.LST_DIAS.Size = New System.Drawing.Size(46, 95)
        Me.LST_DIAS.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(356, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Sub Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(444, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "DESCUENTO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(532, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "RECARGO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(620, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "TOTAL"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(201, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 13)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "TIPO DE PAGO"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(116, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "SERVICIO"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(25, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "HABITACION"
        '
        'LST_HABITACION
        '
        Me.LST_HABITACION.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_HABITACION.FormattingEnabled = True
        Me.LST_HABITACION.Location = New System.Drawing.Point(28, 47)
        Me.LST_HABITACION.Name = "LST_HABITACION"
        Me.LST_HABITACION.Size = New System.Drawing.Size(82, 95)
        Me.LST_HABITACION.TabIndex = 19
        '
        'LST_SERVICIO
        '
        Me.LST_SERVICIO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_SERVICIO.FormattingEnabled = True
        Me.LST_SERVICIO.Location = New System.Drawing.Point(116, 47)
        Me.LST_SERVICIO.Name = "LST_SERVICIO"
        Me.LST_SERVICIO.Size = New System.Drawing.Size(82, 95)
        Me.LST_SERVICIO.TabIndex = 12
        '
        'LST_TOTAL
        '
        Me.LST_TOTAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.LST_TOTAL.FormattingEnabled = True
        Me.LST_TOTAL.Location = New System.Drawing.Point(623, 47)
        Me.LST_TOTAL.Name = "LST_TOTAL"
        Me.LST_TOTAL.Size = New System.Drawing.Size(82, 95)
        Me.LST_TOTAL.TabIndex = 18
        '
        'LST_PAGO
        '
        Me.LST_PAGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_PAGO.FormattingEnabled = True
        Me.LST_PAGO.Location = New System.Drawing.Point(204, 47)
        Me.LST_PAGO.Name = "LST_PAGO"
        Me.LST_PAGO.Size = New System.Drawing.Size(82, 95)
        Me.LST_PAGO.TabIndex = 13
        '
        'LST_subtotal
        '
        Me.LST_subtotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_subtotal.FormattingEnabled = True
        Me.LST_subtotal.Location = New System.Drawing.Point(359, 47)
        Me.LST_subtotal.Name = "LST_subtotal"
        Me.LST_subtotal.Size = New System.Drawing.Size(82, 95)
        Me.LST_subtotal.TabIndex = 14
        '
        'LST_RECARGO
        '
        Me.LST_RECARGO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_RECARGO.FormattingEnabled = True
        Me.LST_RECARGO.Location = New System.Drawing.Point(535, 47)
        Me.LST_RECARGO.Name = "LST_RECARGO"
        Me.LST_RECARGO.Size = New System.Drawing.Size(82, 95)
        Me.LST_RECARGO.TabIndex = 16
        '
        'LST_DESCUENTO1
        '
        Me.LST_DESCUENTO1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LST_DESCUENTO1.FormattingEnabled = True
        Me.LST_DESCUENTO1.Location = New System.Drawing.Point(447, 47)
        Me.LST_DESCUENTO1.Name = "LST_DESCUENTO1"
        Me.LST_DESCUENTO1.Size = New System.Drawing.Size(82, 95)
        Me.LST_DESCUENTO1.TabIndex = 15
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXTDIAS)
        Me.GroupBox4.Controls.Add(Me.TXTNIT)
        Me.GroupBox4.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(28, 27)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(309, 143)
        Me.GroupBox4.TabIndex = 23
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DATOS PACIENTE"
        '
        'TXTDIAS
        '
        Me.TXTDIAS.Location = New System.Drawing.Point(98, 73)
        Me.TXTDIAS.Name = "TXTDIAS"
        Me.TXTDIAS.Size = New System.Drawing.Size(56, 20)
        Me.TXTDIAS.TabIndex = 6
        '
        'TXTNIT
        '
        Me.TXTNIT.Location = New System.Drawing.Point(98, 39)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(147, 20)
        Me.TXTNIT.TabIndex = 5
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(98, 13)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(197, 20)
        Me.TXTNOMBRE.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(57, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "DIAS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "NIT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(35, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "NOMBRE"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(774, 353)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "Form1"
        Me.Text = "HOSPITAL"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents AGREGARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LVECTORESToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBPAGO As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBSERVICIO As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CBHABITACION As ComboBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents LST_HABITACION As ListBox
    Friend WithEvents LST_SERVICIO As ListBox
    Friend WithEvents LST_TOTAL As ListBox
    Friend WithEvents LST_PAGO As ListBox
    Friend WithEvents LST_subtotal As ListBox
    Friend WithEvents LST_RECARGO As ListBox
    Friend WithEvents LST_DESCUENTO1 As ListBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXTDIAS As TextBox
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LST_DIAS As ListBox
End Class
