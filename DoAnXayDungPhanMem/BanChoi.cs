using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace DoAnXayDungPhanMem
{
    class BanChoi
    {
        VienDa[] MangVienDa = new VienDa[70];
        public OChua[] MangOChua = new OChua[14];
        //public KhoChua[] MangKhoChua = new KhoChua[2];
        public int OHienTai;

        public BanChoi()
        {

        }

        public void KhoiTaoVienDa()
        {
            for (int i = 0; i < MangVienDa.Length; i++) 
            {
                MangVienDa[i] = new VienDa();
                //MangVienDa[i].HinhDa = Image.FromFile("BatDau.png");
            }
        }


        public void KhoiTaoOChua(Label[] labelOchua)
        {
            for (int i = 0 ; i < labelOchua.Length; i ++)
            {
                if (i == 5 || i == 11 || i==12 || i==13 )
                    MangOChua[i] = new OChua(0, i, GetLabel(labelOchua, i));
     
                else
                    MangOChua[i] = new OChua(5, i, GetLabel(labelOchua, i));
                   
            }
        }

        private Label GetLabel(Label[] Formlabels, int index)
        {
            int i = 0;
            string str = "label" + (index + 1).ToString();
            while (str != Formlabels[i].Text)
            {
                i++;
            }
            return Formlabels[i];
        }

        public void KhoiTaoDaTrongO()
        {
            int DemVienDa = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    MangOChua[i].ThemDa(j, MangVienDa[DemVienDa]);
                }
            }
            for (int j = 0; j < 10; j++) // tao da cho o quan
            {
                MangOChua[5].ThemDa(MangVienDa[DemVienDa]);
                MangOChua[11].ThemDa(MangVienDa[DemVienDa]);
            }
            for (int i =6 ; i < 11; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    MangOChua[i].ThemDa(j, MangVienDa[DemVienDa]);
                }
            }
        }

        public void KhoiTaoDaTrongKho()
        {

        }

        public OChua[] GetHoleArray
        {
            get
            {
                return MangOChua;
            }
        }

        public int ThongBao(OChua ochua)
        {
            return ochua.GetSoLuongDa();
        }

        //public void ThongBao(Button btn,OChua[] ochua)
        //{
        //    int dem = ochua[OHienTai].GetSoLuongDa();
        //    btn.Text = dem.ToString();
        //}

        public void RaiQuan(OChua ochua, bool nguoichoi, bool huongdi, PictureBox[] mangbantay, Form a,Button btn)
        {
            OHienTai = ochua.GetViTriO();
            int solgda = ochua.GetSoLuongDa();
            btn.Text = solgda.ToString();
            MangOChua[OHienTai].SetLabel(0);
            MangOChua[OHienTai].lbl_SucChua.Refresh();

            
            
            mangbantay[OHienTai].Visible = true;
            if (OHienTai == 0)
            {
                mangbantay[11].Visible = false;
            }
            else
                mangbantay[OHienTai - 1].Visible = false;

            a.Refresh();
            if (nguoichoi == true)
            {
                if (huongdi) // di qua ben phai
                {
                    while (solgda != 0)
                    {
                        mangbantay[OHienTai].Visible = true;
                        OHienTai++;
                        if (OHienTai == 12)
                            OHienTai = 0;
                        mangbantay[OHienTai].Visible = true;
                        if (OHienTai == 0)
                        {
                            mangbantay[11].Visible = false;
                        }
                        else
                            mangbantay[OHienTai - 1].Visible = false;

                        a.Refresh();
                        MangOChua[OHienTai].ThemDa(ochua.ThongTinVienDa(solgda - 1));
                        solgda--;
                        btn.Text = solgda.ToString();
                        btn.Refresh();
                        Thread.Sleep(300);
                        MangOChua[OHienTai].lbl_SucChua.Refresh();
                    }
                }

                else if(huongdi == false) // di sang ben trai
                {
                    while (solgda != 0)
                    {
                        mangbantay[OHienTai].Visible = true;
                        OHienTai--;
                        if (OHienTai == -1)
                            OHienTai = 11;
                        mangbantay[OHienTai].Visible = true;

                        if (OHienTai == 11)
                        {
                            mangbantay[0].Visible = false;
                        }
                        else
                            mangbantay[OHienTai + 1].Visible = false;

                        a.Refresh();
                        MangOChua[OHienTai].ThemDa(ochua.ThongTinVienDa(solgda - 1));
                        solgda--;
                        btn.Text = solgda.ToString();
                        btn.Refresh();
                        Thread.Sleep(300);
                        MangOChua[OHienTai].lbl_SucChua.Refresh();
                    }
                }
            }
            else // neu luot di la cua nguoi choi 2
            {
                while (solgda != 0)
                {
                    if (huongdi==false) // huong di qua ben trai
                    {
                        mangbantay[OHienTai].Visible = true;
                        OHienTai++;

                        if (OHienTai == 12)
                            OHienTai = 0;
                        mangbantay[OHienTai].Visible = true;
                        if (OHienTai == 0)
                        {
                            mangbantay[11].Visible = false;
                        }
                        else
                            mangbantay[OHienTai - 1].Visible = false;

                        a.Refresh();
                        //if (OHienTai == 5)
                        //    OHienTai = 6;
                        MangOChua[OHienTai].ThemDa(ochua.ThongTinVienDa(solgda - 1));
                        
                        
                        //mangbantay[OHienTai].Visible = true;
                        solgda--;
                        btn.Text = solgda.ToString();
                        btn.Refresh();
                        Thread.Sleep(500);
                        MangOChua[OHienTai].lbl_SucChua.Refresh();
                        //mangbantay[OHienTai].Visible = false;
                    }
                    else if (huongdi == true) // huong di qua ben phai
                    
                    {
                        mangbantay[OHienTai].Visible = true;
                        OHienTai--;
                        if (OHienTai == -1)
                            OHienTai = 11;
                        mangbantay[OHienTai].Visible = true;

                        if (OHienTai == 11)
                        {
                            mangbantay[0].Visible = false;
                        }
                        else
                            mangbantay[OHienTai + 1].Visible = false;

                        a.Refresh();


                        //if (OHienTai == 5)
                        //    OHienTai = 4;
                        MangOChua[OHienTai].ThemDa(ochua.ThongTinVienDa(solgda - 1));
                        solgda--;
                        btn.Text = solgda.ToString();
                        btn.Refresh();
                        Thread.Sleep(500);
                        MangOChua[OHienTai].lbl_SucChua.Refresh();
                    }
                }
            }
            ochua.XoaDa();
            Thread.Sleep(1000);
           
            mangbantay[OHienTai].Visible = false;
        }

        public int TraViTriOHienTai()
        {
            return OHienTai;
        }
        public void RaiQuanKhiHetDa(OChua[] ochua, bool nguoichoi)
        {
            VienDa[] soda;
            int ndathem =0;
            // lay ra so da trong kho
            if (nguoichoi)// nguoi choi 1
            {
                soda = ochua[12].SoDaTrongO;
                for (int i = 0; i < 5; i++)
                {
                    ochua[i].ThemDa(soda[ndathem++]);
                    ochua[i].lbl_SucChua.Refresh();
                }
                //cap nhat lai da trong kho
                ochua[12].XoaDa();
                for (int j = 0; j < soda.Length - 5; j++)
                {
                    ochua[12].ThemDa(soda[j]);
                }
                ochua[12].lbl_SucChua.Refresh();
            }
            else // nguoi choi 2
            {
                soda = ochua[13].SoDaTrongO;
                for (int i = 6; i < 11; i++)
                {
                    ochua[i].ThemDa(soda[ndathem++]);
                    ochua[i].lbl_SucChua.Refresh();
                }
                //cap nhat lai da trong kho
                ochua[13].XoaDa();
                for (int j = 0; j < soda.Length - 5; j++)
                {
                    ochua[13].ThemDa(soda[j]);
                }
                ochua[13].lbl_SucChua.Refresh();
            }
        }
    }
}

