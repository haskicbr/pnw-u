using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MainController : MonoBehaviour
{

    public GameObject particle;
    public GameObject gameWorld;
    public LayerMask clickMask;
    public NavMeshAgent playerAgent;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
            Vector3 clickPosition;
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 1000f, clickMask))
            {
                clickPosition = hit.point;
                //Instantiate(particle, new Vector3(clickPosition.x, 10.0f, clickPosition.z), particle.transform.rotation);

                //Vector3 direction = particle.transform.position -  new Vector3(clickPosition.x, 10.0f, clickPosition.z);
                //particle.GetComponent<Rigidbody>().AddForceAtPosition(direction.normalized, particle.transform.position);
                //particle.transform.position = new Vector3(clickPosition.x, 1.0f, clickPosition.z);


                playerAgent.SetDestination(clickPosition);

            }
        }
    }
}
