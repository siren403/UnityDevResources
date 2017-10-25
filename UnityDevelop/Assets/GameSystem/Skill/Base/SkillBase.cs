using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Skill
{
    [System.Serializable]
    public abstract class SkillBase : ISkill
    {
        public string Name;
        public Sprite SkillIcon;
        public Characters BelongToWho;
        public string Description;
    }
}
