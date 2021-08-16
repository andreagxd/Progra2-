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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlbarroz = New System.Windows.Forms.TextBox()
        Me.txtlbfrijol = New System.Windows.Forms.TextBox()
        Me.txtlbazucar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtsiniva = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtiva = New System.Windows.Forms.TextBox()
        Me.txtpagoparcial = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtdescuento1 = New System.Windows.Forms.TextBox()
        Me.txtdescuento2 = New System.Windows.Forms.TextBox()
        Me.txttotalapagar = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(58, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ingrese cantidad de libras de arroz"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(58, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Ingrese cantidad de libras de frijol"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(58, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Ingrese cantidad de libras de azúcar"
        '
        'txtlbarroz
        '
        Me.txtlbarroz.Location = New System.Drawing.Point(251, 73)
        Me.txtlbarroz.Name = "txtlbarroz"
        Me.txtlbarroz.Size = New System.Drawing.Size(100, 20)
        Me.txtlbarroz.TabIndex = 3
        Me.txtlbarroz.Text = "0"
        '
        'txtlbfrijol
        '
        Me.txtlbfrijol.Location = New System.Drawing.Point(251, 107)
        Me.txtlbfrijol.Name = "txtlbfrijol"
        Me.txtlbfrijol.Size = New System.Drawing.Size(100, 20)
        Me.txtlbfrijol.TabIndex = 4
        Me.txtlbfrijol.Text = "0"
        '
        'txtlbazucar
        '
        Me.txtlbazucar.Location = New System.Drawing.Point(251, 139)
        Me.txtlbazucar.Name = "txtlbazucar"
        Me.txtlbazucar.Size = New System.Drawing.Size(100, 20)
        Me.txtlbazucar.TabIndex = 5
        Me.txtlbazucar.Text = "0"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(405, 62)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(58, 224)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total de la compra sin IVA "
        '
        'txtsiniva
        '
        Me.txtsiniva.Enabled = False
        Me.txtsiniva.Location = New System.Drawing.Point(251, 217)
        Me.txtsiniva.Name = "txtsiniva"
        Me.txtsiniva.Size = New System.Drawing.Size(100, 20)
        Me.txtsiniva.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(58, 250)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "IVA "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(58, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Pago parcial "
        '
        'txtiva
        '
        Me.txtiva.Enabled = False
        Me.txtiva.Location = New System.Drawing.Point(251, 243)
        Me.txtiva.Name = "txtiva"
        Me.txtiva.Size = New System.Drawing.Size(100, 20)
        Me.txtiva.TabIndex = 11
        '
        'txtpagoparcial
        '
        Me.txtpagoparcial.Enabled = False
        Me.txtpagoparcial.Location = New System.Drawing.Point(251, 269)
        Me.txtpagoparcial.Name = "txtpagoparcial"
        Me.txtpagoparcial.Size = New System.Drawing.Size(100, 20)
        Me.txtpagoparcial.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(58, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(161, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "INGRESO DE DATOS:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(58, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(179, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "DESGLOCE DEL TOTAL:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(58, 302)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Descuento 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(58, 328)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Descuento 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkRed
        Me.Label11.Location = New System.Drawing.Point(58, 370)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 16)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "TOTAL A PAGAR ="
        '
        'txtdescuento1
        '
        Me.txtdescuento1.Enabled = False
        Me.txtdescuento1.Location = New System.Drawing.Point(251, 295)
        Me.txtdescuento1.Name = "txtdescuento1"
        Me.txtdescuento1.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuento1.TabIndex = 18
        '
        'txtdescuento2
        '
        Me.txtdescuento2.Enabled = False
        Me.txtdescuento2.Location = New System.Drawing.Point(251, 321)
        Me.txtdescuento2.Name = "txtdescuento2"
        Me.txtdescuento2.Size = New System.Drawing.Size(100, 20)
        Me.txtdescuento2.TabIndex = 19
        '
        'txttotalapagar
        '
        Me.txttotalapagar.BackColor = System.Drawing.SystemColors.Window
        Me.txttotalapagar.Enabled = False
        Me.txttotalapagar.ForeColor = System.Drawing.Color.DarkRed
        Me.txttotalapagar.Location = New System.Drawing.Point(251, 366)
        Me.txttotalapagar.Name = "txttotalapagar"
        Me.txttotalapagar.Size = New System.Drawing.Size(100, 20)
        Me.txttotalapagar.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(405, 103)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Red
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(405, 146)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "Salir "
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(178, 19)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(186, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "TIENDA DE ABARROTES"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(540, 439)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txttotalapagar)
        Me.Controls.Add(Me.txtdescuento2)
        Me.Controls.Add(Me.txtdescuento1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtpagoparcial)
        Me.Controls.Add(Me.txtiva)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtsiniva)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtlbazucar)
        Me.Controls.Add(Me.txtlbfrijol)
        Me.Controls.Add(Me.txtlbarroz)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIENDA DE ABARROTES"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtlbarroz As TextBox
    Friend WithEvents txtlbfrijol As TextBox
    Friend WithEvents txtlbazucar As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtsiniva As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtiva As TextBox
    Friend WithEvents txtpagoparcial As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtdescuento1 As TextBox
    Friend WithEvents txtdescuento2 As TextBox
    Friend WithEvents txttotalapagar As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label12 As Label
End Class
