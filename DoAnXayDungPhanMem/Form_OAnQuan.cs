using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnXayDungPhanMem
{
    public partial class Form_OAnQuan : Form
    {
        //public OChua[] ochua = new OChua[14];
        public bool coquan1 = false, coquan2 = false;
        public OChua[] ochua;
        private int buttonclicked = -1;
        private int ohientai = -1;
        private int flag = 0;
        public static bool KetThucGame = false;
        public static int NguoiChienThang;
        private BanChoi banchoi = new BanChoi();
        private bool nguoichoi,huongdi = true;
        public PictureBox[] MangBanTay = new PictureBox[12];
        public Form_OAnQuan()
        {
            InitializeComponent();
        }

        private void ptb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptb_New_Click(object sender, EventArgs e)
        {
            NewGame frm = new NewGame();
            frm.Show();
        }

        public Label[] GetLabel()
        {
            Label[] labels = new Label[14]; // khoi tao 14 label
            int i = 0;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is Label)
                {
                    labels[i] = (Label)ctr;
                    i++;
                }
            }
            return labels;
        }
    
        private void Form_OAnQuan_Load(object sender, EventArgs e)
        {
            ochua = banchoi.MangOChua;

            banchoi.KhoiTaoVienDa();
            banchoi.KhoiTaoOChua(GetLabel());
            banchoi.KhoiTaoDaTrongO();
            nguoichoi = true;
        
            foreach (Control ctr in this.Controls)
            {
                if (ctr is PictureBox)
                {
                    if (ctr.Name[ctr.Name.Length - 3] == 'x')
                    {
                        int j = int.Parse(ctr.Name[ctr.Name.Length - 2].ToString() + ctr.Name[ctr.Name.Length - 1].ToString());
                        PictureBox c = (PictureBox)ctr;
                        c.Visible = false;
                        MangBanTay[j - 1] = c;
                    }
                }
            }

        }

        int o2 = 0, o1 = 0;

        int hamcon(int Kho)
        {
            if (ochua[o1].GetSoLuongDa() == 0 && ochua[o2].GetSoLuongDa() != 0)
            {
                /*Dieu kien de an dan*/
                if ((o1 != 5 && o1 != 11 && o2!=5 && o2!=11)||(o2==5&&coquan1)||(o2==11&&coquan2))
                {
                        foreach (VienDa vd in ochua[o2].SoDaTrongO)
                        {
                            ochua[Kho].ThemDa(vd);
                        }
                        ochua[o2].XoaDa();
                        ochua[o2].lbl_SucChua.Refresh();
                        Thread.Sleep(300);
                        ochua[Kho].lbl_SucChua.Refresh();

                        txt_Display.Text = " Ăn Dân";
                        txt_Display.Visible = true;
                        txt_Display.Refresh();
                        Thread.Sleep(300);
                        txt_Display.Visible = false;
                  
                }
                /*dieu kien de an quan*/
                else if (o2 == 5 && ochua[o2].GetSoLuongDa() >= 15 || o2 == 11 && ochua[o2].GetSoLuongDa() >= 15)
                {
                    foreach (VienDa vd in ochua[o2].SoDaTrongO)
                    {
                        ochua[Kho].ThemDa(vd);
                    }
                    ochua[o2].XoaDa();
                    ochua[o2].lbl_SucChua.Refresh();
                    Thread.Sleep(300);
                    ochua[Kho].lbl_SucChua.Refresh();
                    if (o2 == 5)
                    {
                        coquan1 = true;
                    }
                    else
                    {
                        coquan2 = true;
                    }

                    txt_Display.Text = " Ăn Quan";
                    txt_Display.Visible = true;
                    txt_Display.Refresh();
                    Thread.Sleep(300);
                    txt_Display.Visible = false;
                }
                else
                {
                    txt_Display.Text = "Mất Lượt";
                    txt_Display.Visible = true;
                    txt_Display.Refresh();
                    Thread.Sleep(300);
                    txt_Display.Visible = false;
                    return -1;
                }

            }
            else if (ohientai == 5 || ohientai == 11/* || ohientai == 10 || ohientai == 4*/)
            {
                txt_Display.Text = "Mất Lượt";
                txt_Display.Visible = true;
                txt_Display.Refresh();
                Thread.Sleep(300);
                txt_Display.Visible = false;
                return -1;
            }
            else if (ochua[o1].GetSoLuongDa() == 0 && ochua[o2].GetSoLuongDa() == 0)
            {
                txt_Display.Text = "Mất Lượt";
                txt_Display.Visible = true;
                txt_Display.Refresh();
                Thread.Sleep(300);
                txt_Display.Visible = false;
                return -1;
            }
            else
            {
                txt_Display.Text = "Mất Lượt";
                txt_Display.Visible = true;
                txt_Display.Refresh();
                Thread.Sleep(300);
                txt_Display.Visible = false;
                return -1;
            }
            return 0;
        }

        public void ChoiGame()
        {
            if (buttonclicked <= 5)
            {
                while (KiemTra.ThemLuotDi(banchoi, banchoi.MangOChua, nguoichoi, huongdi))
                {
                    ohientai = banchoi.TraViTriOHienTai();
                    if (huongdi == true && nguoichoi == false || huongdi == false && nguoichoi == true)
                    {
                        ohientai--;
                        if (ohientai == -1)
                            ohientai = 11;
                    }
                    if (huongdi == false && nguoichoi == false || huongdi == true && nguoichoi == true)
                    {
                        ohientai++;
                        if (ohientai == 12)
                            ohientai = 0;
                    }
                    txt_Display.Text = ("Lượt tiếp tục");
                    txt_Display.Visible = true;
                    txt_Display.Refresh();

                    banchoi.RaiQuan(banchoi.GetHoleArray[(ohientai)], nguoichoi, huongdi,MangBanTay, this,btn_Da);
                    //Thread.Sleep(300);
                    txt_Display.Visible = false;

                }
                while ((KiemTra.ThemLuotDi(banchoi, banchoi.MangOChua,nguoichoi,huongdi)) == false)
                {
                    if (huongdi) // huong di ben phai cua nguoi choi 1
                    {
                        #region KhaiBaoBien
                        ohientai = banchoi.TraViTriOHienTai();
                        if (ohientai == 10)
                        {
                            o1 = 11;
                            o2 = 0;
                        }
                        else if (ohientai == 11)
                        {
                            o1 = 0;
                            o2 = 1;
                        }
                        else
                        {
                            o1 = ohientai + 1;
                            o2 = ohientai + 2;
                        }
                        #endregion
                        int kho_a = 12;
                        /*code dang sai*/
                        if (hamcon(kho_a) == -1)
                            break;

                        
                        if (ohientai == 11)
                            ohientai = 1;
                        else if (ohientai == 10)
                            ohientai = 0;
                        else
                            ohientai += 2;
                        banchoi.OHienTai = ohientai;
                    }
                    else if(huongdi == false) // huong di qua ben trai cua nguoi 1
                    {
                        #region KhaiBaoBien
                        ohientai = banchoi.TraViTriOHienTai();
                        if (ohientai == 0)
                        {
                            o1 = 11;
                            o2 = 10;
                        }
                        else if (ohientai == 1)
                        {
                            o1 = 0;
                            o2 = 11;
                        }
                        else
                        {
                            o1 = ohientai - 1;
                            o2 = ohientai - 2;
                        }
                        #endregion

                        int kho_a = 12;
                        if (hamcon(kho_a) == -1)
                            break;

                        if (ohientai == 0)
                            ohientai = 10;
                        else if (ohientai == 1)
                            ohientai = 11;
                        else
                            ohientai -= 2;
                        banchoi.OHienTai = ohientai;
                    }
                }
                nguoichoi = false;
            }
            else if (nguoichoi == false)
            {
                while (KiemTra.ThemLuotDi(banchoi,banchoi.MangOChua,nguoichoi,huongdi))
                {
                    ohientai = banchoi.TraViTriOHienTai();
                    if (huongdi == true && nguoichoi == false || huongdi == false && nguoichoi == true)
                    { 
                        ohientai--; 
                    }
                    if (huongdi == false && nguoichoi == false || huongdi == true && nguoichoi == true)
                    {
                        ohientai++;
                        if (ohientai == 12)
                            ohientai = 0;
                    }
                    txt_Display.Text = ("Lượt tiếp tục");
                    txt_Display.Visible = true;
                    txt_Display.Refresh();

                    banchoi.RaiQuan(banchoi.GetHoleArray[(ohientai)], nguoichoi, huongdi, MangBanTay, this,btn_Da);
                    //Thread.Sleep(300);
                    txt_Display.Visible = false;
                    
                }
                while ((KiemTra.ThemLuotDi(banchoi, banchoi.MangOChua,nguoichoi,huongdi)) == false)
                {
                    if (huongdi) // huong di ben phai cua nguoi choi 2
                    {
                        #region KhaiBaoBien
                        ohientai = banchoi.TraViTriOHienTai();
                        if (ohientai == 0)
                        {
                            o1 = 11;
                            o2 = 10;
                        }
                        else if (ohientai == 1)
                        {
                            o1 = 0;
                            o2 = 11;
                        }
                        else
                        {
                            o1 = ohientai - 1;
                            o2 = ohientai - 2;
                        }
                        #endregion
                        int kho_b = 13;
                        if (hamcon(kho_b) == -1)
                            break;

                        
                        if (ohientai == 0)
                            ohientai = 10;
                        else if (ohientai == 1)
                            ohientai = 11;
                        else
                            ohientai -= 2;
                        banchoi.OHienTai = ohientai;
                       
                    }
                    else if (huongdi == false) // huong di qua ben trai cua nguoi 2
                    {
                        #region KhaiBaoBien
                        ohientai = banchoi.TraViTriOHienTai();
                        if (ohientai == 10)
                        {
                            o1 = 11;
                            o2 = 0;
                        }
                        else if (ohientai == 11)
                        {
                            o1 = 0;
                            o2 = 1;
                        }
                        else
                        {
                            o1 = ohientai + 1;
                            o2 = ohientai + 2;
                        }
                        #endregion

                        int kho_b = 13;
                        if (hamcon(kho_b) == -1)
                            break;

                        if (ohientai == 11)
                            ohientai = 1;
                        else if (ohientai == 10)
                            ohientai = 0;
                        else
                            ohientai += 2;
                        banchoi.OHienTai = ohientai;
                    }
                }
                nguoichoi = true;
            }


            if (nguoichoi == false)
            {
                ptb_player2.Visible = true;
                ptb_player1.Visible = false;
            }
            else 
            {
                ptb_player1.Visible = true;
                ptb_player2.Visible = false;
            }
        }

        private void KetQua()
        {
            KiemTra.KetThucTran(banchoi.GetHoleArray);
            if (KetThucGame == true)
            {
                if (NguoiChienThang == 0)
                {
                    txt_Display.Text = "Hòa";
                    txt_Display.Visible = true;
                }
                else if (NguoiChienThang == 1)
                {
                    txt_Display.Text = "Người Chơi 1 Thắng";
                    txt_Display.Visible = true;
                }
                else
                {
                    txt_Display.Text = "Người Chơi 2 Thắng";
                    txt_Display.Visible = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ochua[0].GetSoLuongDa() != 0)
            {
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == true)
                {
                    buttonclicked = 1;
                    if (nguoichoi == true)
                        banchoi.RaiQuan(banchoi.GetHoleArray[0], nguoichoi, huongdi, MangBanTay, this,btn_Da);
                    ChoiGame();
                    if(KiemTra.KiemTraHetQuan(ochua) == 2)
                        banchoi.RaiQuanKhiHetDa(ochua, false);
                    KetQua();
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
            {
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ochua[1].GetSoLuongDa() != 0)
            {
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == true)
                {
                    buttonclicked = 2;
                    //ohientai = buttonclicked;
                    if (nguoichoi == true)
                        banchoi.RaiQuan(banchoi.GetHoleArray[1], nguoichoi, huongdi, MangBanTay, this, btn_Da);
                    ChoiGame();
                    if (KiemTra.KiemTraHetQuan(ochua) == 2)
                        banchoi.RaiQuanKhiHetDa(ochua, false);
                    KetQua();
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ochua[2].GetSoLuongDa() != 0)
            {
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == true)
                {
                    buttonclicked = 3;
                    if (nguoichoi == true)
                        banchoi.RaiQuan(banchoi.GetHoleArray[2], nguoichoi, huongdi, MangBanTay, this, btn_Da);
                    ChoiGame();
                    if (KiemTra.KiemTraHetQuan(ochua) == 2)
                        banchoi.RaiQuanKhiHetDa(ochua, false);
                    KetQua();
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (ochua[3].GetSoLuongDa() != 0)
            {
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == true)
                {
                    buttonclicked = 4;
                    if (nguoichoi == true)
                        banchoi.RaiQuan(banchoi.GetHoleArray[3], nguoichoi, huongdi, MangBanTay, this, btn_Da);
                    ChoiGame();
                    if (KiemTra.KiemTraHetQuan(ochua) == 2)
                        banchoi.RaiQuanKhiHetDa(ochua, false);
                    KetQua();
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ochua[4].GetSoLuongDa() != 0)
            {
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == true)
                {
                    buttonclicked = 5;
                    //if (nguoichoi == true)
                    banchoi.RaiQuan(banchoi.GetHoleArray[4], nguoichoi, huongdi, MangBanTay, this, btn_Da);
                    ChoiGame();
                    if (KiemTra.KiemTraHetQuan(ochua) == 2)
                        banchoi.RaiQuanKhiHetDa(ochua, false);
                    KetQua();
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (ochua[6].GetSoLuongDa() != 0)
            {
                buttonclicked = 6;
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == false)
                {

                    if (nguoichoi == false)
                        banchoi.RaiQuan(banchoi.GetHoleArray[6], nguoichoi, huongdi, MangBanTay, this, btn_Da);
                    ChoiGame();
                    if (KiemTra.KiemTraHetQuan(ochua) == 1)
                        banchoi.RaiQuanKhiHetDa(ochua, true);
                    KetQua();
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (ochua[7].GetSoLuongDa() != 0)
            {
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == false)
                {
                    buttonclicked = 7;
                    if (nguoichoi == false)
                        banchoi.RaiQuan(banchoi.GetHoleArray[7], nguoichoi, huongdi, MangBanTay, this, btn_Da);
                    ChoiGame();
                    if (KiemTra.KiemTraHetQuan(ochua) == 1)
                        banchoi.RaiQuanKhiHetDa(ochua, true);
                    KetQua();
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ochua[8].GetSoLuongDa() != 0)
            {
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == false)
                {
                    buttonclicked = 8;
                    if (nguoichoi == false)
                        banchoi.RaiQuan(banchoi.GetHoleArray[8], nguoichoi, huongdi, MangBanTay, this, btn_Da);
                    ChoiGame();
                    if (KiemTra.KiemTraHetQuan(ochua) == 1)
                        banchoi.RaiQuanKhiHetDa(ochua, true);
                    KetQua();
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (ochua[9].GetSoLuongDa() != 0)
            {
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == false)
                {
                    buttonclicked = 9;
                    if (nguoichoi == false)
                        banchoi.RaiQuan(banchoi.GetHoleArray[9], nguoichoi, huongdi, MangBanTay, this, btn_Da);
                    ChoiGame();
                    if (KiemTra.KiemTraHetQuan(ochua) == 1)
                        banchoi.RaiQuanKhiHetDa(ochua, true);
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (ochua[10].GetSoLuongDa() != 0)
            {
                if (flag == 0)
                    MessageBox.Show("Bạn chưa chọn hướng đi ");
                else if (nguoichoi == false)
                {
                    buttonclicked = 10;
                    if (nguoichoi == false)
                        banchoi.RaiQuan(banchoi.GetHoleArray[10], nguoichoi, huongdi, MangBanTay, this, btn_Da);
                    ChoiGame();
                    if (KiemTra.KiemTraHetQuan(ochua) == 1)
                        banchoi.RaiQuanKhiHetDa(ochua, true);
                    flag = 0;
                }
                else
                    MessageBox.Show("Bạn không được quyền đi  từ ô này ");
            }
            else
                MessageBox.Show("Ô hiện tại không có đá, không thể đi ");
        }

        private void btn_Trai_Click(object sender, EventArgs e)
        {
            huongdi = false;
            flag ++;
            if (flag == 2)
            {
                MessageBox.Show("Chọn Ô Để Đi");
                flag = 1;
            }
            
        }

        private void btn_Phai_Click(object sender, EventArgs e)
        {
            huongdi = true;
            flag++;
            if (flag == 2)
            {
                MessageBox.Show("Chọn Ô Để Đi");
                flag = 1;
            }
                
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
