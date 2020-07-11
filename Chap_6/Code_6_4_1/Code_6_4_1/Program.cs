using System;

namespace Code_6_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawingBoard drawingBoard = new DrawingBoard();
            Circle circle = new Circle();
            Square square = new Square();
            drawingBoard.draw(circle);
            drawingBoard.draw(square);
        }
    }
}
