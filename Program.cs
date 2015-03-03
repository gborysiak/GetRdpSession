using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TerminalTools;

namespace GetRdpSession
{
    class Program
    {
        static int Main(string[] args)
        {
            if( args.Length == 0 )
            {
                Console.Write("Error no arguments. Specify server name");
                return 1;
            }

            try
            {
                String serverName = args[0];
                List<TerminalSessionData> listSessions = TerminalTools.TermServicesManager.ListSessions(serverName);
                foreach (TerminalSessionData session in listSessions)
                {
                    TerminalSessionInfo info = TerminalTools.TermServicesManager.GetSessionInfo(serverName, session.SessionId);
                    if (info.UserName != null && ( info.UserName != null && info.UserName.Trim() != "" ) )
                    {
                        Console.WriteLine(session.SessionId + " " + info.UserName + " " + session.ConnectionState);
                    }
                }
                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 2;
            }
        }
    }
}
