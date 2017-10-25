using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

/// <summary>
/// Exam01의 Zenejct 버전
/// </summary>
namespace DI.Exam02
{
   

    public class Client 
    {
        Lecture mLecture = null;
        Settings mSettings = null;


        [Inject]
        public void Construct(Grader grader,Settings settings)
        {
            mLecture = new Lecture(grader, settings.A, settings.B, settings.C);
            Debug.LogFormat("Grade : {0}", mLecture.Grade());
        }

        //public void Initialize()
        //{
        //    Debug.LogFormat("Grade : {0}", mLecture.Grade());
        //}

        [System.Serializable]
        public class Settings
        {
            public int A;
            public int B;
            public int C;
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
        string Grade(int a, int b, int c);
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



