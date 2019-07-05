using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class SceneChange : MonoBehaviour {

	public void MainScene(){
		Application.LoadLevel("Pantalla Principal");
	}
}

public partial class SceneChange : MonoBehaviour{

	public void Exit(){
		Application.LoadLevel("Inicio");
	}
}

public partial class SceneChange : MonoBehaviour{

	public void Camera(){
		Application.LoadLevel("Camara");
	}
}

public partial class SceneChange : MonoBehaviour
{

    public void About()
    {
        Application.LoadLevel("About");
    }
}