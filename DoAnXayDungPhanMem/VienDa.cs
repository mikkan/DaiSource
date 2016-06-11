using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnXayDungPhanMem
{
    public class VienDa
    {
        private int _ViTri;

        public int LayViTri
        {
            get { return _ViTri; }
            set { _ViTri = value; }
        }

        private Image _HinhDa;

        public Image HinhDa
        {
            get { return _HinhDa; }
            set { _HinhDa = value; }
        }

        

        public VienDa()
        {
            _ViTri = 0;
            
        }

        

        public void Draw() // Ve vien da
        {

        }
    }

    
}
