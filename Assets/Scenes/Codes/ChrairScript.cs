using UnityEngine;
using UnityEngine.SceneManagement;

public class ChrairScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject PAC;
    public GameObject HintE;
    public GameObject HintQ;
    public bool _IsOnTrigger;
    public Animator Anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _IsOnTrigger = true;
        HintE.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _IsOnTrigger = false;
        HintE.SetActive(false);
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.E)) && _IsOnTrigger)
        {
            Player.SetActive(false);
            PAC.SetActive(true);
            HintQ.SetActive(true);
            Anim.SetBool("StartOpen", true);

        }
        if (Input.GetKeyDown(KeyCode.Q) && _IsOnTrigger == false) 
        {
            Player.SetActive(true);
            PAC.SetActive(false);
            HintQ.SetActive(false);
            Anim.SetBool("StartOpen", false);
        }
    }
}
