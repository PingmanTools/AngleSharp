﻿namespace AngleSharp
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    /// <summary>
    /// Represents the interface for a general setup of AngleSharp
    /// or a particular AngleSharp request.
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Gets the culture to use.
        /// </summary>
        CultureInfo Culture { get; }

        /// <summary>
        /// Gets an enumeration over the available services.
        /// </summary>
        IEnumerable<Object> Services { get; }
    }
}
