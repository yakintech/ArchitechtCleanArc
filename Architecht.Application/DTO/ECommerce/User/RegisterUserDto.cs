﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Application.DTO
{
    public class RegisterUserDto
    {
        public string EMail { get; set; }
        public string Password { get; set; }

        public string ConfirmPassword { get; set; }
    }
}