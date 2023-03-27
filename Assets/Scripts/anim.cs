using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    private Animator m_Animator;
    private bool isFacing = true;
    private bool isScanning= false;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator=gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("Launching Scan");
            isFacing=true;
            isScanning=true;
            m_Animator.SetBool("IsFacingObject",isFacing);
            m_Animator.SetBool("IsScanning",isScanning);

        }
    }
}
