using System;
using System.Collections.Generic;

namespace Models
{

	public class ItemRank
	{

		public string QualityName { get; set; }

		public string[] quality = {
			"Poor",
			"Common",
			"Good",
			"Great",
			"Excelent"
		};

		public static int RndAttackDmg(string quality)
		{
			Random rnd = new Random();
			int AttackDamage;

			if (quality == "Poor")
			{
				AttackDamage = rnd.Next(1, 8);
				return AttackDamage;
			}
			else if (quality == "Common")
			{
				AttackDamage = rnd.Next(9, 15);
				return AttackDamage;
			}
			else if (quality == "Good")
			{
				AttackDamage = rnd.Next(16, 24);
				return AttackDamage;
			}
			else if (quality == "Great")
			{
				AttackDamage = rnd.Next(25, 50);
				return AttackDamage;
			}
			else
			{
				AttackDamage = rnd.Next(50, 75);
				return AttackDamage;
			}
		}

	}
}