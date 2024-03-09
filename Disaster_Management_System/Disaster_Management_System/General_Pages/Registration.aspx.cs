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
    public partial class GeneralRegistration : System.Web.UI.Page
    {
        SqlDataAdapter adp = new SqlDataAdapter("select * from [dbo].[UserDataTable]", @"Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\Project_Net_by_KK\Final_Project\Disaster_Management_System\Disaster_Management_System\App_Data\Database1.mdf;Integrated Security=True");
        DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            adp.Fill(dt);
            SqlCommandBuilder str = new SqlCommandBuilder(adp);
            if (Session["UserClass"].ToString() == "General")
            {
                lblMail.Text = "Mail: ";
            }
            if (Session["UserClass"].ToString() == "DDMO")
            {
                lblMail.Text = "Official Mail: ";
 
            }
            if (Session["UserClass"].ToString() == "Meteorologi" || Session["UserClass"].ToString() == "Medical_Team")
            {
                lblMail.Text = "Official Mail: ";
                lblUserClass.Text = "Team Leader Can Register Only";
            }
            if (Session["Count"].ToString() == "One")
            {

            }
            else
            {
                txtCountry.Text = Session["Country"].ToString();
                txtDist.Text = Session["Dist"].ToString();
                txtMail.Text = Session["Mail"].ToString();
                txtMobile.Text = Session["Mobile"].ToString();
                txtName.Text = Session["Name"].ToString();
                txtPass.Text = Session["Pass"].ToString();
                txtPin.Text = Session["Pin"].ToString();
                //txtUserId.Text = Session["Pin"].ToString();

            }

        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtCountry.Text == "" || txtDist.Text == "" || txtMail.Text == "" || txtMobile.Text == "" || txtPass.Text == "" || txtPin.Text == "" || txtComPass.Text == "" || txtState.Text == "")
            {
                lblErrorMsg.Text = "Fill The Form Properly";
            }
            else
            {
                try
                {
                    DataRow[] dr = dt.Select("Email='" + txtMail.Text + "'");
                    if (dr[0]["Email"].ToString() == txtMail.Text)
                    {
                        lblErrorMsg.Text = "Mail Already Exist Change The Mail";
                    }
                   
                    
                }
                catch
                {
                    //lblErrorMsg.Text = "hii";
                    try
                    {
                        DataRow[] dr1 = dt.Select("Mobile='" + txtMobile.Text + "'");
                        if (dr1[0]["Mobile"].ToString() == txtMobile.Text)
                        {
                            lblErrorMsg.Text = "Mobile Already Exist Change The Number";
                        }

                    }
                    catch
                    {
                        if (txtPass.Text != txtComPass.Text)
                        {
                            lblErrorMsg.Text = "Please Check Your CompPassword";
                        }
                        else
                        {
                            Session["Name"] = txtName.Text.ToString();
                            Session["Country"] = txtCountry.Text.ToString();
                            Session["State"] = txtState.Text.ToString();
                            Session["Dist"] = txtDist.Text.ToString();
                            Session["Pin"] = txtPin.Text.ToString();
                            Session["Mobile"] = txtMobile.Text.ToString();
                            Session["Mail"] = txtMail.Text.ToString();
                            // Session["UserId"] = txtUserId.Text.ToString();
                            Session["Pass"] = txtPass.Text.ToString();
                            Response.Redirect("~/General_Pages/GeSuccessPage.aspx");
                        }
                    }
                }
               
            }
        }
    }
}