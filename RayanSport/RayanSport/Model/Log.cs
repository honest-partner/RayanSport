using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RayanSport
{
    class Log
    {
        public long log_id { get; set; }
        public String log_description { get; set; }
        public String log_targetTable { get; set; }
        public String log_username { get; set; }
        public String log_date { get; set; }
        public String log_time { get; set; }
        public Log(long log_id, string log_description, string log_targetTable, string log_username, string log_date, string log_time)
        {
            this.log_id = log_id;
            this.log_description = log_description;
            this.log_targetTable = log_targetTable;
            this.log_username = log_username;
            this.log_date = log_date;
            this.log_time = log_time;
        }
    }
}
