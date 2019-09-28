using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Odc3.Odc3_Utils;

namespace Odc3
{
	public class UnityEventFunctionsRenderingCamera : MonoBehaviour
	{
		#region Rendering
		// Zanim kamera zrobi culling (można zmieniać parametry kamery)
		private void OnPreCull()
		{
			Log();
		}

		// Zanim kamera zacznie renderować (można zmieniać ustawiania środowiska do renderowania ale nie parametry kamery)
		private void OnPreRender()
		{
			Log();
		}

		// Po wyrenderowaniu sceny można wyrenderować własną geometrię przez np. Graphics.DrawMeshNow
		private void OnRenderObject()
		{
			Log();
		}

		// Jak OnRenderObject
		private void OnPostRender()
		{
			Log();
		}

		// Po wyrenderowaniu wszystkiego, służy do postprocessing'u (efektów nakładych na cały obraz)
		private void OnRenderImage( RenderTexture source, RenderTexture destination )
		{
			Log();
			Graphics.Blit( source, destination ); // Należy przynajmniej przepisać texturę, inaczej będą błędy
		}
		#endregion Rendering
	}
}
