using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionHelper : MonoBehaviour
{
    public GameObject interactionCue;
    public void Show(bool show)
    {
        interactionCue.SetActive(show);
    }
}
