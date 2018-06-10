using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimation : MonoBehaviour {
    public GameObject anim;
    public bool GoUpBool;

    private void Start()
    {
        
    }

    public void DropDowns()
    {
        if (GoUpBool == true)
        {
            anim.GetComponent<Animator>().SetBool("GoesUp", false);
            GoUpBool = false;

        }
        else if (GoUpBool == false)
        {
            anim.GetComponent<Animator>().SetBool("GoesUp", true);
            GoUpBool = true;
        }


    }


}
