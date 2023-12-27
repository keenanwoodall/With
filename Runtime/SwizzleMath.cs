using System.Runtime.CompilerServices;

public static class SwizzleMath
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void UnpackSwizzleOffsets(int packedInt, out int x, out int y, out int z, out int w)
    {
        x = (packedInt >> 24) & 0xFF;
        y = (packedInt >> 16) & 0xFF;
        z = (packedInt >> 8) & 0xFF;
        w = packedInt & 0xFF;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void UnpackSwizzleOffsets(int packedInt, out int x, out int y, out int z)
    {
        x = (packedInt >> 16) & 0xFF;
        y = (packedInt >> 8) & 0xFF;
        z = packedInt & 0xFF;
    }
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void UnpackSwizzleOffsets(int packedInt, out int x, out int y)
    {
        x = (packedInt >> 8) & 0xFF;
        y = packedInt & 0xFF;
    }
}