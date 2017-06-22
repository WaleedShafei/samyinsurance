using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SamyWeb
{
    public partial class Login : System.Web.UI.Page
    {
        SamyDBDataContext db = new SamyDBDataContext();
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!Page.IsPostBack)
            //{
            //    txtPass.Text = " ";
            //    txtUser.Text = " ";
            //    lblWelcome.Text = " ";
            //}
        }
        void AllPhotos(string user, int pass)
        {
            var allFilesNames = from d in db.EmployeesFiles where d.LoggedUserName == user.Trim() & d.LoggedUserPassword == pass select d.FileName;


            List<Image> images = new List<Image>();


            int i = 1;
            foreach (string s in allFilesNames)
            {

                string ext = Path.GetExtension(s);
                if (ext.ToLower() == ".gif" | ext.ToLower() == ".png" |
                    ext.ToLower() == ".jpg" | ext.ToLower() == ".jpeg")
                {
                    Image img = new Image();
                    img.Width = 70;
                    img.Height = 80;
                    img.ID = i.ToString();
                    img.ImageUrl = "~/UpImage/" + s;
                    img.Visible = true;

                    Page.Controls.Add(img);
                }
                else
                {
                    ddlFiles.Items.Add(s);
                    ddlFiles.DataValueField = "ID";
                    ddlFiles.DataTextField = "FileName";
                    ddlFiles.DataBind();
                }

                i++;
            }
        }

        bool checkFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".gif": return true;
                case ".png": return true;
                case ".jpg": return true;
                case ".jpeg": return true;
                case ".doc": return true;
                default: return false;
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            lblWelcome.Text = " ";
            //txtUser.Text = "Samy";
            //Response.Write(Convert.ToString(txtUser.Text));

            {

                try
                {
                    int exist = Convert.ToInt32(db.Users.Count(m => m.UserName == txtUser.Text.Trim() & m.Password == Convert.ToInt32(txtPass.Text)));

                    //
                    if (exist == 1)
                    {
                        //var users = db.Users.ToList();
                        User u = db.Users.Single(m => m.UserName == txtUser.Text.Trim() & m.Password == Convert.ToInt32(txtPass.Text));
                        //Response.Redirect("~/UploadImage.aspx?username=" + u.UserName + "");
                        GLobal.pass = Convert.ToInt32(u.Password);
                        GLobal.loggedUser = u.UserName;

                        MultiView1.ActiveViewIndex = 1;
                        lblWelcome.Text = GLobal.WelcomeUser + u.UserName;

                        //Load files to gridview

                        var allFilesNames = from d in db.EmployeesFiles
                                            //where d.LoggedUserName == txtUser.Text.Trim() & d.LoggedUserPassword == Convert.ToInt32(txtPass.Text)
                                            select d;

                        if (GridView1.Visible == false)
                        {
                            GridView1.Visible = true;
                        }
                        GridView1.DataSource = allFilesNames;
                        GridView1.DataBind();

                        //AllPhotos(u.UserName.Trim(), GLobal.pass);
                    }

                    else
                    {
                        Response.Write("<script>alert('كلمة السر خطأ');</script>");
                    }
                }


                catch (FormatException ex)
                {
                    Response.Write("<script>alert('قيم مدخلة بشكل خطأ');</script>");
                    //Response.Redirect("");
                }

                catch (Exception)
                {
                    Response.Write("<script>alert('"+txtUser.Text+ "'+'" + txtPass.Text + "');</script>");
                    //Response.Write("<script>alert('مستخدم غير معرف أو باسورد خطأ');</script>");
                }



            }
        }

        protected void btnSessions_Click(object sender, EventArgs e)
        {
            int sessionID = 0;
            if (Page.IsPostBack)
            {
                if (!UserExist())
                {
                    Session.Add("Visitor", txtUser.Text);
                    sessionID++;

                }
            }
        }


        private bool UserExist()
        {
            try
            {
                int exist = Convert.ToInt32(db.Users.Count(m => m.UserName == txtUser.Text.Trim() & m.Password == Convert.ToInt32(txtPass.Text)));
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Login.aspx");

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            try
            {
                if (upImage.HasFile)
                {
                    if (checkFileType(upImage.FileName))
                    {
                        string filePath = "~/UpImage/" + upImage.FileName;
                        upImage.SaveAs(MapPath(filePath));
                        //save the image to database

                        EmployeesFile empFile = new EmployeesFile();
                        empFile.FileName = upImage.FileName;
                        empFile.File = System.IO.File.ReadAllBytes(Server.MapPath(filePath));
                        empFile.LoggedUserName = GLobal.loggedUser;
                        empFile.LoggedUserPassword = GLobal.pass;

                        //AllPhotos(GLobal.loggedUser, GLobal.pass);
                        db.EmployeesFiles.InsertOnSubmit(empFile);
                        db.SubmitChanges();
                        //Response.Write("<script>alert('Done')</script>");
                        SendMail(txtBody.Text);
                        MultiView1.ActiveViewIndex = 1;
                    }
                }

            }
            catch (System.Net.WebException)
            {
                Response.Write("<script>alert('غير متصل بالانترنت');</script>");
                Response.Write("<script>alert('حدث خطأ سيتم اعادة التوجيه');</script>");
                Response.Redirect("~/LoginUsers.aspx");
            }
        }

        public void SendMail(string emailBody)
        {
            MailMessage mailMessage = new MailMessage("waleedshafei2015@gmail.com", "waleedshafei2017@gmail.com");
            mailMessage.Subject = "Test";
            mailMessage.Body = emailBody;
            mailMessage.Attachments.Add(new Attachment(upImage.PostedFile.InputStream, upImage.PostedFile.FileName));

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new System.Net.NetworkCredential()
            {
                UserName = "waleedshafei2015@gmail.com",
                Password = "B7d4tk9mfh"
            };

            smtp.EnableSsl = true;
            smtp.Send(mailMessage);
        }
    }
}