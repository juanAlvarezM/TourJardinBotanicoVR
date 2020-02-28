using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rayScript : MonoBehaviour {

    public cambioScenas cambioScenasScript;
    private GameObject go;
   // public Text texto;
    private LineRenderer lineRender;
    public Color principioColorNoToca, finalColorNoToca, colorTocando;
    Gradient gradient = new Gradient();
    Gradient gradient2 = new Gradient();

    void Start () {
        lineRender = gameObject.GetComponent<LineRenderer>();

        //Asigna los colores a las gradientes
        gradient.SetKeys(
               new GradientColorKey[] { new GradientColorKey(principioColorNoToca, 0.0f), new GradientColorKey(finalColorNoToca, 1.0f) },
               new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 1.0f) }
           );
        gradient2.SetKeys(
               new GradientColorKey[] { new GradientColorKey(colorTocando, 0.0f), new GradientColorKey(colorTocando, 1.0f) },
               new GradientAlphaKey[] { new GradientAlphaKey(1.0f, 0.0f), new GradientAlphaKey(1.0f, 1.0f) }
           );

    }

    RaycastHit hit;
    void Update()
     {
       

        if (Physics.Raycast(transform.position, transform.forward, out hit))            
        {
            lineRender.SetPosition(1, new Vector3(0, 0, hit.distance));
            if (hit.collider != null)
            {
                
                if (hit.collider.transform.name == "aInicio" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a1();
                }
                if (hit.collider.transform.name == "a1" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a1();
                }
                if (hit.collider.transform.name == "a2" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a2();
                }
                if (hit.collider.transform.name == "a3" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a3();
                }
                if (hit.collider.transform.name == "a4" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a4();
                }
                if (hit.collider.transform.name == "a5" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a5();
                }
                if (hit.collider.transform.name == "a6" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a6();
                }
                if (hit.collider.transform.name == "a7" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a7();
                }
                if (hit.collider.transform.name == "a8" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a8();
                }
                if (hit.collider.transform.name == "a9" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a9();
                }
                if (hit.collider.transform.name == "a10" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a10();
                }
                if (hit.collider.transform.name == "a11" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a11();
                }
                if (hit.collider.transform.name == "a12" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a12();
                }
                if (hit.collider.transform.name == "a13" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a13();
                }
                if (hit.collider.transform.name == "a14" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a14();
                }
                if (hit.collider.transform.name == "a15" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a15();
                }
                if (hit.collider.transform.name == "a16" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a16();
                }
                if (hit.collider.transform.name == "a17" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a17();
                }
                if (hit.collider.transform.name == "a18" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a18();
                }
                if (hit.collider.transform.name == "a19" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a19();
                }
                if (hit.collider.transform.name == "a20" && (OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger) || Input.GetKeyDown(KeyCode.A))) //Si el tag es el taladro y se preciona el boton
                {
                    cambioScenasScript.a20();
                }


                if (go != hit.collider.gameObject)
                {
                    go = hit.transform.gameObject;
                }
            }
            //Debug.DrawRay(transform.position, transform.forward * hit.distance, Color.yellow);  //Esto cambia el color para visualizar en inspector
            
            lineRender.colorGradient = gradient2;
        }
        else
        {
            //Debug.DrawRay(transform.position, transform.forward * 1000, Color.blue);           
            //Color de la Gradiente           
            lineRender.colorGradient = gradient;
            //Debug.Log("Did not Hit");             
        }
        
     }
   
}
