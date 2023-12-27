using System.Runtime.CompilerServices;
using UnityEngine;

public static partial class WithExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 With(this Vector2 v, Axis2 swizzle)
    {
        AxisMath.UnpackOffsets((int)swizzle, out var x, out var y);
        return new Vector2(v[x], v[y]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 With(this Vector3 v, Axis3 swizzle)
    {
        AxisMath.UnpackOffsets((int)swizzle, out var x, out var y, out var z);
        return new Vector3(v[x], v[y], v[z]);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4 With(this Vector4 v, Axis4 swizzle)
    {
        AxisMath.UnpackOffsets((int)swizzle, out var x, out var y, out var z, out var w);
        return new Vector4(v[x], v[y], v[z], v[w]);
    }
}