using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ListLab;

internal class LikedListMain
{
    public static void Main(string[] args)
    {

        // יצירת משתנה שמצביע על ראש הרשימה
        //Node<int> myLinkedList = null;
        Node<int> myLinkedList = new Node<int>(1);

        // לולאת for להוספת 10 חוליות לרשימה
        for (int i = 2; i <= 10; i++)
        {
            // יצירת חוליה חדשה עם הערך i והחוליה הקודמת (head)
            myLinkedList = new Node<int>(i, myLinkedList);
        }

        // הדפסת הרשימה
        Console.WriteLine(myLinkedList); // הפלט יהיה הרשימה המקושרת
        Console.WriteLine(myLinkedList.GetValue());



        Console.WriteLine("the sum is"+CalculateSum(myLinkedList));

        myLinkedList = new Node<int>(1, myLinkedList);
        Console.WriteLine(myLinkedList);
        Console.WriteLine(CountItemsBetweenDuplicates(myLinkedList, 1));





        // תרגיל ראשון 

        //Node<int> myLinkedList = new Node<int>(5);
        //myLinkedList = new Node<int>(10, myLinkedList);
        //myLinkedList = new Node<int>(15, myLinkedList);
        //Console.WriteLine(myLinkedList);

        // תרגיל שני
        // 



        //// יצירת הרשימה המקושרת
        //Node<int> node10 = new Node<int>(10);
        //Node<int> node9 = new Node<int>(9, node10);
        //Node<int> node8 = new Node<int>(8, node9);
        //Node<int> node6 = new Node<int>(6, node8);
        //Node<int> node5 = new Node<int>(5, node6);
        //Node<int> node4 = new Node<int>(4, node5);
        //Node<int> node3 = new Node<int>(3, node4);
        //Node<int> node2 = new Node<int>(2, node3);

        //// הדפסת הרשימה לפני הכנסת המספר 7
        //Console.WriteLine("לפני הכנסת 7:");
        //Console.WriteLine(node2);

        //// הכנסת 7 במקום הנכון
        //Node<int> currentNode = node2; // מתחילים מהחוליה הראשונה
        //Node<int> newNode = new Node<int>(7); // החוליה החדשה שאנחנו רוצים להוסיף

        //// חיפוש המיקום שבו 7 צריך להיות
        //while (currentNode != null && currentNode.GetValue() < 7)
        //{
        //    currentNode = currentNode.GetNext();
        //}

        //// הכנסה של החוליה החדשה במקום הנכון
        //if (currentNode != null)
        //{
        //    // אם יש חוליה עוקבת, אנחנו מכניסים את 7 בין החוליה הנוכחית והחוליה הבאה
        //    newNode.SetNext(currentNode);
        //    if (currentNode.GetNext() != null)
        //    {
        //        Node<int> previousNode = node2;
        //        while (previousNode.GetNext() != currentNode)
        //        {
        //            previousNode = previousNode.GetNext();
        //        }
        //        previousNode.SetNext(newNode);
        //    }
        //    else
        //    {
        //        // אם הגענו לסוף הרשימה
        //        currentNode.SetNext(newNode);
        //    }
        //}

        //// הדפסת הרשימה אחרי הכנסת 7
        //Console.WriteLine("\nאחרי הכנסת 7:");
        //Console.WriteLine(node2);
    }



    //תרגיל סריקה 1
    public static int CalculateSum(Node<int> first)
    {
        int sum = 0;
        Node<int> current = first;

        while (current != null)
        {
            sum += current.GetValue();
            current = current.GetNext();
        }

        return sum;
    }

    //תרגיל סריקה 2
    public static int CountEvenNumbers(Node<int> first)
    {
        int count = 0;
        Node<int> current = first;

        while (current != null)
        {
            if (current.GetValue() % 2 == 0)
            {
                count++;
            }
            current = current.GetNext();
        }

        return count;
    }

    //תרגיל סריקה 3
    public static int FindMaxValue(Node<int> first)
    {

        int maxValue = first.GetValue();
        Node<int> current = first.GetNext();

        while (current != null)
        {
            if (current.GetValue() > maxValue)
            {
                maxValue = current.GetValue();
            }
            current = current.GetNext();
        }

        return maxValue;
    }


    // שאלה מבגרות
    public static int CountItemsBetweenDuplicates(Node<int> first, int target)
    {
        int count = 0;
        bool foundFirst = false;
        Node<int> current = first;
        Console.WriteLine(target);

        // חיפוש שני המופעים של הערך ברשימה
        while (current != null)
        {
            if (current.GetValue() == target)
            {
                if (foundFirst)
                {
                    // אם כבר מצאנו את המופע הראשון, החזר את המספר
                    return count;
                }
                else
                {
                    // אם מצאנו את המופע הראשון
                    foundFirst = true;
                }
            }


            else
            {
                if (foundFirst) count++; // מתחילים לספור רק אחרי המופע הראשון
            }                      
            current = current.GetNext();
        }

        // אם לא מצאנו שני מופעים, מחזירים -1
        return -1;
    }
}

