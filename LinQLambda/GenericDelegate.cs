using System;
namespace LinQLambda
{
	public class GenericDelegate
	{
		public GenericDelegate()
		{
		}
	}

	delegate T MyDele<T>();
	delegate T MyDeleWithP<T>(T a, T b);
}

