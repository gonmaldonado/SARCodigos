using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Consultas
    {
        public static DataTable ListarModelos()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(NOMBRE) AS NOMBRE from T_MODELOS  order by NOMBRE ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarVehiculos()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(ID) ID from T_VEHICULOS  order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarVTipos()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(TIPO) TIPO from T_V_TIPOS  order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarFilas()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(FILA) FILA from T_FILAS  order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarFilas2()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(FILA) FILA from T_FILAS where ID <= 2  order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable TrearGeneral()

        {
            DataTable dt = new DataTable();
            string strProc = " select vt.TIPO 'TIPO',v.ID_VEHICULO 'VEHICULO',f.FILA 'FILA',b.NOMBRE 'MODELO', c.ID 'CODIGO', t.TIPO 'DESCRIPCION', l.LADO 'LADO',  'A'= CASE when b.AIRBAG = 1 and t.ID =1 then 'SI'  when b.AIRBAG = 1 and t.ID = 2 then 'SI' else 'NO' end,'H'= CASE when b.HEATER = 1 and t.ID =1 then 'SI' when b.HEATER = 1 and t.ID =2 then 'SI' else 'NO' end,h.MATERIAL 'MATERIAL',g.COLOR 'COLOR' from T_CODIGOS c inner join T_C_TIPOS t on c.ID_C_TIPO = t.ID inner join T_LADO l  on c.ID_LADO = l.ID inner join R_MODELO_CODIGO m on RTRIM(c.ID) = RTRIM(m.ID_CODIGO) inner join T_MODELOS b on RTRIM(b.ID) = RTRIM(m.ID_MODELO) inner join R_VEHICULO_MODELO v on RTRIM(v.ID_MODELO)=RTRIM(m.ID_MODELO)inner join T_VEHICULOS ve on ve.ID=v.ID_VEHICULO inner join T_V_TIPOS vt on vt.ID=ve.ID_V_TIPO inner join T_FILAS f on f.ID= b.ID_FILA inner join T_MATERIAL h on h.ID=b.ID_MATERIAL inner join T_COLOR g on g.ID= b.ID_COLOR   group by c.ID,t.TIPO,l.LADO,b.NOMBRE,v.ID_VEHICULO,ve.ID,vt.TIPO,f.FILA ,h.MATERIAL,b.AIRBAG,b.HEATER,b.BLOWER,g.COLOR,t.ID order by vt.TIPO,v.ID_VEHICULO, b.NOMBRE";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;

        }
        public static DataTable TrearGeneralFiltro(string filtro)

        {
            DataTable dt = new DataTable();
            string strProc = @" select vt.TIPO 'TIPO',v.ID_VEHICULO 'VEHICULO',f.FILA 'FILA',b.NOMBRE 'MODELO', c.ID 'CODIGO', t.TIPO 'DESCRIPCION', l.LADO 'LADO',  'A'= CASE when b.AIRBAG = 1 and t.ID =1 then 'SI'  when b.AIRBAG = 1 and t.ID = 2 then 'SI' else 'NO' end,'H'= CASE when b.HEATER = 1 and t.ID =1 then 'SI'  when b.HEATER = 1 and t.ID =2 then 'SI' else 'NO' end,h.MATERIAL 'MATERIAL',g.COLOR 'COLOR' from T_CODIGOS c inner join T_C_TIPOS t on c.ID_C_TIPO = t.ID inner join T_LADO l  on c.ID_LADO = l.ID inner join R_MODELO_CODIGO m on RTRIM(c.ID) = RTRIM(m.ID_CODIGO) inner join T_MODELOS b on RTRIM(b.ID) = RTRIM(m.ID_MODELO) inner join R_VEHICULO_MODELO v on RTRIM(v.ID_MODELO)=RTRIM(m.ID_MODELO)inner join T_VEHICULOS ve on ve.ID=v.ID_VEHICULO inner join T_V_TIPOS vt on vt.ID=ve.ID_V_TIPO inner join T_FILAS f on f.ID= b.ID_FILA inner join T_MATERIAL h on h.ID=b.ID_MATERIAL inner join T_COLOR g on g.ID= b.ID_COLOR   
            Where "+filtro.Trim()+ " group by c.ID,t.TIPO,l.LADO,b.NOMBRE,v.ID_VEHICULO,ve.ID,vt.TIPO,f.FILA ,h.MATERIAL,b.AIRBAG,b.HEATER,b.BLOWER,g.COLOR,t.ID order by vt.TIPO,v.ID_VEHICULO, b.NOMBRE";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;

        }
        public static DataTable ListarCodigos()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(ID) ID from T_CODIGOS WHERE ID_C_TIPO <= 4  order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarCodigos2()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(ID) ID from T_CODIGOS WHERE ID_C_TIPO > 4  order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarCodigos3()
        {

            DataTable dt = new DataTable();
            string strProc = "SELECT DISTINCT Material from T_BOM_SAP order by Material";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarDescripcion()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(TIPO) TIPO from T_C_TIPOS WHERE ID <= 4  order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarDescripcion2()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(TIPO) TIPO from T_C_TIPOS WHERE ID = 5 or ID = 6  order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarLados()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(LADO) LADO from T_LADO order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarLados2()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(LADO) LADO from T_LADO where ID = 2 or ID = 3 order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarMateriales()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(MATERIAL) MATERIAL from T_MATERIAL order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarColores()
        {

            DataTable dt = new DataTable();
            string strProc = "select RTRIM(COLOR) COLOR from T_COLOR order by ID ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable TrearDoor()

        {
            DataTable dt = new DataTable();
            string strProc = "  select tv.TIPO 'TIPO', f.FILA 'FILA' ,d.NOMBRE 'MODELO',d.ID 'CODIGO',ct.TIPO 'DESCRIPCION',l.LADO 'LADO',m.MATERIAL 'MATERIAL', co.COLOR 'COLOR' from T_CODIGOS c inner join T_DOOR_TRIM d on d.ID=c.ID inner join T_C_TIPOS ct on ct.ID = c.ID_C_TIPO inner join T_LADO l on l.ID = c.ID_LADO inner join T_MATERIAL m on m.ID = d.ID_MATERIAL inner join T_COLOR co on co.ID=d.ID_COLOR inner join T_FILAS f on f.ID = d.ID_FILA inner join T_V_TIPOS tv on tv.ID= d.ID_T_V_TIPOS group by tv.TIPO, d.NOMBRE,d.ID,ct.TIPO,l.LADO,m.MATERIAL,co.COLOR,f.FILA order by d.NOMBRE";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;

        }
        public static DataTable TrearDoor(string filtro)

        {
            DataTable dt = new DataTable();
            string strProc = "  select tv.TIPO 'TIPO', f.FILA 'FILA' ,d.NOMBRE 'MODELO',d.ID 'CODIGO',ct.TIPO 'DESCRIPCION',l.LADO 'LADO',m.MATERIAL 'MATERIAL', co.COLOR 'COLOR' from T_CODIGOS c inner join T_DOOR_TRIM d on d.ID=c.ID inner join T_C_TIPOS ct on ct.ID = c.ID_C_TIPO inner join T_LADO l on l.ID = c.ID_LADO inner join T_MATERIAL m on m.ID = d.ID_MATERIAL inner join T_COLOR co on co.ID=d.ID_COLOR inner join T_FILAS f on f.ID = d.ID_FILA inner join T_V_TIPOS tv on tv.ID= d.ID_T_V_TIPOS" +
                              " Where " + filtro.Trim() + " group by tv.TIPO, d.NOMBRE,d.ID,ct.TIPO,l.LADO,m.MATERIAL,co.COLOR,f.FILA order by d.NOMBRE";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;

        }
        public static DataTable ListarDoorTrim()
        {

            DataTable dt = new DataTable();
            string strProc = "select NOMBRE from T_DOOR_TRIM order by NOMBRE ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarCantidad()
        {

            DataTable dt = new DataTable();
            string strProc = "SELECT DISTINCT Cantidad from T_BOM_SAP order by Cantidad";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarUM()
        {

            DataTable dt = new DataTable();
            string strProc = "SELECT DISTINCT UM2 from T_BOM_SAP ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable ListarComponente()
        {

            DataTable dt = new DataTable();
            string strProc = "SELECT DISTINCT Componente from T_BOM_SAP order by Componente";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable Bom()
        {

            DataTable dt = new DataTable();
            string strProc = @"  select tv.TIPO 'TIPO',fi.FILA 'FILA',m.NOMBRE 'MODELO',f.ID_CODIGO 'CODIGO', t.TIPO 'DESCRIPCION', l.LADO 'LADO',b.Componente 'MATERIAL',b.Cantidad 'CANTIDAD', b.UM2 'UM'
                                  from R_MODELO_CODIGO f 
                                  inner join T_CODIGOS c on f.ID_CODIGO=c.ID
                                  inner join T_C_TIPOS t on t.ID = c.ID_C_TIPO
                                  inner join T_LADO l on l.ID = c.ID_LADO
                                  inner join T_BOM_SAP b on f.ID_CODIGO = b.Material
                                  inner join R_VEHICULO_MODELO v on v.ID_MODELO = f.ID_MODELO
                                  inner join T_MODELOS m on m.ID = f.ID_MODELO
                                  inner join T_VEHICULOS ve on ve.ID = v.ID_VEHICULO
                                  inner join T_V_TIPOS tv on tv.ID = ve.ID_V_TIPO
                                  inner join T_FILAS fi on fi.ID = m.ID_FILA
                                union
                                select tv.TIPO 'TIPO', f.FILA 'FILA' ,d.NOMBRE 'MODELO',d.ID 'CODIGO',ct.TIPO 'DESCRIPCION',l.LADO 'LADO',b.Componente 'MATERIAL',b.Cantidad 'CANTIDAD', b.UM2 'UM'
                                from T_CODIGOS c 
                                inner join T_DOOR_TRIM d on d.ID=c.ID 
                                inner join T_C_TIPOS ct on ct.ID = c.ID_C_TIPO 
                                inner join T_LADO l on l.ID = c.ID_LADO 
                                inner join T_FILAS f on f.ID = d.ID_FILA 
                                inner join T_V_TIPOS tv on tv.ID= d.ID_T_V_TIPOS
                                inner join T_BOM_SAP b on d.ID = b.Material
                                order by 'MODELO' ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable Bom(string filtro)
        {

            DataTable dt = new DataTable();
            string strProc = @"  select tv.TIPO 'TIPO',fi.FILA 'FILA',m.NOMBRE 'MODELO',c.ID 'CODIGO', t.TIPO 'DESCRIPCION', l.LADO 'LADO',b.Componente 'MATERIAL',b.Cantidad 'CANTIDAD', b.UM2 'UM'"+
                                  "from R_MODELO_CODIGO f " +
                                  "inner join T_CODIGOS c on f.ID_CODIGO=c.ID " +
                                  "inner join T_C_TIPOS t on t.ID = c.ID_C_TIPO " +
                                  "inner join T_LADO l on l.ID = c.ID_LADO " +
                                  "inner join T_BOM_SAP b on f.ID_CODIGO = b.Material " +
                                  "inner join R_VEHICULO_MODELO v on v.ID_MODELO = f.ID_MODELO " +
                                  "inner join T_MODELOS m on m.ID = f.ID_MODELO " +
                                  "inner join T_VEHICULOS ve on ve.ID = v.ID_VEHICULO " +
                                  "inner join T_V_TIPOS tv on tv.ID = ve.ID_V_TIPO " +
                                  "inner join T_FILAS fi on fi.ID = m.ID_FILA " +
                                  "Where "+ filtro.Trim() +""+
                                @"union "+
                                "select tv.TIPO 'TIPO', fi.FILA 'FILA' ,m.NOMBRE 'MODELO',c.ID 'CODIGO',t.TIPO 'DESCRIPCION',l.LADO 'LADO',b.Componente 'MATERIAL',b.Cantidad 'CANTIDAD', b.UM2 'UM'  " +
                                "from T_CODIGOS c  " +
                                "inner join T_DOOR_TRIM m on m.ID=c.ID " +
                                "inner join T_C_TIPOS t on t.ID = c.ID_C_TIPO " +
                                "inner join T_LADO l on l.ID = c.ID_LADO " +
                                "inner join T_FILAS fi on fi.ID = m.ID_FILA " +
                                "inner join T_V_TIPOS tv on tv.ID= m.ID_T_V_TIPOS " +
                                "inner join T_BOM_SAP b on m.ID = b.Material " +
                                "Where " +filtro.Trim()+ "order by 'MODELO' ";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }
        public static DataTable Patc()
        {

            DataTable dt = new DataTable();
            string strProc = "SELECT p.ID 'CODIGO',p.DESCRIPCION 'DESCRIPCION' ,b.Componente 'MATERIAL',b.Cantidad 'CANTIDAD', b.UM2 'UM' from T_PATC p inner join T_BOM_SAP b on p.ID = b.Material order by p.ID";
            SqlDataAdapter objDaTraer = new SqlDataAdapter(strProc, Conexion.strConexion);
            objDaTraer.SelectCommand.CommandType = CommandType.Text;
            objDaTraer.Fill(dt);
            return dt;
        }


    }
}
