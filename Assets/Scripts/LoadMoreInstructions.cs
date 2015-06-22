using UnityEngine;
using System.Collections;

public class LoadMoreInstructions : MonoBehaviour {

    public void OnClick() 
    {
        Application.LoadLevel("InstructionsLevel2");
    }
}
