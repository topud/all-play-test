using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WebViewController : MonoBehaviour
{
	UniWebView webView;
	bool back_loaded, front_loaded;

	public string frontImage = "1_portrait.png";
	public string backImage = "2_portrait.png";


	public void Print()
	{
		if (webView)
			Destroy(webView);

		var webViewGameObject = new GameObject("UniWebView");
		webView = webViewGameObject.AddComponent<UniWebView>();


		webView.Frame = new Rect(Screen.width * 2, Screen.height * 2, Screen.width, Screen.height);
		//webView.Frame = new Rect(0, 0, Screen.width, Screen.height);
		string url = UniWebViewHelper.StreamingAssetURLForPath("html/printUSLetter.html");
		//string url = "https://uniwebview.com";

		webView.Load(url);
		webView.Show();

		webView.OnPageFinished += (view, statusCode, loadedUrl) =>
		{
			webView.OnMessageReceived += OnMessageReceived;
			string jsCode = "setImages('" + frontImage + "','" + backImage + "');";
			webView.EvaluateJavaScript(jsCode);
			
		};
		
	}


	void OnMessageReceived(UniWebView view, UniWebViewMessage message)
	{
		if (message.Path == "images_loaded")
		{
			webView.Print();
		}
/*		if (message.Path == "close")
		{
			webView.Hide();
		}*/
	}
}
