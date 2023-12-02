using System;

// Задача 1 --------------------------------------------------------

// namespace task_4
// {
// 	public class Program {
// 		public static void Main(string [] args){
// 			System.Console.Write("Input number => ");
// 			int ? numInt = Convert.ToInt32(Console.ReadLine());
			
// 			while(numInt != 7 && numInt != 23) {
// 				System.Console.WriteLine($"Incorrectly, the number {numInt} is not equal to the numbers 7 and 23");
// 				System.Console.Write("Input number again => ");
// 				numInt = Convert.ToInt32(Console.ReadLine());
// 			} 
// 			System.Console.WriteLine($"That's right, the correct number is {numInt}");
// 		}
// 	}
// }

// Задача 2 --------------------------------------------------------


// namespace task_4
// {
// 	public class Program {
// 		public static void Main(string [] args){
// 			System.Console.Write("Input coordinats with spase => ");
// 			string ? nubers = Console.ReadLine();

// 			string[] ? numbersArr = nubers.Split(" ");
// 			int num1 = Convert.ToInt32(numbersArr[0]);
// 			int num2 = Convert.ToInt32(numbersArr[1]);

// 			string ? quarter = num1 > 0 && num2 > 0 ? "1" : num1 < 0 && num2 > 0 ? "2" : num1 < 0 && num2 < 0 ? "3" : "4";
// 			System.Console.Write(quarter);

// 		}
// 	}
// }


// Задача 3 --------------------------------------------------------

// namespace task_4
// {
// 	public class Program {
// 		public static void Main(string [] args){
// 			System.Console.Write("Input number => ");
// 			int number = Convert.ToInt32(Console.ReadLine());
						
// 			while(!(number > 9) || !(number < 100)) {
// 				System.Console.WriteLine($"The number must be between 10 and 99");
// 				System.Console.Write("Input number again => ");
// 				number = Convert.ToInt32(Console.ReadLine());
// 			}  

// 			int firstDigit = number / 10;
// 			int secondDigit = number % 10;

// 			System.Console.WriteLine($"Mаксимальное число {Math.Max(firstDigit,secondDigit)} из введенного {number}");
// 		}
// 	}
// }


// Задача 4 --------------------------------------------------------

// namespace task_4
// {
// 	public class Program {
// 		public static void Main(string [] args){
// 			string phrase = "Урааа, я нашел решение";
// 			char[] words = phrase.Replace(" ", "").ToArray();
// 			string stringDevaid = string.Join(",",words);
// 			System.Console.Write(stringDevaid);
// 		}
// 	}
// }
