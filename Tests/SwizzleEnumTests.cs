using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[TestFixture]
public class SwizzleEnumTests
{
    public static IEnumerable<TestCaseData> Swizzle2TestCases()
    {
        Vector2 original = new Vector2(1, 2);
        foreach (Axis2 swizzle in System.Enum.GetValues(typeof(Axis2)))
        {
            AxisMath.UnpackOffsets((int)swizzle, out var x, out var y);
            yield return new TestCaseData(original, swizzle, new Vector2(original[x], original[y]));
        }
    }

    [Test, TestCaseSource(nameof(Swizzle2TestCases))]
    public void TestSwizzle2(Vector2 original, Axis2 swizzle, Vector2 expected)
    {
        Assert.AreEqual(expected, original.As(swizzle));
    }

    public static IEnumerable<TestCaseData> Swizzle3TestCases()
    {
        Vector3 original = new Vector3(1, 2, 3);
        foreach (Axis3 swizzle in System.Enum.GetValues(typeof(Axis3)))
        {
            AxisMath.UnpackOffsets((int)swizzle, out var x, out var y, out var z);
            yield return new TestCaseData(original, swizzle, new Vector3(original[x], original[y], original[z]));
        }
    }

    [Test, TestCaseSource(nameof(Swizzle3TestCases))]
    public void TestSwizzle3(Vector3 original, Axis3 swizzle, Vector3 expected)
    {
        Assert.AreEqual(expected, original.As(swizzle));
    }

    public static IEnumerable<TestCaseData> Swizzle4TestCases()
    {
        Vector4 original = new Vector4(1, 2, 3, 4);
        foreach (Axis4 swizzle in System.Enum.GetValues(typeof(Axis4)))
        {
            AxisMath.UnpackOffsets((int)swizzle, out var x, out var y, out var z, out var w);
            yield return new TestCaseData(original, swizzle, new Vector4(original[x], original[y], original[z], original[w]));
        }
    }

    [Test, TestCaseSource(nameof(Swizzle4TestCases))]
    public void TestSwizzle4(Vector4 original, Axis4 swizzle, Vector4 expected)
    {
        Assert.AreEqual(expected, original.As(swizzle));
    }
}
