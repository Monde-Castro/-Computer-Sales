Public Class MainFrame

    Inherits Computer

    Public Sub New(ByVal FCostPrice As Decimal,
                    ByVal FDiskSize As Decimal,
                    ByVal FColor As String,
                    ByVal FProductNum As String)
    End Sub

    Public Overrides Function Installment(costprice As Decimal) As String

        Return (costprice + 200).ToString("C")
    End Function


End Class
