<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculadora_form
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
        Me.label_num1 = New System.Windows.Forms.Label()
        Me.label_num2 = New System.Windows.Forms.Label()
        Me.label_resultado = New System.Windows.Forms.Label()
        Me.txt_num1 = New System.Windows.Forms.TextBox()
        Me.txt_num2 = New System.Windows.Forms.TextBox()
        Me.txt_resultado = New System.Windows.Forms.TextBox()
        Me.btn_suma = New System.Windows.Forms.Button()
        Me.btn_resta = New System.Windows.Forms.Button()
        Me.btn_mult = New System.Windows.Forms.Button()
        Me.btn_divi = New System.Windows.Forms.Button()
        Me.btn_limpiar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label_num1
        '
        Me.label_num1.AutoSize = True
        Me.label_num1.Location = New System.Drawing.Point(25, 31)
        Me.label_num1.Name = "label_num1"
        Me.label_num1.Size = New System.Drawing.Size(56, 13)
        Me.label_num1.TabIndex = 0
        Me.label_num1.Text = "Numero 1:"
        '
        'label_num2
        '
        Me.label_num2.AutoSize = True
        Me.label_num2.Location = New System.Drawing.Point(25, 61)
        Me.label_num2.Name = "label_num2"
        Me.label_num2.Size = New System.Drawing.Size(56, 13)
        Me.label_num2.TabIndex = 1
        Me.label_num2.Text = "Numero 2:"
        '
        'label_resultado
        '
        Me.label_resultado.AutoSize = True
        Me.label_resultado.Location = New System.Drawing.Point(25, 90)
        Me.label_resultado.Name = "label_resultado"
        Me.label_resultado.Size = New System.Drawing.Size(58, 13)
        Me.label_resultado.TabIndex = 2
        Me.label_resultado.Text = "Resultado:"
        '
        'txt_num1
        '
        Me.txt_num1.Location = New System.Drawing.Point(120, 24)
        Me.txt_num1.MaxLength = 15
        Me.txt_num1.Name = "txt_num1"
        Me.txt_num1.Size = New System.Drawing.Size(115, 20)
        Me.txt_num1.TabIndex = 3
        Me.txt_num1.Text = "0"
        '
        'txt_num2
        '
        Me.txt_num2.Location = New System.Drawing.Point(120, 54)
        Me.txt_num2.MaxLength = 15
        Me.txt_num2.Name = "txt_num2"
        Me.txt_num2.Size = New System.Drawing.Size(115, 20)
        Me.txt_num2.TabIndex = 4
        Me.txt_num2.Text = "0"
        '
        'txt_resultado
        '
        Me.txt_resultado.Enabled = False
        Me.txt_resultado.Location = New System.Drawing.Point(120, 87)
        Me.txt_resultado.MaxLength = 15
        Me.txt_resultado.Name = "txt_resultado"
        Me.txt_resultado.Size = New System.Drawing.Size(115, 20)
        Me.txt_resultado.TabIndex = 5
        Me.txt_resultado.Text = "0"
        '
        'btn_suma
        '
        Me.btn_suma.Location = New System.Drawing.Point(25, 144)
        Me.btn_suma.Name = "btn_suma"
        Me.btn_suma.Size = New System.Drawing.Size(85, 23)
        Me.btn_suma.TabIndex = 6
        Me.btn_suma.Text = "Suma"
        Me.btn_suma.UseVisualStyleBackColor = True
        '
        'btn_resta
        '
        Me.btn_resta.Location = New System.Drawing.Point(150, 144)
        Me.btn_resta.Name = "btn_resta"
        Me.btn_resta.Size = New System.Drawing.Size(85, 23)
        Me.btn_resta.TabIndex = 7
        Me.btn_resta.Text = "Resta"
        Me.btn_resta.UseVisualStyleBackColor = True
        '
        'btn_mult
        '
        Me.btn_mult.Location = New System.Drawing.Point(25, 189)
        Me.btn_mult.Name = "btn_mult"
        Me.btn_mult.Size = New System.Drawing.Size(85, 23)
        Me.btn_mult.TabIndex = 8
        Me.btn_mult.Text = "Multiplicación"
        Me.btn_mult.UseVisualStyleBackColor = True
        '
        'btn_divi
        '
        Me.btn_divi.Location = New System.Drawing.Point(150, 189)
        Me.btn_divi.Name = "btn_divi"
        Me.btn_divi.Size = New System.Drawing.Size(85, 23)
        Me.btn_divi.TabIndex = 9
        Me.btn_divi.Text = "División"
        Me.btn_divi.UseVisualStyleBackColor = True
        '
        'btn_limpiar
        '
        Me.btn_limpiar.Location = New System.Drawing.Point(89, 231)
        Me.btn_limpiar.Name = "btn_limpiar"
        Me.btn_limpiar.Size = New System.Drawing.Size(85, 23)
        Me.btn_limpiar.TabIndex = 10
        Me.btn_limpiar.Text = "Limpiar"
        Me.btn_limpiar.UseVisualStyleBackColor = True
        '
        'Calculadora_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 291)
        Me.Controls.Add(Me.btn_limpiar)
        Me.Controls.Add(Me.btn_divi)
        Me.Controls.Add(Me.btn_mult)
        Me.Controls.Add(Me.btn_resta)
        Me.Controls.Add(Me.btn_suma)
        Me.Controls.Add(Me.txt_resultado)
        Me.Controls.Add(Me.txt_num2)
        Me.Controls.Add(Me.txt_num1)
        Me.Controls.Add(Me.label_resultado)
        Me.Controls.Add(Me.label_num2)
        Me.Controls.Add(Me.label_num1)
        Me.MaximizeBox = False
        Me.Name = "Calculadora_form"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label_num1 As Label
    Friend WithEvents label_num2 As Label
    Friend WithEvents label_resultado As Label
    Friend WithEvents txt_num1 As TextBox
    Friend WithEvents txt_num2 As TextBox
    Friend WithEvents txt_resultado As TextBox
    Friend WithEvents btn_suma As Button
    Friend WithEvents btn_resta As Button
    Friend WithEvents btn_mult As Button
    Friend WithEvents btn_divi As Button
    Friend WithEvents btn_limpiar As Button
End Class
