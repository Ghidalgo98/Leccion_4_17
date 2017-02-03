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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.txt_lado_1 = New System.Windows.Forms.TextBox()
        Me.txt_lado_2 = New System.Windows.Forms.TextBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.bt_calcular = New System.Windows.Forms.Button()
        Me.Cb_Figura = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_base = New System.Windows.Forms.TextBox()
        Me.txt_altura = New System.Windows.Forms.TextBox()
        Me.lb_lado1 = New System.Windows.Forms.Label()
        Me.lb_base = New System.Windows.Forms.Label()
        Me.lb_lado_2 = New System.Windows.Forms.Label()
        Me.lb_altura = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione la Figura a Calcular"
        '
        'txt_lado_1
        '
        Me.txt_lado_1.Location = New System.Drawing.Point(57, 135)
        Me.txt_lado_1.Name = "txt_lado_1"
        Me.txt_lado_1.Size = New System.Drawing.Size(100, 20)
        Me.txt_lado_1.TabIndex = 3
        Me.txt_lado_1.Visible = False
        '
        'txt_lado_2
        '
        Me.txt_lado_2.Location = New System.Drawing.Point(201, 135)
        Me.txt_lado_2.Name = "txt_lado_2"
        Me.txt_lado_2.Size = New System.Drawing.Size(100, 20)
        Me.txt_lado_2.TabIndex = 4
        Me.txt_lado_2.Visible = False
        '
        'txt_resultado
        '
        Me.txt_resultado.Location = New System.Drawing.Point(52, 390)
        Me.txt_resultado.Multiline = True
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(118, 28)
        Me.txt_resultado.TabIndex = 5
        '
        'bt_calcular
        '
        Me.bt_calcular.Location = New System.Drawing.Point(57, 291)
        Me.bt_calcular.Name = "bt_calcular"
        Me.bt_calcular.Size = New System.Drawing.Size(100, 33)
        Me.bt_calcular.TabIndex = 6
        Me.bt_calcular.Text = "Calcular"
        Me.bt_calcular.UseVisualStyleBackColor = True
        '
        'Cb_Figura
        '
        Me.Cb_Figura.FormattingEnabled = True
        Me.Cb_Figura.Items.AddRange(New Object() {"Seleccione el Item", "Cuadrado", "Rectangulo", "Triangulo", "Palalelogramo"})
        Me.Cb_Figura.Location = New System.Drawing.Point(57, 43)
        Me.Cb_Figura.Name = "Cb_Figura"
        Me.Cb_Figura.Size = New System.Drawing.Size(121, 21)
        Me.Cb_Figura.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "El Area de La Figura es"
        '
        'txt_base
        '
        Me.txt_base.Location = New System.Drawing.Point(56, 227)
        Me.txt_base.Name = "txt_base"
        Me.txt_base.Size = New System.Drawing.Size(100, 20)
        Me.txt_base.TabIndex = 9
        Me.txt_base.Visible = False
        '
        'txt_altura
        '
        Me.txt_altura.Location = New System.Drawing.Point(201, 227)
        Me.txt_altura.Name = "txt_altura"
        Me.txt_altura.Size = New System.Drawing.Size(100, 20)
        Me.txt_altura.TabIndex = 10
        Me.txt_altura.Visible = False
        '
        'lb_lado1
        '
        Me.lb_lado1.AutoSize = True
        Me.lb_lado1.Location = New System.Drawing.Point(57, 105)
        Me.lb_lado1.Name = "lb_lado1"
        Me.lb_lado1.Size = New System.Drawing.Size(43, 13)
        Me.lb_lado1.TabIndex = 11
        Me.lb_lado1.Text = "Lado_1"
        Me.lb_lado1.Visible = False
        '
        'lb_base
        '
        Me.lb_base.AutoSize = True
        Me.lb_base.Location = New System.Drawing.Point(57, 192)
        Me.lb_base.Name = "lb_base"
        Me.lb_base.Size = New System.Drawing.Size(31, 13)
        Me.lb_base.TabIndex = 12
        Me.lb_base.Text = "Base"
        Me.lb_base.Visible = False
        '
        'lb_lado_2
        '
        Me.lb_lado_2.AutoSize = True
        Me.lb_lado_2.Location = New System.Drawing.Point(213, 105)
        Me.lb_lado_2.Name = "lb_lado_2"
        Me.lb_lado_2.Size = New System.Drawing.Size(43, 13)
        Me.lb_lado_2.TabIndex = 13
        Me.lb_lado_2.Text = "Lado_2"
        Me.lb_lado_2.Visible = False
        '
        'lb_altura
        '
        Me.lb_altura.AutoSize = True
        Me.lb_altura.Location = New System.Drawing.Point(213, 192)
        Me.lb_altura.Name = "lb_altura"
        Me.lb_altura.Size = New System.Drawing.Size(34, 13)
        Me.lb_altura.TabIndex = 14
        Me.lb_altura.Text = "Altura"
        Me.lb_altura.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(729, 473)
        Me.Controls.Add(Me.lb_altura)
        Me.Controls.Add(Me.lb_lado_2)
        Me.Controls.Add(Me.lb_base)
        Me.Controls.Add(Me.lb_lado1)
        Me.Controls.Add(Me.txt_altura)
        Me.Controls.Add(Me.txt_base)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cb_Figura)
        Me.Controls.Add(Me.bt_calcular)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.txt_lado_2)
        Me.Controls.Add(Me.txt_lado_1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txt_lado_1 As TextBox
    Friend WithEvents txt_lado_2 As TextBox
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents bt_calcular As Button
    Friend WithEvents Cb_Figura As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_base As TextBox
    Friend WithEvents txt_altura As TextBox
    Friend WithEvents lb_lado1 As Label
    Friend WithEvents lb_base As Label
    Friend WithEvents lb_lado_2 As Label
    Friend WithEvents lb_altura As Label
End Class
