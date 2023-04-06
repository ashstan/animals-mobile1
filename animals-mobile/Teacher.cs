using System;

namespace animals_mobile
{
    public class Teacher: Person, ITalkable
    {
        private int age;

        public Teacher(string name, int teacherAge) : base(name)
        {
            age = teacherAge;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int teacherAge)
        {
            age = teacherAge;
        }

        public string GetName()
        {
            return Name;
        }
        
        public string Talk()
        {
            return "Don't forget to do the assigned reading!";
        }
        
        public override string ToString()
        {
            return "Teacher: " + "name=" + Name + " age=" + age;
        }
        
    }
}