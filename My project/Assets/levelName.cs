using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static NameAndSpeed;

public class levelName : MonoBehaviour
{
    public Text names;
    // Start is called before the first frame update
    void Start()
    {
        names.text = Names;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
