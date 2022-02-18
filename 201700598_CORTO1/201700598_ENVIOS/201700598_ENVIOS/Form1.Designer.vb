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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LMONTOSEGURO = New System.Windows.Forms.Label()
        Me.LVIATICOS = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTLIMPIAR = New System.Windows.Forms.Button()
        Me.BTCALCULAR = New System.Windows.Forms.Button()
        Me.BTSALIR = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RBVEHICULO = New System.Windows.Forms.RadioButton()
        Me.RBACCIDENTE = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBOCCIDENTE = New System.Windows.Forms.RadioButton()
        Me.RBORIENTE = New System.Windows.Forms.RadioButton()
        Me.RBSUR = New System.Windows.Forms.RadioButton()
        Me.RBNORTE = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LSUELDOFINAL = New System.Windows.Forms.Label()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LSUELDOFINAL)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.LMONTOSEGURO)
        Me.GroupBox4.Controls.Add(Me.LVIATICOS)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(292, 91)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(156, 127)
        Me.GroupBox4.TabIndex = 20
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DETALLE"
        '
        'LMONTOSEGURO
        '
        Me.LMONTOSEGURO.AutoSize = True
        Me.LMONTOSEGURO.Location = New System.Drawing.Point(116, 23)
        Me.LMONTOSEGURO.Name = "LMONTOSEGURO"
        Me.LMONTOSEGURO.Size = New System.Drawing.Size(13, 13)
        Me.LMONTOSEGURO.TabIndex = 13
        Me.LMONTOSEGURO.Text = "--"
        '
        'LVIATICOS
        '
        Me.LVIATICOS.AutoSize = True
        Me.LVIATICOS.Location = New System.Drawing.Point(116, 46)
        Me.LVIATICOS.Name = "LVIATICOS"
        Me.LVIATICOS.Size = New System.Drawing.Size(13, 13)
        Me.LVIATICOS.TabIndex = 15
        Me.LVIATICOS.Text = "--"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Monto de Seguro:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 44)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Viaticos:"
        '
        'TXTMONTO
        '
        Me.TXTMONTO.Location = New System.Drawing.Point(137, 55)
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(60, 20)
        Me.TXTMONTO.TabIndex = 19
        Me.TXTMONTO.Text = "0"
        Me.TXTMONTO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Location = New System.Drawing.Point(137, 15)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(265, 20)
        Me.TXTNOMBRE.TabIndex = 18
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BTLIMPIAR)
        Me.GroupBox3.Controls.Add(Me.BTCALCULAR)
        Me.GroupBox3.Controls.Add(Me.BTSALIR)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(226, 233)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(222, 69)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ACCIONES"
        '
        'BTLIMPIAR
        '
        Me.BTLIMPIAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTLIMPIAR.Location = New System.Drawing.Point(99, 15)
        Me.BTLIMPIAR.Name = "BTLIMPIAR"
        Me.BTLIMPIAR.Size = New System.Drawing.Size(63, 44)
        Me.BTLIMPIAR.TabIndex = 1
        Me.BTLIMPIAR.Text = "LIMPIAR"
        Me.BTLIMPIAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTLIMPIAR.UseVisualStyleBackColor = False
        '
        'BTCALCULAR
        '
        Me.BTCALCULAR.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BTCALCULAR.Location = New System.Drawing.Point(16, 15)
        Me.BTCALCULAR.Name = "BTCALCULAR"
        Me.BTCALCULAR.Size = New System.Drawing.Size(78, 44)
        Me.BTCALCULAR.TabIndex = 0
        Me.BTCALCULAR.Text = " CALCULAR"
        Me.BTCALCULAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTCALCULAR.UseVisualStyleBackColor = False
        '
        'BTSALIR
        '
        Me.BTSALIR.BackgroundImage = CType(resources.GetObject("BTSALIR.BackgroundImage"), System.Drawing.Image)
        Me.BTSALIR.Location = New System.Drawing.Point(168, 15)
        Me.BTSALIR.Name = "BTSALIR"
        Me.BTSALIR.Size = New System.Drawing.Size(48, 44)
        Me.BTSALIR.TabIndex = 3
        Me.BTSALIR.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RBVEHICULO)
        Me.GroupBox2.Controls.Add(Me.RBACCIDENTE)
        Me.GroupBox2.Location = New System.Drawing.Point(167, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(119, 127)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SEGUROS"
        '
        'RBVEHICULO
        '
        Me.RBVEHICULO.AutoSize = True
        Me.RBVEHICULO.Location = New System.Drawing.Point(14, 19)
        Me.RBVEHICULO.Name = "RBVEHICULO"
        Me.RBVEHICULO.Size = New System.Drawing.Size(79, 17)
        Me.RBVEHICULO.TabIndex = 4
        Me.RBVEHICULO.TabStop = True
        Me.RBVEHICULO.Text = "VEHICULO"
        Me.RBVEHICULO.UseVisualStyleBackColor = True
        '
        'RBACCIDENTE
        '
        Me.RBACCIDENTE.AutoSize = True
        Me.RBACCIDENTE.Location = New System.Drawing.Point(14, 54)
        Me.RBACCIDENTE.Name = "RBACCIDENTE"
        Me.RBACCIDENTE.Size = New System.Drawing.Size(93, 17)
        Me.RBACCIDENTE.TabIndex = 5
        Me.RBACCIDENTE.TabStop = True
        Me.RBACCIDENTE.Text = "ACCIDENTES"
        Me.RBACCIDENTE.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBOCCIDENTE)
        Me.GroupBox1.Controls.Add(Me.RBORIENTE)
        Me.GroupBox1.Controls.Add(Me.RBSUR)
        Me.GroupBox1.Controls.Add(Me.RBNORTE)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(144, 127)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "REGION"
        '
        'RBOCCIDENTE
        '
        Me.RBOCCIDENTE.AutoSize = True
        Me.RBOCCIDENTE.Location = New System.Drawing.Point(19, 88)
        Me.RBOCCIDENTE.Name = "RBOCCIDENTE"
        Me.RBOCCIDENTE.Size = New System.Drawing.Size(87, 17)
        Me.RBOCCIDENTE.TabIndex = 3
        Me.RBOCCIDENTE.TabStop = True
        Me.RBOCCIDENTE.Text = "OCCIDENTE"
        Me.RBOCCIDENTE.UseVisualStyleBackColor = True
        '
        'RBORIENTE
        '
        Me.RBORIENTE.AutoSize = True
        Me.RBORIENTE.Location = New System.Drawing.Point(19, 65)
        Me.RBORIENTE.Name = "RBORIENTE"
        Me.RBORIENTE.Size = New System.Drawing.Size(73, 17)
        Me.RBORIENTE.TabIndex = 2
        Me.RBORIENTE.TabStop = True
        Me.RBORIENTE.Text = "ORIENTE"
        Me.RBORIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RBORIENTE.UseVisualStyleBackColor = True
        '
        'RBSUR
        '
        Me.RBSUR.AutoSize = True
        Me.RBSUR.Location = New System.Drawing.Point(19, 42)
        Me.RBSUR.Name = "RBSUR"
        Me.RBSUR.Size = New System.Drawing.Size(48, 17)
        Me.RBSUR.TabIndex = 1
        Me.RBSUR.TabStop = True
        Me.RBSUR.Text = "SUR"
        Me.RBSUR.UseVisualStyleBackColor = True
        '
        'RBNORTE
        '
        Me.RBNORTE.AutoSize = True
        Me.RBNORTE.Location = New System.Drawing.Point(19, 19)
        Me.RBNORTE.Name = "RBNORTE"
        Me.RBNORTE.Size = New System.Drawing.Size(63, 17)
        Me.RBNORTE.TabIndex = 0
        Me.RBNORTE.TabStop = True
        Me.RBNORTE.Text = "NORTE"
        Me.RBNORTE.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Monto Envio:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Nombre Mensajero:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Suledo Final:"
        '
        'LSUELDOFINAL
        '
        Me.LSUELDOFINAL.AutoSize = True
        Me.LSUELDOFINAL.Location = New System.Drawing.Point(116, 69)
        Me.LSUELDOFINAL.Name = "LSUELDOFINAL"
        Me.LSUELDOFINAL.Size = New System.Drawing.Size(13, 13)
        Me.LSUELDOFINAL.TabIndex = 21
        Me.LSUELDOFINAL.Text = "--"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(465, 323)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.TXTMONTO)
        Me.Controls.Add(Me.TXTNOMBRE)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "MENSAJERIA ENVIOS S. A."
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LMONTOSEGURO As Label
    Friend WithEvents LVIATICOS As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTMONTO As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BTLIMPIAR As Button
    Friend WithEvents BTCALCULAR As Button
    Friend WithEvents BTSALIR As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RBVEHICULO As RadioButton
    Friend WithEvents RBACCIDENTE As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBOCCIDENTE As RadioButton
    Friend WithEvents RBORIENTE As RadioButton
    Friend WithEvents RBSUR As RadioButton
    Friend WithEvents RBNORTE As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LSUELDOFINAL As Label
End Class
