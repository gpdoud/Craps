using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craps {
	class Program {
		Random rnd = new Random();
		int DiceRoll() {
			var diceone = rnd.Next(6) + 1;
			var dicetwo = rnd.Next(6) + 1;
			Print($"Roll is {diceone + dicetwo}");
			return diceone + dicetwo;
		}
		void CrapsGame() {
			// First Roll
			var dice = DiceRoll();
			if(dice == 7 || dice == 11) {
				Print($"You Won!");
				return;
			} else if(dice == 2 || dice == 3 || dice == 12) {
				Print($"You Lose...");
				return;
			}
			var thePoint = dice;
			Print($"Point is {thePoint}");
			// Second thru Nth roll
			while (true) { // infinite loop
				dice = DiceRoll();
				if (dice == thePoint) {
					Print($"You Won!");
					return;
				} else if (dice == 7) {
					Print($"You Lose...");
					return;
				}
			}

		}
		void Run() {
			var TimesToRun = 10;
			var counter = 0;
			while(counter < TimesToRun) {
				CrapsGame();
				counter++;
			}
		}
		void Print(string msg) {
			Console.WriteLine(msg);
		}
		static void Main(string[] args) {
			new Program().Run();
		}
	}
}
