﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Innovator.Client.Connection
{
  public interface IVaultFactory
  {
    Vault GetVault(IReadOnlyItem i);
  }
}
