using System;
namespace FootballTask
{
	public abstract class Person
	{
        public int Age { get; set; }
        public string Name { get; set; }
        
        public Person(string name, int age)
		{
			this.Name = name;
			this.Age = age;
		}
	}
}

