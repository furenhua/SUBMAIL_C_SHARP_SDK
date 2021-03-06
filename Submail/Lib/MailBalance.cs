﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Submail.AppConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Submail.Lib
{
	public class MailBalance : SendBase
	{


		public MailBalance(IAppConfig appConfig) : base(appConfig)
		{
		}

		protected override ISender GetSender()
		{
			return new Mail(_appConfig);
		}

		public string Balance(out string returnMessage)
		{
			return this.GetSender().Balance(_dataPair, out returnMessage);
		}
	}

}
