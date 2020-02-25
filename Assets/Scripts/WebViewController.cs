using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//[RequireComponent(typeof(UnityEngine.UI.Button))]
public class WebViewController : MonoBehaviour
{
	UniWebView webView;

	public void Print()
	{
		var webViewGameObject = new GameObject("UniWebView");
		webView = webViewGameObject.AddComponent<UniWebView>();

		webView.Frame = new Rect(Screen.width, Screen.height, Screen.width, Screen.height);
		//webView.Frame = new Rect(0, 0, Screen.width, Screen.height);
		string url = UniWebViewHelper.StreamingAssetURLForPath("html/printSamplePortrait.html");

		webView.Load(url);
		webView.Show();

		webView.OnPageFinished += (view, statusCode, loadedUrl) =>
		{
			webView.Print();
		};

		webView.OnMessageReceived += (view, message) =>
		{
			if (message.Path == "close")
			{
				webView.Hide();
			}
		};
	}

}
