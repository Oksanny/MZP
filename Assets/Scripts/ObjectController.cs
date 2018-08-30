using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour {
    public GameObject Karkas;
    public GameObject Pillow;
    public GameObject Foots;
    public GameObject Metal;
    public GameObject CurrentObject;
    public static int CurrentMatPillow;
    public static int CurrentMatKarkas;
    public static int CurrentMatMetal;
    public static int CurrentMatFoots;
    public static int CurrentMat;
    public Material[] MaterialsBond;
	// Use this for initialization
	void Start () {
        CurrentObject = Pillow;
	}
	
	// Update is called once per frame
	void Update () {

      
	}
    public void SetObjectPillow()
    {
        CurrentObject = Pillow;
    }
    public void SetObjectMetal()
    {
        CurrentObject = Metal;
    }
    public void SetObjectFoots()
    {
        CurrentObject = Foots;
    }
    public void SetObjectKarkas()
    {
        CurrentObject = Karkas;
    }

    public void SetMaterial(string Mat)
    {
        Material mat = Resources.Load(Mat) as Material;
        CurrentObject.GetComponent<Renderer>().material = mat;
      
        switch (Mat)
        {
            case "Button_bond1":
                CurrentMat = 0;
                break;
            case "Button_bond2":
                CurrentMat = 1;
                break;
            case "Button_bond3":
                CurrentMat = 2;
                break;
            case "Button_bond4":
                CurrentMat = 3;
                break;
            case "Button_bond5":
                CurrentMat = 4;
                break;
            case "Button_bond6":
                CurrentMat = 5;
                break;
            case "Button_bond7":
                CurrentMat = 6;
                break;
            case "Button_bond8":
                CurrentMat = 7;
                break;
            case "Button_bond9":
                CurrentMat = 8;
                break;
            case "Button_bond10":
                CurrentMat = 9;
                break;
            case "Button_bond11":
                CurrentMat = 10;
                break;
            case "Button_bond12":
                CurrentMat = 11;
                break;
            case "Button_bond13":
                CurrentMat = 12;
                break;
            case "Button_bond14":
                CurrentMat = 13;
                break;
            case "Button_bond15":
                CurrentMat = 14;
                break;
            case "Button_bond16":
                CurrentMat = 15;
                break;
        }


    }



}
