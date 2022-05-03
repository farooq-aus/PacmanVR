using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coinCollect : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxCount = 32;
    public int currentCount;
    public CoinBar coinBar;
    void Start()
    {
        currentCount = 0;
        coinBar.SetMaxCount(maxCount);
        coinBar.SetCount(0);
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hitColliders = Physics.OverlapSphere(transform.position, 2.0f);
        foreach (var hitCollider in hitColliders)
        {
            if (hitCollider.name.Contains("coin"))
            {
                Debug.Log(hitCollider.name);
                currentCount += 1;
                coinBar.SetCount(currentCount);
                // make coin disappear after this
            }
        }
    }
}
