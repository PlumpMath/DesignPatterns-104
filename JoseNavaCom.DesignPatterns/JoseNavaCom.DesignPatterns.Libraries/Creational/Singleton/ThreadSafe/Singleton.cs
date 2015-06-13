namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Singleton.ThreadSafe
{
    public sealed class Singleton
    {
        //volatile ensure that assignment to the instance variable completes before the instance variable can be accessed
        private static volatile Singleton _instance = null;
        private static object _object = new object();

        private Singleton() { }

        public static Singleton GetInstance()
        {
            //lock makes it thread safe

            lock (_object)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
}
