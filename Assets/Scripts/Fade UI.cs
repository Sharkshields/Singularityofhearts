using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeUI : MonoBehaviour
{
    // Start is called before the first frame update

    public CanvasGroup uiElement;

    public void FadeIn()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 1));
    }

    public void FadeOut()
    {
        StartCoroutine(FadeCanvasGroup(uiElement, uiElement.alpha, 0));
    }
    public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerptime = 0.5f)
    {
        float _timestartedlerping = Time.time;
        float timesincestarted = Time.time - _timestartedlerping;
        float percentagecomplete = timesincestarted / lerptime;

        while (true)
        {
            timesincestarted = Time.time - _timestartedlerping;
            percentagecomplete = timesincestarted / lerptime;
            float currentvalue = Mathf.Lerp(start, end, percentagecomplete);

            cg.alpha = currentvalue;

            if (percentagecomplete >= 1) break;

            yield return new WaitForEndOfFrame();
         }
            
        print("fading done...");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
