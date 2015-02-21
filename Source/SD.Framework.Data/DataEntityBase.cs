//-----------------------------------------------------------------------
// <copyright file="DataEntityBase.cs" company="SD">
//     Copyright (c) 2015. All rights reserved.
// </copyright>
// <author>Sergey Dzyuban</author>
//-----------------------------------------------------------------------
namespace SD.Framework.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Base class for entity object
    /// </summary>
    public class DataEntityBase
    {
        /// <summary>
        /// Gets or sets identity field. 
        /// </summary>
        public int Id { get; set; }
    }
}
