using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionScroll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   
        transform.Rotate(0, 180, 0); 
    }

    // Update is called once per frame
    void Update()
    {
        //Comment out the bottom two lines to just show one color question mark.
        MeshRenderer mr = GetComponent<MeshRenderer>();
        mr.material.mainTextureOffset = new Vector2(.2f * Time.time,.2f * Time.time);
    }
 }
