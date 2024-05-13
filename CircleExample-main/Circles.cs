class Circles
{
    float radius;
    public Circles()
    {
       Console.WriteLine("Khong ban kinh khoi tao");
    }
    public Circles( float radius)
    {
      this.radius = radius;
    }
    public float AreaCircle()
    {
      float localRadius = 3.14f*radius*radius;
      return localRadius;
    }
    public float PerimeteCircle()
    {
        return 3.14f*2*radius;
    }
}