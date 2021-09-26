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
        Me.LBLRENTAUTOS = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LBLNIT = New System.Windows.Forms.Label()
        Me.TXTNIT = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBLDIAS = New System.Windows.Forms.Label()
        Me.TXTDIAS = New System.Windows.Forms.TextBox()
        Me.CMBMARCA = New System.Windows.Forms.ComboBox()
        Me.LBLMARCA = New System.Windows.Forms.Label()
        Me.LBLNUMPLACA = New System.Windows.Forms.Label()
        Me.TXTNUMPLACA = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CHKTARJETA = New System.Windows.Forms.CheckBox()
        Me.TXTTARJETA = New System.Windows.Forms.TextBox()
        Me.CHKEFECTIVO = New System.Windows.Forms.CheckBox()
        Me.TXTEFECTIVO = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PROCESOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LST7 = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LST6 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LST5 = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LST4 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LST3 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LST2 = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LST1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBLRENTAUTOS
        '
        Me.LBLRENTAUTOS.AutoSize = True
        Me.LBLRENTAUTOS.BackColor = System.Drawing.Color.Transparent
        Me.LBLRENTAUTOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLRENTAUTOS.ForeColor = System.Drawing.Color.White
        Me.LBLRENTAUTOS.Location = New System.Drawing.Point(33, 40)
        Me.LBLRENTAUTOS.Name = "LBLRENTAUTOS"
        Me.LBLRENTAUTOS.Size = New System.Drawing.Size(190, 24)
        Me.LBLRENTAUTOS.TabIndex = 0
        Me.LBLRENTAUTOS.Text = "RENTA DE AUTOS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.LBLNIT)
        Me.GroupBox1.Controls.Add(Me.TXTNIT)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(317, 42)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 52)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INGRESO DE DATOS DEL CLIENTE"
        '
        'LBLNIT
        '
        Me.LBLNIT.AutoSize = True
        Me.LBLNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNIT.Location = New System.Drawing.Point(22, 28)
        Me.LBLNIT.Name = "LBLNIT"
        Me.LBLNIT.Size = New System.Drawing.Size(28, 13)
        Me.LBLNIT.TabIndex = 1
        Me.LBLNIT.Text = "NIT"
        '
        'TXTNIT
        '
        Me.TXTNIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNIT.Location = New System.Drawing.Point(129, 21)
        Me.TXTNIT.Name = "TXTNIT"
        Me.TXTNIT.Size = New System.Drawing.Size(116, 20)
        Me.TXTNIT.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.LBLDIAS)
        Me.GroupBox2.Controls.Add(Me.TXTDIAS)
        Me.GroupBox2.Controls.Add(Me.CMBMARCA)
        Me.GroupBox2.Controls.Add(Me.LBLMARCA)
        Me.GroupBox2.Controls.Add(Me.LBLNUMPLACA)
        Me.GroupBox2.Controls.Add(Me.TXTNUMPLACA)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(175, 100)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 113)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "INGRESO DE DATOS DEL AUTO A RENTAR"
        '
        'LBLDIAS
        '
        Me.LBLDIAS.AutoSize = True
        Me.LBLDIAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDIAS.Location = New System.Drawing.Point(22, 84)
        Me.LBLDIAS.Name = "LBLDIAS"
        Me.LBLDIAS.Size = New System.Drawing.Size(88, 13)
        Me.LBLDIAS.TabIndex = 7
        Me.LBLDIAS.Text = "Dias a alquilar"
        '
        'TXTDIAS
        '
        Me.TXTDIAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTDIAS.Location = New System.Drawing.Point(129, 77)
        Me.TXTDIAS.Name = "TXTDIAS"
        Me.TXTDIAS.Size = New System.Drawing.Size(140, 20)
        Me.TXTDIAS.TabIndex = 6
        '
        'CMBMARCA
        '
        Me.CMBMARCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMARCA.FormattingEnabled = True
        Me.CMBMARCA.Items.AddRange(New Object() {"HONDA", "MERCEDES BENZ", "TOYOTA ", "MAZDA"})
        Me.CMBMARCA.Location = New System.Drawing.Point(129, 50)
        Me.CMBMARCA.Name = "CMBMARCA"
        Me.CMBMARCA.Size = New System.Drawing.Size(140, 21)
        Me.CMBMARCA.TabIndex = 5
        '
        'LBLMARCA
        '
        Me.LBLMARCA.AutoSize = True
        Me.LBLMARCA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMARCA.Location = New System.Drawing.Point(22, 58)
        Me.LBLMARCA.Name = "LBLMARCA"
        Me.LBLMARCA.Size = New System.Drawing.Size(42, 13)
        Me.LBLMARCA.TabIndex = 4
        Me.LBLMARCA.Text = "Marca"
        '
        'LBLNUMPLACA
        '
        Me.LBLNUMPLACA.AutoSize = True
        Me.LBLNUMPLACA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNUMPLACA.Location = New System.Drawing.Point(22, 31)
        Me.LBLNUMPLACA.Name = "LBLNUMPLACA"
        Me.LBLNUMPLACA.Size = New System.Drawing.Size(104, 13)
        Me.LBLNUMPLACA.TabIndex = 3
        Me.LBLNUMPLACA.Text = "Número de Placa"
        '
        'TXTNUMPLACA
        '
        Me.TXTNUMPLACA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTNUMPLACA.Location = New System.Drawing.Point(129, 24)
        Me.TXTNUMPLACA.Name = "TXTNUMPLACA"
        Me.TXTNUMPLACA.Size = New System.Drawing.Size(140, 20)
        Me.TXTNUMPLACA.TabIndex = 2
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.CHKTARJETA)
        Me.GroupBox3.Controls.Add(Me.TXTTARJETA)
        Me.GroupBox3.Controls.Add(Me.CHKEFECTIVO)
        Me.GroupBox3.Controls.Add(Me.TXTEFECTIVO)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(481, 100)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 113)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "MÉTODO PAGO"
        '
        'CHKTARJETA
        '
        Me.CHKTARJETA.AutoSize = True
        Me.CHKTARJETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKTARJETA.Location = New System.Drawing.Point(23, 61)
        Me.CHKTARJETA.Name = "CHKTARJETA"
        Me.CHKTARJETA.Size = New System.Drawing.Size(87, 17)
        Me.CHKTARJETA.TabIndex = 6
        Me.CHKTARJETA.Text = "Tarjeta (%)"
        Me.CHKTARJETA.UseVisualStyleBackColor = True
        '
        'TXTTARJETA
        '
        Me.TXTTARJETA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTARJETA.Location = New System.Drawing.Point(129, 58)
        Me.TXTTARJETA.Name = "TXTTARJETA"
        Me.TXTTARJETA.Size = New System.Drawing.Size(140, 20)
        Me.TXTTARJETA.TabIndex = 5
        Me.TXTTARJETA.Visible = False
        '
        'CHKEFECTIVO
        '
        Me.CHKEFECTIVO.AutoSize = True
        Me.CHKEFECTIVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKEFECTIVO.Location = New System.Drawing.Point(23, 35)
        Me.CHKEFECTIVO.Name = "CHKEFECTIVO"
        Me.CHKEFECTIVO.Size = New System.Drawing.Size(94, 17)
        Me.CHKEFECTIVO.TabIndex = 4
        Me.CHKEFECTIVO.Text = "Efectivo (%)"
        Me.CHKEFECTIVO.UseVisualStyleBackColor = True
        '
        'TXTEFECTIVO
        '
        Me.TXTEFECTIVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTEFECTIVO.Location = New System.Drawing.Point(129, 32)
        Me.TXTEFECTIVO.Name = "TXTEFECTIVO"
        Me.TXTEFECTIVO.Size = New System.Drawing.Size(140, 20)
        Me.TXTEFECTIVO.TabIndex = 2
        Me.TXTEFECTIVO.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROCESOSToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.SALIRToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(893, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PROCESOSToolStripMenuItem
        '
        Me.PROCESOSToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.PROCESOSToolStripMenuItem.Name = "PROCESOSToolStripMenuItem"
        Me.PROCESOSToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.PROCESOSToolStripMenuItem.Text = "PROCESOS"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.BackColor = System.Drawing.Color.Linen
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(125, 20)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.BackColor = System.Drawing.Color.White
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'SALIRToolStripMenuItem
        '
        Me.SALIRToolStripMenuItem.BackColor = System.Drawing.Color.Linen
        Me.SALIRToolStripMenuItem.Name = "SALIRToolStripMenuItem"
        Me.SALIRToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.SALIRToolStripMenuItem.Text = "SALIR"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.LST7)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.LST6)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.LST5)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.LST4)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.LST3)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.LST2)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.LST1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(28, 226)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(842, 155)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(747, 25)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(47, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "TOTAL"
        '
        'LST7
        '
        Me.LST7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST7.FormattingEnabled = True
        Me.LST7.Location = New System.Drawing.Point(716, 41)
        Me.LST7.Name = "LST7"
        Me.LST7.Size = New System.Drawing.Size(108, 95)
        Me.LST7.TabIndex = 12
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(611, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "DESCUENTO"
        '
        'LST6
        '
        Me.LST6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST6.FormattingEnabled = True
        Me.LST6.Location = New System.Drawing.Point(601, 41)
        Me.LST6.Name = "LST6"
        Me.LST6.Size = New System.Drawing.Size(108, 95)
        Me.LST6.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(491, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "PAGO PARCIAL"
        '
        'LST5
        '
        Me.LST5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST5.FormattingEnabled = True
        Me.LST5.Location = New System.Drawing.Point(485, 41)
        Me.LST5.Name = "LST5"
        Me.LST5.Size = New System.Drawing.Size(108, 95)
        Me.LST5.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(366, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "DIAS A ALQUILAR"
        '
        'LST4
        '
        Me.LST4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST4.FormattingEnabled = True
        Me.LST4.Location = New System.Drawing.Point(370, 41)
        Me.LST4.Name = "LST4"
        Me.LST4.Size = New System.Drawing.Size(108, 95)
        Me.LST4.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(282, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "MARCA"
        '
        'LST3
        '
        Me.LST3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST3.FormattingEnabled = True
        Me.LST3.Location = New System.Drawing.Point(254, 41)
        Me.LST3.Name = "LST3"
        Me.LST3.Size = New System.Drawing.Size(108, 95)
        Me.LST3.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(167, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "PLACA"
        '
        'LST2
        '
        Me.LST2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST2.FormattingEnabled = True
        Me.LST2.Location = New System.Drawing.Point(139, 41)
        Me.LST2.Name = "LST2"
        Me.LST2.Size = New System.Drawing.Size(108, 95)
        Me.LST2.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "NIT"
        '
        'LST1
        '
        Me.LST1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST1.FormattingEnabled = True
        Me.LST1.Location = New System.Drawing.Point(23, 41)
        Me.LST1.Name = "LST1"
        Me.LST1.Size = New System.Drawing.Size(108, 95)
        Me.LST1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "*Nota: El pago 100% con tarjeta tiene un recargo del 2.5%*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(893, 414)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBLRENTAUTOS)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBLRENTAUTOS As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LBLNIT As Label
    Friend WithEvents TXTNIT As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LBLDIAS As Label
    Friend WithEvents TXTDIAS As TextBox
    Friend WithEvents CMBMARCA As ComboBox
    Friend WithEvents LBLMARCA As Label
    Friend WithEvents LBLNUMPLACA As Label
    Friend WithEvents TXTNUMPLACA As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CHKTARJETA As CheckBox
    Friend WithEvents TXTTARJETA As TextBox
    Friend WithEvents CHKEFECTIVO As CheckBox
    Friend WithEvents TXTEFECTIVO As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PROCESOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SALIRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents LST7 As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents LST6 As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LST5 As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents LST4 As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents LST3 As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents LST2 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents LST1 As ListBox
    Friend WithEvents Label1 As Label
End Class
