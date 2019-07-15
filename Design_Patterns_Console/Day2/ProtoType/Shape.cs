using System;
namespace ProtoType
{
    public abstract class Shape : IProtoType<Shape>
    {
        public abstract Shape clone();
    }
}
