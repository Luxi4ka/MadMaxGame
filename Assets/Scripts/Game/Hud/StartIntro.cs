using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class StartIntro : MonoBehaviour
{
    public float fadeDuration;
    public float timeDestroy;
    public float waiting;
    void Start()
    {
        StartCoroutine(FadeEnd());
    }
    public IEnumerator FadeEnd()
    {
        yield return new WaitForSecondsRealtime(waiting);
        GetComponent<Image>().CrossFadeAlpha(0, fadeDuration,false);
        Destroy(gameObject, timeDestroy);
    }
}
