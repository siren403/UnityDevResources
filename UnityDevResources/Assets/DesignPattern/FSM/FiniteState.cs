using System.Collections;

namespace FSM
{
    /**
     @class FiniteState<T,U>
    
     @brief 각각의 상태의 원형 클래스
    
     @author    SEONG
     @date  2017-08-28
    
     @tparam    T   상태를 가지게 되는 객체의 타입, Context.
     @tparam    U   상태를 타나내는 타입, Enum,int....
    
     ### tparam T   Entity Type.
     ### tparam U   State ID Type (EnumType Recommended)
     */
    public class FiniteState<T,U> : IState<U>  
    {
        protected T Entity;

        public void SetEntity(T entity)
        {
            this.Entity = entity;
        }

        public virtual U StateID
        {
            get
            {
                //UnityEngine.Debug.Log("Not Override StateID");
                return default(U);
            }
        }

        /// <summary>
        /// AddState로 추가된 이후 호출. 초기화 용도
        /// </summary>
        public virtual void Initialize() { }

        public virtual void Enter()
        {
            //UnityEngine.Debug.Log(StateID.ToString()+" Enter");
        }

        public virtual void Excute()
        {
            //UnityEngine.Debug.Log(StateID.ToString() + " Excute");
        }

        public virtual void Exit()
        {
            //UnityEngine.Debug.Log(StateID.ToString() + " Exit");
        }
    }

}
