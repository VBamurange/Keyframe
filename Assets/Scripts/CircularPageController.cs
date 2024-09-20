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

    private enum PageState
    {
        //Page1,
        //Page2,
        //Page3
        Panel1,
        Panel2,
        Panel3
    }

    private PageState _currentPage;
    

    private void Start()
    {
        

        _currentPage = PageState.Panel1;
        

        SetButtonListeners();
    }


    private void SetButtonListeners()
    {
        nextButton1.onClick.AddListener(() => TransitionToPage(PageState.Panel2));
        nextButton2.onClick.AddListener(() => TransitionToPage(PageState.Panel3));
        prevButton1.onClick.AddListener(() => TransitionToPage(PageState.Panel1));
        prevButton2.onClick.AddListener(() => TransitionToPage(PageState.Panel2));
    }

    private void TransitionToPage(PageState targetPage)
    {
        animator.SetBool("Page1", targetPage == PageState.Panel1);
        animator.SetBool("Page2", targetPage == PageState.Panel2);
        animator.SetBool("Page3", targetPage == PageState.Panel3);

        _currentPage = targetPage;

    }

}