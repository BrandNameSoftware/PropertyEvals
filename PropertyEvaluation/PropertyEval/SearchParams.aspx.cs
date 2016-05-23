using PropertyEval.PropertyCalls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PropertyEval
{
    public partial class SearchParams : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PropertySearch.SearchForProperties();
        }
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            PropertySearch.SearchForProperties();
        }
    }
}