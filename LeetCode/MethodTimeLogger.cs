using Microsoft.Extensions.Logging;
using System.Reflection;

namespace MethodMeasure;

public static class MethodTimeLogger
{
    public static ILogger Logger;
    public static void Log(MethodBase methodBase, TimeSpan timeSpan, string message)
    {
        Logger.LogInformation("{Class}.{Method} {Duration} {message}",
            methodBase.DeclaringType!.Name, methodBase.Name, timeSpan, message);
        //Logger.LogTrace("{Class}.{Method} {Duration} {message}",
        //    methodBase.DeclaringType!.Name, methodBase.Name, timeSpan, message);
        //Logger.LogDebug("{Class}.{Method} {Duration} {message}",
        //    methodBase.DeclaringType!.Name, methodBase.Name, timeSpan, message);
    }
}
