using UnityEngine;
using SF = UnityEngine.SerializeField;

namespace Odc3
{
	public class FrameRateSetter : MonoBehaviour
	{
		[SF][Range(1, 30)] private int _frameRate = 2;
		private int _lastFrameRate = -1;

		private void Awake()
		{
			TrySetFrameRate();
		}

		private void Update()
		{
			if ( Input.GetKeyDown( KeyCode.P ) )
			{
				_frameRate++;
			}
			if ( Input.GetKeyDown( KeyCode.M ) )
			{
				_frameRate--;
			}

			TrySetFrameRate();
		}

		private void TrySetFrameRate()
		{
			_frameRate = Mathf.Clamp( _frameRate, 1, 30 );
			if(_frameRate != _lastFrameRate )
			{
				Odc3_Utils.SetFramerate( _frameRate );
				_lastFrameRate = _frameRate;
			}
		}
	}
}
