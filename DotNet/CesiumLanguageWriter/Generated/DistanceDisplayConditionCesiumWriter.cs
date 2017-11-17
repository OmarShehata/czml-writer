// <auto-generated>
// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer
// </auto-generated>

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>DistanceDisplayCondition</c> to a <see cref="CesiumOutputStream" />.  A <c>DistanceDisplayCondition</c> is indicates the visibility of an object based on the distance to the camera.
    /// </summary>
    public class DistanceDisplayConditionCesiumWriter : CesiumInterpolatablePropertyWriter<DistanceDisplayConditionCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>distanceDisplayCondition</c> property.
        /// </summary>
        public const string DistanceDisplayConditionPropertyName = "distanceDisplayCondition";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        private readonly Lazy<ICesiumInterpolatableValuePropertyWriter<Bounds>> m_asDistanceDisplayCondition;
        private readonly Lazy<ICesiumValuePropertyWriter<Reference>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public DistanceDisplayConditionCesiumWriter(string propertyName)
            : base(propertyName)
        {
            m_asDistanceDisplayCondition = new Lazy<ICesiumInterpolatableValuePropertyWriter<Bounds>>(CreateDistanceDisplayConditionAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected DistanceDisplayConditionCesiumWriter(DistanceDisplayConditionCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asDistanceDisplayCondition = new Lazy<ICesiumInterpolatableValuePropertyWriter<Bounds>>(CreateDistanceDisplayConditionAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
        }

        /// <inheritdoc />
        public override DistanceDisplayConditionCesiumWriter Clone()
        {
            return new DistanceDisplayConditionCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>distanceDisplayCondition</c>, which is the value specified as two values <c>[NearDistance, FarDistance]</c>, with distances in meters.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDistanceDisplayCondition(Bounds value)
        {
            const string PropertyName = DistanceDisplayConditionPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteBounds(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>distanceDisplayCondition</c>, which is the value specified as two values <c>[NearDistance, FarDistance]</c>, with distances in meters.
        /// </summary>
        /// <param name="lowerBound">The lower bound.</param>
        /// <param name="upperBound">The upper bound.</param>
        public void WriteDistanceDisplayCondition(double lowerBound, double upperBound)
        {
            WriteDistanceDisplayCondition(new Bounds(lowerBound, upperBound));
        }

        /// <summary>
        /// Writes the value expressed as a <c>distanceDisplayCondition</c>, which is the value specified as two values <c>[NearDistance, FarDistance]</c>, with distances in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteDistanceDisplayCondition(IList<JulianDate> dates, IList<Bounds> values)
        {
            WriteDistanceDisplayCondition(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>distanceDisplayCondition</c>, which is the value specified as two values <c>[NearDistance, FarDistance]</c>, with distances in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteDistanceDisplayCondition(IList<JulianDate> dates, IList<Bounds> values, int startIndex, int length)
        {
            const string PropertyName = DistanceDisplayConditionPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteBounds(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the value specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumInterpolatableValuePropertyWriter{T}" /> to write a value in <c>DistanceDisplayCondition</c> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumInterpolatableValuePropertyWriter<Bounds> AsDistanceDisplayCondition()
        {
            return m_asDistanceDisplayCondition.Value;
        }

        private ICesiumInterpolatableValuePropertyWriter<Bounds> CreateDistanceDisplayConditionAdaptor()
        {
            return new CesiumInterpolatableWriterAdaptor<DistanceDisplayConditionCesiumWriter, Bounds>(this, (me, value) => me.WriteDistanceDisplayCondition(value), (me, dates, values, startIndex, length) => me.WriteDistanceDisplayCondition(dates, values, startIndex, length));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumValuePropertyWriter{T}" /> to write a value in <c>Reference</c> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumValuePropertyWriter<Reference> AsReference()
        {
            return m_asReference.Value;
        }

        private ICesiumValuePropertyWriter<Reference> CreateReferenceAdaptor()
        {
            return new CesiumWriterAdaptor<DistanceDisplayConditionCesiumWriter, Reference>(this, (me, value) => me.WriteReference(value));
        }

    }
}
