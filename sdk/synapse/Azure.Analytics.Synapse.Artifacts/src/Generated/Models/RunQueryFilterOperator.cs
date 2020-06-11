// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Operator to be used for filter. </summary>
    public readonly partial struct RunQueryFilterOperator : IEquatable<RunQueryFilterOperator>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="RunQueryFilterOperator"/> values are the same. </summary>
        public RunQueryFilterOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualsValueValue = "Equals";
        private const string NotEqualsValue = "NotEquals";
        private const string InValue = "In";
        private const string NotInValue = "NotIn";

        /// <summary> Equals. </summary>
        public static RunQueryFilterOperator EqualsValue { get; } = new RunQueryFilterOperator(EqualsValueValue);
        /// <summary> NotEquals. </summary>
        public static RunQueryFilterOperator NotEquals { get; } = new RunQueryFilterOperator(NotEqualsValue);
        /// <summary> In. </summary>
        public static RunQueryFilterOperator In { get; } = new RunQueryFilterOperator(InValue);
        /// <summary> NotIn. </summary>
        public static RunQueryFilterOperator NotIn { get; } = new RunQueryFilterOperator(NotInValue);
        /// <summary> Determines if two <see cref="RunQueryFilterOperator"/> values are the same. </summary>
        public static bool operator ==(RunQueryFilterOperator left, RunQueryFilterOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RunQueryFilterOperator"/> values are not the same. </summary>
        public static bool operator !=(RunQueryFilterOperator left, RunQueryFilterOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RunQueryFilterOperator"/>. </summary>
        public static implicit operator RunQueryFilterOperator(string value) => new RunQueryFilterOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RunQueryFilterOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RunQueryFilterOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
