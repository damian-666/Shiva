﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiva
{
    public interface IConfigurationItem
    {
        List<IValidationRule> Rules { get; }
        List<string> Dependencies { get; }
    }
}
