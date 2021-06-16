using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UploadFileInNestedGridPopupEditor.ViewModels
{
    public class BidVM
    {
        public int BidProfileId { get; set; }
        public string BidNumber { get; set; }
        public string BidTitle { get; set; }
        public DateTime BidBeginDate { get; set; }
        public DateTime BidClosingDate { get; set; }

    }
}
