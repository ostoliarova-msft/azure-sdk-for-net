// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ActiveDefaultSecurityAdminRule
    {
        internal static ActiveDefaultSecurityAdminRule DeserializeActiveDefaultSecurityAdminRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<DateTimeOffset> commitTime = default;
            Optional<string> region = default;
            Optional<string> configurationDescription = default;
            Optional<string> ruleCollectionDescription = default;
            Optional<IReadOnlyList<NetworkManagerSecurityGroupItem>> ruleCollectionAppliesToGroups = default;
            Optional<IReadOnlyList<NetworkConfigurationGroup>> ruleGroups = default;
            EffectiveAdminRuleKind kind = default;
            Optional<string> description = default;
            Optional<string> flag = default;
            Optional<SecurityConfigurationRuleProtocol> protocol = default;
            Optional<IReadOnlyList<AddressPrefixItem>> sources = default;
            Optional<IReadOnlyList<AddressPrefixItem>> destinations = default;
            Optional<IReadOnlyList<string>> sourcePortRanges = default;
            Optional<IReadOnlyList<string>> destinationPortRanges = default;
            Optional<SecurityConfigurationRuleAccess> access = default;
            Optional<int> priority = default;
            Optional<SecurityConfigurationRuleDirection> direction = default;
            Optional<NetworkProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("commitTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commitTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("configurationDescription"u8))
                {
                    configurationDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionDescription"u8))
                {
                    ruleCollectionDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ruleCollectionAppliesToGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkManagerSecurityGroupItem> array = new List<NetworkManagerSecurityGroupItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkManagerSecurityGroupItem.DeserializeNetworkManagerSecurityGroupItem(item));
                    }
                    ruleCollectionAppliesToGroups = array;
                    continue;
                }
                if (property.NameEquals("ruleGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetworkConfigurationGroup> array = new List<NetworkConfigurationGroup>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetworkConfigurationGroup.DeserializeNetworkConfigurationGroup(item));
                    }
                    ruleGroups = array;
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new EffectiveAdminRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("flag"u8))
                        {
                            flag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new SecurityConfigurationRuleProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sources"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AddressPrefixItem> array = new List<AddressPrefixItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AddressPrefixItem.DeserializeAddressPrefixItem(item));
                            }
                            sources = array;
                            continue;
                        }
                        if (property0.NameEquals("destinations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AddressPrefixItem> array = new List<AddressPrefixItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AddressPrefixItem.DeserializeAddressPrefixItem(item));
                            }
                            destinations = array;
                            continue;
                        }
                        if (property0.NameEquals("sourcePortRanges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            sourcePortRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("destinationPortRanges"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            destinationPortRanges = array;
                            continue;
                        }
                        if (property0.NameEquals("access"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            access = new SecurityConfigurationRuleAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("priority"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            priority = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("direction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            direction = new SecurityConfigurationRuleDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ActiveDefaultSecurityAdminRule(id.Value, Optional.ToNullable(commitTime), region.Value, configurationDescription.Value, ruleCollectionDescription.Value, Optional.ToList(ruleCollectionAppliesToGroups), Optional.ToList(ruleGroups), kind, description.Value, flag.Value, Optional.ToNullable(protocol), Optional.ToList(sources), Optional.ToList(destinations), Optional.ToList(sourcePortRanges), Optional.ToList(destinationPortRanges), Optional.ToNullable(access), Optional.ToNullable(priority), Optional.ToNullable(direction), Optional.ToNullable(provisioningState));
        }
    }
}
