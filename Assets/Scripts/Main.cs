using UnityEngine;
using UnityEngine.SceneManagement; // ضروري عشان تستخدم SceneManager

public class MainMenu : MonoBehaviour
{

    // لما تضغط زر Start
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    // لما تضغط زر Exit
    public void ExitGame()
    {
#if UNITY_EDITOR
        // لو بتجرب اللعبة جوه ال Editor هيوقف اللعب مش هيقفل التطبيق
        UnityEditor.EditorApplication.isPlaying = false;
#else
        // لو اللعبة شغالة على الجهاز الحقيقي
        Application.Quit();
#endif
    }
}