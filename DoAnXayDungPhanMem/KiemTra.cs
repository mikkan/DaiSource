using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnXayDungPhanMem
{
    class KiemTra
    {
        

        public static bool ThemLuotDi(BanChoi b, OChua[] ochua,Boolean nguoichoi, Boolean huongdi)
        {

            int OHienTai = b.TraViTriOHienTai();
            if (huongdi == false && nguoichoi == false || huongdi == true && nguoichoi == true)
            {
                if (OHienTai == 11 || OHienTai ==12 || OHienTai ==13)
                    OHienTai = -1;
                if (OHienTai + 1 != 5 && OHienTai + 1 != 11 && ochua[(OHienTai + 1)].GetSoLuongDa() != 0)
                    return true;
                else
                    return false;
            }

            if (huongdi == true && nguoichoi == false || huongdi == false && nguoichoi == true)
            {
                if (OHienTai == 0)
                    OHienTai = 12;
                if (OHienTai - 1 != 5 && OHienTai - 1 != 11 && ochua[(OHienTai - 1)].GetSoLuongDa() != 0)
                    return true;
                else
                    return false;
            }
            return true;
        }

        public static int KiemTraHetQuan(OChua[] ochua)
        {
            int Dem = 0;
            for (int i = 0; i < 5; i++)
            {
                if (ochua[i].GetSoLuongDa() == 0)
                    Dem++;
            }
            if (Dem == 5)
                return 1; // nguoi choi 1 het da
            Dem = 0;
            for (int i = 6; i < 11; i++)
            { if (ochua[i].GetSoLuongDa() == 0)
                    Dem++;
            }
            if (Dem == 5)
                return 2;// nguoi choi 2 het da
            return 0;
        }

        public static int ThangTran(OChua[] ochua)
        {
            if (ochua[12].GetSoLuongDa() == ochua[13].GetSoLuongDa() || KiemTraHetQuan(ochua) == 1 && ochua[12].GetSoLuongDa() < 5)
                return 0; ////Hoa
            if (ochua[12].GetSoLuongDa() > ochua[13].GetSoLuongDa() || KiemTraHetQuan(ochua)==2 && ochua[13].GetSoLuongDa()<5)
                return 1; ////Nguoi choi 1 thang
            else return 2; //// nguoi choi 2 thang
        }

        public static void KetThucTran(OChua[] ochua)
        {
            if (ochua[5].GetSoLuongDa() == 0 && ochua[11].GetSoLuongDa() == 0)
            {
                Form_OAnQuan.KetThucGame = true;
                int Dem;
                {
                    for (int i = 6; i < 11; i++)
                    {
                        Dem = ochua[i].GetSoLuongDa();
                        while (Dem != 0)
                        {
                            ochua[13].ThemDa(ochua[i].ThongTinVienDa(Dem - 1));
                            Dem--;
                        }
                        ochua[i].XoaDa();
                    }
                }
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Dem = ochua[i].GetSoLuongDa();
                        while (Dem != 0)
                        {
                            ochua[12].ThemDa(ochua[i].ThongTinVienDa(Dem - 1));
                            Dem--;
                        }
                        ochua[i].XoaDa();
                    }
                }
                Form_OAnQuan.NguoiChienThang = ThangTran(ochua);
            }
            else
                return;
        }
    }
}
