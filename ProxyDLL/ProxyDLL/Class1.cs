using CefSharp.OffScreen;
using System;
using System.IO;

namespace ProxyDLL
{
    public class Class1
    {
        public CefSettings Test() => new CefSettings()
        {
            //By default CefSharp will use an in-memory cache, you need to specify a Cache Folder to persist data
            CachePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CefSharp\\Cache")
        };
    }
}
