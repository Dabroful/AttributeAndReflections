namespace AttributeAndReflections
{
    
    public class Photo
    {
        [geoAtribute(10, 20)]
        public string Path { get; set; }
        public string Name { get; set; }

        public Photo(string name)
        {
            Name = name;
        }
    }
}