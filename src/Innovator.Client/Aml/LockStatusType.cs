﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Innovator.Client
{
  /// <summary>
  /// The lock status of the item
  /// </summary>
  public enum LockStatusType
  {
    /// <summary>
    /// The item is not locked
    /// </summary>
    NotLocked,
    /// <summary>
    /// The item is locked by user currently connected to Aras
    /// </summary>
    LockedByUser,
    /// <summary>
    /// The item is locked by a user other than the one currently connected to Aras
    /// </summary>
    LockedByOther
  }
}
