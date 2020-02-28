using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    // public UnityEvent m_Myevent
    public UnityEvent OnOverEvent;
    public UnityEvent OnOffEvent;
    public UnityEvent OnClickEvent;

    bool m_bDown;
    bool m_bLastDown;

    public void Down()
    {
        m_bDown = true;
    }

    public void Clicked()
    {
        Debug.Log("clicked");
        OnClickEvent.Invoke();
        //rig.useGravity = false;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (m_bDown && !m_bLastDown)
        {
            OnOverEvent.Invoke();
        }

        if (!m_bDown && m_bLastDown)
        {
            OnOffEvent.Invoke();
        }

        m_bLastDown = m_bDown;
        m_bDown = false;
    }


    public void Agrandar()
    {
        try
        {
            Animator temp = gameObject.GetComponent<Animator>();
            temp.SetBool("Agrandar", true);
            temp.SetBool("pequeño", false);
        }
        catch
        {
            Debug.Log("no agrandó");
        }
    }
    public void Enpequenecer()
    {
        try
        {
            Animator temp = gameObject.GetComponent<Animator>();
            temp.SetBool("pequeño", true);
            temp.SetBool("Agrandar", false);
        }
        catch
        {
            Debug.Log("no enpequeñecio");
        }
    }
}
