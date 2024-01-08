Allows quick modification/creation of color and vector channels.

Modify single channel
```cs
transform.position = transform.position.WithY(3.0f);
image.color = image.color.WithA(0.5f);
```

Modify multiple channels
```cs
transform.localScale = transform.localScale.With(x: 2f, z: 2f)
```

Swizzle channels
```cs
transform.position = transform.position.ZYX();
transform.position = transform.position.Swizzle(Axis3.ZYX);
```
