using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavigationScript : MonoBehaviour
{
    public bool north;
    public bool south;
    public bool east;
    public bool west;
    public NavigationScript nsNorth;
    public NavigationScript nsSouth;
    public NavigationScript nsEast;
    public NavigationScript nsWest;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Reset()
    {
        for(int i = 0; i<361; i *= 90)
        {
            RaycastHit2D hit = Physics2D.Raycast(gameObject.transform.position, Vector2.right * i); 
            switch (i){
                case 0:

                    break;
                    
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer != LayerMask.GetMask("NavigationPoint"))
        {
            Physics2D.IgnoreCollision(collision.collider, gameObject.GetComponent<CircleCollider2D>(), true);
        }
    }

}
