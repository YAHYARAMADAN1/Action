using UnityEngine;
using UnityEngine.SceneManagement;
public class NewBehaviourScript : MonoBehaviour
{
    public void NEXT()
    {
        SceneManager.LoadSceneAsync(2);// شغال 
    }
    public void RESTART()
    {
        SceneManager.LoadSceneAsync(1);
    }
    public void EXIT()
    {
        SceneManager.LoadSceneAsync(0);// شغال 
    }
}