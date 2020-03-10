using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Button : Interactable
{

    public LevelMenue LevelMenue;
    public override void Interact()
    {
        LevelMenue.Level1();
        base.Interact();
    }

    public override void OnDefocused()
    {
        base.OnDefocused();
        LevelMenue.QuitLevel();
    }
}
