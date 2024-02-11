using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;
//interfaceler newlenemez ref. tutuculardır
public class PttManager:ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantservice) //constructor new yapıldığında çalışır.
    {
        _applicantService = applicantservice;
    }

    public void GiveMask(Citizen citizen)
    {
       
        if (_applicantService.CheckCitizen(
            citizen))
        {
            Console.WriteLine(citizen.FirstName + " için maske verildi.");
        }
        else
        {
            Console.WriteLine(citizen.FirstName + " için maske VERİLEMEDİ.");
        }
    }
}
