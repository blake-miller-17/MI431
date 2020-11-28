using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		//Grabs all the enemies with NewEnemy script, then allows them to be
        //subscribed to that event, ready to do something
		NewPlayer.EnemyChangeColor += ChangeColor;
        //NewPlayer.EnemyChangeColor += takeDamage;
    }

	//Call this method every time we want to change the color
    //We can have more than one Event for our EnemyColor delegate
    //We can also have more than one method, but it has to take a Color
	private void ChangeColor(Color color)
	{
		transform.GetComponent<Renderer>().material.color = color;
	}

    //memory leak can happen if you do not unsubscribe from the event
    //This is in the case that an object is destroyed/ deleted
	void OnDestroy()
    {
        NewPlayer.EnemyChangeColor -= ChangeColor;
    }

}