Public Class Form1
    Private Sub btnsuma_Click(sender As Object, e As EventArgs) Handles btnsuma.Click

        ' Variables para almacenar los números inicial, final y la suma de los pares
        Dim inicial As Integer
        Dim final As Integer
        Dim suma As Integer = 0

        ' Intentar convertir los valores de los TextBox a números enteros
        If Integer.TryParse(txtinicio.Text, inicial) AndAlso
           Integer.TryParse(txtfin.Text, final) Then

            ' Iterar desde el número inicial hasta el número final
            For num As Integer = inicial To final
                ' Verificar si el número actual es par
                If num Mod 2 = 0 Then
                    suma += num ' Sumar al total de números pares
                End If
            Next

            ' Mostrar el resultado en el TextBox de resultado
            lblresultado.Text = suma.ToString()
        Else
            ' Mostrar un mensaje de error si los datos ingresados no son numéricos
            MessageBox.Show("Por favor, ingrese valores numéricos válidos.")
        End If
    End Sub
End Class

