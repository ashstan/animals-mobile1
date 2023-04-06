namespace animals_mobile
{
    public abstract class Person
    {
        protected string Name { get; set; }

        protected Person(string name)
        {
            Name = name;
        }
        
        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }
    }
}