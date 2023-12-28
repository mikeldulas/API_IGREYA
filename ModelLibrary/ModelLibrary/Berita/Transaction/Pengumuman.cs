using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Berita.Transaction
{
    class Pengumuman
    {
        int Id { get; set; }
        string Ket { get; set; }
        bool Active { get; set; }
        DateTime ForDate { get; set; }
        public byte[] FileData { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string UpdateBy { get; set; }
        DateTime UpdateDate { get; set; }
    }
}
