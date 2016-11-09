using UnityEngine;
using System.Collections;
using ZXing;
using ZXing.QrCode;

public class Zing : MonoBehaviour {

    private Texture2D encoded;//儲存QR Code圖片
    private string QRCodeString;//儲存要轉為QR Code的字串

     void Start ()
    {
        encoded = new Texture2D(256, 256);//設定QR Code圖片大小
        QRCodeString = "https://www.google.com";//要轉為QR Code的字串，在此使用google的英文首頁
    }

    void Update()
    {
        QRCodeString = loadrext2.url;
        Color32[] color32 = useEncode(QRCodeString, encoded.width, encoded.height);//儲存產生的QR Code
        encoded.SetPixels32(color32);//設定要顯示的圖片像素
        encoded.Apply();//申請顯示圖片
    }

    /// <summary>
    /// 將字串進行編碼動作(字串轉QR Code)，回傳值為Color32[]
    /// </summary>
    /// <param name="textForEncoding">要被轉換成QR Code的字串</param>
    /// <param name="width">QR Code的寬度</param>
    /// <param name="height">QR Code的高度</param>
    /// <returns></returns>
    private Color32[] useEncode(string textForEncoding, int width, int height)
    {
        //開始進行編碼動作
        BarcodeWriter writer = new BarcodeWriter
        {
            Format = BarcodeFormat.QR_CODE,//設定格式為QR Code
            Options = new QrCodeEncodingOptions//設定QR Code圖片寬度和高度
            {
                Height = height,
                Width = width
            }
        };
        return writer.Write(textForEncoding);//將字串寫入，同時回傳轉換後的QR Code
    }

    void OnGUI()
    {
        //將QR Code繪製到畫面上
        GUI.DrawTexture(new Rect(1100, 250, 256, 256), encoded);
    }
}
