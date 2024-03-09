using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Disaster_Management_System.User_Pages.General_User
{
    public partial class GeUser1 : System.Web.UI.MasterPage
    {
        SqlDataAdapter adp = new SqlDataAdapter(" select * from [dbo].[UserDataTable]", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project_Net_by_KK\Final_Project\Disaster_Management_System\Disaster_Management_System\App_Data\Database1.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            //adp.Fill(dt);
            //SqlCommandBuilder str = new SqlCommandBuilder(adp);
            //DataRow[] dr = dt.Select("User_Id='" + Session["Auth_user_id"].ToString() + "'");
            //lblAccountHolder.Text = dr[0]["Name"].ToString();

            //lblAccountHolder.Text = Session["Auth_user_id"].ToString();
            
          
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Profile.aspx");
        }

        protected void btnDisaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Disaster_General.aspx");
        }

        protected void btnTeam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Team_General.aspx");
        }

        protected void btnAlertsHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Alerts_General.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/About_General.aspx");
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Help_General.aspx");
        }

        protected void btnMedical_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Medical_Team_General.aspx");
        }

        protected void btnEmergency_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Emergency_Help_General.aspx");
        }

        protected void btnImgEmergency_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Emergency_Help_General.aspx");
        }

        protected void btnLogout1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Home.aspx");
        }

        protected void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Upload_Image_General.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/Edit_Profile_Form_General.aspx");
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/General_User/View_Profile_General.aspx");
        }
    }
}