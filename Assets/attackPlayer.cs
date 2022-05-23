using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackPlayer : MonoBehaviour


{

    [SerializeField] private Animator myAttack;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("player"))
        {
            //myAttack.play("Attack", 0, 0.0f);
        } 
    }

    // Update is called once per frame
    //void Update()
    //{
    //    Collider[] hitColliders = Physics.OverlapSphere(transform.position, 2.0f);
    //    foreach (var hitCollider in hitColliders)
    //    {
    //        if (hitCollider.tag.Equals("player"))
    //        {
    //            Debug.Log(hitCollider.name);
    //            //currentCount += 1;
    //            //coinBar.SetCount(currentCount);
    //            //Debug.Log("sound");
    //            //Debug.Log(chingSound.name);
    //            //chingSound.Play();
    //            //Debug.Log(chingSound.isPlaying);
    //            //Destroy(hitCollider.gameObject);


    //        }
    //    }
    //}
}
