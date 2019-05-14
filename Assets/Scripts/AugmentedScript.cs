using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AugmentedScript : MonoBehaviour
{

    private float longitude;
    private float latitude;
    private float pointReferenceLatitude;
	private float pointReferenceLongitude;

    private GameObject distanceTextObject;
    private double distance;

    private bool setOriginalValues = true;

    IEnumerator GetCoordinates()
    {
        //while true so this function keeps running once started.
        while (true)
        {
            // check if user has location service enabled
            if (!Input.location.isEnabledByUser)
                yield break;

            // Start service before querying location
            Input.location.Start(1f, .1f);

            // Wait until service initializes
            int maxWait = 20;
            while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
            {
                yield return new WaitForSeconds(1);
                maxWait--;
            }

            // Service didn't initialize in 20 seconds
            if (maxWait < 1)
            {
                print("Timed out");
                yield break;
            }

            // Connection has failed
            if (Input.location.status == LocationServiceStatus.Failed)
            {
                print("Unable to determine device location");
                yield break;
            }
            else
            {
                // Access granted and location value could be retrieved
                print("Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy + " " + Input.location.lastData.timestamp);

                //if original value has not yet been set save coordinates of player on app start
                /*if (setOriginalValues)
                {
                    pointReferenceLatitude = 21.4915963f;
                    pointReferenceLongitude = -104.8949233f;
                    setOriginalValues = false;
                }*/

                //overwrite current lat and lon everytime
                latitude = Input.location.lastData.latitude;
                longitude = Input.location.lastData.longitude;

                //calculate the distance between where the player was when the app started and where they are now.
                Calc(pointReferenceLatitude, pointReferenceLongitude, latitude, longitude);

            }
            Input.location.Stop();
        }
    }

    //calculates distance between two sets of coordinates, taking into account the curvature of the earth.
    public void Calc(float lat1, float lon1, float lat2, float lon2)
    {

        var R = 6378.137; // Radius of earth in KM
        var dLat = lat2 * Mathf.PI / 180 - lat1 * Mathf.PI / 180;
        var dLon = lon2 * Mathf.PI / 180 - lon1 * Mathf.PI / 180;
        float a = Mathf.Sin(dLat / 2) * Mathf.Sin(dLat / 2) +
          Mathf.Cos(lat1 * Mathf.PI / 180) * Mathf.Cos(lat2 * Mathf.PI / 180) *
          Mathf.Sin(dLon / 2) * Mathf.Sin(dLon / 2);
        var c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        distance = R * c;
        distance = distance * 1000f; // meters
                                     //set the distance text on the canvas
        distanceTextObject.GetComponent<Text>().text = "Distancia: " + distance;
        //convert distance from double to float
        float distanceFloat = (float)distance;
        //distance was multiplied by 12 so I didn't have to walk that far to get the UFO to show up closer

    }

    void Start()
    {
        //get distance text reference
        distanceTextObject = GameObject.FindGameObjectWithTag("distanceText");
        //start GetCoordinate() function 
        StartCoroutine("GetCoordinates");
        pointReferenceLatitude = 21.4915963f;
        pointReferenceLongitude = -104.8949233f;
    }

    void Update()
    {
    	//get distance text reference
        distanceTextObject = GameObject.FindGameObjectWithTag("distanceText");
    }
}