using Microsoft.AspNetCore.Mvc.Razor;
using System;

namespace DevIO.App.Extensions
{
    public static class RazorExtensions
    {
        public static string FormataDocumento(this RazorPage _, int tipoDoc, string documento)
        {
            return tipoDoc == 1 ?
                  Convert.ToUInt64(documento).ToString(@"000\.000\.000\-00") :
                  Convert.ToUInt64(documento).ToString(@"00\.000\.000\/0000\-00");
        }
    }
}
