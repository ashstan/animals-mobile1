using System.Security.Cryptography;

namespace animals_mobile
{
    public abstract class Pet
    {
        protected string Name { get; set; }

        protected Pet(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }
    }
}