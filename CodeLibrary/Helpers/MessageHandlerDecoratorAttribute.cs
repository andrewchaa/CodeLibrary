using System;

namespace CodeLibrary.Helpers
{
    [AttributeUsage(AttributeTargets.Method)]
    public abstract class MessageHandlerDecoratorAttribute : Attribute
    {
        public int Order { get; private set; }

        public abstract Type DecoratorType { get; }

        protected MessageHandlerDecoratorAttribute()
        {
        }

        protected MessageHandlerDecoratorAttribute(int order)
        {
            this.Order = order;
        }
    }
}