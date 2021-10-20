using System;

namespace ErorrHandling.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public int Code { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
