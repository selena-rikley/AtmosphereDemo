using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour
{

		public Text buttonText;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
	
		}
	
		void OnClick ()
		{
				buttonText.color = Color.blue;	
		}
}
