using VILLAMAR_SECURE_API.Models.Request;
using VILLAMAR_SECURE_API.Respo;
using VILLAMAR_SECURE_API.Services.EmpServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;
namespace VILLAMAR_SECURE_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {

        private readonly IEmpleadoService _empleadoService;

        public EmpleadoController(IEmpleadoService empleadoService)

        {
            _empleadoService = empleadoService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _respuesta.Data = _empleadoService.GetAll();
                _respuesta.exito = 1;
            }
            catch (Exception ex)
            {

                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);
        }

        [HttpPost]
        public IActionResult Add(EmpleadoRequest request)
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _empleadoService.Add(request);
                _respuesta.exito = 1;
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;

            }
            return Ok(_respuesta);
        }

        [HttpPut]
        public IActionResult Edit(EmpleadoRequest request)
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _empleadoService.Edit(request);
                _respuesta.exito = 1;
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;

            }
            return Ok(_respuesta);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _empleadoService.Delete(id);
                _respuesta.exito = 1;
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;

            }
            return Ok(_respuesta);
        }

    }
}
