using System;

namespace JoseNavaCom.DesignPatterns.Libraries.Creational.Singleton.Lazy
{
    public sealed class Singleton
    {
        private static readonly Lazy<Singleton> _singleton = new Lazy<Singleton>(() => new Singleton());

        private Singleton()
        {
        }

        public static Singleton GetInstance()
        {
            return _singleton.Value;
        }

    }
}
