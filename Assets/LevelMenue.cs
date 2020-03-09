using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMenue : MonoBehaviour
{
    public static bool OnLevel = false;

    public GameObject Level1UI;

    GameObject RefUI;


    // BLEU = 1
    // ROUGE = 2
    // VERT = 3
    // JAUNE = 4
    // ORANGE = 5
    // MAGENTA = 6

    static int[,,] puzzle1 =
    {
            {{1,0},{4,0},{5,0},{4,0},{3,0},{2,0}},
            {{3,0},{2,0},{6,0},{1,0},{3,0},{4,0}},
            {{3,0},{5,0},{2,0},{6,0},{5,0},{1,0}},
            {{6,0},{4,0},{5,0},{1,0},{2,0},{6,0}}
        };

    static ArrayList group1 = new ArrayList();
    static ArrayList group2 = new ArrayList();
    static ArrayList group3 = new ArrayList();
    static ArrayList group4 = new ArrayList();

    public void Level1()
    {
        if (!OnLevel)
        {
            OnLevel = true;
            Level1UI.SetActive(true);
            RefUI = Level1UI;

        }
    }

    static void setGroup(int group, int i, int j)
    {
        // Faire la partie graphique
        if (puzzle1[i, j, 1] != group)
        {
            if (group == 1)
                group1.Add(puzzle1[i, j, 0].ToString());
            else if (group == 2)
                group2.Add(puzzle1[i, j, 0].ToString());
            else if (group == 3)
                group3.Add(puzzle1[i, j, 0].ToString());
            else if (group == 4)
                group4.Add(puzzle1[i, j, 0].ToString());
            puzzle1[i, j, 1] = group;
        }
    }

    static bool checkPuzzle()
    {
        if (group1.Count == group2.Count && group2.Count == group3.Count && group3.Count == group4.Count &&
            group4.Count == 6)
        {
            bool ok = true;
            foreach (string x in group1)
            {
                int i = 0;
                foreach (string y in group1)
                {
                    if (x.Equals(y))
                        i++;
                }
                if (i != 1)
                    ok = false;
            }

            if (ok)
            {
                foreach (string x in group2)
                {
                    int i = 0;
                    foreach (string y in group2)
                    {
                        if (x.Equals(y))
                            i++;
                    }
                    if (i != 1)
                        ok = false;
                }
            }
            if (ok)
            {
                foreach (string x in group3)
                {
                    int i = 0;
                    foreach (string y in group3)
                    {
                        if (x.Equals(y))
                            i++;
                    }
                    if (i != 1)
                        ok = false;
                }
            }
            if (ok)
            {
                foreach (string x in group4)
                {
                    int i = 0;
                    foreach (string y in group4)
                    {
                        if (x.Equals(y))
                            i++;
                    }
                    if (i != 1)
                        ok = false;
                }
            }
            return ok;
        }
        else
            return false;
    }

    public void QuitLevel()
    {
        if(OnLevel)
        {
            OnLevel = false;
            RefUI.SetActive(false);
            RefUI = null;
        }
    }
}
