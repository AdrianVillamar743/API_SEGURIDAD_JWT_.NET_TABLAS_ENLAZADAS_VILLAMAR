using VILLAMAR_SECURE_API.Data;
using VILLAMAR_SECURE_API.Models;
using VILLAMAR_SECURE_API.Models.Request;
using System;
using System.Linq;

namespace VILLAMAR_SECURE_API.Services.DepServices
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly VILLAMAR_ASEGUContext _context;

        public DepartamentoService(VILLAMAR_ASEGUContext context)
        {
            _context = context;
        }


        public void Add(DepartamentoRequest request)
        {
            Departamento _departamento = new Departamento();
            _departamento.Nombre = request.Nombre;
            _context.Add(_departamento);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            try
            {
                Departamento _departamento=_context.Departamentos.Find(id);
                _context.Remove(_departamento);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(DepartamentoRequest request)
        {
            try
            {
                Departamento _departamento = _context.Departamentos.Find(request.IdDepartamento);
                _departamento.Nombre=request.Nombre;
                _context.Update(_departamento);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Departamento> GetAll()
        {
            return _context.Departamentos.OrderByDescending(c => c.IdDepartamento);
        }
    }
}
