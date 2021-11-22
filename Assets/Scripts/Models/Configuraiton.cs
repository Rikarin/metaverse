using System.Xml;
using System.Xml.Serialization;

public class Configuraiton : IVisitable {
    [XmlElement("server")]
    public Server Server { get; set; }

    [XmlElement("settings")]
    public Settings[] Settings { get; set; }

    [XmlElement("heightmap")]
    public Heightmap Heightmap { get; set; }

    [XmlElement("size")]
    public Size Size { get; set; }

    [XmlElement("spawnpoint")]
    public Spawnpoint Spawnpoint { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}
