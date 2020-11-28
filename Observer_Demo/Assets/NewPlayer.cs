using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewPlayer : MonoBehaviour
{
    //#region

    //#endregion
    public delegate void EnemyColor(Color color);
    public static event EnemyColor EnemyChangeColor; 
    // Start is called before the first frame update
    void Start()
    {
        
    }
                      
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
		{
            //Check to make sure there are subscribers
            if (EnemyChangeColor != null)
			{
                EnemyChangeColor(Color.red);
			}
		}
    }
}
