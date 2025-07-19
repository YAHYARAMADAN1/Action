using UnityEngine;
using UnityEngine.UI;

public class PlayAnimationOnClick : MonoBehaviour
{
    public Animator animator;     // اسحب هنا الـ Animator
    public Button myButton;       // اسحب هنا الزر

    void Start()
    {
        myButton.onClick.AddListener(PlayAnim); // ربط الزر بالدالة 
    }

    void PlayAnim()
    {
        animator.SetTrigger("gan");// تشغيل الأنيميشن عن طريق التريجر
        animator.SetTrigger("idle");
    }
}
