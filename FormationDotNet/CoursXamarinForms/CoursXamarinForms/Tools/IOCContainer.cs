using System;
using System.Collections.Generic;
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
    }
}
