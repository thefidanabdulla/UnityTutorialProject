using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        int selectedCharacter =
            int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

        string clickedObj = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        Debug.Log(clickedObj);

        //SceneManager.LoadScene("Gameplay");
    }

}
