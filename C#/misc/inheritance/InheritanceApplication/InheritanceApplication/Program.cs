using System;

namespace RectangleApplication
{

	class Rectangle
	{
		//member variables
		protected double length;
		protected double width;

		public Rectangle(double l, double w)
		{
			length = l;
			width = w;
		}

		public double GetArea()
		{
			return length * width;
		}

		public void Display()
		{
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("Width: {0}", width);
			Console.WriteLine("Area: {0}", GetArea());
		}
	}


	class Tabletop : Rectangle
	{	
				
		public Tabletop(double l, double w) : base(l, w) { }

		public double GetCost()
		{
			return GetArea() * 70;			
		}

		public new void Display()
		{
			base.Display();
			Console.WriteLine("Cost: {0}", GetCost());
		}
	}

	class ExecuteRectangle
	{

		static void Main(string[] args)
		{
			Tabletop t = new Tabletop(4.5, 7.5);
			t.Display();
			Console.ReadLine();
		}
	}
}