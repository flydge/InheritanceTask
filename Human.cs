using System;

namespace InheritanceTask
{
    public class Human
    {
        private int _age;
        private string _name;
        private double _height;
        private string _gender;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public double Height
        {
            get => _height;
            set => _height = value;
        }

        public virtual string Gender
        {
            get => _gender;
            set => _gender = value;
        }

        
        

        public Human(int age, string name, double height, string gender)
        {
            _age = age;
            _name = name;
            _height = height;
            _gender = gender;
        }
        
        


        public override string ToString()
        {
            return String.Format("\nName:{0}\nAge:{1}\nHeight:{2}\nGender:{3}\n",_name,_age,_height,_gender);
        }
    }
}