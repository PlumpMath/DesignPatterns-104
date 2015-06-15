using System;

namespace JoseNavaCom.DesignPatterns.Libraries.Structural.Adapter
{
    public class Client
    {
        private readonly ITarget _target;

        public Client(ITarget target)
        {
            if (target == null)
            {
                throw new ArgumentNullException("target", "You did not pass a target");
            }

            _target = target;
        }

        public string MakeRequest()
        {
            return _target.GetMethodA();
        }

    }
}
