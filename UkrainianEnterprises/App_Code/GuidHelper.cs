using System;

namespace UkrainianEnterprises.App_Code
{
    /// <summary>
    /// Helper to manage Guids
    /// </summary>
    public static class GuidHelper
    {
        /// <summary>
        /// Parses the unique identifier.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns></returns>
        public static Guid GetGuid(string value)
        {
            var result = default(Guid);
            Guid.TryParse(value, out result);
            return result;
        }
    }
}