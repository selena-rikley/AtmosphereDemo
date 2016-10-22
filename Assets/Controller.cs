using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour
{

		public Material Sky1;
		public Material Sky2;
		public Material Sky3;
		public Material Sky4;
		public Material Sky5;

		public GameObject[] Lights = new GameObject[5];	
		public GameObject[] AmbientSounds = new GameObject[4];
		public GameObject[] SoundBytes = new GameObject[5];
		public GameObject[] Music = new GameObject[4];
		// Use this for initialization
		void Start ()
		{
	
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.Alpha1)) {
						RenderSettings.skybox = Sky1;
				}

				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.Alpha2)) {
						RenderSettings.skybox = Sky2;
				}

				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.Alpha3)) {
						RenderSettings.skybox = Sky3;
				}

				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.Alpha4)) {
						RenderSettings.skybox = Sky4;
				}

				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.Alpha5)) {
						RenderSettings.skybox = Sky5;
				}

				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.Alpha1)) {
						foreach (GameObject lgt in Lights) {
								lgt.light.enabled = false;
						}
						Lights [0].light.enabled = true;
				}
			
				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.Alpha2)) {
						foreach (GameObject lgt in Lights) {
								lgt.light.enabled = false;
						}
						Lights [1].light.enabled = true;
				}
			
				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.Alpha3)) {
						foreach (GameObject lgt in Lights) {
								lgt.light.enabled = false;
						}
						Lights [2].light.enabled = true;
				}
            
				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.Alpha4)) {
						foreach (GameObject lgt in Lights) {
								lgt.light.enabled = false;
						}
						Lights [3].light.enabled = true;
				}
            
				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.Alpha5)) {
						foreach (GameObject lgt in Lights) {
								lgt.light.enabled = false;
						}
						Lights [4].light.enabled = true;
				}
            
				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.F1)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}			
						AmbientSounds [0].audio.enabled = true;
				}
				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.F2)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						AmbientSounds [1].audio.enabled = true;
				}
				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.F3)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						AmbientSounds [2].audio.enabled = true;
				}
				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.F4)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						AmbientSounds [3].audio.enabled = true;
				}           

				if (Input.GetKey (KeyCode.LeftShift) && Input.GetKey (KeyCode.F5)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
				}
           
				if (Input.GetKey (KeyCode.LeftControl) && Input.GetKey (KeyCode.F1)) {
						foreach (GameObject ambSound in SoundBytes) {
								ambSound.audio.enabled = false;
						}			
						SoundBytes [0].audio.enabled = true;
				}
				if (Input.GetKey (KeyCode.LeftControl) && Input.GetKey (KeyCode.F2)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						SoundBytes [1].audio.enabled = true;
				}
				if (Input.GetKey (KeyCode.LeftControl) && Input.GetKey (KeyCode.F3)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						SoundBytes [2].audio.enabled = true;
				}
				if (Input.GetKey (KeyCode.LeftControl) && Input.GetKey (KeyCode.F4)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						SoundBytes [3].audio.enabled = true;
				}           
		
				if (Input.GetKey (KeyCode.LeftControl) && Input.GetKey (KeyCode.F5)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						SoundBytes [4].audio.enabled = true;
            
				}          

				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.F1)) {
						foreach (GameObject ambSound in Music) {
								ambSound.audio.enabled = false;
						}			
						Music [0].audio.enabled = true;
				}
				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.F2)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						Music [1].audio.enabled = true;
				}
				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.F3)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						Music [2].audio.enabled = true;
				}
				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.F4)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
						Music [3].audio.enabled = true;
				}           
		
				if (Input.GetKey (KeyCode.LeftAlt) && Input.GetKey (KeyCode.F5)) {
						foreach (GameObject ambSound in AmbientSounds) {
								ambSound.audio.enabled = false;
						}		
				} 
		}
}
