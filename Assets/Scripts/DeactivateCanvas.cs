using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateCanvas : MonoBehaviour
{
    public void DeactivateCanvasChildren()
    {
        foreach (Transform child in transform)
            child.gameObject.SetActive(false);
    }
}
