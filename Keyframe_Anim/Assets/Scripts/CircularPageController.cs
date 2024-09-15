using UnityEngine;
using UnityEngine.UI;

public class CircularPageController : MonoBehaviour
{

    public GameObject[] pages;
    public Button nextButton;

    private int currentPage = 0;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        nextButton.onClick.AddListener(GoToNextPage);

    }

    void GoToNextPage()
    {
        // currentPage = (currentPage + 1) % pages.Length; 
        // animator.Play("Anim01"); 
        animator.SetTrigger("NextPage");
    }


}