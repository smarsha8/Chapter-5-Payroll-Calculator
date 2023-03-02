'Program Name:  Payroll Calculator
'Developer:     Shakeitha Marshall

Public Class iko

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblFederalTax.Click

    End Sub

    Private Sub iko_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub







    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGrossPay.Clear()
        txtNetPaycheckIncome.Clear()
        lblFicaNumbers.Text = ""
        lblFederalTaxNumber.Text = ""
        lblStateTaxNumber.Text = ""

    End Sub

    Private Sub btncomputetaxes_Click(sender As Object, e As EventArgs) Handles btncomputetaxes.Click
        'Declare Variable

        Dim strGrossPay = txtNetPaycheckIncome.Text




        'MsgBox(srtGrossPay)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblFederalTaxNumber.Click

    End Sub
End Class
