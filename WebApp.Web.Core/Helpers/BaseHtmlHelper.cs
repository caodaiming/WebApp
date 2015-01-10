using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WebApp.Web.Core.Helpers
{
    public class BaseHtmlHelper
    {
        private readonly HtmlHelper _html;
        private readonly UrlHelper _url;
        public BaseHtmlHelper(HtmlHelper html, UrlHelper url)
        {
            this._html = html;
            this._url = url;
        }

        protected HtmlHelper Html { get { return _html; } }

        protected UrlHelper Url { get { return _url; } }
    }
}
