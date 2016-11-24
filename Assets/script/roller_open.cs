using UnityEngine;
using System.Collections;

public class roller_open : MonoBehaviour {

    Animator animtor;

    void Start()
    {
        animtor = this.GetComponent<Animator>();
    }

	public void open()
    {
        animtor.SetInteger("roller_state", 1);
    }
}
