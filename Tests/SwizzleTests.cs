using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;
using UnityEngine;

[TestFixture]
public class SwizzleTests
{
    // Generate Vector2 Swizzle Test Cases
    public static IEnumerable<TestCaseData> GenerateVector2SwizzleTestCases()
    {
        var v2 = new Vector2(1f, 2f);
        string[] components = { "x", "y" };

        foreach (var i in components)
            foreach (var j in components)
            {
                string methodName = $"{i.ToUpper()}{j.ToUpper()}";
                Vector2 expected = new Vector2(
                    i == "x" ? v2.x : v2.y,
                    j == "x" ? v2.x : v2.y
                );
                yield return new TestCaseData(v2, expected, methodName);
            }
    }

    [Test, TestCaseSource(nameof(GenerateVector2SwizzleTestCases))]
    public void TestVector2Swizzles(Vector2 original, Vector2 expected, string methodName)
    {
        MethodInfo methodInfo = typeof(WithExtensions).GetMethod(methodName, new[] { typeof(Vector2) });
        Vector2 result = (Vector2)methodInfo.Invoke(null, new object[] { original });
        Assert.AreEqual(expected, result);
    }

    // Generate Vector3 Swizzle Test Cases
    public static IEnumerable<TestCaseData> GenerateVector3SwizzleTestCases()
    {
        var v3 = new Vector3(1f, 2f, 3f);
        string[] components = { "x", "y", "z" };

        foreach (var i in components)
            foreach (var j in components)
                foreach (var k in components)
                {
                    string methodName = $"{i.ToUpper()}{j.ToUpper()}{k.ToUpper()}";
                    Vector3 expected = new Vector3(
                        i == "x" ? v3.x : i == "y" ? v3.y : v3.z,
                        j == "x" ? v3.x : j == "y" ? v3.y : v3.z,
                        k == "x" ? v3.x : k == "y" ? v3.y : v3.z
                    );
                    yield return new TestCaseData(v3, expected, methodName);
                }
    }

    [Test, TestCaseSource(nameof(GenerateVector3SwizzleTestCases))]
    public void TestVector3Swizzles(Vector3 original, Vector3 expected, string methodName)
    {
        MethodInfo methodInfo = typeof(WithExtensions).GetMethod(methodName, new[] { typeof(Vector3) });
        Vector3 result = (Vector3)methodInfo.Invoke(null, new object[] { original });
        Assert.AreEqual(expected, result);
    }

    // Generate Vector4 Swizzle Test Cases
    public static IEnumerable<TestCaseData> GenerateVector4SwizzleTestCases()
    {
        var v4 = new Vector4(1f, 2f, 3f, 4f);
        string[] components = { "x", "y", "z", "w" };

        foreach (var i in components)
            foreach (var j in components)
                foreach (var k in components)
                    foreach (var l in components)
                    {
                        string methodName = $"{i.ToUpper()}{j.ToUpper()}{k.ToUpper()}{l.ToUpper()}";
                        Vector4 expected = new Vector4(
                            i == "x" ? v4.x : i == "y" ? v4.y : i == "z" ? v4.z : v4.w,
                            j == "x" ? v4.x : j == "y" ? v4.y : j == "z" ? v4.z : v4.w,
                            k == "x" ? v4.x : k == "y" ? v4.y : k == "z" ? v4.z : v4.w,
                            l == "x" ? v4.x : l == "y" ? v4.y : l == "z" ? v4.z : v4.w
                        );
                        yield return new TestCaseData(v4, expected, methodName);
                    }
    }

    [Test, TestCaseSource(nameof(GenerateVector4SwizzleTestCases))]
    public void TestVector4Swizzles(Vector4 original, Vector4 expected, string methodName)
    {
        MethodInfo methodInfo = typeof(WithExtensions).GetMethod(methodName, new[] { typeof(Vector4) });
        Vector4 result = (Vector4)methodInfo.Invoke(null, new object[] { original });
        Assert.AreEqual(expected, result);
    }
}