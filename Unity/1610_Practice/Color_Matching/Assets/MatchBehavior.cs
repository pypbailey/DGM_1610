using UnityEngine;

public class MatchBehavior : MonoBehaviour
{
    public ID idobj;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(idobj);
        Debug.Log(other.GetComponent<IDContainerBehavior>().idObj);
    }
}
