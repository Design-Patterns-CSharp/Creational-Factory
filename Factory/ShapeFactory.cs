namespace Factory;
public class ShapeFactory
{
	public ShapeFactory()
	{
	}

	public IShape GetShape(ShapeType type)
	{
		IShape shape;

		if (type == ShapeType.Square)
		{
			shape = new Square();
		}
		else if (type == ShapeType.Circle)
		{
			shape = new Circle();
		}
		else if (type == ShapeType.Rectangle)
		{
			shape = new Rectangle();
		}
		else
		{
			throw new Exception("Type is not valid!");
		}

		return shape;

	}
}
