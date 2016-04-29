using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WarningWindow : MonoBehaviour {

    [SerializeField]
    private Text text;

    public void active(string value)
    {
        text.text = value;
        gameObject.SetActive(true);
    }

    public void close()
    {
        gameObject.SetActive(false);
    }
}
