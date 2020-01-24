namespace ClassLibrary1
{
    public class ClassSample
    {
        #region Methods

        #region static
        public static string GetMethod2Call() => GetMethod2();
        public static string GetMethod3Call() => GetMethod3();
        public static string GetMethod4Call() => GetMethod4();

        public static string GetMethod1()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod1)}";
        }
        internal static string GetMethod2()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod2)}";
        }
        protected static string GetMethod3()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod3)}";
        }
        private static string GetMethod4()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod4)}";
        }
        #endregion

        #region Normal
        public string GetMethod6Call() => GetMethod6();
        public string GetMethod7Call() => GetMethod7();
        public string GetMethod8Call() => GetMethod8();

        public string GetMethod5()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod5)}";
        }
        internal string GetMethod6()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod6)}";
        }
        protected string GetMethod7()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod7)}";
        }
        private string GetMethod8()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod8)}";
        }
        #endregion

        #region virtual
        public string GetMethod9Call() => GetMethod9();
        public string GetMethod10Call() => GetMethod10();
        public string GetMethod11Call() => GetMethod11();

        public virtual string GetMethod9()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod9)}";
        }
        internal virtual string GetMethod10()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod10)}";
        }
        protected virtual string GetMethod11()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod11)}";
        }
        #endregion

        #region etc
        public string GetMethod12<T>()
        {
            return $"{nameof(ClassSample)}.{nameof(GetMethod12)}:{typeof(T).Name}";
        }
        public int GetMethod13(int a, int b)
        {
            return a + b;
        }
        #endregion

        #endregion

        #region Properties

        public static string Property1 => $"{nameof(ClassSample)}.{nameof(Property1)}";
        public string Property2 => $"{nameof(ClassSample)}.{nameof(Property2)}";
        public string Property3 { get; set; }
        public virtual string Property4 => $"{nameof(ClassSample)}.{nameof(Property4)}";

        #endregion

        public class InnerClassSample
        {
            #region Methods

            #region static
            public static string GetMethod2Call() => GetMethod2();
            public static string GetMethod3Call() => GetMethod3();
            public static string GetMethod4Call() => GetMethod4();

            public static string GetMethod1()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod1)}";
            }
            internal static string GetMethod2()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod2)}";
            }
            protected static string GetMethod3()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod3)}";
            }
            private static string GetMethod4()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod4)}";
            }
            #endregion

            #region Normal
            public string GetMethod6Call() => GetMethod6();
            public string GetMethod7Call() => GetMethod7();
            public string GetMethod8Call() => GetMethod8();

            public string GetMethod5()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod5)}";
            }
            internal string GetMethod6()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod6)}";
            }
            protected string GetMethod7()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod7)}";
            }
            private string GetMethod8()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod8)}";
            }
            #endregion

            #region virtual
            public string GetMethod9Call() => GetMethod9();
            public string GetMethod10Call() => GetMethod10();
            public string GetMethod11Call() => GetMethod11();

            public virtual string GetMethod9()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod9)}";
            }
            internal virtual string GetMethod10()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod10)}";
            }
            protected virtual string GetMethod11()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod11)}";
            }
            #endregion

            #region etc
            public string GetMethod12<T>()
            {
                return $"{nameof(InnerClassSample)}.{nameof(GetMethod12)}:{typeof(T).Name}";
            }
            public int GetMethod13(int a, int b)
            {
                return a + b;
            }
            #endregion

            #endregion

            #region Properties

            public static string Property1 => $"{nameof(InnerClassSample)}.{nameof(Property1)}";
            public string Property2 => $"{nameof(InnerClassSample)}.{nameof(Property2)}";
            public string Property3 { get; set; }
            public virtual string Property4 => $"{nameof(InnerClassSample)}.{nameof(Property4)}";

            #endregion
        }
    }
}
