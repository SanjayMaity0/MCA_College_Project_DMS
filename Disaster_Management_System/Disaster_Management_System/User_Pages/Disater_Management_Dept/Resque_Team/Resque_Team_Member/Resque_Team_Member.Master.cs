using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Disaster_Management_System.User_Pages.Disater_Management_Dept.Resque_Team.Resque_Team_Member
{
    public partial class Resque_Team_Member : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Member/Profile_Resque_TeamMember.aspx");
        }

        protected void btnDisaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Member/Disaster_Resque_TeamMember.aspx");
        }

        protected void btnteam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Member/Team_Resque_TeamMember.aspx");
        }

        protected void btnAlertsHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Member/AlertsHub_Resque_TeamMember.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Member/About_Resque_TeamMember.aspx");
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Member/Help_Resque_TeamMember.aspx");
        }

        protected void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Member/Upload_Image_Resque_TeamMember.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Member/Edit_Profile_Resque_TeamMember.aspx");
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Disater_Management_Dept/Resque_Team/Resque_Team_Member/View_Profile_Resque_TeamMember.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Home.aspx");
        }
    }
}