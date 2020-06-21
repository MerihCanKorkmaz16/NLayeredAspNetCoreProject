﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NLayeredProjectExample.MvcWebUI.Models.Security
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
