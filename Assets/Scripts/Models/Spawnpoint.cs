using System.Xml;
using System.Xml.Serialization;

public class Spawnpoint : IVisitable {
    [XmlAttribute("x")]
    public int X { get; set; }

    [XmlAttribute("y")]
    public int Y { get; set; }

    [XmlAttribute("z")]
    public int Z { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
