﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Microplate
{
    /// <summary>
    /// Predefined plate formats and factory methods.
    /// </summary>
    public static class Formats
    {
        /// <summary>
        /// Few defined standard formats: 96-well, 386-well,
        /// 
        /// NOTE: Position naming is set to <see cref="PositionNamings.Default"/>
        /// </summary>
        public static readonly Dictionary<string, Format> Defined = new Dictionary<string, Format>()
                                                              {
                                                                  {"96-well", new Format(8, 12, PositionNamings.Default, "96-well")},
                                                                  {"384-well", new Format(16, 24, PositionNamings.Default, "384-well")},
                                                              };
        /// <summary>
        /// Not a plate but a queue of tubes
        /// </summary>
        /// <param name="n">The number of tubes.</param>
        /// <returns></returns>
        public static Format SingleTubes(int n)
        {
            return new Format(1, n, PositionNamings.Default, String.Format("Single tubes ({0})", n));
        }

        /// <summary>
        /// Gets the default 4x4 format for testing.
        /// </summary>
        public static Format Default
        {
            get { return new Format(4, 4, PositionNamings.Default); }
        }
    }
}
