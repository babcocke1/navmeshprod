using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public NPCMove nma;
    public GameObject g;

    private void OnTriggerEnter(Collider other)
    {
        
        if( (g.transform.position - new Vector3(13.2f, .5f, 13f)).magnitude < .025)
        {
            g.transform.position = new Vector3(-13f, .5f, -13f);
            nma.setDestination();
        }
        else if ((g.transform.position - new Vector3(-13f, .5f, -13f)).magnitude < .025)
        {
            g.transform.position = new Vector3(13.2f, .5f, 13f);
            nma.setDestination();

        }

    }
}
