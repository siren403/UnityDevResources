using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skill
{
    [System.Serializable]
    public abstract class DHActiveSkill : ActiveSkill
    {
        public HunterSkillCategory Category;
        public HunterResource RequireResource;
    }
}
