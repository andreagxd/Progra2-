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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TXTCONSUMOMENSUAL = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TXTSALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BTNCALCULAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNLIMPIARENTRADAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNLIMPIARLISTAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNLIMPIARVECTORES = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNSALIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LST2 = New System.Windows.Forms.ListBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LST1 = New System.Windows.Forms.ListBox()
        Me.LST9 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LST8 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LST7 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LST6 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LST5 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LST4 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LST3 = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CMBSERVICIO = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CMBTARIFA = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TXTCONSUMOMENSUAL)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TXTSALDOANTERIOR)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TXTNIT)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(357, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(287, 142)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS"
        '
        'TXTCONSUMOMENSUAL
        '
        Me.TXTCONSUMOMENSUAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCONSUMOMENSUAL.Location = New System.Drawing.Point(154, 108)
        Me.TXTCONSUMOMENSUAL.Name = "TXTCONSUMOMENSUAL"
        Me.TXTCONSUMOMENSUAL.Size = New System.Drawing.Size(119, 20)
        Me.TXTCONSUMOMENSUAL.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Consumo en un mes (kWatt)"
        '
        'TXTSALDOANTERIOR
        '
        Me.TXTSALDOANTERIOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSALDOANTERIOR.Location = New System.Drawing.Point(154, 77)
        Me.TXTSALDOANTERIOR.Name = "TXTSALDOANTERIOR"
        Me.TXTSALDOANTERIOR.Size = New System.Drawing.Size(119, 20)
        Me.TXTSALDOANTERIOR.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Saldo Anterior"
        '
        'TXTNIT
        '
        Me.TXTNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNIT.Location = New System.Drawing.Point(154, 48)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(119, 20)
        Me.TXTNIT.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIT"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMBRE.Location = New System.Drawing.Point(154, 19)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(119, 20)
        Me.TXTNOMBRE.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNCALCULAR, Me.BTNLIMPIARENTRADAS, Me.BTNLIMPIARLISTAS, Me.BTNLIMPIARVECTORES, Me.BTNSALIR})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1112, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BTNCALCULAR
        '
        Me.BTNCALCULAR.Name = "BTNCALCULAR"
        Me.BTNCALCULAR.Size = New System.Drawing.Size(78, 20)
        Me.BTNCALCULAR.Text = "CALCULAR"
        '
        'BTNLIMPIARENTRADAS
        '
        Me.BTNLIMPIARENTRADAS.Name = "BTNLIMPIARENTRADAS"
        Me.BTNLIMPIARENTRADAS.Size = New System.Drawing.Size(125, 20)
        Me.BTNLIMPIARENTRADAS.Text = "LIMPIAR ENTRADAS"
        '
        'BTNLIMPIARLISTAS
        '
        Me.BTNLIMPIARLISTAS.Name = "BTNLIMPIARLISTAS"
        Me.BTNLIMPIARLISTAS.Size = New System.Drawing.Size(101, 20)
        Me.BTNLIMPIARLISTAS.Text = "LIMPIAR LISTAS"
        '
        'BTNLIMPIARVECTORES
        '
        Me.BTNLIMPIARVECTORES.Name = "BTNLIMPIARVECTORES"
        Me.BTNLIMPIARVECTORES.Size = New System.Drawing.Size(121, 20)
        Me.BTNLIMPIARVECTORES.Text = "LIMPIAR VECTORES"
        '
        'BTNSALIR
        '
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(49, 20)
        Me.BTNSALIR.Text = "SALIR"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.LST2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.LST1)
        Me.GroupBox2.Controls.Add(Me.LST9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.LST8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.LST7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LST6)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LST5)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.LST4)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.LST3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1079, 182)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(167, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(28, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "NIT"
        '
        'LST2
        '
        Me.LST2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST2.FormattingEnabled = True
        Me.LST2.Location = New System.Drawing.Point(134, 40)
        Me.LST2.Name = "LST2"
        Me.LST2.Size = New System.Drawing.Size(100, 121)
        Me.LST2.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "NOMBRE"
        '
        'LST1
        '
        Me.LST1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST1.FormattingEnabled = True
        Me.LST1.Location = New System.Drawing.Point(16, 40)
        Me.LST1.Name = "LST1"
        Me.LST1.Size = New System.Drawing.Size(100, 121)
        Me.LST1.TabIndex = 20
        '
        'LST9
        '
        Me.LST9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST9.FormattingEnabled = True
        Me.LST9.Location = New System.Drawing.Point(960, 40)
        Me.LST9.Name = "LST9"
        Me.LST9.Size = New System.Drawing.Size(100, 121)
        Me.LST9.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(957, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "PAGO TOTAL"
        '
        'LST8
        '
        Me.LST8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST8.FormattingEnabled = True
        Me.LST8.Location = New System.Drawing.Point(841, 40)
        Me.LST8.Name = "LST8"
        Me.LST8.Size = New System.Drawing.Size(100, 121)
        Me.LST8.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(852, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "DESCUENTO"
        '
        'LST7
        '
        Me.LST7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST7.FormattingEnabled = True
        Me.LST7.Location = New System.Drawing.Point(724, 40)
        Me.LST7.Name = "LST7"
        Me.LST7.Size = New System.Drawing.Size(100, 121)
        Me.LST7.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(753, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "MORA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(609, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "PAGO INICIAL"
        '
        'LST6
        '
        Me.LST6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST6.FormattingEnabled = True
        Me.LST6.Location = New System.Drawing.Point(603, 40)
        Me.LST6.Name = "LST6"
        Me.LST6.Size = New System.Drawing.Size(100, 121)
        Me.LST6.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(478, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "SALDO ANTERIOR"
        '
        'LST5
        '
        Me.LST5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST5.FormattingEnabled = True
        Me.LST5.Location = New System.Drawing.Point(481, 40)
        Me.LST5.Name = "LST5"
        Me.LST5.Size = New System.Drawing.Size(99, 121)
        Me.LST5.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(360, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TIPO DE TARIFA"
        '
        'LST4
        '
        Me.LST4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST4.FormattingEnabled = True
        Me.LST4.Location = New System.Drawing.Point(372, 40)
        Me.LST4.Name = "LST4"
        Me.LST4.Size = New System.Drawing.Size(88, 121)
        Me.LST4.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "TIPO DE SERVICIO"
        '
        'LST3
        '
        Me.LST3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST3.FormattingEnabled = True
        Me.LST3.Location = New System.Drawing.Point(249, 40)
        Me.LST3.Name = "LST3"
        Me.LST3.Size = New System.Drawing.Size(100, 121)
        Me.LST3.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CMBSERVICIO)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(650, 58)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(163, 56)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TIPO DE SERVICIO"
        '
        'CMBSERVICIO
        '
        Me.CMBSERVICIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBSERVICIO.FormattingEnabled = True
        Me.CMBSERVICIO.Items.AddRange(New Object() {"RESIDENCIAL", "INDUSTRIAL"})
        Me.CMBSERVICIO.Location = New System.Drawing.Point(14, 21)
        Me.CMBSERVICIO.Name = "CMBSERVICIO"
        Me.CMBSERVICIO.Size = New System.Drawing.Size(121, 21)
        Me.CMBSERVICIO.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.CMBTARIFA)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(650, 120)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(163, 56)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TIPO DE TARIFA"
        '
        'CMBTARIFA
        '
        Me.CMBTARIFA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBTARIFA.FormattingEnabled = True
        Me.CMBTARIFA.Items.AddRange(New Object() {"SOCIAL", "NO SOCIAL"})
        Me.CMBTARIFA.Location = New System.Drawing.Point(14, 21)
        Me.CMBTARIFA.Name = "CMBTARIFA"
        Me.CMBTARIFA.Size = New System.Drawing.Size(121, 21)
        Me.CMBTARIFA.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1112, 441)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTSALDOANTERIOR As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BTNCALCULAR As ToolStripMenuItem
    Friend WithEvents BTNLIMPIARENTRADAS As ToolStripMenuItem
    Friend WithEvents BTNLIMPIARLISTAS As ToolStripMenuItem
    Friend WithEvents BTNLIMPIARVECTORES As ToolStripMenuItem
    Friend WithEvents BTNSALIR As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LST9 As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LST8 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LST7 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LST6 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LST5 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LST4 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LST3 As ListBox
    Friend WithEvents TXTCONSUMOMENSUAL As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CMBSERVICIO As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CMBTARIFA As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LST2 As ListBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LST1 As ListBox
End Class
