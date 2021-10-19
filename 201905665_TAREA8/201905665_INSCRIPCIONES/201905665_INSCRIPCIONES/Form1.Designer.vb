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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTNOMBRE = New System.Windows.Forms.TextBox()
        Me.TXTCARNET = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RDBBASICOS = New System.Windows.Forms.RadioButton()
        Me.RDBDIVER = New System.Windows.Forms.RadioButton()
        Me.CMBDIVER = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CMBPAGO = New System.Windows.Forms.ComboBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TXTGENERAL = New System.Windows.Forms.TextBox()
        Me.TXTEFECTIVO = New System.Windows.Forms.TextBox()
        Me.TXTTARJETA = New System.Windows.Forms.TextBox()
        Me.TXTTRANSF = New System.Windows.Forms.TextBox()
        Me.TXTDEPOSITO = New System.Windows.Forms.TextBox()
        Me.TXTBASICOS = New System.Windows.Forms.TextBox()
        Me.TXTDIVER = New System.Windows.Forms.TextBox()
        Me.TXTPERITO = New System.Windows.Forms.TextBox()
        Me.TXTBACH = New System.Windows.Forms.TextBox()
        Me.TXTELEC = New System.Windows.Forms.TextBox()
        Me.TXTDISEÑO = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARDATOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARMATRIZToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULARTOTALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARTOTALESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(384, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INSCRIPCIONES COLEGIO CAMINO DEL SABER"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Khaki
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.MOSTRARDATOSToolStripMenuItem, Me.LIMPIARMATRIZToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.CALCULARTOTALESToolStripMenuItem, Me.LIMPIARTOTALESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1209, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TXTCARNET)
        Me.GroupBox1.Controls.Add(Me.TXTNOMBRE)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(249, 86)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DEL ESTUDIANTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre del alumno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(19, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Carnet"
        '
        'TXTNOMBRE
        '
        Me.TXTNOMBRE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNOMBRE.Location = New System.Drawing.Point(134, 27)
        Me.TXTNOMBRE.Name = "TXTNOMBRE"
        Me.TXTNOMBRE.Size = New System.Drawing.Size(100, 20)
        Me.TXTNOMBRE.TabIndex = 2
        '
        'TXTCARNET
        '
        Me.TXTCARNET.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTCARNET.Location = New System.Drawing.Point(134, 53)
        Me.TXTCARNET.Name = "TXTCARNET"
        Me.TXTCARNET.Size = New System.Drawing.Size(100, 20)
        Me.TXTCARNET.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CMBDIVER)
        Me.GroupBox2.Controls.Add(Me.RDBDIVER)
        Me.GroupBox2.Controls.Add(Me.RDBBASICOS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(287, 74)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(245, 86)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "NIVEL DE ESTUDIOS"
        '
        'RDBBASICOS
        '
        Me.RDBBASICOS.AutoSize = True
        Me.RDBBASICOS.Checked = True
        Me.RDBBASICOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBBASICOS.Location = New System.Drawing.Point(22, 30)
        Me.RDBBASICOS.Name = "RDBBASICOS"
        Me.RDBBASICOS.Size = New System.Drawing.Size(62, 17)
        Me.RDBBASICOS.TabIndex = 4
        Me.RDBBASICOS.TabStop = True
        Me.RDBBASICOS.Text = "Básicos"
        Me.RDBBASICOS.UseVisualStyleBackColor = True
        '
        'RDBDIVER
        '
        Me.RDBDIVER.AutoSize = True
        Me.RDBDIVER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBDIVER.Location = New System.Drawing.Point(22, 56)
        Me.RDBDIVER.Name = "RDBDIVER"
        Me.RDBDIVER.Size = New System.Drawing.Size(86, 17)
        Me.RDBDIVER.TabIndex = 5
        Me.RDBDIVER.Text = "Diversificado"
        Me.RDBDIVER.UseVisualStyleBackColor = True
        '
        'CMBDIVER
        '
        Me.CMBDIVER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBDIVER.FormattingEnabled = True
        Me.CMBDIVER.Items.AddRange(New Object() {"Perito Contador", "Bachillerato", "Electrónica", "Diseño Gráfico"})
        Me.CMBDIVER.Location = New System.Drawing.Point(119, 56)
        Me.CMBDIVER.Name = "CMBDIVER"
        Me.CMBDIVER.Size = New System.Drawing.Size(121, 21)
        Me.CMBDIVER.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.CMBPAGO)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(204, 166)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(150, 66)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FORMA DE PAGO"
        '
        'CMBPAGO
        '
        Me.CMBPAGO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBPAGO.FormattingEnabled = True
        Me.CMBPAGO.Items.AddRange(New Object() {"Efectivo", "Tarjeta de crédito", "Transferencia por ACH", "Depósito Bancario"})
        Me.CMBPAGO.Location = New System.Drawing.Point(17, 30)
        Me.CMBPAGO.Name = "CMBPAGO"
        Me.CMBPAGO.Size = New System.Drawing.Size(121, 21)
        Me.CMBPAGO.TabIndex = 6
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.TXTDISEÑO)
        Me.GroupBox4.Controls.Add(Me.TXTELEC)
        Me.GroupBox4.Controls.Add(Me.TXTBACH)
        Me.GroupBox4.Controls.Add(Me.TXTPERITO)
        Me.GroupBox4.Controls.Add(Me.TXTDIVER)
        Me.GroupBox4.Controls.Add(Me.TXTBASICOS)
        Me.GroupBox4.Controls.Add(Me.TXTDEPOSITO)
        Me.GroupBox4.Controls.Add(Me.TXTTRANSF)
        Me.GroupBox4.Controls.Add(Me.TXTTARJETA)
        Me.GroupBox4.Controls.Add(Me.TXTEFECTIVO)
        Me.GroupBox4.Controls.Add(Me.TXTGENERAL)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(765, 74)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(422, 374)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTALES"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Khaki
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total General (Q.)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Khaki
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total por forma de pago (Q.)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "* Efectivo"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(114, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "* Tarjeta de crédito"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(114, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "* Transferencia por ACH"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(114, 159)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "* Depósito Bancario"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Khaki
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(20, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Total por nivel (Q.)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(114, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 13)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "* Básicos"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(114, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 13)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "* Diversificado"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Khaki
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(20, 251)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Total inscritos por carrera"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(114, 272)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 13)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "* Perito Contador"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(114, 295)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "* Bachillerato"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(114, 321)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 13)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "* Electrónica"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(114, 347)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(100, 13)
        Me.Label17.TabIndex = 14
        Me.Label17.Text = "* Diseño Gráfico"
        '
        'TXTGENERAL
        '
        Me.TXTGENERAL.Enabled = False
        Me.TXTGENERAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTGENERAL.Location = New System.Drawing.Point(295, 30)
        Me.TXTGENERAL.Name = "TXTGENERAL"
        Me.TXTGENERAL.Size = New System.Drawing.Size(100, 20)
        Me.TXTGENERAL.TabIndex = 15
        '
        'TXTEFECTIVO
        '
        Me.TXTEFECTIVO.Enabled = False
        Me.TXTEFECTIVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEFECTIVO.Location = New System.Drawing.Point(295, 82)
        Me.TXTEFECTIVO.Name = "TXTEFECTIVO"
        Me.TXTEFECTIVO.Size = New System.Drawing.Size(100, 20)
        Me.TXTEFECTIVO.TabIndex = 16
        '
        'TXTTARJETA
        '
        Me.TXTTARJETA.Enabled = False
        Me.TXTTARJETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTARJETA.Location = New System.Drawing.Point(295, 107)
        Me.TXTTARJETA.Name = "TXTTARJETA"
        Me.TXTTARJETA.Size = New System.Drawing.Size(100, 20)
        Me.TXTTARJETA.TabIndex = 17
        '
        'TXTTRANSF
        '
        Me.TXTTRANSF.Enabled = False
        Me.TXTTRANSF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTRANSF.Location = New System.Drawing.Point(295, 132)
        Me.TXTTRANSF.Name = "TXTTRANSF"
        Me.TXTTRANSF.Size = New System.Drawing.Size(100, 20)
        Me.TXTTRANSF.TabIndex = 18
        '
        'TXTDEPOSITO
        '
        Me.TXTDEPOSITO.Enabled = False
        Me.TXTDEPOSITO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDEPOSITO.Location = New System.Drawing.Point(295, 156)
        Me.TXTDEPOSITO.Name = "TXTDEPOSITO"
        Me.TXTDEPOSITO.Size = New System.Drawing.Size(100, 20)
        Me.TXTDEPOSITO.TabIndex = 19
        '
        'TXTBASICOS
        '
        Me.TXTBASICOS.Enabled = False
        Me.TXTBASICOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBASICOS.Location = New System.Drawing.Point(295, 199)
        Me.TXTBASICOS.Name = "TXTBASICOS"
        Me.TXTBASICOS.Size = New System.Drawing.Size(100, 20)
        Me.TXTBASICOS.TabIndex = 20
        '
        'TXTDIVER
        '
        Me.TXTDIVER.Enabled = False
        Me.TXTDIVER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDIVER.Location = New System.Drawing.Point(295, 225)
        Me.TXTDIVER.Name = "TXTDIVER"
        Me.TXTDIVER.Size = New System.Drawing.Size(100, 20)
        Me.TXTDIVER.TabIndex = 21
        '
        'TXTPERITO
        '
        Me.TXTPERITO.Enabled = False
        Me.TXTPERITO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPERITO.Location = New System.Drawing.Point(295, 265)
        Me.TXTPERITO.Name = "TXTPERITO"
        Me.TXTPERITO.Size = New System.Drawing.Size(100, 20)
        Me.TXTPERITO.TabIndex = 22
        '
        'TXTBACH
        '
        Me.TXTBACH.Enabled = False
        Me.TXTBACH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTBACH.Location = New System.Drawing.Point(295, 289)
        Me.TXTBACH.Name = "TXTBACH"
        Me.TXTBACH.Size = New System.Drawing.Size(100, 20)
        Me.TXTBACH.TabIndex = 23
        '
        'TXTELEC
        '
        Me.TXTELEC.Enabled = False
        Me.TXTELEC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTELEC.Location = New System.Drawing.Point(295, 314)
        Me.TXTELEC.Name = "TXTELEC"
        Me.TXTELEC.Size = New System.Drawing.Size(100, 20)
        Me.TXTELEC.TabIndex = 24
        '
        'TXTDISEÑO
        '
        Me.TXTDISEÑO.Enabled = False
        Me.TXTDISEÑO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDISEÑO.Location = New System.Drawing.Point(295, 340)
        Me.TXTDISEÑO.Name = "TXTDISEÑO"
        Me.TXTDISEÑO.Size = New System.Drawing.Size(100, 20)
        Me.TXTDISEÑO.TabIndex = 25
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.Khaki
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView2.Location = New System.Drawing.Point(25, 247)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(720, 201)
        Me.DataGridView2.TabIndex = 10
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'MOSTRARDATOSToolStripMenuItem
        '
        Me.MOSTRARDATOSToolStripMenuItem.Name = "MOSTRARDATOSToolStripMenuItem"
        Me.MOSTRARDATOSToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.MOSTRARDATOSToolStripMenuItem.Text = "MOSTRAR DATOS"
        '
        'LIMPIARMATRIZToolStripMenuItem
        '
        Me.LIMPIARMATRIZToolStripMenuItem.Name = "LIMPIARMATRIZToolStripMenuItem"
        Me.LIMPIARMATRIZToolStripMenuItem.Size = New System.Drawing.Size(108, 20)
        Me.LIMPIARMATRIZToolStripMenuItem.Text = "LIMPIAR MATRIZ"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'CALCULARTOTALESToolStripMenuItem
        '
        Me.CALCULARTOTALESToolStripMenuItem.Name = "CALCULARTOTALESToolStripMenuItem"
        Me.CALCULARTOTALESToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.CALCULARTOTALESToolStripMenuItem.Text = "CALCULAR TOTALES"
        '
        'LIMPIARTOTALESToolStripMenuItem
        '
        Me.LIMPIARTOTALESToolStripMenuItem.Name = "LIMPIARTOTALESToolStripMenuItem"
        Me.LIMPIARTOTALESToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.LIMPIARTOTALESToolStripMenuItem.Text = "LIMPIAR TOTALES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Carnet"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nivel de estudios"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Carrera"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Forma de pago"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Pago Inicial "
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Pago inicial con recargo"
        Me.Column7.Name = "Column7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1209, 474)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARDATOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARMATRIZToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CALCULARTOTALESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARTOTALESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TXTCARNET As TextBox
    Friend WithEvents TXTNOMBRE As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CMBDIVER As ComboBox
    Friend WithEvents RDBDIVER As RadioButton
    Friend WithEvents RDBBASICOS As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CMBPAGO As ComboBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXTDISEÑO As TextBox
    Friend WithEvents TXTELEC As TextBox
    Friend WithEvents TXTBACH As TextBox
    Friend WithEvents TXTPERITO As TextBox
    Friend WithEvents TXTDIVER As TextBox
    Friend WithEvents TXTBASICOS As TextBox
    Friend WithEvents TXTDEPOSITO As TextBox
    Friend WithEvents TXTTRANSF As TextBox
    Friend WithEvents TXTTARJETA As TextBox
    Friend WithEvents TXTEFECTIVO As TextBox
    Friend WithEvents TXTGENERAL As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
