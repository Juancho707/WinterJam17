using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    private float successCount;
    private float strikeCount;

    public DynamicLabel SuccessCounter;
    public DynamicLabel StrikeCounter;
    public float MaxStrikes;

    private void Start()
    {
        successCount = 0;
        strikeCount = 0;
        SuccessCounter.SetLabel(successCount);
        StrikeCounter.SetLabel(strikeCount);
    }

    public void AddSuccess()
    {
        successCount++;
        SuccessCounter.SetLabel(successCount);

    }

    public void AddStrike()
    {
        strikeCount++;
        StrikeCounter.SetLabel(strikeCount);
    }

    private void FixedUpdate()
    {
        if(strikeCount >= MaxStrikes)
        {
            //Game Over
        }
    }
}
