using System;
using System.Collections;

namespace nurl
{
	class Nurl
	{
		public enum NurlMode {
			NONE = 0,
			GET = 1,
			TEST = 2
		};

		NurlMode mode = NurlMode.NONE;
		Uri url = null;

		public static void Main (string[] args)
		{
			Console.WriteLine ("Hello World!");
		}
	}

	class ArgParser
	{
		Hashtable parseArgs(string[] args) {
			var ret = new Hashtable ();
			if (args == null) return ret;

			switch (args [0]) {
				case "get":
					ret ["mode"] = Nurl.NurlMode.GET;
					break;
				case "test":
					ret ["mode"] = Nurl.NurlMode.TEST;
					break;
				default:
					ret ["mode"] = Nurl.NurlMode.NONE;
					break;
			}
			return ret;
		}
	}
}