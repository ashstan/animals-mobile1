using System;
using System.Security.Permissions;

namespace animals_mobile
{
    public class Dog : Pet, ITalkable
    {
        private bool friendly;

        public Dog(string name, bool friendly) : base(name)
        {
            //Name = name;
            this.friendly = friendly;
        }

        public bool IsFriendly()
        {
            return friendly;
        }

        public string GetName()
        {
            return Name;
        }
        
        public string Talk()
        {
            return "Bark";
        }

        public override string ToString()
        {
            return "Dog: " + "name=" + Name + " friendly=" + friendly;
        }
    }
}