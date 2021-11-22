using System.Xml;
using System.Xml.Serialization;

public class Box : IVisitable {
    [XmlAttribute("class")]
    public string Class { get; set; }

    [XmlAttribute("click")]
    public string Click { get; set; }

    [XmlAttribute("size")]
    public string Size { get; set; }

    [XmlAttribute("rotation")]
    public string Rotation { get; set; }

    [XmlAttribute("position")]
    public string Position { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
