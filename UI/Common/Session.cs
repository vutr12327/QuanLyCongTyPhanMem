using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace QuanLyCongTyPhanMem;

public class Session
{
    public static dto_NguoiDung? NguoiDung { get; set; }

    public static void DangXuat()
    {
        NguoiDung = null;
    }
}
