package cesiumlanguagewritertests;


import agi.foundation.compatibility.*;
import agi.foundation.compatibility.DisposeHelper;
import agi.foundation.compatibility.MapHelper;
import agi.foundation.compatibility.TestContextRule;
import cesiumlanguagewriter.*;
import cesiumlanguagewriter.advanced.*;
import java.awt.Color;
import java.util.LinkedHashMap;
import java.util.Map;
import javax.annotation.Nonnull;
import org.junit.FixMethodOrder;
import org.junit.Rule;
import org.junit.runners.MethodSorters;
import org.junit.Test;

@SuppressWarnings( {
        "unused",
        "deprecation",
        "serial"
})
@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class TestCustomPatternSensorCesiumWriter extends TestCesiumPropertyWriter<CustomPatternSensorCesiumWriter> {
    @Test
    public final void testBasicProperties() {
        final boolean expectedShow = true;
        final double expectedRadius = 1234.5;
        {
            final PacketCesiumWriter usingExpression_0 = (getPacket());
            try {
                {
                    CustomPatternSensorCesiumWriter rectangle = getPacket().openCustomPatternSensorProperty();
                    try {
                        {
                            CustomPatternSensorCesiumWriter interval = rectangle.openInterval();
                            try {
                                interval.writeShowProperty(expectedShow);
                                interval.writeRadiusProperty(expectedRadius);
                            } finally {
                                DisposeHelper.dispose(interval);
                            }
                        }
                    } finally {
                        DisposeHelper.dispose(rectangle);
                    }
                }
            } finally {
                DisposeHelper.dispose(usingExpression_0);
            }
        }
        final Map<String, Object> tempCollection$0 = new LinkedHashMap<String, Object>();
        MapHelper.add(tempCollection$0, CustomPatternSensorCesiumWriter.ShowPropertyName, expectedShow);
        MapHelper.add(tempCollection$0, CustomPatternSensorCesiumWriter.RadiusPropertyName, expectedRadius);
        assertExpectedJson(PacketCesiumWriter.CustomPatternSensorPropertyName, tempCollection$0);
    }

    @Test
    public final void testIntersectionProperties() {
        final boolean expectedShowIntersection = true;
        Color expectedIntersectionColor = Color.BLUE;
        final double expectedIntersectionWidth = 2.1;
        final boolean expectedShowEnvironmentIntersection = true;
        Color expectedEnvironmentIntersectionColor = Color.RED;
        {
            final PacketCesiumWriter usingExpression_1 = (getPacket());
            try {
                {
                    CustomPatternSensorCesiumWriter rectangle = getPacket().openCustomPatternSensorProperty();
                    try {
                        {
                            CustomPatternSensorCesiumWriter interval = rectangle.openInterval();
                            try {
                                interval.writeShowIntersectionProperty(expectedShowIntersection);
                                interval.writeIntersectionColorProperty(expectedIntersectionColor);
                                interval.writeIntersectionWidthProperty(expectedIntersectionWidth);
                                interval.writeShowEnvironmentIntersectionProperty(expectedShowEnvironmentIntersection);
                                interval.writeEnvironmentIntersectionColorProperty(expectedEnvironmentIntersectionColor);
                            } finally {
                                DisposeHelper.dispose(interval);
                            }
                        }
                    } finally {
                        DisposeHelper.dispose(rectangle);
                    }
                }
            } finally {
                DisposeHelper.dispose(usingExpression_1);
            }
        }
        final Map<String, Object> tempCollection$1 = new LinkedHashMap<String, Object>();
        MapHelper.add(tempCollection$1, CustomPatternSensorCesiumWriter.ShowIntersectionPropertyName, expectedShowIntersection);
        MapHelper.add(tempCollection$1, CustomPatternSensorCesiumWriter.IntersectionColorPropertyName, expectedIntersectionColor);
        MapHelper.add(tempCollection$1, CustomPatternSensorCesiumWriter.IntersectionWidthPropertyName, expectedIntersectionWidth);
        MapHelper.add(tempCollection$1, CustomPatternSensorCesiumWriter.ShowEnvironmentIntersectionPropertyName, expectedShowEnvironmentIntersection);
        MapHelper.add(tempCollection$1, CustomPatternSensorCesiumWriter.EnvironmentIntersectionColorPropertyName, expectedEnvironmentIntersectionColor);
        assertExpectedJson(PacketCesiumWriter.CustomPatternSensorPropertyName, tempCollection$1);
    }

    @Test
    public final void testShowThroughEllipsoid() {
        final boolean expectedShowThroughEllipsoid = true;
        {
            final PacketCesiumWriter usingExpression_2 = (getPacket());
            try {
                {
                    CustomPatternSensorCesiumWriter rectangle = getPacket().openCustomPatternSensorProperty();
                    try {
                        {
                            CustomPatternSensorCesiumWriter interval = rectangle.openInterval();
                            try {
                                interval.writeShowThroughEllipsoidProperty(expectedShowThroughEllipsoid);
                            } finally {
                                DisposeHelper.dispose(interval);
                            }
                        }
                    } finally {
                        DisposeHelper.dispose(rectangle);
                    }
                }
            } finally {
                DisposeHelper.dispose(usingExpression_2);
            }
        }
        final Map<String, Object> tempCollection$2 = new LinkedHashMap<String, Object>();
        MapHelper.add(tempCollection$2, CustomPatternSensorCesiumWriter.ShowThroughEllipsoidPropertyName, expectedShowThroughEllipsoid);
        assertExpectedJson(PacketCesiumWriter.CustomPatternSensorPropertyName, tempCollection$2);
    }

    @Override
    protected CesiumPropertyWriter<CustomPatternSensorCesiumWriter> createPropertyWriter(String propertyName) {
        return new CustomPatternSensorCesiumWriter(propertyName);
    }

    @Nonnull
    private final TestContextRule rule$testContext = new TestContextRule();

    @Nonnull
    @Rule
    public TestContextRule getRule$testContext() {
        return rule$testContext;
    }
}