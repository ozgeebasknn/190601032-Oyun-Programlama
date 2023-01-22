using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public Stashable stashableObject;


    public Stashable Collect()
    {
        var stashable = Instantiate(stashableObject, null);
        stashable.transform.position = transform.position + Vector3.up * 1.5f;
        GetComponent<Collider>().enabled = false;
        Destroy(gameObject, Time.deltaTime);
        return stashable;
    }
}
