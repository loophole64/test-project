// A Simple C# Application
using System;

class TestApp
{
	static void Main()
	{
		Console.WriteLine("Testing! 1, 2, 3");
		
		HelloMessage h = new HelloMessage();
		h.Speak();
	}
}