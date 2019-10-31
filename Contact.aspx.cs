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
        public NegocioAsistencia negocioAsistencia = new NegocioAsistencia();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                NegocioPersona negocioPersona = new NegocioPersona();
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
        public string Dias()
        {
            /*
             * Meses con 31 dias: 1,3,5,7,8,10 y 12.
             */
            DateTime today = DateTime.Today;
            string wk = today.DayOfWeek.ToString();
            switch (wk)
            {
                case "Monday":
                    wk = "L";
                    break;
                case "Tuesday":
                    wk = "M";
                    break;
                case "Wednesday":
                    wk = "M";
                    break;
                case "Thursday":
                    wk = "J";
                    break;
                case "Friday":
                    wk = "V";
                    break;
                case "Saturday":
                    wk = "S";
                    break;
                case "Sunday":
                    wk = "D";
                    break;
                default:
                    break;
            }
            int cant = System.DateTime.DaysInMonth(today.Year, today.Month);
            int d = 1;
            string strT = "";
            while (d <= cant)
            {
                strT += "<th style=\"width: auto; background - color: #d7ed7a\"> "+wk+" "+d+" </ th > ";
                d++;
            }
            return strT;
        }
        public string TablaPresentes()
        {
            string Tabla = "";
            Tabla += "< td >+" +
                        "< div class=\"custom-control custom-checkbox\">" +
                                "<input type = \"checkbox\" class=\"custom-control-input\" id=<%=item.ID %> checked>" +
                                "<label class=\"custom-control-label\" for=<%=item.ID %>></label>" +
                            "</div>" +
                     "</td>";
            return Tabla;
        }
        public string Asistio(Int64 dia, Int64 ID)
        {
            string str = "";
            List<Asistencia> lista = negocioAsistencia.ListarAsistenciasActual(ID);
            foreach (Asistencia item in lista)
            {
                if (item.Fecha.Day == dia)
                {
                    return "checked";
                }
            }
            return str;
        }

    }
}