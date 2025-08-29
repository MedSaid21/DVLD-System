using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess
{
    internal class MyEventLog 
    {

        private string _sourceName;
        /*public MyEventLog(string sourceName)
        {
            _sourceName = sourceName;

            // Create the event source if it does not exist
            if (!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
                //Console.WriteLine("Event source created.");
            }
        }*/

        public static void CreateEvent(string EventInfo , EventLogEntryType eventLogEntryType)
        {
            string sourceName = "DVLD";
            try
            {
                if (!EventLog.SourceExists(sourceName))
                {
                    EventLog.CreateEventSource(sourceName, "Application");
                    //Console.WriteLine("Event source created.");
                }

                EventLog.WriteEntry(sourceName, EventInfo, eventLogEntryType);
            }catch(Exception e)
            {
                //EventLog.WriteEntry(sourceName,e.ToString(), EventLogEntryType.Error);

            }

        }

       







       


    }
}
