﻿namespace VILLAMAR_SECURE_API.Respo
{
    public class Respuesta
    {
        public int exito { get; set; }
        public string Mensaje { get; set; }

        public object Data { get; set; }

        public Respuesta()
        {
            this.exito = 0;
        }
    }
}
