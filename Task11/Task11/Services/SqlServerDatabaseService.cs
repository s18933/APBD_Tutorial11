using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task11.Models;
using Task11.Requests_Responces;

namespace Task11.Services
{
    public class SqlServerDatabaseService : IDatabaseDbService

    {
        private readonly DatabaseDbContext _context;
        public SqlServerDatabaseService(DatabaseDbContext context)
        {
            _context = context;
        }

        public List<GetDoctorsResponce> GetDoctors()
        {
            var doctors = _context.Doctors
                                  .Select(d => new GetDoctorsResponce
                                  {
                                      FirstName = d.FirstName,
                                      LastName = d.LastName,
                                      Email = d.Email
                                  })
                                  .ToList();
            return doctors;
        }

        public string InsertDoctors(DoctorRequest request)
        {
            _context.Doctors.Add(new Doctor
            {
                Id = request.IdDoctor,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            });
            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return null;
            }
            return "A doctor has been successfully added";
        }

        public string UpdateDoctors(DoctorRequest request)
        {
            var update_doctor = new Doctor
            {
                Id = request.IdDoctor,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email
            };

            _context.Update(update_doctor);
            try
            {
                _context.Entry(update_doctor).State = EntityState.Modified;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return null;
            }
            return "A doctor has been successfully updated";
        }
        public string DeleteDoctors(DoctorRequest request)
        {
            var delete_doctor = new Doctor
            {
                Id = request.IdDoctor
            };

            _context.Remove(delete_doctor);
            try
            {
                _context.Entry(delete_doctor).State = EntityState.Deleted;
                _context.SaveChanges();
            }
            catch (Exception)
            {
                return null;
            }
            return "A doctor has been successfully deleted";
        }
    }
}
