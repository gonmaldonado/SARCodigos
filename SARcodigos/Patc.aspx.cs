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
    public partial class Patc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gvSeat.DataSource = Logica.Consultas.Patc();
                gvSeat.DataBind();
                Session["Registros"] = Logica.Consultas.Patc();
            }

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
                    dv1.RowFilter = ddlColumna.Text + " LIKE '%" + txtFiltro.Text.Trim() + "%'";
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltroNinja(txtFiltro.Text.Trim());
        }

        protected void btnBorrar2_Click(object sender, EventArgs e)
        {
            FiltroNinja("");
            txtFiltro.Text = "";
        }
    }
}