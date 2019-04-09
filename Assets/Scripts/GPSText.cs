using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPSText : MonoBehaviour {

	//varibles
	public Text latitude;
	public Text longitude;

	private void Update () {
		latitude.text = "Latitud: " + Coordinates.Instance.latitude.ToString();
		longitude.text = "Longitud: " + Coordinates.Instance.longitude.ToString();
	}
}
