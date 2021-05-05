using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doctor : MonoBehaviour
{
    float velocitat = 0f;

    public GameObject visor = null;
    public Transform target = null;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        // this.transform.Translate(new Vector3(1f, 0f, 0f));
        // rb = gameObject.GetComponent<Rigidbody>();
        //rb.velocity = new Vector3(Random.Range(5, 15), 0, Random.Range(5, 15));
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            this.transform.Rotate(Vector3.up, -1);
        }
        else
        {
            this.transform.LookAt(target);

        }
    }
}
