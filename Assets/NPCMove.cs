using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMove : MonoBehaviour
{
    [SerializeField]
    Transform destination;

    NavMeshAgent nma;
    // Start is called before the first frame update
    void Start()
    {
        nma = this.GetComponent<NavMeshAgent>();

        if (nma == null)
            Debug.LogError("the nav mesh agent component is not attached to " + gameObject.name);
        else
            setDestination();
    }

    // Update is called once per frame
    public void setDestination()
    {
        if(destination != null)
        {
            Vector3 targetVector = destination.transform.position;
            nma.SetDestination(targetVector);
        }

    }
}
