using UnityEngine;
using System.Collections;

public class BGLooper : MonoBehaviour {

    int numBGPanels = 6;

	void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Triggered: " + collider.name);

        float widthOfBGObject = ((BoxCollider2D)collider).size.x;
        Vector3 pos = collider.transform.position;
        pos.x += widthOfBGObject*numBGPanels - 0.5f; //repositioning the background panel
        collider.transform.position = pos; //assign the new position
    }
}
