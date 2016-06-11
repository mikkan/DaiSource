using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnXayDungPhanMem
{
    public class OChua
    {
        private int ViTriO;
        public VienDa[] SoDaTrongO;
        public Label lbl_SucChua;


        public OChua()
        {

        }

        public OChua(int SoLuong, int holenum, Label lblsucchua)
        {
            SoDaTrongO = new VienDa[SoLuong]; // khoi tao mang chua so vien da
            this.ViTriO = holenum; // vi tri o tren ban co
            this.lbl_SucChua = lblsucchua; // label hien thi so da trong o
            lbl_SucChua.Text = SoDaTrongO.Length.ToString();
            
        }

        public void ThemDa(VienDa stone)
        {
            Array.Resize(ref SoDaTrongO, SoDaTrongO.Length + 1);
            SoDaTrongO[SoDaTrongO.Length - 1] = stone;
            lbl_SucChua.Text = SoDaTrongO.Length.ToString();
        }

        public void XoaDa()
        {
            Array.Resize(ref SoDaTrongO, 0);
            lbl_SucChua.Text = "0";
        }

        public void ThemDa(int i, VienDa stone)
        {
            SoDaTrongO[i] = stone;
            lbl_SucChua.Text = SoDaTrongO.Length.ToString();
        }

        public int GetViTriO()
        {
            return ViTriO;
        }

        public int GetSoLuongDa()
        {
            return SoDaTrongO.Length;
        }

        public VienDa ThongTinVienDa(int num)
        {
            return SoDaTrongO[num];
        }

        public void SetLabel(int num)
        {
            lbl_SucChua.Text = num.ToString();
        }
    }





        
}

