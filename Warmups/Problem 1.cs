using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace HackerRank
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var userinput = Console.ReadLine().Split(' ');


			//LINQ Solution
			userinput = userinput.Distinct().ToArray();

			/*

			*** Loops Solution But Then We will have to loop Through the Arraylist "newslist" not userinput one ***


			var newslist = new ArrayList();
			for (int i = 0; i < userinput.Length; i++)
			{
				if (newslist.Contains(userinput[i]) == false)
					newslist.Add(userinput[i]);
				   
			}
			*/


			foreach (var item in userinput)
			{
				Console.Write("{0} ", item);
			}

			Console.ReadKey();

		}
	}
}

