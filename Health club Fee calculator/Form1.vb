Public Class Form1
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtMonths.Text = String.Empty
        lblMonthlyFee.Text = String.Empty
        lblTotalFee.Text = String.Empty
        radAdult.Checked = False
        radChild.Checked = False
        radSenior.Checked = False
        radStudent.Checked = False
        chkKarate.Checked = False
        chkTrainer.Checked = False
        chkYoga.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decDiscount As Decimal
        Dim decTotalFee As Decimal
        Const decDiscount4to6 As Decimal = 0.05D ' 4 to 6 months
        Const decDiscount7to9 As Decimal = 0.08D ' 7 to 9 months
        Const decDiscount10orMore As Decimal = 0.1D ' 10 or more mo.
        Dim intMonths As Integer
        Dim decBaseFee As Decimal


        If Not Integer.TryParse(txtMonths.Text, intMonths) Then
            MessageBox.Show("Months must be a valid integer",
             "Input Error")
            Return
        End If
        ' Check the month range: must be 1-24.
        If (intMonths < 1) Or (intMonths > 24) Then
            MessageBox.Show("Enter a value in the range of " _
             & "1 - 24 for months.", "Input Error")
            Return
        End If

        'Cost of each Rate from Adult to Senior Citizen

        If radAdult.Checked = True Then
            decBaseFee = 40
        ElseIf radChild.Checked = True Then
            decBaseFee = 20
        ElseIf radStudent.Checked = True Then
            decBaseFee = 25
        ElseIf radSenior.Checked = True Then
            decBaseFee = 30
        End If

        If chkYoga.Checked = True Then 'added cost for yoga
            decBaseFee += 10
        End If
        If chkKarate.Checked = True Then 'added cost for karate
            decBaseFee += 30
        End If
        If chkTrainer.Checked = True Then 'added cost for personal trainer
            decBaseFee += 50
        End If

        'Deciding the discounts per rate of months

        Select Case intMonths
            Case Is <= 3
                decDiscount = 0
            Case 4 To 6
                decDiscount = decBaseFee * decDiscount4to6
            Case 7 To 9
                decDiscount = decBaseFee * decDiscount7to9
            Case Is >= 10
                decDiscount = decBaseFee * decDiscount10orMore
        End Select

        decBaseFee -= decDiscount
        decTotalFee = decBaseFee * intMonths
        ' Display the fees.
        lblMonthlyFee.Text = decBaseFee.ToString("c")
        lblTotalFee.Text = decTotalFee.ToString("c")
    End Sub
End Class
