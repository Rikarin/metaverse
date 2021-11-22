public interface IVisitable {
    void Accept(IVisitor visitor);
}

public interface IVisitor {
    void Visit(Dtml dtml);

    void Visit(Configuraiton configuraiton);
    void Visit(Settings settings);
    void Visit(Server server);
    void Visit(Heightmap heightmap);
    void Visit(Spawnpoint spawnpoint);
    void Visit(Size size);

    void Visit(Hud hud);
    void Visit(Button button);

    void Visit(World world);
    void Visit(Box box);
    void Visit(Plane plane);
    void Visit(Sphere sphere);
    void Visit(Cylinder cylinder);
}
