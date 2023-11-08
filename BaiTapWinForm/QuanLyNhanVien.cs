using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWinForm
{
    internal class QuanLyNhanVien
    {
        private string _MNV;
        private string _HT;
        private string _DC;
        private double _LUONG;
        private string _MNQL;
        private int _PHG;

        public QuanLyNhanVien(string mNV, string hT, string dC, double lUONG, string mNQL, int pHG)
        {
            MNV = mNV;
            HT = hT;
            DC = dC;
            LUONG = lUONG;
            MNQL = mNQL;
            PHG = pHG;
        }

        public string MNV { get => _MNV; set => _MNV = value; }
        public string HT { get => _HT; set => _HT = value; }
        public string DC { get => _DC; set => _DC = value; }
        public double LUONG { get => _LUONG; set => _LUONG = value; }
        public string MNQL { get => _MNQL; set => _MNQL = value; }
        public int PHG { get => _PHG; set => _PHG = value; }
    }
}
