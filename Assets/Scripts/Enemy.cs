using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform target;
    /*private List<EnemyPathing> GetAdjacentSquares(EnemyPathing p)
    {
        List<EnemyPathing> ret = new List<EnemyPathing>();

        int _x = p.x;
        int _y = p.y;
        for (int x = 0; x <= -1; x++)
        {
            for (int y = 0; y <= -1; y++)
            {
                int __x = _x + x;
                int __y = _y + y;

                if ((x == 0 && y == 0) || (x != 0 && y != 0)) //not self and not diagonal
                {
                    continue;
                }
                else if (__x < GameManager.GetGameManager.numCols &&
                    __y < GameManager.GetGameManager.numRows &&
                    __x >= 0 &&
                    __y >= 0 &&
                    !CheckForCollisions(new Vector2(_x, _y), new Vector2(__x, __y)))
                    ret.Add(new EnemyPathing(p.g + 1, BlocksToTarget(new Vector2(__x, __y), target.position), p, __x, __y));
            }
        }

        return ret;
    }*/

    private int BlocksToTarget(Vector2 EnemyPos, Vector3 PlayerPos)
    {
        return Mathf.RoundToInt(
            Mathf.Abs(EnemyPos.x - PlayerPos.x) +
            Mathf.Abs(EnemyPos.y - PlayerPos.y)
            );
    }

    private bool CheckForCollisions(Vector2 start, Vector2 end)
    {
        this.GetComponent<BoxCollider2D>().enabled = false;
        RaycastHit2D hit = Physics2D.Linecast(start, end, 0);
        this.GetComponent<BoxCollider2D>().enabled = true;
        if (hit.transform!= null && !hit.collider.CompareTag("Player"))
        {
            return true;
        }
        return false;
    }
}
