﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootlooseFS.Models
{
    public interface IFootlooseFSUnitOfWorkFactory
    {
        IFootlooseFSUnitOfWork CreateUnitOfWork();
    }
}