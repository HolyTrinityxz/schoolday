using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public GameObject Player;
    public GameObject Hint;
    public int _NumScen;
    public bool _IsOnTrigger;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _IsOnTrigger = true;
        Hint.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _IsOnTrigger = false;
        Hint.SetActive(false);
    }

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.E)) && _IsOnTrigger)
        {
            SceneManager.LoadScene(_NumScen);
        }
    }
}
