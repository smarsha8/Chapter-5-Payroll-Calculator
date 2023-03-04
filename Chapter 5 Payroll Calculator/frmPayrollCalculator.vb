'Program Name:  Payroll Calculator
'Developer:     Shakeitha Marshall

Public Class iko

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblFederalTax.Click

    End Sub










    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Close()
    End Sub
    Private Sub iko_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtGrossPay.Focus()
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGrossPay.Clear()

        lblFicaNumbers.Text = ""
        lblFederalTaxNumber.Text = ""
        lblStateTaxNumber.Text = ""
        lblNetPaycheckIncomedisplay.Text = ""
        txtGrossPay.Focus()

    End Sub

    Private Sub btncomputetaxes_Click(sender As Object, e As EventArgs) Handles btncomputetaxes.Click
        'Declare Variable
        Dim strEnterGrossPay = txtGrossPay.Text
        'MsgBox(strEnterGrossPay)
        Dim decGross As Decimal = 0
        Dim _decFica As Decimal = 0.0765D
        Dim _decState As Decimal = 0.04D
        Dim _decFederal As Decimal = 0.22D
        Dim decFedAmount As Decimal = 0
        Dim decStateAmount As Decimal = 0
        Dim decFicaAmount As Decimal = 0
        Dim _decFicaAmount As Decimal = 0
        Dim _decStateAmount As Decimal = 0
        Dim _decNetPay As Decimal = 0
        Dim decNetPay As Decimal = 0
        'Amounts
        decFicaAmount = decGross * _decFica
        decFedAmount = decGross * _decFederal
        decStateAmount = decGross * _decState

        ' Dim msg As String = "FICA:" & decFedAmount & vbLf
        'msg += "Federal: " & decFedAmount & vbLf
        'msg += "State: " & decStateAmount & vbLf

        'MsgBox(msg)

        'fed, fica, fed display
        decNetPay = decGross - (decFicaAmount + decFedAmount + decStateAmount)
        lblFicaNumbers.Text = decFicaAmount.ToString("c2")
        lblFederalTaxNumber.Text = decFedAmount.ToString("c2")
        lblStateTaxNumber.Text = decStateAmount.ToString("c2")
        lblNetPaycheckIncomedisplay.Text = decNetPay.ToString("c2")






        'Convert input
        decGross = Convert.ToDecimal(txtGrossPay.Text)
        MsgBox(decGross)






        'MsgBox(srtGrossPay)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblFederalTaxNumber.Click

    End Sub

    Private Sub lblFicaNumbers_Click(sender As Object, e As EventArgs) Handles lblFicaNumbers.Click


    End Sub

    Private Sub lblStateTaxNumber_Click(sender As Object, e As EventArgs) Handles lblStateTaxNumber.Click

    End Sub
End Class

