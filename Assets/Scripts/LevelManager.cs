using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    static int idGroup = 1;

    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;
    public Button button11;
    public Button button12;
    public Button button13;
    public Button button14;
    public Button button15;
    public Button button16;
    public Button button17;
    public Button button18;
    public Button button19;
    public Button button20;
    public Button button21;
    public Button button22;
    public Button button23;
    public Button button24;

    public Button groupe1;
    public Button groupe2;
    public Button groupe3;
    public Button groupe4;

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

    public void Button1()
    {
        Debug.Log("Bouton 1 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(0, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }

    public void Button2()
    {
        Debug.Log("Bouton 2 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(1, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }

    public void Button3()
    {
        Debug.Log("Bouton 3 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(2, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }

    public void Button4()
    {
        Debug.Log("Bouton 4 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(3, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button5()
    {
        Debug.Log("Bouton 5 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(4, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button6()
    {
        Debug.Log("Bouton 6 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(5, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button7()
    {
        Debug.Log("Bouton 7 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(0, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button8()
    {
        Debug.Log("Bouton 8 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(1, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button9()
    {
        Debug.Log("Bouton 9 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(2, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button10()
    {
        Debug.Log("Bouton 10 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(3, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button11()
    {
        Debug.Log("Bouton 11 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(4, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button12()
    {
        Debug.Log("Bouton 12 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(5, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button13()
    {
        Debug.Log("Bouton 13 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(0, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button14()
    {
        Debug.Log("Bouton 14 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(1, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button15()
    {
        Debug.Log("Bouton 15 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(2, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button16()
    {
        Debug.Log("Bouton 16 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(3, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button17()
    {
        Debug.Log("Bouton 17 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(4, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button18()
    {
        Debug.Log("Bouton 18 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(5, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button19()
    {
        Debug.Log("Bouton 19 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(0, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button20()
    {
        Debug.Log("Bouton 20 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(1, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button21()
    {
        Debug.Log("Bouton 21 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(2, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button22()
    {
        Debug.Log("Bouton 22 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(3, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button23()
    {
        Debug.Log("Bouton 23 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(4, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button24()
    {
        Debug.Log("Bouton 24 cliqué");
        Text text = button1.GetComponent<Text>();
        text.text = (idGroup.ToString());
        if (setGroup(5, 3))
        {
            Debug.Log("Win");
            Win();
        }
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



    static bool setGroup(int j, int i)
    {
        if (puzzle1[i, j, 1] != idGroup)
        {
            if (puzzle1[i, j, 1] == 1)
                group1.Remove(puzzle1[i, j, 0].ToString());
            else if (puzzle1[i, j, 1] == 2)
                group2.Remove(puzzle1[i, j, 0].ToString());
            else if (puzzle1[i, j, 1] == 3)
                group3.Remove(puzzle1[i, j, 0].ToString());
            else if (puzzle1[i, j, 1] == 4)
                group4.Remove(puzzle1[i, j, 0].ToString());
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
        return checkPuzzle();
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

    public void Win()
    {

    }
}
