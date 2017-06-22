using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SamyWeb
{
    public partial class Index : System.Web.UI.Page
    {
        public Decimal tk1 = 0;
        public Double tk2 = 0;
        SamyDBDataContext db = new SamyDBDataContext();
        SamyMethods2017 samy = new SamyMethods2017();
        SamyClass2017 samycls = new SamyClass2017();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            if (txtSen.Text.Trim() == "")
            {
                lblResult.Text = "حدد السن"; return;
            }

            else { lblResult.Text = ""; lblDamga.Text = "بخلاف الدمغات والرسوم"; }
            SamyClass2017.ws_sen1 = Convert.ToInt32(txtSen.Text);

            if (SamyClass2017.ws_sen1 < 20) { SamyClass2017.ws_sen1 = 20; }

            SamyClass2017.ws_inspriod = Convert.ToInt32(txtModa.Text);
            SamyClass2017.ws_inspriod9 = Convert.ToInt32(txtModa.Text);
            SamyClass2017.ws_mab = Convert.ToInt32(txtMab.Text);
            SamyClass2017.ws_strd = Convert.ToDateTime(DateTime.Now);
            SamyClass2017.ws_strd = new DateTime(SamyClass2017.ws_strd.Year, SamyClass2017.ws_strd.Month, 1);

            //int moddda = Convert.ToInt32(txtModa.Text);
            if (SamyClass2017.VarChoice == 1 && SamyClass2017.ws_inspriod < 2)
            {
                lblResult.Text = "مدة تأمين المختلط لا تقل عن ثلاث سنوات";
                txtModa.Text = "3"; SamyClass2017.ws_inspriod = 3; SamyClass2017.ws_inspriod9 = 3;
            }
            if (SamyClass2017.VarChoice < 1 || SamyClass2017.VarChoice > 15)
            {
                Response.Write("<script>alert('حدد نوع التأمين')</script>"); return;

            }


            if (SamyClass2017.ws_strd < SamyClass2017.datetst)
            {
                Response.Write("<script>alert('تاريخ الجهاز اقل من 1-1-2017')</script>"); return;
            }
            if ((SamyClass2017.ws_sen1 < 14) | (SamyClass2017.ws_sen1 > 65))
            {
                Response.Write("<script>alert('السن خطأ'+'" + Convert.ToString(SamyClass2017.ws_sen1) + "')</script>"); return;
            }

            if (SamyClass2017.VarChoice == 1)
            {
                lblResult.Text = "";
                btnResult.Text = btn1.Text;
                samy.rr1();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 2)
            {
                lblResult.Text = "";
                btnResult.Text = btn2.Text;
                samy.rr2();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 3)
            {
                lblResult.Text = "";
                btnResult.Text = btn3.Text;
                samy.rr3();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 4)
            {
                lblResult.Text = "";
                btnResult.Text = btn4.Text;
                samy.rr4();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 5)
            {
                lblResult.Text = "";
                btnResult.Text = btn5.Text;
                samy.rr5();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 6)
            {
                lblResult.Text = "";
                btnResult.Text = btn6.Text;
                samy.rr6();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 7)
            {
                lblResult.Text = "";
                btnResult.Text = btn7.Text;
                samy.rr7();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 8)
            {
                SamyClass2017.w_kstyer = 0;
                txtKstYear.Text = "0";
                txtKstHalf.Text = "0";
                txtKstQuarter.Text = "0";
                txtKstMonth.Text = "0";
                txtKstOnly.Text = "0";

                for (int i = 0; i < 4; i++)
                {
                    SamyMethods2017.nums[i] = 0;
                }

                SamyClass2017.ws_dentyp = 1;

                lblResult.Text = "";
                btnResult.Text = btn8.Text;
                while (SamyClass2017.ws_dentyp <= 4)
                {
                    samy.rr8(); voidError();
                    SamyClass2017.ws_dentyp = SamyClass2017.ws_dentyp + 1;
                }
                //samy.rr8();
                //voidError();
                //voidResult();

                lbl1.Text = "سداد دفعة واحدة";
                lbl2.Text = "سداد دفعات";
                lbl3.Text = "سداد دفعة غير متساوية";
                lbl4.Text = "سداد دفعات غير متساوية";
                txtKstYear.Text = Convert.ToString(SamyMethods2017.nums[0]);
                txtKstHalf.Text = Convert.ToString(SamyMethods2017.nums[1]);
                txtKstQuarter.Text = Convert.ToString(SamyMethods2017.nums[2]);
                txtKstMonth.Text = Convert.ToString(SamyMethods2017.nums[3]);

                return;
            }

            if (SamyClass2017.VarChoice == 9)
            {
                lblResult.Text = "";
                btnResult.Text = btn9.Text;
                samy.rr9();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 10)
            {
                lblResult.Text = "";
                btnResult.Text = btn10.Text;
                samy.rr10();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 11)
            {
                lblResult.Text = "";
                btnResult.Text = btn11.Text;
                samy.rr11();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 12)
            {
                lblResult.Text = "";
                btnResult.Text = btn12.Text;
                samy.rr12();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 13)
            {
                lblResult.Text = "";
                btnResult.Text = btn13.Text;
                samy.rr13();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 14)
            {
                lblResult.Text = "";
                btnResult.Text = btn14.Text;
                samy.rr14();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }

            if (SamyClass2017.VarChoice == 15)
            {
                lblResult.Text = "";
                btnResult.Text = btn15.Text;
                samy.rr15();
                voidError();
                voidResult();
                resetLabelskst();
                return;
            }
        }

        public void resetLabels()
        {

            if (lbl1.Text == "سداد دفعة واحدة")
                lbl1.Text = "قسط سنوي";
            if (lbl2.Text == "سداد دفعات")
                lbl2.Text = "قسط نصف سنوي";
            if (lbl3.Text == "سداد دفعة غير متساوية")
                lbl3.Text = "قسط ربع سنوي";
            if (lbl4.Text == "سداد دفعات غير متساوية")
                lbl4.Text = "قسط شهري";
        }
        public void resetLabelskst()
        {
            lbl1.Text = "قسط سنوي";
            lbl2.Text = "قسط نصف سنوي";
            lbl3.Text = "قسط ربع سنوي";
            lbl4.Text = "قسط شهري";
        }
        protected void btn1_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 1;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }



        protected void btn2_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 2;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn3_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 3;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn4_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 4;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn5_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 5;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn6_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 6;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn7_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 7;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn8_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 8;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn9_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 9;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn10_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 10;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn11_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 11;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";
        }

        protected void btn12_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 12;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn13_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 13;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn14_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 14;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        protected void btn15_Click(object sender, EventArgs e)
        {
            SamyClass2017.VarChoice = 15;
            resetLabelskst();
            voidEmpty();
            btnResult.Text = "Result";

        }

        public void voidResult()
        {
            txtKstYear.Text = SamyClass2017.ryer.ToString();
            txtKstHalf.Text = SamyClass2017.rhav.ToString();
            txtKstQuarter.Text = SamyClass2017.rqrt.ToString();
            txtKstMonth.Text = SamyClass2017.rmonth.ToString();
            txtKstOnly.Text = SamyClass2017.ronly.ToString();
        }

        public void voidEmpty()
        {
            lblDamga.Text = " ";
            txtKstYear.Text = "0";
            txtKstHalf.Text = "0";
            txtKstQuarter.Text = "0";
            txtKstMonth.Text = "0";
            txtKstOnly.Text = "0";

            SamyClass2017.ryer = 0;
            SamyClass2017.rhav = 0;
            SamyClass2017.rqrt = 0;
            SamyClass2017.rmonth = 0;
            SamyClass2017.ronly = 0;
        }
        public void voidError()
        {
            if (samy.ii == 1)
            {
                Response.Write("<script>alert('مدة التعاونية 10 أو 15 أو 20'+'" + "')</script>");
                voidEmpty();

            }
            if (samy.ii == 5)
            {
                Response.Write("<script>alert('مبلغ تأمين التعاونية لابد أن يقبل القسمة علي 5000'+'" + "')</script>");
                voidEmpty();

            }


            if (samy.ii == 2)
            {
                Response.Write("<script>alert('مبلغ التأمين لابد ان يكون اكبر من أو يساوي 1000 جنيه'+'" +  "')</script>");
                voidEmpty();

            }

            if (samy.ii == 3)
            {
                Response.Write("<script>alert('المدة لابد ان تبدأ من 10 الى 30 وتقبل القسمة على خمسة')</script>");
                voidEmpty();

            }

            if (samy.ii == 4)
            {
                Response.Write("<script>alert('المدة لابد ان تبدأ من 5')</script>");
                voidEmpty();

            }

            if (samy.ii == 6)
            {
                Response.Write("<script>alert('pp==1')</script>");
                voidEmpty();

            }


            if (samy.ii == 7)
            {
                Response.Write("<script>alert('متوسط السن اكبر من 65')</script>");
                voidEmpty();

            }

            if (samy.ii == 8)
            {
                Response.Write("<script>alert('متوسط السن اكبر من 55')</script>");
                voidEmpty();

            }

            if (samy.ii == 9)
            {
                Response.Write("<script>alert('مبلغ المؤقت لابد ان يكون اكبر من أو يساوي 5000 جنيها')</script>");
                voidEmpty();

            }
        }
    }
}