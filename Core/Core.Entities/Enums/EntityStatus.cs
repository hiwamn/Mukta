using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Enums
{
    public enum EntityStatus
    {
        [Display(Description = "غیر فعال")]
        Deactive = 0,
        [Display(Description = "فعال")]
        Active = 1,
        [Display(Description = "حذف شده")]
        Deleted = 2,
        [Display(Description = "رد شده")]
        Rejected = 3,
        [Display(Description = "در انتظار ارسال عکس")]
        WaitingToSendImage= 4,
        [Display(Description = "عکس ارسال شده")]
        ImageHasBeenSent = 5,
        [Display(Description = "عکس رد شده")]
        ImageHasBeenRejected = 6

    }
}
