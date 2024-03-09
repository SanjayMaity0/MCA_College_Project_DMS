using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Disaster_Management_System.User_Pages.Medical_team.Medical_Team_Member
{
    public partial class Medical_Team_Member : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Member/Profile_Medical_TeamMember.aspx");
        }

        protected void btnDisaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Member/Disaster_Medical_TeamMember.aspx");
        }

        protected void btnteam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Member/Team_Medical_TeamMember.aspx");
        }

        protected void btnAlertsHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Member/AlertsHub_Medical_TeamMember.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Member/About_Medical_TeamMember.aspx");
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Member/Help_Medical_TeamMember.aspx");
        }

        protected void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Member/Upload_Image_Medical_TeamMember.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Member/Edit_Profile_Medical_TeamMember.aspx");
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Member/View_Profile_Medical_TeamMember.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Home.aspx");
        }
    }
}