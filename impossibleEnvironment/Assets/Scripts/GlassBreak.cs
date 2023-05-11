using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassBreak : MonoBehaviour
{
    public Rigidbody rb;
    public bool isBroken;
    // Start is called before the first frame update
    void Start()
    {
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(isBroken == true)
        {
            rb.isKinematic = false;

            //Invoke("DestroyPiece", 50);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickup")
        {
            isBroken = true;
        }
    }

    //void DestroyPiece()
    //{
    //    Destroy(this.gameObject);
    //}
}
