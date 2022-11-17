using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DraggableBehavior : MonoBehaviour
{

    private Camera cameraObj;
    public bool draggable;
    public Vector3 position;

    void start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        draggable = true;

        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            Debug.Log("Drag");
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition);
            transform.position = position;
        }
    }

    public void OnMouseUp()
    {
        draggable = false;
    }
}