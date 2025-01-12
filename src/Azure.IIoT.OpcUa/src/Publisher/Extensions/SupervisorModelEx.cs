// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Azure.IIoT.OpcUa.Publisher.Models
{
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Service model extensions for discovery service
    /// </summary>
    public static class SupervisorModelEx
    {
        /// <summary>
        /// Equality comparison
        /// </summary>
        /// <param name="model"></param>
        /// <param name="that"></param>
        /// <returns></returns>
        public static bool IsSameAs(this IEnumerable<SupervisorModel> model,
            IEnumerable<SupervisorModel> that)
        {
            if (model == that)
            {
                return true;
            }
            if (model == null || that == null)
            {
                return false;
            }
            if (model.Count() != that.Count())
            {
                return false;
            }
            return model.All(a => that.Any(b => b.IsSameAs(a)));
        }

        /// <summary>
        /// Equality comparison
        /// </summary>
        /// <param name="model"></param>
        /// <param name="that"></param>
        /// <returns></returns>
        public static bool IsSameAs(this SupervisorModel model,
            SupervisorModel that)
        {
            if (model == that)
            {
                return true;
            }
            if (model == null || that == null)
            {
                return false;
            }
            return that.Id == model.Id;
        }
    }
}
