Public Class InventoryItems
    Dim itemNo As Integer
    Dim itemDesc As String
    Dim itemPrice As Decimal

    'Default constructor
    Public Sub New()
        itemNo = 0
        itemDesc = "DEFAULT"
        itemPrice = 0.00
    End Sub
    'Constructor with Properties
    Public Sub New(itemNo As Integer, itemDesc As String, itemPrice As Decimal)
        Me.itemNo = itemNo
        Me.itemDesc = itemDesc
        Me.itemPrice = Format(itemPrice, "Currency") 'convert to currency
    End Sub

    'Public Property Number
    Public Property Number As Integer
        Get
            Return itemNo
        End Get
        Set(value As Integer)
            itemNo = value
        End Set
    End Property

    'Public Property Description
    Public Property Description As String
        Get
            Return itemDesc
        End Get
        Set(value As String)
            itemDesc = value
        End Set
    End Property

    'Public Property Price
    Public Property Price As Decimal
        Get
            Return itemPrice
        End Get
        Set(value As Decimal)
            itemPrice = Format(value, "Currency")
        End Set
    End Property

End Class
