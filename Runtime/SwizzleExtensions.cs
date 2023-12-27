using System.Runtime.CompilerServices;
using UnityEngine;

public static class SwizzleExtensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector2 Swizzle(this Vector2 v, Swizzle2 swizzle)
    {
        SwizzleMath.UnpackSwizzleOffsets((int)swizzle, out var x, out var y);
        return new Vector2(v[x], v[y]);
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector3 Swizzle(this Vector3 v, Swizzle3 swizzle)
    {
        SwizzleMath.UnpackSwizzleOffsets((int)swizzle, out var x, out var y, out var z);
        return new Vector3(v[x], v[y], v[z]);
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector4 Swizzle(this Vector4 v, Swizzle4 swizzle)
    {
        SwizzleMath.UnpackSwizzleOffsets((int)swizzle, out var x, out var y, out var z, out var w);
        return new Vector4(v[x], v[y], v[z], v[w]);
    }
}
    