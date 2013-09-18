Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2, largerNum As Double

        num1 = CDbl(txtFirstNum.Text)
        num1 = CDbl(txtSecondNum.Text)

        If (num1 > num2) Then
            largerNum = num1
        Else
            largerNum = num2
            txtResult.Text = "The larger number is " & largerNum
        Else If (num1 < num2) Then
            txtResult.Text = "The larger number is " & num2
        Else
            txtResult.Text = "They are equal "
        End If
    End Sub



End Class
