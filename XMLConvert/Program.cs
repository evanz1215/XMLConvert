using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

var xmlString = File.ReadAllText("PurchaseOrder.xml");

// 1. 傳統方法: 轉成PurchaseOrder物件 (推薦)

var serializer = new XmlSerializer(typeof(PurchaseOrder));
using var reader = new StringReader(xmlString);
var purchaseOrder = (PurchaseOrder)serializer.Deserialize(reader)!;

Console.WriteLine("information from xml:");
Console.WriteLine("part no:");

foreach (var item in purchaseOrder.Items)
{
    Console.WriteLine(item.PartNumber);
}
Console.WriteLine();

// 2. 傳統方法: 使用 XmlDocument, 操作xml node(節點), 非物件操作 (不推薦)
// https://learn.microsoft.com/zh-tw/dotnet/api/system.xml.xmlnode.selectnodes?view=net-8.0
Console.WriteLine("using XmlDocument");

var doc = new XmlDocument();
doc.LoadXml(xmlString);

// https://learn.microsoft.com/zh-tw/dotnet/api/system.xml.xmlnode.selectnodes?view=net-8.0#system-xml-xmlnode-selectnodes(system-string)
// https://learn.microsoft.com/zh-tw/previous-versions/dotnet/netframework-4.0/ms256086(v=vs.100)
var partNumbers = doc.SelectNodes("//@PartNumber");

Console.WriteLine("part numbers in doc:");
foreach (XmlNode node in partNumbers)
{
    Console.WriteLine(node.InnerText);
}
Console.WriteLine();

// 3. 使用LINQ方法: 直接使用LINQ操作xml字串取得並要資訊 (推薦)
Console.WriteLine("using LINQ:");

var xml = XElement.Parse(xmlString);
var partNos = xml.Descendants("Item").Select(x => (string)x.Attribute("PartNumber")).ToList();

foreach (var partNo in partNos)
{
    Console.WriteLine(partNo);
}
Console.WriteLine();


var query = from item in xml.Descendants("Item")
            let partNo = (string)item.Attribute("PartNumber")
            //let productName = (string)item.Element("ProductName")
            let quantity = (int)item.Element("Quantity")
            let unitPrice = (double)item.Element("USPrice")
            select new { partNo, quantity, unitPrice };
var list = query.ToList();

list.ForEach(x =>
{
    Console.WriteLine($"{x.partNo}, {x.quantity}, {x.unitPrice}");
});
Console.WriteLine();
