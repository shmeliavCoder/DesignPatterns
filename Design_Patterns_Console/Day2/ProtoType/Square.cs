using System;

namespace ProtoType
{
    public class Square : Shape
    {
        public Point TL { get; set; }
        public Point BR { get; set; }

        public Square(Point TL, Point BR)
        {
            this.TL = TL;
            this.BR = BR;
        }

        public override string ToString()
        {
            return $"Point : (TL = {TL} , BR = {BR})";
        }

        public override Shape clone()
        {
            return new Square((Point)this.TL.clone(), (Point)this.BR.clone());
        }
    }
}
