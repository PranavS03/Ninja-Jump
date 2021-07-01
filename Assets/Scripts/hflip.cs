using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hflip : MonoBehaviour
{
    SpriteRenderer flip;


    // Start is called before the first frame update
    void Start()
    {
        flip = GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    public void flipT()
    {
        flip.flipX=true;

        
        

        
        
    }
    public void flipF()
    {
        flip.flipX=false;
    }
}
