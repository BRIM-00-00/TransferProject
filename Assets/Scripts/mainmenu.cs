using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour{
 
    public void GotoScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
    public void QuitApp(){
      Application.Quit();
        Debug.Log("Quit");
    }


}
