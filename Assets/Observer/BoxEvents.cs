using UnityEngine;
using System.Collections;
using System;

public abstract class BoxEvents
{
    public abstract float GetJumpForce();
}

public class JumpLittle : BoxEvents
{
    public override float GetJumpForce()
    {
        return 100f;
    }
}

public class JumpMedium : BoxEvents
{
    public override float GetJumpForce()
    {
        return 150f;
    }
}

public class JumpHigh : BoxEvents
{
    public override float GetJumpForce()
    {
        return 200f;
    }
}
