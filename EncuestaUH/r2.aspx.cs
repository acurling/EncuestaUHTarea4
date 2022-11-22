using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EncuestaUH
{
    public partial class r2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
                GridView1.Visible = false;
                biniciar.Visible = false;
            } else
            {
                GridView1.Visible = true;
                biniciar.Visible = true;
            }
           
        }

        protected void biniciar_Click(object sender, EventArgs e)
        {
            Response.Redirect("inicio.aspx");
        }

        protected void salvar()
        {
            try
            {
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["EncuestasUHConnectionString"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand(" INSERT INTO Persona(cedulaP, Nombre, Genero) VALUES('" + Persona.cedula + "', '" + Persona.nombre + "', '" + Persona.Genero + "')", conexion);
                comando.ExecuteNonQuery();
                conexion.Close();
              



            }
            catch (Exception)
            {


            }
            try

            {
                String s = System.Configuration.ConfigurationManager.ConnectionStrings["EncuestasUHConnectionString"].ConnectionString;
                SqlConnection conexion = new SqlConnection(s);
                conexion.Open();
                SqlCommand comando = new SqlCommand(" INSERT INTO Repuestas VALUES('" + Persona.cedula + "','" + Persona.r1 + "', '" + Persona.r2 + "','" + Persona.r2 + "')", conexion);
                comando.ExecuteNonQuery();
                conexion.Close();


            }
            catch (Exception)
            {

                throw;
            }

           



            
            LlenarGrid();
        }
    
        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["EncuestasUHConnectionString"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select r.id, r.cedulaR,p.nombre, r.r1, r.r2, r.r3 " +
                                                       "from Repuestas r " +
                                                       "inner join Persona p on r.cedulaR= p.cedulaP"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }
        protected void Salvar_Click(object sender, EventArgs e)
        {
            float nota = 0;
            Persona.r2 = DropDownList1.SelectedValue;
            Label1.Text = "Cedula: " + Persona.cedula + " Nombre: " + Persona.nombre + " Genero: " + Persona.Genero + " R1: " + Persona.r1 + " R2: " + Persona.r2;
            if (Persona.r1.Equals("a"))
                nota += 10;

            if (Persona.r2.Equals("a"))
                nota += 10;
            Label2.ForeColor = Color.Red;
          Label2.Text = "La Nota es: " +(nota = (nota /20) * 100).ToString();


            salvar();
            
        }
    }
}