using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coinCollect : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxCount = 32;
    public int currentCount;
    public CoinBar coinBar;
    public AudioSource chingSound;

    public GameObject portal;
    public GameObject shieldActive, shieldInactive;
    public static bool hasShield;

    void Start()
    {
        currentCount = 0;
        coinBar.SetMaxCount(maxCount);
        coinBar.SetCount(0);
        portal.SetActive(false);
        shieldActive.SetActive(false);
        shieldInactive.SetActive(true);
        hasShield = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1.0f);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.tag.Equals("coin"))
            {
                Debug.Log(hitCollider.name);
                currentCount += 1;
                coinBar.SetCount(currentCount);
                Debug.Log("sound");
                Debug.Log(chingSound.name);
                chingSound.Play();
                Debug.Log(chingSound.isPlaying);
                Destroy(hitCollider.gameObject);

                if(currentCount == maxCount)
                {
                    portal.SetActive(true);
                }
            }
            else if (hitCollider.tag.Equals("shield"))
            {
                shieldActive.SetActive(true);
                shieldInactive.SetActive(false);
                hasShield = true;
            }
        }
    }
}
