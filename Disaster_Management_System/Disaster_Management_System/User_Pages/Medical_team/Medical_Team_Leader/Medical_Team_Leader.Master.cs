using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Disaster_Management_System.User_Pages.Medical_team
{
    public partial class Medical_Team : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/Profile_Medical_TeamLeader.aspx");
        }

        protected void btnDisaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/Disaster_Medical_TeamLeader.aspx");
        }

        protected void btnteam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/Team_Medical_TeamLeader.aspx");
        }

        protected void btnAlertsHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/AlertsHub_Medical_TeamLeader.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/About_Medical_TeamLeader.aspx");
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/Help_Medical_TeamLeader.aspx");
        }

        protected void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/UploadImage_Medical_TeamLeader.aspx");
        }

        protected void btnEditProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/ProfileEdit_Form_Medical_TeamLeader.aspx");
        }

        protected void btnViewProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/View_Profile_Medical_TeamLeader.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User_Pages/Medical_team/Medical_Team_Leader/TeamMemberAdding_Form_Medical_TeamLeader.aspx");
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Home.aspx");
        }
    }
}