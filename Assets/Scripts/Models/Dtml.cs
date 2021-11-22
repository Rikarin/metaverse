using System.Xml;
using System.Xml.Serialization;

[XmlRootAttribute("dtml")]
public class Dtml : IVisitable {
    [XmlAttribute("version")]
    public string Version { get; set; }

    [XmlElement("configuration")]
    public Configuraiton Configuraiton { get; set; }

    [XmlElement("hud")]
    public Hud Hud { get; set; }

    [XmlElement("world")]
    public World World { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
