using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordManager : MonoBehaviour
{
    public List<Word> words;

    public WordSpawner wordSpawner;
    // public Transform target;
    // public Transform Word;
    private bool hasActiveWord;
    // private bool target;
    private Word activeWord;

    public void AddWord ()
    {
        Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
        Debug.Log(word.word);

        words.Add(word);
    }

    public void TypeLetter (char letter)
    {
        if (hasActiveWord)
        {
            if (activeWord.GetNextLetter() == letter)
            {
                activeWord.TypeLetter();
            }
        }
        else
        {
            foreach(Word word in words)
            {
                if (word.GetNextLetter() == letter)
                {
                    activeWord = word;
                    // target = true;
                    // target.position = Word.position;
                    hasActiveWord = true;
                    word.TypeLetter();
                    break;
                }
            }
        }

        // if (target)
        // {
            // Word.tag = "target";
        // }

        if (hasActiveWord && activeWord.WordTyped())
        {
            hasActiveWord = false;
            // target = false;
            words.Remove(activeWord);
        }
    }
}
