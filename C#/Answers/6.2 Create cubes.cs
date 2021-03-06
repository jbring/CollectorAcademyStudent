class Cube
{
    double width;
    double height;
    double depth;

    public Cube(double _width, double _height, double _depth)
    {
        width = _width;
        height = _height;
        depth = _depth;
    }

    public double CalculateVolume()
    {
        return width * height * depth;
    }

    public void WriteVolume()
    {
        double volume = CalculateVolume();
        System.Console.WriteLine($"The volume of the cube is {volume}");
    }
}