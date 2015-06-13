namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Singleton.NestedClass
{
    //Lazy loaded
    public sealed class Singleton
    {
        private Singleton() { }

        public static Singleton GetInstance()
        {
            return Nested.instance;
        }

        private class Nested
        {
            static Nested() { }

            internal static readonly Singleton instance = new Singleton();
        }
    }
}
