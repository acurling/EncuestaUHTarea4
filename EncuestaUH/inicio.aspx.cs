using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EncuestaUH
{
    public partial class inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bsiguiente_Click(object sender, EventArgs e)
        {
            Persona.cedula = tcedula.Text;
            Persona.nombre = tnombre.Text;

            if (rf.Checked)
                Persona.Genero = "F";
              else
                Persona.Genero = "M";
            Response.Redirect("r1.aspx");
        }
    }
}