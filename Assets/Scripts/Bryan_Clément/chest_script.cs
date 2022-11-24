
using UnityEngine;
using UnityEngine.Events;

public class chest_script : Interactive
{
    public Animator anim;
    public GameObject KeyInteraction;
    public bool isOpen;


    public override void OnInteraction()
    {
        if (!isOpen)
        {
            isOpen = true;
            Debug.Log("Chest is open");
            anim.enabled = true;
            KeyInteraction.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    

}
        
  
