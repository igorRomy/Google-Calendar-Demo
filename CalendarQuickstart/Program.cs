using CalendarQuickstart.Logic;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Calendar.v3;
using Google.Apis.Calendar.v3.Data;
using Google.Apis.PeopleService.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalendarQuickstart
{
	class Program
	{


		 static void Main(string[] args) {

			GService t = new GService();
			Calendarss c = new Calendarss();
			Calendarss.newCalendar("testName", "testloc", "testDes");
			Console.Read();


		}


	}

	}


	
