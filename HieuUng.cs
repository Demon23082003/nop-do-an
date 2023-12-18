using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ungdunghoctumoi
{
   
      public class TuMoi
        {
            private string nghiatienganh, nghiatiengviet;
            public string NghiaTiengAnh { get { return nghiatienganh; } set { nghiatienganh = value; } }
            public string NghiaTiengViet { get { return nghiatiengviet; } set { nghiatiengviet = value; } }
            public TuMoi(string ta, string tv)
            {
                nghiatienganh = ta;
                nghiatiengviet = tv;
            }
        }

    public class HieuUng
    {
        private List<TuMoi> NewWord;
        public List<TuMoi> NewWordRandom;
        private int soluongtumoi;
        private int tongsotumoi;
        public int TongSoTuMoi { get { return tongsotumoi; } set { tongsotumoi = value; } }
        public int SoLuongTuMoi { get { return soluongtumoi; } set { soluongtumoi = value; } }
        private int diem;
        public int Diem { get { return diem; } set { diem = value; } }

        public string taketa(int i)
        {
            return NewWordRandom[i].NghiaTiengAnh;
        }
        public string taketv(int i)
        {
            return NewWordRandom[i].NghiaTiengViet;
        }
        public void LoadNewWord()
        {
            StreamReader d = new StreamReader("data.txt");
            string tienganh;
            while ((tienganh = d.ReadLine()) != null)
            {
                string tiengviet = d.ReadLine();
                TuMoi tumoi = new TuMoi(tienganh, tiengviet);
                NewWord.Add(tumoi);
                tongsotumoi++;
            }
            d.Close();
        
        }
        
        public List<string> tv()
        {
            List<string> kaka = new List<string>();
            for(int i=0;i<soluongtumoi;i++)
            {
                kaka.Add(NewWordRandom[i].NghiaTiengViet);
            }
            return kaka;
        }
        bool CheckNumber(int n, int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (n == a[i])
                    return false;//trả về false nếu bị trùng
            }
            return true;
        }
        public void ThemTu(string sta,string stv)
        {
            StreamWriter wr = new StreamWriter("data.txt", true);
            wr.WriteLine(sta);
            wr.WriteLine(stv);
            wr.Close();
        }
        //public int[] mangxaotron()
        //{
        //    int[] mang = new int[SoLuongTuMoi];
        //    mang[0] = 100;
        //    Random rd = new Random();
        //    int index;
        //    for(int i=0;i<SoLuongTuMoi;i++)
        //    {
        //    manh:
        //        index = rd.Next(0, tongsotumoi);
        //        if (CheckNumber(index, mang) == false)
        //            goto manh;
        //        else
        //            mang[i]=index;
        //    }
        //    return mang;
        //}
        // random tu vung 
        public void TakeRandomNewWord()
        {
            Random rd = new Random();
            int[] key = new int[15];
            int index;
            key[0] = 100;
            for (int i = 0; i < soluongtumoi; i++)
            {
            check:
                index = rd.Next(0, tongsotumoi);
                if (CheckNumber(index, key) == false)
                    goto check;

                else
                {
                    key[i] = index;
                    TuMoi random = new TuMoi(NewWord[index].NghiaTiengAnh, NewWord[index].NghiaTiengViet);
                    NewWordRandom.Add(random);
                }
            }

        }
        public HieuUng()
        {
            NewWord = new List<TuMoi>();
            NewWordRandom = new List<TuMoi>();
            diem = 0;
            tongsotumoi = 0;
        }
        public HieuUng(int x, List<TuMoi> a)
        {
            soluongtumoi = x;
            NewWordRandom = a;
        }
        public int KiemTra(List<TuMoi> cautraloi)
        {
            for(int i=0;i<soluongtumoi;i++)
            {
                if (NewWordRandom[i].NghiaTiengAnh == cautraloi[i].NghiaTiengAnh && NewWordRandom[i].NghiaTiengViet == cautraloi[i].NghiaTiengViet)
                    diem++;
            }
            return diem;
        }
        }
    }

