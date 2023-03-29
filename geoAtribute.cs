namespace AttributeAndReflections
{
    public class geoAtribute : System.Attribute
    {
        public int X { get; set; }
        public int Y { get; set; }

        public geoAtribute() { }

        public geoAtribute(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}