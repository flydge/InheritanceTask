using System;
using System.Collections.Generic;

namespace InheritanceTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Human human = new Human(40,"just Human",178,"Man");
            Boy boy = new Boy(12,"Ioan",167.5,"Tanya");
            Girl girl = new Girl(13,"Tanya",163.2,"Ioan");
            
            Console.WriteLine(String.Format("Human:{0}\nBoy:{1}\n\nGirl:{2}",human,boy,girl));
            
        }
    }
}