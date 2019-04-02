using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private List<EnemyPathing> GetAdjacentSquares(EnemyPathing p)
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

                if ((x == 0 && y == 0) || (x!=0 && y != 0)) //not self and not diagonal
                {
                    continue;
                }
                else if (__x < GameManager.GetGameManager.numCols && __y < GameManager.GetGameManager.numRows && )
                {

                }
            }
        }
    }
}
