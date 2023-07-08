namespace Factory;
public class Rectangle : IShape
{
	public Rectangle()
	{
	}
	public void Draw()
	{
		int width = 8;  // Width of the rectangle
		int height = 4; // Height of the rectangle

		// Loop through rows
		for (int i = 0; i < height; i++)
		{
			// Loop through columns
			for (int j = 0; j < width; j++)
			{
				Console.Write("*");
			}

			Console.WriteLine(); // Move to the next line		
		}
	}
}
