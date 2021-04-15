using Cars_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cars_Api
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public IQueryable<Marca> GetMarcas()
        {
            var _db = new Cars_Api.Contexts.Db();
            IQueryable<Marca> query = _db.marcas;
            return query;
        }
    }
}