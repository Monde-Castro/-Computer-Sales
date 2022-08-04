Public Class Computer
    Private ProductNum As String
    Private Colors As String
    Private DiskSize As Decimal
    Private CostPrice As Decimal

    Public Property ProductNums() As String
        Get
            Return ProductNum
        End Get
        Set(ByVal productvalue As String)
            ProductNum = productvalue
        End Set
    End Property

    Public Property Color() As String
        Get
            Return Colors
        End Get
        Set(ByVal colorvalue As String)
            Colors = colorvalue
        End Set
    End Property

    Public Property DiskSizes() As String
        Get
            Return DiskSize
        End Get
        Set(ByVal DiskSizesvalue As String)
            DiskSize = DiskSizesvalue
        End Set
    End Property

    Public Property CostPrices() As String
        Get
            Return CostPrice
        End Get
        Set(ByVal CostPricesvalue As String)
            CostPrice = CostPricesvalue
        End Set
    End Property

    Public Sub New()

        CostPrice = 0
        DiskSize = 0
        Color = String.Empty
        ProductNum = String.Empty

    End Sub


    Public Sub New(ByVal FCostPrice As Decimal,
                   ByVal FDiskSize As Decimal,
                   ByVal FColor As String,
                   ByVal FProductNum As String)
        CostPrice = FCostPrice
        DiskSize = FDiskSize
        Color = FColor
        ProductNum = FProductNum
    End Sub

    Public Overridable Function Installment(ByVal costprice As Decimal) As String
        Dim Total As String
        Total = costprice / 12
        Return Total.ToString("C2")
    End Function

End Class
