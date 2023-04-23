using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameAndSpeed : MonoBehaviour
{
    public static float Speedbonus;
    public Text NameDisplay;
    public Text SpeedDisplay;
    public Slider SpeedInput;
    public InputField Name;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        NameDisplay.text = Name.text;
        Speedbonus = SpeedInput.value;
        SpeedDisplay.text = Speedbonus.ToString("F2");
    }
}
