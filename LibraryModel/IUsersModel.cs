﻿using LibraryLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryModel
{
    public interface IUsersModel
    {
        public int userId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
