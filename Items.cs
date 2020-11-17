using System;
using System.Collections.Generic;

namespace Models
{

	public class Items
	{

		public string Name { get; set; }
		public int AttackDamage { get; set; }

		public string[] items = {
			"Short Sword", 
			"Long Sword", 
			"Wand", 
			"Wooden Bow",
			"Iron Mace",
			"Spear",
			"Crossbow"
		};

	}
}