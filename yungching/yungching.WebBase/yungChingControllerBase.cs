using System;
using System.Text;
using System.Web.Mvc;

namespace yungching.WebBase
{
    public class yungChingControllerBase : Controller
    {
        protected override JsonResult Json(object data, string contentType,
                  Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return new JsonNetResult()
            {
                Data = data,
                ContentType = contentType,
                ContentEncoding = contentEncoding
            };
        }
    }
}