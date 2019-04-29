using System.Collections;
using UnityEngine;
using TMPro;
using System;

public class Dialog : MonoBehaviour {


    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    IEnumerator Type()
    {
        //sorteia uma frase aleatoria
        index = this.geradorNumeroAleatorio(0, this.sentences.Length);


        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

	// Use this for initialization
	void Start () {
        StartCoroutine(Type());
	}
    // gerador de numero aleatorio
    private int geradorNumeroAleatorio(int min, int max)
    {
        System.Random rnd = new System.Random();
        return rnd.Next(min, max);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
