namespace Factory;
public class Circle : IShape
{
	public Circle()
	{
	}

	public void Draw()
	{
		int radius = 10;  // Radius of the circle
		int diameter = radius * 2;
		double aspectRatio = 2.5;  // Adjust this value to change the aspect ratio of the circle

		// Loop through rows
		for (int y = -radius; y <= radius; y++)
		{
			// Loop through columns
			for (int x = -diameter; x <= diameter; x++)
			{
				double distance = (x / aspectRatio) * (x / aspectRatio) + y * y;

				if (Math.Abs(distance - radius * radius) < radius)
				{
					Console.Write("*");
				}
				else
				{
					Console.Write(" ");
				}
			}

			Console.WriteLine(); // Move to the next line
		}
	}
}