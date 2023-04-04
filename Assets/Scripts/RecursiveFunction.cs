using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecursiveFunction : MonoBehaviour
{
    int i = 0;
    private void Awake()
    {
        Debug.Log("Awake Function from ReCalled");
    }
    // Start is called before the first frame update
    void Start()
    {
        //CombinationString("ABC", "", 0, 7);
        //string str = "ABCD";
        //int k = 7;
        //int i1 =CombinationString2(str, "", k);
        //print("1st check" + i);
        //print("check2" +i1);
        //IntCombo(0,"ABCD");
        Debug.Log("Start Function from Recalled");
    }
    //public void CombinationString(string str,string p,int indx,int n) 
    //{
    //    if (str.Length == 0)
    //    {
    //        print(p);
    //        return;
    //    }
    //    for (int i=0;i<str.Length;i++)
    //    {
    //        char crrnt = str[i];
    //        string newString = str.Substring(0, i) + str.Substring(i + 1);
    //        CombinationString(newString,p+crrnt,indx+1,n);
    //    }
    //}
    public int CombinationString2(string str, string p, int k)
    {
        if (k == 0)
        {
            i++;
            print(p);
            return i;
        }
        for(int i=0; i < str.Length; i++)
        {
           // char crrnt = str[i];
            string newString = p + str[i];
            CombinationString2(str, newString, k - 1);
        }
        
        return i;
    }
    public void IntCombo(int n, string str)
    {
        if (n == (str.Length - 1))
        {
            print(str[n]);
            IntCombo2(str, 0);
            return;
        }
        IntCombo(n+1,str);
        print(str[n]);
        IntCombo2(str, 0);
    }
    public void IntCombo2(string str,int n)
    {
        if(n == (str.Length - 1))
        {
            return;
        }
        print(str[n]);
        IntCombo2(str, n + 1);
    }
}
