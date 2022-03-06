using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hit1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void hit()
    {
        transform.localScale = Vector3.zero;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision) 
        {
            if (collision.gameObject.CompareTag("Weapon"))
                hit();
        }
}
