class Sphere : Circle
{
    public Sphere(double r) : base(r){}
    
    public override double Area()
    {
        return 4 * base.Area();
    }
}