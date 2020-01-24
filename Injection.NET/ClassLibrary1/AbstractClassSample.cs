namespace ClassLibrary1
{
    public abstract class AbstractClassSample
    {
        #region Methods

        #region static
        public static string GetMethod2Call() => GetMethod2();
        public static string GetMethod3Call() => GetMethod3();
        public static string GetMethod4Call() => GetMethod4();

        public static string GetMethod1()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod1)}";
        }
        internal static string GetMethod2()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod2)}";
        }
        protected static string GetMethod3()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod3)}";
        }
        private static string GetMethod4()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod4)}";
        }
        #endregion

        #region normal
        public string GetMethod6Call() => GetMethod6();
        public string GetMethod7Call() => GetMethod7();
        public string GetMethod8Call() => GetMethod8();

        public string GetMethod5()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod5)}";
        }
        internal string GetMethod6()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod6)}";
        }
        protected string GetMethod7()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod7)}";
        }
        private string GetMethod8()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod8)}";
        }
        #endregion

        #region virtual
        public string GetMethod9Call() => GetMethod9();
        public string GetMethod10Call() => GetMethod10();
        public string GetMethod11Call() => GetMethod11();

        public virtual string GetMethod9()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod9)}";
        }
        internal virtual string GetMethod10()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod10)}";
        }
        protected virtual string GetMethod11()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod11)}";
        }
        #endregion

        #region etc
        public string GetMethod12<T>()
        {
            return $"{nameof(AbstractClassSample)}.{nameof(GetMethod12)}:{typeof(T).Name}";
        }
        public int GetMethod13(int a, int b)
        {
            return a + b;
        }
        #endregion

        #region abstract

        public string GetMethod14Call() => GetMethod14();
        public abstract string GetMethod14();

        #endregion

        #endregion

        #region Properties

        public static string Property1 => $"{nameof(AbstractClassSample)}.{nameof(Property1)}";
        public string Property2 => $"{nameof(AbstractClassSample)}.{nameof(Property2)}";
        public string Property3 { get; set; }
        public virtual string Property4 => $"{nameof(AbstractClassSample)}.{nameof(Property4)}";
        public abstract string Property5 { get; set; }
        public string Property5Call => Property5;

        #endregion
    }
}
