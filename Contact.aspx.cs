using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Soria
{
    public partial class Contact : Page
    {
        public List<Persona> Personas { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                NegocioPersona negocioPersona = new NegocioPersona();
                grid.DataSource = negocioPersona.ListarPersonas();
                grid.DataBind();
                Personas = negocioPersona.ListarPersonas();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        protected void ValidarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioPersona negocioPersona = new NegocioPersona();
                //var code = CodigoPersona.Value;
                //Persona voucher = negocioPersona.BuscarPersonas(code);
                //if (voucher.Code != null)
                //{
                //    Response.Redirect("/frmIncripcion.aspx");
                //}
                //else
                //{
                //    Response.Redirect("/Default.aspx");
                //}
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}