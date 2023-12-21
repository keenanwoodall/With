using UnityEngine;

public static class WithExtensions
{
    // Vector2
    
    public static Vector2 WithX(this Vector2 v, float x)
    {
        v.x = x;
        return v;
    }
    
    public static Vector2 WithY(this Vector2 v, float y)
    {
        v.y = y;
        return v;
    }
    
    public static Vector3 WithZ(this Vector2 v, float z)
    {
        return new Vector3(v.x, v.y, z);
    }
    
    public static Vector2 With(this Vector2 v, float? x = null, float? y = null)
    {
        if (x.HasValue)
            v.x = x.Value;
        if (y.HasValue)
            v.y = y.Value;

        return v;
    }
    
    // Vector3
    
    public static Vector3 WithX(this Vector3 v, float x)
    {
        v.x = x;
        return v;
    }
    
    public static Vector3 WithY(this Vector3 v, float y)
    {
        v.y = y;
        return v;
    }
    
    public static Vector3 WithZ(this Vector3 v, float z)
    {
        v.z = z;
        return v;
    }
    
    public static Vector4 WithW(this Vector3 v, float w)
    {
        return new Vector4(v.x, v.y, v.z, w);
    }
    
    public static Vector3 With(this Vector3 v, float? x = null, float? y = null, float? z = null)
    {
        if (x.HasValue)
            v.x = x.Value;
        if (y.HasValue)
            v.y = y.Value;
        if (z.HasValue)
            v.z = z.Value;

        return v;
    }
    
    // Vector4
    
    public static Vector4 WithX(this Vector4 v, float x)
    {
        v.x = x;
        return v;
    }
    
    public static Vector4 WithY(this Vector4 v, float y)
    {
        v.y = y;
        return v;
    }
    
    public static Vector4 WithZ(this Vector4 v, float z)
    {
        v.z = z;
        return v;
    }
    
    public static Vector4 WithW(this Vector4 v, float w)
    {
        v.w = w;
        return v;
    }
    
    public static Vector4 With(this Vector4 v, float? x = null, float? y = null, float? z = null, float? w = null)
    {
        if (x.HasValue)
            v.x = x.Value;
        if (y.HasValue)
            v.y = y.Value;
        if (z.HasValue)
            v.z = z.Value;
        if (w.HasValue)
            v.w = w.Value;
        
        return v;
    }
    
    // Vector4
        
    public static Color WithR(this Color c, float r)
    {
        c.r = r;
        return c;
    }
    
    public static Color WithG(this Color c, float g)
    {
        c.g = g;
        return c;
    }
    
    public static Color WithB(this Color c, float b)
    {
        c.b = b;
        return c;
    }
    
    public static Color WithA(this Color c, float a)
    {
        c.a = a;
        return c;
    }
    
    public static Color With(this Color c, float? r = null, float? g = null, float? b = null, float? a = null)
    {
        if (r.HasValue)
            c.r = r.Value;
        if (g.HasValue)
            c.g = g.Value;
        if (b.HasValue)
            c.b = b.Value;
        if (a.HasValue)
            c.a = a.Value;
        
        return c;
    }
}