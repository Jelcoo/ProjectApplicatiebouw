using System.Reflection;

namespace ChapeauUI.Helpers
{
    public static class ObjectHelpers
    {
        public static T DeepCopy<T>(T obj)
        {
            ConstructorInfo constructor = obj.GetType().GetConstructors().FirstOrDefault(c => c.GetParameters().Length == 0);
            if (constructor == null)
            {
                throw new ArgumentException($"Type {obj.GetType()} does not have a parameterless constructor");
            }

            T copy = (T)constructor.Invoke(new object[] { });

            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (property.CanRead && property.CanWrite)
                {
                    property.SetValue(copy, property.GetValue(obj));
                }
            }

            return copy;
        }
    }
}
