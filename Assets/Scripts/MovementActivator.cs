using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementActivator : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate.GetComponent<MoveObject>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    { }
	void OnTriggerEnter(Collider other) {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("test");
        gos[0].SetActive(true);

    }

    void OnTriggerExit(Collider other)
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("test");
        gos[0].SetActive(false);

    }
}
