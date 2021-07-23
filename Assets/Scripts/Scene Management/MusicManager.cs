using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicManager : MonoBehaviour
{
    private SaveMusic music;

    void Start()
    {
        StartCoroutine(IgetScene());
    }

    private IEnumerator IgetScene()
    {
        if (SceneManager.GetActiveScene().name == "Main Menu" || SceneManager.GetActiveScene().name == "Settings" )
        {
            music = FindObjectOfType<SaveMusic>();
            music.gameObject.SetActive(true);
            DontDestroyOnLoad(music.gameObject);
        }
        else
        {
            music.gameObject.SetActive(false);
        }
        yield break;
    }
}
