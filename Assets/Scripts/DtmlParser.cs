using System.IO;
using System.Xml;
using System.Xml.Serialization;

public class DtmlParser {
    public string DtmlText { get; }
    public Dtml Dtml { get; private set; }

    public DtmlParser(string dtml) {
        DtmlText = dtml;
    }

    public void Parse() {
        var serializer = new XmlSerializer(typeof(Dtml));

        using (var reader = new StringReader(DtmlText)) {
            Dtml = serializer.Deserialize(reader) as Dtml;
        }
    }
}
