using System.ServiceModel;

namespace WcfService
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        int Testdb();
    }
}
