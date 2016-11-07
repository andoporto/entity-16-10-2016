using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkPractica
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DB_EmpleadosEntities Ctx = new DB_EmpleadosEntities();
            Empleado em = new Empleado();
            em.Nombre = TextBox1.Text;
            Ctx.Empleados.Add(em);
            Ctx.SaveChanges();

        }
    }
}