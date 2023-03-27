using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronautAnim : MonoBehaviour
{
    private Animator m_Animator;
    private bool drill = false;
    private bool wave= false;
    private bool idle = false;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator=gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("Launching Drill");
            drill=true;
            idle=false;
            wave=false;
            m_Animator.SetBool("IsWaving",wave);
            m_Animator.SetBool("IsDrilling",drill);

        }
                if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Launching Wave");
            wave=true;
            idle=false;
            drill=false;
            m_Animator.SetBool("IsWaving",wave);
            m_Animator.SetBool("IsDrilling",drill);

        }
                for (int i = 0; i < Input.touchCount; ++i)
        {
        if (Input.GetKeyDown(KeyCode.W)||Input.GetTouch(i).phase==TouchPhase.Began)
        {
            Debug.Log("Launching Wave");
            wave=true;
            idle=false;
            drill=false;
            m_Animator.SetBool("IsWaving",wave);
            m_Animator.SetBool("IsDrilling",drill);

        }  }
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Launching Idle");
            drill=false;
            idle=true;
            wave=false;
            m_Animator.SetBool("IsWaving",wave);
            m_Animator.SetBool("IsDrilling",drill);

        }
    }
}
