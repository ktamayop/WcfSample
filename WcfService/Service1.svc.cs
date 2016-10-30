namespace WcfService
{
    /// <summary>
    /// Service class implementing the IService1 contract
    /// </summary>
    public class Service1 : IService1
    {
        /// <summary>
        /// Tests the connection to the Database system.
        /// </summary>
        /// <returns></returns>
        public int Testdb()
        {
            return 1;
        }
    }
}