using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

[TestFixture]
public class SwizzleTests
{
    public static IEnumerable<TestCaseData> Swizzle2TestCases()
    {
        Vector2 original = new Vector2(1, 2);
        foreach (Swizzle2 swizzle in System.Enum.GetValues(typeof(Swizzle2)))
        {
            SwizzleMath.UnpackSwizzleOffsets((int)swizzle, out var x, out var y);
            yield return new TestCaseData(original, swizzle, new Vector2(original[x], original[y]));
        }
    }

    [Test, TestCaseSource(nameof(Swizzle2TestCases))]
    public void TestSwizzle2(Vector2 original, Swizzle2 swizzle, Vector2 expected)
    {
        Assert.AreEqual(expected, original.Swizzle(swizzle));
    }

    public static IEnumerable<TestCaseData> Swizzle3TestCases()
    {
        Vector3 original = new Vector3(1, 2, 3);
        foreach (Swizzle3 swizzle in System.Enum.GetValues(typeof(Swizzle3)))
        {
            SwizzleMath.UnpackSwizzleOffsets((int)swizzle, out var x, out var y, out var z);
            yield return new TestCaseData(original, swizzle, new Vector3(original[x], original[y], original[z]));
        }
    }

    [Test, TestCaseSource(nameof(Swizzle3TestCases))]
    public void TestSwizzle3(Vector3 original, Swizzle3 swizzle, Vector3 expected)
    {
        Assert.AreEqual(expected, original.Swizzle(swizzle));
    }

    public static IEnumerable<TestCaseData> Swizzle4TestCases()
    {
        Vector4 original = new Vector4(1, 2, 3, 4);
        foreach (Swizzle4 swizzle in System.Enum.GetValues(typeof(Swizzle4)))
        {
            SwizzleMath.UnpackSwizzleOffsets((int)swizzle, out var x, out var y, out var z, out var w);
            yield return new TestCaseData(original, swizzle, new Vector4(original[x], original[y], original[z], original[w]));
        }
    }

    [Test, TestCaseSource(nameof(Swizzle4TestCases))]
    public void TestSwizzle4(Vector4 original, Swizzle4 swizzle, Vector4 expected)
    {
        Assert.AreEqual(expected, original.Swizzle(swizzle));
    }
}
