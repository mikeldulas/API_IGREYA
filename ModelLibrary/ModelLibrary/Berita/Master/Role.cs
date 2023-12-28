using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Berita.Master
{
    class Roles
    {
        int Id {get;set;}
        string Role { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string UpdateBy { get; set; }
        DateTime UpdateDate { get; set; }

    }

}
