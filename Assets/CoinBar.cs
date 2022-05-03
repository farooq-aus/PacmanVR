using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinBar : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;

    public void SetMaxCount(int count)
    {
        slider.maxValue = count;
        slider.value = count; 
    }
    public void SetCount(int count)
    {
        slider.value = count;
    }
}
