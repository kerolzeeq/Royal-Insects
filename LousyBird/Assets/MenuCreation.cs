using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MenuCreation : MonoBehaviour
{
    public GameObject character;

    public void Submit()
    {
       // PrefabUtility.SaveAsPrefabAsset(character, "Assets/Bluebat.prefab");
        SceneManager.LoadScene(4);
    }
}
