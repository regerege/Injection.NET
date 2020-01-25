using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Injection.Core.ReflectionHelper;

namespace Injection.Core.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cls = new ClassSample();

            var target = typeof(ClassSample).GetMethod(nameof(ClassSample.GetMethod5));
            var injection = ((Func<string>)GetMethod5_ClassSample).Method;

            cls.GetMethod5().Is("ClassSample.GetMethod5");
            using (Injection.Set(target, injection))
            {
                cls.GetMethod5().Is("Injection.GetMethod5");
            }
            cls.GetMethod5().Is("ClassSample.GetMethod5");
        }

        public string GetMethod5_ClassSample() => "Injection.GetMethod5";
    }
}
