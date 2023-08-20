namespace Singleton
{

    /*
     * The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. 
     * It's often used for resources that should be shared across the application, like configuration settings or database connections.
     */
    public sealed class Singleton
    {
        private static Singleton? instance;
        private static readonly object lockObject = new(); // For thread safety

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        instance ??= new Singleton();
                    }
                }
                return instance;
            }
        }
    }
}