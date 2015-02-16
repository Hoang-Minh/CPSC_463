using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using TV;
using System.Collections.Generic;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblResult.Visible = false;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!(string.IsNullOrEmpty(txtSeriesName.Text) && string.IsNullOrEmpty(txtMale.Text) && string.IsNullOrEmpty(txtFemale.Text)))
        {

            ServiceClient obj = new ServiceClient();
            TVSeries obj2 = new TVSeries();
            obj2.TVSeriesName = txtSeriesName.Text;
            obj2.FavMaleCharacter = txtMale.Text;
            obj2.FavFemaleCharacter = txtFemale.Text;
            string message = obj.InsertSeriesDetails(obj2);
            lblResult.Visible = true;
            lblResult.Text = message;

        }
        else
        {
            lblResult.Visible = true;
            lblResult.Text = "Please enter the TV series details..Then hit Insert button...";
            txtSeriesName.Focus();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        lblResult.Visible = false;
        ServiceClient obj3 = new ServiceClient();
        IList<TVSeries> listTV = obj3.GetSeriesDetails();
        grdView.DataSource = listTV;
        grdView.DataBind();
        
    }
}
