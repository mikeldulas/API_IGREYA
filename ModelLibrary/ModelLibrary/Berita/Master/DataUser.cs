using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Berita.Master
{
    class DataUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string NIK { get; set; }
        string KTP { get; set; }
        string Alamat { get; set; }
        string HP { get; set; }
        string Email { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string UpdateBy { get; set; }
        DateTime UpdateDate { get; set; }
    }
}
