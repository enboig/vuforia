using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class captured: MonoBehaviour {
  // float velocitat = 0f;

  // public GameObject visor = null;
  // public GameObject capturedObject = null;

  // public int position;

  // public Transform target = null;

  // private Rigidbody rb;

  // public bool visible = false;

  

  // Start is called before the first frame update
  void Start() {
//    this.GetComponent<MeshRenderer>().enabled = false;
    gameObject.SetActive(false);

  }

  // Update is called once per frame
  void Update() {
    // if (this.visible == true) {
    //     //fem que miri la càmara
    //     this.transform.Rotate(Vector3.up, -1);
    //     this.transform.LookAt(target);
    // }
  }

  public void inFrontOfCamera() {
      //this.GetComponent<MeshRenderer>().enabled = true;

      gameObject.SetActive(true);
      //this.transform.parent = camera.transform;

  }
}
