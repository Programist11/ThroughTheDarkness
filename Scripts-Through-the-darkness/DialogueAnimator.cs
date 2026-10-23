using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueAnimator : MonoBehaviour
{
    public GameObject Starro;
    public Animator startAnim;
    public DialogueManager dm;

    private void OnTriggerEnter2D(Collider2D other) {
        if(Starro.tag == "Star")
        startAnim.SetBool("StartOpen", true);
    }
    private void OnTriggerExit2D(Collider2D other) {
        startAnim.SetBool("StartOpen", false);
        dm.EndDiologue();
    }
}
