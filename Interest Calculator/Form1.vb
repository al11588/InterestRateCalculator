Public Class Form1

    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim principal As Decimal = Val(txtPrincipals.Text)
        Dim rate As Decimal = Val(txtBoxInterestRate.Text)

        lstResults.Items.Add("Year" & vbTab & "Amount to Deposit")
        Dim amount As Decimal

        For Yearcounter As Integer = 1 To yearUpDown.Value
            amount = principal * ((1 + rate / 100) ^ Yearcounter)
            lstResults.Items.Add(Yearcounter & vbTab & String.Format("{0:C}", amount))
        Next
    End Sub
End Class
