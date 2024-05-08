using System;

namespace Model
{
    public class AnularDevolucionRequest : CassRequest<AnularDevolucionResponse>
    {
        private string data { get; set; }
        public Tienda tienda;
        public Tarjeta tarjeta;

        public AnularDevolucionRequest(Operacion op)
        {
            tienda = op.getTienda();
            tarjeta = op.getTarjeta();
            
            this.data = tienda.getCliente()+";" + tienda.getTienda()+";" + tienda.getTpv()+";" + tienda.getOperario()+";" + tienda.getTicket()+";" + "12;"
            + op.getImporte()+";" + op.getNumOpCO()+";" + op.getNumOpBco()+";" + op.getCodAut();
        }
        public override AnularDevolucionResponse decodeResponse(string response)
        {
            return new AnularDevolucionResponse(response);
        }
        public string toString()
        {
            return this.data;
        }

    }
}
