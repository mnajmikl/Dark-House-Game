/* 
 * DarkHouse
 * Horror Exploration Game
 * Copyright (c) 2019 Mohammad Najmi
 */

using System.ComponentModel;

namespace DarkHouse
{
    /// <summary>
    /// MeasurementUnits enum
    /// </summary>
    /// <remarks>Measurement units</remarks>
    enum MeasurementUnits : int 
    {
        /// <summary>Metric (0)</summary>
        /// <remarks>Measurement unit is metric (meter)</remarks>
        [Description("Metric")]
        Metrics = 0,
        /// <summary>Imperial (1)</summary>
        /// <remarks>Measurement unit is imperial (feet)</remarks>
        [Description("Imperial")]
        Imperial = 1
    }
}