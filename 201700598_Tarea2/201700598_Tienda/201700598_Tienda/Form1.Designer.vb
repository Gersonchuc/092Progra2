<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtPagoTotal = New System.Windows.Forms.TextBox()
        Me.TXtDesc2 = New System.Windows.Forms.TextBox()
        Me.TxtDesc1 = New System.Windows.Forms.TextBox()
        Me.TxtIva = New System.Windows.Forms.TextBox()
        Me.TxtParcial = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtAzucar = New System.Windows.Forms.TextBox()
        Me.TxtFrijol = New System.Windows.Forms.TextBox()
        Me.TxtArroz = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.out = New System.Windows.Forms.Button()
        Me.Clear = New System.Windows.Forms.Button()
        Me.Calculos = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.LightCoral
        Me.GroupBox2.Controls.Add(Me.TxtPagoTotal)
        Me.GroupBox2.Controls.Add(Me.TXtDesc2)
        Me.GroupBox2.Controls.Add(Me.TxtDesc1)
        Me.GroupBox2.Controls.Add(Me.TxtIva)
        Me.GroupBox2.Controls.Add(Me.TxtParcial)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(310, 33)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 223)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pago a Realizar"
        '
        'TxtPagoTotal
        '
        Me.TxtPagoTotal.Location = New System.Drawing.Point(182, 178)
        Me.TxtPagoTotal.Name = "TxtPagoTotal"
        Me.TxtPagoTotal.Size = New System.Drawing.Size(100, 27)
        Me.TxtPagoTotal.TabIndex = 51
        '
        'TXtDesc2
        '
        Me.TXtDesc2.Location = New System.Drawing.Point(158, 141)
        Me.TXtDesc2.Name = "TXtDesc2"
        Me.TXtDesc2.Size = New System.Drawing.Size(100, 27)
        Me.TXtDesc2.TabIndex = 50
        '
        'TxtDesc1
        '
        Me.TxtDesc1.Location = New System.Drawing.Point(158, 101)
        Me.TxtDesc1.Name = "TxtDesc1"
        Me.TxtDesc1.Size = New System.Drawing.Size(100, 27)
        Me.TxtDesc1.TabIndex = 49
        '
        'TxtIva
        '
        Me.TxtIva.Location = New System.Drawing.Point(158, 64)
        Me.TxtIva.Name = "TxtIva"
        Me.TxtIva.Size = New System.Drawing.Size(100, 27)
        Me.TxtIva.TabIndex = 48
        '
        'TxtParcial
        '
        Me.TxtParcial.Location = New System.Drawing.Point(158, 22)
        Me.TxtParcial.Name = "TxtParcial"
        Me.TxtParcial.Size = New System.Drawing.Size(100, 27)
        Me.TxtParcial.TabIndex = 47
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 181)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 20)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "TOTAL A PAGAR:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 99)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 20)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Pago con IVA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 20)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "iva:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(29, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Descuento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Parcial:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Khaki
        Me.GroupBox1.Controls.Add(Me.TxtAzucar)
        Me.GroupBox1.Controls.Add(Me.TxtFrijol)
        Me.GroupBox1.Controls.Add(Me.TxtArroz)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(24, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 189)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso de  Libras"
        '
        'TxtAzucar
        '
        Me.TxtAzucar.Location = New System.Drawing.Point(127, 123)
        Me.TxtAzucar.Name = "TxtAzucar"
        Me.TxtAzucar.Size = New System.Drawing.Size(100, 27)
        Me.TxtAzucar.TabIndex = 37
        '
        'TxtFrijol
        '
        Me.TxtFrijol.Location = New System.Drawing.Point(127, 79)
        Me.TxtFrijol.Name = "TxtFrijol"
        Me.TxtFrijol.Size = New System.Drawing.Size(100, 27)
        Me.TxtFrijol.TabIndex = 36
        '
        'TxtArroz
        '
        Me.TxtArroz.Location = New System.Drawing.Point(127, 42)
        Me.TxtArroz.Name = "TxtArroz"
        Me.TxtArroz.Size = New System.Drawing.Size(100, 27)
        Me.TxtArroz.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Azucar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Frijol:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Arroz:"
        '
        'out
        '
        Me.out.BackColor = System.Drawing.Color.Yellow
        Me.out.Location = New System.Drawing.Point(662, 120)
        Me.out.Name = "out"
        Me.out.Size = New System.Drawing.Size(136, 47)
        Me.out.TabIndex = 49
        Me.out.Text = "SALIR"
        Me.out.UseVisualStyleBackColor = False
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.Aqua
        Me.Clear.Location = New System.Drawing.Point(662, 33)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(136, 41)
        Me.Clear.TabIndex = 48
        Me.Clear.Text = "LIMPIAR"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Calculos
        '
        Me.Calculos.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Calculos.Location = New System.Drawing.Point(24, 239)
        Me.Calculos.Name = "Calculos"
        Me.Calculos.Size = New System.Drawing.Size(137, 40)
        Me.Calculos.TabIndex = 47
        Me.Calculos.Text = "CALCULAR"
        Me.Calculos.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(810, 345)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.out)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Calculos)
        Me.Name = "Form1"
        Me.Text = "PAGO DE ARTICULOS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtPagoTotal As TextBox
    Friend WithEvents TXtDesc2 As TextBox
    Friend WithEvents TxtDesc1 As TextBox
    Friend WithEvents TxtIva As TextBox
    Friend WithEvents TxtParcial As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtAzucar As TextBox
    Friend WithEvents TxtFrijol As TextBox
    Friend WithEvents TxtArroz As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents out As Button
    Friend WithEvents Clear As Button
    Friend WithEvents Calculos As Button
End Class
