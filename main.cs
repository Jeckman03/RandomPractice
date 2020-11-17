using System;
using Models;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {

		CreateItem();

    Console.ReadLine();
  }

	private static void CreateItem()
	{
		Items newItem = new Items();

		Random rnd = new Random();

		newItem.Name = newItem.items[rnd.Next(0, newItem.items.Length)];

		ItemRank newQuality = new ItemRank();

		Random rnd2 = new Random();

		newQuality.QualityName = newQuality.quality[rnd2.Next(0, newQuality.quality.Length)];

		int damage = ItemRank.RndAttackDmg(newQuality.QualityName);

		Console.WriteLine(newQuality.QualityName + " " + newItem.Name);
		Console.WriteLine(damage);
	}

	//public static void DisplayItem()
	//{
//
	//}

}