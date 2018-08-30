using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float RotationSpeed = 5;
    public bool downBut;
	private void Start()
	{
     
        downBut = false;
	}

	// Update is called once per frame
	void Update()
    {
        if(downBut)
        transform.Rotate(0, (Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime), 0, Space.World);

    }

	private void OnMouseUp()
    {
        downBut = false;
	}
	private void OnMouseDown()
	{
        downBut = true;
	}
}