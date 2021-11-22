using System.Xml;
using System.Xml.Serialization;

public class World : IVisitable {
    [XmlElement("style")]
    public string[] Styles { get; set; }

    [XmlElement("script")]
    public string[] Scripts { get; set; }

    [XmlElement("box")]
    public Box[] Boxes { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
