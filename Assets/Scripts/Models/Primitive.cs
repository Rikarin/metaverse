using System.Xml;
using System.Xml.Serialization;

public abstract class Primitive : IVisitable {
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

    public abstract void Accept(IVisitor visitor);
}

public class Box : Primitive {
    public override void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}

public class Plane : Primitive {
    public override void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}

public class Sphere : Primitive {
    public override void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}

public class Cylinder : Primitive {
    public override void Accept(IVisitor visitor) {
        visitor.Visit(this);
    }
}