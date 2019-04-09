using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordinates : MonoBehaviour {

	//instance
	public static Coordinates Instance{
		set;
		get;
	}

	//variables
	public float latitude;
	public float longitude;

	private void Start(){
		Instance = this;
		DontDestroyOnLoad(gameObject);
		StartCoroutine(StartLocationServide());
	}

	private IEnumerator StartLocationServide(){
		if(!Input.location.isEnabledByUser){
			Debug.Log("El usuario no ha hablilitado el GPS");
			yield break;
		}

		Input.location.Start();
		int maxWait = 20;
		
		while(Input.location.status == LocationServiceStatus.Initializing && maxWait > 0){
			yield return new WaitForSeconds(1);
			maxWait--;
		}

		if(maxWait <= 0){
			Debug.Log("Tiempo de espera agotado");
			yield break;
		}

		if(Input.location.status == LocationServiceStatus.Failed){
			Debug.Log("No se ha encontrado la ubicación del dispositivo");
			yield break;
		}

		yield break;
	}

	private void Update(){
		latitude = Input.location.lastData.latitude;
		longitude = Input.location.lastData.longitude;
	}
}
