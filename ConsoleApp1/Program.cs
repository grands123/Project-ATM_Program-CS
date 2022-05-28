//Project by Sajakorn Chutikarnmongkol
using System;
namespace atm_program //Project by Sajakorn Chutikarnmongkol
{
	class ab
	{
		static void Main(String[] args)
		{
			int amt = 10000, a, current, pin = 4040, pin1, pin2;

			//read PIN
			Console.WriteLine("Enter the pin");
			pin1 = int.Parse(Console.ReadLine());

			//compare PIN
			if (pin1 == pin)
			{
				Console.WriteLine("1.To check balance");
				Console.WriteLine("2.To withdraw money");
				Console.WriteLine("3.To deposite Money");
				Console.WriteLine("4.To change the pin");
				Console.WriteLine("Enter your choice");
				int ch = int.Parse(Console.ReadLine());
				switch (ch)
				{
					case 1:
						Console.WriteLine("The current balance in your account is" + " " + amt);
						break;

					case 2:
						Console.WriteLine("Enter the amount to withdraw");
						{
							a = int.Parse(Console.ReadLine());
							if (amt >= a)
							{
								if (a % 100 == 0)
								{
									Console.WriteLine("Please collect the cash" + a);
									current = amt - a;
									Console.WriteLine("The current balance is now" + current);
								}
								else
									Console.WriteLine("Please enter the amount to withdraw in the multiples of 100");
							}
							else
								Console.WriteLine("Your account does not have sufficient balance");
						}

						break;

					case 3:
						Console.WriteLine("Enter the amount to be deposite");
						a = int.Parse(Console.ReadLine());
						current = amt + a;
						Console.WriteLine("The current balance in the account is" + current);
						break;

					case 4:
						Console.WriteLine("Want to change your pin");
						Console.WriteLine("Enter your previous pin");
						int prepin = int.Parse(Console.ReadLine());
						if (prepin == pin)
						{
							Console.WriteLine("Enter your new pin");
							pin2 = int.Parse(Console.ReadLine());
							pin1 = pin2;
							Console.WriteLine("Your pin is changed");
						}
						else
							Console.WriteLine("Enter your correct pin");
						break;

					default:
						Console.WriteLine("Please select correct option");
						break;
				}
			}
			else
				Console.WriteLine("Pin is wrong");
		}
	}
}