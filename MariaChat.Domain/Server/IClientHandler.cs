﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MariaChat.Domain.Server
{
    public interface IClientHandler
    {
        public IClientHandler GetInstance();
    }
}