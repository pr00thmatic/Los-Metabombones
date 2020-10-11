using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMusic : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip engineStartClip;
    public AudioClip engineLoopClip;
    void Start()
    {
        GetComponent<AudioSource> ().loop = true;
        StartCoroutine(playEngineSound());
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator playEngineSound()
    {
        GetComponent<AudioSource>().clip = engineStartClip;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(GetComponent<AudioSource>().clip.length);
        GetComponent<AudioSource>().clip = engineLoopClip;
        GetComponent<AudioSource>().Play();
    }
    
}
