using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioScenas : MonoBehaviour {
    //public GameObject salaCocina, corredorSuperior, salaAdelante,habit,habit2;
    [Header("Variables de control Escenas")]
    public Color colorNextArrow;
    public GameObject[] esferas, objetos;
    public GameObject temporizagorObj, Blur;
    public timer temporizador = new timer();
    public Vector3[] posicionesIniciales;
    

    [Header("Control Audios")]
    //public GameObject apuntadorCabeza;
    public AudioSource audioSourceRobot;
    public AudioClip[] audioClipsRobot;
    public GameObject robot;

    void Start () {       
        aInicio();
        audioSourceRobot.clip = audioClipsRobot[0];
        audioSourceRobot.Play();
        Invoke("Audio2",25f);
       // robot = audioSourceRobot.gameObject;
        robot.transform.position = new Vector3(-0.808f,0.019f,0.08f);
        robot.transform.rotation = Quaternion.Euler(0f,201.926f,0f);
    }


    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.DpadUp))
        {
            SceneManager.LoadScene("TourVR");
        }
    }

    //metodos control de Audio
    public void Audio2()
    {
        CancelInvoke("Audio2");
        audioSourceRobot.clip = audioClipsRobot[1];
        audioSourceRobot.Play();
    }

    bool primerVeza1 = false, primerVeza2 = false;

    public void exit()
    {
        temporizagorObj.SetActive(false);
        temporizador.tiempo = 0;

    }

    public void aInicio()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[20].SetActive(true);
        objetos[20].SetActive(true);         
    }

    public void a1(){
        CancelInvoke("Audio2");
        desactivarEsferas();
        desactivarObjetos();

        esferas[0].SetActive(true);
        objetos[1].SetActive(true);

        objetos[1].transform.position = new Vector3(0.45f, -0.3f, 0.8f);
        objetos[1].transform.rotation = Quaternion.Euler(-24,209,-116);
        for (int i = 0; i < objetos[1].GetComponent<Transform>().childCount; i++)
        {
            objetos[1].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }
        if (primerVeza1 == false)
        {
            primerVeza1 = true;
            robot.GetComponent<Animator>().SetBool("Agrandar", true);
            robot.transform.position = new Vector3(0.217f, -0.332f, 0.852f);
            robot.transform.rotation = Quaternion.Euler(0f, 284.1f, 0f);
            audioSourceRobot.clip = audioClipsRobot[2];//cambia audio de explicacion
            audioSourceRobot.Play(); //reproduce el audio           
        }
        else {
            robot.SetActive(false);
        }
       
    }

    public void a2(){              
        desactivarEsferas();
        desactivarObjetos();

        esferas[1].SetActive(true);
        objetos[2].SetActive(true);
        objetos[0].SetActive(true);            
            
        objetos[0].transform.position = new Vector3(-0.8f, -0.25f, 0.3f);
        objetos[0].transform.rotation = Quaternion.Euler(212,-68,-215);
        //Cambio Color Antes
        for (int i = 0; i < objetos[0].GetComponent<Transform>().childCount; i++)
        {
            objetos[0].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[2].transform.position = new Vector3(0.95f, -0.4f,  0.24f);
        objetos[2].transform.rotation = Quaternion.Euler(-22, -100, -76);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[2].GetComponent<Transform>().childCount; i++)
        {
            objetos[2].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

        if (primerVeza2 == false)
        {
            robot.transform.position = new Vector3(-0.802f, -0.332f, 0.13f);
            robot.transform.rotation = Quaternion.Euler(0f, 181.6f, 0f);
            audioSourceRobot.clip = audioClipsRobot[3];//cambia audio de explicacion
            audioSourceRobot.Play(); //reproduce el audio
            robot.GetComponent<Animator>().SetBool("Agrandar", true);
            primerVeza2 = true;
        }
        else
        {
            robot.SetActive(false);
        }

    }

    public void a3(){       
        desactivarEsferas();
        desactivarObjetos();

        esferas[2].SetActive(true);
        objetos[1].SetActive(true);
        objetos[3].SetActive(true);        

        objetos[1].transform.position = new Vector3(-0.841f, -0.197f , 0.017f);
        objetos[1].transform.rotation = Quaternion.Euler(150, 88, 60);
        //Cambio Color Antes
        for (int i = 0; i < objetos[1].GetComponent<Transform>().childCount; i++)
        {
            objetos[1].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[3].transform.position = new Vector3(0.754f, -0.3f, 0.525f);
        objetos[3].transform.rotation = Quaternion.Euler(12, 39, -91);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[3].GetComponent<Transform>().childCount; i++)
        {
            objetos[3].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }
        robot.SetActive(false);
    }

    public void a4()
    {
        desactivarEsferas();
        desactivarObjetos();
        esferas[3].SetActive(true);
        objetos[2].SetActive(true);
        objetos[4].SetActive(true);

        objetos[2].transform.position = new Vector3(-0.17f, -0.28f, 0.751f);       
        objetos[2].transform.rotation = Quaternion.Euler(28, -35, -29);
        //Cambio Color Antes
        for (int i = 0; i < objetos[2].GetComponent<Transform>().childCount; i++)
        {
            objetos[2].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[4].transform.position = new Vector3(0.046f, -0.3f, -0.892f);
        objetos[4].transform.rotation = Quaternion.Euler(-21, 19, -40);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[4].GetComponent<Transform>().childCount; i++)
        {
            objetos[4].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }

    public void a5()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[4].SetActive(true);
        objetos[3].SetActive(true);
        objetos[5].SetActive(true);

        objetos[3].transform.position = new Vector3(-0.253f, -0.27f, 0.695f);
        objetos[3].transform.rotation = Quaternion.Euler(17, -19, -69);
        //Cambio Color Antes
        for (int i = 0; i < objetos[3].GetComponent<Transform>().childCount; i++)
        {
            objetos[3].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[5].transform.position = new Vector3(0.027f, -0.4f, -0.8f);
        objetos[5].transform.rotation = Quaternion.Euler(-24, 2, -98);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[5].GetComponent<Transform>().childCount; i++)
        {
            objetos[5].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }
    }

    public void a6()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[5].SetActive(true);
        objetos[4].SetActive(true);
        objetos[6].SetActive(true);

        objetos[4].transform.position = new Vector3(0.054f, -0.3f, 0.838f);
        objetos[4].transform.rotation = Quaternion.Euler(15, 7, -83);
        //Cambio Color Antes
        for (int i = 0; i < objetos[4].GetComponent<Transform>().childCount; i++)
        {
            objetos[4].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[6].transform.position = new Vector3(0.132f, -0.18f, -0.943f);
        objetos[6].transform.rotation = Quaternion.Euler(0,-12,-121);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[6].GetComponent<Transform>().childCount; i++)
        {
            objetos[6].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }
    }

    public void a7()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[6].SetActive(true);
        objetos[5].SetActive(true);
        objetos[7].SetActive(true);

        objetos[5].transform.position = new Vector3(0.8f, -0.2f, 0.6f);
        objetos[5].transform.rotation = Quaternion.Euler(19, 42, -90);
        //Cambio Color Antes
        for (int i = 0; i < objetos[5].GetComponent<Transform>().childCount; i++)
        {
            objetos[5].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[7].transform.position = new Vector3(0.2f, -0.18f, -0.8f);
        objetos[7].transform.rotation = Quaternion.Euler(0, -12, -121);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[7].GetComponent<Transform>().childCount; i++)
        {
            objetos[7].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }
    }

    public void a8 ()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[7].SetActive(true);
        objetos[6].SetActive(true);
        objetos[8].SetActive(true);

        objetos[6].transform.position = new Vector3(-0.227f, -0.18f, 0.9f);
        objetos[6].transform.rotation = Quaternion.Euler(10, -17, -106);
        //Cambio Color Antes
        for (int i = 0; i < objetos[6].GetComponent<Transform>().childCount; i++)
        {
            objetos[6].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[8].transform.position = new Vector3(0.2f, -0.18f, -0.8f);
        objetos[8].transform.rotation = Quaternion.Euler(0, -12, -121);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[8].GetComponent<Transform>().childCount; i++)
        {
            objetos[8].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }

    public void a9 ()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[8].SetActive(true);
        objetos[7].SetActive(true);
        objetos[9].SetActive(true);

        objetos[7].transform.position = new Vector3(0.3f, -0.3f, 0.892f);
        objetos[7].transform.rotation = Quaternion.Euler(16, 13, -98);
        //Cambio Color Antes
        for (int i = 0; i < objetos[7].GetComponent<Transform>().childCount; i++)
        {
            objetos[7].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[9].transform.position = new Vector3(0.7f, -0.18f, -0.63f);
        objetos[9].transform.rotation = Quaternion.Euler(-15, -64, -11);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[9].GetComponent<Transform>().childCount; i++)
        {
            objetos[9].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }
    }

    public void a10()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[9].SetActive(true);
        objetos[8].SetActive(true);
        objetos[10].SetActive(true);

        objetos[8].transform.position = new Vector3(-0.688f, -0.157f, 0.455f);
        objetos[8].transform.rotation = Quaternion.Euler(-4, 137, 93);
        //Cambio Color Antes
        for (int i = 0; i < objetos[8].GetComponent<Transform>().childCount; i++)
        {
            objetos[8].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[10].transform.position = new Vector3(0.597f, -0.13f, 0.665f);
        objetos[10].transform.rotation = Quaternion.Euler(-17, -151, -24);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[10].GetComponent<Transform>().childCount; i++)
        {
            objetos[10].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }

    public void a11()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[10].SetActive(true);
        objetos[9].SetActive(true);
        objetos[11].SetActive(true);

        objetos[9].transform.position = new Vector3(0.498f, -0.18f, -0.759f);
        objetos[9].transform.rotation = Quaternion.Euler(-15, -64, -11);
        //Cambio Color Antes
        for (int i = 0; i < objetos[9].GetComponent<Transform>().childCount; i++)
        {
            objetos[9].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[11].transform.position = new Vector3(-0.568f, -0.24f, 0.68f);
        objetos[11].transform.rotation = Quaternion.Euler(9, -13, -154);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[11].GetComponent<Transform>().childCount; i++)
        {
            objetos[11].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }

    public void a12()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[11].SetActive(true);
        objetos[10].SetActive(true);
        objetos[12].SetActive(true);

        objetos[10].transform.position = new Vector3(0.3f, -0.06f, -0.8f);
        objetos[10].transform.rotation = Quaternion.Euler(-8, -31, -33);
        //Cambio Color Antes
        for (int i = 0; i < objetos[10].GetComponent<Transform>().childCount; i++)
        {
            objetos[10].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[12].transform.position = new Vector3(-0.8f, -0.2f, 0.3f);
        objetos[12].transform.rotation = Quaternion.Euler(36, -101, -70);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[12].GetComponent<Transform>().childCount; i++)
        {
            objetos[12].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }
    }

    public void a13()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[12].SetActive(true);
        objetos[11].SetActive(true);
        objetos[13].SetActive(true);
        
        objetos[11].transform.position = new Vector3(-0.3f, -0.06f, -0.7f);
        objetos[11].transform.rotation = Quaternion.Euler(-6, 30, -90);
        //Cambio Color Antes
        for (int i = 0; i < objetos[11].GetComponent<Transform>().childCount; i++)
        {
            objetos[11].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[13].transform.position = new Vector3(-0.65f, -0.1f, 0.6f);
        objetos[13].transform.rotation = Quaternion.Euler(19, -48, -98);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[13].GetComponent<Transform>().childCount; i++)
        {
            objetos[13].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }
    }

    public void a14()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[13].SetActive(true);
        objetos[12].SetActive(true);
        objetos[14].SetActive(true);

        objetos[12].transform.position = new Vector3(-0.202f, -0.116f, 0.929f);
        objetos[12].transform.rotation = Quaternion.Euler(16, 13, -98);
        //Cambio Color Antes
        for (int i = 0; i < objetos[12].GetComponent<Transform>().childCount; i++)
        {
            objetos[12].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[14].transform.position = new Vector3(-0.823f, -0.25f, 0.243f);
        objetos[14].transform.rotation = Quaternion.Euler(16, -87, 74);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[14].GetComponent<Transform>().childCount; i++)
        {
            objetos[14].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }
    }

    public void a15()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[14].SetActive(true);
        objetos[13].SetActive(true);
        objetos[15].SetActive(true);

        objetos[13].transform.position = new Vector3(0.935f, -0.4f, 0.037f);
        objetos[13].transform.rotation = Quaternion.Euler(12, 69, -267);
        //Cambio Color Antes
        for (int i = 0; i < objetos[13].GetComponent<Transform>().childCount; i++)
        {
            objetos[13].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[15].transform.position = new Vector3(0.9f, -0.18f, 0.5f);
        objetos[15].transform.rotation = Quaternion.Euler(-15, -117, -11);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[15].GetComponent<Transform>().childCount; i++)
        {
            objetos[15].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }

    public void a16()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[15].SetActive(true);
        objetos[14].SetActive(true);
        objetos[16].SetActive(true);

        objetos[14].transform.position = new Vector3(0.7f, -0.18f, -0.63f);
        objetos[14].transform.rotation = Quaternion.Euler(-15, -64, -11);
        //Cambio Color Antes
        for (int i = 0; i < objetos[14].GetComponent<Transform>().childCount; i++)
        {
            objetos[14].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[16].transform.position = new Vector3(-0.551f, -0.2f, 0.695f);
        objetos[16].transform.rotation = Quaternion.Euler(17, -11, -172);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[16].GetComponent<Transform>().childCount; i++)
        {
            objetos[16].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }

    public void a17()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[16].SetActive(true);
        objetos[15].SetActive(true);
        objetos[17].SetActive(true);

        objetos[15].transform.position = new Vector3(0.97f, -0.041f, -0.312f);
        objetos[15].transform.rotation = Quaternion.Euler(-12, 103, -11);
        //Cambio Color Antes
        for (int i = 0; i < objetos[15].GetComponent<Transform>().childCount; i++)
        {
            objetos[15].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[17].transform.position = new Vector3(0.116f, -0.1f, -0.929f);
        objetos[17].transform.rotation = Quaternion.Euler(-16, -18, -149);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[17].GetComponent<Transform>().childCount; i++)
        {
            objetos[17].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }

    public void a18()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[17].SetActive(true);
        objetos[16].SetActive(true);
        objetos[18].SetActive(true);

        objetos[16].transform.position = new Vector3(-0.76f, -0.05f, 0.035f);
        objetos[16].transform.rotation = Quaternion.Euler(9, 259, 88);
        //Cambio Color Antes
        for (int i = 0; i < objetos[16].GetComponent<Transform>().childCount; i++)
        {
            objetos[16].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[18].transform.position = new Vector3(-0.7f, -0.18f, -0.3f);
        objetos[18].transform.rotation = Quaternion.Euler(4, -105, -16);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[18].GetComponent<Transform>().childCount; i++)
        {
            objetos[18].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }

    public void a19()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[18].SetActive(true);
        objetos[17].SetActive(true);
        objetos[19].SetActive(true);

        objetos[17].transform.position = new Vector3(-0.5f, -0.18f, -0.5f);
        objetos[17].transform.rotation = Quaternion.Euler(-8, 45, -142);
        //Cambio Color Antes
        for (int i = 0; i < objetos[17].GetComponent<Transform>().childCount; i++)
        {
            objetos[17].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[19].transform.position = new Vector3(0.9f, -0.3f, -0.2f);
        objetos[19].transform.rotation = Quaternion.Euler(15, 112, 10);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[19].GetComponent<Transform>().childCount; i++)
        {
            objetos[19].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }

    public void a20()
    {
        desactivarEsferas();
        desactivarObjetos();

        esferas[19].SetActive(true);
        objetos[0].SetActive(true);

        objetos[18].transform.position = new Vector3(-0.7f, -0.14f, -0.53f);
        objetos[18].transform.rotation = Quaternion.Euler(11, -110, -86);
        //Cambio Color Antes
        for (int i = 0; i < objetos[18].GetComponent<Transform>().childCount; i++)
        {
            objetos[18].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = Color.red;
        }
        objetos[0].transform.position = new Vector3(0.736f, -0.2f, 0.631f);
        objetos[0].transform.rotation = Quaternion.Euler(16, 13, -150);
        //Cambiocolor Despues
        for (int i = 0; i < objetos[0].GetComponent<Transform>().childCount; i++)
        {
            objetos[0].GetComponent<Transform>().GetChild(i).GetComponent<Renderer>().material.color = colorNextArrow;
        }

    }
    

    public void desactivarEsferas()
    {
        for (int i = 0; i < esferas.Length; i++)
        {
            if (esferas[i].activeSelf)
            {
                esferas[i].gameObject.SetActive(false);
            }
        }
    }

    public void desactivarObjetos()
    {
        for (int i = 0; i < objetos.Length; i++)
        {
            if (objetos[i].activeSelf)
            {
                objetos[i].gameObject.SetActive(false);
            }
        }
    }

   
}
