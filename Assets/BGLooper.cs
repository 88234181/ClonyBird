using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

    int numBGPanels = 6;

	void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Triggered: " + collider.name);

        float widthOfBGObject = ((BoxCollider2D)collider).size.x;
        Vector3 pos = collider.transform.position;
        pos.x += widthOfBGObject * numBGPanels; //repositioning the background panel
        Debug.Log("current x: " + collider.transform.position.x + " next x: " + pos.x + " width: "+ widthOfBGObject);
        collider.transform.position = pos; //assign the new position
        Debug.Log("after reposition : " + collider.transform.position.x);
    }
}
