using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelMusic : MonoBehaviour
{
    // Start is called before the first frame update
    static bool firstTime = true;
    public string nextLevel = "";
    public AudioClip engineStartClip;
    public AudioClip engineLoopClip;
    void Start()
    {
        GetComponent<AudioSource> ().loop = true;
        StartCoroutine(playEngineSound());
       FadeSound();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public float fadeTime = 3; // fade time in seconds
    public void FadeSound() { 
        if(fadeTime == 0) { 
            GetComponent<AudioSource> ().volume = 0;
            return;
        }
        StartCoroutine(_FadeSound()); 
    }
    
    IEnumerator _FadeSound() {
        float t = fadeTime;
        while (t > 0) {
            yield return null;
            t-= Time.deltaTime;
            GetComponent<AudioSource> ().volume = t / fadeTime;
            Debug.Log(t);
        }
        SceneManager.LoadScene (sceneName: nextLevel);
        yield break;
    }
    IEnumerator playEngineSound()
    {
        if (firstTime) {
            GetComponent<AudioSource>().clip = engineStartClip;
            GetComponent<AudioSource>().Play();
            yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
            GetComponent<AudioSource>().clip = engineLoopClip;
            GetComponent<AudioSource>().Play();
            firstTime = false;
        } else {
            GetComponent<AudioSource>().clip = engineLoopClip;
            GetComponent<AudioSource>().Play();
        }
    }
    
}
