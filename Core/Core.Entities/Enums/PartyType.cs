using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Enums
{
    public enum PartyType
    {
        [Display(Description = "Direct Dealer")]
        Image = 1,
        [Display(Description = "Dealer Account")]
        Video = 2,
        [Display(Description = "Distributor")]
        Document = 3

    }
}
