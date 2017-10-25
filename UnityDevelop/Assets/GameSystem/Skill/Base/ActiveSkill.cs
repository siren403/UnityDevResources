using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skill
{
    [System.Serializable]
    public abstract class ActiveSkill : SkillBase
    {
        public int UseCost;
        public float CoolTime;
    }
}
