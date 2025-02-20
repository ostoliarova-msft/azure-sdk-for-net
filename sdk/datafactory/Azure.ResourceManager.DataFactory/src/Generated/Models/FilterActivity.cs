// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Filter and return results from input array based on the conditions. </summary>
    public partial class FilterActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of FilterActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="items"> Input array on which filter should be applied. </param>
        /// <param name="condition"> Condition to be used for filtering the input. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="items"/> or <paramref name="condition"/> is null. </exception>
        public FilterActivity(string name, FactoryExpressionDefinition items, FactoryExpressionDefinition condition) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(items, nameof(items));
            Argument.AssertNotNull(condition, nameof(condition));

            Items = items;
            Condition = condition;
            ActivityType = "Filter";
        }

        /// <summary> Initializes a new instance of FilterActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="items"> Input array on which filter should be applied. </param>
        /// <param name="condition"> Condition to be used for filtering the input. </param>
        internal FilterActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, FactoryExpressionDefinition items, FactoryExpressionDefinition condition) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            Items = items;
            Condition = condition;
            ActivityType = activityType ?? "Filter";
        }

        /// <summary> Input array on which filter should be applied. </summary>
        public FactoryExpressionDefinition Items { get; set; }
        /// <summary> Condition to be used for filtering the input. </summary>
        public FactoryExpressionDefinition Condition { get; set; }
    }
}
