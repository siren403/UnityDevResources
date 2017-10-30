namespace CustomDebug
{

    /// <summary>
    /// 로그 출력 여부를 전역적으로 처리하기위한 맞춤클래스
    /// 날짜+로그와 Conditional사용 코드를 참조하여 제작
    /// </summary>
    public static class CDebug
    {
        private const string DATE_FORMAT = "yy/MM/dd-HH:mm:ss ";
        private const string CONDITION_LOG = "ENABLE_LOG";

        private static string GetDateString()
        {
            return System.DateTime.Now.ToString(DATE_FORMAT);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void Log(object message)
        {
            message = GetDateString() + message;
            UnityEngine.Debug.Log(message);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void Log(object message, UnityEngine.Object context)
        {
            message = GetDateString() + message;
            UnityEngine.Debug.Log(message, context);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogError(object message)
        {
            message = GetDateString() + message;
            UnityEngine.Debug.LogError(message);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogError(object message, UnityEngine.Object context)
        {
            message = GetDateString() + message;
            UnityEngine.Debug.LogError(message, context);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogErrorFormat(string format, params object[] args)
        {
            format = GetDateString() + format;
            UnityEngine.Debug.LogErrorFormat(format, args);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogErrorFormat(UnityEngine.Object context,
                                          string format, params object[] args)
        {
            format = GetDateString() + format;
            UnityEngine.Debug.LogErrorFormat(context, format, args);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogFormat(string format, params object[] args)
        {
            format = GetDateString() + format;
            UnityEngine.Debug.LogFormat(format, args);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogFormat(UnityEngine.Object context,
                                     string format, params object[] args)
        {
            format = GetDateString() + format;
            UnityEngine.Debug.LogFormat(context, format, args);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogWarning(object message)
        {
            message = GetDateString() + message;
            UnityEngine.Debug.LogWarning(message);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogWarning(object message, UnityEngine.Object context)
        {
            message = GetDateString() + message;
            UnityEngine.Debug.LogWarning(message, context);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogWarningFormat(string format, params object[] args)
        {
            format = GetDateString() + format;
            UnityEngine.Debug.LogWarningFormat(format, args);
        }
        [System.Diagnostics.Conditional(CONDITION_LOG)]
        public static void LogWarningFormat(UnityEngine.Object context,
                                            string format, params object[] args)
        {
            format = GetDateString() + format;
            UnityEngine.Debug.LogWarningFormat(context, format, args);
        }
    }
}
