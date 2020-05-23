using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public GameObject Level1UI;

    public LevelMenue levelMenue;

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

    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;
    public Text text11;
    public Text text12;
    public Text text13;
    public Text text14;
    public Text text15;
    public Text text16;
    public Text text17;
    public Text text18;
    public Text text19;
    public Text text20;
    public Text text21;
    public Text text22;
    public Text text23;
    public Text text24;

    public Button groupe1;
    public Button groupe2;
    public Button groupe3;
    public Button groupe4;

    public void Grp1()
    {
        Debug.Log("Groupe 1 selectionné");
        idGroup = 1;
        groupe1.GetComponent<Image>().color = Color.green;
        groupe2.GetComponent<Image>().color = Color.white;
        groupe3.GetComponent<Image>().color = Color.white;
        groupe4.GetComponent<Image>().color = Color.white;
    }
    public void Grp2()
    {
        Debug.Log("Groupe 2 selectionné");
        idGroup = 2;
        groupe1.GetComponent<Image>().color = Color.white;
        groupe2.GetComponent<Image>().color = Color.green;
        groupe3.GetComponent<Image>().color = Color.white;
        groupe4.GetComponent<Image>().color = Color.white;
    }

    public void Grp3()
    {
        Debug.Log("Groupe 3 selectionné");
        idGroup = 3;
        groupe1.GetComponent<Image>().color = Color.white;
        groupe2.GetComponent<Image>().color = Color.white;
        groupe3.GetComponent<Image>().color = Color.green;
        groupe4.GetComponent<Image>().color = Color.white;
    }
    public void Grp4()
    {
        Debug.Log("Groupe 4 selectionné");
        idGroup = 4;
        groupe1.GetComponent<Image>().color = Color.white;
        groupe2.GetComponent<Image>().color = Color.white;
        groupe3.GetComponent<Image>().color = Color.white;
        groupe4.GetComponent<Image>().color = Color.green;
    }

    public void Button1()
    {
        Debug.Log("Bouton 1 cliqué");
        text1.text = (idGroup.ToString());
        if (setGroup(0, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }

    public void Button2()
    {
        Debug.Log("Bouton 2 cliqué");
        text2.text = (idGroup.ToString());
        if (setGroup(1, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }

    public void Button3()
    {
        Debug.Log("Bouton 3 cliqué");
        text3.text = (idGroup.ToString());
        if (setGroup(2, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }

    public void Button4()
    {
        Debug.Log("Bouton 4 cliqué");
        text4.text = (idGroup.ToString());
        if (setGroup(3, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button5()
    {
        Debug.Log("Bouton 5 cliqué");
        text5.text = (idGroup.ToString());
        if (setGroup(4, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button6()
    {
        Debug.Log("Bouton 6 cliqué");
        text6.text = (idGroup.ToString());
        if (setGroup(5, 0))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button7()
    {
        Debug.Log("Bouton 7 cliqué");
        text7.text = (idGroup.ToString());
        if (setGroup(0, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button8()
    {
        Debug.Log("Bouton 8 cliqué");
        text8.text = (idGroup.ToString());
        if (setGroup(1, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button9()
    {
        Debug.Log("Bouton 9 cliqué");
        text9.text = (idGroup.ToString());
        if (setGroup(2, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button10()
    {
        Debug.Log("Bouton 10 cliqué");
        text10.text = (idGroup.ToString());
        if (setGroup(3, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button11()
    {
        Debug.Log("Bouton 11 cliqué");
        text11.text = (idGroup.ToString());
        if (setGroup(4, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button12()
    {
        Debug.Log("Bouton 12 cliqué");
        text12.text = (idGroup.ToString());
        if (setGroup(5, 1))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button13()
    {
        Debug.Log("Bouton 13 cliqué");
        text13.text = (idGroup.ToString());
        if (setGroup(0, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button14()
    {
        Debug.Log("Bouton 14 cliqué");
        text14.text = (idGroup.ToString());
        if (setGroup(1, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button15()
    {
        Debug.Log("Bouton 15 cliqué");
        text15.text = (idGroup.ToString());
        if (setGroup(2, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button16()
    {
        Debug.Log("Bouton 16 cliqué");
        text16.text = (idGroup.ToString());
        if (setGroup(3, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button17()
    {
        Debug.Log("Bouton 17 cliqué");
        text17.text = (idGroup.ToString());
        if (setGroup(4, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button18()
    {
        Debug.Log("Bouton 18 cliqué");
        text18.text = (idGroup.ToString());
        if (setGroup(5, 2))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button19()
    {
        Debug.Log("Bouton 19 cliqué");
        text19.text = (idGroup.ToString());
        if (setGroup(0, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button20()
    {
        Debug.Log("Bouton 20 cliqué");
        text20.text = (idGroup.ToString());
        if (setGroup(1, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button21()
    {
        Debug.Log("Bouton 21 cliqué");
        text21.text = (idGroup.ToString());
        if (setGroup(2, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button22()
    {
        Debug.Log("Bouton 22 cliqué");
        text22.text = (idGroup.ToString());
        if (setGroup(3, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button23()
    {
        Debug.Log("Bouton 23 cliqué");
        text23.text = (idGroup.ToString());
        if (setGroup(4, 3))
        {
            Debug.Log("Win");
            Win();
        }
    }
    public void Button24()
    {
        Debug.Log("Bouton 24 cliqué");
        text24.text = (idGroup.ToString());
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
        levelMenue.level1done = true;
        LevelMenue.OnLevel = false;
        Cursor.lockState = CursorLockMode.Locked;
        Level1UI.SetActive(false);
    }
}
