using System.Diagnostics;
using UnityEngine;

namespace Odc3
{
	public static class Odc3_Utils
	{
		public static void Log(string arg = null)
		{
			var stackTrace = new StackTrace();
			var stackMethod = stackTrace.GetFrame(1).GetMethod();
			var callerMethod = stackMethod.Name;
			var caller = stackMethod.ReflectedType.Name;
			UnityEngine.Debug.Log( $"On frame: {Time.frameCount} called from {callerMethod} by {caller}" + 
				(string.IsNullOrWhiteSpace( arg ) ? "" : $" with arg {arg}" ) );
		}

		public static void SetFramerate( int frameRate )
		{
			QualitySettings.vSyncCount = 0;
			Application.targetFrameRate = frameRate;
		}
	}
}
