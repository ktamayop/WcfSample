using System.ServiceModel;

namespace WcfService
{
    /// <summary>
    /// This is the contract your service must implement.
    /// </summary>
    [ServiceContract]
    public interface IService1
    {
        /// <summary>
        /// The operation for testing the connection to DB.
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        int Testdb();
    }
}
