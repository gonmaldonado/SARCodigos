using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Logica
{
    public class Consultas
    {
        public static DataTable ListarModelos()
        {
            return Datos.Consultas.ListarModelos();
        }
        public static DataTable ListarDoorTrim()
        {
            return Datos.Consultas.ListarDoorTrim();
        }
        public static DataTable TrearGeneral()
        {
            return Datos.Consultas.TrearGeneral();
        }
        public static DataTable TrearDoorTrim()
        {
            return Datos.Consultas.TrearDoor();
        }
        public static DataTable TrearDoorTrim(string filtro)
        {
            return Datos.Consultas.TrearDoor(filtro);
        }
        public static DataTable TrearGeneralFitrlo(string filtro)
        {
            return Datos.Consultas.TrearGeneralFiltro(filtro);
        }
        public static DataTable ListarVehiculos()
        {
            return Datos.Consultas.ListarVehiculos();
        }
        public static DataTable ListarVTipos()
        {
            return Datos.Consultas.ListarVTipos();
        }
        public static DataTable ListarFilas()
        {
            return Datos.Consultas.ListarFilas();
        }
        public static DataTable ListarFilas2()
        {
            return Datos.Consultas.ListarFilas2();
        }
        public static DataTable ListarCodigos()
        {
            return Datos.Consultas.ListarCodigos();
        }
        public static DataTable ListarCodigos2()
        {
            return Datos.Consultas.ListarCodigos2();
        }
        public static DataTable ListarCodigos3()
        {
            return Datos.Consultas.ListarCodigos3();
        }
        public static DataTable ListarDescripcion()
        {
            return Datos.Consultas.ListarDescripcion();
        }
        public static DataTable ListarDescripcion2()
        {
            return Datos.Consultas.ListarDescripcion2();
        }
        public static DataTable ListarLados()
        {
            return Datos.Consultas.ListarLados();
        }
        public static DataTable ListarLados2()
        {
            return Datos.Consultas.ListarLados2();
        }
        public static DataTable ListarMateriales()
        {
            return Datos.Consultas.ListarMateriales();
        }
        public static DataTable ListarColores()
        {
            return Datos.Consultas.ListarColores();
        }
        public static DataTable Bom()
        {
            return Datos.Consultas.Bom();
        }
        public static DataTable ListarCantidad()
        {
            return Datos.Consultas.ListarCantidad();
        }
        public static DataTable ListarComponente()
        {
            return Datos.Consultas.ListarComponente();
        }
        public static DataTable ListarUM()
        {
            return Datos.Consultas.ListarUM();
        }
        public static DataTable Bom(string filtro)
        {
            return Datos.Consultas.Bom(filtro);
        }
        public static DataTable Patc()
        {
            return Datos.Consultas.Patc();
        }


    }
}
