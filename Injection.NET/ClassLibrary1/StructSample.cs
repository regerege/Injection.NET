namespace ClassLibrary1
{
    public struct StructSample
    {
        public static string GetMethod1()
        {
            return $"{nameof(StructSample)}.{nameof(GetMethod1)}";
        }
        internal static string GetMethod2()
        {
            return $"{nameof(StructSample)}.{nameof(GetMethod2)}";
        }
        private static string GetMethod3()
        {
            return $"{nameof(StructSample)}.{nameof(GetMethod3)}";
        }

        public string GetMethod4()
        {
            return $"{nameof(StructSample)}.{nameof(GetMethod4)}";
        }
        internal string GetMethod5()
        {
            return $"{nameof(StructSample)}.{nameof(GetMethod5)}";
        }
        private string GetMethod6()
        {
            return $"{nameof(StructSample)}.{nameof(GetMethod6)}";
        }

        public string GetMethod7<T>()
        {
            return $"{nameof(StructSample)}.{nameof(GetMethod7)}:{typeof(T).Name}";
        }
        public int GetMethod8(int a, int b)
        {
            return a + b;
        }

        public static string Property1 => $"{nameof(StructSample)}.{nameof(Property1)}";
        public string Property2 => $"{nameof(StructSample)}.{nameof(Property2)}";
        public string Property3 { get; set; }
    }
}
