using Business.Abstract;
using Business.Utilities.Messages;
using Core.Results;
using DataAccess.EntityFramework.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ServiceManager : IServiceService
    {
        IServiceDal serviceDal;
        public ServiceManager(IServiceDal _serviceDal)
        {
            serviceDal = _serviceDal;
        }
        public IResult Add(Service service)
        {
            serviceDal.Add(service);
            return new SuccessResult();
        }

        public IResult Delete(Service service)
        {
            serviceDal.Delete(service);
            return new SuccessResult();
        }

        public IDataResult<List<Service>> GetAll()
        {
            return new SuccessDataResult<List<Service>>(serviceDal.GetAll(), Messages.ServicesListed);
        }

        public IDataResult<Service> GetById(int id)
        {
            return new SuccessDataResult<Service>(serviceDal.Get(s => s.ServiceId == id));
        }

        public IResult Update(Service service)
        {
            serviceDal.Update(service);
            return new SuccessResult();
        }
    }
}
