using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace SamyWeb
{

    public class SamyMethods2017
    {

        public int second = 0, kk_sam = 0, xxsen = 0, xxyer = 0, xxno = 0;
        public double dx1_70 = 0, dx2_20 = 0, dx3_10 = 0, dx4_10 = 0, dx_sum = 0;
        public double w_pen1 = 0, w_pen2 = 0, w_pen3 = 0, w_pen4 = 0, w_penall = 0, w_unit = 0, w_omos = 0;
        public int sm_y = 0, sm_m = 0, sm_d = 0, x_flag = 0, xa1 = 0, xa2 = 0, xa3 = 0, x_div = 0, gg_sen = 0;
        public double x_kst1 = 0, u_kst = 0, va1 = 0, va2 = 0, va3 = 0, w_sahb = 0;
        public double x_bon = 0, wbounsw = 0, x_bonall = 0, l_ls = 0, ee = 0, ee1 = 0, ee_frk = 0;
        public double x_mab = 0, x_prm = 0, x_rag = 0, x_calc = 0, x_rat = 0, x_bak = 0;
        public double gg1 = 0, gg2 = 0, gg3 = 0, wom = 0;
        public double g1 = 0, g2 = 0, g3 = 0;
        public double ao1 = 0, ao2 = 0, ao3 = 0, ao4 = 0, aop = 0, aog = 0, ww_pen = 0;
        public int flagdeps = 0, asen = 0, flagsmsm = 0, x_cur = 0, x_ins = 0, x_yer = 0, w_mabs = 0;
        public double ww_deps2 = 0, zz_deps2 = 0;
        public double w_kstdep = 0, w_kstdep2 = 0, ww_sens2 = 0, ww_moda2 = 0;
        public double ww_sens1 = 0, ww_moda1 = 0, ww_deps1 = 0, zz_deps = 0, a7 = 0;
        public double w_rsm = 0, iikst = 0, ii743 = 0, ii843 = 0, ii943 = 0;
        public int ww_sen2 = 0, gsen = 0;
        public int ww_prn = 0, ww_doc = 0, kk = 0, ll = 0, iiser = 0, lol = 0, ww_sen1 = 0;
        public int yr1 = 0, mn1 = 0, dy1 = 0, yr2 = 0, mn2 = 0, dy2 = 0;
        public int wmoda = 0, xxsamxx = 0, onlykst = 0, yr3 = 0, mn3 = 0, dy3 = 0, ww_id = 0;
        public int xsen = 0, sam_sam = 0, flag_dep = 0, w_sts = 0, w_month = 0, w_tr = 0, pp = 0;
        public int o_over = 0, zsen = 0, frk = 0, wfrk = 0, f_e = 0, xx_xx = 0, ii = 0;
        public String ww_pass = "Çááå", ww_pass1 = "hggi";
        public Double ww_omm = 0, ww_oms = 0, ksr = 0.0, xw_nsb1 = 0, w_sub = 0, w_edkh = 0;
        public Double nz = 0, dz = 0, nz1 = 0, dz1 = 0, nz2 = 0, dz2 = 0, nz3 = 0, dz3 = 0;
        public Double o_kst1 = 0, o_kst2 = 0, omo = 0.0, zrat = 0, z_zft = 0;
        public Double ww_ttt = 0.0, w_shr = 0, b1000 = 0, b100 = 0, rkm = 0, sam_ksr = 0.0;
        public Double zft = 0, zz_ded = 0, zz_ded22 = 0, dedprem = 0, dedprem22 = 0;
        public Double w_rkm_first = 0.0, ww_kst_pay = 0.0, xw_rkm = 0.0, w_kstyer22 = 0.0;
        public Double w_prem = 0.0, w_rkm = 0.0, w_part = 0.0, w_rkm22 = 0, w_kstyer_all22 = 0.0;
        public Double a1000 = 0, a100 = 0, axx = 0, gxx = 0, kxx = 0.0;


        public Double w_kst = 0.0, w_kstyer_all = 0.0, w_kstyer = 0.0, www_rkm = 0;
        public DateTime tstdate = Convert.ToDateTime("2015/10/31");
        public DateTime a2009 = Convert.ToDateTime("2009/01/01");
        public DateTime a1981 = Convert.ToDateTime("1981/01/01");
        public DateTime wdat2 = Convert.ToDateTime("1900/01/01");
        public DateTime xx_end = Convert.ToDateTime("1900/01/01");
        public DateTime xx_tdt = Convert.ToDateTime("1900/01/01");
        public DateTime x_dats = Convert.ToDateTime("1900/01/01");
        public DateTime zz_dendat = Convert.ToDateTime("1900/01/01");
        public DateTime a200609 = Convert.ToDateTime("2006/09/04");
        public DateTime dattdy = Convert.ToDateTime("1900/01/01");
        public DateTime sm_date = Convert.ToDateTime("1900/01/01");
        public DateTime wdat1 = Convert.ToDateTime("1900/01/01");

        public static double[] nums = new double[4];
        public SamyDBDataContext db = new SamyDBDataContext();
        /// <summary>
        /// ////////
        /// </summary>
        public int ws_cod = 0;


        public void get_frk()
        {
            switch (frk)
            {
                case 1: wfrk = 1; break;
                case 2: wfrk = 1; break;
                case 3: wfrk = 2; break;
                case 4: wfrk = 2; break;
                case 5: wfrk = 3; break;
                case 6: wfrk = 3; break;
                case 7: wfrk = 4; break;
                case 8: wfrk = 5; break;
                case 9: wfrk = 5; break;
                case 10: wfrk = 6; break;
                case 11: wfrk = 7; break;
                case 12: wfrk = 8; break;
                case 13: wfrk = 8; break;
                case 14: wfrk = 9; break;
                case 15: wfrk = 10; break;
                case 16: wfrk = 11; break;
                case 17: wfrk = 12; break;
                case 18: wfrk = 12; break;
                case 19: wfrk = 13; break;
                case 20: wfrk = 14; break;
                case 21: wfrk = 15; break;
                case 22: wfrk = 16; break;
                case 23: wfrk = 17; break;
                case 24: wfrk = 18; break;
                case 25: wfrk = 18; break;
                case 26: wfrk = 19; break;
                case 27: wfrk = 20; break;
                case 28: wfrk = 21; break;
                case 29: wfrk = 22; break;
                case 30: wfrk = 23; break;
                case 31: wfrk = 24; break;
                case 32: wfrk = 25; break;
                case 33: wfrk = 26; break;
                case 34: wfrk = 27; break;
            }
        }
        //public void get_calc() { get_rkm(); gg_rsm(); }
        public void get_part_smsm()
        {
            if (SamyClass2017.ws_sdadtyp == 1) { sam_sam = 12; w_month = 1; }
            if (SamyClass2017.ws_sdadtyp == 2) { sam_sam = 06; w_month = 2; }
            if (SamyClass2017.ws_sdadtyp == 3) { sam_sam = 03; w_month = 4; }
            if (SamyClass2017.ws_sdadtyp == 4) { sam_sam = 01; w_month = 12; }
            if (SamyClass2017.ws_sdadtyp == 5) { sam_sam = 01; w_month = 1; }
        }
        public void g_shr()
        {
            w_month = Convert.ToInt32(w_shr);
        }
        public void get_rkm()
        {
            www_rkm = 0; sam_sam = 0;
            SamyClass2017.ws_sdadtyp = 1;
            if (SamyClass2017.w_dival != 0)
            {
                w_part = SamyClass2017.w_dival;
            }
            else
            {
                w_part = 1;
            }
            get_part_smsm();
            ww_kst_pay = sam_sam * (SamyClass2017.ww_payednow + 1);
            if (ww_kst_pay >= 12)
            {
                w_rkm = (w_kstyer_all / w_month * zrat);
                w_rkm22 = (w_kstyer_all22 / w_month * zrat);
            }
            else
            {
                w_rkm = (w_kstyer_all * w_part / w_month * zrat);
                w_rkm22 = (w_kstyer_all22 * w_part / w_month * zrat);
            }
            if (SamyClass2017.ws_sdadtyp == 1)
            {
                xw_rkm = (w_kstyer_all / w_month * zrat);
                w_rkm22 = (w_kstyer_all22 / w_month * zrat);
            }
            else
            {
                xw_rkm = (w_kstyer_all * w_part / w_month * zrat);
                w_rkm22 = (w_kstyer_all22 * w_part / w_month * zrat);
            }
            zft = xw_rkm;
            get_zft();
            xw_rkm = zft;
            SamyClass2017.n_kst = xw_rkm; xw_rkm = Math.Round(xw_rkm, 2);
            www_rkm = xw_rkm;
            get_tkreeb();
            xw_rkm = www_rkm;
            w_rkm = Math.Round(w_rkm, 2);
            www_rkm = w_rkm; get_tkreeb();
            w_rkm = www_rkm; w_rkm22 = Math.Round(w_rkm22, 2);
            www_rkm = w_rkm22; get_tkreeb(); w_rkm22 = www_rkm;
            {
                if (SamyClass2017.ww_payednow > 0)
                {
                    w_rkm_first = w_kstyer_all;
                }
                else
                {
                    w_rkm_first = Math.Round((w_rkm * 1), 2);
                }
            }
            SamyClass2017.ww_kst3 = Math.Round(w_rkm22, 3);
            if (SamyClass2017.ws_cod == 4)
            {
                SamyClass2017.ww_kst3 = SamyClass2017.w_kstall * SamyClass2017.w_dival / 12;
                SamyClass2017.ww_kst3 = SamyClass2017.ww_kst3 * (SamyClass2017.ww_payednow + 1);
                SamyClass2017.ww_kst3 = Math.Round(SamyClass2017.ww_kst3, 3);
            }
            z_zft = SamyClass2017.ww_kst3; get_z_zft(); SamyClass2017.ww_kst3 = z_zft;
            if (SamyClass2017.ww_payednow >= 11)
            {
                SamyClass2017.ww_kst3 = w_kstyer_all;
            }
        }
        public void get_z_zft()
        {
            Decimal uu = 0; Double oo = 0;
            uu = Convert.ToDecimal(z_zft); uu = uu * 100;
            uu = Decimal.Truncate(uu); oo = Convert.ToDouble(uu);
            oo = oo / 100; oo = z_zft - oo; oo = Math.Round(oo, 3);
            oo = oo * 1000; if (oo == 5) { z_zft = z_zft + 0.001; }
            z_zft = Math.Round(z_zft, 2);
        }
        public void get_tkreeb()
        {
            Decimal sw_rkm = 0, sw_rkmg = 0;
            sw_rkm = Convert.ToDecimal(www_rkm); sw_rkmg = Convert.ToDecimal(www_rkm);
            sw_rkm = Math.Round(sw_rkm, 2);
            if (sw_rkmg > sw_rkm)
            {
                sw_rkmg = sw_rkmg - sw_rkm;
            }
            if (sw_rkmg >= Convert.ToDecimal(0.005))
            {
                www_rkm = www_rkm + 0.00;
            }
            else
            {
                www_rkm = Convert.ToDouble(sw_rkm);
            }
            www_rkm = Math.Round(www_rkm, 2);
        }
        public void get_data()
        {
            x_div = 0;
            xa1 = 0; xa2 = 0; xa3 = 0;
            va1 = 0; va2 = 0; va3 = 0;
            gsen = 0; w_kstdep = 0; w_kstdep2 = 0;


            ii = 0; xx_xx = 0;
            if ((SamyClass2017.ws_cod != 5) & (SamyClass2017.ws_cod != 10))
            {
                SamyClass2017.ws_sen2 = 0;
            }
            if ((SamyClass2017.ws_cod != 5) & (SamyClass2017.ws_cod != 6) & (SamyClass2017.ws_cod != 7) & (SamyClass2017.ws_cod != 8))
            {
                a7 = 7.50;
            }
            else
            {
                a7 = 0;
            }
            if (SamyClass2017.ws_cod == 9) { a7 = 0; }
            ww_sen2 = SamyClass2017.ws_sen2;





            ww_sen1 = SamyClass2017.ws_sen1;

            if ((SamyClass2017.ws_cod == 5) | (SamyClass2017.ws_cod == 10))
            {

                SamyClass2017.ws_sen2 = 0;
                if (SamyClass2017.ws_brth2 == SamyClass2017.datnul)
                {
                    SamyClass2017.ws_sen2 = 0; yr3 = 0;
                }
            }


            xxsamxx = 0;
            if (SamyClass2017.ws_cod == 9)
            {
                if ((SamyClass2017.ws_inspriod != 20) & (SamyClass2017.ws_inspriod != 15) & (SamyClass2017.ws_inspriod != 10))
                {

                    ii = 1; return;
                }
            }
            if (SamyClass2017.ws_inspriod < 1)
            {
                ii = 1; return;
            }
            get_ends_sam();
            SamyClass2017.xmodasdd = SamyClass2017.ws_inspriod;
            if (SamyClass2017.ws_cod != 15)
            {
                if (SamyClass2017.ws_cod > 10)
                {
                    int e1 = SamyClass2017.xmodasdd;
                    if ((e1 != 10) & (e1 != 15) & (e1 != 20) & (e1 != 25) & (e1 != 30))
                    {
                        ii = 3;
                        xx_xx = 1; return;
                    }
                }
            }
            else
            {
                int e1 = SamyClass2017.xmodasdd;
                if (e1 < 5)
                {
                    ii = 4; xx_xx = 1; return;
                }
            }
            SamyClass2017.z_adds = 0; SamyClass2017.z_deds = 0;
            SamyClass2017.ws_mab = Convert.ToInt32(SamyClass2017.ws_mab);
            if (SamyClass2017.ws_cod == 9)
            {
                int ww = SamyClass2017.ws_mab / 5000;
                int kk = ww * 5000;
                ww = SamyClass2017.ws_mab;
                if (SamyClass2017.ws_mab != kk)
                {
                    ii = 5; return;
                }

            }

            if (SamyClass2017.ws_cod == 3)
            {
                if (SamyClass2017.ws_mab < 5000)
                {
                    ii = 9;return;
                }
                

            }

            if ((SamyClass2017.ws_mab < 1000) | (SamyClass2017.ws_mab > 100000000))
            {
                ii = 2; return;
            }

            SamyClass2017.z_dat2 = SamyClass2017.ws_strd;




            SamyClass2017.wdat1 = SamyClass2017.ws_strd; SamyClass2017.wdat2 = SamyClass2017.ws_brth2;
            //MessageBox.Show("sssssssssssssss");
            if (SamyClass2017.wdat2 >= SamyClass2017.wdat1)
            {
                ii = 1; return;
            }
            get_sub_dat();
            SamyClass2017.ws_sen2 = 0;
            if (SamyClass2017.ws_brth2 == SamyClass2017.datnul)
            { SamyClass2017.ws_sen2 = 0; yr3 = 0; }

        }

        public void get_ends_sam()
        {
            SamyClass2017.ws_endd = Convert.ToDateTime("1900/01/01");
            wmoda = SamyClass2017.ws_inspriod; wdat1 = SamyClass2017.ws_strd;
            yr1 = SamyClass2017.ws_strd.Year; mn1 = SamyClass2017.ws_strd.Month;
            dy1 = SamyClass2017.ws_strd.Day; yr1 = yr1 + wmoda;
            wdat1 = new DateTime(yr1, mn1, dy1); SamyClass2017.ws_endd = wdat1;
        }
        public void get_sub_dat()
        {
            yr1 = 0; mn1 = 0; dy1 = 0;
            yr2 = 0; mn2 = 0; dy2 = 0;
            yr3 = 0; mn3 = 0; dy3 = 0;
            yr1 = SamyClass2017.wdat1.Year;
            mn1 = SamyClass2017.wdat1.Month;
            dy1 = SamyClass2017.wdat1.Day;
            yr2 = SamyClass2017.wdat2.Year;
            mn2 = SamyClass2017.wdat2.Month;
            dy2 = SamyClass2017.wdat2.Day;
            if (dy1 < dy2)
            {
                mn1 = mn1 - 1; dy1 = dy1 + 30; dy3 = dy1 - dy2;
            }
            else
            {
                dy3 = dy1 - dy2;
            }
            if (mn1 < mn2)
            {
                yr1 = yr1 - 1; mn1 = mn1 + 12; mn3 = mn1 - mn2;
            }
            else
            {
                mn3 = mn1 - mn2;
            }
            yr3 = yr1 - yr2;
            if (mn3 > 5)
            {
                yr3 = yr3 + 1;
            }
        }
        public void get_infc()
        {
            xxsen = xsen;
            if (xsen < 20) { xxsen = 20; }
            if ((SamyClass2017.ws_cod == 2) | (SamyClass2017.ws_cod == 4) | (SamyClass2017.ws_cod == 11)) { xxno = 1; xxyer = 1924; }
            if ((SamyClass2017.ws_cod == 1) | (SamyClass2017.ws_cod == 3) | (SamyClass2017.ws_cod == 7) | (SamyClass2017.ws_cod == 12) | (SamyClass2017.ws_cod == 13) | (SamyClass2017.ws_cod == 14) | (SamyClass2017.ws_cod == 15)) { xxno = 7; xxyer = 1949; }
            if (SamyClass2017.ws_cod == 5) { xxno = 5; xxyer = 1949; }
            if (SamyClass2017.ws_cod == 6) { xxno = 6; xxyer = 1924; }
            if (SamyClass2017.ws_cod == 8) { xxno = 88; xxyer = 1949; }
            if ((SamyClass2017.ws_cod == 3) & (onlykst == 1)) { xxno = 11; xxyer = 1924; }

            SamyClass2017.mx = 0; SamyClass2017.nx = 0; SamyClass2017.dx = 0; SamyClass2017.rx = 0; SamyClass2017.sx = 0;

            if (SamyClass2017.ws_cod == 9) { return; }

            SamyClass2017.para1 = xxno;
            SamyClass2017.para2 = xxyer;
            SamyClass2017.para3 = xxsen;
            para(SamyClass2017.para1, SamyClass2017.para2, SamyClass2017.para3);



        }
        public void get_kst_one()
        {
            SamyClass2017.z_rat_one = 0;
            get_rat_one();
            SamyClass2017.ws_kst5 = w_kstyer * SamyClass2017.z_rat_one;
            SamyClass2017.ws_kst5 = Math.Round(SamyClass2017.ws_kst5, 2);
        }
        public void get_rat_one()
        {
            onlykst = 1;
            xsen = SamyClass2017.ws_sen1;
            get_infc();
            get_infc_mov1();
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod;
            get_infc();
            get_infc_mov2();
            if (SamyClass2017.dx1 == 0)
            {
                SamyClass2017.z_rat_one = 0;
            }
            else
            {
                SamyClass2017.z_rat_one = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1;
                SamyClass2017.z_rat_one = Math.Round(SamyClass2017.z_rat_one, 5);
            }
            /////MessageBox.Show("ÇáãÚÇãá",Convert.ToString(SamyClass2017.z_rat_one));
            onlykst = 0;
        }
        public void get_infc_mov1()
        {
            SamyClass2017.mx1 = SamyClass2017.mx; SamyClass2017.dx1 = SamyClass2017.dx; SamyClass2017.nx1 = SamyClass2017.nx;
            SamyClass2017.rx1 = SamyClass2017.rx; SamyClass2017.sx1 = SamyClass2017.sx;
            SamyClass2017.mx = 0; SamyClass2017.dx = 0; SamyClass2017.nx = 0; SamyClass2017.rx = 0; SamyClass2017.sx = 0;
        }
        public void get_infc_mov2()
        {
            SamyClass2017.mx2 = SamyClass2017.mx; SamyClass2017.dx2 = SamyClass2017.dx; SamyClass2017.nx2 = SamyClass2017.nx;
            SamyClass2017.rx2 = SamyClass2017.rx; SamyClass2017.sx2 = SamyClass2017.sx;
            SamyClass2017.mx = 0; SamyClass2017.dx = 0; SamyClass2017.nx = 0; SamyClass2017.rx = 0; SamyClass2017.sx = 0;
        }
        public void get_infc_mov3()
        {
            SamyClass2017.mx3 = SamyClass2017.mx; SamyClass2017.dx3 = SamyClass2017.dx; SamyClass2017.nx3 = SamyClass2017.nx;
            SamyClass2017.rx3 = SamyClass2017.rx; SamyClass2017.sx3 = SamyClass2017.sx;
            SamyClass2017.mx = 0; SamyClass2017.dx = 0; SamyClass2017.nx = 0; SamyClass2017.rx = 0; SamyClass2017.sx = 0;
        }
        public void get_infc_mov4()
        {
            SamyClass2017.mx4 = SamyClass2017.mx; SamyClass2017.dx4 = SamyClass2017.dx; SamyClass2017.sx = 0;
            SamyClass2017.sx1 = 0; SamyClass2017.sx2 = 0; SamyClass2017.sx3 = 0;
        }
        public void get_infc_mov11()
        {
            SamyClass2017.rx10 = SamyClass2017.rx; SamyClass2017.mx10 = SamyClass2017.mx;
        }

        public void rr3()
        {
            SamyClass2017.ws_cod = 3;

            g_pen_cln();
            flagsmsm = 1;
            get_infc_clean(); gg_data();
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = DateTime.Now;
            SamyClass2017.ws_cod = 3;

            get_data(); gg_deps();
            if (flagdeps == 0) { gg_infc_dep(); }
            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            {
                ii = 6; return;
                // if (r3.Checked == true)
                //{ r3.Checked = false; brdat.Focus(); return; }
            }
            if (ii == 0)
            {
                get_calc3(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            // if (r3.Checked == true) { r3.Checked = false; }
        }

        public void rr4()
        {
            SamyClass2017.ws_cod = 4;

            g_pen_cln();
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            SamyClass2017.ws_cod = 4;

            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            {
                ii = 6; return;
                //if (r4.Checked == true)
                //{ r4.Checked = false; brdat.Focus(); return; }
            }
            if (ii == 0)
            {
                get_calc4(); gg_tst1(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            // if (r4.Checked == true) { r4.Checked = false; }
        }

        public void rr5()
        {
            SamyClass2017.ws_cod = 5;

            g_pen_cln();
            flagsmsm = 5;
            g_en5(); //f_pos2.Select(0, 5); f_pos2.Focus();
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            //if (strdat.Value < a1981) { strdat.Value = dattdy; }
            get_clean2();

            //dtp_brth2.Focus();
            ////////////////////////////////////////////////////////////
            SamyClass2017.ws_sen2 = SamyClass2017.ws_sen1;

            get_calc5();
            gg_tst();
            get_payed();
            get_payed2();
            get_disp();
            get_mor();

            ///////////////////////////////////////////////////////////
            flagsmsm = 5;
        }

        public void rr6()
        {
            SamyClass2017.ws_cod = 6;

            g_pen_cln();
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            SamyClass2017.ws_cod = 6;
            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            {
                ii = 6; return;
                //if (r6.Checked == true)
                //{ r6.Checked = false; brdat.Focus(); return; }
            }
            if (ii == 0)
            {
                get_calc6(); gg_tst1(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            //if (r6.Checked == true) { r6.Checked = false; }
        }

        public void rr7()
        {
            SamyClass2017.ws_cod = 7;

            g_pen_cln();
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            SamyClass2017.ws_cod = 7;

            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            {
                ii = 6; return;
                //if (r7.Checked == true)
                //{ r7.Checked = false; brdat.Focus(); return; }
            }
            if (ii == 0)
            {
                get_calc7(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            // if (r7.Checked == true) { r7.Checked = false; }
        }

        public void rr8()
        {

            SamyClass2017.ws_cod = 8;

            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            {
                //if (r8.Checked == true) { r8.Checked = false; brdat.Focus(); return; }
                //111111111111111111111111111111111111
            }
            if (ii == 0)
            {
                get_calc8(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();

                
                nums[SamyClass2017.ws_dentyp - 1] = SamyClass2017.ryer;
                get_mor();

            }



            //g_pen_cln();
            //flagsmsm = 1;
            //if (ww_prn == 1)
            //{
            //    ww_prn = 0;
            //    get_meza();
            //    return;
            //}
            //get_enab();

            //f_e = 0;
            //dattdy = SamyClass2017.ws_strd;
            //get_clean8();


            //SamyClass2017.ws_cod = 8;
            //com_den.Select(0, 25); com_den.Focus();
            //if (r8.Checked == true) { r8.Checked = false; }
        }

        public void rr9()
        {
            SamyClass2017.ws_cod = 9;
            g_pen_cln();
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;

            SamyClass2017.ws_cod = 9;

            get_data(); gg_deps();

            ////gg_infc_dep();


            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            {
                ii = 6; return;
                //if (r9.Checked == true)
                //{ r9.Checked = false; brdat.Focus(); return; }
            }
            if (ii == 0)
            {
                get_calc9(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            //if (r9.Checked == true) { r9.Checked = false; }
        }

        public void rr10()
        {
            SamyClass2017.ws_cod = 10;
            g_pen_cln();
            flagsmsm = 10;
            g_en5(); //f_pos2.Select(0, 3); f_pos2.Focus();
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            //if (strdat.Value < a1981) { strdat.Value = dattdy; }
            get_clean2();

            ////////////////////////////////////////////////////////////
            SamyClass2017.ws_sen2 = SamyClass2017.ws_sen1;

            get_calc10();
            gg_tst();
            get_payed();
            get_payed2();
            get_disp();
            get_mor();

            ///////////////////////////////////////////////////////////


            flagsmsm = 10;
        }

        public void rr11()
        {
            SamyClass2017.ws_cod = 11;
            g_pen_cln();
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            SamyClass2017.ws_cod = 11;

            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            {
                ii = 6; return;
                //if (r11.Checked == true)
                //{ r11.Checked = false; brdat.Focus(); return; }
            }
            if (ii == 0)
            {
                get_calc11(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            //if (r11.Checked == true) { r11.Checked = false; }
        }
        public void g_div()
        {
            if (SamyClass2017.ws_cod == 12)
            {
                x_div = SamyClass2017.ws_inspriod / 2;
                va1 = 50; va2 = 0; va3 = 0;
            }
            if (SamyClass2017.ws_cod == 13)
            {
                x_div = SamyClass2017.ws_inspriod / 3;
                va1 = 25; va2 = 25; va3 = 0;
            }
            if (SamyClass2017.ws_cod == 14)
            {
                x_div = SamyClass2017.ws_inspriod / 4;
                va1 = 15; va2 = 15; va3 = 20;
            }
            x_div = x_div + 1;
            xa1 = x_div; xa2 = x_div * 2; xa3 = x_div * 3;

        }
        public void rr12()
        {
            SamyClass2017.ws_cod = 12;
            g_pen_cln();
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            SamyClass2017.ws_cod = 12;
            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            g_div();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            {
                ii = 6; return;
                //if (r12.Checked == true)
                //{ r12.Checked = false; brdat.Focus(); return; }
            }
            if (ii == 0)
            {
                get_calc12(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            //if (r12.Checked == true) { r12.Checked = false; }
        }

        public void rr13()
        {
            SamyClass2017.ws_cod = 13;
            g_pen_cln();
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            SamyClass2017.ws_cod = 13;

            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1)
            {
                return;
            }
            get_tst_data();
            if (pp == 1)
            {
                ii = 6; return;
                //if (r13.Checked == true)
                //{ r13.Checked = false; brdat.Focus(); return; }
            }
            if (ii == 0)
            {
                get_calc13(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            //if (r13.Checked == true) { r13.Checked = false; }
        }

        public void rr14()
        {
            SamyClass2017.ws_cod = 14;
            g_pen_cln();
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            SamyClass2017.ws_cod = 14;
            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1)
            {
                return;
            }
            get_tst_data();
            if (pp == 1)
            {
                ii = 6; return;
            }
            if (ii == 0)
            {
                get_calc14(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            //if (r14.Checked == true) { r14.Checked = false; }
        }


        public void get_calc1()
        {
            get_infc_clean(); xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            get_infc();
            get_infc_mov1();
            if (SamyClass2017.ws_sen2 > 0)
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_sen2;
                get_infc();
                get_infc_mov2();
                gg_111(); get_infc_rkm111();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1;
            }
            if (SamyClass2017.ws_sen2 != 0)
            {
                SamyClass2017.ws_sendiv = (SamyClass2017.ws_sen1 + SamyClass2017.ws_sen2) / 2;
            }
            else
            {
                SamyClass2017.ws_sendiv = SamyClass2017.ws_sen1;
            }
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);
            SamyClass2017.ws_sendiv = xsen; xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            //MessageBox.Show("ssssssssssssssssss");
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc();
            get_infc_mov2();
            gg_111(); get_infc_rkm111();
            //x_mab = Convert.ToDouble(SamyClass2017.ws_mab);
            //x_prm = Convert.ToDouble(w_prem);
            //x_rag = Convert.ToDouble(1000);
            //double x_kstyer = 0;
            //x_kstyer = x_mab / x_rag * x_prm;
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            //w_kstyer = x_mab / x_rag * x_prm;

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc2()
        {
            // مؤجل الدفع
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            get_infc();
            get_infc_mov1();
            if (SamyClass2017.ws_sen2 > 0)
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_sen2;
                get_infc(); get_infc_mov2(); get_infc_calc2();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1;
            }
            SamyClass2017.ws_sendiv = xsen; xsen = SamyClass2017.ws_sen1;
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sen1);
            if (xsen < 20)
            {
                xsen = 20;
            }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc();
            get_infc_mov2();
            get_infc_calc2();
            zrat = 1;
            if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd)
            {
                get_kstnew();
            }
            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc3()
        {
            ////ãÄÞÊ ÞÏíÜÜã
            get_tst3();
            if (SamyClass2017.z_tsts == 1)
            {
                SamyClass2017.z_tsts = 0;
                // brdat.Focus();
                return;
            }
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            get_infc();
            get_infc_mov1();
            if (SamyClass2017.ws_sen2 > 0)
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_sen2;
                get_infc(); get_infc_mov2();
                if (SamyClass2017.ws_strd < a200609)
                {
                    get_infc_rkm3();
                }
                else
                {
                    get_infc_rkm3new();
                }
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1;
            }
            SamyClass2017.ws_sendiv = xsen; xsen = SamyClass2017.ws_sen1;
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sen1);
            if (xsen < 20)
            {
                xsen = 20;
            }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc();
            get_infc_mov2();
            if (SamyClass2017.ws_strd < a200609)
            {
                get_infc_rkm3();
            }
            else
            {
                get_infc_rkm3new();
            }
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            //w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;				
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd) { get_kstnew(); }

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc4()
        {
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            get_infc();
            SamyClass2017.ws_sendiv = xsen;
            get_infc_mov1();
            SamyClass2017.ws_sen1 = xsen;
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sen1);
            get_infc_rkm4();
            Double haf = 0.0; haf = rkm * 50 / 100;
            haf = Math.Round(haf, 2); rkm = rkm + haf; w_prem = rkm;
            get_ksts();
            zrat = 1;
            if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd)
            {
                get_kstnew();
            }

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc5()
        {
            //ãÎÊáØ Úáì ÔÎÕíä
            get_infc_clean();
            get_ins_5();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            xsen = SamyClass2017.ws_sendiv;
            get_infc();
            get_infc_mov1();
            if (xsen < 20)
            {
                xsen = 20;
            }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc();
            get_infc_mov2();
            get_infc_calc();
            get_infc_rkm5();
            zrat = 1;
            if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd)
            {
                get_kstnew();
            }
            //SamyClass2017.ws_sendiv = (SamyClass2017.ws_sen1 + SamyClass2017.ws_sen2)/2;
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc6()
        {
            ////ÇáãåäÏÓ
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            get_infc();
            get_infc_mov1();
            if (SamyClass2017.ws_sen2 > 0)
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_sen2;
                get_infc(); get_infc_mov2(); get_infc_calc6();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1;
            }
            SamyClass2017.ws_sendiv = xsen; xsen = SamyClass2017.ws_sen1;
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);
            if (xsen < 20)
            {
                xsen = 20;
            }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc();
            get_infc_mov2();
            get_infc_calc6();
            zrat = 1;
            if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd)
            {
                get_kstnew();
            }

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc7()
        {
            //ÇáãÊÒÇíÏå
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            ww_id = 7;
            get_infc_calc7();
            get_sahb();
            zrat = 1;
            if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd)
            {
                get_kstnew();
            }
            SamyClass2017.ws_sendiv = SamyClass2017.ws_sen1;
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc8()
        {
            //ÇáãÊäÇÞÕ
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            SamyClass2017.ws_sendiv = xsen;
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            get_ins_8();
            get_infc_calc8();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd)
            {
                get_kstnew();
            }
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc9()
        {
            w_edkh = 0;
            ////ÇáÊÚÇæäíå
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20)
            {
                xsen = 20;
            }
            SamyClass2017.ws_sendiv = xsen; xsen = SamyClass2017.ws_sen1;
            if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_kst9();
            if (gxx == 0)
            {
                w_unit = Convert.ToDouble(SamyClass2017.ws_mab / 1000);
                w_mabs = 5000;
                w_omos = Convert.ToDouble(SamyClass2017.ws_mab / 5000);
                get_kst9_new();
                //gxx = gxx * w_unit;
                w_edkh = w_edkh * w_omos;
                ww_omm = ww_omm * w_omos; ww_oms = ww_oms * w_omos;

                gxx = Math.Round(gxx, 2); w_edkh = Math.Round(w_edkh, 2);
                ww_omm = Math.Round(ww_omm, 2); ww_oms = Math.Round(ww_oms, 2);
            }
            get_part_month();
            get_infc_rkm9();
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            //            w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;				
            zrat = 1;
            if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd) { get_kstnew(); }
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc10()
        {
            //ÇÈäÇÁ
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20) { xsen = 20; }
            get_infc10();
            SamyClass2017.mx1 = SamyClass2017.mx; SamyClass2017.nx1 = SamyClass2017.nx; SamyClass2017.dx1 = SamyClass2017.dx;
            if (SamyClass2017.sen > 0)
            {
                xsen = xsen + SamyClass2017.ws_sen2; SamyClass2017.ws_sendiv = xsen;
            }
            else
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_inspriod;
            }
            get_infc10();
            SamyClass2017.mx2 = SamyClass2017.mx; SamyClass2017.nx2 = SamyClass2017.nx; SamyClass2017.dx2 = SamyClass2017.dx;
            get_infc_calc10();
            get_infc_rkmnew10();
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd) { get_kstnew(); }

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc11()
        {
            ////ÝÖíå
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20) { xsen = 20; }
            get_infc();
            get_infc_mov1();
            if (SamyClass2017.ws_sen2 > 0)
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_sen2;
                get_infc();
                get_infc_mov2();
                get_infc_rkm();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1;
            }
            SamyClass2017.ws_sendiv = xsen;
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc();
            get_infc_mov2();
            xsen = SamyClass2017.ws_sen1 + 10;
            get_infc();
            get_infc_mov11();
            get_infc_rkm11();
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            //			w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;							
            zrat = 1;
            if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd)
            {
                get_kstnew();
            }
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc12()
        {
            ///ËäÇÆíå
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20) { xsen = 20; }
            get_infc();
            get_infc_mov1();
            if (SamyClass2017.ws_sen2 > 0)
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_sen2;
                get_infc();
                get_infc_mov2();
                get_infc_rkm112();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1;
            }
            SamyClass2017.ws_sendiv = xsen;
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc(); get_infc_mov2();
            SamyClass2017.z_dx = 0; SamyClass2017.z_dxx = 0; SamyClass2017.z_dxxx = 0;
            if (SamyClass2017.ws_inspriod == 10) { SamyClass2017.z_dx = 5; }
            if (SamyClass2017.ws_inspriod == 15) { SamyClass2017.z_dx = 8; }
            if (SamyClass2017.ws_inspriod == 20) { SamyClass2017.z_dx = 10; }
            if (SamyClass2017.ws_inspriod == 25) { SamyClass2017.z_dx = 13; }
            if (SamyClass2017.ws_inspriod >= 30) { SamyClass2017.z_dx = 15; }
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.z_dx;
            get_infc();
            get_infc_mov3();
            get_infc_rkm112();
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            //w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;				
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd) { get_kstnew(); }
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc13()
        {
            ///ËáÇËíå
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1; get_infc(); get_infc_mov1();
            if (SamyClass2017.ws_sen2 > 0)
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_sen2;
                get_infc();
                get_infc_mov2();
                get_infc_rkm113();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1;
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            }
            SamyClass2017.ws_sendiv = xsen;
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc(); get_infc_mov2();
            SamyClass2017.z_dx = 0; SamyClass2017.z_dxx = 0; SamyClass2017.z_dxxx = 0;
            if (SamyClass2017.ws_inspriod == 10) { SamyClass2017.z_dx = 3; SamyClass2017.z_dxx = 6; }
            if (SamyClass2017.ws_inspriod == 15) { SamyClass2017.z_dx = 5; SamyClass2017.z_dxx = 10; }
            if (SamyClass2017.ws_inspriod == 20) { SamyClass2017.z_dx = 7; SamyClass2017.z_dxx = 14; }
            if (SamyClass2017.ws_inspriod == 25) { SamyClass2017.z_dx = 8; SamyClass2017.z_dxx = 16; }
            if (SamyClass2017.ws_inspriod >= 30) { SamyClass2017.z_dx = 10; SamyClass2017.z_dxx = 20; }
            xsen = SamyClass2017.ws_sen1;
            if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.z_dx;
            get_infc(); get_infc_mov3();
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.z_dxx;
            get_infc(); get_infc_mov4();
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.z_dxxx;
            get_infc(); get_infc_rkm113();
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            //w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;				
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd) { get_kstnew(); }
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc14()
        {
            ///ÑÈÇÚíå
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            get_infc(); get_infc_mov1();
            if (SamyClass2017.ws_sen2 > 0)
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_sen2;
                get_infc();
                get_infc_mov2();
                get_infc_rkm114();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            }
            SamyClass2017.ws_sendiv = xsen;
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc();
            get_infc_mov2();
            SamyClass2017.z_dx = 0; SamyClass2017.z_dxx = 0; SamyClass2017.z_dxxx = 0;
            if (SamyClass2017.ws_inspriod == 10)
            { SamyClass2017.z_dx = 3; SamyClass2017.z_dxx = 5; SamyClass2017.z_dxxx = 8; }
            if (SamyClass2017.ws_inspriod == 15)
            { SamyClass2017.z_dx = 4; SamyClass2017.z_dxx = 8; SamyClass2017.z_dxxx = 12; }
            if (SamyClass2017.ws_inspriod == 20)
            { SamyClass2017.z_dx = 5; SamyClass2017.z_dxx = 10; SamyClass2017.z_dxxx = 15; }
            if (SamyClass2017.ws_inspriod == 25)
            { SamyClass2017.z_dx = 7; SamyClass2017.z_dxx = 14; SamyClass2017.z_dxxx = 21; }
            if (SamyClass2017.ws_inspriod >= 30)
            { SamyClass2017.z_dx = 8; SamyClass2017.z_dxx = 16; SamyClass2017.z_dxxx = 24; }
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.z_dx;
            get_infc(); get_infc_mov3();
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.z_dxx;
            get_infc(); get_infc_mov4();
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.z_dxxx;
            get_infc(); get_infc_rkm114();
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            //w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd) { get_kstnew(); }
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_calc15()
        {
            ////ãÄÞÊ ãÚ ÑÏ ÇáÇÞÓÇØ
            get_infc_clean();
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            get_infc(); get_infc_mov1();
            if (SamyClass2017.ws_sen2 > 0)
            {
                xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
                xsen = xsen + SamyClass2017.ws_sen2;
                get_infc();
                get_infc_mov2();
                get_infc_rkm();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1;
            }
            SamyClass2017.ws_sendiv = xsen;
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            xsen = xsen + SamyClass2017.ws_inspriod;
            get_infc();
            get_infc_mov2();
            get_infc_rkm15();
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            //w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;				
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.xmodasdd) { get_kstnew(); }
            //t_sen1.Text = Convert.ToString(SamyClass2017.ws_sendiv);

            kk_pen();

            gg_rsm(); if (flagdeps == 1) { SamyClass2017.ws_dep = SamyClass2017.dep; zz_rsm(); }
            gg_sum();
            zrat = 1; if (SamyClass2017.ws_inspriod != SamyClass2017.ws_inspriod9) { get_kstnew(); }
            get_rkm();
        }
        public void get_infc_rkm15()
        {
            a1000 = ((SamyClass2017.mx1 - SamyClass2017.mx2) / (SamyClass2017.nx1 - SamyClass2017.nx2)) * 1000; a1000 = a1000 + 1;
            Double xsx = 0.83; a100 = 1 / ((SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1);
            Double zsz = (SamyClass2017.ws_inspriod - 2);
            zsz = xsx - (zsz * (SamyClass2017.dx2 / SamyClass2017.dx1) * a100); gxx = a1000 / zsz;
            w_kst = gxx;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            w_prem = w_kst;
        }
        public void get_infc_rkm14()
        {
            a1000 = (1000 * (SamyClass2017.mx1 - SamyClass2017.mx2)) + (150 * SamyClass2017.dx3) + (150 * SamyClass2017.dx4) + (200 * SamyClass2017.dx) + (500 * SamyClass2017.dx2);
            a1000 = a1000 / SamyClass2017.dx1; a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1; gxx = a1000 / a100;
            Double gzz = 0.0;
            if ((SamyClass2017.ws_inspriod == 10) | (SamyClass2017.ws_inspriod == 15))
            { gzz = (gxx + 3.50 + (55 / a100)) / 0.96; }
            if ((SamyClass2017.ws_inspriod == 25) | (SamyClass2017.ws_inspriod == 30))
            { gzz = (gxx + 3.50) / (0.96 - (1.10 / a100)); }
            if (SamyClass2017.ws_inspriod == 20)
            {
                if ((SamyClass2017.ws_sen1 >= 28) & (SamyClass2017.ws_sen1 <= 50))
                { gzz = (gxx + 3.50 + (55 / a100)) / 0.96; }
                else
                { gzz = (gxx + 3.50) / (0.96 - (1.10 / a100)); }
            }
            w_kst = gzz;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            w_prem = w_kst;

            ww_ttt = w_kst; w_prem = w_kst;
            if (w_tr == 1)
            {
                if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
            }
            //ÇáÊÎÝíÖ
            if (w_tr == 1)
            {
                if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
            }
        }
        public void get_infc_rkm13()
        {
            a1000 = (1000 * (SamyClass2017.mx1 - SamyClass2017.mx2)) + (250 * SamyClass2017.dx3) + (250 * SamyClass2017.dx4) + (500 * SamyClass2017.dx2);
            a1000 = a1000 / SamyClass2017.dx1; a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1; gxx = a1000 / a100;
            Double gzz = 0.0;
            if ((SamyClass2017.ws_inspriod == 10) | (SamyClass2017.ws_inspriod == 15))
            { gzz = (gxx + 3.50 + (55 / a100)) / 0.96; }
            if ((SamyClass2017.ws_inspriod == 20) & (SamyClass2017.ws_sen1 > 28))
            { gzz = (gxx + 3.50 + (55 / a100)) / 0.96; }
            if ((SamyClass2017.ws_inspriod == 20) & (SamyClass2017.ws_sen1 <= 28))
            {
                Double loading = 0.96 - (1.10 / a100);
                gzz = (gxx + 3.50) / loading;
            }
            if ((SamyClass2017.ws_inspriod == 25) | (SamyClass2017.ws_inspriod == 30))
            {
                Double loading = 0.96 - (1.10 / a100);
                gzz = (gxx + 3.50) / loading;
            }
            w_kst = gzz;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            w_prem = w_kst;

            ww_ttt = w_kst; w_prem = w_kst;
            if (w_tr == 1)
            {
                if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
            }
            //ÇáÊÎÝíÖ
            if (w_tr == 1)
            {
                if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
            }
        }
        public void get_infc_rkm12()
        {
            a1000 = (SamyClass2017.mx1 - SamyClass2017.mx2) + (SamyClass2017.dx3 / 2) + (SamyClass2017.dx2 / 2); a1000 = (a1000 * 1000);
            a1000 = a1000 / SamyClass2017.dx1; a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1;
            gxx = a1000 / a100;
            Double gzz = 0.0;
            if ((SamyClass2017.ws_inspriod == 10) | (SamyClass2017.ws_inspriod == 15))
            { gzz = (gxx + 3.50 + (55 / a100)) / 0.96; }
            if ((SamyClass2017.ws_inspriod == 25) | (SamyClass2017.ws_inspriod == 30))
            { gzz = (gxx + 3.50) / (0.96 - (1.10 / a100)); }
            if (SamyClass2017.ws_inspriod == 20)
            {
                if ((SamyClass2017.ws_sen1 >= 25) & (SamyClass2017.ws_sen1 <= 50))
                { gzz = (gxx + 3.50 + (55 / a100)) / 0.96; }
                else
                { gzz = (gxx + 3.50) / (0.96 - (1.10 / a100)); }
            }
            w_kst = gzz;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            w_prem = w_kst;

            ww_ttt = w_kst; w_prem = w_kst;
            if (w_tr == 1)
            {
                if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
            }
            //ÇáÊÎÝíÖ
            if (w_tr == 1)
            {
                if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
            }
        }
        public void get_infc_rkm11()
        {
            a1000 = ((SamyClass2017.mx1 - SamyClass2017.mx2 + SamyClass2017.dx2) / (SamyClass2017.nx1 - SamyClass2017.nx2)) * 1000;
            Double xsx = 300, dxx = 0.0, bxx = 0.0, bouns = 0.0, a100 = 0.0;
            if (SamyClass2017.ws_sen2 > 0) { xsx = (SamyClass2017.ws_sen2 / xsx); }
            else { xsx = (SamyClass2017.ws_inspriod / xsx); }
            gxx = Convert.ToDouble(xsx); gxx = 1 - gxx;
            dxx = (0.03 * SamyClass2017.ws_inspriod * SamyClass2017.dx2 * 1000) / SamyClass2017.dx1;
            bxx = (0.01 * 1000 * ((SamyClass2017.rx1 - SamyClass2017.rx2 - (SamyClass2017.ws_inspriod * SamyClass2017.mx2)) + (SamyClass2017.rx1 - SamyClass2017.rx10 - (10 * SamyClass2017.mx10)))) / SamyClass2017.dx1;
            a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1; bouns = (dxx + bxx) / a100;
            w_kst = (a1000 + 2 + bouns) / gxx;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            if (SamyClass2017.sen > 0)
            {
                w_prem = w_kst;
                w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                //w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;	
                //w_kstyer22 = w_prem * SamyClass2017.ws_mab / 1000;	
                flag_dep = 1; return;
            }
            else
            {
                ww_ttt = w_kst; w_prem = w_kst;
                if (w_tr == 1)
                {
                    if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                    { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
                }
                if (w_tr == 1)
                {
                    if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
                }
                w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                flag_dep = 0;
            }
            SamyClass2017.ws_sen2 = 0;
        }
        public void get_infc_rkmnew10()
        {
            if (SamyClass2017.sen > 0)
            {
                w_prem = w_kst; ww_ttt = w_kst; w_prem = ww_ttt + 1.50;
                w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                flag_dep = 1; return;
            }
            else
            {
                ww_ttt = w_kst; ww_ttt = w_kst; w_prem = ww_ttt + 1.50;
                if (w_tr == 1)
                {
                    if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                    { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
                }
                if (w_tr == 1)
                {
                    if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
                }
                w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                flag_dep = 0;
            }
            SamyClass2017.ws_sen2 = 0;
        }
        public void get_infc_calc10()
        {
            w_kst = 0;
            if (SamyClass2017.sen > 0) { a1000 = Math.Pow((1 / (1 + .04)), SamyClass2017.sen) * 1000; }
            else { a1000 = Math.Pow((1 / (1 + .04)), SamyClass2017.ws_inspriod) * 1000; }
            a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1;
            Decimal mxxx = 0, nxxx = 300;
            if (SamyClass2017.sen > 0) { mxxx = SamyClass2017.sen / nxxx; }
            else { mxxx = SamyClass2017.ws_inspriod / nxxx; }
            mxxx = 1 - mxxx;
            kxx = Convert.ToDouble(mxxx);
            gxx = (((a1000 / a100) + 2) / kxx);
            w_kst = gxx;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            ww_ttt = w_kst; w_prem = ww_ttt + 1.50;
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
        }
        public void get_infc_rkm9()
        {
            w_kst = gxx;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            ww_ttt = w_kst; w_prem = w_kst;
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            w_edkh = (w_edkh * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00) / Convert.ToDouble(w_month);
            w_edkh = Math.Round(w_edkh, 2);
        }
        public void get_part_month()
        {
            if (SamyClass2017.ws_sdadtyp == 0) { SamyClass2017.ws_sdadtyp = 1; }
            if (SamyClass2017.ws_cod != 7)
            {
                if (SamyClass2017.ws_sdadtyp == 1) { w_part = 1; w_month = 1; }
                if (SamyClass2017.ws_sdadtyp == 2) { w_part = 1.02; w_month = 2; }
                if (SamyClass2017.ws_sdadtyp == 3) { w_part = 1.03; w_month = 4; }
                if (SamyClass2017.ws_sdadtyp == 4) { w_part = 1.05; w_month = 12; }
                if (SamyClass2017.ws_sdadtyp == 5) { w_part = 1; w_month = 1; }
            }
            else
            {
                if (SamyClass2017.ws_sdadtyp == 1) { w_part = 1; w_month = 1; }
                if (SamyClass2017.ws_sdadtyp == 2) { w_part = 1.02; w_month = 2; }
                if (SamyClass2017.ws_sdadtyp == 3) { w_part = 1.03; w_month = 4; }
                if (SamyClass2017.ws_sdadtyp == 4) { w_part = 1.04; w_month = 12; }
                if (SamyClass2017.ws_sdadtyp == 5) { w_part = 1; w_month = 1; }
            }
            if (SamyClass2017.w_prod == 3) { w_part = 1; }
        }
        public void get_kst9()
        {
            gxx = 0; w_kst = 0; w_edkh = 0; ww_omm = 0; ww_oms = 0;
            //if (cons4.State == System.Data.ConnectionState.Open)
            //{ cons4.Close(); }
            //cons4.ConnectionString = SamyClass2017.connstring;

            //System.Data.OleDb.OleDbDataReader kxxc = null;
            //oleDbCommand1.CommandText = "SELECT kst, edk, omm, oms FROM T_kst9 WHERE (cod = " + SamyClass2017.ws_inspriod + ") AND(moda = " + SamyClass2017.ws_mab + ")";
            //oleDbCommand1.Connection = cons4;
            //try
            //{
            //    cons4.Open();


            //    //            sqlCommand17.Parameters[0].Value = SamyClass2017.ws_inspriod;	
            //    //sqlCommand17.Parameters[1].Value = SamyClass2017.ws_mab;
            //    kxxc = oleDbCommand1.ExecuteReader();
            //    while (kxxc.Read())
            //    {
            //        if (!Convert.IsDBNull(kxxc[0])) { gxx = Convert.ToDouble(kxxc[0]); }
            //        if (!Convert.IsDBNull(kxxc[1])) { w_edkh = Convert.ToDouble(kxxc[1]); }
            //        if (!Convert.IsDBNull(kxxc[2])) { ww_omm = Convert.ToDouble(kxxc[2]); }
            //        if (!Convert.IsDBNull(kxxc[3])) { ww_oms = Convert.ToDouble(kxxc[3]); }
            //    }
            //}
            //catch
            //{
            //    if (kxxc.IsClosed == false) { kxxc.Close(); }
            //    if (kxxc.IsClosed == false) { kxxc.Close(); }
            //    if (cons4.State == System.Data.ConnectionState.Open)
            //    { cons4.Close(); }
            //}
        }
        public void get_kst9_new()
        {
            gxx = 0; w_kst = 0; w_edkh = 0; ww_omm = 0; ww_oms = 0;
            //if (cons4.State == System.Data.ConnectionState.Open)
            //{ cons4.Close(); }
            //cons4.ConnectionString = SamyClass2017.connstring;
            //System.Data.OleDb.OleDbDataReader kxxc = null;
            //oleDbCommand1.CommandText = "SELECT kst, edk, omm, oms FROM T_kst9 WHERE (cod = " + SamyClass2017.ws_inspriod + ") AND(moda = " + w_mabs + ")";
            //try
            //{
            //    cons4.Open();

            //    //oleDbCommand1.Parameters[0].Value = SamyClass2017.ws_inspriod;
            //    //sqlCommand17.Parameters[1].Value = w_mabs;
            //    kxxc = oleDbCommand1.ExecuteReader();
            //    while (kxxc.Read())
            //    {
            //        if (!Convert.IsDBNull(kxxc[0])) { gxx = Convert.ToDouble(kxxc[0]); }
            //        if (!Convert.IsDBNull(kxxc[1])) { w_edkh = Convert.ToDouble(kxxc[1]); }
            //        if (!Convert.IsDBNull(kxxc[2])) { ww_omm = Convert.ToDouble(kxxc[2]); }
            //        if (!Convert.IsDBNull(kxxc[3])) { ww_oms = Convert.ToDouble(kxxc[3]); }
            //    }
            //}
            //catch
            //{
            //    if (kxxc.IsClosed == false) { kxxc.Close(); }
            //    if (cons4.State == System.Data.ConnectionState.Open)
            //    { cons4.Close(); }
            //}
            var sss = from d in db.T_kst9s where d.cod == SamyClass2017.ws_inspriod && d.moda == w_mabs select d;
            foreach (var item in sss)
            {
                gxx = Convert.ToDouble(item.kst);
                w_edkh = Convert.ToDouble(item.edk);
                ww_omm = Convert.ToDouble(item.omm);
                ww_oms = Convert.ToDouble(item.oms);
            }

        }
        public void get_infc_clean()
        {
            x_mab = 0; x_prm = 0; x_rag = 0;
            a1000 = 0; a100 = 0; gxx = 0; axx = 0; kxx = 0; xsen = 0;
            SamyClass2017.mx1 = 0; SamyClass2017.dx1 = 0; SamyClass2017.mx2 = 0; SamyClass2017.dx2 = 0; SamyClass2017.nx1 = 0; SamyClass2017.nx2 = 0;
            SamyClass2017.rx1 = 0; SamyClass2017.rx2 = 0; SamyClass2017.rx3 = 0; SamyClass2017.sx = 0; SamyClass2017.sx1 = 0; SamyClass2017.sx2 = 0; SamyClass2017.sx3 = 0;
            b1000 = 0; b100 = 0; SamyClass2017.rx10 = 0; SamyClass2017.mx10 = 0;
        }
        public void get_infc_rkm()
        {
            //MessageBox.Show("ssssssssssssssssssss");
            a1000 = ((SamyClass2017.mx1 - SamyClass2017.mx2 + SamyClass2017.dx2) / (SamyClass2017.nx1 - SamyClass2017.nx2)) * 1000;
            Double xsx = 300;
            if (SamyClass2017.ws_sen2 > 0) { xsx = (SamyClass2017.ws_sen2 / xsx); }
            else { xsx = (SamyClass2017.ws_inspriod / xsx); }
            gxx = Convert.ToDouble(xsx); gxx = (a1000 + 2) / (1 - gxx);
            w_kst = gxx;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            if (SamyClass2017.sen > 0)
            {
                w_prem = w_kst; w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00; flag_dep = 1; return;
            }
            else
            {
                ww_ttt = w_kst; w_prem = w_kst;
                if (w_tr == 1)
                {
                    if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                    { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
                }
                //ÇáÊÎÝíÖ
                if (w_tr == 1)
                {
                    if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
                }
                w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00; flag_dep = 0;
            }
            SamyClass2017.ws_sen2 = 0;
        }
        public void get_zft_omo_kst()
        {
            zft = w_kst;
            get_zft();
            w_kst = zft;
        }
        public void get_disp()
        {
            w_pen1 = 0; w_pen2 = 0; w_pen3 = 0; w_pen4 = 0; w_penall = 0;
            SamyClass2017.w_kst = w_kst;
            // t_kst.Text = Convert.ToString(w_kst);


            gxx = Math.Round(gxx, 2);


            if (SamyClass2017.ws_cod == 4) { gxx = w_prem; }
            if (SamyClass2017.ws_cod == 8) { gxx = w_prem; }
            if (w_prem == 0)
            {// t_prem.Text = Convert.ToString(w_kst);
                SamyClass2017.w_prem = w_kst;
            }
            else
            {
                //t_prem.Text = Convert.ToString(w_prem);
                SamyClass2017.w_prem = w_prem;
            }
            //txt_kstyer.Text = Convert.ToString(w_kstyer);
            SamyClass2017.w_kstyer = w_kstyer;
            get_dmga();
            //ryer
            SamyClass2017.ryer = Convert.ToDouble(SamyClass2017.ws_kst1 + SamyClass2017.w_nbs1 + SamyClass2017.w_esh1);
            SamyClass2017.rhav = Convert.ToDouble(SamyClass2017.ws_kst2 + SamyClass2017.w_nbs2 + SamyClass2017.w_esh2);
            SamyClass2017.rqrt = Convert.ToDouble(SamyClass2017.ws_kst3 + SamyClass2017.w_nbs3 + SamyClass2017.w_esh3);
            SamyClass2017.rmonth = Convert.ToDouble(SamyClass2017.ws_kst4 + SamyClass2017.w_nbs4 + SamyClass2017.w_esh4);
            SamyClass2017.ronly = Convert.ToDouble(SamyClass2017.ws_kst5 + SamyClass2017.w_nbs5 + SamyClass2017.w_esh5);
            if (SamyClass2017.ws_inspriod9 > 5)
            {

                //w_pen1 = Convert.ToDouble(textBox16.Text);
                //w_pen2 = Convert.ToDouble(textBox26.Text);
                //w_pen3 = Convert.ToDouble(textBox36.Text);
                //w_pen4 = Convert.ToDouble(textBox46.Text);
                //w_penall = Convert.ToDouble(textBox446.Text);
            }
            //t_omola1.Text = Convert.ToString(SamyClass2017.o_o1);
            //t_omola2.Text = Convert.ToString(SamyClass2017.o_o2);
            //t_omola3.Text = Convert.ToString(SamyClass2017.o_o3);
            //t_omola4.Text = Convert.ToString(SamyClass2017.o_o4);
            //t_omola5.Text = Convert.ToString(SamyClass2017.o_o5);
            //t_omola_all.Text = Convert.ToString(SamyClass2017.o_oz);

            //t_omola11.Text = Convert.ToString(SamyClass2017.o_o11);
            //t_omola22.Text = Convert.ToString(SamyClass2017.o_o22);
            //t_omola33.Text = Convert.ToString(SamyClass2017.o_o33);
            //t_omola44.Text = Convert.ToString(SamyClass2017.o_o44);
            //t_omola55.Text = Convert.ToString(SamyClass2017.o_o55);
            //t_omola_all2.Text = Convert.ToString(SamyClass2017.o_ozz);

            //t_omola111.Text = Convert.ToString(SamyClass2017.o_o111);
            //t_omola222.Text = Convert.ToString(SamyClass2017.o_o222);
            //t_omola333.Text = Convert.ToString(SamyClass2017.o_o333);
            //t_omola444.Text = Convert.ToString(SamyClass2017.o_o444);
            //t_omola555.Text = Convert.ToString(SamyClass2017.o_o555);
            //t_omola_all3.Text = Convert.ToString(SamyClass2017.o_ozzz);

            //t_omola1111.Text = Convert.ToString(SamyClass2017.o_o1111);
            //t_omola2222.Text = Convert.ToString(SamyClass2017.o_o2222);
            //t_omola3333.Text = Convert.ToString(SamyClass2017.o_o3333);
            //t_omola4444.Text = Convert.ToString(SamyClass2017.o_o4444);
            //t_omola5555.Text = Convert.ToString(SamyClass2017.o_o5555);
            //t_omola_all4.Text = Convert.ToString(SamyClass2017.o_ozzzz);
        }
        public void get_dmga()
        {
            ww_pen = SamyClass2017.ws_pen / 2.00;
            ww_pen = Math.Round(ww_pen, 2);
            ///MessageBox.Show("sssssss", Convert.ToString(SamyClass2017.ws_pen));
			xw_nsb1 = 0.005;
            SamyClass2017.w_nbs1 = (SamyClass2017.ws_kst1 * xw_nsb1);
            ksr = SamyClass2017.w_nbs1; get_decm(); SamyClass2017.w_nbs1 = ksr;
            SamyClass2017.w_esh1 = (SamyClass2017.ws_kst1 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh1; get_decm(); SamyClass2017.w_esh1 = ksr;

            SamyClass2017.w_nbs2 = (SamyClass2017.ws_kst2 * xw_nsb1);
            ksr = SamyClass2017.w_nbs2; get_decm(); SamyClass2017.w_nbs2 = ksr;
            SamyClass2017.w_esh2 = (SamyClass2017.ws_kst2 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh2; get_decm(); SamyClass2017.w_esh2 = ksr;

            SamyClass2017.w_nbs3 = (SamyClass2017.ws_kst3 * xw_nsb1);
            ksr = SamyClass2017.w_nbs3; get_decm(); SamyClass2017.w_nbs3 = ksr;
            SamyClass2017.w_esh3 = (SamyClass2017.ws_kst3 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh3; get_decm(); SamyClass2017.w_esh3 = ksr;

            SamyClass2017.w_nbs4 = (SamyClass2017.ws_kst4 * xw_nsb1);
            ksr = SamyClass2017.w_nbs4; get_decm(); SamyClass2017.w_nbs4 = ksr;
            SamyClass2017.w_esh4 = (SamyClass2017.ws_kst4 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh4; get_decm(); SamyClass2017.w_esh4 = ksr;

            SamyClass2017.w_nbs5 = (SamyClass2017.ws_kst5 * xw_nsb1);
            ksr = SamyClass2017.w_nbs5; get_decm(); SamyClass2017.w_nbs5 = ksr;
            SamyClass2017.w_esh5 = (SamyClass2017.ws_kst5 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh5; get_decm(); SamyClass2017.w_esh5 = ksr;



            SamyClass2017.w_nbs16 = (SamyClass2017.ws_kst16 * xw_nsb1);
            ksr = SamyClass2017.w_nbs16; get_decm(); SamyClass2017.w_nbs16 = ksr;
            SamyClass2017.w_esh16 = (SamyClass2017.ws_kst16 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh16; get_decm(); SamyClass2017.w_esh16 = ksr;

            SamyClass2017.w_nbs26 = (SamyClass2017.ws_kst26 * xw_nsb1);
            ksr = SamyClass2017.w_nbs26; get_decm(); SamyClass2017.w_nbs26 = ksr;
            SamyClass2017.w_esh26 = (SamyClass2017.ws_kst26 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh26; get_decm(); SamyClass2017.w_esh26 = ksr;

            SamyClass2017.w_nbs36 = (SamyClass2017.ws_kst36 * xw_nsb1);
            ksr = SamyClass2017.w_nbs36; get_decm(); SamyClass2017.w_nbs36 = ksr;
            SamyClass2017.w_esh36 = (SamyClass2017.ws_kst36 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh36; get_decm(); SamyClass2017.w_esh36 = ksr;

            SamyClass2017.w_nbs46 = (SamyClass2017.ws_kst46 * xw_nsb1);
            ksr = SamyClass2017.w_nbs46; get_decm(); SamyClass2017.w_nbs46 = ksr;
            SamyClass2017.w_esh46 = (SamyClass2017.ws_kst46 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh46; get_decm(); SamyClass2017.w_esh46 = ksr;

            SamyClass2017.w_nbs56 = (SamyClass2017.ws_kst56 * xw_nsb1);
            ksr = SamyClass2017.w_nbs56; get_decm(); SamyClass2017.w_nbs56 = ksr;
            SamyClass2017.w_esh56 = (SamyClass2017.ws_kst56 * xw_nsb1) / 2;
            ksr = SamyClass2017.w_esh56; get_decm(); SamyClass2017.w_esh56 = ksr;
        }
        public void get_decm()
        {
            Double xwall = ksr * 100; Double xwsml = ksr * 100;
            Decimal wksr = Convert.ToDecimal(xwsml);
            wksr = Decimal.Truncate(wksr);
            xwsml = Convert.ToDouble(wksr); if (xwall == xwsml) { return; }
            Double frk = (xwall - xwsml) * 10;
            Decimal wk = Convert.ToDecimal(frk); wk = Decimal.Truncate(wk);
            if (wk > 0) { ksr = (xwsml + 1) / 100; return; }
            if (wk == 0) { ksr = xwsml / 100; return; }
        }

        /// <summary>
        /// ////////////////////
        /// </summary>
		public void get_payed()
        {
            w_rkm = 0.0; w_shr = 1;
            SamyClass2017.w_dival = 1.00;
            if ((SamyClass2017.ws_cod != 5) & (SamyClass2017.ws_cod != 6) & (SamyClass2017.ws_cod != 7) & (SamyClass2017.ws_cod != 8) & (SamyClass2017.ws_cod != 9))
            { w_kstyer = w_kstyer + 7.50; }
            if (SamyClass2017.ws_cod == 12) { w_kstyer = w_kstyer - 7.50; }
            if (SamyClass2017.ws_cod == 13) { w_kstyer = w_kstyer - 7.50; }
            if (SamyClass2017.ws_cod == 14) { w_kstyer = w_kstyer - 7.50; }
            w_rkm = w_kstyer * SamyClass2017.w_dival / w_shr * zrat;
            w_rkm = Math.Round(w_rkm, 3);
            get_zft_rkm();
            SamyClass2017.ws_kst1 = w_rkm;
            get_omola_end();
            get_mov_omo1();
            SamyClass2017.w_dival = 1.02; w_shr = 2;
            w_rkm = w_kstyer * SamyClass2017.w_dival / w_shr * zrat;
            w_rkm = Math.Round(w_rkm, 3);
            get_zft_rkm();
            SamyClass2017.ws_kst2 = w_rkm;
            get_omola_end();
            get_mov_omo2();
            if (SamyClass2017.ws_cod == 7)
            {
                SamyClass2017.w_dival = 1.03; w_shr = 4;
            }
            else
            {
                SamyClass2017.w_dival = 1.03; w_shr = 4;
            }
            w_rkm = w_kstyer * SamyClass2017.w_dival / w_shr * zrat;
            w_rkm = Math.Round(w_rkm, 3);
            get_zft_rkm();
            SamyClass2017.ws_kst3 = w_rkm;
            get_omola_end();
            get_mov_omo3();
            if (SamyClass2017.ws_cod == 7)
            {
                SamyClass2017.w_dival = 1.04; w_shr = 12;
            }
            else
            {
                SamyClass2017.w_dival = 1.05; w_shr = 12;
            }
            w_rkm = w_kstyer * SamyClass2017.w_dival / w_shr * zrat;
            w_rkm = Math.Round(w_rkm, 3);
            get_zft_rkm();
            SamyClass2017.ws_kst4 = w_rkm;
            get_omola_end();
            get_mov_omo4();
        }
        public void get_zft_rkm()
        {
            zft = w_rkm;
            get_zft();
            w_rkm = zft;
            w_rkm = Math.Round(w_rkm, 2);
        }
        public void get_zft()
        {
            //zft = Math.Round(zft, 5);
            Decimal kkk = Convert.ToDecimal(zft); Decimal mmm = Convert.ToDecimal(zft);
            kkk = Decimal.Truncate(kkk); mmm = (mmm - kkk) * 100;

            Decimal ggg = mmm; mmm = Decimal.Truncate(mmm); ggg = (ggg - mmm) * 10;
            if (ggg == 5)
            {
                Double lll = Convert.ToDouble(0.001); zft = zft + lll;
            }

        }
        public void get_om_over()
        {
            //MessageBox.Show("sssssssssssssssssss111111111111ss");
            o_over = 0; o_kst1 = 0; o_kst2 = 0;
            o_kst1 =
                (w_kstyer - SamyClass2017.ws_pen - SamyClass2017.ws_dep - SamyClass2017.ws_acc - SamyClass2017.ws_hel - SamyClass2017.ws_pos) + SamyClass2017.adm1 + SamyClass2017.adm2;

            if (SamyClass2017.ws_cod == 1) { o_over = 0; return; }
            if (SamyClass2017.ws_cod == 12) { o_over = 0; return; }
            if (SamyClass2017.ws_cod == 13) { o_over = 0; return; }
            if (SamyClass2017.ws_cod == 14) { o_over = 0; return; }

            o_kst2 = Convert.ToDouble(SamyClass2017.ws_mab) * 5.00 / 100.00;
            if (o_kst1 >= o_kst2) { o_over = 1; }

            o_over = 0; o_kst1 = 0; o_kst2 = 0;
            o_kst1 = w_kstyer + SamyClass2017.adm1 + SamyClass2017.adm2;

        }
        public void get_omola_end()
        {
            //MessageBox.Show("ssssssssssssssssssss999999");
            if (SamyClass2017.ws_cod == 9) { SamyClass2017.w_60 = 65.00; }
            get_om_over();
            //ÇáÚãæáÇÊ					
            if (SamyClass2017.w_prod == 4)
            {
                SamyClass2017.w_omola0 = 0; SamyClass2017.w_omola1 = 0;
                SamyClass2017.w_omola2 = 0; SamyClass2017.w_omola3 = 0;
                SamyClass2017.w_omola4 = 0; SamyClass2017.w_omola5 = 0;
                SamyClass2017.w_omola_all = 0;
                SamyClass2017.n_om0 = 0; SamyClass2017.n_om1 = 0; SamyClass2017.n_om2 = 0;
                SamyClass2017.n_om3 = 0; SamyClass2017.n_om4 = 0; SamyClass2017.n_om5 = 0;
                SamyClass2017.w_omola_all = SamyClass2017.w_omola0 + SamyClass2017.w_omola1 + SamyClass2017.w_omola2
                    + SamyClass2017.w_omola3 + SamyClass2017.w_omola4 + SamyClass2017.w_omola5;
                get_om_tst();
                return;
            }
            g_shr();
            Double xxmon = Convert.ToDouble(w_month); w_kstyer = Math.Round(w_kstyer, 2);
            get_omo();
            if (o_over == 0)
            {
                if (w_kstyer22 == 0) { w_kstyer22 = w_kstyer; a7 = 0; }
                if (SamyClass2017.w_prod == 1)
                {
                    SamyClass2017.w_omolat = w_kstyer22 + a7;
                    //////SamyClass2017.w_omolat = (w_kstyer + SamyClass2017.adm1 + SamyClass2017.adm2) ;
                    SamyClass2017.w_omola1 = SamyClass2017.w_omolat * SamyClass2017.w_30 / 100;
                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 2);
                    omo = SamyClass2017.w_omola1 / xxmon;
                    omo = Math.Round(omo, 3);
                    SamyClass2017.n_om0 = SamyClass2017.w_30;
                    SamyClass2017.n_om1 = SamyClass2017.w_30;
                    SamyClass2017.w_omola2 = SamyClass2017.w_omolat * SamyClass2017.w_10 / 100;
                    SamyClass2017.n_om2 = SamyClass2017.w_10;
                    SamyClass2017.w_omola3 = SamyClass2017.w_omolat * SamyClass2017.w3 / 100;
                    SamyClass2017.n_om3 = SamyClass2017.w3;
                    if (SamyClass2017.ws_cod == 9)
                    {
                        SamyClass2017.w_omola3 = SamyClass2017.w_omolat * SamyClass2017.w_5 / 100;
                        SamyClass2017.n_om3 = SamyClass2017.w_5;
                    }
                    SamyClass2017.w_omola4 = SamyClass2017.w_omolat * SamyClass2017.w4 / 100;
                    SamyClass2017.n_om4 = SamyClass2017.w4;
                    SamyClass2017.w_omola5 = SamyClass2017.w_omolat * SamyClass2017.w5 / 100;
                    SamyClass2017.n_om5 = SamyClass2017.w5;
                    SamyClass2017.w_omola1 = SamyClass2017.w_omola1 / xxmon;
                    SamyClass2017.w_omola2 = SamyClass2017.w_omola2 / xxmon;
                    SamyClass2017.w_omola3 = SamyClass2017.w_omola3 / xxmon;
                    SamyClass2017.w_omola4 = SamyClass2017.w_omola4 / xxmon;
                    SamyClass2017.w_omola5 = SamyClass2017.w_omola5 / xxmon;

                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 4);
                    SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 4);
                    SamyClass2017.w_omola3 = Math.Round(SamyClass2017.w_omola3, 4);
                    SamyClass2017.w_omola4 = Math.Round(SamyClass2017.w_omola4, 4);
                    SamyClass2017.w_omola5 = Math.Round(SamyClass2017.w_omola5, 4);

                    get_zft_omo();

                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 2);
                    SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 2);
                    SamyClass2017.w_omola3 = Math.Round(SamyClass2017.w_omola3, 2);
                    SamyClass2017.w_omola4 = Math.Round(SamyClass2017.w_omola4, 2);
                    SamyClass2017.w_omola5 = Math.Round(SamyClass2017.w_omola5, 2);

                }
                if ((SamyClass2017.w_prod == 2) | (SamyClass2017.w_prod == 3))
                {
                    SamyClass2017.w_omolat = w_kstyer22 + a7;
                    /////////SamyClass2017.w_omolat = (w_kstyer + SamyClass2017.adm1 + SamyClass2017.adm2) ;
                    SamyClass2017.w_omola1 = SamyClass2017.w_omolat * SamyClass2017.w_60 / 100;
                    if (SamyClass2017.ws_cod == 8)
                    {
                        SamyClass2017.w_omola1 = (w_kstyer * SamyClass2017.w_60 / 100);
                    }
                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 2);
                    omo = SamyClass2017.w_omola1 / xxmon;
                    omo = Math.Round(omo, 3);
                    SamyClass2017.n_om0 = SamyClass2017.w_60;
                    SamyClass2017.n_om1 = SamyClass2017.w_60;
                    SamyClass2017.w_omola2 = SamyClass2017.w_omolat * SamyClass2017.w_10 / 100;
                    SamyClass2017.n_om2 = SamyClass2017.w_10;
                    SamyClass2017.w_omola3 = SamyClass2017.w_omolat * SamyClass2017.w3 / 100;
                    SamyClass2017.n_om3 = SamyClass2017.w3;
                    if (SamyClass2017.ws_cod == 9)
                    {
                        SamyClass2017.w_omola3 = SamyClass2017.w_omolat * SamyClass2017.w_5 / 100;
                        SamyClass2017.n_om3 = SamyClass2017.w_5;
                    }
                    SamyClass2017.w_omola4 = SamyClass2017.w_omolat * SamyClass2017.w4 / 100;
                    SamyClass2017.n_om4 = SamyClass2017.w4;
                    SamyClass2017.w_omola5 = SamyClass2017.w_omolat * SamyClass2017.w5 / 100;
                    SamyClass2017.n_om5 = SamyClass2017.w5;
                    SamyClass2017.w_omola1 = SamyClass2017.w_omola1 / xxmon;
                    SamyClass2017.w_omola2 = SamyClass2017.w_omola2 / xxmon;
                    SamyClass2017.w_omola3 = SamyClass2017.w_omola3 / xxmon;
                    SamyClass2017.w_omola4 = SamyClass2017.w_omola4 / xxmon;
                    SamyClass2017.w_omola5 = SamyClass2017.w_omola5 / xxmon;

                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 4);
                    SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 4);
                    SamyClass2017.w_omola3 = Math.Round(SamyClass2017.w_omola3, 4);
                    SamyClass2017.w_omola4 = Math.Round(SamyClass2017.w_omola4, 4);
                    SamyClass2017.w_omola5 = Math.Round(SamyClass2017.w_omola5, 4);

                    get_zft_omo();

                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 2);
                    SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 2);
                    SamyClass2017.w_omola3 = Math.Round(SamyClass2017.w_omola3, 2);
                    SamyClass2017.w_omola4 = Math.Round(SamyClass2017.w_omola4, 2);
                    SamyClass2017.w_omola5 = Math.Round(SamyClass2017.w_omola5, 2);
                }
            }
            if (o_over == 1)
            {
                if (SamyClass2017.w_prod == 1)
                {
                    SamyClass2017.w_omola1 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w_30 / 100);
                    omo = SamyClass2017.w_omola1 / xxmon;
                    SamyClass2017.n_om0 = SamyClass2017.w_30;
                    SamyClass2017.n_om1 = SamyClass2017.w_30;
                    SamyClass2017.w_omola1 = SamyClass2017.w_omola1 / xxmon;
                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 2);
                    SamyClass2017.w_omola2 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w_10 / 100);
                    SamyClass2017.n_om2 = SamyClass2017.w_10;
                    SamyClass2017.w_omola3 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w3 / 100);
                    SamyClass2017.n_om3 = SamyClass2017.w3;
                    if (SamyClass2017.ws_cod == 9)
                    {
                        SamyClass2017.w_omola3 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w_5 / 100);
                        SamyClass2017.n_om3 = SamyClass2017.w_5;
                    }
                    SamyClass2017.w_omola4 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w4 / 100);
                    SamyClass2017.n_om4 = SamyClass2017.w4;
                    SamyClass2017.w_omola5 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w5 / 100);
                    SamyClass2017.n_om5 = SamyClass2017.w5;
                    SamyClass2017.w_omola2 = SamyClass2017.w_omola2 / xxmon;
                    SamyClass2017.w_omola3 = SamyClass2017.w_omola3 / xxmon;
                    SamyClass2017.w_omola4 = SamyClass2017.w_omola4 / xxmon;
                    SamyClass2017.w_omola5 = SamyClass2017.w_omola5 / xxmon;

                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 4);
                    SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 4);
                    SamyClass2017.w_omola3 = Math.Round(SamyClass2017.w_omola3, 4);
                    SamyClass2017.w_omola4 = Math.Round(SamyClass2017.w_omola4, 4);
                    SamyClass2017.w_omola5 = Math.Round(SamyClass2017.w_omola5, 4);

                    get_zft_omo();

                    SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 2);
                    SamyClass2017.w_omola3 = Math.Round(SamyClass2017.w_omola3, 2);
                    SamyClass2017.w_omola4 = Math.Round(SamyClass2017.w_omola4, 2);
                    SamyClass2017.w_omola5 = Math.Round(SamyClass2017.w_omola5, 2);
                }
                if ((SamyClass2017.w_prod == 2) | (SamyClass2017.w_prod == 3))
                {
                    SamyClass2017.w_omola1 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w_60 / 100);
                    if (SamyClass2017.ws_cod == 8)
                    {
                        SamyClass2017.w_omola1 = (w_kstyer * SamyClass2017.w_60 / 100);
                    }
                    omo = SamyClass2017.w_omola1 / xxmon;
                    SamyClass2017.n_om0 = SamyClass2017.w_60;
                    SamyClass2017.n_om1 = SamyClass2017.w_60;
                    SamyClass2017.w_omola1 = SamyClass2017.w_omola1 / xxmon;
                    //MessageBox.Show("wwwwwwwwwwwwwwwwwwwwww");
                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 2);
                    SamyClass2017.w_omola2 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w_10 / 100);
                    SamyClass2017.n_om2 = SamyClass2017.w_10;
                    SamyClass2017.w_omola3 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w3 / 100);
                    SamyClass2017.n_om3 = SamyClass2017.w3;
                    //MessageBox.Show("wwwwwwwwwwwwwwwwwwwwww");
                    //if(SamyClass2017.ws_cod == 9)
                    //{
                    //    SamyClass2017.w_omola3 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w_5 / 100);
                    //    SamyClass2017.n_om3    = SamyClass2017.w_5;
                    //}
                    SamyClass2017.w_omola4 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w4 / 100);
                    SamyClass2017.n_om4 = SamyClass2017.w4;
                    SamyClass2017.w_omola5 = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w5 / 100);
                    SamyClass2017.n_om5 = SamyClass2017.w5;
                    SamyClass2017.w_omola2 = SamyClass2017.w_omola2 / xxmon;
                    SamyClass2017.w_omola3 = SamyClass2017.w_omola3 / xxmon;
                    SamyClass2017.w_omola4 = SamyClass2017.w_omola4 / xxmon;
                    SamyClass2017.w_omola5 = SamyClass2017.w_omola5 / xxmon;

                    SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 4);
                    SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 4);
                    SamyClass2017.w_omola3 = Math.Round(SamyClass2017.w_omola3, 4);
                    SamyClass2017.w_omola4 = Math.Round(SamyClass2017.w_omola4, 4);
                    SamyClass2017.w_omola5 = Math.Round(SamyClass2017.w_omola5, 4);

                    get_zft_omo();

                    SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 2);
                    SamyClass2017.w_omola3 = Math.Round(SamyClass2017.w_omola3, 2);
                    SamyClass2017.w_omola4 = Math.Round(SamyClass2017.w_omola4, 2);
                    SamyClass2017.w_omola5 = Math.Round(SamyClass2017.w_omola5, 2);
                }
            }
            if (w_shr == 5) { g_only(); }
            if (SamyClass2017.ww_payednow > 0)
            {
                SamyClass2017.w_omola0 = SamyClass2017.w_omola1 * (SamyClass2017.ww_payednow + 1);
            }
            else
            { SamyClass2017.w_omola0 = SamyClass2017.w_omola1; }
            SamyClass2017.w_omola0 = Math.Round(SamyClass2017.w_omola0, 2);
            SamyClass2017.w_omola1 = Math.Round(SamyClass2017.w_omola1, 2);
            SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 2);
            g_zero();
            if (w_shr == 5)
            {
                SamyClass2017.w_omola_all = SamyClass2017.w_omola0 + SamyClass2017.w_omola1
                    + SamyClass2017.w_omola2 + SamyClass2017.w_omola3
                    + SamyClass2017.w_omola4;
                SamyClass2017.wall = SamyClass2017.n_om1 + SamyClass2017.n_om2 + SamyClass2017.n_om3
                    + SamyClass2017.n_om4 + SamyClass2017.n_om5;
            }
            else
            { SamyClass2017.w_omola_all = 0; SamyClass2017.wall = 0; }
            if ((w_shr == 5) & (SamyClass2017.xmodasdd == 1))
            {
                SamyClass2017.w_omola2 = 0; SamyClass2017.w_omola3 = 0;
                SamyClass2017.w_omola4 = 0; SamyClass2017.w_omola5 = 0;
                SamyClass2017.n_om2 = 0; SamyClass2017.n_om3 = 0;
                SamyClass2017.n_om4 = 0; SamyClass2017.n_om5 = 0;
                SamyClass2017.w_omola_all = 0;
                SamyClass2017.wall = 0;
            }
            if (SamyClass2017.ww_payednow == 0)
            { SamyClass2017.w_omola0 = 0; SamyClass2017.n_om0 = 0; }
            SamyClass2017.w_omola_all = SamyClass2017.w_omola0 + SamyClass2017.w_omola1 + SamyClass2017.w_omola2
                + SamyClass2017.w_omola3 + SamyClass2017.w_omola4 + SamyClass2017.w_omola5;
            if (SamyClass2017.w_omola0 == 0)
            { SamyClass2017.w_omola0 = SamyClass2017.w_omola1; SamyClass2017.n_om0 = SamyClass2017.n_om1; }
            get_om_tst();
            if (f_e == 0)
            {
                get_kst_one();
                f_e = 1;
            }

            return;
        }
        public void g_only()
        {
            Double hop = 0;
            if (w_kst < 50) { hop = SamyClass2017.w_omolat; }
            else { hop = ((Convert.ToDouble(SamyClass2017.ws_mab) * 0.05) * SamyClass2017.w_30 / 100.00); }
            //MessageBox.Show("ÞÓØ æÍíÏ");
            Double w_o2 = 1.1, w_o3 = 1.1, w_o4 = 1.1, w_o5 = 1.1;
            w_o2 = Math.Pow(w_o2, 1); w_o3 = Math.Pow(w_o3, 2);
            w_o4 = Math.Pow(w_o4, 3); w_o5 = Math.Pow(w_o5, 4);
            w_o2 = Math.Round(w_o2, 5); w_o3 = Math.Round(w_o3, 5);
            w_o4 = Math.Round(w_o4, 5); w_o5 = Math.Round(w_o5, 5);
            SamyClass2017.w_omola2 = hop * (1 / w_o2) * SamyClass2017.w_10 / 100;
            SamyClass2017.w_omola3 = hop * (1 / w_o3) * SamyClass2017.w3 / 100;
            SamyClass2017.w_omola4 = hop * (1 / w_o4) * SamyClass2017.w4 / 100;
            SamyClass2017.w_omola5 = hop * (1 / w_o5) * SamyClass2017.w5 / 100;
            SamyClass2017.w_omola2 = Math.Round(SamyClass2017.w_omola2, 2);
            SamyClass2017.w_omola3 = Math.Round(SamyClass2017.w_omola3, 2);
            SamyClass2017.w_omola4 = Math.Round(SamyClass2017.w_omola4, 2);
            SamyClass2017.w_omola5 = Math.Round(SamyClass2017.w_omola5, 2);
            SamyClass2017.w_omola_all = SamyClass2017.w_omola0 + SamyClass2017.w_omola1
                + SamyClass2017.w_omola2 + SamyClass2017.w_omola3
                + SamyClass2017.w_omola4;
        }
        public void g_zero()
        {
            if (SamyClass2017.ws_cod == 8)
            {
                if (w_shr == 5)
                {
                    SamyClass2017.n_om2 = 0; SamyClass2017.w_omola2 = 0;/* t_omola2.Text = "0";*/
                    SamyClass2017.n_om3 = 0; SamyClass2017.w_omola3 = 0;/* t_omola3.Text = "0";*/
                    SamyClass2017.n_om4 = 0; SamyClass2017.w_omola4 = 0;/* t_omola4.Text = "0";*/
                    SamyClass2017.n_om5 = 0; SamyClass2017.w_omola5 = 0;/* t_omola5.Text = "0";*/
                }
            }
            if (SamyClass2017.ws_cod == 3)
            {
                if (w_shr == 5)
                {
                    SamyClass2017.n_om1 = SamyClass2017.n_om1 + SamyClass2017.n_om2;
                    SamyClass2017.w_omola1 = SamyClass2017.w_omola1 + SamyClass2017.w_omola2;
                    SamyClass2017.n_om2 = 0; SamyClass2017.w_omola2 = 0; /*t_omola2.Text = "0";*/
                    SamyClass2017.n_om3 = 0; SamyClass2017.w_omola3 = 0; /*t_omola3.Text = "0";*/
                    SamyClass2017.n_om4 = 0; SamyClass2017.w_omola4 = 0; /*t_omola4.Text = "0";*/
                    SamyClass2017.n_om5 = 0; SamyClass2017.w_omola5 = 0; /*t_omola5.Text = "0";*/
                }
            }
            if ((SamyClass2017.ws_cod != 3) & (SamyClass2017.ws_cod != 7))
            {
                SamyClass2017.w4 = 0; SamyClass2017.w_omola4 = 0; SamyClass2017.w5 = 0; SamyClass2017.w_omola5 = 0;
                //t_omola4.Text = "0";
            }
            if (SamyClass2017.xmodasdd < 5) { SamyClass2017.w5 = 0; SamyClass2017.w_omola5 = 0; }
            if (SamyClass2017.xmodasdd < 4)
            {
                SamyClass2017.w4 = 0; SamyClass2017.w_omola4 = 0; //t_omola4.Text = "0";
            }
            if (SamyClass2017.xmodasdd < 3)
            {
                SamyClass2017.w3 = 0; SamyClass2017.w_omola3 = 0; //t_omola3.Text = "0"; 
            }
            if (SamyClass2017.xmodasdd < 2)
            {
                SamyClass2017.n_om2 = 0; SamyClass2017.w_omola2 = 0; //t_omola2.Text = "0";
            }
            SamyClass2017.w_omola_all = SamyClass2017.w_omola0 + SamyClass2017.w_omola1
                + SamyClass2017.w_omola2 + SamyClass2017.w_omola3
                + SamyClass2017.w_omola4;
            SamyClass2017.wall = SamyClass2017.n_om1 + SamyClass2017.n_om2 + SamyClass2017.n_om3
                + SamyClass2017.n_om4 + SamyClass2017.n_om5;
        }
        public void get_omo()
        {
            SamyClass2017.w3 = 0; SamyClass2017.w4 = 0; SamyClass2017.w5 = 0;
            if (SamyClass2017.w_prod == 1) { SamyClass2017.w_30 = 30; SamyClass2017.w_10 = 10; SamyClass2017.w3 = 10; }
            else { SamyClass2017.w_30 = 0; SamyClass2017.w_60 = 60; SamyClass2017.w_10 = 10; SamyClass2017.w3 = 10; }
            if ((SamyClass2017.w_prod == 1) & (SamyClass2017.ws_cod == 3))
            { SamyClass2017.w_30 = 4; SamyClass2017.w_10 = 4; SamyClass2017.w3 = 4; SamyClass2017.w4 = 4; SamyClass2017.w5 = 4; }
            if ((SamyClass2017.w_prod != 1) & (SamyClass2017.ws_cod == 3))
            { SamyClass2017.w_60 = 4; SamyClass2017.w_10 = 4; SamyClass2017.w3 = 4; SamyClass2017.w4 = 4; SamyClass2017.w5 = 4; }
            if (SamyClass2017.ws_cod == 4)
            { SamyClass2017.w_60 = 20; SamyClass2017.w_30 = 20; SamyClass2017.w_10 = 10; SamyClass2017.w3 = 10; }
            if (SamyClass2017.ws_cod == 7)
            { SamyClass2017.w_60 = 65; SamyClass2017.w_30 = 35; SamyClass2017.w_10 = 13; SamyClass2017.w3 = 13; SamyClass2017.w4 = 4; SamyClass2017.w5 = 4; }
            if (SamyClass2017.ws_cod == 8)
            { SamyClass2017.w_60 = 5; SamyClass2017.w_30 = 5; SamyClass2017.w_10 = 5; SamyClass2017.w3 = 5; SamyClass2017.w4 = 5; SamyClass2017.w5 = 5; }
            if ((SamyClass2017.w_prod == 1) & (SamyClass2017.ws_cod == 15))
            { SamyClass2017.w_60 = 0; SamyClass2017.w_30 = 4; SamyClass2017.w_10 = 4; SamyClass2017.w3 = 4; SamyClass2017.w4 = 4; SamyClass2017.w5 = 4; }
            if ((SamyClass2017.w_prod != 1) & (SamyClass2017.ws_cod == 15))
            { SamyClass2017.w_60 = 5; SamyClass2017.w_30 = 0; SamyClass2017.w_10 = 5; SamyClass2017.w3 = 5; SamyClass2017.w4 = 5; SamyClass2017.w5 = 5; }

            if (SamyClass2017.ws_cod == 9)
            {
                if (SamyClass2017.w_prod == 1)
                {
                    SamyClass2017.w_60 = 32.50; SamyClass2017.w_30 = 32.50; SamyClass2017.w_10 = 10.00;
                    SamyClass2017.w3 = 5.00; SamyClass2017.w4 = 0; SamyClass2017.w5 = 0;
                }
                if (SamyClass2017.w_prod > 1)
                {
                    SamyClass2017.w_60 = 65.00; SamyClass2017.w_30 = 65.50; SamyClass2017.w_10 = 10.00;
                    SamyClass2017.w3 = 5.00; SamyClass2017.w4 = 0; SamyClass2017.w5 = 0;
                }
            }
        }



        public void get_zft_omo()
        {
            zft = SamyClass2017.w_omola1; get_zft(); SamyClass2017.w_omola1 = zft;
            zft = SamyClass2017.w_omola2; get_zft(); SamyClass2017.w_omola2 = zft;
            zft = SamyClass2017.w_omola3; get_zft(); SamyClass2017.w_omola3 = zft;
            zft = SamyClass2017.w_omola4; get_zft(); SamyClass2017.w_omola4 = zft;
            zft = SamyClass2017.w_omola5; get_zft(); SamyClass2017.w_omola5 = zft;
        }
        public void get_om_tst()
        {
            if (SamyClass2017.w_omola5 != 0)
            {
                if (SamyClass2017.w_omola4 == 0)
                { //MessageBox.Show("ÑÇÌÜÜÜÜÜÜÜÚ ÇáÚãæáÜÜÜå");
                    return;
                }
            }
            if (SamyClass2017.w_omola4 != 0)
            {
                if (SamyClass2017.w_omola3 == 0)
                {// MessageBox.Show("ÑÇÌÜÜÜÜÜÜÜÚ ÇáÚãæáÜÜÜå");
                    return;
                }
            }
            if (SamyClass2017.w_omola3 != 0)
            {
                if (SamyClass2017.w_omola2 == 0)
                {

                    //MessageBox.Show("ÑÇÌÜÜÜÜÜÜÜÚ ÇáÚãæáÜÜÜå");

                    return;
                }
            }
            if (SamyClass2017.w_omola2 != 0)
            {
                if (SamyClass2017.w_omola1 == 0)
                {
                    //MessageBox.Show("ÑÇÌÜÜÜÜÜÜÜÚ ÇáÚãæáÜÜÜå"); 
                    return;
                }
            }
        }
        public void get_mov_omo1()
        {
            SamyClass2017.o_o1 = SamyClass2017.w_omola1; SamyClass2017.o_o2 = SamyClass2017.w_omola2;
            SamyClass2017.o_o3 = SamyClass2017.w_omola3; SamyClass2017.o_o4 = SamyClass2017.w_omola4;
            SamyClass2017.o_o5 = SamyClass2017.w_omola5; SamyClass2017.o_oz = SamyClass2017.w_omola_all;
        }
        public void get_mov_omo2()
        {
            SamyClass2017.o_o11 = SamyClass2017.w_omola1; SamyClass2017.o_o22 = SamyClass2017.w_omola2;
            SamyClass2017.o_o33 = SamyClass2017.w_omola3; SamyClass2017.o_o44 = SamyClass2017.w_omola4;
            SamyClass2017.o_o55 = SamyClass2017.w_omola5; SamyClass2017.o_ozz = SamyClass2017.w_omola_all;
        }
        public void get_mov_omo3()
        {
            SamyClass2017.o_o111 = SamyClass2017.w_omola1; SamyClass2017.o_o222 = SamyClass2017.w_omola2;
            SamyClass2017.o_o333 = SamyClass2017.w_omola3; SamyClass2017.o_o444 = SamyClass2017.w_omola4;
            SamyClass2017.o_o555 = SamyClass2017.w_omola5; SamyClass2017.o_ozzz = SamyClass2017.w_omola_all;
        }
        public void get_mov_omo4()
        {
            SamyClass2017.o_o1111 = SamyClass2017.w_omola1; SamyClass2017.o_o2222 = SamyClass2017.w_omola2;
            SamyClass2017.o_o3333 = SamyClass2017.w_omola3; SamyClass2017.o_o4444 = SamyClass2017.w_omola4;
            SamyClass2017.o_o5555 = SamyClass2017.w_omola5; SamyClass2017.o_ozzzz = SamyClass2017.w_omola_all;
        }
        public void get_infc_calc2()
        {
            //ÍÓÇÈ ÇáÊÚÑíÝå æÇáÞÓØ ÇáÓäæì ÇáãÄÌá ÇáÏÝÚ
            w_kstyer = 0; w_kstyer_all = 0;
            w_kstyer22 = 0; w_kstyer_all22 = 0;
            a1000 = Math.Pow((1 / 1.04), SamyClass2017.ws_inspriod) * 1000;
            a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1; axx = a1000 / a100;
            Double v3 = Convert.ToDouble(300), vm = Convert.ToDouble(SamyClass2017.ws_inspriod), vd = 0;
            vd = (1 - (vm / v3)); gxx = (axx + 2) / vd;
            w_kst = gxx;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            ww_ttt = w_kst; w_prem = ww_ttt;
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
        }
        //public void get_kstnew()
        //{			
        //    zrat = 1;
        //    nz = 0 ; dz = 0; nz1 = 0 ; dz1 = 0;nz2 = 0 ; dz2 = 0;nz3 = 0 ; dz3 = 0;
        //    zsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod;get_infc_kstnew();
        //    nz1 = nz; dz1 = dz;
        //    zsen = SamyClass2017.ws_sen1;get_infc_kstnew();
        //    nz2 = nz; dz2 = dz;
        //    zsen = SamyClass2017.ws_sen1 + SamyClass2017.xmodasdd;get_infc_kstnew();
        //    nz3 = nz; dz3 = dz;
        //    Double ra = 0 , rb = 0;
        //    ra = ((nz2 - nz1)/ dz2);rb = ((nz2 - nz3)/ dz2);
        //    ra = Math.Round(ra,3);rb = Math.Round(rb,3);
        //    zrat = ra / rb;
        //    zrat = Math.Round(zrat,5);
        //    //MessageBox.Show(Convert.ToString(zrat));
        //}
        public void get_infc_kstnew()
        {
            onlykst = 1;
            nz = 0; dz = 0;

            if (xsen < 20) { xxsen = 20; } else { xxsen = xsen; }
            if ((SamyClass2017.ws_cod == 1) | (SamyClass2017.ws_cod == 2) | (SamyClass2017.ws_cod == 4) | (SamyClass2017.ws_cod == 11)) { xxno = 1; xxyer = 1924; }
            if ((SamyClass2017.ws_cod == 12) | (SamyClass2017.ws_cod == 13) | (SamyClass2017.ws_cod == 14) | (SamyClass2017.ws_cod == 15)) { xxno = 7; xxyer = 1949; }
            if (SamyClass2017.ws_cod == 5) { xxno = 5; xxyer = 1949; }
            if (SamyClass2017.ws_cod == 6) { xxno = 6; xxyer = 1924; }
            if ((SamyClass2017.ws_cod == 3) | (SamyClass2017.ws_cod == 7)) { xxno = 7; xxyer = 1949; }
            if (SamyClass2017.ws_cod == 8) { xxno = 88; xxyer = 1949; }
            if ((SamyClass2017.ws_cod == 3) & (onlykst == 1)) { xxno = 11; xxyer = 1924; }

            //MessageBox.Show(Convert.ToString(onlykst));
            SamyClass2017.mx = 0; SamyClass2017.nx = 0; SamyClass2017.dx = 0; SamyClass2017.rx = 0; SamyClass2017.sx = 0;
            SamyClass2017.para1 = xxno;
            SamyClass2017.para2 = xxyer;
            SamyClass2017.para3 = xxsen;
            para(SamyClass2017.para1, SamyClass2017.para2, SamyClass2017.para3);



        }
        public void get_tst3()
        {
            if (SamyClass2017.ws_mab < 5000)
            {
                //MessageBox.Show("áÇÊÕÏÑ ÈãÈáÛ ÊÃãíä ÇÞá ãä 5000 ÌäíåÇ");
                SamyClass2017.z_tsts = 1; return;
            }
            if (SamyClass2017.ws_mab < 100000) { SamyClass2017.z_adds = 1; }
            if ((SamyClass2017.ws_mab >= 100000) & (SamyClass2017.ws_mab < 500000))
            { SamyClass2017.z_adds = 0.0; }
            if (SamyClass2017.ws_mab >= 500000) { SamyClass2017.z_deds = 1; }
        }
        public void get_infc_rkm3new()
        {
            //MessageBox.Show("ÌÏíÏ");
            a1000 = (1000 * ((SamyClass2017.mx1 - SamyClass2017.mx2) / (SamyClass2017.nx1 - SamyClass2017.nx2)) + 1);
            Double a100 = 0.83; gxx = (a1000 / a100);
            w_kst = gxx; get_zft_omo_kst(); w_kst = Math.Round(w_kst, 2);
            if (SamyClass2017.ws_sen2 > 0)
            {
                w_prem = w_kst; w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00; flag_dep = 1; return;
            }
            else
            {
                ww_ttt = w_kst; w_prem = w_kst;
                if ((SamyClass2017.ws_cod == 1) | (SamyClass2017.ws_cod == 5))
                {
                    if (w_tr == 1)
                    {
                        if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                        { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
                        if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
                    }
                }
                if (SamyClass2017.ws_cod == 3)
                {
                    if (SamyClass2017.ws_mab < 100000) { w_prem = w_kst + 1; ww_ttt = w_kst + 1; }
                    if (w_tr == 1)
                    {
                        if (SamyClass2017.ws_mab >= 500000) { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
                    }
                }
                w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00; flag_dep = 0;
            }
            SamyClass2017.ws_sen2 = 0;
        }
        public void get_infc_rkm3()
        {
            //MessageBox.Show("ÞÏíã");
            a1000 = ((SamyClass2017.mx1 - SamyClass2017.mx2) * 1000 / SamyClass2017.dx1); Double a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1;
            gxx = (a1000 / a100); gxx = (gxx + 2.0) / 0.90; w_kst = gxx;
            w_kst = gxx; get_zft_omo_kst(); w_kst = Math.Round(w_kst, 2);
            if (SamyClass2017.ws_sen2 > 0)
            {
                w_prem = w_kst; w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                flag_dep = 1; return;
            }
            else
            {
                ww_ttt = w_kst; w_prem = w_kst;
                if ((SamyClass2017.ws_cod == 1) | (SamyClass2017.ws_cod == 5))
                {
                    if (w_tr == 1)
                    {
                        if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                        { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
                        if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
                    }
                }
                if (SamyClass2017.ws_cod == 3)
                {
                    if (SamyClass2017.ws_mab < 100000) { w_prem = w_kst + 1; ww_ttt = w_kst + 1; }
                    if (w_tr == 1)
                    {
                        if (SamyClass2017.ws_mab >= 500000) { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
                    }
                }
                w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
                w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00; flag_dep = 0;
            }
            SamyClass2017.ws_sen2 = 0;
        }
        public void get_infc_rkm4()
        {
            a1000 = SamyClass2017.mx1 / SamyClass2017.nx1 * 1000; Double xsx = 0.90; gxx = (a1000 + 2) / xsx; rkm = gxx;
            w_kst = gxx; get_zft_omo_kst(); w_kst = Math.Round(w_kst, 2);
            rkm = w_kst; ww_ttt = rkm;
        }
        public void get_ksts()
        {
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            w_kstyer22 = w_kst * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            w_kstyer22 = Math.Round(w_kstyer22, 0);
        }
        public void get_ins_5()
        {
            if (SamyClass2017.ws_sen1 > SamyClass2017.ws_sen2)
            {
                frk = SamyClass2017.ws_sen1 - SamyClass2017.ws_sen2; get_frk();
                SamyClass2017.ws_sendiv = SamyClass2017.ws_sen2 + wfrk;
            }
            if (SamyClass2017.ws_sen1 < SamyClass2017.ws_sen2)
            {
                frk = SamyClass2017.ws_sen2 - SamyClass2017.ws_sen1; get_frk();
                SamyClass2017.ws_sendiv = SamyClass2017.ws_sen1 + wfrk;
            }
            if (SamyClass2017.ws_sen1 == SamyClass2017.ws_sen2) { SamyClass2017.ws_sendiv = SamyClass2017.ws_sen1; }
        }
        public void get_infc_calc()
        {
            //ÍÓÇÈ ÇáÊÚÑíÝå æÇáÞÓØ ÇáÓäæì
            w_kstyer = 0; w_kstyer_all = 0; w_kstyer22 = 0; w_kstyer_all22 = 0;
            a1000 = (SamyClass2017.mx1 - SamyClass2017.mx2 + SamyClass2017.dx2) / SamyClass2017.dx1 * 1000; a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1;
            axx = a1000 / a100; gxx = (axx + 3) / (0.97 - (1 / a100));
            if (gxx >= 50) { gxx = (axx + 3 + (50 / a100)) / 0.97; }
            if (gxx < 0) { gxx = (axx + 3 + (50 / a100)) / 0.97; }
            w_kst = gxx; get_zft_omo_kst(); w_kst = Math.Round(w_kst, 2);
            ww_ttt = w_kst; w_prem = ww_ttt; w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
        }
        public void get_infc_rkm5()
        {
            get_zft_omo_kst(); w_kst = Math.Round(w_kst, 2); ww_ttt = w_kst; w_prem = w_kst;
            if (w_tr == 1)
            {
                if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
            }
            if (w_tr == 1)
            { if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; } }
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00; flag_dep = 0;
        }


        public void get_infc_calc6()
        {
            Double ia = 0, v200 = 0;
            //ÍÓÇÈ ÇáÊÚÑíÝå æÇáÞÓØ ÇáÓäæì ÇáãåäÏÓ
            w_kstyer = 0; w_kstyer_all = 0;
            w_kstyer22 = 0; w_kstyer_all22 = 0;
            a1000 = Math.Pow((1 / 1.0425), SamyClass2017.ws_inspriod) * 1000;
            a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1;
            b1000 = 1000 * ((SamyClass2017.mx1 - SamyClass2017.mx2 + SamyClass2017.dx2) / SamyClass2017.dx1);
            b100 = ((1 - Math.Pow((1 / 1.0425), SamyClass2017.ws_inspriod)) / 0.0425) * (1.0425);
            v200 = Convert.ToDouble(200);
            axx = (a1000 + b1000 + (v200 * (b100 - a100))) / a100;
            ia = (SamyClass2017.rx1 - SamyClass2017.rx2 - (SamyClass2017.ws_inspriod * SamyClass2017.mx2)) / SamyClass2017.dx1;
            gxx = (axx + (100.00 / a100) + 4.00) / (0.97 - (ia / a100));
            w_kst = gxx;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            if (w_kst < 100)
            { gxx = (axx + 4.00) / (0.97 - (ia / a100) - (1.1 / a100)); }
            w_kst = gxx;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);

            ww_ttt = w_kst; w_prem = ww_ttt;
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 2000.00;
            w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 2000.00;
            sam_ksr = w_kstyer; get_ksr(); w_kstyer = sam_ksr;
            sam_ksr = w_kstyer22; get_ksr(); w_kstyer22 = sam_ksr;
        }
        public void get_ksr()
        {
            Double xwall = sam_ksr * 100; Double xwsml = sam_ksr * 100;
            Decimal wksr = Convert.ToDecimal(xwsml);
            wksr = Decimal.Truncate(wksr); xwsml = Convert.ToDouble(wksr);
            if (xwall == xwsml) { return; }
            Double frk = (xwall - xwsml) * 10; Decimal wk = Convert.ToDecimal(frk);
            wk = Decimal.Truncate(wk);
            if (wk > 0) { sam_ksr = (xwsml + 1) / 100; return; }
            if (wk == 0) { sam_ksr = xwsml / 100; return; }
        }
        public void get_infc_calc7()
        {
            SamyClass2017.z_auts = 1.1; w_sahb = 0;
            //ÍÓÇÈ ÇáÊÚÑíÝå æÇáÞÓØ ÇáÓäæì
            Double dxx1 = 0.0, nx6 = 0.0, x200 = 0.0, x55x = 0.0, x35x = 0.0;
            Double xlop = 0.0, xlop2 = 0.0, xlop3 = 0.0, x77x = 0.0;
            Double ia1000 = 0.0, ggx = 0.0, xrkx = 0.0, ggz = 0.0, x97x = 0.0;
            Double xsxx = 0.0, xsa = 0.0;
            nx6 = 0; SamyClass2017.nx = 0; xsen = SamyClass2017.ws_sen1 + 6; get_infc8();
            nx6 = SamyClass2017.nx; get_x(); w_kstyer = 0; w_kstyer_all = 0;
            w_kstyer22 = 0; w_kstyer_all22 = 0;
            a1000 = (SamyClass2017.mx1 - SamyClass2017.mx3 + SamyClass2017.dx3) / SamyClass2017.dx1 * 1000;
            int moda7 = SamyClass2017.ws_inspriod;
            Double xsven = 0.0;
            if (SamyClass2017.ws_inspriod < 11)
            { xsven = ((SamyClass2017.rx2 - SamyClass2017.rx3 - ((moda7 - 1) * SamyClass2017.mx3) + (moda7 * SamyClass2017.dx3)) / SamyClass2017.dx1); }
            else
            { xsven = ((SamyClass2017.rx2 - SamyClass2017.rx3 - ((moda7 - 1) * SamyClass2017.mx3)) / SamyClass2017.dx1); }
            x77x = 200 * xsven;
            x35x = (0.0035 * ((SamyClass2017.nx1 - SamyClass2017.nx3) / SamyClass2017.dx1)) * ((1000 + (1000 + (200 * moda7))) / 2);
            x200 = 200 * moda7 * (SamyClass2017.dx3 / SamyClass2017.dx1);
            x55x = 5.5 * ((SamyClass2017.nx2 - nx6) / SamyClass2017.dx1);
            Double nx66 = nx6; Double nx22 = SamyClass2017.nx2; Double dx11 = SamyClass2017.dx1;
            ia1000 = ((SamyClass2017.rx1 - SamyClass2017.rx3 - (moda7 * SamyClass2017.mx3) + (moda7 * SamyClass2017.dx3)) / SamyClass2017.dx1) * 1000;
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod;
            SamyClass2017.mx3 = 0; SamyClass2017.nx3 = 0; SamyClass2017.dx3 = 0; SamyClass2017.rx3 = 0; SamyClass2017.sx3 = 0; get_infc8();
            SamyClass2017.mx3 = SamyClass2017.mx; SamyClass2017.nx3 = SamyClass2017.nx; SamyClass2017.dx3 = SamyClass2017.dx;
            SamyClass2017.rx3 = SamyClass2017.rx; SamyClass2017.sx3 = SamyClass2017.sx;
            xlop2 = (moda7 - 1) * SamyClass2017.rx3;
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod;
            SamyClass2017.mx3 = 0; SamyClass2017.nx3 = 0; SamyClass2017.dx3 = 0; SamyClass2017.rx3 = 0; SamyClass2017.sx3 = 0; get_infc8();
            SamyClass2017.mx3 = SamyClass2017.mx; SamyClass2017.nx3 = SamyClass2017.nx; SamyClass2017.dx3 = SamyClass2017.dx; SamyClass2017.rx3 = SamyClass2017.rx; SamyClass2017.sx3 = SamyClass2017.sx;
            xlop3 = (SamyClass2017.dx3 - SamyClass2017.mx3) * ((moda7 * (moda7 - 1)) / 2); get_x2();
            x97x = 0.97 * ((SamyClass2017.nx1 - SamyClass2017.nx3) / SamyClass2017.dx1); get_x2();
            if (SamyClass2017.ws_inspriod < 11)
            { xsxx = 0.097 * ((SamyClass2017.sx2 - SamyClass2017.sx3 - ((moda7 - 1) * SamyClass2017.nx3)) / SamyClass2017.dx1); }
            else
            { xsxx = 0.097 * ((SamyClass2017.sx2 - SamyClass2017.sx3 - ((moda7 - 3) * SamyClass2017.nx3)) / SamyClass2017.dx1); }
            int aa = SamyClass2017.ws_sen1 + 1; int bb = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod - 1;
            dxx1 = SamyClass2017.dx1;
            while (aa <= bb) { SamyClass2017.rx = 0; xsen = aa; get_infc8(); xlop = xlop + SamyClass2017.rx; aa = aa + 1; }
            xrkx = (ia1000 + (200 * ((xlop - xlop2 + xlop3) / dxx1))) / 100;
            if (SamyClass2017.ws_inspriod > 10)
            { ggx = (a1000 + x77x + x200 + x35x + xrkx + 55 + x55x); ggz = x97x + xsxx; gxx = ggx / ggz; }
            else
            {
                ggx = (a1000 + x77x + x35x + xrkx + 55 + x55x);
                if (SamyClass2017.ws_inspriod > 10)
                { xsa = 1.10 - (0.11 * ((nx22 - nx66) / dx11)); ggz = x97x + xsxx - xsa; gxx = ggx / ggz; }
                else { xsa = x97x + xsxx; gxx = ggx / xsa; }
            }
            w_kst = gxx;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);

            w_prem = w_kst; ww_ttt = w_kst; get_sub_rsm(); w_prem = w_prem - w_sub;
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            w_kstyer22 = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
        }
        public void get_sahb()
        {
            w_sahb = (SamyClass2017.ws_mab * 1.10);
            if (w_sahb != 0)
            {
                w_sahb = w_sahb / 1000.00;
            }
            w_kstyer = w_kstyer + w_sahb;
            w_kstyer22 = w_kstyer22 + w_sahb;
            w_kstyer = Math.Round(w_kstyer, 2);
            w_kstyer22 = Math.Round(w_kstyer22, 2);
        }
        public void get_infc8()
        {

            SamyClass2017.mx = 0; SamyClass2017.nx = 0; SamyClass2017.dx = 0; SamyClass2017.rx = 0; SamyClass2017.sx = 0;
            SamyClass2017.para1 = ww_id;
            SamyClass2017.para2 = 1949;
            SamyClass2017.para3 = xsen;
            para(SamyClass2017.para1, SamyClass2017.para2, SamyClass2017.para3);


        }
        public void get_x()
        {
            SamyClass2017.mx1 = 0; SamyClass2017.nx1 = 0; SamyClass2017.dx1 = 0; SamyClass2017.rx1 = 0; SamyClass2017.sx1 = 0;
            xsen = SamyClass2017.ws_sen1; get_infc8();
            SamyClass2017.mx1 = SamyClass2017.mx; SamyClass2017.nx1 = SamyClass2017.nx; SamyClass2017.dx1 = SamyClass2017.dx; SamyClass2017.rx1 = SamyClass2017.rx; SamyClass2017.sx1 = SamyClass2017.sx;
            SamyClass2017.mx2 = 0; SamyClass2017.nx2 = 0; SamyClass2017.dx2 = 0; SamyClass2017.rx2 = 0; SamyClass2017.sx2 = 0;
            xsen = SamyClass2017.ws_sen1 + 1; get_infc8();
            SamyClass2017.mx2 = SamyClass2017.mx; SamyClass2017.nx2 = SamyClass2017.nx; SamyClass2017.dx2 = SamyClass2017.dx; SamyClass2017.rx2 = SamyClass2017.rx; SamyClass2017.sx2 = SamyClass2017.sx;
            SamyClass2017.mx3 = 0; SamyClass2017.nx3 = 0; SamyClass2017.dx3 = 0; SamyClass2017.rx3 = 0; SamyClass2017.sx3 = 0;
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod; get_infc8();
            SamyClass2017.mx3 = SamyClass2017.mx; SamyClass2017.nx3 = SamyClass2017.nx; SamyClass2017.dx3 = SamyClass2017.dx; SamyClass2017.rx3 = SamyClass2017.rx; SamyClass2017.sx3 = SamyClass2017.sx;
        }
        public void get_x2()
        {
            SamyClass2017.mx1 = 0; SamyClass2017.nx1 = 0; SamyClass2017.dx1 = 0; SamyClass2017.rx1 = 0; SamyClass2017.sx1 = 0;
            xsen = SamyClass2017.ws_sen1; get_infc8();
            SamyClass2017.mx1 = SamyClass2017.mx; SamyClass2017.nx1 = SamyClass2017.nx; SamyClass2017.dx1 = SamyClass2017.dx; SamyClass2017.rx1 = SamyClass2017.rx; SamyClass2017.sx1 = SamyClass2017.sx;
            SamyClass2017.mx2 = 0; SamyClass2017.nx2 = 0; SamyClass2017.dx2 = 0; SamyClass2017.rx2 = 0; SamyClass2017.sx2 = 0;
            xsen = SamyClass2017.ws_sen1 + 1; get_infc8();
            SamyClass2017.mx2 = SamyClass2017.mx; SamyClass2017.nx2 = SamyClass2017.nx; SamyClass2017.dx2 = SamyClass2017.dx; SamyClass2017.rx2 = SamyClass2017.rx; SamyClass2017.sx2 = SamyClass2017.sx;
            SamyClass2017.mx3 = 0; SamyClass2017.nx3 = 0; SamyClass2017.dx3 = 0; SamyClass2017.rx3 = 0; SamyClass2017.sx3 = 0;
            if (SamyClass2017.ws_inspriod < 11)
            { xsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod; }
            else
            { xsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod - 2; }
            get_infc8();
            SamyClass2017.mx3 = SamyClass2017.mx; SamyClass2017.nx3 = SamyClass2017.nx; SamyClass2017.dx3 = SamyClass2017.dx; SamyClass2017.rx3 = SamyClass2017.rx; SamyClass2017.sx3 = SamyClass2017.sx;
        }
        public void get_sub_rsm()
        {
            w_sub = 0;
            if ((SamyClass2017.ws_mab >= 1000) & (SamyClass2017.ws_mab < 3000)) { w_sub = 1; }
            if ((SamyClass2017.ws_mab >= 3000) & (SamyClass2017.ws_mab < 5000)) { w_sub = 2; }
            if (SamyClass2017.ws_mab >= 5000) { w_sub = 3; }
        }
        public void get_ins_8()
        {
            SamyClass2017.mx1 = 0; SamyClass2017.nx1 = 0; SamyClass2017.dx1 = 0; SamyClass2017.rx1 = 0; SamyClass2017.sx1 = 0;
            xsen = SamyClass2017.ws_sen1; get_infc(); get_infc_mov1();
            SamyClass2017.mx2 = 0; SamyClass2017.nx2 = 0; SamyClass2017.dx2 = 0; SamyClass2017.rx2 = 0; SamyClass2017.sx2 = 0;
            xsen = SamyClass2017.ws_sen1 + 1; get_infc(); get_infc_mov2();
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod + 1;
            SamyClass2017.mx3 = 0; SamyClass2017.nx3 = 0; SamyClass2017.dx3 = 0; SamyClass2017.rx3 = 0; SamyClass2017.sx3 = 0;
            get_infc();
            get_infc_mov3();
        }
        public void get_infc_calc8()
        {
            get_dof_data();
            rkm = 0;
            Double a0 = 0.0, b0 = 0.0;
            Double xmoda = Convert.ToDouble(SamyClass2017.ws_inspriod);
            a0 = 1000.00 / SamyClass2017.ws_inspriod;
            b0 = (SamyClass2017.ws_inspriod * SamyClass2017.mx1) - SamyClass2017.rx2 + SamyClass2017.rx3;
            a1000 = a0 * b0 / SamyClass2017.dx1; a100 = a1000 / 0.80;
            rkm = a100;
            w_kst = rkm;
            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            rkm = w_kst;
            w_prem = rkm; w_rkm = rkm;
            zz_ded = 0; zz_ded22 = 0;
            zz_ded = rkm * dedprem / 100;
            zz_ded = Math.Round(zz_ded, 2);
            zz_ded22 = w_prem - zz_ded;
            zz_ded22 = zz_ded22 * dedprem22 / 100;
            zz_ded22 = Math.Round(zz_ded22, 2);
            ww_ttt = zz_ded + zz_ded22;
            w_prem = w_prem - ww_ttt;
            //ÊÞÑíÈ ÞÓØ ÇáãÊäÇÞÕ			
            sam_ksr = w_prem; get_ksr(); w_prem = sam_ksr;
            if (ww_ttt == 0.0) { ww_ttt = w_prem; }
            w_kst = w_rkm;
            w_kstyer = w_prem * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00;
            w_kstyer = Math.Round(w_kstyer, 2);
        }
        public void get_dof_data()
        {
            // if (com_den.Text.Trim() == "")
            //{ com_den.Select(0, 10); com_den.Focus(); return; }
            //SamyClass2017.ws_dentyp = Convert.ToInt32(com_den.SelectedIndex) + 1;
            int mam = SamyClass2017.ws_dentyp;
            if (mam == 4) { mam = 12; dedprem = 5; dedprem22 = 0; }
            else if (mam == 3) { mam = 04; dedprem = 4; dedprem22 = 0; }
            else if (mam == 2) { mam = 06; dedprem = 3; dedprem22 = 0; }
            else if (mam == 1) { mam = 01; dedprem = 0; dedprem22 = 0; }
            else if (mam == 8) { mam = 12; dedprem = 5; dedprem22 = 5; }
            else if (mam == 7) { mam = 04; dedprem = 5; dedprem22 = 4; }
            else if (mam == 6) { mam = 06; dedprem = 5; dedprem22 = 3; }
            else if (mam == 5) { mam = 01; dedprem = 5; dedprem22 = 0; }

            else if (mam == 12) { mam = 12; dedprem = 5; dedprem22 = 0; }
            else if (mam == 11) { mam = 04; dedprem = 4; dedprem22 = 0; }
            else if (mam == 10) { mam = 06; dedprem = 3; dedprem22 = 0; }
            else if (mam == 9) { mam = 01; dedprem = 0; dedprem22 = 0; }

            else if (mam == 16) { mam = 12; dedprem = 5; dedprem22 = 5; }
            else if (mam == 15) { mam = 04; dedprem = 5; dedprem22 = 4; }
            else if (mam == 14) { mam = 06; dedprem = 5; dedprem22 = 3; }
            else if (mam == 13) { mam = 01; dedprem = 5; dedprem22 = 0; }
            Double nor = 0.0;
            nor = Convert.ToDouble(mam) * Convert.ToDouble(SamyClass2017.ws_inspriod);
            nor = Convert.ToDouble(SamyClass2017.ws_mab) / nor;
            if (SamyClass2017.ws_dentyp > 8) { nor = 0; }
            SamyClass2017.ws_denkst = nor;
            sam_ksr = SamyClass2017.ws_denkst; sam_ksr = SamyClass2017.ws_denkst;
            get_ksr10(); SamyClass2017.ws_denkst = sam_ksr;
            //t_den.Text = Convert.ToString(SamyClass2017.ws_denkst);
            get_denend();
        }
        public void get_denend()
        {
            int mam = SamyClass2017.ws_dentyp;
            zz_dendat = SamyClass2017.datnul;
            int zz_month = 0, uy = 0, um = 0, ud = 0;
            if ((mam == 1) | (mam == 5) | (mam == 9) | (mam == 13)) { zz_month = 12; }
            if ((mam == 2) | (mam == 6) | (mam == 10) | (mam == 14)) { zz_month = 06; }
            if ((mam == 3) | (mam == 7) | (mam == 11) | (mam == 15)) { zz_month = 03; }
            if ((mam == 4) | (mam == 8) | (mam == 12) | (mam == 16)) { zz_month = 01; }
            uy = SamyClass2017.ws_endd.Year;
            um = SamyClass2017.ws_endd.Month;
            ud = SamyClass2017.ws_endd.Day;
            while (um <= zz_month) { uy = uy - 12; um = um + 12; }
            um = um - zz_month;
            zz_dendat = new DateTime(uy, um, ud);
        }
        public void get_ksr10()
        {
            Double xwall = sam_ksr; Double xwsml = sam_ksr;
            Decimal wksr = Convert.ToDecimal(xwsml);
            wksr = Decimal.Truncate(wksr);
            xwsml = Convert.ToDouble(wksr);
            if (xwall == xwsml) { sam_ksr = xwsml; return; }
            sam_ksr = xwsml + 1; return;
        }


        public void get_tst_data()
        {
            pp = 0;
            //if (SamyClass2017.ws_brth == SamyClass2017.datnul) 
            //{ pp = 1; return; }
            if (SamyClass2017.ws_cod != 4)
            { if (SamyClass2017.ws_inspriod == 0) { pp = 1; return; } }
            if ((SamyClass2017.ws_cod == 5) | (SamyClass2017.ws_cod == 10))
            { if (SamyClass2017.ws_brth2 == SamyClass2017.datnul) { pp = 1; return; } }
            if (SamyClass2017.ws_cod == 8)
                //{ if (com_den.Text.Trim() == "") { pp = 1; return; } }
                if (SamyClass2017.ws_mab == 0) { pp = 1; return; }
            if (SamyClass2017.ws_strd == SamyClass2017.datnul) { pp = 1; return; }
        }

        public void rr15()
        {
            SamyClass2017.ws_cod = 15;
            g_pen_cln();
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            SamyClass2017.ws_cod = 15;
            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            { ii = 6; return; }
            if (ii == 0)
            {
                get_calc15();
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            //if (r15.Checked == true) { r15.Checked = false; }
        }

        public void rr2()
        {
            SamyClass2017.ws_cod = 2;
            //مؤجل
            g_pen_cln();
            flagsmsm = 1;
            gg_data();
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            SamyClass2017.ws_cod = 2;
            get_data(); gg_deps(); gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            { ii = 6; return; /*if (r2.Checked == true) { r2.Checked = false; brdat.Focus(); return; } */}
            if (ii == 0)
            {
                get_calc2(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
            //if (r2.Checked == true) { r2.Checked = false; }
        }
        public void g_pen_cln()
        {
            w_mabs = 0; w_unit = 0; w_omos = 0;
            w_pen1 = 0; w_pen2 = 0; w_pen3 = 0; w_pen4 = 0; w_penall = 0;
        }
        public void rr1()
        {
            SamyClass2017.ws_cod = 1;
            g_pen_cln();
            flagsmsm = 1;
            get_infc_clean(); gg_data();
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            dattdy = SamyClass2017.ws_strd;
            onlykst = 1;
            ws_cod = 1;

            get_data();
            gg_deps();
            gg_infc_dep();
            //gg_kst_dep();
            if (xx_xx == 1) { return; }
            get_tst_data();
            if (pp == 1)
            {
                ii = 5;
                return;
            }
            if (ii == 0)
            {
                get_calc1(); gg_tst(); if (lol == 1) { return; }
                get_payed();
                get_payed2();
                get_disp();
                get_mor();
            }
        }
        public void gg_tst()
        {
            if (SamyClass2017.ws_sendiv > 65)
            {
                ii = 7;

                lol = 1;
                return;
            }
            else
            {
                lol = 0;
            }
        }
        public void gg_tst1()
        {
            if (SamyClass2017.ws_sendiv > 55)
            {
                ii = 8;
                lol = 1;
                return;
            }
            else
            {
                lol = 0;
            }
        }
        public void get_infc10()
        {

            SamyClass2017.para1 = SamyClass2017.ws_cod;
            SamyClass2017.para2 = 1924;
            SamyClass2017.para3 = xsen;
            SamyClass2017.mx = 0; SamyClass2017.nx = 0; SamyClass2017.dx = 0;

            para10(SamyClass2017.para1, SamyClass2017.para2, SamyClass2017.para3);

        }

        public void para(int p1, int p2, int p3)
        {
            List<infac> ggggg = db.infacs.Where(d => d.no == p1 && d.idf == p2
                                 && d.sen == p3).ToList();

            foreach (infac item in ggggg)
            {
                SamyClass2017.dx = Convert.ToDouble(item.dx);
                SamyClass2017.nx = Convert.ToDouble(item.nx);
                SamyClass2017.sx = Convert.ToDouble(item.sx);
                SamyClass2017.mx = Convert.ToDouble(item.mx);
                SamyClass2017.rx = Convert.ToDouble(item.rx);
            }
        }

        public void para10(int p1, int p2, int p3)
        {
            List<infac> ggggg = db.infacs.Where(d => d.no == p1 && d.idf == p2
                                 && d.sen == p3).ToList();

            foreach (infac item in ggggg)
            {
                SamyClass2017.dx = Convert.ToDouble(item.dx);
                SamyClass2017.nx = Convert.ToDouble(item.nx);
                SamyClass2017.mx = Convert.ToDouble(item.mx);
            }
        }



        #region clean var
        public void get_clean()
        {
            // dtp_brth2.Value = SamyClass2017.datnul;
            x_cur = 0; x_ins = 0; x_yer = 0;
            wbounsw = 0; x_bon = 0; x_bonall = 0; l_ls = 0;
            //inspriod9.Value = 0;

            //strdat.Value = SamyClass2017.datnul;
            SamyClass2017.ryer = 0; SamyClass2017.rhav = 0;
            SamyClass2017.rqrt = 0; SamyClass2017.rmonth = 0; SamyClass2017.ronly = 0;

            SamyClass2017.o_o5 = 0;
            SamyClass2017.o_o55 = 0;
            SamyClass2017.o_o555 = 0;
            SamyClass2017.o_o5555 = 0;

            SamyClass2017.ws_kst1 = 0; SamyClass2017.w_nbs1 = 0; SamyClass2017.w_esh1 = 0;
            SamyClass2017.ws_kst2 = 0; SamyClass2017.w_nbs2 = 0; SamyClass2017.w_esh2 = 0;
            SamyClass2017.ws_kst3 = 0; SamyClass2017.w_nbs3 = 0; SamyClass2017.w_esh3 = 0;
            SamyClass2017.ws_kst4 = 0; SamyClass2017.w_nbs4 = 0; SamyClass2017.w_esh4 = 0;
            SamyClass2017.ws_kst5 = 0; SamyClass2017.w_nbs5 = 0; SamyClass2017.w_esh5 = 0;
            SamyClass2017.o_o1 = 0; SamyClass2017.o_o2 = 0; SamyClass2017.o_o3 = 0; SamyClass2017.o_o4 = 0; SamyClass2017.o_o5 = 0; SamyClass2017.o_oz = 0;
            SamyClass2017.o_o11 = 0; SamyClass2017.o_o22 = 0; SamyClass2017.o_o33 = 0; SamyClass2017.o_o44 = 0; SamyClass2017.o_o55 = 0; SamyClass2017.o_ozz = 0;
            SamyClass2017.o_o111 = 0; SamyClass2017.o_o222 = 0; SamyClass2017.o_o333 = 0; SamyClass2017.o_o444 = 0; SamyClass2017.o_o555 = 0; SamyClass2017.o_ozzz = 0;
            SamyClass2017.o_o1111 = 0; SamyClass2017.o_o2222 = 0; SamyClass2017.o_o3333 = 0; SamyClass2017.o_o4444 = 0; SamyClass2017.o_o5555 = 0;
            SamyClass2017.o_ozzzz = 0;

            SamyClass2017.pos = 0; SamyClass2017.hel = 0; SamyClass2017.acc = 0;
            SamyClass2017.dep = 0; SamyClass2017.pen = 0;
            SamyClass2017.ws_pos = 0; SamyClass2017.ws_hel = 0; SamyClass2017.ws_acc = 0;
            SamyClass2017.ws_dep = 0; SamyClass2017.ws_pen = 0; SamyClass2017.ws_mont = 0;
            SamyClass2017.pos2 = 0; SamyClass2017.hel2 = 0; SamyClass2017.acc2 = 0;
            SamyClass2017.dep2 = 0; SamyClass2017.pen2 = 0;
        }
        public void get_clean2()
        {
            SamyClass2017.ryer = 0; SamyClass2017.rhav = 0;
            SamyClass2017.rqrt = 0; SamyClass2017.rmonth = 0; SamyClass2017.ronly = 0;
        }
        public void get_clean8()
        {
            SamyClass2017.ryer = 0; SamyClass2017.rhav = 0;
            SamyClass2017.rqrt = 0; SamyClass2017.rmonth = 0; SamyClass2017.ronly = 0;
        }
        #endregion

        public void tr0_Click(object sender, System.EventArgs e)
        {
            //if (tr0.Checked == true) { w_tr = 1; } else { w_tr = 0; } 
        }



        public void d_prodins()
        {
            //if (cons4.State == System.Data.ConnectionState.Open)
            //{ cons4.Close(); }
            //cons4.ConnectionString = SamyClass2017.connstring;

            //try
            //{
            //    cons4.Open();
            //    del_prodins.CommandText = "DELETE FROM prodins    WHERE(ser = " + w_sts + ") AND(cod = " + SamyClass2017.ws_cod + ")";
            //    //del_prodins.Parameters[0].Value = w_sts;
            //    //del_prodins.Parameters[1].Value = SamyClass2017.ws_cod;
            //    del_prodins.ExecuteNonQuery(); cons4.Close();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
            //if (cons4.State == System.Data.ConnectionState.Open)
            //{ cons4.Close(); }
        }
        public void d_bouns()
        {
            //if (sqlConnection4o.State == System.Data.ConnectionState.Open)
            //{ sqlConnection4o.Close(); }
            //sqlConnection4o.ConnectionString = SamyClass2017.connstring;

            //try
            //{
            //    sqlConnection4o.Open();
            //    del_bouns.Parameters[0].Value = w_sts;
            //    del_bouns.Parameters[1].Value = SamyClass2017.ws_cod;
            //    del_bouns.ExecuteNonQuery(); sqlConnection4o.Close();
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
            //if (sqlConnection4o.State == System.Data.ConnectionState.Open)
            //{ sqlConnection4o.Close(); }
        }

        public void button1_Click(object sender, System.EventArgs e)
        {
            x_kst1 = 0; u_kst = 0;
            yr1 = SamyClass2017.ws_strd.Year + SamyClass2017.ws_inspriod;
            mn1 = SamyClass2017.ws_strd.Month;
            xx_end = new DateTime(yr1, mn1, 1);
            yr1 = DateTime.Today.Date.Year;
            mn1 = DateTime.Today.Date.Month;
            dy1 = DateTime.Today.Date.Day;
            if (dy1 > 19)
            {
                mn1 = mn1 + 1;
                if (mn1 > 12) { mn1 = mn1 - 12; yr1 = yr1 + 1; }
            }
            xx_tdt = new DateTime(yr1, mn1, 1);
            if (flagsmsm == 0)
            {
                //MessageBox.Show("áÇ íæÌÏ ÍÓÜÜÜÜÜÜÜÜÜÜÜÜÇÈ ÊÃßÏ ãä ÇáÈíÇäÇÊ"); 
                return;
            }
            gg1 = 0; gg2 = 0; gg3 = 0;

            get_data_all();
            d_prodins();
            d_bouns();
            r_doc();
            get_max_rkm();
            SamyClass2017.ws_ser = SamyClass2017.ws_ser + 1;
            // MessageBox.Show(Convert.ToString(ww_doc));
            r_prodins();
            r_lops();
            gg1 = (g1 - 1.00) * 100.00;
            gg2 = (g2 - 1.00) * 100.00;
            gg3 = (g3 - 1.00) * 100.00;
            //f_ser.Value = SamyClass2017.ws_ser;
            //get_prn();
        }
        public void g_bon()
        {


            x_bon = 0;
            //if (connx.State == System.Data.ConnectionState.Open) { connx.Close(); }
            //connx.Open();
            ////System.Data.SqlClient.SqlDataReader rd = null;
            //connx.ConnectionString = SamyClass2017.connstring;
            //System.Data.OleDb.OleDbDataReader rd = null;
            //oleDbCommand1 = new OleDbCommand();
            //try
            //{
            //    oleDbCommand1.CommandText =
            //        "SELECT bon FROM Bounsprod WHERE  " +
            //        "cur = " + x_cur + " AND ins = " + x_ins + " AND   " +
            //        "  '" + x_dats.ToShortDateString() + " '   BETWEEN fdat AND tdat ";
            //    rd = oleDbCommand1.ExecuteReader();
            //    while (rd.Read())
            //    {
            //        if (!Convert.IsDBNull(rd[0])) { x_bon = Convert.ToDouble(rd[0]); }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.ToString());
            //    if (rd.IsClosed == false) { rd.Close(); }
            //    if (connx.State == System.Data.ConnectionState.Open) { connx.Close(); }
            //}
        }
        public void get_days()
        {
            sm_y = sm_date.Year; sm_m = sm_date.Month; sm_d = sm_date.Day;
            if ((sm_m == 1) | (sm_m == 3) | (sm_m == 5) | (sm_m == 7) | (sm_m == 8) | (sm_m == 10) | (sm_m == 12)) { sm_d = 31; }
            else { sm_d = 30; }
            if (sm_m == 2)
            {
                int xint = 0; Decimal dint = 0, xxint = 0; dint = Convert.ToDecimal(sm_y);
                dint = dint / 4; xint = sm_y / 4; xxint = Convert.ToDecimal(xint);
                if (xxint != dint) { sm_d = 28; } else { sm_d = 29; }
            }
            sm_date = new DateTime(sm_y, sm_m, sm_d);
        }
        public void r_mots()
        {
            l_ls = 0;
            x_mab = Convert.ToDouble(SamyClass2017.ws_mab);
            x_yer = SamyClass2017.ws_strd.Year + kk;
            x_dats = new DateTime(x_yer, SamyClass2017.ws_strd.Month, 1);
            if ((SamyClass2017.ws_strd.Month == 2) & (SamyClass2017.ws_strd.Day > 28))
            {
                sm_date = x_dats; get_days(); x_dats = sm_date;
            }
            x_ins = 0;
            x_cur = 1;
            if (SamyClass2017.ws_cod == 6) { x_ins = SamyClass2017.ws_cod; }
            if (SamyClass2017.ws_cod == 11) { x_ins = SamyClass2017.ws_cod; }
            g_bon();
            wbounsw = x_bon * 10.00 * x_mab / 1000.00;
            g_tsf();
            x_rat = ee;
            wbounsw = wbounsw * x_rat;
            wbounsw = Math.Round(wbounsw, 0);
            //ÍÓÇÈ ÇáÊÕÝíå
            l_ls = (1000.00 * kk / SamyClass2017.ws_inspriod) * (Math.Pow((1.00 / 1.05), (SamyClass2017.ws_inspriod - kk)));
            l_ls = Math.Round(l_ls, 0);
            x_calc = l_ls * x_mab / 1000.00;
            x_calc = Math.Round(x_calc, 0);
            x_bonall = x_calc + wbounsw;
            x_bonall = Math.Round(x_bonall, 0);
            u_kst = iikst + x_kst1;
            u_kst = Math.Round(u_kst, 2);
            //x_rat = x_bonall / iikst *100.00;
            x_rat = x_bonall / u_kst * 100.00;
            x_rat = Math.Round(x_rat, 0);
        }
        public void sub_dat()
        {
            yr1 = 0; mn1 = 0; dy1 = 0; yr2 = 0; mn2 = 0; dy2 = 0; yr3 = 0; mn3 = 0; dy3 = 0; w_shr = 0;
            if (wdat2 < wdat1) { yr3 = 0; mn3 = 0; dy3 = 0; return; }
            yr1 = wdat2.Year; mn1 = wdat2.Month; dy1 = wdat2.Day;
            yr2 = wdat1.Year; mn2 = wdat1.Month; dy2 = wdat1.Day;
            if (dy1 < dy2) { mn1 = mn1 - 1; dy1 = dy1 + 30; dy3 = dy1 - dy2; }
            else { dy3 = dy1 - dy2; }
            if (mn1 < mn2) { yr1 = yr1 - 1; mn1 = mn1 + 12; mn3 = mn1 - mn2; }
            else { mn3 = mn1 - mn2; }
            yr3 = yr1 - yr2;
            w_shr = yr3 * 12 + mn3 + 1;
            return;
        }
        public void g_tsf()
        {
            //MessageBox.Show(Convert.ToString(kk));
            yr1 = SamyClass2017.ws_strd.Year + kk;
            mn1 = SamyClass2017.ws_strd.Month;
            xx_tdt = new DateTime(yr1, mn1, 1);



            // xx_tdt = Convert.ToDateTime("2017/04/01");



            wdat2 = xx_end; wdat1 = xx_tdt; sub_dat();
            ee = Math.Pow((1.00 / (1.09)), yr3);
            if (mn3 != 0)
            {
                ee1 = Math.Pow((1.00 / (1.09)), (yr3 + 1));
                ee_frk = (ee - ee1) * mn3 / 12;
                ee = ee - ee_frk;
            }
            ee = Math.Round(ee, 3);
        }
        public void get_max_rkm()
        {
            SamyClass2017.ws_ser = 0;
            //OleDbConnection conwa = cons3;
            //if (conwa.State == System.Data.ConnectionState.Open)
            //{ conwa.Close(); }
            ////System.Data.SqlClient.SqlDataReader kxxc = null ;
            //System.Data.OleDb.OleDbDataReader kxxc = null;
            //conwa.ConnectionString = SamyClass2017.connstring;
            //oleDbCommand1 = new OleDbCommand();
            //oleDbCommand1.Connection = conwa;
            //oleDbCommand1.CommandText = "SELECT MAX(ser) FROM prodins";
            //try
            //{
            //    conwa.Open();
            //    kxxc = oleDbCommand1.ExecuteReader();
            //    while (kxxc.Read())
            //    { if (!Convert.IsDBNull(kxxc[0])) { SamyClass2017.ws_ser = Convert.ToDecimal(kxxc[0]); } }
            //}
            //catch
            //{
            //    if (kxxc.IsClosed == false) { kxxc.Close(); }
            //    if (conwa.State == System.Data.ConnectionState.Open)
            //    { conwa.Close(); }
            //}
        }
        public void r_prodins()
        {
            //if (SqlConnection11.State == System.Data.ConnectionState.Open)
            //{ SqlConnection11.Close(); }
            ////System.Data.SqlClient.SqlTransaction krd = null;
            //SqlConnection11.ConnectionString = SamyClass2017.connstring;

            //System.Data.OleDb.OleDbTransaction krd = null;
            //try
            //{
            //    SqlConnection11.Open();
            //    krd = SqlConnection11.BeginTransaction();
            //    ins_prodins11.Transaction = krd;
            //    ins_prodins11.Parameters[0].Value = SamyClass2017.ws_cod;
            //    ins_prodins11.Parameters[1].Value = SamyClass2017.ws_ser;
            //    ins_prodins11.Parameters[2].Value = SamyClass2017.ws_brth;
            //    ins_prodins11.Parameters[3].Value = SamyClass2017.ws_brth2;
            //    ins_prodins11.Parameters[4].Value = SamyClass2017.ws_inspriod;
            //    ins_prodins11.Parameters[5].Value = SamyClass2017.ws_mab;
            //    ins_prodins11.Parameters[6].Value = SamyClass2017.ws_strd;
            //    ins_prodins11.Parameters[7].Value = SamyClass2017.w_kst;
            //    ins_prodins11.Parameters[8].Value = SamyClass2017.w_prem;
            //    ins_prodins11.Parameters[9].Value = SamyClass2017.w_kstyer;
            //    ins_prodins11.Parameters[10].Value = SamyClass2017.ws_sendiv;
            //    ins_prodins11.Parameters[11].Value = SamyClass2017.ws_dentyp;
            //    ins_prodins11.Parameters[12].Value = SamyClass2017.ws_denkst;
            //    ins_prodins11.Parameters[13].Value = SamyClass2017.ws_kst1;
            //    ins_prodins11.Parameters[14].Value = SamyClass2017.w_nbs1;
            //    ins_prodins11.Parameters[15].Value = SamyClass2017.w_esh1;
            //    ins_prodins11.Parameters[16].Value = SamyClass2017.ws_kst2;
            //    ins_prodins11.Parameters[17].Value = SamyClass2017.w_nbs2;
            //    ins_prodins11.Parameters[18].Value = SamyClass2017.w_esh2;
            //    ins_prodins11.Parameters[19].Value = SamyClass2017.ws_kst3;
            //    ins_prodins11.Parameters[20].Value = SamyClass2017.w_nbs3;
            //    ins_prodins11.Parameters[21].Value = SamyClass2017.w_esh3;
            //    ins_prodins11.Parameters[22].Value = SamyClass2017.ws_kst4;
            //    ins_prodins11.Parameters[23].Value = SamyClass2017.w_nbs4;
            //    ins_prodins11.Parameters[24].Value = SamyClass2017.w_esh4;

            //    ins_prodins11.Parameters[25].Value = SamyClass2017.o_o1;
            //    ins_prodins11.Parameters[26].Value = SamyClass2017.o_o2;
            //    ins_prodins11.Parameters[27].Value = SamyClass2017.o_o3;
            //    ins_prodins11.Parameters[28].Value = SamyClass2017.o_o4;
            //    ins_prodins11.Parameters[29].Value = SamyClass2017.o_o5;

            //    ins_prodins11.Parameters[30].Value = SamyClass2017.o_o11;
            //    ins_prodins11.Parameters[31].Value = SamyClass2017.o_o22;
            //    ins_prodins11.Parameters[32].Value = SamyClass2017.o_o33;
            //    ins_prodins11.Parameters[33].Value = SamyClass2017.o_o44;
            //    ins_prodins11.Parameters[34].Value = SamyClass2017.o_o55;

            //    ins_prodins11.Parameters[35].Value = SamyClass2017.o_o111;
            //    ins_prodins11.Parameters[36].Value = SamyClass2017.o_o222;
            //    ins_prodins11.Parameters[37].Value = SamyClass2017.o_o333;
            //    ins_prodins11.Parameters[38].Value = SamyClass2017.o_o444;
            //    ins_prodins11.Parameters[39].Value = SamyClass2017.o_o555;

            //    ins_prodins11.Parameters[40].Value = SamyClass2017.o_o1111;
            //    ins_prodins11.Parameters[41].Value = SamyClass2017.o_o2222;
            //    ins_prodins11.Parameters[42].Value = SamyClass2017.o_o3333;
            //    ins_prodins11.Parameters[43].Value = SamyClass2017.o_o4444;
            //    ins_prodins11.Parameters[44].Value = SamyClass2017.o_o5555;
            //    ins_prodins11.Parameters[45].Value = SamyClass2017.w_tr;

            //    ins_prodins11.Parameters[49].Value = SamyClass2017.qq_adr;
            //    ins_prodins11.Parameters[50].Value = SamyClass2017.qq_life;
            //    ins_prodins11.Parameters[51].Value = SamyClass2017.qq_deth;
            //    ins_prodins11.Parameters[52].Value = SamyClass2017.qq_phon;
            //    ins_prodins11.Parameters[53].Value = SamyClass2017.qq_phon2;
            //    ins_prodins11.Parameters[48].Value = SamyClass2017.qq_nam2;
            //    ins_prodins11.Parameters[54].Value = SamyClass2017.qq_amil;
            //    ins_prodins11.Parameters[55].Value = SamyClass2017.qq_fax;
            //    ins_prodins11.Parameters[56].Value = SamyClass2017.ws_ser;
            //    ins_prodins11.Parameters[57].Value = DateTime.Today.Date;
            //    ins_prodins11.Parameters[47].Value = SamyClass2017.qq_nam;
            //    ins_prodins11.Parameters[58].Value = SamyClass2017.qq_nam3;
            //    ins_prodins11.Parameters[59].Value = SamyClass2017.qq_pos;
            //    ins_prodins11.Parameters[60].Value = SamyClass2017.qq_pos2;
            //    ins_prodins11.Parameters[61].Value = SamyClass2017.qq_pos3;
            //    ins_prodins11.Parameters[62].Value = SamyClass2017.qq_adr;
            //    ins_prodins11.Parameters[46].Value = SamyClass2017.qq_strd;
            //    ins_prodins11.Parameters[63].Value = SamyClass2017.qq_adr2;
            //    ins_prodins11.Parameters[64].Value = SamyClass2017.qq_adr3;
            //    ins_prodins11.Parameters[65].Value = SamyClass2017.qq_numall;
            //    ins_prodins11.Parameters[66].Value = SamyClass2017.qq_numall2;
            //    ins_prodins11.Parameters[67].Value = SamyClass2017.qq_numall3;
            //    ins_prodins11.Parameters[68].Value = SamyClass2017.ws_cur;
            //    ins_prodins11.Parameters[69].Value = 0;
            //    ins_prodins11.Parameters[70].Value = 0;
            //    ins_prodins11.Parameters[71].Value = ww_doc;
            //    ins_prodins11.Parameters[72].Value = SamyClass2017.pos;
            //    ins_prodins11.Parameters[73].Value = SamyClass2017.pos2;
            //    ins_prodins11.Parameters[74].Value = SamyClass2017.hel;
            //    ins_prodins11.Parameters[75].Value = SamyClass2017.hel2;
            //    ins_prodins11.Parameters[76].Value = SamyClass2017.acc;
            //    ins_prodins11.Parameters[77].Value = SamyClass2017.acc2;
            //    ins_prodins11.Parameters[78].Value = SamyClass2017.dep;
            //    ins_prodins11.Parameters[79].Value = SamyClass2017.dep2;
            //    ins_prodins11.Parameters[80].Value = SamyClass2017.pen;
            //    ins_prodins11.Parameters[81].Value = SamyClass2017.pen2;
            //    ins_prodins11.Parameters[82].Value = SamyClass2017.pascod;
            //    ins_prodins11.Parameters[83].Value = wom;
            //    ins_prodins11.Parameters[84].Value = SamyClass2017.ws_inspriod9;
            //    ins_prodins11.Parameters[85].Value = w_pen1;
            //    ins_prodins11.Parameters[86].Value = w_pen2;
            //    ins_prodins11.Parameters[87].Value = w_pen3;
            //    ins_prodins11.Parameters[88].Value = w_pen4;
            //    ins_prodins11.Parameters[89].Value = w_penall;
            //    ins_prodins11.ExecuteNonQuery(); krd.Commit(); SqlConnection11.Close();
            //MessageBox.Show("Êã ÇáÊÓÌíá");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    if (SqlConnection11.State == System.Data.ConnectionState.Open)
            //    { SqlConnection11.Close(); }
            //}
        }
        public void get_data_all()
        {
            wom = 0;
            //if (ch1.Checked == true) { wom = 1; }
        }
        //public void get_prn()
        //{
        //    /////////////////////////////////////////////////////////////////
        //    if (wom == 0)
        //    {
        //        //p_pol pp1 = new p_pol();
        //        //repview vv1 = new repview();
        //        //vv1.view1.ReportSource = pp1;
        //        //pp1.DataDefinition.RecordSelectionFormula = " {prodins.ser}= " + f_ser.Value + " ";
        //        //vv1.view1.Visible = true;
        //        //vv1.ShowDialog();
        //    }
        //    else
        //    {
        //        //p_pol99 pp22 = new p_pol99();
        //        //repview vv22 = new repview();
        //        //vv22.view1.ReportSource = pp22;
        //        //pp22.DataDefinition.RecordSelectionFormula = " {prodins.ser}= " + f_ser.Value + " ";
        //        //vv22.view1.Visible = true;
        //        //vv22.ShowDialog();
        //    }
        //    /////////////////////////////////////////////////////////////////

        //    /////////////////////////////////////////////////////////////////
        //    if ((SamyClass2017.ws_cod == 3) | (SamyClass2017.ws_cod == 8) | (SamyClass2017.ws_cod == 15))
        //    {
        //        return;
        //    }
        //    G_bouns pp2 = new G_bouns();
        //    repview vv2 = new repview();
        //    vv2.view1.ReportSource = pp2;
        //    pp2.DataDefinition.FormulaFields["g1"].Text = gg1.ToString();
        //    pp2.DataDefinition.FormulaFields["g2"].Text = gg2.ToString();
        //    pp2.DataDefinition.FormulaFields["g3"].Text = gg3.ToString();
        //    //pp2.DataDefinition.FormulaFields["g3"].Text = gg3.ToString();
        //    pp2.DataDefinition.RecordSelectionFormula = " {prodins.ser}= " + f_ser.Value + " ";
        //    vv2.view1.Visible = true;
        //    vv2.ShowDialog();
        //    /////////////////////////////////////////////////////////////////
        //}
        //public void get_prn()
        //{
        //    //rptx1.ReportFileName   = @"E:\Mohs_prod\reports\p_pol.rpt";			
        //    //rptx1.set_Formulas      (0,"id = "+0+" ");
        //    //			rptx1.set_Formulas      (1,"tdat = date('"+SamyClass2017.ww_dat2.Date+"') ");			
        //    //			rptx1.set_Formulas      (2,"mabs = "+SamyClass2017.ws_mab+" ");
        //    //rptx1.ReplaceSelectionFormula ( "{prodins.ser} = "+qser.Value+" ");
        //    //rptx1.Action = 0;
        //}







        public void g_rep1()
        {
            /////////////////////////////////////////////////////////////////
            //Report1 pp1 = new Report1();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep2()
        {
            /////////////////////////////////////////////////////////////////
            //Report2 pp1 = new Report2();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep3()
        {
            /////////////////////////////////////////////////////////////////
            //Report3 pp1 = new Report3();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep4()
        {
            /////////////////////////////////////////////////////////////////
            //Report4 pp1 = new Report4();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep5()
        {
            /////////////////////////////////////////////////////////////////
            //Report5 pp1 = new Report5();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep6()
        {
            /////////////////////////////////////////////////////////////////
            //Report6 pp1 = new Report6();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            ///////////////////////////////////////////////////////////////////
        }
        public void g_rep7()
        {
            /////////////////////////////////////////////////////////////////
            //Report7 pp1 = new Report7();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep8()
        {
            /////////////////////////////////////////////////////////////////
            //Report8 pp1 = new Report8();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep9()
        {
            /////////////////////////////////////////////////////////////////
            //Report9 pp1 = new Report9();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            ///////////////////////////////////////////////////////////////////
        }
        public void g_rep10()
        {
            /////////////////////////////////////////////////////////////////
            //Report10 pp1 = new Report10();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep11()
        {
            /////////////////////////////////////////////////////////////////
            //Report11 pp1 = new Report11();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            ///////////////////////////////////////////////////////////////////
        }
        public void g_rep12()
        {
            /////////////////////////////////////////////////////////////////
            //Report12 pp1 = new Report12();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep13()
        {
            /////////////////////////////////////////////////////////////////
            //Report13 pp1 = new Report13();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep14()
        {
            /////////////////////////////////////////////////////////////////
            //Report14 pp1 = new Report14();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void g_rep15()
        {
            /////////////////////////////////////////////////////////////////
            //Report15 pp1 = new Report15();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();
            /////////////////////////////////////////////////////////////////
        }
        public void button3_Click(object sender, EventArgs e)
        {
            ww_prn = 1;
            g_prn_cod();
            ww_prn = 0;
        }
        public void get_meza()
        {
            //if (r1.Checked == true) { g_rep1(); return; }
            //if (r2.Checked == true) { g_rep2(); return; }
            //if (r3.Checked == true) { g_rep3(); return; }
            //if (r4.Checked == true) { g_rep4(); return; }
            //if (r5.Checked == true) { g_rep5(); return; }
            //if (r6.Checked == true) { g_rep6(); return; }
            //if (r7.Checked == true) { g_rep7(); return; }
            //if (r8.Checked == true) { g_rep8(); return; }
            //if (r9.Checked == true) { g_rep9(); return; }
            //if (r10.Checked == true) { g_rep10(); return; }
            //if (r11.Checked == true) { g_rep11(); return; }
            //if (r12.Checked == true) { g_rep12(); return; }
            //if (r13.Checked == true) { g_rep13(); return; }
            //if (r14.Checked == true) { g_rep14(); return; }
            //if (r15.Checked == true) { g_rep15(); return; }
        }
        public void r_doc()
        {
            ww_doc = 0;
            if ((SamyClass2017.ws_mab >= 1000) & (SamyClass2017.ws_mab <= 15000)) { ww_doc = 1; return; }
            if ((SamyClass2017.ws_mab > 15000) & (SamyClass2017.ws_mab <= 50000)) { ww_doc = 2; return; }
            if ((SamyClass2017.ws_mab > 50000) & (SamyClass2017.ws_mab <= 100000)) { ww_doc = 3; return; }
            if ((SamyClass2017.ws_mab > 100000) & (SamyClass2017.ws_mab <= 250000)) { ww_doc = 4; return; }
            if ((SamyClass2017.ws_mab > 250000) & (SamyClass2017.ws_mab < 300000)) { ww_doc = 8; return; }
            if ((SamyClass2017.ws_mab >= 300000) & (SamyClass2017.ws_mab < 500000)) { ww_doc = 5; return; }
            if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab <= 1000000)) { ww_doc = 6; return; }
            if (SamyClass2017.ws_mab > 1000000) { ww_doc = 7; return; }
        }
        public void get_enab()
        {

        }





        public void gg_data()
        {
            ////f_pos.Value = 0; f_hel.Value = 0;
            ////f_acc.Value = 0; f_dep.Value = 0;
            ////f_pen.Value = 0;
            //SamyClass2017.pos = 0; SamyClass2017.hel = 0; SamyClass2017.dep = 0;
            //SamyClass2017.acc = 0; SamyClass2017.pen = 0; 
            //SamyClass2017.pos = Convert.ToDouble(f_pos.Value);
            //SamyClass2017.hel = Convert.ToDouble(f_hel.Value);
            //SamyClass2017.acc = Convert.ToDouble(f_acc.Value);
            //SamyClass2017.dep = Convert.ToDouble(f_dep.Value);
            ////SamyClass2017.pen = Convert.ToDouble(f_pen.Value);

            //SamyClass2017.pos2 = Convert.ToDouble(f_pos2.Value);
            //SamyClass2017.hel2 = Convert.ToDouble(f_hel2.Value);
            //SamyClass2017.acc2 = Convert.ToDouble(f_acc2.Value);
            //SamyClass2017.dep2 = Convert.ToDouble(f_dep2.Value);
            //SamyClass2017.pen2 = Convert.ToDouble(f_pen2.Value);

            //SamyClass2017.ws_brth = Convert.ToDateTime(brdat.Value.Date);
            //SamyClass2017.ws_brth2 = Convert.ToDateTime(dtp_brth2.Value.Date);

            //SamyClass2017.ws_mab = Convert.ToInt32(mab.Text);
            //SamyClass2017.ws_strd = Convert.ToDateTime(strdat.Value.Date);
            SamyClass2017.z_dat2 = SamyClass2017.ws_strd;
            a1000 = 0; SamyClass2017.mx1 = 0; SamyClass2017.mx2 = 0; SamyClass2017.nx1 = 0; SamyClass2017.nx2 = 0;
            a100 = 0; gxx = 0;
            onlykst = 0;
        }



        public void gg_rsm()
        {
            if ((SamyClass2017.ws_cod != 5) & (SamyClass2017.ws_cod != 6) & (SamyClass2017.ws_cod != 7) & (SamyClass2017.ws_cod != 8))
            {
                a7 = 7.50;
            }
            else
            {
                a7 = 0;
            }
            if (SamyClass2017.ws_cod == 9) { a7 = 0; }
            if (SamyClass2017.ws_cod == 12) { a7 = 0; }
            if (SamyClass2017.ws_cod == 13) { a7 = 0; }
            if (SamyClass2017.ws_cod == 14) { a7 = 0; }
            w_rsm = 0;
            SamyClass2017.ws_mont = Convert.ToDouble(SamyClass2017.ws_mab);
            SamyClass2017.ws_pos = SamyClass2017.ws_mont * SamyClass2017.pos;
            SamyClass2017.ws_hel = SamyClass2017.ws_mont * SamyClass2017.hel;
            SamyClass2017.ws_acc = SamyClass2017.ws_mont * SamyClass2017.acc;

            SamyClass2017.ws_dep = SamyClass2017.ws_mont * w_kstdep;
            //SamyClass2017.ws_pen = SamyClass2017.ws_mont * SamyClass2017.pen;

            SamyClass2017.ws_pos2 = SamyClass2017.ws_mont * SamyClass2017.pos2;
            SamyClass2017.ws_hel2 = SamyClass2017.ws_mont * SamyClass2017.hel2;
            SamyClass2017.ws_acc2 = SamyClass2017.ws_mont * SamyClass2017.acc2;
            SamyClass2017.ws_dep2 = SamyClass2017.ws_mont * w_kstdep2;
            //SamyClass2017.ws_pen2 = SamyClass2017.ws_mont * SamyClass2017.pen2;            

            if (SamyClass2017.ws_pos != 0)
            { SamyClass2017.ws_pos = SamyClass2017.ws_pos / 1000.00; }
            else { SamyClass2017.ws_pos = 0; }

            if (SamyClass2017.ws_pos2 != 0)
            { SamyClass2017.ws_pos2 = SamyClass2017.ws_pos2 / 1000.00; }
            else { SamyClass2017.ws_pos2 = 0; }

            if (SamyClass2017.ws_hel != 0)
            { SamyClass2017.ws_hel = SamyClass2017.ws_hel / 1000.00; }
            else { SamyClass2017.ws_hel = 0; }

            if (SamyClass2017.ws_hel2 != 0)
            { SamyClass2017.ws_hel2 = SamyClass2017.ws_hel2 / 1000.00; }
            else { SamyClass2017.ws_hel2 = 0; }

            if (SamyClass2017.ws_acc != 0)
            { SamyClass2017.ws_acc = SamyClass2017.ws_acc / 1000.00; }
            else { SamyClass2017.ws_acc = 0; }

            if (SamyClass2017.ws_acc2 != 0)
            { SamyClass2017.ws_acc2 = SamyClass2017.ws_acc2 / 1000.00; }
            else { SamyClass2017.ws_acc2 = 0; }

            if (SamyClass2017.ws_dep != 0)
            {
                SamyClass2017.ws_dep = SamyClass2017.ws_dep / 1000.00;
                SamyClass2017.ws_dep = SamyClass2017.ws_dep + a7;
                SamyClass2017.ws_dep = SamyClass2017.ws_dep * SamyClass2017.dep / 100;
                SamyClass2017.ws_dep = Math.Round(SamyClass2017.ws_dep, 2);
                //MessageBox.Show("ÚÌÒ", Convert.ToString(SamyClass2017.ws_dep));
            }
            else { SamyClass2017.ws_dep = 0; }


            if (SamyClass2017.ws_dep2 != 0)
            {
                SamyClass2017.ws_dep2 = SamyClass2017.ws_dep2 / 1000.00;
                SamyClass2017.ws_dep2 = SamyClass2017.ws_dep2 + a7;
                SamyClass2017.ws_dep2 = SamyClass2017.ws_dep2 * SamyClass2017.dep2 / 100;
                SamyClass2017.ws_dep2 = Math.Round(SamyClass2017.ws_dep2, 2);
                //MessageBox.Show("ÚÌÒ2", Convert.ToString(SamyClass2017.ws_dep2));
            }
            else { SamyClass2017.ws_dep2 = 0; }



            //if (SamyClass2017.ws_pen != 0)
            //{ SamyClass2017.ws_pen = SamyClass2017.ws_pen / 100.00; }
            //else { SamyClass2017.ws_pen = 0; }

            //if (SamyClass2017.ws_pen2 != 0)
            //{ SamyClass2017.ws_pen2 = SamyClass2017.ws_pen2 / 100.00; }
            //else { SamyClass2017.ws_pen2 = 0; }

            w_rsm = SamyClass2017.ws_pos + SamyClass2017.ws_hel + SamyClass2017.ws_acc
                  + SamyClass2017.ws_pos2 + SamyClass2017.ws_hel2 + SamyClass2017.ws_acc2
            + SamyClass2017.ws_pen + SamyClass2017.ws_pen2;
        }


        public void r_lops()
        {
            if (x_flag == 0)
            {
                g1 = 1.0770;
                g2 = 1.0870;
                g3 = 1.0970;
                if ((SamyClass2017.ws_sendiv > 0) & (SamyClass2017.ws_sendiv <= 30))
                {
                    if ((SamyClass2017.ws_inspriod >= 10) & (SamyClass2017.ws_inspriod <= 14))
                    { g1 = 1.1220; g2 = 1.1320; g3 = 1.1420; }
                    if ((SamyClass2017.ws_inspriod >= 15) & (SamyClass2017.ws_inspriod <= 19))
                    { g1 = 1.1020; g2 = 1.1120; g3 = 1.1220; }
                    if ((SamyClass2017.ws_inspriod >= 20) & (SamyClass2017.ws_inspriod <= 24))
                    { g1 = 1.0840; g2 = 1.0940; g3 = 1.1040; }
                    if (SamyClass2017.ws_inspriod >= 25)
                    { g1 = 1.0830; g2 = 1.0930; g3 = 1.1030; }
                }
                if ((SamyClass2017.ws_sendiv > 30) & (SamyClass2017.ws_sendiv <= 40))
                {
                    if ((SamyClass2017.ws_inspriod >= 10) & (SamyClass2017.ws_inspriod <= 14))
                    { g1 = 1.1120; g2 = 1.1220; g3 = 1.1320; }
                    if ((SamyClass2017.ws_inspriod >= 15) & (SamyClass2017.ws_inspriod <= 19))
                    { g1 = 1.0920; g2 = 1.1020; g3 = 1.1120; }
                    if ((SamyClass2017.ws_inspriod >= 20) & (SamyClass2017.ws_inspriod <= 24))
                    { g1 = 1.0800; g2 = 1.0900; g3 = 1.1000; }
                    if (SamyClass2017.ws_inspriod >= 25)
                    { g1 = 1.0800; g2 = 1.0900; g3 = 1.1000; }
                }
                if ((SamyClass2017.ws_sendiv > 40) & (SamyClass2017.ws_sendiv <= 50))
                {
                    if ((SamyClass2017.ws_inspriod >= 10) & (SamyClass2017.ws_inspriod <= 14))
                    { g1 = 1.1020; g2 = 1.1120; g3 = 1.1220; }
                    if ((SamyClass2017.ws_inspriod >= 15) & (SamyClass2017.ws_inspriod <= 19))
                    { g1 = 1.0820; g2 = 1.0920; g3 = 1.1020; }
                    if ((SamyClass2017.ws_inspriod >= 20) & (SamyClass2017.ws_inspriod <= 24))
                    { g1 = 1.0740; g2 = 1.0840; g3 = 1.0940; }
                    if (SamyClass2017.ws_inspriod >= 25)
                    { g1 = 1.0730; g2 = 1.0830; g3 = 1.0930; }
                }
                if ((SamyClass2017.ws_sendiv > 50) & (SamyClass2017.ws_sendiv <= 65))
                {
                    if ((SamyClass2017.ws_inspriod >= 10) & (SamyClass2017.ws_inspriod <= 14))
                    { g1 = 1.0920; g2 = 1.1020; g3 = 1.1120; }
                    if ((SamyClass2017.ws_inspriod >= 15) & (SamyClass2017.ws_inspriod <= 19))
                    { g1 = 1.0720; g2 = 1.0820; g3 = 1.0920; }
                    if ((SamyClass2017.ws_inspriod >= 20) & (SamyClass2017.ws_inspriod <= 24))
                    { g1 = 1.0540; g2 = 1.0640; g3 = 1.0740; }
                    if (SamyClass2017.ws_inspriod >= 25)
                    { g1 = 1.0530; g2 = 1.0630; g3 = 1.0730; }
                }
            }
            int aa = 0;
            ll = SamyClass2017.ws_inspriod;
            aa = SamyClass2017.ws_inspriod;
            kk = 1; iikst = 0;
            iiser = Convert.ToInt32(SamyClass2017.ws_ser);
            ii743 = 0; ii843 = 0; ii943 = 0;
            //MessageBox.Show("ÇáÞÓØ ÞÈá ÇáÎÕã", Convert.ToString(w_kstyer));
            w_kstyer = w_kstyer - (w_kstyer * 0.05);
            w_kstyer = Math.Round(w_kstyer, 2);
            if (kk == 1) { x_kst1 = w_kstyer; }
            while (kk <= ll)
            {
                if (kk != 1)
                {
                    iikst = iikst + w_kstyer;
                    ii743 = w_kstyer * Math.Pow(g1, aa);

                    ii843 = w_kstyer * Math.Pow(g2, aa);

                    ii943 = w_kstyer * Math.Pow(g3, aa);
                }
                x_bonall = 0; x_rat = 0;
                //if (kk == 4)
                //{
                //    MessageBox.Show("------------------------------");
                //}
                if ((kk > 2) & (kk < SamyClass2017.ws_inspriod))
                {
                    r_mots();
                }
                else
                {
                    x_bonall = 0; x_rat = 0;
                }
                //MessageBox.Show("------------------------------");
                r_div();
                r_bouns();


                kk = kk + 1; aa = aa - 1;
            }
        }
        public void r_bouns()
        {
            //if (SqlConnection11.State == System.Data.ConnectionState.Open)
            //{ SqlConnection11.Close(); }
            //SqlConnection11.ConnectionString = SamyClass2017.connstring;

            //System.Data.OleDb.OleDbTransaction krd1 = null;

            //try
            //{
            //    SqlConnection11.Open();
            //    krd1 = SqlConnection11.BeginTransaction();
            //    ins_bouns11.Transaction = krd1;
            //    ins_bouns11.Parameters[0].Value = SamyClass2017.ws_cod;
            //    ins_bouns11.Parameters[1].Value = iiser;
            //    ins_bouns11.Parameters[2].Value = kk;
            //    ins_bouns11.Parameters[3].Value = iikst;
            //    ins_bouns11.Parameters[4].Value = ii743;
            //    ins_bouns11.Parameters[5].Value = ii843;
            //    ins_bouns11.Parameters[6].Value = ii943;
            //    ins_bouns11.Parameters[7].Value = x_bonall;
            //    ins_bouns11.Parameters[8].Value = x_rat;

            //    ins_bouns11.ExecuteNonQuery(); krd1.Commit(); SqlConnection11.Close();
            //    //MessageBox.Show("Êã ÇáÊÓÌíá");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    if (SqlConnection11.State == System.Data.ConnectionState.Open)
            //    { SqlConnection11.Close(); }
            //}
        }
        public void gg_deps()
        {
            ww_sens1 = 0; ww_moda1 = 0; ww_deps1 = 0; zz_deps = 0;
            ww_sens1 = Convert.ToDouble(SamyClass2017.ws_sen1);
            ww_moda1 = Convert.ToDouble(SamyClass2017.ws_inspriod);
            ww_deps1 = ww_sen1 + ww_moda1;
            //MessageBox.Show("sssssssssssssssssssssssssss");
            if (ww_deps1 > 60.00)
            {
                ww_moda1 = ww_moda1 - (ww_deps1 - 60.00);
                flagdeps = 0;
            }
            else
            {
                flagdeps = 1;
            }
            if ((ww_sens1 >= 20) & (ww_sen1 <= 40)) { zz_deps = 3.00; }
            if ((ww_sens1 >= 41) & (ww_sen1 <= 45)) { zz_deps = 3.50; }
            if ((ww_sens1 >= 46) & (ww_sen1 <= 50)) { zz_deps = 4.00; }
            if ((ww_sens1 >= 51) & (ww_sen1 <= 55)) { zz_deps = 4.50; }
            //if (Convert.ToDouble(f_dep.Value) != zz_deps)
            //{
            //    //MessageBox.Show("äÓÈå ÇáÚÌÒ ÇáÇÕáíå", Convert.ToString(zz_deps));
            //    zz_deps = Convert.ToDouble(f_dep.Value);
            //    SamyClass2017.dep = zz_deps;
            //}
            //else
            //{
            //    f_dep.Value = Convert.ToDecimal(zz_deps);
            //    SamyClass2017.dep = zz_deps;
            //}
        }

        public void gg_deps2()
        {
            ww_sens2 = 0; ww_moda2 = 0; ww_deps2 = 0; zz_deps2 = 0;
            ww_sens2 = Convert.ToDouble(SamyClass2017.ws_sen2);
            ww_moda2 = Convert.ToDouble(SamyClass2017.ws_inspriod);
            ww_deps2 = ww_sen2 + ww_moda2;
            if (ww_deps2 > 60.00)
            {
                ww_moda2 = ww_moda2 - (ww_deps2 - 60.00);
            }
            if ((ww_sens2 >= 20) & (ww_sen2 <= 40)) { zz_deps = 3.00; }
            if ((ww_sens2 >= 41) & (ww_sen2 <= 45)) { zz_deps = 3.50; }
            if ((ww_sens2 >= 46) & (ww_sen2 <= 50)) { zz_deps = 4.00; }
            if ((ww_sens2 >= 51) & (ww_sen2 <= 55)) { zz_deps = 4.50; }
            //if (Convert.ToDouble(f_dep2.Value) != zz_deps2)
            //{
            //    //MessageBox.Show("äÓÈå ÇáÚÌÒ ÇáÇÕáíå", Convert.ToString(zz_deps2));
            //    zz_deps2 = Convert.ToDouble(f_dep2.Value);
            //    SamyClass2017.dep2 = zz_deps2;
            //}
            //else
            //{
            //    f_dep2.Value = Convert.ToDecimal(zz_deps2);
            //    SamyClass2017.dep2 = zz_deps2;
            //}
        }
        public void gg_infc_dep()
        {
            w_kstdep = w_kstdep;
            if (ww_sen1 != 0)
            {
                gsen = ww_sen1;
                get_infcnew();
                get_infc_mov1();
                gsen = gsen + Convert.ToInt32(ww_moda1);
                get_infcnew();
                get_infc_mov2();
                get_infc_rkm99();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen1;
            }
        }
        public void gg_infc_dep2()
        {
            if (ww_sen2 != 0)
            {
                gsen = ww_sen2;
                get_infcnew();
                get_infc_mov1();
                gsen = gsen + Convert.ToInt32(ww_moda2);
                get_infcnew();
                get_infc_mov2();
                get_infc_rkm99();
                w_prem = w_kst; xsen = SamyClass2017.ws_sen2;
            }
        }
        public void get_infcnew()
        {
            SamyClass2017.mx = 0; SamyClass2017.nx = 0; SamyClass2017.dx = 0; SamyClass2017.rx = 0; SamyClass2017.sx = 0;
            xxsen = gsen;
            if (xxsen < 20) { xxsen = 20; }
            if ((SamyClass2017.ws_cod == 1) | (SamyClass2017.ws_cod == 2) | (SamyClass2017.ws_cod == 3) | (SamyClass2017.ws_cod == 4) | (SamyClass2017.ws_cod == 10) | (SamyClass2017.ws_cod == 11)) { xxno = 1; xxyer = 1924; }
            if ((SamyClass2017.ws_cod == 3) | (SamyClass2017.ws_cod == 7) | (SamyClass2017.ws_cod == 12) | (SamyClass2017.ws_cod == 13) | (SamyClass2017.ws_cod == 14) | (SamyClass2017.ws_cod == 15)) { xxno = 7; xxyer = 1949; }
            if (SamyClass2017.ws_cod == 5) { xxno = 5; xxyer = 1949; }
            if (SamyClass2017.ws_cod == 6) { xxno = 6; xxyer = 1924; }
            if (SamyClass2017.ws_cod == 8) { xxno = 88; xxyer = 1949; }
            if ((SamyClass2017.ws_cod == 3) & (onlykst == 1)) { xxno = 11; xxyer = 1924; }

            if (SamyClass2017.ws_cod == 9) { return; }


            SamyClass2017.para1 = xxno;
            SamyClass2017.para2 = xxyer;
            SamyClass2017.para3 = xxsen;
            para(SamyClass2017.para1, SamyClass2017.para2, SamyClass2017.para3);

        }
        public void get_infc_rkm99()
        {
            if ((SamyClass2017.nx1 - SamyClass2017.nx2) == 0)
            {
                a1000 = 0;
            }
            else
            {
                a1000 = ((SamyClass2017.mx1 - SamyClass2017.mx2 + SamyClass2017.dx2) / (SamyClass2017.nx1 - SamyClass2017.nx2)) * 1000;
            }
            Double xsx = 300;
            if (ww_sen2 > 0)
            {
                if (ww_sen2 == 0)
                {
                    xsx = 0;
                }
                else
                {
                    xsx = (ww_sen2 / xsx);
                }
            }
            else
            {
                if (ww_moda1 == 0)
                {
                    xsx = 0;
                }
                else
                {
                    xsx = (ww_moda1 / xsx);
                }
            }
            gxx = Convert.ToDouble(xsx); gxx = (a1000 + 2) / (1 - gxx);
            gxx = Math.Round(gxx, 2);
            w_kstdep = gxx;
            //////////
            w_kst = gxx;
        }
        public void gg_kst_dep()
        {
            ///SamyClass2017.ws_dep = w_kstdep;
            //w_kstdep = w_kstdep * SamyClass2017.ws_mab / 1000.00;
            //MessageBox.Show(" ÈÏæä 7.50 ÞÓØ ÇáÚÌÒ", Convert.ToString(w_kstdep));
            //w_kstdep = w_kstdep + a7;
            //MessageBox.Show(" ÈÚÏ 7.50 ÞÓØ ÇáÚÌÒ", Convert.ToString(w_kstdep));
            //SamyClass2017.dep = w_kstdep * SamyClass2017.dep / 100;
            //MessageBox.Show("ãÈáÛ ÇáÚÌÒ", Convert.ToString(SamyClass2017.dep));
        }


        public void g_dis5()
        {
            //if (f_pos2.Visible == true) { f_pos2.Visible = false; }
            //if (f_hel2.Visible == true) { f_hel2.Visible = false; }
            //if (f_acc2.Visible == true) { f_acc2.Visible = false; }
            //if (f_dep2.Visible == true) { f_dep2.Visible = false; }
        }
        public void g_en5()
        {
            //if (f_pos2.Visible == false) { f_pos2.Visible = true; }
            //if (f_hel2.Visible == false) { f_hel2.Visible = true; }
            //if (f_acc2.Visible == false) { f_acc2.Visible = true; }
            //if (f_dep2.Visible == false) { f_dep2.Visible = true; }
        }




        public void zz_rsm()
        {
            //MessageBox.Show("ssssssssssssssss");
            SamyClass2017.ws_dep = Convert.ToDouble(SamyClass2017.ws_mab);
            SamyClass2017.ws_dep = w_prem * SamyClass2017.ws_dep / 1000.00;
            SamyClass2017.ws_dep = SamyClass2017.ws_dep + a7;
            SamyClass2017.ws_dep = SamyClass2017.ws_dep * SamyClass2017.dep / 100.00;
            //SamyClass2017.ws_dep = w_prem * (SamyClass2017.ws_mab + a7) * SamyClass2017.dep / 100000.00;
            SamyClass2017.ws_dep = Math.Round(SamyClass2017.ws_dep, 2);
        }
        public void gg_sum()
        {
            w_rsm = w_rsm + SamyClass2017.ws_dep + SamyClass2017.ws_dep2;
            w_kstyer = w_kstyer + w_rsm;
        }
        public void gg_pen()
        {
            //MessageBox.Show("ãÚÇÔ ÇáÚÇÆáå");
            ao1 = 0; ao2 = 0; ao3 = 0; ao4 = 0; aop = 0; aog = 0; asen = 0;

            ao1 = (1.00 - Math.Pow((1.00 / 1.04), SamyClass2017.ws_inspriod)) / 0.04;

            get_infc_clean();
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            get_infc(); get_infc_mov1();
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod; if (xsen < 20) { xsen = 20; }
            get_infc(); get_infc_mov2();
            ao3 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1;

            double dx1new = SamyClass2017.dx1;

            get_infc_clean();
            xsen = SamyClass2017.ws_sen1 + 1; if (xsen < 20) { xsen = 20; }
            get_infc(); get_infc_mov1();
            xsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod + 1; if (xsen < 20) { xsen = 20; }
            get_infc(); get_infc_mov2();
            ao2 = (SamyClass2017.nx1 - SamyClass2017.nx2) / dx1new;

            get_infc_clean();
            xsen = SamyClass2017.ws_sen1; if (xsen < 20) { xsen = 20; }
            get_infc(); get_infc_mov1();
            xsen = SamyClass2017.ws_sen1 + 5; if (xsen < 20) { xsen = 20; }
            get_infc(); get_infc_mov2();
            ao4 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1;

            aop = (ao1 - ao2) / (ao3 + ao4) * 100.00;

            aog = aop / 0.80 + 1.00;
            z_zft = aog;
            get_z_zft1000();
            aog = z_zft;
            //MessageBox.Show("ãÚÇÔ ", Convert.ToString(aog));
        }
        public void get_z_zft1000()
        {
            //MessageBox.Show("sssssssssssssssssssssss");
            Decimal uu = 0, uu1 = 0, oo = 0, ww = 0, dd = 0; double lolo = 0;
            uu = Convert.ToDecimal(z_zft * 1000);
            uu1 = Convert.ToDecimal(z_zft * 100);
            uu1 = decimal.Truncate(uu1);
            uu1 = uu1 / 100;


            uu = decimal.Truncate(uu);
            uu = uu / 10;
            //uu = uu * 100;
            ww = Decimal.Truncate(uu);

            //oo = decimal.Truncate((uu) * 10);
            //oo = oo * 10;
            dd = (uu - ww) * 10;
            if (dd >= 5)
            {
                lolo = Convert.ToDouble(uu1) + 0.01;
            }
            else
            {
                lolo = Convert.ToDouble(uu1);
            }
            z_zft = Math.Round(lolo, 2);
        }
        public void kk_pen()
        {
            //MessageBox.Show("kokyyyyyyyyyyyyyyyyyyyyy");
            SamyClass2017.pen = 0; SamyClass2017.pen2 = 0; SamyClass2017.ws_pen = 0; SamyClass2017.ws_pen2 = 0;
            //if (f_pen.Checked == true)
            //{
            //    if (SamyClass2017.ws_inspriod9 > 5)
            //    {
            //        asen = SamyClass2017.ws_sen1; gg_pen();
            //        SamyClass2017.pen = aog;
            //        SamyClass2017.ws_pen = SamyClass2017.pen * Convert.ToDouble(SamyClass2017.ws_mab) / 1000.00 * 2.00;
            //    }
            //}

        }
        public void get_payed2()
        {
            //MessageBox.Show("sssssssssssss");
            //if (f_pen9.Checked == true) { return; }

            ww_pen = SamyClass2017.ws_pen / 2.00;
            //MessageBox.Show("smsm", Convert.ToString(ww_pen));
            w_rkm = 0.0; w_shr = 1;
            SamyClass2017.w_dival = 1.00;
            if ((SamyClass2017.ws_cod != 5) & (SamyClass2017.ws_cod != 6) & (SamyClass2017.ws_cod != 7) & (SamyClass2017.ws_cod != 8))
            { w_kstyer = w_kstyer - ww_pen; }
            w_rkm = w_kstyer * SamyClass2017.w_dival / w_shr;
            w_rkm = Math.Round(w_rkm, 3);
            get_zft_rkm();
            SamyClass2017.ws_kst16 = w_rkm;
            //get_omola_end();
            //get_mov_omo1();
            SamyClass2017.w_dival = 1.02; w_shr = 2;
            w_rkm = w_kstyer * SamyClass2017.w_dival / w_shr;
            w_rkm = Math.Round(w_rkm, 3);
            get_zft_rkm();
            SamyClass2017.ws_kst26 = w_rkm;
            //get_omola_end();
            //get_mov_omo2();
            SamyClass2017.w_dival = 1.03; w_shr = 4;
            w_rkm = w_kstyer * SamyClass2017.w_dival / w_shr;
            w_rkm = Math.Round(w_rkm, 3);
            get_zft_rkm();
            SamyClass2017.ws_kst36 = w_rkm;
            //get_omola_end();
            //get_mov_omo3();
            SamyClass2017.w_dival = 1.05; w_shr = 12;
            w_rkm = w_kstyer * SamyClass2017.w_dival / w_shr;
            w_rkm = Math.Round(w_rkm, 3);
            get_zft_rkm();
            SamyClass2017.ws_kst46 = w_rkm;
            //get_omola_end();
            //get_mov_omo4();            

            get_kst_one2();
        }
        public void get_kst_one2()
        {
            SamyClass2017.z_rat_one = 0;
            get_rat_one();
            SamyClass2017.ws_kst56 = w_kstyer * SamyClass2017.z_rat_one;
            SamyClass2017.ws_kst56 = Math.Round(SamyClass2017.ws_kst56, 2);
        }










        public void get_soso8()
        {
            flagsmsm = 1;
            if (ww_prn == 1)
            {
                ww_prn = 0;
                get_meza();
                return;
            }
            get_enab();
            f_e = 0;
            dattdy = SamyClass2017.ws_strd;
            // if (strdat.Value < a1981) { strdat.Value = dattdy; }
            get_clean8();
            //get_ena8();


            SamyClass2017.ws_cod = 8;
            //com_den.Select(0, 25); com_den.Focus();
            //if (r8.Checked == true) { r8.Checked = false; }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            //Report1 pp1 = new Report1();
            //repview vv1 = new repview();
            //vv1.view1.ReportSource = pp1;
            //vv1.view1.Visible = true;
            //vv1.ShowDialog();

            //Report2 pp2 = new Report2();
            //repview vv2 = new repview();
            //vv2.view1.ReportSource = pp2;
            //vv2.view1.Visible = true;
            //vv2.ShowDialog();

            //Report3 pp3 = new Report3();
            //repview vv3 = new repview();
            //vv3.view1.ReportSource = pp3;
            //vv3.view1.Visible = true;
            //vv3.ShowDialog();

            //Report4 pp4 = new Report4();
            //repview vv4 = new repview();
            //vv4.view1.ReportSource = pp4;
            //vv4.view1.Visible = true;
            //vv4.ShowDialog();

            //Report5 pp5 = new Report5();
            //repview vv5 = new repview();
            //vv5.view1.ReportSource = pp5;
            //vv5.view1.Visible = true;
            //vv5.ShowDialog();

            //Report6 pp6 = new Report6();
            //repview vv6 = new repview();
            //vv6.view1.ReportSource = pp6;
            //vv6.view1.Visible = true;
            //vv6.ShowDialog();

            //Report7 pp7 = new Report7();
            //repview vv7 = new repview();
            //vv7.view1.ReportSource = pp7;
            //vv7.view1.Visible = true;
            //vv7.ShowDialog();

            //Report8 pp8 = new Report8();
            //repview vv8 = new repview();
            //vv8.view1.ReportSource = pp8;
            //vv8.view1.Visible = true;
            //vv8.ShowDialog();

            //Report9 pp9 = new Report9();
            //repview vv9 = new repview();
            //vv9.view1.ReportSource = pp9;
            //vv9.view1.Visible = true;
            //vv9.ShowDialog();

            //Report10 pp10 = new Report10();
            //repview vv10 = new repview();
            //vv10.view1.ReportSource = pp10;
            //vv10.view1.Visible = true;
            //vv10.ShowDialog();

            //Report11 pp11 = new Report11();
            //repview vv11 = new repview();
            //vv11.view1.ReportSource = pp11;
            //vv11.view1.Visible = true;
            //vv11.ShowDialog();

            //Report12 pp12 = new Report12();
            //repview vv12 = new repview();
            //vv12.view1.ReportSource = pp12;
            //vv12.view1.Visible = true;
            //vv12.ShowDialog();

            //Report13 pp13 = new Report13();
            //repview vv13 = new repview();
            //vv13.view1.ReportSource = pp13;
            //vv13.view1.Visible = true;
            //vv13.ShowDialog();

            //Report14 pp14 = new Report14();
            //repview vv14 = new repview();
            //vv14.view1.ReportSource = pp14;
            //vv14.view1.Visible = true;
            //vv14.ShowDialog();

            //Report15 pp15 = new Report15();
            //repview vv15 = new repview();
            //vv15.view1.ReportSource = pp15;
            //vv15.view1.Visible = true;
            //vv15.ShowDialog();
        }
        public void get_mor()
        {
            //MessageBox.Show(Convert.ToString(SamyClass2017.w_kst));
            x_flag = 0;
            if ((SamyClass2017.w_kst >= 50.00) & (SamyClass2017.ws_sendiv > 47))
            {
                g1 = 1.059;
                g2 = 1.069;
                g3 = 1.079;

                gg1 = 5.9;
                gg2 = 6.9;
                gg3 = 7.9;
                x_flag = 1;
            }
        }


        public void r_div()
        {
            //return;
            if (kk == xa1)
            {
                iikst = iikst - (SamyClass2017.ws_mab * va1 / 100.00) + w_kstyer;
            }
            if (kk == xa2)
            {
                iikst = iikst - (SamyClass2017.ws_mab * va2 / 100.00) + w_kstyer;
            }
            if (kk == xa3)
            {
                iikst = iikst - (SamyClass2017.ws_mab * va3 / 100.00) + w_kstyer;
            }
        }




        public void get_kstnew()
        {
            //MessageBox.Show("sssssssssssssssssssssssssssss");
            zrat = 1;
            nz = 0; dz = 0; nz1 = 0; dz1 = 0; nz2 = 0; dz2 = 0; nz3 = 0; dz3 = 0;
            zsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod; get_infc_kstnew();
            nz1 = nz; dz1 = dz;
            zsen = SamyClass2017.ws_sen1; get_infc_kstnew();
            nz2 = nz; dz2 = dz;
            zsen = SamyClass2017.ws_sen1 + SamyClass2017.ws_inspriod9; get_infc_kstnew();
            nz3 = nz; dz3 = dz;
            Double ra = 0, rb = 0;
            ra = ((nz2 - nz1) / dz2); rb = ((nz2 - nz3) / dz2);
            ra = Math.Round(ra, 3); rb = Math.Round(rb, 3);
            zrat = ra / rb; zrat = Math.Round(zrat, 5);
            //if ((SamyClass2017.ws_polcy == 23548) & (SamyClass2017.ws_ksh == 1))
            //{
            //    //MessageBox.Show("ssssssssssssssssssssssssssãÚÇãá ÇáÈÞÑì ");
            //    zrat = 2.804;
            //}
            //MessageBox.Show("ãÚÇãá", Convert.ToString(zrat));

        }
        public void get_clean1()
        {
            SamyClass2017.ws_inspriod = 0; SamyClass2017.ws_inspriod9 = 0;
            x_cur = 0; x_ins = 0; x_yer = 0;
            wbounsw = 0; x_bon = 0; x_bonall = 0; l_ls = 0;


            SamyClass2017.ryer = 0; SamyClass2017.rhav = 0;
            SamyClass2017.rqrt = 0; SamyClass2017.rmonth = 0; SamyClass2017.ronly = 0;
            SamyClass2017.o_o5 = 0;
            SamyClass2017.o_o55 = 0;
            SamyClass2017.o_o555 = 0;
            SamyClass2017.o_o5555 = 0;

            SamyClass2017.ws_kst1 = 0; SamyClass2017.w_nbs1 = 0; SamyClass2017.w_esh1 = 0;
            SamyClass2017.ws_kst2 = 0; SamyClass2017.w_nbs2 = 0; SamyClass2017.w_esh2 = 0;
            SamyClass2017.ws_kst3 = 0; SamyClass2017.w_nbs3 = 0; SamyClass2017.w_esh3 = 0;
            SamyClass2017.ws_kst4 = 0; SamyClass2017.w_nbs4 = 0; SamyClass2017.w_esh4 = 0;
            SamyClass2017.ws_kst5 = 0; SamyClass2017.w_nbs5 = 0; SamyClass2017.w_esh5 = 0;
            SamyClass2017.o_o1 = 0; SamyClass2017.o_o2 = 0; SamyClass2017.o_o3 = 0; SamyClass2017.o_o4 = 0; SamyClass2017.o_o5 = 0; SamyClass2017.o_oz = 0;
            SamyClass2017.o_o11 = 0; SamyClass2017.o_o22 = 0; SamyClass2017.o_o33 = 0; SamyClass2017.o_o44 = 0; SamyClass2017.o_o55 = 0; SamyClass2017.o_ozz = 0;
            SamyClass2017.o_o111 = 0; SamyClass2017.o_o222 = 0; SamyClass2017.o_o333 = 0; SamyClass2017.o_o444 = 0; SamyClass2017.o_o555 = 0; SamyClass2017.o_ozzz = 0;
            SamyClass2017.o_o1111 = 0; SamyClass2017.o_o2222 = 0; SamyClass2017.o_o3333 = 0; SamyClass2017.o_o4444 = 0; SamyClass2017.o_o5555 = 0;
            SamyClass2017.o_ozzzz = 0;

            SamyClass2017.pos = 0; SamyClass2017.hel = 0; SamyClass2017.acc = 0;
            SamyClass2017.dep = 0; SamyClass2017.pen = 0;
            SamyClass2017.ws_pos = 0; SamyClass2017.ws_hel = 0; SamyClass2017.ws_acc = 0;
            SamyClass2017.ws_dep = 0; SamyClass2017.ws_pen = 0; SamyClass2017.ws_mont = 0;
            SamyClass2017.pos2 = 0; SamyClass2017.hel2 = 0; SamyClass2017.acc2 = 0;
            SamyClass2017.dep2 = 0; SamyClass2017.pen2 = 0;
        }


        public void g_prn_cod()
        {
            if (SamyClass2017.ws_cod == 1)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report1.pdf"));

            }
            if (SamyClass2017.ws_cod == 2)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report2.pdf"));

            }
            if (SamyClass2017.ws_cod == 3)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report3.pdf"));

            }
            if (SamyClass2017.ws_cod == 4)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report4.pdf"));

            }
            if (SamyClass2017.ws_cod == 5)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report5.pdf"));

            }
            if (SamyClass2017.ws_cod == 6)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report6.pdf"));

            }
            if (SamyClass2017.ws_cod == 7)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report7.pdf"));

            }
            if (SamyClass2017.ws_cod == 8)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report8.pdf"));

            }
            if (SamyClass2017.ws_cod == 9)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report9.pdf"));

            }
            if (SamyClass2017.ws_cod == 10)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report10.pdf"));

            }
            if (SamyClass2017.ws_cod == 11)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report11.pdf"));

            }
            if (SamyClass2017.ws_cod == 12)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report12.pdf"));

            }
            if (SamyClass2017.ws_cod == 13)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report13.pdf"));

            }
            if (SamyClass2017.ws_cod == 14)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report14.pdf"));

            }
            if (SamyClass2017.ws_cod == 15)
            {
                // Process.Start(Server.MapPath(@"D:\Moh_prod_SW\Mohs_prod\lifeprod\xpdf\report15.pdf"));
            }

        }
        public void gg_clns_new()
        {
            dx1_70 = 0; dx2_20 = 0; dx3_10 = 0; dx4_10 = 0; dx_sum = 0;
        }
        public void gg_111()
        {
            gg_clns_new();
            gg_sen = SamyClass2017.ws_sen1;
            gg_sen = gg_sen + 0; gg_infc_new(); dx1_70 = SamyClass2017.dx * 70.00 / 100.00;
            gg_sen = gg_sen + 1; gg_infc_new(); dx2_20 = SamyClass2017.dx * 20.00 / 100.00;
            gg_sen = gg_sen + 1; gg_infc_new(); dx3_10 = SamyClass2017.dx * 10.00 / 100.00;
            gg_sen = gg_sen + 1; gg_infc_new(); dx4_10 = SamyClass2017.dx * 10.00 / 100.00;

            dx_sum = dx1_70 + dx2_20 + dx3_10 + dx4_10;
        }
        public void gg_infc_new()
        {
            SamyClass2017.mx = 0; SamyClass2017.nx = 0; SamyClass2017.dx = 0; SamyClass2017.rx = 0; SamyClass2017.sx = 0;
            if (SamyClass2017.ws_cod == 1)
            {
                xxno = 7; xxyer = 1949; xxsen = gg_sen;
            }
            SamyClass2017.para1 = xxno;
            SamyClass2017.para2 = xxyer;
            SamyClass2017.para3 = xxsen;
            para(SamyClass2017.para1, SamyClass2017.para2, SamyClass2017.para3);

        }
        public void get_infc_rkm111()
        {
            //MessageBox.Show("ssssssssssssssssssss");
            a1000 = (SamyClass2017.mx1 - SamyClass2017.mx2 + SamyClass2017.dx2) / SamyClass2017.dx1 * 1000.00;
            a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1;
            axx = a1000 / a100;

            gxx = (axx + 2.50) / (0.96 - (dx_sum / (SamyClass2017.nx1 - SamyClass2017.nx2)));

            w_kst = gxx;

            get_zft_omo_kst();
            w_kst = Math.Round(w_kst, 2);
            if (SamyClass2017.sen > 0)
            {
                w_prem = w_kst; w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;
                w_kstyer22 = w_prem * SamyClass2017.ws_mab / 1000; flag_dep = 1; return;
            }
            else
            {
                ww_ttt = w_kst; w_prem = w_kst;
                if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
                { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
                //ÇáÊÎÝíÖ
                if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
                w_kstyer = w_prem * SamyClass2017.ws_mab / 1000;
                w_kstyer22 = w_prem * SamyClass2017.ws_mab / 1000; flag_dep = 0;
            }
            SamyClass2017.ws_sen2 = 0;
        }
        public void get_infc_rkm112()
        {
            a1000 = (SamyClass2017.mx1 - SamyClass2017.mx2) + (SamyClass2017.dx3 / 2) + (SamyClass2017.dx2 / 2); a1000 = (a1000 * 1000);
            a1000 = a1000 / SamyClass2017.dx1; a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1; gxx = a1000 / a100;
            Double gzz = 0.0;
            gzz = (gxx + 3.50) / (0.96 - (1.10 / a100));
            w_kst = gzz; get_zft_omo_kst(); w_kst = Math.Round(w_kst, 2); w_prem = w_kst;
            ww_ttt = w_kst; w_prem = w_kst;
            if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
            { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
            //ÇáÊÎÝíÖ
            if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
            SamyClass2017.ws_sen2 = 0;
        }
        public void get_infc_rkm113()
        {
            a1000 = (1000 * (SamyClass2017.mx1 - SamyClass2017.mx2)) + (250 * SamyClass2017.dx3) + (250 * SamyClass2017.dx4) + (500 * SamyClass2017.dx2);
            a1000 = a1000 / SamyClass2017.dx1; a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1; gxx = a1000 / a100;
            Double gzz = 0.0;
            Double loading = 0.96 - (1.10 / a100); gzz = (gxx + 3.50) / loading;
            w_kst = gzz; get_zft_omo_kst(); w_kst = Math.Round(w_kst, 2); w_prem = w_kst;
            ww_ttt = w_kst; w_prem = w_kst;
            if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
            { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
            //ÇáÊÎÝíÖ
            if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
        }
        public void get_infc_rkm114()
        {
            a1000 = (1000 * (SamyClass2017.mx1 - SamyClass2017.mx2)) + (150 * SamyClass2017.dx3) + (150 * SamyClass2017.dx4) + (200 * SamyClass2017.dx) + (500 * SamyClass2017.dx2);
            a1000 = a1000 / SamyClass2017.dx1; a100 = (SamyClass2017.nx1 - SamyClass2017.nx2) / SamyClass2017.dx1; gxx = a1000 / a100;
            Double gzz = 0.0;
            gzz = (gxx + 3.50) / (0.96 - (1.10 / a100));
            w_kst = gzz; get_zft_omo_kst(); w_kst = Math.Round(w_kst, 2); w_prem = w_kst;
            ww_ttt = w_kst; w_prem = w_kst;
            if ((SamyClass2017.ws_mab >= 500000) & (SamyClass2017.ws_mab < 1000000))
            { w_prem = w_kst - 1; ww_ttt = w_kst - 1; }
            //ÇáÊÎÝíÖ
            if (SamyClass2017.ws_mab >= 1000000) { w_prem = w_kst - 1.5; }
        }




    }
}
