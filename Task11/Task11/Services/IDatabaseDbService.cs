using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task11.Requests_Responces;

namespace Task11.Services
{
    public interface IDatabaseDbService
    {
        List<GetDoctorsResponce> GetDoctors();
        string InsertDoctors(DoctorRequest request);
        string UpdateDoctors(DoctorRequest request);
        string DeleteDoctors(DoctorRequest request);
    }
}
