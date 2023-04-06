using System;
using System.Security.Permissions;

namespace animals_mobile
{
    public class Cat : Pet, ITalkable
    {
        private int MousesKilled { get; set; }

        public Cat(string name, int mousesKilled) : base(name)
        {
            //Name = name;
            MousesKilled = mousesKilled;
        }

        public int GetMousesKilled()
        {
            return MousesKilled;
        }

        public void AddMouse()
        {
            MousesKilled++;
        }

        public string GetName()
        {
            return Name;
        }
        
        public string Talk()
        {
            return "Meow";
        }

        public override string ToString()
        {
            return "Cat: " + "name=" + Name + " mousesKilled=" + MousesKilled;
        }
    }
}