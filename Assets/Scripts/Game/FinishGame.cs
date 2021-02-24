using UnityEngine;
using UnityEngine.UI;

public class FinishGame : MonoBehaviour
{
    public Button buttonRestart;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        buttonRestart.gameObject.SetActive(true);
    }
}
