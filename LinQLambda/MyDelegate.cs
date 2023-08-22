using System;
namespace LinQLambda
{
	public class MyDelegate
	{
		public MyDelegate()
		{
		}
	}

	delegate void MyDele();
	delegate int IntDele(int x, int y);

	class Student
	{
		public void SayHello()
		{
			Console.WriteLine("I am student");
		}
	}
}

