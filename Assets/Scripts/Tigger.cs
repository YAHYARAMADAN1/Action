using UnityEngine;

public class ShowKafana : MonoBehaviour
{
    public GameObject kafana; // اسحب كائن الكافانا هنا

    void Start()
    {
        kafana.SetActive(false); // نخفيه في البداية
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // لو اللي دخل هو اللاعب
        {
            kafana.SetActive(true); // يظهر الكافانا
        }
    }
}
