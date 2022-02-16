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
        Me.TXTSEDA = New System.Windows.Forms.TextBox()
        Me.TXTALGODON = New System.Windows.Forms.TextBox()
        Me.TXTLONA = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CBLONA = New System.Windows.Forms.CheckBox()
        Me.CBSEDA = New System.Windows.Forms.CheckBox()
        Me.CBALGODON = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBLARGE = New System.Windows.Forms.RadioButton()
        Me.RBMEDIUM = New System.Windows.Forms.RadioButton()
        Me.RBSMALL = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LVENTA = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LRESULTADOS = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTLIMPIAR = New System.Windows.Forms.Button()
        Me.BTCALCULAR = New System.Windows.Forms.Button()
        Me.BTSALIR = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXTSEDA)
        Me.GroupBox4.Controls.Add(Me.TXTALGODON)
        Me.GroupBox4.Controls.Add(Me.TXTLONA)
        Me.GroupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox4.Location = New System.Drawing.Point(280, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(106, 105)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Yardas"
        '
        'TXTSEDA
        '
        Me.TXTSEDA.Enabled = False
        Me.TXTSEDA.Location = New System.Drawing.Point(7, 52)
        Me.TXTSEDA.Name = "TXTSEDA"
        Me.TXTSEDA.Size = New System.Drawing.Size(93, 20)
        Me.TXTSEDA.TabIndex = 2
        Me.TXTSEDA.Text = "0"
        Me.TXTSEDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTALGODON
        '
        Me.TXTALGODON.Enabled = False
        Me.TXTALGODON.Location = New System.Drawing.Point(7, 24)
        Me.TXTALGODON.Name = "TXTALGODON"
        Me.TXTALGODON.Size = New System.Drawing.Size(93, 20)
        Me.TXTALGODON.TabIndex = 1
        Me.TXTALGODON.Text = "0"
        Me.TXTALGODON.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TXTLONA
        '
        Me.TXTLONA.Enabled = False
        Me.TXTLONA.Location = New System.Drawing.Point(7, 78)
        Me.TXTLONA.Name = "TXTLONA"
        Me.TXTLONA.Size = New System.Drawing.Size(93, 20)
        Me.TXTLONA.TabIndex = 0
        Me.TXTLONA.Text = "0"
        Me.TXTLONA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBLONA)
        Me.GroupBox3.Controls.Add(Me.CBSEDA)
        Me.GroupBox3.Controls.Add(Me.CBALGODON)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox3.Location = New System.Drawing.Point(155, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(106, 105)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MATERIALES"
        '
        'CBLONA
        '
        Me.CBLONA.AutoSize = True
        Me.CBLONA.Location = New System.Drawing.Point(6, 74)
        Me.CBLONA.Name = "CBLONA"
        Me.CBLONA.Size = New System.Drawing.Size(50, 17)
        Me.CBLONA.TabIndex = 3
        Me.CBLONA.Text = "Lona"
        Me.CBLONA.UseVisualStyleBackColor = True
        '
        'CBSEDA
        '
        Me.CBSEDA.AutoSize = True
        Me.CBSEDA.Location = New System.Drawing.Point(6, 51)
        Me.CBSEDA.Name = "CBSEDA"
        Me.CBSEDA.Size = New System.Drawing.Size(51, 17)
        Me.CBSEDA.TabIndex = 2
        Me.CBSEDA.Text = "Seda"
        Me.CBSEDA.UseVisualStyleBackColor = True
        '
        'CBALGODON
        '
        Me.CBALGODON.AutoSize = True
        Me.CBALGODON.Location = New System.Drawing.Point(6, 28)
        Me.CBALGODON.Name = "CBALGODON"
        Me.CBALGODON.Size = New System.Drawing.Size(65, 17)
        Me.CBALGODON.TabIndex = 1
        Me.CBALGODON.Text = "Algodon"
        Me.CBALGODON.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBLARGE)
        Me.GroupBox1.Controls.Add(Me.RBMEDIUM)
        Me.GroupBox1.Controls.Add(Me.RBSMALL)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(32, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(106, 105)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TAMAÑOS"
        '
        'RBLARGE
        '
        Me.RBLARGE.AutoSize = True
        Me.RBLARGE.Location = New System.Drawing.Point(20, 73)
        Me.RBLARGE.Name = "RBLARGE"
        Me.RBLARGE.Size = New System.Drawing.Size(61, 17)
        Me.RBLARGE.TabIndex = 2
        Me.RBLARGE.TabStop = True
        Me.RBLARGE.Text = "LARGE"
        Me.RBLARGE.UseVisualStyleBackColor = True
        '
        'RBMEDIUM
        '
        Me.RBMEDIUM.AutoSize = True
        Me.RBMEDIUM.Location = New System.Drawing.Point(20, 50)
        Me.RBMEDIUM.Name = "RBMEDIUM"
        Me.RBMEDIUM.Size = New System.Drawing.Size(69, 17)
        Me.RBMEDIUM.TabIndex = 1
        Me.RBMEDIUM.TabStop = True
        Me.RBMEDIUM.Text = "MEDIUM"
        Me.RBMEDIUM.UseVisualStyleBackColor = True
        '
        'RBSMALL
        '
        Me.RBSMALL.AutoSize = True
        Me.RBSMALL.Location = New System.Drawing.Point(20, 27)
        Me.RBSMALL.Name = "RBSMALL"
        Me.RBSMALL.Size = New System.Drawing.Size(60, 17)
        Me.RBSMALL.TabIndex = 0
        Me.RBSMALL.TabStop = True
        Me.RBSMALL.Text = "SMALL"
        Me.RBSMALL.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(48, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Precio de Venta:"
        '
        'LVENTA
        '
        Me.LVENTA.AutoSize = True
        Me.LVENTA.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LVENTA.Location = New System.Drawing.Point(158, 172)
        Me.LVENTA.Name = "LVENTA"
        Me.LVENTA.Size = New System.Drawing.Size(13, 13)
        Me.LVENTA.TabIndex = 13
        Me.LVENTA.Text = "--"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(48, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Precio de Costo:"
        '
        'LRESULTADOS
        '
        Me.LRESULTADOS.AutoSize = True
        Me.LRESULTADOS.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LRESULTADOS.Location = New System.Drawing.Point(158, 144)
        Me.LRESULTADOS.Name = "LRESULTADOS"
        Me.LRESULTADOS.Size = New System.Drawing.Size(13, 13)
        Me.LRESULTADOS.TabIndex = 11
        Me.LRESULTADOS.Text = "--"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTLIMPIAR)
        Me.GroupBox2.Controls.Add(Me.BTCALCULAR)
        Me.GroupBox2.Controls.Add(Me.BTSALIR)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox2.Location = New System.Drawing.Point(164, 213)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(222, 69)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ACCIONES"
        '
        'BTLIMPIAR
        '
        Me.BTLIMPIAR.BackColor = System.Drawing.Color.MediumSpringGreen
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
        Me.BTCALCULAR.BackColor = System.Drawing.Color.MediumSpringGreen
        Me.BTCALCULAR.Location = New System.Drawing.Point(16, 15)
        Me.BTCALCULAR.Name = "BTCALCULAR"
        Me.BTCALCULAR.Size = New System.Drawing.Size(78, 44)
        Me.BTCALCULAR.TabIndex = 0
        Me.BTCALCULAR.Text = " CALCULAR"
        Me.BTCALCULAR.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(399, 294)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LVENTA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LRESULTADOS)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Name = "Form1"
        Me.Text = "FABRICA"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXTSEDA As TextBox
    Friend WithEvents TXTALGODON As TextBox
    Friend WithEvents TXTLONA As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBLONA As CheckBox
    Friend WithEvents CBSEDA As CheckBox
    Friend WithEvents CBALGODON As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RBLARGE As RadioButton
    Friend WithEvents RBMEDIUM As RadioButton
    Friend WithEvents RBSMALL As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents LVENTA As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LRESULTADOS As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTLIMPIAR As Button
    Friend WithEvents BTCALCULAR As Button
    Friend WithEvents BTSALIR As Button
End Class
