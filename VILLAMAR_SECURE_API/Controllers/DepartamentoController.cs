using VILLAMAR_SECURE_API.Models.Request;
using VILLAMAR_SECURE_API.Respo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using VILLAMAR_SECURE_API.Services.DepServices;

namespace VILLAMAR_SECURE_API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DepartamentoController : ControllerBase
    {

        private readonly IDepartamentoService _departamentoService;

        public DepartamentoController(IDepartamentoService departamentoService)

        {
            _departamentoService = departamentoService;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _respuesta.Data = _departamentoService.GetAll();
                _respuesta.exito = 1;
            }
            catch (Exception ex)
            {

                _respuesta.Mensaje = ex.Message;
            }
            return Ok(_respuesta);
        }



        [HttpPost]
        public IActionResult Add(DepartamentoRequest request)
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _departamentoService.Add(request);
                _respuesta.exito = 1;
            }
            catch (Exception ex)
            {
                _respuesta.Mensaje = ex.Message;

            }
            return Ok(_respuesta);
        }

        [HttpPut]
        public IActionResult Edit(DepartamentoRequest request)
        {
            Respuesta _respuesta = new Respuesta();
            try
            {
                _departamentoService.Edit(request);
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
                _departamentoService.Delete(id);
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
