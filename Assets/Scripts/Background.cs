using System.Collections;
using UnityEngine;

public class Background : MonoBehaviour {

	public Transform Background1;	//background
	public Transform Background2;	//duplicate of background that is 40.96 units ahead of background1 on z-axis

	private bool whichBackground = true;	//if true, control background1; if false, control background2

	public Transform cam;
	private float currentZ = 40.96f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (currentZ < cam.position.z) {
		
			if (whichBackground) {
			
				Background1.localPosition = new Vector3 (0, 0, Background1.localPosition.z + 81.92f);	//move first background to be ahead of second background
			
			} else {
			
				Background2.localPosition = new Vector3 (0, 0, Background2.localPosition.z + 81.92f);	//if second background is behind first background, move second background to be ahead
			
			}

			currentZ += 40.96f;	//keep track of backgrounds
			whichBackground = !whichBackground;	//alternate between backgrounds
		
		}

		if (currentZ > cam.position.z + 40.96) {

			if (whichBackground) {

				Background2.localPosition = new Vector3 (0, 0, Background2.localPosition.z - 81.92f);

			} else {

				Background1.localPosition = new Vector3 (0, 0, Background1.localPosition.z - 81.92f);

			}

			currentZ -= 40.96f;	//keep track of backgrounds
			whichBackground = !whichBackground;	//alternate between backgrounds

		}

	}
}
