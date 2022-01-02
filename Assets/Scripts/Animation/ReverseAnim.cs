using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseAnim : MonoBehaviour
{
    public string animationName;
    // Start is called before the first frame update
    void Start()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.Play(animationName,-1,float.NegativeInfinity);
    }

    // Update is called once per frame
    void Update()
    {
        Animator anim = gameObject.GetComponent<Animator>();
        anim.SetFloat("Direction", -1);
        anim.Play(animationName, -1, float.NegativeInfinity);
    }
}
