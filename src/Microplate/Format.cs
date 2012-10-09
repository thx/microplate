﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Microplate
{
    /// <summary>
    /// Container for plate format parameters. Used in <see cref="Format"/>.
    /// </summary>
    public struct Format
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Format"/> struct.
        /// </summary>
        /// <param name="height">The height.</param>
        /// <param name="width">The width.</param>
        /// <param name="defaultNaming">The default position naming naming.</param>
        public Format(int height, int width, IPositionNaming defaultNaming)
        {
            Height = height;
            Width = width;
            PositionNaming = defaultNaming;
        }

        /// <summary>
        /// Width of the plate using this format.
        /// </summary>
        public int Width;


        /// <summary>
        /// Height of the plate using this format.
        /// </summary>
        public int Height;

        /// <summary>
        /// Default position naming for this format.
        /// </summary>
        public IPositionNaming PositionNaming;

        public bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}
