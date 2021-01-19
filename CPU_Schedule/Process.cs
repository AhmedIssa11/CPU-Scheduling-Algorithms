using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPU_Schedule
{
    public class NewProcess
    {
        public string name { get; set; }
        public int ID { get; set; }
        public int time { get; set; }
        public int IO { get; set; }
        public int arrTime { get; set; }
        public string status { get; set; }
        public int quantum { get; set; }
        public int remainingTime { get; set; }

        public NewProcess()
        {
            name = "";
            ID = 0;
            time = 0;
            IO = 0;
            status = "Ready";
            remainingTime = 0;
            arrTime = 0;
        }
    }
}
