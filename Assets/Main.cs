using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    // === Using delegate
    // public delegate int CharacterLength(string text);
    // CharacterLength cl;

    // === Using Func
    // *** if no parameter, <return Type>
    // public Func<int> CharacterLength;
    // *** if has parameter, <param type, return type>
    public Func<string, int> CharacterLength;


    void Start()
    {
        // === Using delegate
        // cl = GetCharacters;
        // Debug.Log(cl("Louf"));

        // === Using Func
        // CharacterLength = GetCharacters;

        // === Using Lambda
        CharacterLength = (name) => name.Length;

        int count = CharacterLength("Maelouf");
        Debug.Log(count);
    }

    // === Using Lambda
    // === This method can be inline
    // int GetCharacters(string text)
    // {
    //     return text.Length;
    // }
}
