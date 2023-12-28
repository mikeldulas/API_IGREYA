using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLibrary.Berita.Master
{
    class Logins
    {
        int Id { get; set; }
        int UserIdReff { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Role { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDate { get; set; }
        string UpdateBy { get; set; }
        DateTime UpdateDate { get; set; }
        bool Active { get; set; }

    }

    class HistoryLogins
    {
        int id { get; set; }
        int id_login { get; set; }
        string Username { get; set; }
        string Status { get; set; }
        DateTime Dates { get; set; }

    }
}
