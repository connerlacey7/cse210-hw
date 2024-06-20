class Circle : RoundShape
{
    private double _radius;
    public Circle(double r){_radius = r; }

    protected public override double Area()
    {
        return Math.PI * _radius * _radius
    }
}