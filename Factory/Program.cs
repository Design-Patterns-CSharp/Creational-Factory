using System.Drawing;

namespace Factory;

internal class Program
{
	static void Main(string[] args)
	{
		while (true)
		{
			Console.WriteLine("Enter number of shape to draw it (1: Circle | 2: Squre | 3: Rectangle)");

			var input = Console.ReadLine();

			if (Enum.TryParse(input, true, out ShapeType shapeType))
			{
				var shapeFactory = new ShapeFactory();

				var shape = shapeFactory.GetShape(shapeType);

				shape.Draw();
			}
		}
	}
}

/*
	برای کلاس هایی با ویژگی های مشترک و یک 
	interface
	واحد که بر اساس ورودی مختلف نیاز است از آن اینترفیس 
	کلاس ها را بسازیم٬ یک کلاس به عنوان فکتوری می سازیم و از آن کلاس در برنامه ی خود
	برای شیء سازی استفاده میکنیم
*/