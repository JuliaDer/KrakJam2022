using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostPower : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator chairAnimator;
    public Animator chairAnimator1;
    public Animator chairAnimator2;
    public Animator chairAnimator3;
    public List<Animator> test ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
       //     chairAnimator.enabled = true;
       //    chairAnimator.Play("GhostChair");
    test[0].Play("GhostChair");
    test[1].Play("GhostChair");
        }
   }

   private void OnTriggerExit(Collider other) {
        if (other.gameObject.CompareTag("Player")) {
            chairAnimator.enabled = false;
        }
    }
}
