using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour
{

		private Vector3 lastMousePos;
		// Use this for initialization
		void Start ()
		{
				lastMousePos = Input.mousePosition;
		}
	
		// Update is called once per frame
		void Update ()
		{
				transform.Rotate (new Vector3 (
					0,
					.75f * (Input.mousePosition.x - lastMousePos.x), 
					0));

				Camera.main.transform.Rotate (new Vector3 (
					-.75f * (Input.mousePosition.y - lastMousePos.y), 0, 0)	
				);
				lastMousePos = Input.mousePosition;
		}


}
