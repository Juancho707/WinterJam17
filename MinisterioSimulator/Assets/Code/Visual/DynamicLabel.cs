using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DynamicLabel : MonoBehaviour
{
    public string Format;

    public void SetLevel(params object[] args)
    {
        this.GetComponent<Text>().text = string.Format(Format, args);
    }
}
