// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Box</c> to a <see cref="CesiumOutputStream" />.  A <c>Box</c> is a box, which is a closed rectangular cuboid.
    /// </summary>
    public class BoxCesiumWriter : CesiumPropertyWriter<BoxCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>show</c> property.
        /// </summary>
        public const string ShowPropertyName = "show";

        /// <summary>
        /// The name of the <c>dimensions</c> property.
        /// </summary>
        public const string DimensionsPropertyName = "dimensions";

        /// <summary>
        /// The name of the <c>fill</c> property.
        /// </summary>
        public const string FillPropertyName = "fill";

        /// <summary>
        /// The name of the <c>material</c> property.
        /// </summary>
        public const string MaterialPropertyName = "material";

        /// <summary>
        /// The name of the <c>outline</c> property.
        /// </summary>
        public const string OutlinePropertyName = "outline";

        /// <summary>
        /// The name of the <c>outlineColor</c> property.
        /// </summary>
        public const string OutlineColorPropertyName = "outlineColor";

        /// <summary>
        /// The name of the <c>outlineWidth</c> property.
        /// </summary>
        public const string OutlineWidthPropertyName = "outlineWidth";

        /// <summary>
        /// The name of the <c>shadows</c> property.
        /// </summary>
        public const string ShadowsPropertyName = "shadows";

        private readonly Lazy<BooleanCesiumWriter> m_show = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(ShowPropertyName), false);
        private readonly Lazy<BoxDimensionsCesiumWriter> m_dimensions = new Lazy<BoxDimensionsCesiumWriter>(() => new BoxDimensionsCesiumWriter(DimensionsPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_fill = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(FillPropertyName), false);
        private readonly Lazy<MaterialCesiumWriter> m_material = new Lazy<MaterialCesiumWriter>(() => new MaterialCesiumWriter(MaterialPropertyName), false);
        private readonly Lazy<BooleanCesiumWriter> m_outline = new Lazy<BooleanCesiumWriter>(() => new BooleanCesiumWriter(OutlinePropertyName), false);
        private readonly Lazy<ColorCesiumWriter> m_outlineColor = new Lazy<ColorCesiumWriter>(() => new ColorCesiumWriter(OutlineColorPropertyName), false);
        private readonly Lazy<DoubleCesiumWriter> m_outlineWidth = new Lazy<DoubleCesiumWriter>(() => new DoubleCesiumWriter(OutlineWidthPropertyName), false);
        private readonly Lazy<ShadowModeCesiumWriter> m_shadows = new Lazy<ShadowModeCesiumWriter>(() => new ShadowModeCesiumWriter(ShadowsPropertyName), false);

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public BoxCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected BoxCesiumWriter(BoxCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override BoxCesiumWriter Clone()
        {
            return new BoxCesiumWriter(this);
        }

        /// <summary>
        /// Gets the writer for the <c>show</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>show</c> property defines whether or not the box is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter ShowWriter
        {
            get { return m_show.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>show</c> property.  The <c>show</c> property defines whether or not the box is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenShowProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShowWriter);
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>boolean</c> value.  The <c>show</c> property specifies whether or not the box is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteShowProperty(bool value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the box is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShowPropertyReference(Reference value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the box is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShowPropertyReference(string value)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the box is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>show</c> property as a <c>reference</c> value.  The <c>show</c> property specifies whether or not the box is shown.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShowPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShowProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>dimensions</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>dimensions</c> property defines the dimensions of the box.
        /// </summary>
        public BoxDimensionsCesiumWriter DimensionsWriter
        {
            get { return m_dimensions.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>dimensions</c> property.  The <c>dimensions</c> property defines the dimensions of the box.
        /// </summary>
        public BoxDimensionsCesiumWriter OpenDimensionsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(DimensionsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>dimensions</c> property as a <c>cartesian</c> value.  The <c>dimensions</c> property specifies the dimensions of the box.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteDimensionsProperty(Cartesian value)
        {
            using (var writer = OpenDimensionsProperty())
            {
                writer.WriteCartesian(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>dimensions</c> property as a <c>cartesian</c> value.  The <c>dimensions</c> property specifies the dimensions of the box.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteDimensionsProperty(IList<JulianDate> dates, IList<Cartesian> values)
        {
            using (var writer = OpenDimensionsProperty())
            {
                writer.WriteCartesian(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>dimensions</c> property as a <c>cartesian</c> value.  The <c>dimensions</c> property specifies the dimensions of the box.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteDimensionsProperty(IList<JulianDate> dates, IList<Cartesian> values, int startIndex, int length)
        {
            using (var writer = OpenDimensionsProperty())
            {
                writer.WriteCartesian(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>dimensions</c> property as a <c>reference</c> value.  The <c>dimensions</c> property specifies the dimensions of the box.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteDimensionsPropertyReference(Reference value)
        {
            using (var writer = OpenDimensionsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>dimensions</c> property as a <c>reference</c> value.  The <c>dimensions</c> property specifies the dimensions of the box.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteDimensionsPropertyReference(string value)
        {
            using (var writer = OpenDimensionsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>dimensions</c> property as a <c>reference</c> value.  The <c>dimensions</c> property specifies the dimensions of the box.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteDimensionsPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenDimensionsProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>dimensions</c> property as a <c>reference</c> value.  The <c>dimensions</c> property specifies the dimensions of the box.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteDimensionsPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenDimensionsProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>fill</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>fill</c> property defines whether or not the box is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter FillWriter
        {
            get { return m_fill.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>fill</c> property.  The <c>fill</c> property defines whether or not the box is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        public BooleanCesiumWriter OpenFillProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(FillWriter);
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>boolean</c> value.  The <c>fill</c> property specifies whether or not the box is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteFillProperty(bool value)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>reference</c> value.  The <c>fill</c> property specifies whether or not the box is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteFillPropertyReference(Reference value)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>reference</c> value.  The <c>fill</c> property specifies whether or not the box is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteFillPropertyReference(string value)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>reference</c> value.  The <c>fill</c> property specifies whether or not the box is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteFillPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>fill</c> property as a <c>reference</c> value.  The <c>fill</c> property specifies whether or not the box is filled.  If not specified, the default value is <see langword="true"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteFillPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenFillProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>material</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>material</c> property defines the material to display on the surface of the box.
        /// </summary>
        public MaterialCesiumWriter MaterialWriter
        {
            get { return m_material.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>material</c> property.  The <c>material</c> property defines the material to display on the surface of the box.
        /// </summary>
        public MaterialCesiumWriter OpenMaterialProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(MaterialWriter);
        }

        /// <summary>
        /// Gets the writer for the <c>outline</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>outline</c> property defines whether or not the box is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        public BooleanCesiumWriter OutlineWriter
        {
            get { return m_outline.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>outline</c> property.  The <c>outline</c> property defines whether or not the box is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        public BooleanCesiumWriter OpenOutlineProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(OutlineWriter);
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>boolean</c> value.  The <c>outline</c> property specifies whether or not the box is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteOutlineProperty(bool value)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteBoolean(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>reference</c> value.  The <c>outline</c> property specifies whether or not the box is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteOutlinePropertyReference(Reference value)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>reference</c> value.  The <c>outline</c> property specifies whether or not the box is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteOutlinePropertyReference(string value)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>reference</c> value.  The <c>outline</c> property specifies whether or not the box is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteOutlinePropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outline</c> property as a <c>reference</c> value.  The <c>outline</c> property specifies whether or not the box is outlined.  If not specified, the default value is <see langword="false"/>.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteOutlinePropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenOutlineProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>outlineColor</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>outlineColor</c> property defines the color of the box outline.
        /// </summary>
        public ColorCesiumWriter OutlineColorWriter
        {
            get { return m_outlineColor.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>outlineColor</c> property.  The <c>outlineColor</c> property defines the color of the box outline.
        /// </summary>
        public ColorCesiumWriter OpenOutlineColorProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(OutlineColorWriter);
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgba</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteOutlineColorProperty(Color color)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgba(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgba</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 255.</param>
        /// <param name="green">The green component in the range 0 to 255.</param>
        /// <param name="blue">The blue component in the range 0 to 255.</param>
        /// <param name="alpha">The alpha component in the range 0 to 255.</param>
        public void WriteOutlineColorProperty(int red, int green, int blue, int alpha)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgba(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgba</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteOutlineColorProperty(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgba(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgba</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteOutlineColorProperty(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgba(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgbaf</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="color">The color.</param>
        public void WriteOutlineColorPropertyRgbaf(Color color)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgbaf(color);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgbaf</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="red">The red component in the range 0 to 1.0.</param>
        /// <param name="green">The green component in the range 0 to 1.0.</param>
        /// <param name="blue">The blue component in the range 0 to 1.0.</param>
        /// <param name="alpha">The alpha component in the range 0 to 1.0.</param>
        public void WriteOutlineColorPropertyRgbaf(float red, float green, float blue, float alpha)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgbaf(red, green, blue, alpha);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgbaf</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteOutlineColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> values)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgbaf(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>rgbaf</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="colors">The color corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteOutlineColorPropertyRgbaf(IList<JulianDate> dates, IList<Color> colors, int startIndex, int length)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteRgbaf(dates, colors, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>reference</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteOutlineColorPropertyReference(Reference value)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>reference</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteOutlineColorPropertyReference(string value)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>reference</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteOutlineColorPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineColor</c> property as a <c>reference</c> value.  The <c>outlineColor</c> property specifies the color of the box outline.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteOutlineColorPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenOutlineColorProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>outlineWidth</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>outlineWidth</c> property defines the width of the box outline.  If not specified, the default value is 1.0.
        /// </summary>
        public DoubleCesiumWriter OutlineWidthWriter
        {
            get { return m_outlineWidth.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>outlineWidth</c> property.  The <c>outlineWidth</c> property defines the width of the box outline.  If not specified, the default value is 1.0.
        /// </summary>
        public DoubleCesiumWriter OpenOutlineWidthProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(OutlineWidthWriter);
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>number</c> value.  The <c>outlineWidth</c> property specifies the width of the box outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteOutlineWidthProperty(double value)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteNumber(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>number</c> value.  The <c>outlineWidth</c> property specifies the width of the box outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteOutlineWidthProperty(IList<JulianDate> dates, IList<double> values)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteNumber(dates, values);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>number</c> value.  The <c>outlineWidth</c> property specifies the width of the box outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The value corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteOutlineWidthProperty(IList<JulianDate> dates, IList<double> values, int startIndex, int length)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteNumber(dates, values, startIndex, length);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>reference</c> value.  The <c>outlineWidth</c> property specifies the width of the box outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteOutlineWidthPropertyReference(Reference value)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>reference</c> value.  The <c>outlineWidth</c> property specifies the width of the box outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteOutlineWidthPropertyReference(string value)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>reference</c> value.  The <c>outlineWidth</c> property specifies the width of the box outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteOutlineWidthPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>outlineWidth</c> property as a <c>reference</c> value.  The <c>outlineWidth</c> property specifies the width of the box outline.  If not specified, the default value is 1.0.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteOutlineWidthPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenOutlineWidthProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

        /// <summary>
        /// Gets the writer for the <c>shadows</c> property.  The returned instance must be opened by calling the <see cref="CesiumElementWriter.Open"/> method before it can be used for writing.  The <c>shadows</c> property defines whether or not the box casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        public ShadowModeCesiumWriter ShadowsWriter
        {
            get { return m_shadows.Value; }
        }

        /// <summary>
        /// Opens and returns the writer for the <c>shadows</c> property.  The <c>shadows</c> property defines whether or not the box casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        public ShadowModeCesiumWriter OpenShadowsProperty()
        {
            OpenIntervalIfNecessary();
            return OpenAndReturn(ShadowsWriter);
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>shadowMode</c> value.  The <c>shadows</c> property specifies whether or not the box casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="value">The shadow mode.</param>
        public void WriteShadowsProperty(CesiumShadowMode value)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteShadowMode(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the box casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteShadowsPropertyReference(Reference value)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the box casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteShadowsPropertyReference(string value)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(value);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the box casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteShadowsPropertyReference(string identifier, string propertyName)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(identifier, propertyName);
            }
        }

        /// <summary>
        /// Writes a value for the <c>shadows</c> property as a <c>reference</c> value.  The <c>shadows</c> property specifies whether or not the box casts or receives shadows.  If not specified, the default value is DISABLED.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteShadowsPropertyReference(string identifier, string[] propertyNames)
        {
            using (var writer = OpenShadowsProperty())
            {
                writer.WriteReference(identifier, propertyNames);
            }
        }

    }
}
