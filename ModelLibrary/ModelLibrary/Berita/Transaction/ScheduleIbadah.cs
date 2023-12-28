using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Berita.Transaction
{
    class ScheduleIbadah
    {
        int id { get; set; }
        DateTime Tgl_Ibadah { get; set; }
        DateTime Start_Ibadah { get; set; }
        DateTime End_Ibadah { get; set; }
        string Hari { get; set; }
        string Pembicara { get; set; }
        string Tema { get; set; }
        int Id_Event { get; set; }
        string Event { get; set; }
        string Details { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string UpdateBy { get; set; }
        DateTime UpdateDate { get; set; }
    }
}
