using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WulkanizacjaOpony.Infrastructure
{
    public static class UrlHelpers
    {
        public static string TireImagePath(this UrlHelper helper, string tireFilename)
        {
            var albumTiresFolder = AppConfig.PhotosFolderRelative;
            var path = Path.Combine(albumTiresFolder, tireFilename);
            var absolutePath = helper.Content(path);
            return absolutePath;
        }
    }
}