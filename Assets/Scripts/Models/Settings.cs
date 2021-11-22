using System.Xml;
using System.Xml.Serialization;

public class Settings : IVisitable {
    [XmlAttribute("name")]
    public string Name { get; set; }

    [XmlAttribute("value")]
    public string Value { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
