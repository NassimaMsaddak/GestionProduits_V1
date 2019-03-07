using System;

namespace MyCat_BaseDeArchitectureDotNet_ASP_Net_Core_MVC6.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}