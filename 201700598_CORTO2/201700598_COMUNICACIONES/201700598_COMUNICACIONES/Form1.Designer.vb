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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBCELULAR = New System.Windows.Forms.RadioButton()
        Me.RBTABLET = New System.Windows.Forms.RadioButton()
        Me.RBDRONE = New System.Windows.Forms.RadioButton()
        Me.RBTELEVISOR = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXTSUELDO = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LSTEMPLEADO = New System.Windows.Forms.ListBox()
        Me.LSTCOMISION = New System.Windows.Forms.ListBox()
        Me.LSTBONO = New System.Windows.Forms.ListBox()
        Me.LSTSUELDO = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LSTVENTAS = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBTELEVISOR)
        Me.GroupBox1.Controls.Add(Me.RBCELULAR)
        Me.GroupBox1.Controls.Add(Me.RBTABLET)
        Me.GroupBox1.Controls.Add(Me.RBDRONE)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(27, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(119, 125)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ARTICULOS"
        '
        'RBCELULAR
        '
        Me.RBCELULAR.AutoSize = True
        Me.RBCELULAR.Location = New System.Drawing.Point(23, 67)
        Me.RBCELULAR.Name = "RBCELULAR"
        Me.RBCELULAR.Size = New System.Drawing.Size(74, 17)
        Me.RBCELULAR.TabIndex = 2
        Me.RBCELULAR.TabStop = True
        Me.RBCELULAR.Text = "CELULAR"
        Me.RBCELULAR.UseVisualStyleBackColor = True
        '
        'RBTABLET
        '
        Me.RBTABLET.AutoSize = True
        Me.RBTABLET.Location = New System.Drawing.Point(23, 21)
        Me.RBTABLET.Name = "RBTABLET"
        Me.RBTABLET.Size = New System.Drawing.Size(66, 17)
        Me.RBTABLET.TabIndex = 0
        Me.RBTABLET.TabStop = True
        Me.RBTABLET.Text = "TABLET"
        Me.RBTABLET.UseVisualStyleBackColor = True
        '
        'RBDRONE
        '
        Me.RBDRONE.AutoSize = True
        Me.RBDRONE.Location = New System.Drawing.Point(23, 44)
        Me.RBDRONE.Name = "RBDRONE"
        Me.RBDRONE.Size = New System.Drawing.Size(64, 17)
        Me.RBDRONE.TabIndex = 1
        Me.RBDRONE.TabStop = True
        Me.RBDRONE.Text = "DRONE"
        Me.RBDRONE.UseVisualStyleBackColor = True
        '
        'RBTELEVISOR
        '
        Me.RBTELEVISOR.AutoSize = True
        Me.RBTELEVISOR.Location = New System.Drawing.Point(23, 90)
        Me.RBTELEVISOR.Name = "RBTELEVISOR"
        Me.RBTELEVISOR.Size = New System.Drawing.Size(85, 17)
        Me.RBTELEVISOR.TabIndex = 3
        Me.RBTELEVISOR.TabStop = True
        Me.RBTELEVISOR.Text = "TELEVISOR"
        Me.RBTELEVISOR.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TXTSUELDO)
        Me.GroupBox4.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(152, 39)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(269, 125)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "VENDEDOR"
        '
        'TXTSUELDO
        '
        Me.TXTSUELDO.Location = New System.Drawing.Point(81, 64)
        Me.TXTSUELDO.Name = "TXTSUELDO"
        Me.TXTSUELDO.Size = New System.Drawing.Size(98, 20)
        Me.TXTSUELDO.TabIndex = 1
        Me.TXTSUELDO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(72, 30)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(191, 20)
        Me.TXTNOMBRE.TabIndex = 0
        Me.TXTNOMBRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "EMPLEADO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "SUELDO:"
        '
        'LSTEMPLEADO
        '
        Me.LSTEMPLEADO.FormattingEnabled = True
        Me.LSTEMPLEADO.Location = New System.Drawing.Point(27, 204)
        Me.LSTEMPLEADO.Name = "LSTEMPLEADO"
        Me.LSTEMPLEADO.Size = New System.Drawing.Size(120, 95)
        Me.LSTEMPLEADO.TabIndex = 9
        '
        'LSTCOMISION
        '
        Me.LSTCOMISION.FormattingEnabled = True
        Me.LSTCOMISION.Location = New System.Drawing.Point(161, 204)
        Me.LSTCOMISION.Name = "LSTCOMISION"
        Me.LSTCOMISION.Size = New System.Drawing.Size(120, 95)
        Me.LSTCOMISION.TabIndex = 10
        '
        'LSTBONO
        '
        Me.LSTBONO.FormattingEnabled = True
        Me.LSTBONO.Location = New System.Drawing.Point(295, 204)
        Me.LSTBONO.Name = "LSTBONO"
        Me.LSTBONO.Size = New System.Drawing.Size(120, 95)
        Me.LSTBONO.TabIndex = 11
        '
        'LSTSUELDO
        '
        Me.LSTSUELDO.FormattingEnabled = True
        Me.LSTSUELDO.Location = New System.Drawing.Point(439, 204)
        Me.LSTSUELDO.Name = "LSTSUELDO"
        Me.LSTSUELDO.Size = New System.Drawing.Size(120, 95)
        Me.LSTSUELDO.TabIndex = 12
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'LSTVENTAS
        '
        Me.LSTVENTAS.FormattingEnabled = True
        Me.LSTVENTAS.Location = New System.Drawing.Point(575, 204)
        Me.LSTVENTAS.Name = "LSTVENTAS"
        Me.LSTVENTAS.Size = New System.Drawing.Size(120, 95)
        Me.LSTVENTAS.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "EMPLEADO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(158, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "COMISION"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "BONO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(436, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "SUELDO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(572, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "VENTAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(800, 335)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LSTVENTAS)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LSTSUELDO)
        Me.Controls.Add(Me.LSTBONO)
        Me.Controls.Add(Me.LSTCOMISION)
        Me.Controls.Add(Me.LSTEMPLEADO)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "COMUNICACIONES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBTELEVISOR As RadioButton
    Friend WithEvents RBCELULAR As RadioButton
    Friend WithEvents RBTABLET As RadioButton
    Friend WithEvents RBDRONE As RadioButton
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTSUELDO As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents LSTEMPLEADO As ListBox
    Friend WithEvents LSTCOMISION As ListBox
    Friend WithEvents LSTBONO As ListBox
    Friend WithEvents LSTSUELDO As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LSTVENTAS As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
