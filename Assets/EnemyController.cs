using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
//using UnityStandardAssets.Characters.ThirdPerson;

public class EnemyController : MonoBehaviour
{

    public float lookRadius = 10f;
    public Camera target;
    public NavMeshAgent agent;
    [SerializeField] private Animator myAttack;
    public GameObject gameOver;

    //public ThirdPersonCharacter character;

    public void gameover()
    {
        Debug.Log(coinCollect.hasShield);
        if (!coinCollect.hasShield)
            gameOver.SetActive(true);
        else
            coinCollect.hasShield = false;
    }

    private void Start()
    {
        //agent.updateRotation = false;
        gameOver.SetActive(false);
    }

    private bool played = false;


    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.transform.position);

        if(Vector3.Distance(transform.position, target.transform.position) <= 5.5f && !played)
        {
            played = true;
            myAttack.Play("Attack", 0, 0.0f);

            //foreach (var hitCollider in Physics.OverlapSphere(transform.position, 4.0f))
            //{
            //    if (hitCollider.tag.Equals("player"))
            //    {
            //        Debug.Log(hitCollider.name);
            //        gameOver.SetActive(true);
            //    }
            //}
        }

        //Collider[] hitColliders = Physics.OverlapSphere(transform.position, 6.0f);
        //foreach (var hitCollider in hitColliders)
        //{
        //    if (hitCollider.tag.Equals("player"))
        //    {
        //        Debug.Log(hitCollider.name);
        //        myAttack.Play("Attack", 0, 0.0f);

        //        //agent.
        //        //currentCount += 1;
        //        //coinBar.SetCount(currentCount);
        //        //Debug.Log("sound");
        //        //Debug.Log(chingSound.name);
        //        //chingSound.Play();
        //        //Debug.Log(chingSound.isPlaying);
        //        //Destroy(hitCollider.gameObject);


        //    }
        //}

        //if(agent.remainingDistance > agent.stoppingDistance)
        //{
        //    character.Move(agent.desiredVelocity, false, false);
        //}
        //else
        //{
        //    character.Move(Vector3.zero, false, false);
        //}



    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}
