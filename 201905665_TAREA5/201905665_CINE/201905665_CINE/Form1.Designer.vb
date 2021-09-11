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
        Me.CMBCINE = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CMBFUNCION = New System.Windows.Forms.ComboBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TXTENTRADAS = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LST3 = New System.Windows.Forms.ListBox()
        Me.LST7 = New System.Windows.Forms.ListBox()
        Me.LST2 = New System.Windows.Forms.ListBox()
        Me.LST6 = New System.Windows.Forms.ListBox()
        Me.LST1 = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LST5 = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LST4 = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BTNCALCULAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNLIMPIARLISTAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNLIMPIARENTRADAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNLIMPIARVECTORES = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTNSALIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CMBCINE)
        Me.GroupBox1.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(154, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CINE"
        '
        'CMBCINE
        '
        Me.CMBCINE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBCINE.FormattingEnabled = True
        Me.CMBCINE.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CMBCINE.Location = New System.Drawing.Point(6, 32)
        Me.CMBCINE.Name = "CMBCINE"
        Me.CMBCINE.Size = New System.Drawing.Size(121, 21)
        Me.CMBCINE.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CMBFUNCION)
        Me.GroupBox2.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(308, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 72)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FUNCIÓN"
        '
        'CMBFUNCION
        '
        Me.CMBFUNCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBFUNCION.FormattingEnabled = True
        Me.CMBFUNCION.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CMBFUNCION.Location = New System.Drawing.Point(6, 32)
        Me.CMBFUNCION.Name = "CMBFUNCION"
        Me.CMBFUNCION.Size = New System.Drawing.Size(121, 21)
        Me.CMBFUNCION.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TXTENTRADAS)
        Me.GroupBox3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(449, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(135, 72)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "NÚMERO DE ENTRADAS"
        '
        'TXTENTRADAS
        '
        Me.TXTENTRADAS.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTENTRADAS.Location = New System.Drawing.Point(6, 33)
        Me.TXTENTRADAS.Name = "TXTENTRADAS"
        Me.TXTENTRADAS.Size = New System.Drawing.Size(123, 20)
        Me.TXTENTRADAS.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.LST3)
        Me.GroupBox4.Controls.Add(Me.LST7)
        Me.GroupBox4.Controls.Add(Me.LST2)
        Me.GroupBox4.Controls.Add(Me.LST6)
        Me.GroupBox4.Controls.Add(Me.LST1)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.LST5)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.LST4)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.White
        Me.GroupBox4.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(714, 195)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "TOTAL"
        '
        'LST3
        '
        Me.LST3.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST3.FormattingEnabled = True
        Me.LST3.ItemHeight = 14
        Me.LST3.Location = New System.Drawing.Point(212, 58)
        Me.LST3.Name = "LST3"
        Me.LST3.Size = New System.Drawing.Size(83, 116)
        Me.LST3.TabIndex = 13
        '
        'LST7
        '
        Me.LST7.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST7.FormattingEnabled = True
        Me.LST7.ItemHeight = 14
        Me.LST7.Location = New System.Drawing.Point(587, 58)
        Me.LST7.Name = "LST7"
        Me.LST7.Size = New System.Drawing.Size(83, 116)
        Me.LST7.TabIndex = 7
        '
        'LST2
        '
        Me.LST2.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST2.FormattingEnabled = True
        Me.LST2.ItemHeight = 14
        Me.LST2.Location = New System.Drawing.Point(116, 58)
        Me.LST2.Name = "LST2"
        Me.LST2.Size = New System.Drawing.Size(83, 116)
        Me.LST2.TabIndex = 12
        '
        'LST6
        '
        Me.LST6.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST6.FormattingEnabled = True
        Me.LST6.ItemHeight = 14
        Me.LST6.Location = New System.Drawing.Point(491, 58)
        Me.LST6.Name = "LST6"
        Me.LST6.Size = New System.Drawing.Size(83, 116)
        Me.LST6.TabIndex = 6
        '
        'LST1
        '
        Me.LST1.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST1.FormattingEnabled = True
        Me.LST1.ItemHeight = 14
        Me.LST1.Location = New System.Drawing.Point(22, 58)
        Me.LST1.Name = "LST1"
        Me.LST1.Size = New System.Drawing.Size(83, 116)
        Me.LST1.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(222, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Entradas"
        '
        'LST5
        '
        Me.LST5.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST5.FormattingEnabled = True
        Me.LST5.ItemHeight = 14
        Me.LST5.Location = New System.Drawing.Point(397, 58)
        Me.LST5.Name = "LST5"
        Me.LST5.Size = New System.Drawing.Size(83, 116)
        Me.LST5.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(126, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Función"
        '
        'LST4
        '
        Me.LST4.Font = New System.Drawing.Font("Rockwell", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LST4.FormattingEnabled = True
        Me.LST4.ItemHeight = 14
        Me.LST4.Location = New System.Drawing.Point(304, 58)
        Me.LST4.Name = "LST4"
        Me.LST4.Size = New System.Drawing.Size(84, 116)
        Me.LST4.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(41, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 15)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Cine"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(601, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TOTAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(490, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descuento 2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(396, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Descuento 1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Rockwell", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ENTRADAS DE CINE"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTNCALCULAR, Me.BTNLIMPIARLISTAS, Me.BTNLIMPIARENTRADAS, Me.BTNLIMPIARVECTORES, Me.BTNSALIR})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(826, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BTNCALCULAR
        '
        Me.BTNCALCULAR.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTNCALCULAR.Name = "BTNCALCULAR"
        Me.BTNCALCULAR.Size = New System.Drawing.Size(78, 20)
        Me.BTNCALCULAR.Text = "CALCULAR"
        '
        'BTNLIMPIARLISTAS
        '
        Me.BTNLIMPIARLISTAS.BackColor = System.Drawing.Color.White
        Me.BTNLIMPIARLISTAS.Name = "BTNLIMPIARLISTAS"
        Me.BTNLIMPIARLISTAS.Size = New System.Drawing.Size(101, 20)
        Me.BTNLIMPIARLISTAS.Text = "LIMPIAR LISTAS"
        '
        'BTNLIMPIARENTRADAS
        '
        Me.BTNLIMPIARENTRADAS.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTNLIMPIARENTRADAS.Name = "BTNLIMPIARENTRADAS"
        Me.BTNLIMPIARENTRADAS.Size = New System.Drawing.Size(125, 20)
        Me.BTNLIMPIARENTRADAS.Text = "LIMPIAR ENTRADAS"
        '
        'BTNLIMPIARVECTORES
        '
        Me.BTNLIMPIARVECTORES.BackColor = System.Drawing.Color.White
        Me.BTNLIMPIARVECTORES.Name = "BTNLIMPIARVECTORES"
        Me.BTNLIMPIARVECTORES.Size = New System.Drawing.Size(121, 20)
        Me.BTNLIMPIARVECTORES.Text = "LIMPIAR VECTORES"
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.LemonChiffon
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(49, 20)
        Me.BTNSALIR.Text = "SALIR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(826, 380)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CMBCINE As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents CMBFUNCION As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LST7 As ListBox
    Friend WithEvents LST6 As ListBox
    Friend WithEvents LST5 As ListBox
    Friend WithEvents LST4 As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BTNCALCULAR As ToolStripMenuItem
    Friend WithEvents BTNLIMPIARLISTAS As ToolStripMenuItem
    Friend WithEvents BTNLIMPIARENTRADAS As ToolStripMenuItem
    Friend WithEvents BTNLIMPIARVECTORES As ToolStripMenuItem
    Friend WithEvents BTNSALIR As ToolStripMenuItem
    Friend WithEvents TXTENTRADAS As TextBox
    Friend WithEvents LST3 As ListBox
    Friend WithEvents LST2 As ListBox
    Friend WithEvents LST1 As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
