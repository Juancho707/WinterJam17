using UnityEngine;

public static class GlobalReferences
{
    public static GameObject resources = GameObject.Find("Resources");
    public static NavigationNodes navigation = GameObject.Find("NavigationNodes").GetComponent<NavigationNodes>();
    public static ScoreKeeper score = GameObject.Find("Score").GetComponent<ScoreKeeper>();
}
