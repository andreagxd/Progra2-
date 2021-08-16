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
        Me.RDB_AHORRO = New System.Windows.Forms.RadioButton()
        Me.RDB_MONETARIOPREMIER = New System.Windows.Forms.RadioButton()
        Me.RDB_MONETARIO = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CHK_EFECTIVO = New System.Windows.Forms.CheckBox()
        Me.CHK_CHEQUESOTROSBANCOS = New System.Windows.Forms.CheckBox()
        Me.CHK_CHEQUESPROPIOS = New System.Windows.Forms.CheckBox()
        Me.TXT_TOTALADEPOSITAR = New System.Windows.Forms.TextBox()
        Me.TXT_EFECTIVO = New System.Windows.Forms.TextBox()
        Me.TXT_CHEQUESOTROSBANCOS = New System.Windows.Forms.TextBox()
        Me.TXT_CHEQUESPROPIOS = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTN_SALIR = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TXT_INTERES = New System.Windows.Forms.TextBox()
        Me.BTN_LIMPIAR = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BTN_CALCULAR = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TXT_SALDONUEVO = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TXT_SALDOANTERIOR = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RDB_AHORRO)
        Me.GroupBox1.Controls.Add(Me.RDB_MONETARIOPREMIER)
        Me.GroupBox1.Controls.Add(Me.RDB_MONETARIO)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 135)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TIPO DE DEPOSITO"
        '
        'RDB_AHORRO
        '
        Me.RDB_AHORRO.AutoSize = True
        Me.RDB_AHORRO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_AHORRO.Location = New System.Drawing.Point(26, 99)
        Me.RDB_AHORRO.Name = "RDB_AHORRO"
        Me.RDB_AHORRO.Size = New System.Drawing.Size(56, 17)
        Me.RDB_AHORRO.TabIndex = 2
        Me.RDB_AHORRO.TabStop = True
        Me.RDB_AHORRO.Text = "Ahorro"
        Me.RDB_AHORRO.UseVisualStyleBackColor = True
        '
        'RDB_MONETARIOPREMIER
        '
        Me.RDB_MONETARIOPREMIER.AutoSize = True
        Me.RDB_MONETARIOPREMIER.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_MONETARIOPREMIER.Location = New System.Drawing.Point(26, 63)
        Me.RDB_MONETARIOPREMIER.Name = "RDB_MONETARIOPREMIER"
        Me.RDB_MONETARIOPREMIER.Size = New System.Drawing.Size(110, 17)
        Me.RDB_MONETARIOPREMIER.TabIndex = 1
        Me.RDB_MONETARIOPREMIER.TabStop = True
        Me.RDB_MONETARIOPREMIER.Text = "Monetario Premier"
        Me.RDB_MONETARIOPREMIER.UseVisualStyleBackColor = True
        '
        'RDB_MONETARIO
        '
        Me.RDB_MONETARIO.AutoSize = True
        Me.RDB_MONETARIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDB_MONETARIO.Location = New System.Drawing.Point(26, 28)
        Me.RDB_MONETARIO.Name = "RDB_MONETARIO"
        Me.RDB_MONETARIO.Size = New System.Drawing.Size(72, 17)
        Me.RDB_MONETARIO.TabIndex = 0
        Me.RDB_MONETARIO.TabStop = True
        Me.RDB_MONETARIO.Text = "Monetario"
        Me.RDB_MONETARIO.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CHK_EFECTIVO)
        Me.GroupBox2.Controls.Add(Me.CHK_CHEQUESOTROSBANCOS)
        Me.GroupBox2.Controls.Add(Me.CHK_CHEQUESPROPIOS)
        Me.GroupBox2.Location = New System.Drawing.Point(171, 26)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(171, 135)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "MÉTODO DE DEPOSITO"
        '
        'CHK_EFECTIVO
        '
        Me.CHK_EFECTIVO.AutoSize = True
        Me.CHK_EFECTIVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_EFECTIVO.Location = New System.Drawing.Point(24, 99)
        Me.CHK_EFECTIVO.Name = "CHK_EFECTIVO"
        Me.CHK_EFECTIVO.Size = New System.Drawing.Size(65, 17)
        Me.CHK_EFECTIVO.TabIndex = 2
        Me.CHK_EFECTIVO.Text = "Efectivo"
        Me.CHK_EFECTIVO.UseVisualStyleBackColor = True
        '
        'CHK_CHEQUESOTROSBANCOS
        '
        Me.CHK_CHEQUESOTROSBANCOS.AutoSize = True
        Me.CHK_CHEQUESOTROSBANCOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_CHEQUESOTROSBANCOS.Location = New System.Drawing.Point(24, 63)
        Me.CHK_CHEQUESOTROSBANCOS.Name = "CHK_CHEQUESOTROSBANCOS"
        Me.CHK_CHEQUESOTROSBANCOS.Size = New System.Drawing.Size(147, 17)
        Me.CHK_CHEQUESOTROSBANCOS.TabIndex = 1
        Me.CHK_CHEQUESOTROSBANCOS.Text = "Cheques de otros bancos"
        Me.CHK_CHEQUESOTROSBANCOS.UseVisualStyleBackColor = True
        '
        'CHK_CHEQUESPROPIOS
        '
        Me.CHK_CHEQUESPROPIOS.AutoSize = True
        Me.CHK_CHEQUESPROPIOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_CHEQUESPROPIOS.Location = New System.Drawing.Point(24, 28)
        Me.CHK_CHEQUESPROPIOS.Name = "CHK_CHEQUESPROPIOS"
        Me.CHK_CHEQUESPROPIOS.Size = New System.Drawing.Size(106, 17)
        Me.CHK_CHEQUESPROPIOS.TabIndex = 0
        Me.CHK_CHEQUESPROPIOS.Text = "Cheques Propios"
        Me.CHK_CHEQUESPROPIOS.UseVisualStyleBackColor = True
        '
        'TXT_TOTALADEPOSITAR
        '
        Me.TXT_TOTALADEPOSITAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_TOTALADEPOSITAR.Location = New System.Drawing.Point(21, 20)
        Me.TXT_TOTALADEPOSITAR.Name = "TXT_TOTALADEPOSITAR"
        Me.TXT_TOTALADEPOSITAR.Size = New System.Drawing.Size(100, 20)
        Me.TXT_TOTALADEPOSITAR.TabIndex = 7
        '
        'TXT_EFECTIVO
        '
        Me.TXT_EFECTIVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_EFECTIVO.Location = New System.Drawing.Point(16, 96)
        Me.TXT_EFECTIVO.Name = "TXT_EFECTIVO"
        Me.TXT_EFECTIVO.Size = New System.Drawing.Size(100, 20)
        Me.TXT_EFECTIVO.TabIndex = 5
        Me.TXT_EFECTIVO.Visible = False
        '
        'TXT_CHEQUESOTROSBANCOS
        '
        Me.TXT_CHEQUESOTROSBANCOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CHEQUESOTROSBANCOS.Location = New System.Drawing.Point(16, 60)
        Me.TXT_CHEQUESOTROSBANCOS.Name = "TXT_CHEQUESOTROSBANCOS"
        Me.TXT_CHEQUESOTROSBANCOS.Size = New System.Drawing.Size(100, 20)
        Me.TXT_CHEQUESOTROSBANCOS.TabIndex = 4
        Me.TXT_CHEQUESOTROSBANCOS.Visible = False
        '
        'TXT_CHEQUESPROPIOS
        '
        Me.TXT_CHEQUESPROPIOS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_CHEQUESPROPIOS.Location = New System.Drawing.Point(16, 25)
        Me.TXT_CHEQUESPROPIOS.Name = "TXT_CHEQUESPROPIOS"
        Me.TXT_CHEQUESPROPIOS.Size = New System.Drawing.Size(100, 20)
        Me.TXT_CHEQUESPROPIOS.TabIndex = 3
        Me.TXT_CHEQUESPROPIOS.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BTN_SALIR)
        Me.GroupBox3.Controls.Add(Me.GroupBox8)
        Me.GroupBox3.Controls.Add(Me.BTN_LIMPIAR)
        Me.GroupBox3.Controls.Add(Me.GroupBox5)
        Me.GroupBox3.Controls.Add(Me.BTN_CALCULAR)
        Me.GroupBox3.Controls.Add(Me.GroupBox7)
        Me.GroupBox3.Controls.Add(Me.GroupBox6)
        Me.GroupBox3.Controls.Add(Me.GroupBox4)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Controls.Add(Me.GroupBox2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(44, 33)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(652, 284)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "INTERESES Y DEPOSITOS"
        '
        'BTN_SALIR
        '
        Me.BTN_SALIR.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BTN_SALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SALIR.Location = New System.Drawing.Point(359, 209)
        Me.BTN_SALIR.Name = "BTN_SALIR"
        Me.BTN_SALIR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_SALIR.TabIndex = 5
        Me.BTN_SALIR.Text = "SALIR"
        Me.BTN_SALIR.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TXT_INTERES)
        Me.GroupBox8.Enabled = False
        Me.GroupBox8.Location = New System.Drawing.Point(484, 148)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(144, 55)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "INTERES"
        '
        'TXT_INTERES
        '
        Me.TXT_INTERES.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_INTERES.Location = New System.Drawing.Point(21, 20)
        Me.TXT_INTERES.Name = "TXT_INTERES"
        Me.TXT_INTERES.Size = New System.Drawing.Size(100, 20)
        Me.TXT_INTERES.TabIndex = 7
        '
        'BTN_LIMPIAR
        '
        Me.BTN_LIMPIAR.BackColor = System.Drawing.Color.PaleTurquoise
        Me.BTN_LIMPIAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_LIMPIAR.Location = New System.Drawing.Point(255, 209)
        Me.BTN_LIMPIAR.Name = "BTN_LIMPIAR"
        Me.BTN_LIMPIAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_LIMPIAR.TabIndex = 4
        Me.BTN_LIMPIAR.Text = "LIMPIAR"
        Me.BTN_LIMPIAR.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TXT_TOTALADEPOSITAR)
        Me.GroupBox5.Enabled = False
        Me.GroupBox5.Location = New System.Drawing.Point(484, 87)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(144, 55)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "DEPOSITO "
        '
        'BTN_CALCULAR
        '
        Me.BTN_CALCULAR.BackColor = System.Drawing.Color.Aquamarine
        Me.BTN_CALCULAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CALCULAR.Location = New System.Drawing.Point(149, 209)
        Me.BTN_CALCULAR.Name = "BTN_CALCULAR"
        Me.BTN_CALCULAR.Size = New System.Drawing.Size(75, 23)
        Me.BTN_CALCULAR.TabIndex = 3
        Me.BTN_CALCULAR.Text = "CALCULAR"
        Me.BTN_CALCULAR.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TXT_SALDONUEVO)
        Me.GroupBox7.Enabled = False
        Me.GroupBox7.Location = New System.Drawing.Point(484, 209)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(144, 55)
        Me.GroupBox7.TabIndex = 11
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "SALDO NUEVO"
        '
        'TXT_SALDONUEVO
        '
        Me.TXT_SALDONUEVO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SALDONUEVO.Location = New System.Drawing.Point(21, 20)
        Me.TXT_SALDONUEVO.Name = "TXT_SALDONUEVO"
        Me.TXT_SALDONUEVO.Size = New System.Drawing.Size(100, 20)
        Me.TXT_SALDONUEVO.TabIndex = 7
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TXT_SALDOANTERIOR)
        Me.GroupBox6.Location = New System.Drawing.Point(484, 26)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(144, 55)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "SALDO ANTERIOR"
        '
        'TXT_SALDOANTERIOR
        '
        Me.TXT_SALDOANTERIOR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_SALDOANTERIOR.Location = New System.Drawing.Point(21, 20)
        Me.TXT_SALDOANTERIOR.Name = "TXT_SALDOANTERIOR"
        Me.TXT_SALDOANTERIOR.Size = New System.Drawing.Size(100, 20)
        Me.TXT_SALDOANTERIOR.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXT_CHEQUESPROPIOS)
        Me.GroupBox4.Controls.Add(Me.TXT_CHEQUESOTROSBANCOS)
        Me.GroupBox4.Controls.Add(Me.TXT_EFECTIVO)
        Me.GroupBox4.Location = New System.Drawing.Point(348, 26)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(130, 135)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "MONTOS EN Q."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(740, 352)
        Me.Controls.Add(Me.GroupBox3)
        Me.DoubleBuffered = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RDB_AHORRO As RadioButton
    Friend WithEvents RDB_MONETARIOPREMIER As RadioButton
    Friend WithEvents RDB_MONETARIO As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXT_EFECTIVO As TextBox
    Friend WithEvents TXT_CHEQUESOTROSBANCOS As TextBox
    Friend WithEvents TXT_CHEQUESPROPIOS As TextBox
    Friend WithEvents CHK_EFECTIVO As CheckBox
    Friend WithEvents CHK_CHEQUESOTROSBANCOS As CheckBox
    Friend WithEvents CHK_CHEQUESPROPIOS As CheckBox
    Friend WithEvents TXT_TOTALADEPOSITAR As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BTN_CALCULAR As Button
    Friend WithEvents BTN_LIMPIAR As Button
    Friend WithEvents BTN_SALIR As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TXT_SALDOANTERIOR As TextBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TXT_SALDONUEVO As TextBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TXT_INTERES As TextBox
End Class
