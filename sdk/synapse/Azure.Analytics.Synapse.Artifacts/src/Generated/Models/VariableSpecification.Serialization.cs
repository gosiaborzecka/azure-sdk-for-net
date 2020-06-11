// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class VariableSpecification : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type.ToString());
            if (DefaultValue != null)
            {
                writer.WritePropertyName("defaultValue");
                writer.WriteObjectValue(DefaultValue);
            }
            writer.WriteEndObject();
        }

        internal static VariableSpecification DeserializeVariableSpecification(JsonElement element)
        {
            VariableType type = default;
            object defaultValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"))
                {
                    type = new VariableType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("defaultValue"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defaultValue = property.Value.GetObject();
                    continue;
                }
            }
            return new VariableSpecification(type, defaultValue);
        }
    }
}
