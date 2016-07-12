using PropertyEval.GoogleSheets;
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

        }
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            List<String> streetAddresses = new List<String>(TxtStreetAddresses.Text.Split('\n'));
            //streetAddresses.Add("13 Royal Crest Dr, Pueblo, CO 81005");
            Dictionary<int, DTOs.PropertyInfo> properties = PropertySearch.SearchForProperties(streetAddresses);

            GridViewResults.DataSource = properties.Values.ToList();
            GridViewResults.DataBind();
        }
    }
}