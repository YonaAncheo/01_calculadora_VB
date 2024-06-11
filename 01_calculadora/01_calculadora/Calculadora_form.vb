Public Class Calculadora_form
    Private mi_operacion As New Operaciones
    Private numero_1 As Double
    Private numero_2 As Double

    Public Sub set_numero_1(num As Double)
        numero_1 = num
    End Sub
    Public Sub set_numero_2(num As Double)
        numero_2 = num
    End Sub

    Private Function obt_txt_num1()
        Return Double.Parse(txt_num1.Text)
    End Function

    Private Function obt_txt_num2()
        Return Double.Parse(txt_num2.Text)
    End Function
    Private Function Validar_cadena()

        Try
            numero_1 = obt_txt_num1()
            numero_2 = obt_txt_num2()
        Catch ex As Exception
            MsgBox("Solose permite numeros reales.")
            txt_resultado.Text = "Error!"
            Return False
        End Try
        Return True
    End Function

    Private Sub btn_limpiar_Click(sender As Object, e As EventArgs) Handles btn_limpiar.Click
        txt_num1.Text = "0"
        txt_num2.Text = "0"
        txt_resultado.Text = "0"
    End Sub
    Private Sub btn_suma_Click(sender As Object, e As EventArgs) Handles btn_suma.Click
        If Validar_cadena() Then
            txt_resultado.Text = mi_operacion.Suma(numero_1, numero_2)
        End If
    End Sub

    Private Sub btn_resta_Click(sender As Object, e As EventArgs) Handles btn_resta.Click
        If Validar_cadena() Then
            txt_resultado.Text = mi_operacion.Resta(numero_1, numero_2)
        End If
    End Sub

    Private Sub btn_mult_Click(sender As Object, e As EventArgs) Handles btn_mult.Click
        If Validar_cadena() Then
            txt_resultado.Text = mi_operacion.Multi(numero_1, numero_2)
        End If
    End Sub

    Private Sub btn_divi_Click(sender As Object, e As EventArgs) Handles btn_divi.Click
        If Validar_cadena() Then
            txt_resultado.Text = mi_operacion.Divi(numero_1, numero_2)
        End If
    End Sub
End Class

Public Class Operaciones
    Public Function Suma(num1 As Double, num2 As Double)
        Return num1 + num2
    End Function
    Public Function Resta(num1 As Double, num2 As Double)
        Return num1 - num2
    End Function
    Public Function Multi(num1 As Double, num2 As Double)
        Return num1 * num2
    End Function
    Public Function Divi(num1 As Double, num2 As Double)
        If num2 = 0 Then
            MsgBox("El divisor no puede ser cero.")
            Return "Error!"
        End If
        Return num1 / num2
    End Function
End Class

