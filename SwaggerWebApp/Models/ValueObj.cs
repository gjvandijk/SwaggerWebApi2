using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SwaggerWebApp.Models
{
    /// <summary>
    /// Object containing string value
    /// </summary>
    public class ValueObj

    {
        /// <summary>
        /// string value
        /// </summary>
        public string Value { get; set; }

        public ValueObj(string value)
        {
            Value = value;
        }
    }
}