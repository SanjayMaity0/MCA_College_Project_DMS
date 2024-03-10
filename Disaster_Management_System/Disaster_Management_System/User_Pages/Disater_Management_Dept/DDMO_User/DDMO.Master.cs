using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Disaster_Management_System.User_Pages.DDMO_User
{
    public partial class DDMO : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAccountHolder.Text = Session["Auth_user_id"].ToString();

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/Profile_DDMO.aspx");
        }

        protected void btnDisaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/Disaster_DDMO.aspx");
        }

        protected void btnteam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/Team_DDMO.aspx");
        }

        protected void btnAlertsHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/AlertsHub_DDMO.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/About_DDMO.aspx");
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/Help_DDMO.aspx");
        }

        protected void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/Upload_Image_DDMO.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/Edit_Profile_DDMO.aspx");
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/View_Profile_DDMO.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/DDMO_User/Add_Resque_TeamLeader_DDMO.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Home.aspx");
        }
    }
}