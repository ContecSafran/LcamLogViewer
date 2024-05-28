using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LcamLogViewer.DTO
{
    public class LcamLog
    {
        public DateTime startTime;
        public DateTime endTime;
        public bool settingTime;
        public List<DateTime> timeList;
        public List<String> columnFilter;
        public List<String> currentColumn;
        public List<String> fileList;
    }
}
