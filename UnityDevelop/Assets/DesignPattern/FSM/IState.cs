using System.Collections;

namespace FSM
{
    /**
     @interface IState<T>
    
     @brief 상태가 가져야 되는 최소단위의 인터페이스
    
     @author    SEONG
     @date  2017-08-28
    
     @tparam    T   Generic type parameter.
    
     ### tparam T   해당 State의 ID 타입.
     */
    public interface IState<T>
    {
        void Enter();
        void Excute();
        void Exit();

        T StateID
        {
            get;
        }
    }
}