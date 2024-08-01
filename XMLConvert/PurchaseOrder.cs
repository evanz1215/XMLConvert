
// 注意: 產生的程式碼可能至少需要 .NET Framework 4.5 或 .NET Core/Standard 2.0。
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class PurchaseOrder
{

    private PurchaseOrderAddress[] addressField;

    private string deliveryNotesField;

    private PurchaseOrderItem[] itemsField;

    private uint purchaseOrderNumberField;

    private System.DateTime orderDateField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Address")]
    public PurchaseOrderAddress[] Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public string DeliveryNotes
    {
        get
        {
            return this.deliveryNotesField;
        }
        set
        {
            this.deliveryNotesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable = false)]
    public PurchaseOrderItem[] Items
    {
        get
        {
            return this.itemsField;
        }
        set
        {
            this.itemsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public uint PurchaseOrderNumber
    {
        get
        {
            return this.purchaseOrderNumberField;
        }
        set
        {
            this.purchaseOrderNumberField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "date")]
    public System.DateTime OrderDate
    {
        get
        {
            return this.orderDateField;
        }
        set
        {
            this.orderDateField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class PurchaseOrderAddress
{

    private string nameField;

    private string streetField;

    private string cityField;

    private string stateField;

    private uint zipField;

    private string countryField;

    private string typeField;

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Street
    {
        get
        {
            return this.streetField;
        }
        set
        {
            this.streetField = value;
        }
    }

    /// <remarks/>
    public string City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public string State
    {
        get
        {
            return this.stateField;
        }
        set
        {
            this.stateField = value;
        }
    }

    /// <remarks/>
    public uint Zip
    {
        get
        {
            return this.zipField;
        }
        set
        {
            this.zipField = value;
        }
    }

    /// <remarks/>
    public string Country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class PurchaseOrderItem
{

    private string productNameField;

    private byte quantityField;

    private decimal uSPriceField;

    private System.DateTime shipDateField;

    private bool shipDateFieldSpecified;

    private string commentField;

    private string partNumberField;

    /// <remarks/>
    public string ProductName
    {
        get
        {
            return this.productNameField;
        }
        set
        {
            this.productNameField = value;
        }
    }

    /// <remarks/>
    public byte Quantity
    {
        get
        {
            return this.quantityField;
        }
        set
        {
            this.quantityField = value;
        }
    }

    /// <remarks/>
    public decimal USPrice
    {
        get
        {
            return this.uSPriceField;
        }
        set
        {
            this.uSPriceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime ShipDate
    {
        get
        {
            return this.shipDateField;
        }
        set
        {
            this.shipDateField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool ShipDateSpecified
    {
        get
        {
            return this.shipDateFieldSpecified;
        }
        set
        {
            this.shipDateFieldSpecified = value;
        }
    }

    /// <remarks/>
    public string Comment
    {
        get
        {
            return this.commentField;
        }
        set
        {
            this.commentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string PartNumber
    {
        get
        {
            return this.partNumberField;
        }
        set
        {
            this.partNumberField = value;
        }
    }
}

