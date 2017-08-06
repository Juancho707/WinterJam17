using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AttachmentResources : MonoBehaviour
{
    public AttachmentResource[] AttResources;

    public GameObject GetAttachment(Attachment col)
    {
        return AttResources.First(x => x.AttType == col).AttachmentPrefab;
    }
}
