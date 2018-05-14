using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LoadLevel : MonoBehaviour
{

    //make a variable of type string, which will hold the name of the level to load
    public string nextLevel;

    //changes to the level whose name is being passed inside the parameters
    public void changeLevel()
    {
        SceneManager.LoadScene(nextLevel);

    }
}
