using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPathing : MonoBehaviour
{
    public int g;                   //Steps from enemy pos to target
    public int h;                   //Steps from current pos to target
    public EnemyPathing parent;     //Parent Node
    public int x;                   // x coordinate
    public int y;                   // y coordinate


    //construct the pathing node
    public EnemyPathing(int _g, int _h, EnemyPathing _parent, int _x, int _y)
    {
        g = _g;
        h = _h;
        parent = _parent;
        x = _x;
        y = _y;
    }
    public int f // total weight
    {
        get { return g + h; }
    }
}
