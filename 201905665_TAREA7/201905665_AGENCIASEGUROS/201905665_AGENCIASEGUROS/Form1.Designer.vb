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
        Me.CMBTALLER = New System.Windows.Forms.ComboBox()
        Me.TXTMONTO = New System.Windows.Forms.TextBox()
        Me.CMBREGISTRO = New System.Windows.Forms.ComboBox()
        Me.CMBGENERO = New System.Windows.Forms.ComboBox()
        Me.TXTEDAD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MOSTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTADÍSTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARESTADÍSTICASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTMENORES = New System.Windows.Forms.TextBox()
        Me.TXTEXTRANJEROS = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TXTFEMENINO = New System.Windows.Forms.TextBox()
        Me.TXTMASCULINO = New System.Windows.Forms.TextBox()
        Me.TXTTOTALCONDUCTORES = New System.Windows.Forms.TextBox()
        Me.TXTTOTALMONTO = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.LST6 = New System.Windows.Forms.ListBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.LST5 = New System.Windows.Forms.ListBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LST4 = New System.Windows.Forms.ListBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LST3 = New System.Windows.Forms.ListBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LST2 = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.LST1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CMBTALLER)
        Me.GroupBox1.Controls.Add(Me.TXTMONTO)
        Me.GroupBox1.Controls.Add(Me.CMBREGISTRO)
        Me.GroupBox1.Controls.Add(Me.CMBGENERO)
        Me.GroupBox1.Controls.Add(Me.TXTEDAD)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(29, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DATOS DE INGRESO"
        '
        'CMBTALLER
        '
        Me.CMBTALLER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBTALLER.FormattingEnabled = True
        Me.CMBTALLER.Items.AddRange(New Object() {"TALLER DE CONFIANZA", "TALLER INDICADO POR LA ASEGURADORA"})
        Me.CMBTALLER.Location = New System.Drawing.Point(196, 127)
        Me.CMBTALLER.Name = "CMBTALLER"
        Me.CMBTALLER.Size = New System.Drawing.Size(121, 21)
        Me.CMBTALLER.TabIndex = 7
        '
        'TXTMONTO
        '
        Me.TXTMONTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMONTO.Location = New System.Drawing.Point(196, 101)
        Me.TXTMONTO.Name = "TXTMONTO"
        Me.TXTMONTO.Size = New System.Drawing.Size(121, 20)
        Me.TXTMONTO.TabIndex = 6
        '
        'CMBREGISTRO
        '
        Me.CMBREGISTRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBREGISTRO.FormattingEnabled = True
        Me.CMBREGISTRO.Items.AddRange(New Object() {"0", "1"})
        Me.CMBREGISTRO.Location = New System.Drawing.Point(196, 74)
        Me.CMBREGISTRO.Name = "CMBREGISTRO"
        Me.CMBREGISTRO.Size = New System.Drawing.Size(121, 21)
        Me.CMBREGISTRO.TabIndex = 5
        '
        'CMBGENERO
        '
        Me.CMBGENERO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBGENERO.FormattingEnabled = True
        Me.CMBGENERO.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.CMBGENERO.Location = New System.Drawing.Point(196, 47)
        Me.CMBGENERO.Name = "CMBGENERO"
        Me.CMBGENERO.Size = New System.Drawing.Size(121, 21)
        Me.CMBGENERO.TabIndex = 4
        '
        'TXTEDAD
        '
        Me.TXTEDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEDAD.Location = New System.Drawing.Point(196, 21)
        Me.TXTEDAD.Name = "TXTEDAD"
        Me.TXTEDAD.Size = New System.Drawing.Size(121, 20)
        Me.TXTEDAD.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Taller"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Monto de daños ocasionados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Código de Registro"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Género "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Edad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(35, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 18)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ASEGURADORA"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Moccasin
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.MOSTRARToolStripMenuItem, Me.ESTADÍSTICASToolStripMenuItem, Me.LIMPIARESTADÍSTICASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(842, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'MOSTRARToolStripMenuItem
        '
        Me.MOSTRARToolStripMenuItem.BackColor = System.Drawing.Color.Moccasin
        Me.MOSTRARToolStripMenuItem.Name = "MOSTRARToolStripMenuItem"
        Me.MOSTRARToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.MOSTRARToolStripMenuItem.Text = "MOSTRAR"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'ESTADÍSTICASToolStripMenuItem
        '
        Me.ESTADÍSTICASToolStripMenuItem.Name = "ESTADÍSTICASToolStripMenuItem"
        Me.ESTADÍSTICASToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.ESTADÍSTICASToolStripMenuItem.Text = "ESTADÍSTICAS"
        '
        'LIMPIARESTADÍSTICASToolStripMenuItem
        '
        Me.LIMPIARESTADÍSTICASToolStripMenuItem.Name = "LIMPIARESTADÍSTICASToolStripMenuItem"
        Me.LIMPIARESTADÍSTICASToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.LIMPIARESTADÍSTICASToolStripMenuItem.Text = "LIMPIAR ESTADÍSTICAS"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(226, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "% de conductores menores de 25 años"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(22, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(224, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "% de conductores de género femenino"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(429, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "% de conductores de género masculino con edades entre los 18 y 25 años"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(239, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "% de conductores con registro extranjero"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Total de conductores ingresados"
        '
        'TXTMENORES
        '
        Me.TXTMENORES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMENORES.Location = New System.Drawing.Point(459, 21)
        Me.TXTMENORES.Name = "TXTMENORES"
        Me.TXTMENORES.Size = New System.Drawing.Size(121, 20)
        Me.TXTMENORES.TabIndex = 3
        '
        'TXTEXTRANJEROS
        '
        Me.TXTEXTRANJEROS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEXTRANJEROS.Location = New System.Drawing.Point(459, 101)
        Me.TXTEXTRANJEROS.Name = "TXTEXTRANJEROS"
        Me.TXTEXTRANJEROS.Size = New System.Drawing.Size(121, 20)
        Me.TXTEXTRANJEROS.TabIndex = 6
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(301, 13)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "El total (Q) de los montos de los daños ocasionados"
        '
        'TXTFEMENINO
        '
        Me.TXTFEMENINO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTFEMENINO.Location = New System.Drawing.Point(459, 47)
        Me.TXTFEMENINO.Name = "TXTFEMENINO"
        Me.TXTFEMENINO.Size = New System.Drawing.Size(121, 20)
        Me.TXTFEMENINO.TabIndex = 9
        '
        'TXTMASCULINO
        '
        Me.TXTMASCULINO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMASCULINO.Location = New System.Drawing.Point(459, 73)
        Me.TXTMASCULINO.Name = "TXTMASCULINO"
        Me.TXTMASCULINO.Size = New System.Drawing.Size(121, 20)
        Me.TXTMASCULINO.TabIndex = 10
        '
        'TXTTOTALCONDUCTORES
        '
        Me.TXTTOTALCONDUCTORES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALCONDUCTORES.Location = New System.Drawing.Point(459, 127)
        Me.TXTTOTALCONDUCTORES.Name = "TXTTOTALCONDUCTORES"
        Me.TXTTOTALCONDUCTORES.Size = New System.Drawing.Size(121, 20)
        Me.TXTTOTALCONDUCTORES.TabIndex = 11
        '
        'TXTTOTALMONTO
        '
        Me.TXTTOTALMONTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALMONTO.Location = New System.Drawing.Point(459, 153)
        Me.TXTTOTALMONTO.Name = "TXTTOTALMONTO"
        Me.TXTTOTALMONTO.Size = New System.Drawing.Size(121, 20)
        Me.TXTTOTALMONTO.TabIndex = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.TXTTOTALMONTO)
        Me.GroupBox2.Controls.Add(Me.TXTTOTALCONDUCTORES)
        Me.GroupBox2.Controls.Add(Me.TXTMASCULINO)
        Me.GroupBox2.Controls.Add(Me.TXTFEMENINO)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TXTEXTRANJEROS)
        Me.GroupBox2.Controls.Add(Me.TXTMENORES)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(161, 262)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(589, 191)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ESTADÍSTICAS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.LST6)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.LST5)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.LST4)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.LST3)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.LST2)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.LST1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(376, 68)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 182)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DEDUCIBLE"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(355, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(81, 13)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Q. Deducible"
        '
        'LST6
        '
        Me.LST6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST6.FormattingEnabled = True
        Me.LST6.Location = New System.Drawing.Point(364, 51)
        Me.LST6.Name = "LST6"
        Me.LST6.Size = New System.Drawing.Size(66, 95)
        Me.LST6.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(293, 35)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 13)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Taller"
        '
        'LST5
        '
        Me.LST5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST5.FormattingEnabled = True
        Me.LST5.Location = New System.Drawing.Point(272, 51)
        Me.LST5.Name = "LST5"
        Me.LST5.Size = New System.Drawing.Size(86, 95)
        Me.LST5.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(217, 35)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Monto"
        '
        'LST4
        '
        Me.LST4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST4.FormattingEnabled = True
        Me.LST4.Location = New System.Drawing.Point(210, 51)
        Me.LST4.Name = "LST4"
        Me.LST4.Size = New System.Drawing.Size(56, 95)
        Me.LST4.TabIndex = 13
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(155, 35)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 13)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Código"
        '
        'LST3
        '
        Me.LST3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST3.FormattingEnabled = True
        Me.LST3.Location = New System.Drawing.Point(148, 51)
        Me.LST3.Name = "LST3"
        Me.LST3.Size = New System.Drawing.Size(56, 95)
        Me.LST3.TabIndex = 11
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(83, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(48, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = "Género"
        '
        'LST2
        '
        Me.LST2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST2.FormattingEnabled = True
        Me.LST2.Location = New System.Drawing.Point(73, 51)
        Me.LST2.Name = "LST2"
        Me.LST2.Size = New System.Drawing.Size(69, 95)
        Me.LST2.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(23, 35)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(36, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Edad"
        '
        'LST1
        '
        Me.LST1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST1.FormattingEnabled = True
        Me.LST1.Location = New System.Drawing.Point(11, 51)
        Me.LST1.Name = "LST1"
        Me.LST1.Size = New System.Drawing.Size(56, 95)
        Me.LST1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(842, 459)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label6)
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
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMBTALLER As ComboBox
    Friend WithEvents TXTMONTO As TextBox
    Friend WithEvents CMBREGISTRO As ComboBox
    Friend WithEvents CMBGENERO As ComboBox
    Friend WithEvents TXTEDAD As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MOSTRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ESTADÍSTICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARESTADÍSTICASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTMENORES As TextBox
    Friend WithEvents TXTEXTRANJEROS As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TXTFEMENINO As TextBox
    Friend WithEvents TXTMASCULINO As TextBox
    Friend WithEvents TXTTOTALCONDUCTORES As TextBox
    Friend WithEvents TXTTOTALMONTO As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents LST6 As ListBox
    Friend WithEvents Label17 As Label
    Friend WithEvents LST5 As ListBox
    Friend WithEvents Label16 As Label
    Friend WithEvents LST4 As ListBox
    Friend WithEvents Label15 As Label
    Friend WithEvents LST3 As ListBox
    Friend WithEvents Label14 As Label
    Friend WithEvents LST2 As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents LST1 As ListBox
End Class
