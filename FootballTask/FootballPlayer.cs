﻿using System;
namespace FootballTask
{
	public abstract class FootballPlayer : Person
	{
        public double Height { get; set; }
        public int Number { get; set; }
        
        public FootballPlayer(string name, int age, int number, double height)
		: base(name,age)
		{
			this.Number = number;
			this.Height = height;
		}
	}
}
