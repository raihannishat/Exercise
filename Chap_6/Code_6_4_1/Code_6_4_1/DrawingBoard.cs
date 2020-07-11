using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_4_1
{
    public class DrawingBoard
    {
        public void draw(Shape shape)
        {
            Console.WriteLine($"Drawing a shape: {shape.getName()}");
            string typeName = shape.GetType().Name;
            string supperClassType = shape.GetType().BaseType.Name;
            Console.WriteLine($"TypeName: {typeName}");
            Console.WriteLine($"SupperClass: {supperClassType}");
        }
    }
}
