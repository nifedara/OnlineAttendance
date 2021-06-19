using System;

namespace OnlineAttendance
{
    class Program
    {
		static void Main()
        {
            welcome mssg = new();
            string username = mssg.showUsername();

            if (username ==  "Jack")
            {
                bannedUsernames banneduser = new();
                banAlarm callDelegate = banneduser.banMssg;
                callDelegate();

            }
            else if (username == "Steven")
            {
                bannedUsernames banneduser = new();
                banAlarm callDelegate = banneduser.banMssg;
                callDelegate();
            }
            else if (username == "Matthew")
            {
                bannedUsernames banneduser = new();
                banAlarm callDelegate = banneduser.banMssg;
                callDelegate();
            }
            else
            {
                Console.WriteLine("Welcome {0}!", username);
            }

        }
	}
}
