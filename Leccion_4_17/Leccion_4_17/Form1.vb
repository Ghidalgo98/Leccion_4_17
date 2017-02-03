Public Class Form1

    Dim Figura As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load






    End Sub

    Private Sub Cb_Figura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cb_Figura.SelectedIndexChanged

        Figura = Cb_Figura.SelectedIndex

        Select Case Figura


            Case 0

                MsgBox("Seleccione una figura")

            Case 1

                MsgBox("Cuadrado")
                lb_lado1.Visible = True
                txt_lado_1.Visible = True
                lb_base.Visible = False
                lb_altura.Visible = False
                txt_base.Visible = False
                txt_altura.Visible = False



            Case 2
                MsgBox("Rectangulo")
                lb_lado1.Visible = False
                txt_lado_1.Visible = False
                lb_base.Visible = True
                lb_altura.Visible = True
                txt_base.Visible = True
                txt_altura.Visible = True

            Case 3

                MsgBox("Trianguloo")
                lb_lado1.Visible = False
                txt_lado_1.Visible = False
                lb_base.Visible = True
                lb_altura.Visible = True
                txt_base.Visible = True
                txt_altura.Visible = True

            Case 4
                MsgBox("Palalelogramo")

        End Select


    End Sub

    Private Sub bt_calcular_Click(sender As Object, e As EventArgs) Handles bt_calcular.Click


    End Sub
End Class
