using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace AG.Dialogue.Example.Ex01
{
    public class DialogueTalk : DialogueGetData
    {
        private DialogueController dialogueController;

        private void Awake()
        {
            dialogueController = FindObjectOfType<DialogueController>();
        }

        public void StartDialogue()
        {
            dialogueController.StartDialogue(dialogueContainer);
        }
    }
}