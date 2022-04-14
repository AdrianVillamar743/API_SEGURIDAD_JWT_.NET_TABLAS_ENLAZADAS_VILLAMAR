using VILLAMAR_SECURE_API.Models;
using VILLAMAR_SECURE_API.Models.Request;
using System.Linq;

namespace VILLAMAR_SECURE_API.Services.DepServices
{
    public interface IDepartamentoService
    {
        public IQueryable<Departamento> GetAll();
        public void Add(DepartamentoRequest request);
        public void Edit(DepartamentoRequest request);
        public void Delete(int id);
    }
}
