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
        Me.GB1 = New System.Windows.Forms.GroupBox()
        Me.RDBKING = New System.Windows.Forms.RadioButton()
        Me.RDBQUEEN = New System.Windows.Forms.RadioButton()
        Me.RDBMATRIMONIAL = New System.Windows.Forms.RadioButton()
        Me.RDBIMPERIAL = New System.Windows.Forms.RadioButton()
        Me.GB2 = New System.Windows.Forms.GroupBox()
        Me.CHKHILOCRUDO = New System.Windows.Forms.CheckBox()
        Me.CHKSEDA = New System.Windows.Forms.CheckBox()
        Me.CHKALGODON = New System.Windows.Forms.CheckBox()
        Me.CHKLINO = New System.Windows.Forms.CheckBox()
        Me.GB3 = New System.Windows.Forms.GroupBox()
        Me.TXTHILOCRUDO = New System.Windows.Forms.TextBox()
        Me.TXTSEDA = New System.Windows.Forms.TextBox()
        Me.TXTALGODON = New System.Windows.Forms.TextBox()
        Me.TXTLINO = New System.Windows.Forms.TextBox()
        Me.BTNCALCULAR = New System.Windows.Forms.Button()
        Me.BTNLIMPIAR = New System.Windows.Forms.Button()
        Me.BTNSALIR = New System.Windows.Forms.Button()
        Me.GB4 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTTOTALHILOCRUDO = New System.Windows.Forms.TextBox()
        Me.TXTTOTALSEDA = New System.Windows.Forms.TextBox()
        Me.TXTTOTALALGODON = New System.Windows.Forms.TextBox()
        Me.TXTTOTALLINO = New System.Windows.Forms.TextBox()
        Me.GB5 = New System.Windows.Forms.GroupBox()
        Me.TXTPRECIODEVENTA = New System.Windows.Forms.TextBox()
        Me.TXTPRECIODECOSTO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTTOTALDEMATERIAL = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GB1.SuspendLayout()
        Me.GB2.SuspendLayout()
        Me.GB3.SuspendLayout()
        Me.GB4.SuspendLayout()
        Me.GB5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GB1
        '
        Me.GB1.BackColor = System.Drawing.Color.Transparent
        Me.GB1.Controls.Add(Me.RDBKING)
        Me.GB1.Controls.Add(Me.RDBQUEEN)
        Me.GB1.Controls.Add(Me.RDBMATRIMONIAL)
        Me.GB1.Controls.Add(Me.RDBIMPERIAL)
        Me.GB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB1.Location = New System.Drawing.Point(47, 47)
        Me.GB1.Name = "GB1"
        Me.GB1.Size = New System.Drawing.Size(95, 116)
        Me.GB1.TabIndex = 0
        Me.GB1.TabStop = False
        Me.GB1.Text = "TAMAÑO"
        '
        'RDBKING
        '
        Me.RDBKING.AutoSize = True
        Me.RDBKING.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBKING.Location = New System.Drawing.Point(6, 88)
        Me.RDBKING.Name = "RDBKING"
        Me.RDBKING.Size = New System.Drawing.Size(49, 17)
        Me.RDBKING.TabIndex = 3
        Me.RDBKING.Text = "King "
        Me.RDBKING.UseVisualStyleBackColor = True
        '
        'RDBQUEEN
        '
        Me.RDBQUEEN.AutoSize = True
        Me.RDBQUEEN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBQUEEN.Location = New System.Drawing.Point(6, 65)
        Me.RDBQUEEN.Name = "RDBQUEEN"
        Me.RDBQUEEN.Size = New System.Drawing.Size(57, 17)
        Me.RDBQUEEN.TabIndex = 2
        Me.RDBQUEEN.Text = "Queen"
        Me.RDBQUEEN.UseVisualStyleBackColor = True
        '
        'RDBMATRIMONIAL
        '
        Me.RDBMATRIMONIAL.AutoSize = True
        Me.RDBMATRIMONIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBMATRIMONIAL.Location = New System.Drawing.Point(6, 42)
        Me.RDBMATRIMONIAL.Name = "RDBMATRIMONIAL"
        Me.RDBMATRIMONIAL.Size = New System.Drawing.Size(81, 17)
        Me.RDBMATRIMONIAL.TabIndex = 1
        Me.RDBMATRIMONIAL.Text = "Matrimonial "
        Me.RDBMATRIMONIAL.UseVisualStyleBackColor = True
        '
        'RDBIMPERIAL
        '
        Me.RDBIMPERIAL.AutoSize = True
        Me.RDBIMPERIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RDBIMPERIAL.Location = New System.Drawing.Point(6, 19)
        Me.RDBIMPERIAL.Name = "RDBIMPERIAL"
        Me.RDBIMPERIAL.Size = New System.Drawing.Size(61, 17)
        Me.RDBIMPERIAL.TabIndex = 0
        Me.RDBIMPERIAL.Text = "Imperial"
        Me.RDBIMPERIAL.UseVisualStyleBackColor = True
        '
        'GB2
        '
        Me.GB2.BackColor = System.Drawing.Color.Transparent
        Me.GB2.Controls.Add(Me.CHKHILOCRUDO)
        Me.GB2.Controls.Add(Me.CHKSEDA)
        Me.GB2.Controls.Add(Me.CHKALGODON)
        Me.GB2.Controls.Add(Me.CHKLINO)
        Me.GB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB2.Location = New System.Drawing.Point(148, 47)
        Me.GB2.Name = "GB2"
        Me.GB2.Size = New System.Drawing.Size(86, 116)
        Me.GB2.TabIndex = 1
        Me.GB2.TabStop = False
        Me.GB2.Text = "MATERIAL"
        '
        'CHKHILOCRUDO
        '
        Me.CHKHILOCRUDO.AutoSize = True
        Me.CHKHILOCRUDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKHILOCRUDO.Location = New System.Drawing.Point(6, 89)
        Me.CHKHILOCRUDO.Name = "CHKHILOCRUDO"
        Me.CHKHILOCRUDO.Size = New System.Drawing.Size(78, 17)
        Me.CHKHILOCRUDO.TabIndex = 3
        Me.CHKHILOCRUDO.Text = "Hilo Crudo "
        Me.CHKHILOCRUDO.UseVisualStyleBackColor = True
        '
        'CHKSEDA
        '
        Me.CHKSEDA.AutoSize = True
        Me.CHKSEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKSEDA.Location = New System.Drawing.Point(6, 66)
        Me.CHKSEDA.Name = "CHKSEDA"
        Me.CHKSEDA.Size = New System.Drawing.Size(51, 17)
        Me.CHKSEDA.TabIndex = 2
        Me.CHKSEDA.Text = "Seda"
        Me.CHKSEDA.UseVisualStyleBackColor = True
        '
        'CHKALGODON
        '
        Me.CHKALGODON.AutoSize = True
        Me.CHKALGODON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKALGODON.Location = New System.Drawing.Point(6, 43)
        Me.CHKALGODON.Name = "CHKALGODON"
        Me.CHKALGODON.Size = New System.Drawing.Size(65, 17)
        Me.CHKALGODON.TabIndex = 1
        Me.CHKALGODON.Text = "Algodón"
        Me.CHKALGODON.UseVisualStyleBackColor = True
        '
        'CHKLINO
        '
        Me.CHKLINO.AutoSize = True
        Me.CHKLINO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKLINO.Location = New System.Drawing.Point(6, 20)
        Me.CHKLINO.Name = "CHKLINO"
        Me.CHKLINO.Size = New System.Drawing.Size(46, 17)
        Me.CHKLINO.TabIndex = 0
        Me.CHKLINO.Text = "Lino"
        Me.CHKLINO.UseVisualStyleBackColor = True
        '
        'GB3
        '
        Me.GB3.BackColor = System.Drawing.Color.Transparent
        Me.GB3.Controls.Add(Me.TXTHILOCRUDO)
        Me.GB3.Controls.Add(Me.TXTSEDA)
        Me.GB3.Controls.Add(Me.TXTALGODON)
        Me.GB3.Controls.Add(Me.TXTLINO)
        Me.GB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB3.Location = New System.Drawing.Point(240, 47)
        Me.GB3.Name = "GB3"
        Me.GB3.Size = New System.Drawing.Size(156, 116)
        Me.GB3.TabIndex = 4
        Me.GB3.TabStop = False
        Me.GB3.Text = "YARDAS A EMPLEAR"
        '
        'TXTHILOCRUDO
        '
        Me.TXTHILOCRUDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTHILOCRUDO.Location = New System.Drawing.Point(6, 89)
        Me.TXTHILOCRUDO.Name = "TXTHILOCRUDO"
        Me.TXTHILOCRUDO.Size = New System.Drawing.Size(100, 20)
        Me.TXTHILOCRUDO.TabIndex = 3
        Me.TXTHILOCRUDO.Visible = False
        '
        'TXTSEDA
        '
        Me.TXTSEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTSEDA.Location = New System.Drawing.Point(6, 66)
        Me.TXTSEDA.Name = "TXTSEDA"
        Me.TXTSEDA.Size = New System.Drawing.Size(100, 20)
        Me.TXTSEDA.TabIndex = 2
        Me.TXTSEDA.Visible = False
        '
        'TXTALGODON
        '
        Me.TXTALGODON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTALGODON.Location = New System.Drawing.Point(6, 43)
        Me.TXTALGODON.Name = "TXTALGODON"
        Me.TXTALGODON.Size = New System.Drawing.Size(100, 20)
        Me.TXTALGODON.TabIndex = 1
        Me.TXTALGODON.Visible = False
        '
        'TXTLINO
        '
        Me.TXTLINO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTLINO.Location = New System.Drawing.Point(6, 19)
        Me.TXTLINO.Name = "TXTLINO"
        Me.TXTLINO.Size = New System.Drawing.Size(100, 20)
        Me.TXTLINO.TabIndex = 0
        Me.TXTLINO.Visible = False
        '
        'BTNCALCULAR
        '
        Me.BTNCALCULAR.BackColor = System.Drawing.Color.SpringGreen
        Me.BTNCALCULAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCALCULAR.Location = New System.Drawing.Point(413, 47)
        Me.BTNCALCULAR.Name = "BTNCALCULAR"
        Me.BTNCALCULAR.Size = New System.Drawing.Size(84, 29)
        Me.BTNCALCULAR.TabIndex = 5
        Me.BTNCALCULAR.Text = "Calcular "
        Me.BTNCALCULAR.UseVisualStyleBackColor = False
        '
        'BTNLIMPIAR
        '
        Me.BTNLIMPIAR.BackColor = System.Drawing.Color.Aqua
        Me.BTNLIMPIAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLIMPIAR.Location = New System.Drawing.Point(413, 83)
        Me.BTNLIMPIAR.Name = "BTNLIMPIAR"
        Me.BTNLIMPIAR.Size = New System.Drawing.Size(84, 29)
        Me.BTNLIMPIAR.TabIndex = 6
        Me.BTNLIMPIAR.Text = "Limpiar "
        Me.BTNLIMPIAR.UseVisualStyleBackColor = False
        '
        'BTNSALIR
        '
        Me.BTNSALIR.BackColor = System.Drawing.Color.MediumPurple
        Me.BTNSALIR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNSALIR.Location = New System.Drawing.Point(413, 122)
        Me.BTNSALIR.Name = "BTNSALIR"
        Me.BTNSALIR.Size = New System.Drawing.Size(84, 30)
        Me.BTNSALIR.TabIndex = 7
        Me.BTNSALIR.Text = "Salir"
        Me.BTNSALIR.UseVisualStyleBackColor = False
        '
        'GB4
        '
        Me.GB4.BackColor = System.Drawing.Color.Transparent
        Me.GB4.Controls.Add(Me.TXTTOTALDEMATERIAL)
        Me.GB4.Controls.Add(Me.Label7)
        Me.GB4.Controls.Add(Me.TXTTOTALHILOCRUDO)
        Me.GB4.Controls.Add(Me.TXTTOTALSEDA)
        Me.GB4.Controls.Add(Me.Label6)
        Me.GB4.Controls.Add(Me.TXTTOTALALGODON)
        Me.GB4.Controls.Add(Me.Label5)
        Me.GB4.Controls.Add(Me.TXTTOTALLINO)
        Me.GB4.Controls.Add(Me.Label4)
        Me.GB4.Controls.Add(Me.Label3)
        Me.GB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB4.Location = New System.Drawing.Point(68, 179)
        Me.GB4.Name = "GB4"
        Me.GB4.Size = New System.Drawing.Size(185, 174)
        Me.GB4.TabIndex = 8
        Me.GB4.TabStop = False
        Me.GB4.Text = "TOTAL DE MATERIAL"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Precio de venta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Precio de costo "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Lino "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Algodón "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Seda"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Lino "
        '
        'TXTTOTALHILOCRUDO
        '
        Me.TXTTOTALHILOCRUDO.Enabled = False
        Me.TXTTOTALHILOCRUDO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALHILOCRUDO.Location = New System.Drawing.Point(59, 102)
        Me.TXTTOTALHILOCRUDO.Name = "TXTTOTALHILOCRUDO"
        Me.TXTTOTALHILOCRUDO.Size = New System.Drawing.Size(100, 20)
        Me.TXTTOTALHILOCRUDO.TabIndex = 7
        '
        'TXTTOTALSEDA
        '
        Me.TXTTOTALSEDA.Enabled = False
        Me.TXTTOTALSEDA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALSEDA.Location = New System.Drawing.Point(59, 79)
        Me.TXTTOTALSEDA.Name = "TXTTOTALSEDA"
        Me.TXTTOTALSEDA.Size = New System.Drawing.Size(100, 20)
        Me.TXTTOTALSEDA.TabIndex = 6
        '
        'TXTTOTALALGODON
        '
        Me.TXTTOTALALGODON.Enabled = False
        Me.TXTTOTALALGODON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALALGODON.Location = New System.Drawing.Point(59, 56)
        Me.TXTTOTALALGODON.Name = "TXTTOTALALGODON"
        Me.TXTTOTALALGODON.Size = New System.Drawing.Size(100, 20)
        Me.TXTTOTALALGODON.TabIndex = 5
        '
        'TXTTOTALLINO
        '
        Me.TXTTOTALLINO.Enabled = False
        Me.TXTTOTALLINO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALLINO.Location = New System.Drawing.Point(59, 32)
        Me.TXTTOTALLINO.Name = "TXTTOTALLINO"
        Me.TXTTOTALLINO.Size = New System.Drawing.Size(100, 20)
        Me.TXTTOTALLINO.TabIndex = 4
        '
        'GB5
        '
        Me.GB5.BackColor = System.Drawing.Color.Transparent
        Me.GB5.Controls.Add(Me.TXTPRECIODEVENTA)
        Me.GB5.Controls.Add(Me.TXTPRECIODECOSTO)
        Me.GB5.Controls.Add(Me.Label2)
        Me.GB5.Controls.Add(Me.Label1)
        Me.GB5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GB5.Location = New System.Drawing.Point(259, 206)
        Me.GB5.Name = "GB5"
        Me.GB5.Size = New System.Drawing.Size(200, 81)
        Me.GB5.TabIndex = 9
        Me.GB5.TabStop = False
        Me.GB5.Text = "PRECIO "
        '
        'TXTPRECIODEVENTA
        '
        Me.TXTPRECIODEVENTA.BackColor = System.Drawing.Color.MistyRose
        Me.TXTPRECIODEVENTA.Enabled = False
        Me.TXTPRECIODEVENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRECIODEVENTA.Location = New System.Drawing.Point(94, 47)
        Me.TXTPRECIODEVENTA.Name = "TXTPRECIODEVENTA"
        Me.TXTPRECIODEVENTA.Size = New System.Drawing.Size(100, 20)
        Me.TXTPRECIODEVENTA.TabIndex = 9
        '
        'TXTPRECIODECOSTO
        '
        Me.TXTPRECIODECOSTO.BackColor = System.Drawing.Color.MistyRose
        Me.TXTPRECIODECOSTO.Enabled = False
        Me.TXTPRECIODECOSTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTPRECIODECOSTO.Location = New System.Drawing.Point(94, 23)
        Me.TXTPRECIODECOSTO.Name = "TXTPRECIODECOSTO"
        Me.TXTPRECIODECOSTO.Size = New System.Drawing.Size(100, 20)
        Me.TXTPRECIODECOSTO.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "TOTAL "
        '
        'TXTTOTALDEMATERIAL
        '
        Me.TXTTOTALDEMATERIAL.BackColor = System.Drawing.Color.MistyRose
        Me.TXTTOTALDEMATERIAL.Enabled = False
        Me.TXTTOTALDEMATERIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTOTALDEMATERIAL.Location = New System.Drawing.Point(57, 140)
        Me.TXTTOTALDEMATERIAL.Name = "TXTTOTALDEMATERIAL"
        Me.TXTTOTALDEMATERIAL.Size = New System.Drawing.Size(100, 20)
        Me.TXTTOTALDEMATERIAL.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "CUBRECAMAS"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(537, 365)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GB5)
        Me.Controls.Add(Me.GB4)
        Me.Controls.Add(Me.BTNSALIR)
        Me.Controls.Add(Me.BTNLIMPIAR)
        Me.Controls.Add(Me.BTNCALCULAR)
        Me.Controls.Add(Me.GB3)
        Me.Controls.Add(Me.GB2)
        Me.Controls.Add(Me.GB1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GB1.ResumeLayout(False)
        Me.GB1.PerformLayout()
        Me.GB2.ResumeLayout(False)
        Me.GB2.PerformLayout()
        Me.GB3.ResumeLayout(False)
        Me.GB3.PerformLayout()
        Me.GB4.ResumeLayout(False)
        Me.GB4.PerformLayout()
        Me.GB5.ResumeLayout(False)
        Me.GB5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GB1 As GroupBox
    Friend WithEvents RDBKING As RadioButton
    Friend WithEvents RDBQUEEN As RadioButton
    Friend WithEvents RDBMATRIMONIAL As RadioButton
    Friend WithEvents RDBIMPERIAL As RadioButton
    Friend WithEvents GB2 As GroupBox
    Friend WithEvents CHKHILOCRUDO As CheckBox
    Friend WithEvents CHKSEDA As CheckBox
    Friend WithEvents CHKALGODON As CheckBox
    Friend WithEvents CHKLINO As CheckBox
    Friend WithEvents GB3 As GroupBox
    Friend WithEvents TXTHILOCRUDO As TextBox
    Friend WithEvents TXTSEDA As TextBox
    Friend WithEvents TXTALGODON As TextBox
    Friend WithEvents TXTLINO As TextBox
    Friend WithEvents BTNCALCULAR As Button
    Friend WithEvents BTNLIMPIAR As Button
    Friend WithEvents BTNSALIR As Button
    Friend WithEvents GB4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXTTOTALDEMATERIAL As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTTOTALHILOCRUDO As TextBox
    Friend WithEvents TXTTOTALSEDA As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTTOTALALGODON As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTTOTALLINO As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GB5 As GroupBox
    Friend WithEvents TXTPRECIODEVENTA As TextBox
    Friend WithEvents TXTPRECIODECOSTO As TextBox
    Friend WithEvents Label8 As Label
End Class
