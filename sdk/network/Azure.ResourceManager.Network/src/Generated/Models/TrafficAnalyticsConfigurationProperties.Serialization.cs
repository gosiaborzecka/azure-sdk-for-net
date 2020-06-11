// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TrafficAnalyticsConfigurationProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Enabled != null)
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (WorkspaceId != null)
            {
                writer.WritePropertyName("workspaceId");
                writer.WriteStringValue(WorkspaceId);
            }
            if (WorkspaceRegion != null)
            {
                writer.WritePropertyName("workspaceRegion");
                writer.WriteStringValue(WorkspaceRegion);
            }
            if (WorkspaceResourceId != null)
            {
                writer.WritePropertyName("workspaceResourceId");
                writer.WriteStringValue(WorkspaceResourceId);
            }
            if (TrafficAnalyticsInterval != null)
            {
                writer.WritePropertyName("trafficAnalyticsInterval");
                writer.WriteNumberValue(TrafficAnalyticsInterval.Value);
            }
            writer.WriteEndObject();
        }

        internal static TrafficAnalyticsConfigurationProperties DeserializeTrafficAnalyticsConfigurationProperties(JsonElement element)
        {
            bool? enabled = default;
            string workspaceId = default;
            string workspaceRegion = default;
            string workspaceResourceId = default;
            int? trafficAnalyticsInterval = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("workspaceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceRegion"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceRegion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workspaceResourceId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trafficAnalyticsInterval"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficAnalyticsInterval = property.Value.GetInt32();
                    continue;
                }
            }
            return new TrafficAnalyticsConfigurationProperties(enabled, workspaceId, workspaceRegion, workspaceResourceId, trafficAnalyticsInterval);
        }
    }
}
