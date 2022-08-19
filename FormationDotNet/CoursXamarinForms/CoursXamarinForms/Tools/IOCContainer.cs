using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CoursXamarinForms.Tools
{
    public class IOCContainer
    {
        private Dictionary<Type, Type> _types = new Dictionary<Type, Type>();

        public void Register<T,V>(T interfaceType, V instanceType)
        {
            _types.Add(interfaceType.GetType(), instanceType.GetType());
        }

        public T Resolve<T>()
        {
            Type type = _types[typeof(T)];
            ConstructorInfo[] constructors = type.GetConstructors();
            ParameterInfo[] parameterInfos = constructors[0].GetParameters();
            List<object> parameters = new List<object>();
            foreach(ParameterInfo parameterInfo in parameterInfos)
            {
                Type t = _types[parameterInfo.ParameterType];
                parameters.Add((T)t.GetConstructor(new Type[0]).Invoke(new object[0]));
            }
            return (T)type.GetConstructor(new Type[0]).Invoke(parameters.ToArray());
        }
    }
}
