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
		var webViewGameObject = new GameObject("UniWebView");
		webView = webViewGameObject.AddComponent<UniWebView>();

		webView.Frame = new Rect(Screen.width * 2, Screen.height * 2, Screen.width, Screen.height);
		//webView.Frame = new Rect(0, 0, Screen.width, Screen.height);
		string url = UniWebViewHelper.StreamingAssetURLForPath("html/printUSLetter.html");

		webView.Load(url);
		webView.Show();

		webView.OnPageFinished += (view, statusCode, loadedUrl) =>
		{
			webView.OnMessageReceived += OnMessageReceived;
			string jsCode = "setImages('" + frontImage + "','" + backImage + "');";
			webView.EvaluateJavaScript(jsCode);
		};
	}

	void OpenPrintDialog()
	{
		if (front_loaded && back_loaded)
		{
			webView.Print();
			back_loaded = false;
			front_loaded = false;
		}
	}

	void OnMessageReceived(UniWebView view, UniWebViewMessage message)
	{
		if (message.Path == "front_loaded")
		{
			front_loaded = true;
			OpenPrintDialog();
		}
		if (message.Path == "back_loaded")
		{
			back_loaded = true;
			OpenPrintDialog();
		}
/*		if (message.Path == "close")
		{
			webView.Hide();
		}*/
	}
}
