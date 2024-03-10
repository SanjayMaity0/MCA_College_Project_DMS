using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Disaster_Management_System.General_Pages
{
    public partial class GeSuccessPage : System.Web.UI.Page
    {
        SqlDataAdapter adp = new SqlDataAdapter(" select * from [dbo].[UserDataTable]", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project_Net_by_KK\Final_Project\MCA_College_Project_DMS\Disaster_Management_System\Disaster_Management_System\App_Data\SanjayDatabase.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            adp.Fill(dt);
            SqlCommandBuilder str = new SqlCommandBuilder(adp);
            lblCountry.Text = Session["Country"].ToString();
            lblName.Text = Session["Name"].ToString();
            lblState.Text = Session["State"].ToString();
            lblPass.Text = Session["Pass"].ToString();
            //lblUserId.Text = Session["UserId"].ToString();
            lblDist.Text = Session["Dist"].ToString();
            lblPin.Text = Session["Pin"].ToString();
            lblMobile.Text = Session["Mobile"].ToString();
            lblMail.Text = Session["Mail"].ToString();
            lblUserStatus.Text = Session["UserClass"].ToString();
        }

        protected void btnPrevious_Click(object sender, EventArgs e)
        {
            Session["Count"]= "two";
            Response.Redirect("~/General_Pages/Registration.aspx");
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            //dr["User_Id"] = Session["UserId"].ToString();
            dr["Mobile"] = Session["Mobile"].ToString();
            dr["Email"] = Session["Mail"].ToString();
            dr["Pass"] = Session["Pass"].ToString();
            dr["State"] = Session["State"].ToString();
            dr["Dist"] = Session["Dist"].ToString();
            dr["pin"] = Session["Pin"].ToString();
            dr["User_Class"] = Session["UserClass"].ToString();
            dr["Name"] = Session["Name"].ToString();
            dt.Rows.Add(dr);
            adp.Update(dt);
            lblSuccessMsg.Text = "You Successfully Register.... GO TO HOME for LOGIN";
           // Response.Redirect("~/General_Pages/Home.aspx");
        }
    }
}