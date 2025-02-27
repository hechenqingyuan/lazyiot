﻿using Temporal.Net.InfluxDb.Enums;

namespace Temporal.Net.InfluxDb.Models.Responses
{
    /// <summary>
    /// Represents one or more priveleges granted to a user for a particular database.
    /// </summary>
    public class Grant
    {
        /// <summary>
        /// The database name the granted privilege is for.
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// The granted privilege for the database.
        /// </summary>
        public Privileges Privilege { get; set; }
    }
}
