using System;

namespace Model
{
    public class AnularVentaRequest : CassRequest<AnularVentaResponse>
    {
        private string data { get; set; }
        public Tienda tienda;
        public Tarjeta tarjeta;

        public AnularVentaRequest(Operacion op)
        {
            tienda = op.getTienda();
            tarjeta = op.getTarjeta();
            
            this.data = tienda.getCliente()+";" + tienda.getTienda()+";" + tienda.getTpv()+";" + tienda.getOperario()+";" + tienda.getTicket()+";" + "11;"
            + op.getImporte()+";" + op.getNumOpCO()+";" + op.getNumOpBco()+";" + op.getCodAut();
        }
        public override AnularVentaResponse decodeResponse(string response)
        {
            return new AnularVentaResponse(response);
        }
        public string toString()
        {
            return this.data;
        }
    }
}
