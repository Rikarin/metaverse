using System.Xml;
using System.Xml.Serialization;

public class Heightmap : IVisitable {
    [XmlAttribute("src")]
    public string Src { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
