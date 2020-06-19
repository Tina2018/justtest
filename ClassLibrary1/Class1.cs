using System;

namespace ClassLibrary1
{
    public class Class1
    {
		public int SuppressJitTest()
		{
			int result = 0;

			for (int i = 0; i < 10; i++)
			{
				int nouse = 10;

				result += i;
			}

			return result;
		}
	}
}
