using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAttendance
{
    public delegate void banAlarm();
    class bannedUsernames
    {
        public event banAlarm alarm
        {
            add
            {
                alarm += new banAlarm(banMssg);
            }
            remove
            {
                alarm -= new banAlarm(banMssg);
            }
        }

        public void banMssg()
        {
            Console.WriteLine("You're banned from this organization!!");
        }
          
    }
}
