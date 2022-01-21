using System;

namespace SpAttribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var t = typeof(ISp);
            Console.Write("Type Name : ");
            Console.WriteLine(t.Name);
            var ms = t.GetMethods();
            foreach (var m in ms)
            {
                Console.Write("Method Name : ");
                Console.WriteLine(m.Name);
                var ps = m.GetParameters();
                foreach (var p in ps)
                {
                    Console.Write("Parameter Name : ");
                    Console.WriteLine(p.Name);
                    Console.Write("ParameterType : ");
                    Console.WriteLine(p.ParameterType);
                    Console.Write("ParameterType.IsClass : ");
                    Console.WriteLine(p.ParameterType.IsClass);
                    Console.Write("ParameterType.IsByRef : ");
                    Console.WriteLine(p.ParameterType.IsByRef);
                    Console.Write("ParameterType.IsValueType : ");
                    Console.WriteLine(p.ParameterType.IsValueType);
                    Console.Write("ParameterType.IsPrimitive : ");
                    Console.WriteLine(p.ParameterType.IsPrimitive);
                    Console.Write("ParameterType.IsAnsiClass : ");
                    Console.WriteLine(p.ParameterType.IsAnsiClass);
                    Console.Write("ParameterType.IsNested : ");
                    Console.WriteLine(p.ParameterType.IsNested);
                    Console.Write("ParameterType.IsTypeDefinition : ");
                    Console.WriteLine(p.ParameterType.IsTypeDefinition);
                }

                var mrt = m.ReturnType;
                Console.Write("Return Type : ");
                Console.WriteLine(mrt.Name);

                Console.WriteLine("**********************************************");
            }
            Console.ReadLine();
        }
    }

    public interface ISp
    {
        int Method1(string str);
        SpOutputType Do(SpParamType spParamType);
    }

    public class SpParamType
    {
        public int p1 { get; set; }
        public string p2 { get; set; }
    }

    public class SpOutputType
    {
        public string p1 { get; set; }
        public int p2 { get; set; }
    }
}
