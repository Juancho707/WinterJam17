using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class NpcsResources : MonoBehaviour
{
    public Sprite[] HeadsSpritesNPC;
    public Sprite[] BodySpritesNPC;

    public Sprite GetRandomHead()
    {
        return HeadsSpritesNPC.PickOne();
    }

    public Sprite GetRandomBody()
    {
        return BodySpritesNPC.PickOne();
    }
}
