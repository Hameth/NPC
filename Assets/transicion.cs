using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transicion : MonoBehaviour
{
    private Animator _transitionAnim;
    // Start is called before the first frame update
    void Start()
    {
        _transitionAnim = GetComponent<Animator>(); 
    }

    public void LoadScene(string scene)
    {
        StartCoroutine(Transiciona(scene));
    }

    IEnumerator Transiciona (string scene)
    {
        _transitionAnim.SetTrigger("salida");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);
    }
}
