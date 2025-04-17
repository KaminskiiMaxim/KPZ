using System;

namespace BridgeExample
{
    interface IRenderer
    {
        void Render(string shapeName);
    }

    class VectorRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Малюю {shapeName} як вектор");
        }
    }

    class RasterRenderer : IRenderer
    {
        public void Render(string shapeName)
        {
            Console.WriteLine($"Малюю {shapeName} як пікселі");
        }
    }
    // Створіть базовий клас Shape
    abstract class Shape
    {
        protected IRenderer renderer;

        public Shape(IRenderer renderer)
        {
            this.renderer = renderer;
        }

        public abstract void Draw();
    }

    // Фігури (Дочірні класи Circle, Square, Triangle)
    class Circle : Shape
    {
        public Circle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Коло");
        }
    }

    class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Квадрат");
        }
    }

    class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer) { }

        public override void Draw()
        {
            renderer.Render("Трикутник");
        }
    }

    class Program
    {
        //Перевірка в Main()
        static void Main(string[] args)
        {
            // Векторне коло
            Shape shape1 = new Circle(new VectorRenderer());
            shape1.Draw();

            // Растровий квадрат
            Shape shape2 = new Square(new RasterRenderer());
            shape2.Draw();

            // Векторний трикутник
            Shape shape3 = new Triangle(new VectorRenderer());
            shape3.Draw();

            Console.ReadLine();
        }
    }
}
