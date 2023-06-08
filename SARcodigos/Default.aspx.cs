using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.HtmlControls;
using System.Text;

namespace SARcodigos
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarcbModelo();
                LlenarcbTipo();
                LlenarcbVehiculo();
                LlenarcbFila();
                LlenarcbCodigo();
                LlenarcbDescripcion();
                LlenarcbLado();
                LlenarcbColor();
                LlenarcbMaterial();
                gvSeat.DataSource = Logica.Consultas.TrearGeneral();
                gvSeat.DataBind();
                Session["Registros"]= Logica.Consultas.TrearGeneral();
            }

        }
        public void LlenarcbModelo()
        {
            DataTable dt = Logica.Consultas.ListarModelos();
            cbModelo.DataSource = dt;
            cbModelo.DataTextField = "NOMBRE";
            cbModelo.DataBind();
        }
        public void LlenarcbColor()
        {
            DataTable dt = Logica.Consultas.ListarColores();
            cbColor.DataSource = dt;
            cbColor.DataTextField = "COLOR";
            cbColor.DataBind();
        }
        public void LlenarcbLado()
        {
            DataTable dt = Logica.Consultas.ListarLados();
            cbLado.DataSource = dt;
            cbLado.DataTextField = "LADO";
            cbLado.DataBind();
        }
        public void LlenarcbCodigo()
        {
            DataTable dt = Logica.Consultas.ListarCodigos();
            cbCodigo.DataSource = dt;
            cbCodigo.DataTextField = "ID";
            cbCodigo.DataBind();
        }
        public void LlenarcbVehiculo()
        {
            DataTable dt = Logica.Consultas.ListarVehiculos();
            cbVehiculo.DataSource = dt;
            cbVehiculo.DataTextField = "ID";
            cbVehiculo.DataBind();
        }
        public void LlenarcbTipo()
        {
            DataTable dt = Logica.Consultas.ListarVTipos();
            cbTipo.DataSource = dt;
            cbTipo.DataTextField = "TIPO";
            cbTipo.DataBind();
        }
        public void LlenarcbFila()
        {
            DataTable dt = Logica.Consultas.ListarFilas();
            cbFila.DataSource = dt;
            cbFila.DataTextField = "FILA";
            cbFila.DataBind();
        }
        public void LlenarcbDescripcion()
        {
            DataTable dt = Logica.Consultas.ListarDescripcion();
            cbDescripcion.DataSource = dt;
            cbDescripcion.DataTextField = "TIPO";
            cbDescripcion.DataBind();
        }
        public void LlenarcbMaterial()
        {
            DataTable dt = Logica.Consultas.ListarMateriales();
            cbMaterial.DataSource = dt;
            cbMaterial.DataTextField = "MATERIAL";
            cbMaterial.DataBind();
        }
        public string Modelos ()
        {
            string resultado="";
            for (int i = 0; i < cbModelo.Items.Count; i++)
            {
                if (cbModelo.Items[i].Selected == true)
                {
                    resultado = resultado + ",'"+ cbModelo.Items[i].Value.ToString().Trim()+"'";
                }
            }
            if (resultado != "")
            {
                resultado = resultado.Substring(1);
            }
            return resultado;
        }
        public string Codigos()
        {
            string resultado = "";
            for (int i = 0; i < cbCodigo.Items.Count; i++)
            {
                if (cbCodigo.Items[i].Selected == true)
                {
                    resultado = resultado + ",'" + cbCodigo.Items[i].Value.ToString().Trim() + "'";
                }
            }
            if (resultado != "")
            { 
                resultado = resultado.Substring(1);
            }
            return resultado;
        }
        public string Vehiculos()
        {
            string resultado = "";
            for (int i = 0; i < cbVehiculo.Items.Count; i++)
            {
                if (cbVehiculo.Items[i].Selected == true)
                {
                    resultado = resultado + ",'" + cbVehiculo.Items[i].Value.ToString().Trim()+"'";
                }
            }
            if (resultado != "")
            {
                resultado = resultado.Substring(1);
            }
            return resultado;
        }
        public string Tipos()
        {
            string resultado = "";
            for (int i = 0; i < cbTipo.Items.Count; i++)
            {
                if (cbTipo.Items[i].Selected == true)
                {
                    resultado = resultado + ",'" + cbTipo.Items[i].Value.ToString().Trim()+"'";
                }
            }
            if (resultado != "")
            {
                resultado = resultado.Substring(1);
            }
            return resultado;
        }
        public string Filas()
        {
            string resultado = "";
            for (int i = 0; i < cbFila.Items.Count; i++)
            {
                if (cbFila.Items[i].Selected == true)
                {
                    resultado = resultado + ",'" + cbFila.Items[i].Value.ToString().Trim()+"'";
                }
            }
            if (resultado != "")
            {
                resultado = resultado.Substring(1);
            }
            return resultado;
        }
        public string Descripciones()
        {
            string resultado = "";
            for (int i = 0; i < cbDescripcion.Items.Count; i++)
            {
                if (cbDescripcion.Items[i].Selected == true)
                {
                    resultado = resultado + ",'" + cbDescripcion.Items[i].Value.ToString().Trim()+"'";
                }
            }
            if (resultado != "")
            {
                resultado = resultado.Substring(1);
            }
            return resultado;
        }
        public string Lados()
        {
            string resultado = "";
            for (int i = 0; i < cbLado.Items.Count; i++)
            {
                if (cbLado.Items[i].Selected == true)
                {
                    resultado = resultado + ",'" + cbLado.Items[i].Value.ToString().Trim()+"'";
                }
            }
            if (resultado != "")
            {
                resultado = resultado.Substring(1);
            }
            return resultado;
        }
        public string Materiales()
        {
            string resultado = "";
            for (int i = 0; i < cbMaterial.Items.Count; i++)
            {
                if (cbMaterial.Items[i].Selected == true)
                {
                    resultado = resultado + ",'" + cbMaterial.Items[i].Value.ToString().Trim()+"'";
                }
            }
            if (resultado != "")
            {
                resultado = resultado.Substring(1);
            }
            return resultado;
        }
        public string Colores()
        {
            string resultado = "";
            for (int i = 0; i < cbColor.Items.Count; i++)
            {
                if (cbColor.Items[i].Selected == true)
                {
                    resultado = resultado + ",'" + cbColor.Items[i].Value.ToString().Trim()+"'";
                }
            }
            if (resultado != "")
            {
                resultado = resultado.Substring(1);
            }
            return resultado;
        }
        public string WhenSeat()
        {
            string Consultas = "";
            //MODELO
            if(Modelos()!="")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + "AND b.NOMBRE IN (" + Modelos() + ")";
                }
                else
                {
                    Consultas = Consultas + " b.NOMBRE IN (" + Modelos() + ")";
                }
            }
            //CODIGO
            if (Codigos() != "")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND c.ID IN (" + Codigos() + ")";
                }
                else
                {
                    Consultas = Consultas + " c.ID IN (" + Codigos() + ")";
                }
            }
            //VEHICULO
            if (Vehiculos() != "")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND v.ID_VEHICULO IN (" + Vehiculos() + ")";
                }
                else
                {
                    Consultas = Consultas + " v.ID_VEHICULO IN (" + Vehiculos() + ")";
                }

            }
            //TIPO
            if (Tipos() != "")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND vt.TIPO IN (" + Tipos() + ")";
                }
                else
                {
                    Consultas = Consultas + " vt.TIPO IN (" + Tipos() + ")";
                }
            }
            //FILA
            if (Filas() != "")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND f.FILA IN (" + Filas() + ")";
                }
                else
                {
                    Consultas = Consultas + " f.FILA IN (" + Filas() + ")";
                }

            }
            //DESCRIPCION
            if(Descripciones() != "")
            {
                if(Consultas != "")
                {
                    Consultas = Consultas + " AND t.TIPO IN (" + Descripciones() + ")";
                }
                else
                {
                    Consultas = Consultas + " t.TIPO IN (" + Descripciones() + ")";
                }
            }
            //LADO
            if (Lados() != "")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND l.LADO  IN (" + Lados() + ")";
                }
                else
                {
                    Consultas = Consultas + " l.LADO  IN (" + Lados() + ")";
                }
            }
            //MATERIAL
            if (Materiales() != "")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND h.MATERIAL  IN (" + Materiales() + ")";
                }
                else
                {
                    Consultas = Consultas + " h.MATERIAL  IN (" + Materiales() + ")";
                }
            }
            //COLOR
            if (Colores() != "")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND g.COLOR  IN (" + Colores() + ")";
                }
                else
                {
                    Consultas = Consultas + " g.COLOR  IN (" + Colores() + ")";
                }
            }
            //AIRBAG
            if (cbAirbag.SelectedValue == "NO")
            {
                    if (Consultas != "")
                    {
                        Consultas = Consultas + " AND b.AIRBAG = 0";
                }
                else
                {
                    Consultas = Consultas + " b.AIRBAG = 0";
                }
            }
            if (cbAirbag.SelectedValue == "SI")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND b.AIRBAG = 1";
                }
                else
                {
                    Consultas = Consultas + " b.AIRBAG = 1";
                }
            }
            //HEATER
            if (cbHeater.SelectedValue == "NO")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND b.HEATER = 0";
                }
                else
                {
                    Consultas = Consultas + " b.HEATER = 0";
                }
            }
            if (cbHeater.SelectedValue == "SI")
            {
                if (Consultas != "")
                {
                    Consultas = Consultas + " AND b.HEATER = 1";
                }
                else
                {
                    Consultas = Consultas + " b.HEATER = 1";
                }
            }

            return Consultas;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string consulta = WhenSeat();
            if (consulta !="")
            {
                gvSeat.DataSource = Logica.Consultas.TrearGeneralFitrlo(consulta);
                Session["Registros"] = Logica.Consultas.TrearGeneralFitrlo(consulta);
                gvSeat.DataBind();
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            gvSeat.DataSource = Logica.Consultas.TrearGeneral();
            gvSeat.DataBind();
            Session["Registros"] = Logica.Consultas.TrearGeneral();
            FiltroNinja("");
            txtFiltro.Text = "";
            cbCodigo.ClearSelection();
            cbAirbag.ClearSelection();
            cbModelo.ClearSelection();
            cbColor.ClearSelection();
            cbDescripcion.ClearSelection();
            cbFila.ClearSelection();
            cbHeater.ClearSelection();
            cbVehiculo.ClearSelection();
            cbTipo.ClearSelection();
            cbLado.ClearSelection();
            cbMaterial.ClearSelection();

        }
        public void FiltroNinja(string filtro)
        {
            DataTable dt = (DataTable)Session["Registros"];
        int validardt = dt.Rows.Count;
            if (validardt > 0)
            {
                if (filtro != "")
                {
                    DataTable dt1 = (DataTable)Session["Registros"];
                    DataView dv1 = dt1.DefaultView;
                    dv1.RowFilter = ddlColumna.Text+" LIKE '%" + txtFiltro.Text.Trim() + "%'";
                    gvSeat.DataSource = dv1;
                    gvSeat.DataBind();
                }
                else
                {
                    DataTable dt1 = (DataTable)Session["Registros"];
                    DataView dv1 = dt1.DefaultView;
                    dv1.RowFilter = " CODIGO <> '' ";
                    gvSeat.DataSource = dv1;
                    gvSeat.DataBind();

                }

            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltroNinja(txtFiltro.Text.Trim());
        }

        protected void btnBorrar2_Click(object sender, EventArgs e)
        {
            FiltroNinja("");
            txtFiltro.Text = "";
        }
        private void ExportToExcel(string nameReport, GridView wControl)
        {
            HttpResponse response = Response;
            StringWriter sw = new StringWriter();
            HtmlTextWriter htw = new HtmlTextWriter(sw);
            Page pageToRender = new Page();
            HtmlForm form = new HtmlForm();
            form.Controls.Add(wControl);
            pageToRender.Controls.Add(form);
            response.Clear();
            response.Buffer = true;
            response.ContentType = "application/vnd.ms-excel";
            response.AddHeader("Content-Disposition", "attachment;filename=" + nameReport);
            response.Charset = "UTF-8";
            response.ContentEncoding = Encoding.Default;
            pageToRender.RenderControl(htw);
            response.Write(sw.ToString());
            response.End();
        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            ExportToExcel("SAR_" + DateTime.Now.ToShortDateString() + ".xls", gvSeat);
        }
    }
}