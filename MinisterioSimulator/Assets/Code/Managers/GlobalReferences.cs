using UnityEngine;

public static class GlobalReferences
{
    public static GameObject resources
    {
        get { return GameObject.Find("Resources"); }
    }

    public static NavigationNodes navigation
    {
        get { return GameObject.Find("NavigationNodes").GetComponent<NavigationNodes>(); }
    }

    public static ScoreKeeper score
    {
        get { return GameObject.Find("Score").GetComponent<ScoreKeeper>(); }
    }

    public static AudioResources audioPlayer
    {
        get { return GameObject.Find("AudioPlayer").GetComponent<AudioResources>(); }
    }
}
