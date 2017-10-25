using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 직접적인 클래스에 의존하는것이 아니라
/// 행위에 의존하도록 하여 객체간의 결합도를 낮춤. 
/// </summary>
namespace DI.Exam01
{
    public class Client : MonoBehaviour
    {

        private void Awake()
        {
            Lecture lecture = new Lecture(new PassFailGrader(), 20, 20, 20);

            string grade = lecture.Grade();

            Debug.LogFormat("PassFail : {0}",grade);

            lecture = new Lecture(new StandardGrader(), 20, 20, 20);

            grade = lecture.Grade();

            Debug.LogFormat("Standard : {0}",grade);
        }


    }

    public class Lecture
    {

        private Grader mGrader = null;
        private int mA, mB, mC;

        public Lecture(Grader grader, int a, int b, int c)
        {
            mGrader = grader;
            mA = a;
            mB = b;
            mC = c;
        }

        public string Grade()
        {
            return mGrader.Grade(mA, mB, mC);
        }
    }

    public interface Grader
    {
        string Grade(int a,int b,int c);
    }

    public class PassFailGrader : Grader
    {
        public string Grade(int a, int b, int c)
        {
            int total = a + b + c;
            return total > 50 ? "Success" : "Fail";
        }
    }

    public class StandardGrader : Grader
    {
        public string Grade(int a, int b, int c)
        {
            int total = a + b + c;
            return total > 80 ? "Success" : "Fail";
        }
    }
}
