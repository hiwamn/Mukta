using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Enums
{
    public enum Roles
    {
        [Display(Description = "کاربر")]
        User = 1,
        [Display(Description = "ادمین")]
        Admin = 2,
      
    }
}
