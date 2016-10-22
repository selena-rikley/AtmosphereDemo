using UnityEngine;
using System.Collections;

public class Meovement : MonoBehaviour
{

		private enum Direction
		{
				Forward,
				Backward,
				Left,
				Right
		}
		;

		
		public float speed = 2f;

		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{

				if (Input.GetKey (KeyCode.W) || Input.GetKeyDown (KeyCode.UpArrow))
						move (speed, Direction.Forward);
				if (Input.GetKey (KeyCode.S) || Input.GetKeyDown (KeyCode.DownArrow))
						move (speed, Direction.Backward);
				if (Input.GetKey (KeyCode.D) || Input.GetKeyDown (KeyCode.RightArrow))
						move (speed, Direction.Right);
				if (Input.GetKey (KeyCode.A) || Input.GetKeyDown (KeyCode.LeftArrow))
						move (speed, Direction.Left);
		}

		private void move (float speed, Direction direction)
		{
				switch (direction) {
				case Direction.Forward:
						transform.localPosition += transform.forward * speed * Time.deltaTime;
						break;
				case Direction.Backward:
						transform.localPosition -= transform.forward * speed * Time.deltaTime;
						break;
				case Direction.Right:			
						transform.localPosition += transform.right * speed * Time.deltaTime;
						break;
				case Direction.Left:			
						transform.localPosition -= transform.right * speed * Time.deltaTime;
						break;				
				}
		}
	
}
