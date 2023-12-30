using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdNew : MonoBehaviour
{

    void Start()
    {
        FindDivisors(22, 42);
    }

    public void FindDivisors(int a, int b) // function for finding divisors.
    {
        ArrayList fullList = new ArrayList();
        ArrayList divByTwo = new ArrayList();
        ArrayList divByThree = new ArrayList();
        ArrayList divByFour = new ArrayList();
        ArrayList divByFive = new ArrayList();

        string fullListStr = " ";
        string divByTwoStr = " ";
        string divByTreeStr = " ";
        string divByFourStr= " ";
        string divByFiveStr = " ";


        for (int i = a; i <= b; i++)

        {
            fullList.Add(i);
            fullListStr += " " + i + "," ;
        }
        // list of divided into 2,3,4,5
        foreach (int elements in fullList)
        {
            int remainder = elements % 2;
            if (remainder == 0)
            {
                divByTwoStr += " " + elements + ",";
            }

            remainder = elements % 3;
            if (remainder == 0)
            {
                divByTreeStr += " " + elements + ",";
            }

            remainder = elements % 4;
            if (remainder == 0)
            {
                divByFourStr += " " + elements + ",";
            }

            remainder = elements % 5;
            if (remainder == 0)
            {
                divByFiveStr += " " + elements + ",";
            }

           

        }
        
        print("Full List: " + fullListStr);
        print("Divided by two: " + divByTwoStr);
        print("Divided by three: " + divByTreeStr);
        print("Divided by four: " + divByFourStr);
        print("Divided by five: " + divByFiveStr);

    }
}
