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
            DateTime today = DateTime.Today;
            string wk = today.DayOfWeek.ToString();
            switch (wk)
            {
                case "Monday":
                    wk = "Lu";
                    break;
                case "Tuesday":
                    wk = "Ma";
                    break;
                case "Wednesday":
                    wk = "Mi";
                    break;
                case "Thursday":
                    wk = "Ju";
                    break;
                case "Friday":
                    wk = "Vi";
                    break;
                case "Saturday":
                    wk = "Sa";
                    break;
                case "Sunday":
                    wk = "Do";
                    break;
                default:
                    break;
            }
            int cant = System.DateTime.DaysInMonth(today.Year, today.Month);
            int d = 1;
            string strT = "";
            while (d <= cant)
            {
                switch (wk)
                {
                    case "Lu":
                        strT += "<th style=\"width: auto; background - color: #d7ed7a\"> " + wk + " " + d + " </ th > ";
                        wk = "Ma";
                        break;
                    case "Ma":
                        strT += "<th style=\"width: auto; background - color: #d7ed7a\"> " + wk + " " + d + " </ th > ";
                        wk = "Mi";
                        break;
                    case "Mi":
                        strT += "<th style=\"width: auto; background - color: #d7ed7a\"> " + wk + " " + d + " </ th > ";
                        wk = "Ju";
                        break;
                    case "Ju":
                        strT += "<th style=\"width: auto; background - color: #d7ed7a\"> " + wk + " " + d + " </ th > ";
                        wk = "Vi";
                        break;
                    case "Vi":
                        strT += "<th style=\"width: auto; background - color: #d7ed7a\"> " + wk + " " + d + " </ th > ";
                        wk = "Lu";
                        d += 2;
                        break;
                    case "Sa":
                        wk = "Lu";
                        d++;
                        break;
                    case "Do":
                        wk = "Lu";
                        break;
                    default:
                        break;
                }
                
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