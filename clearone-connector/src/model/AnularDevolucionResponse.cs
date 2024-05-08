using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Model
{
    public class AnularDevolucionResponse  : CassResponse<string>
    {
        public AnularDevolucionResponse(string data) : base(data) { }
    }
}
