using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    
    Queue<string> sentencesToDisplay;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Image portrait;
    public bool dialogIsOn = false;
    public Animator anim;

    Dialogue[] currentListOfDialogues;
    int currentDialogue = 0;

    void Start()
    {
        sentencesToDisplay = new Queue<string>();
    }

    public void StartDialogue(Dialogue[] dialogues)
    {   
        if(currentDialogue == 0) anim.SetBool("isOpen", true);
        dialogIsOn = true;
        sentencesToDisplay.Clear();
        currentListOfDialogues = dialogues;
        Dialogue dialogue = dialogues[currentDialogue];
        
        nameText.text = dialogue.name;
        portrait.sprite = dialogue.portrait;

        foreach (string sentence in dialogue.sentences)
        {
            sentencesToDisplay.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentencesToDisplay.Count == 0)
        {
            currentDialogue++;
           if(currentDialogue < currentListOfDialogues.Length)
           {
                StartDialogue(currentListOfDialogues);
           }
           else
           {
               EndDialogue();
               return;
           }
        }
        string sentence = sentencesToDisplay.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }


    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }

    }

    void EndDialogue()
    {
        anim.SetBool("isOpen", false);
        currentDialogue = 0;
        dialogIsOn = false;
    }
}
