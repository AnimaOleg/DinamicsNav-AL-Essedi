using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Model
{
    public class AnularVentaResponse  : CassResponse<string>
    {
        public AnularVentaResponse(string data) : base(data) { }
    }
}
