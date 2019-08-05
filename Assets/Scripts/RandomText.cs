using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomText : MonoBehaviour {

    public Text texto;

    private int random;

    private void Awake()
    {
        random = 0;
    }

    public void RandomValue()
    {
        random = Random.Range(1, 5);

        switch (random)
        {
            case 1:
                texto.text = "Recomendación: Utiliza audífonos para poder escuchar mejor los audios.";
                break;
            case 2:
                texto.text = "No camines viendo la pantalla de tu teléfono. Evita accidentes.";
                break;
            case 3:
                texto.text = "Recomendación: Manten distancia del mural para poder ver el modelo 3D.";
                break;
            case 4:
                texto.text = "Recomendación: Procura estar bajo una buena fuente de luz.";
                break;
        }
    }
}
