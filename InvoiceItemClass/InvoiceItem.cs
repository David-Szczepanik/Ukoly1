using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceItemClass;
class InvoiceItem
{
    private string id, desc;
    private int qty;
    private double unitPrice;

    public InvoiceItem(string id, string desc, int qty, double unitPrice)
    {
        this.id = id;
        this.desc = desc;
        this.qty = qty;
        this.unitPrice = unitPrice;
    }

    public string getId()
    {
        return id;
    }
    public string getDesc()
    {
        return desc;
    }

    public int Qty
    {
        get { return qty; }
        set { qty = value; }
    }

    public double UnitPrice
    {
        get { return unitPrice; }
        set { unitPrice = value; }
    }

    public double GetTotal()
    {
        return qty * unitPrice;
    }

    public override string ToString()
    {
        return $"InvoiceItem[id={id}, desc={desc}, qty={qty}, unitPrice={unitPrice}]";
    }

}