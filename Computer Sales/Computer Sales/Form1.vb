Public Class frmComputerSales

    Private Sub btnCalc_Installment_Click(sender As Object, e As EventArgs) Handles btnCalc_Installment.Click

        Dim MyLaptop As Laptop
        Dim MyMainFrame As MainFrame
        Dim MyPersonalComputer As PersonalComputer

        'Declare variables
        Dim ProductNum As String
        Dim Color As String
        Dim DiskSize As Decimal
        Dim CostPrice As Decimal

        ProductNum = txtProductNum.Text
        Color = txtColor.Text
        DiskSize = txtDiskSize.Text
        CostPrice = txtCostPrize.Text


        If radLaptop.Checked = True Then
            MyLaptop = New Laptop(CostPrice,
                                  DiskSize,
                                  Color,
                                  ProductNum)
            MyLaptop.CostPrices = CostPrice
            MyLaptop.DiskSizes = DiskSize
            MyLaptop.Color = Color
            MyLaptop.ProductNums = ProductNum
            lblMonthInstallment.Text = "Installment for " & MyLaptop.Color & "Laptop with disksize " & MyLaptop.DiskSizes & "Gig " & MyLaptop.Installment(CostPrice)

        End If

        If radMainFrame.Checked = True Then
            MyMainFrame = New MainFrame(CostPrice,
                                        DiskSize,
                                        Color,
                                        ProductNum)
            MyMainFrame.CostPrices = CostPrice
            MyMainFrame.DiskSizes = DiskSize
            MyMainFrame.Color = Color
            MyMainFrame.ProductNums = ProductNum
            lblMonthInstallment.Text = "Installment for " & MyMainFrame.Color & "Laptop with disksize " & MyMainFrame.DiskSizes & "Gig = " & MyMainFrame.Installment(CostPrice)

        End If

        If radPersonalComputer.Checked = True Then
            MyPersonalComputer = New PersonalComputer(CostPrice,
                                                      DiskSize,
                                                      Color,
                                                      ProductNum)
            MyPersonalComputer.CostPrices = CostPrice
            MyPersonalComputer.DiskSizes = DiskSize
            MyPersonalComputer.Color = Color
            MyPersonalComputer.ProductNums = ProductNum
            lblMonthInstallment.Text = "Installment for " & MyPersonalComputer.Color & "Laptop with disksize " & MyPersonalComputer.DiskSizes & "Gig = " & MyPersonalComputer.Installment(CostPrice)

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'Close form
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtColor.Clear()
        txtCostPrize.Clear()
        txtDiskSize.Clear()
        txtProductNum.Clear()
        lblMonthInstallment.Text = " "
        radLaptop.Checked = True

    End Sub
End Class
