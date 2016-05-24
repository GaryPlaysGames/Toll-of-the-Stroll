using UnityEngine;
using System.Collections;

public class LightControl : MonoBehaviour
{

    public GameObject lightGameObject;
    public GameObject MainCamera;
    public bool changingLight = false;
    UIManager Script;
    Camera myCam;
    Light lightComp;
    float minView = 60, minLight = 4.27f;

    void Start()
    {
        Script = GameObject.Find("UIManager").GetComponent<UIManager>(); //Grab the UI Manager;
        myCam = MainCamera.GetComponent<Camera>();
        lightComp = lightGameObject.GetComponent<Light>();
    }

    void Update()
    {
        
        if (!changingLight && !Script.isPaused)
        {

            if (lightComp.intensity < minLight) //Change the light intensity slowly back to the minLight specified
                lightComp.intensity += .005f;

            if (myCam.fieldOfView > minView)
                myCam.fieldOfView -= 0.05f; //Change the field of view slowly back to the minView specified
        }

    }

    public void LowerLight()
    {
        if (!Script.isPaused) //TODO: Set variables for change speeds (useful for flower changes later)
        {
            lightComp.intensity -= .007f;
            myCam.fieldOfView += 0.05f;
        }
    }
}
