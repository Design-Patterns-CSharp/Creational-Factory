namespace Factory;

public class Square : IShape
{
	public Square()
	{

	}

	public void Draw()
	{
		int size = 5; // Size of the square

		// Loop through rows
		for (int i = 0; i < size; i++)
		{
			// Loop through columns
			for (int j = 0; j < size; j++)
			{
				Console.Write("*");
			}

			Console.WriteLine(); // Move to the next line
		}
	}
}
