﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace SQLiteAssignments
{
    public class LoaiHoa
    {
        [PrimaryKey, AutoIncrement]
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
    }
}
