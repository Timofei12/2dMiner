using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;


public class PLAY : MonoBehaviour
{
public void PressedStartLvl( int sceneID )    
{
        SceneManager.LoadScene(sceneID);
    	}

    public void PressedExit()    
{
        Application.Quit();
    	}

}
