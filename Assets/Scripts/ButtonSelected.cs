using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSelected : MonoBehaviour {
    public GameObject KarkasArrow;
    public GameObject PillowArrow;
    public GameObject FootsArrow;
    public GameObject MetalArrow;
	// Use this for initialization
	void Start () {
        PillowArrow.SetActive(true);
        KarkasArrow.SetActive(false);
        FootsArrow.SetActive(false);
        MetalArrow.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PillowSetArrow()
    {
        PillowArrow.SetActive(true);
        KarkasArrow.SetActive(false);
        FootsArrow.SetActive(false);
        MetalArrow.SetActive(false);
    }
    public void KarkasSetArrow()
    {
        KarkasArrow.SetActive(true);
        PillowArrow.SetActive(false);
        FootsArrow.SetActive(false);
        MetalArrow.SetActive(false);
    }
    public void FootsSetArrow()
    {
        KarkasArrow.SetActive(false);
        PillowArrow.SetActive(false);
        FootsArrow.SetActive(true);
        MetalArrow.SetActive(false);
    }
    public void MetalSetArrow()
    {
        KarkasArrow.SetActive(false);
        PillowArrow.SetActive(false);
        FootsArrow.SetActive(false);
        MetalArrow.SetActive(true);
    }
}
