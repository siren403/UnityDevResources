using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skill
{

    public class SkillManager : MonoBehaviour
    {
        private static SkillManager mInst = null;
        public static SkillManager Inst
        {
            get
            {
                if (mInst == null)
                {
                    mInst = FindObjectOfType<SkillManager>();

                    if (mInst == null)
                    {
                        mInst = new GameObject("SkillManager").AddComponent<SkillManager>();
                    }
                }
                return mInst;
            }
        }

        public SpikeTrap SpikeTrap;
        public Impale Impale;
        public Bolas Bolas;
        public SmokeScreen SmokeScreen;
        public RapidFire RapidFire;
        public HungeringArrow HungeringArrow;
        public Ambush Ambush;

        public List<ISkill> AllSkills = new List<ISkill>();


        private void Start()
        {

        }


        public void Setting()
        {
            AllSkills.Add(SpikeTrap);
            AllSkills.Add(Impale);
            AllSkills.Add(Bolas);
            AllSkills.Add(SmokeScreen);
            AllSkills.Add(RapidFire);
            AllSkills.Add(HungeringArrow);
            AllSkills.Add(Ambush);

            foreach (ISkill skill in AllSkills)
            {

            }
           
        }
    }
}
