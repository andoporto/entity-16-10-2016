using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkPractica
{
    public partial class listaEmpleados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DB_EmpleadosEntities db = new DB_EmpleadosEntities();
            var em = (from e2 in db.Empleados where e2.Edad>30 select e2).ToList();
            GridView1.DataSource=em;
            GridView1.DataBind();
        }
    }
}