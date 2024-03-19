﻿Public Class Vending machine 
    Dim WithEvents CS As New Coin_Slot
Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    CS.Insert_Nickels()
    TextBox1.Text = CS.Total.ToString("C2")
End Sub
Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    CS.Insert_Dimes()
    TextBox1.Text = CS.Total.ToString("C2")
End Sub
Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    CS.Insert_Quarters()
    TextBox1.Text = CS.Total.ToString("C2")
End Sub
Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    CS.Insert_Dollars()
    TextBox1.Text = CS.Total.ToString("C2")
End Sub
Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    CS.Coin_Return()
    TextBox1.Text = CS.Total.ToString("C2")
End Sub

Private Sub CS_CoinReturnEvent(d As Integer, q As Integer, di As Integer, n As Integer) Handles CS.CoinReturnEvent
    If d > 0 Then
        PictureBox6.Visible = True
    Else
        PictureBox6.Visible = False
    End If
    If q > 0 Then
        PictureBox5.Visible = True
    Else
        PictureBox5.Visible = False
    End If
    If di > 0 Then
        PictureBox7.Visible = True
    Else
        PictureBox7.Visible = False
    End If
    If n > 0 Then
        PictureBox8.Visible = True
    Else
        PictureBox8.Visible = False
    End If
End Sub

Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    Select Case ID_TextBox.Text
        Case Product_Control1.ProductID
            CS.Buy(Product_Control1)

        Case Product_Control2.ProductID
            CS.Buy(Product_Control2)

        Case Product_Control3.ProductID
            CS.Buy(Product_Control3)

        Case Product_Control4.ProductID
            CS.Buy(Product_Control4)

        Case Product_Control5.ProductID
            CS.Buy(Product_Control5)

        Case Product_Control6.ProductID
            CS.Buy(Product_Control6)

        Case Product_Control7.ProductID
            CS.Buy(Product_Control7)

        Case Product_Control8.ProductID
            CS.Buy(Product_Control8)

        Case Product_Control9.ProductID
            CS.Buy(Product_Control9)

        Case Product_Control10.ProductID
            CS.Buy(Product_Control10)

        Case Product_Control11.ProductID
            CS.Buy(Product_Control11)

        Case Product_Control12.ProductID
            CS.Buy(Product_Control12)

        Case Product_Control13.ProductID
            CS.Buy(Product_Control13)

        Case Product_Control14.ProductID
            CS.Buy(Product_Control14)

        Case Product_Control15.ProductID
            CS.Buy(Product_Control15)

        Case Product_Control16.ProductID
            CS.Buy(Product_Control16)
    End Select
    TextBox1.Text = CS.Total.ToString("C2")
End Sub

Private Sub Product_Control1_DispenseProduct(i As Image) Handles Product_Control1.DispenseProduct
    Product_PictureBox.Image = i
End Sub
End Class
