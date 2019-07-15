using System;
using System.Collections.Generic;

namespace ProtoType
{
    public class ShapeContainer : IProtoType<ShapeContainer>
    {
        List<Shape> shapes;

        public ShapeContainer()
        {
            shapes = new List<Shape>();
        }

        public ShapeContainer(List<Shape> shapes)
        {
            this.shapes = shapes;
        }

        public void addItem(Shape shape)
        {
            shapes.Add(shape);
        }

        public Shape getItem(int index)
        {
            return shapes[index];
        }

        public ShapeContainer clone()
        {
            List<Shape> temp= new List<Shape>();

            foreach (var shape in shapes)
            {
                temp.Add(shape.clone());
            }

            return new ShapeContainer(temp);
        }



        public override string ToString()
        {
            string toRet = "";
            foreach (var shape in shapes)
            {
                toRet += shape.ToString() + "\n";
            }

            return $"Container : {toRet}";
        }
    }
}
