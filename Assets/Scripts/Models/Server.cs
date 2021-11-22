using System.Xml;
using System.Xml.Serialization;

public class Server : IVisitable {
    [XmlAttribute("link")]
    public string Link { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
