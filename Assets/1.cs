using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    public WinMenu winMenu;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winMenu.ShowWinPanel(); 
        }
    }
}