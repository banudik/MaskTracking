using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class ForeignerManager : IApplicantService
{
    public void ApplyForMask(Citizen citizen)
    {
        throw new NotImplementedException();
    }

    public bool CheckCitizen(Citizen citizen)
    {
        throw new NotImplementedException();
    }

    public List<Citizen> GetList()
    {
        throw new NotImplementedException();
    }
}
