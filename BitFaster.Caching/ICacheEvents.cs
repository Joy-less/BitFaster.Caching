﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitFaster.Caching
{
    /// <summary>
    /// Represents the events that fire when actions are performed on the cache.
    /// </summary>
    public interface ICacheEvents<K, V>
    {
        /// <summary>
        /// Occurs when an item is removed from the cache.
        /// </summary>
        event EventHandler<ItemRemovedEventArgs<K, V>> ItemRemoved;
    }
}
