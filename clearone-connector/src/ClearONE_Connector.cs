using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;
using Model;
using Services;

namespace Clearone
{
	public class ClearONE_Connector
	{
		public ClearONE_Configuration config;
		public TcpClientService tcpClientService;
		
		public ClearONE_Connector(ClearONE_Configuration config)
		{
			this.config = config;
			this.tcpClientService = new TcpClientService(this.config);
		}
		public ClearONE_Configuration getConfig()
		{
			return this.config;
		}
		
		
		public string Venta(Operacion op)
		{
            try {
				VentaRequest myRequest = new VentaRequest( op );
				return tcpClientService.envioPeticionTcpClient( myRequest.toString() );
            }
			catch(Exception e) {
				Console.Write(e.ToString());
			}
			return "";
		}
		public string Devolucion(Operacion op)
		{
            try {
				DevolucionRequest myRequest = new DevolucionRequest( op );
				return tcpClientService.envioPeticionTcpClient( myRequest.toString() );
            }
			catch(Exception e) {
				Console.Write(e.ToString());
			}
			return "";
		}
		public string AnularVenta(Operacion op)
		{
            try {
				AnularVentaRequest myRequest = new AnularVentaRequest( op );
				return tcpClientService.envioPeticionTcpClient( myRequest.toString() );
            }
			catch(Exception e) {
				Console.Write(e.ToString());
			}
			return "";
		}
		public string AnularDevolucion(Operacion op)
		{
            try {
				AnularDevolucionRequest myRequest = new AnularDevolucionRequest( op );
				return tcpClientService.envioPeticionTcpClient( myRequest.toString() );
            }
			catch(Exception e) {
				Console.Write(e.ToString());
			}
			return "";
		}


	}
}

