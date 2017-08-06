using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class OrderInflow : MonoBehaviour
{
    public float OrderInterval;
    public GameObject OrderPrefab;

    private float intervalElapsed;

    private void FixedUpdate()
    {
        intervalElapsed += Time.fixedDeltaTime;

        if (intervalElapsed > OrderInterval)
        {
            Instantiate(OrderPrefab, this.transform);
            intervalElapsed = 0;
        }
    }

    public void CloseOrder(OrderUI order)
    {
        
    }
}
