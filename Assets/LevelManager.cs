using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{


    #region Level1

    static int idGroup = 1;


    public void Grp1()
    {
        Debug.Log("Groupe 1 selectionné");
        idGroup = 1;
    }
    public void Grp2()
    {
        Debug.Log("Groupe 2 selectionné");
        idGroup = 2;
    }

    public void Grp3()
    {
        Debug.Log("Groupe 3 selectionné");
        idGroup = 3;
    }
    public void Grp4()
    {
        Debug.Log("Groupe 4 selectionné");
        idGroup = 4;
    }



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



    static void setGroup(int i, int j)
    {
        // Faire la partie graphique
        if (puzzle1[i, j, 1] != idGroup)
        {
            if (idGroup == 1)
                group1.Add(puzzle1[i, j, 0].ToString());
            else if (idGroup == 2)
                group2.Add(puzzle1[i, j, 0].ToString());
            else if (idGroup == 3)
                group3.Add(puzzle1[i, j, 0].ToString());
            else if (idGroup == 4)
                group4.Add(puzzle1[i, j, 0].ToString());
            puzzle1[i, j, 1] = idGroup;
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




   

    
    #endregion


    
}
