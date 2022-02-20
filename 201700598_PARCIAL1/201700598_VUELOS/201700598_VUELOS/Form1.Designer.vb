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
        Me.RBHELICOPTERO = New System.Windows.Forms.RadioButton()
        Me.RBJET = New System.Windows.Forms.RadioButton()
        Me.RBAVIONETA = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CBSUR = New System.Windows.Forms.CheckBox()
        Me.CBIZABAL = New System.Windows.Forms.CheckBox()
        Me.CBPETEN = New System.Windows.Forms.CheckBox()
        Me.TXTPASAJEROS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LDESCUENTO = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LSUBTOTAL = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LTOTAL = New System.Windows.Forms.Label()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBHELICOPTERO)
        Me.GroupBox1.Controls.Add(Me.RBJET)
        Me.GroupBox1.Controls.Add(Me.RBAVIONETA)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(29, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(131, 115)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AERONAVE"
        '
        'RBHELICOPTERO
        '
        Me.RBHELICOPTERO.AutoSize = True
        Me.RBHELICOPTERO.Location = New System.Drawing.Point(20, 73)
        Me.RBHELICOPTERO.Name = "RBHELICOPTERO"
        Me.RBHELICOPTERO.Size = New System.Drawing.Size(101, 17)
        Me.RBHELICOPTERO.TabIndex = 2
        Me.RBHELICOPTERO.TabStop = True
        Me.RBHELICOPTERO.Text = "HELICOPTERO"
        Me.RBHELICOPTERO.UseVisualStyleBackColor = True
        '
        'RBJET
        '
        Me.RBJET.AutoSize = True
        Me.RBJET.Location = New System.Drawing.Point(20, 50)
        Me.RBJET.Name = "RBJET"
        Me.RBJET.Size = New System.Drawing.Size(44, 17)
        Me.RBJET.TabIndex = 1
        Me.RBJET.TabStop = True
        Me.RBJET.Text = "JET"
        Me.RBJET.UseVisualStyleBackColor = True
        '
        'RBAVIONETA
        '
        Me.RBAVIONETA.AutoSize = True
        Me.RBAVIONETA.Location = New System.Drawing.Point(20, 26)
        Me.RBAVIONETA.Name = "RBAVIONETA"
        Me.RBAVIONETA.Size = New System.Drawing.Size(79, 17)
        Me.RBAVIONETA.TabIndex = 0
        Me.RBAVIONETA.TabStop = True
        Me.RBAVIONETA.Text = "AVIONETA"
        Me.RBAVIONETA.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CBPETEN)
        Me.GroupBox2.Controls.Add(Me.CBSUR)
        Me.GroupBox2.Controls.Add(Me.CBIZABAL)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(184, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(131, 115)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DESTINO"
        '
        'CBSUR
        '
        Me.CBSUR.AutoSize = True
        Me.CBSUR.Location = New System.Drawing.Point(20, 27)
        Me.CBSUR.Name = "CBSUR"
        Me.CBSUR.Size = New System.Drawing.Size(88, 17)
        Me.CBSUR.TabIndex = 7
        Me.CBSUR.Text = "COSTA SUR"
        Me.CBSUR.UseVisualStyleBackColor = True
        '
        'CBIZABAL
        '
        Me.CBIZABAL.AutoSize = True
        Me.CBIZABAL.Location = New System.Drawing.Point(20, 51)
        Me.CBIZABAL.Name = "CBIZABAL"
        Me.CBIZABAL.Size = New System.Drawing.Size(63, 17)
        Me.CBIZABAL.TabIndex = 8
        Me.CBIZABAL.Text = "IZABAL"
        Me.CBIZABAL.UseVisualStyleBackColor = True
        '
        'CBPETEN
        '
        Me.CBPETEN.AutoSize = True
        Me.CBPETEN.Location = New System.Drawing.Point(21, 74)
        Me.CBPETEN.Name = "CBPETEN"
        Me.CBPETEN.Size = New System.Drawing.Size(62, 17)
        Me.CBPETEN.TabIndex = 9
        Me.CBPETEN.Text = "PETEN"
        Me.CBPETEN.UseVisualStyleBackColor = True
        '
        'TXTPASAJEROS
        '
        Me.TXTPASAJEROS.Location = New System.Drawing.Point(166, 186)
        Me.TXTPASAJEROS.Name = "TXTPASAJEROS"
        Me.TXTPASAJEROS.Size = New System.Drawing.Size(100, 20)
        Me.TXTPASAJEROS.TabIndex = 7
        Me.TXTPASAJEROS.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(34, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "CANT. DE PASAJEROS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(192, 263)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "DESCUENTO:"
        '
        'LDESCUENTO
        '
        Me.LDESCUENTO.AutoSize = True
        Me.LDESCUENTO.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LDESCUENTO.Location = New System.Drawing.Point(296, 263)
        Me.LDESCUENTO.Name = "LDESCUENTO"
        Me.LDESCUENTO.Size = New System.Drawing.Size(13, 13)
        Me.LDESCUENTO.TabIndex = 13
        Me.LDESCUENTO.Text = "--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(202, 235)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "SUBTOTAL:"
        '
        'LSUBTOTAL
        '
        Me.LSUBTOTAL.AutoSize = True
        Me.LSUBTOTAL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LSUBTOTAL.Location = New System.Drawing.Point(296, 235)
        Me.LSUBTOTAL.Name = "LSUBTOTAL"
        Me.LSUBTOTAL.Size = New System.Drawing.Size(13, 13)
        Me.LSUBTOTAL.TabIndex = 11
        Me.LSUBTOTAL.Text = "--"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARToolStripMenuItem, Me.CERRARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(377, 24)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(224, 290)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "TOTAL:"
        '
        'LTOTAL
        '
        Me.LTOTAL.AutoSize = True
        Me.LTOTAL.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LTOTAL.Location = New System.Drawing.Point(296, 290)
        Me.LTOTAL.Name = "LTOTAL"
        Me.LTOTAL.Size = New System.Drawing.Size(13, 13)
        Me.LTOTAL.TabIndex = 16
        Me.LTOTAL.Text = "--"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARToolStripMenuItem
        '
        Me.LIMPIARToolStripMenuItem.Name = "LIMPIARToolStripMenuItem"
        Me.LIMPIARToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.LIMPIARToolStripMenuItem.Text = "LIMPIAR"
        '
        'CERRARToolStripMenuItem
        '
        Me.CERRARToolStripMenuItem.Name = "CERRARToolStripMenuItem"
        Me.CERRARToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CERRARToolStripMenuItem.Text = "CERRAR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkBlue
        Me.ClientSize = New System.Drawing.Size(377, 316)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LTOTAL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LDESCUENTO)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LSUBTOTAL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTPASAJEROS)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "VUELOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBHELICOPTERO As RadioButton
    Friend WithEvents RBJET As RadioButton
    Friend WithEvents RBAVIONETA As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CBPETEN As CheckBox
    Friend WithEvents CBSUR As CheckBox
    Friend WithEvents CBIZABAL As CheckBox
    Friend WithEvents TXTPASAJEROS As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LDESCUENTO As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LSUBTOTAL As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label4 As Label
    Friend WithEvents LTOTAL As Label
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CERRARToolStripMenuItem As ToolStripMenuItem
End Class
