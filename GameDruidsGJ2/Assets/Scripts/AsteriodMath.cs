using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMath
{
    // let asteroid respawn to other side if it hits one side
    public static Vector2 Wrap(Vector2 pos, float height)
    {
        //if (Mathf.Abs(pos.x) > bounds.x) // fix this horiz bounds once map set
        //{
        //    pos.x *= -1f;
        //    pos.x *= .95f;
        //}
        if (Mathf.Abs(pos.y) > height)
        {
            pos.y *= -1f;
            pos.y *= .95f;
        }
        return pos;
    }
}
