﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {
    public Dialogue dialogue;
    
    public static DialogueTrigger instance = null;

    private void Start() {
        instance = this;
    }

    public void TriggerDialogue() {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        // DialogueManager.instance.StartDialogue(dialogue);
    }
}