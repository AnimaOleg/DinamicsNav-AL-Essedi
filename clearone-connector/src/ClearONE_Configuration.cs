using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;

namespace Clearone
{
	// environment
	[Flags]
	public enum environment
	{
		proves      = 0,
		productiu    = 1,
	}
	
	public class ClearONE_Configuration
	{
		public environment environment;
		public int port;
		public int PORT_DEV = 8890;
		public int PORT_PROD = 8890;
		public string SERVER_IP = "127.0.0.1";
		public int timeout = 30;

		public ClearONE_Configuration(environment env)
		{
			this.environment = env;

			if(env == environment.proves) {
				this.port = PORT_DEV; 
			}else if(env == environment.productiu) {
				this.port = PORT_PROD;
			}
		}

		public environment getEnvironment() {
			return this.environment;
		}
		public string getServerIP() {
			return this.SERVER_IP;
		}
		public int getServerPORT() {
			return this.port;
		}
		public int getTimeOut(){
			return this.timeout;
		}

	}
}

