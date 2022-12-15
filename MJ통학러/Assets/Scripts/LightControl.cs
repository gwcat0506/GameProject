using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightControl : MonoBehaviour {

    public float degreePerSec;
    public UnityEngine.Light go;

    //private Light lc;
    // Start is called before the first frame update
    void Awake()
    {
        //UnityEngine.Light lc = gameObject.GetComponent<Directionallight>();
        go =GetComponent<UnityEngine.Light>();
    }

    void Update()
    {
        go.transform.Rotate(Vector3.left * Time.deltaTime * degreePerSec);
    }
    
}

