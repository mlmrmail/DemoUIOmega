using System;
using System.Collections.Generic;
using System.Text;

namespace DemoUIOmega.Entities.Models.Errors
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
