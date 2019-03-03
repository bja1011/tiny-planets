// Prints the name of the object camera is directly looking at
using UnityEngine;
using System.Collections;
using UnityEngine.Rendering.PostProcessing;


public class lookingAt : MonoBehaviour
{
    DepthOfField dofLayer = null;
    Camera cam;
    public GameObject pPVolGE;

    void Start()
    {
        cam = GetComponent<Camera>();
       

    }

    void Update()
    {

        PostProcessVolume volume = pPVolGE.GetComponent<PostProcessVolume>();
        volume.profile.TryGetSettings(out dofLayer);

        Ray ray = cam.ViewportPointToRay(new Vector3(0.5F, 0.5F, 0));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.distance);
            dofLayer.focusDistance.value = hit.distance;
            //hit.transform.localScale = new Vector3(2f,2f,2f);  
           // print("I'm looking at " + hit.transform.name);
        }
           
        else
            print("I'm looking at nothing!");
    }
}