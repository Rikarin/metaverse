using System.Xml;
using System.Xml.Serialization;

public class Hud : IVisitable {
    [XmlElement("style")]
    public string[] Style { get; set; }

    [XmlElement("script")]
    public string[] Script { get; set; }

    [XmlElement("button")]
    public Button[] Buttons { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}


public class Button : IVisitable {
    // [XmlElement("style")]
    // public string[] Style { get; set; }

    // [XmlElement("script")]
    // public string[] Script { get; set; }

    public void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}