using Business.Concrete;
using DataAccess.EntityFramework.Concrete;
using System.Net;

ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

ServiceGetAllTest(serviceManager);

static void ServiceGetAllTest(ServiceManager serviceManager)
{
    foreach (var service in serviceManager.GetAll().Data)
    {
        Console.WriteLine(service.ServiceName);
    }
}