using VILLAMAR_SECURE_API.Data;
using VILLAMAR_SECURE_API.Models;
using VILLAMAR_SECURE_API.Models.Request;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace VILLAMAR_SECURE_API.Services.EmpServices
{
    public class EmpleadoService : IEmpleadoService
    {

        private readonly VILLAMAR_ASEGUContext _context;

        public EmpleadoService(VILLAMAR_ASEGUContext context)
        {
            _context = context;
        }


        public void Add(EmpleadoRequest request)
        {
             Empleado _empleado = new Empleado();
            _empleado.Nombre = request.Nombre;
            _empleado.IdDepartamento = request.IdDepartamento;
            _context.Add(_empleado);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            try
            {
                Empleado _empleado = _context.Empleados.Find(id);
                _context.Remove(_empleado);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Edit(EmpleadoRequest request)
        {
            try
            {
                Empleado _empleado = _context.Empleados.Find(request.IdEmpleado);
                _empleado.Nombre = request.Nombre;
                _empleado.IdDepartamento = request.IdDepartamento;
                _context.Update(_empleado);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<Empleado> GetAll()
        {
            return _context.Empleados.Include(c => c.IdDepartamentoNavigation).OrderByDescending(a => a.IdEmpleado);

        }
    }
}
