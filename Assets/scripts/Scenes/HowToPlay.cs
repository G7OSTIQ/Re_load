using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject howtoplaypanel;
    
    void Start()
    {
        howtoplaypanel.SetActive(false);
    }

    public void OpenPanel()
    {
        howtoplaypanel.SetActive(true);
    }

    public void ClosePanel()
    {
        howtoplaypanel.SetActive(false);
    }
}