using UnityEngine;
using UnityEngine.UI;

public class CircularPageController : MonoBehaviour
{

    public GameObject[] pages;
    public Button nextButton1;
    public Button nextButton2;
    public Button prevButton1;
    public Button prevButton2;

    public Animator animator;

    private void Start()
    {
        nextButton1.onClick.AddListener(GoToPage2);
        nextButton2.onClick.AddListener(GoToPage3);
        prevButton1.onClick.AddListener(GoBackToPage1);
        prevButton2.onClick.AddListener(GoBackToPage2);
    }

    private void GoToPage2()
    {
        animator.SetBool("Page1", false);
        animator.SetBool("Page2", true);
        animator.SetBool("Page3", false);
    }

    private void GoToPage3()
    {
        animator.SetBool("Page1", false);
        animator.SetBool("Page2", false);
        animator.SetBool("Page3", true);
    }

    private void GoBackToPage1()
    {
        animator.SetBool("Page1", false);
        animator.SetBool("Page2", true);
        animator.SetBool("Page3", false);
    }

    private void GoBackToPage2()
    {
        animator.SetBool("Page1", true);
        animator.SetBool("Page2", false);
        animator.SetBool("Page3", false);
    }


}