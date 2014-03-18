﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenCvSharp.CPlusPlus
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class MatRowColIndexer
    {
        /// <summary>
        /// 
        /// </summary>
        protected readonly Mat parent;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="parent"></param>
        protected internal MatRowColIndexer(Mat parent)
        {
            this.parent = parent;
        }

        /// <summary>
        /// Creates a matrix header for the specified matrix row/column.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public abstract Mat this[int pos] { get; }

        /// <summary>
        /// Creates a matrix header for the specified row/column span.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public abstract Mat this[int start, int end] { get; }

        /// <summary>
        /// Creates a matrix header for the specified row/column span.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public virtual Mat this[Range range]
        {
            get { return this[range.Start, range.End]; }
        }

        /// <summary>
        /// Creates a matrix header for the specified matrix row/column.
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public Mat Get(int pos)
        {
            return this[pos];
        }
        /// <summary>
        /// Creates a matrix header for the specified row/column span.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public MatExpr Get(int start, int end)
        {
            return this[start, end];
        }
        /// <summary>
        /// Creates a matrix header for the specified row/column span.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public MatExpr Get(Range range)
        {
            return this[range];
        }

    }
}
