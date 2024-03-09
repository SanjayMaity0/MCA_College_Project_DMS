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
    public partial class General2 : System.Web.UI.MasterPage
    {
        SqlDataAdapter adp = new SqlDataAdapter("select *from [dbo].[UserDataTable]", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project_Net_by_KK\Final_Project\Disaster_Management_System\Disaster_Management_System\App_Data\Database1.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            adp.Fill(dt);
            SqlCommandBuilder str = new SqlCommandBuilder(adp);
        }

        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Home.aspx");
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Register.aspx");
        }

        protected void btnDisaster_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Disasters.aspx");
        }

        protected void btnTeam_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Team.aspx");
        }

        protected void btnAleartsHub_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Alerts_Hub.aspx");
        }

        protected void btnAbout_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/About.aspx");
        }

        protected void btnHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Help.aspx");
        }

        protected void btnMedical_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Medical_Team.aspx");
        }

        protected void btnEmergencyHelp_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Emergency_Help.aspx");
        }

        protected void btnIMGEmergencyHelp_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/General_Pages/Emergency_Help.aspx");
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/General_Pages/Register.aspx");
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] dr = dt.Select("Email ='" + txtUserId.Text + "'");
                if (txtPass.Text == dr[0]["Pass"].ToString())
                {
                    //lblLoginAlart.Text = dr[0]["User_Id"].ToString() + "You Successfully Logiin";
                   // Session["Auth_user_id"] = dr[0]["User_Id"].ToString();
                    //Response.Redirect("~/User_Pages/General_User/Profile.aspx");
                    if (dr[0]["User_Class"].ToString() == "General")
                    {
                        Session["Auth_user_id"] = dr[0]["Email"].ToString();
                        //lblLoginAlart.Text = Session["Auth_user_id"].ToString();
                        Response.Redirect("~/User_Pages/General_User/Profile.aspx");
                    }
                    
                    
                }
                else
                {
                    lblLoginAlart.Text = dr[0]["Email"].ToString() + " Enter Correct Password";
                }
                //DataRow[] dr = dt.Select("User_Id='" + txtUserId.Text + "'");
                //lblLoginAlart.Text = dr[0]["Name"].ToString();
                //if (txtPass.Text == dr[0]["Pass"].ToString())
                //{
                //    Session["Auth_user_id"] = dr[0]["User_Id"].ToString();
                //    lblLoginAlart.Text = dr[0]["Name"].ToString() + "You Successfully Login";
                //}
                //else
                //{
                //    lblLoginAlart.Text = dr[0]["User_Id"].ToString() + "Insert Correct Password!!!!";
                //}
            }
            catch
            {
                lblLoginAlart.Text = "User not exit";
            }

        }
    }
}