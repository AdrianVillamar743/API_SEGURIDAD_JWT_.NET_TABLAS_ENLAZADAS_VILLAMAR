using VILLAMAR_SECURE_API.Models;
using VILLAMAR_SECURE_API.Models.Request;
using System.Linq;

namespace VILLAMAR_SECURE_API.Services.EmpServices
{
    public interface IEmpleadoService
    {
        public IQueryable<Empleado> GetAll();
        public void Add(EmpleadoRequest request);
        public void Edit(EmpleadoRequest request);
        public void Delete(int id);
    }
}
