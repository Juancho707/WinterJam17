using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class OrderClock : MonoBehaviour
{
    public Image Fill;
    private float clockAdvPerFrame;
    private bool isCountdown;
    
    void FixedUpdate()
    {
        if (isCountdown)
        {
            Fill.fillAmount -= clockAdvPerFrame;
            if (Fill.fillAmount <= 0)
            {
                isCountdown = false;
                GetComponentInParent<OrderUI>().FailOrder();
            }
        }
    }

    public void StartCountdown(float orderTimeLimit)
    {
        if (Fill != null)
        {
            clockAdvPerFrame = Time.fixedDeltaTime / orderTimeLimit;
            isCountdown = true;
        }
    }
}
