using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilKontrolcüsü : MonoBehaviour
{
    public int OtoDilDurum;
    public string Dil;
    // bunlar dil seçim butonlarý, tercihinize göre çoðaltýn
    public Button TurkceButton, IngilizceButton;
    // bu string, scene de bulunan yazýlarýn bulunduðu listedir. Sceneiçindeki yazýlarýu listeye atýnýz.
    public List<Text> Metinler;

    private void Awake()
    {
       // otodildurum dedðimiz ise sisemin dili otomatik olarak ý belirleyeceði, yoksa kullanýcýnýn daha öceden belirleyip belirlemediðini kontrol eden sistemdir.
       // bu deðer 1 olursa sistem otomatikbelirler 2 olursa kullanýcýnýn dil tercihi hatýrlanýr.
       OtoDilDurum = PlayerPrefs.GetInt("OtoDilDurum", OtoDilDurum);
       Dil = PlayerPrefs.GetString("Dil", Dil);

    }
    void Start()
    { 
        // ilk giriþte otodildurumu deðiþkeni 0 olduðu için 1 yapýp sistemi oto halegtiriyor.
        if(OtoDilDurum == 0)
        {
            OtoDilDurum = 1;
            PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
        }
        // eðer otodil durum 1 ise otomatik dil belirleme sstemi çalýþýyor
        if(OtoDilDurum == 1)
        {
            // bu kýsýmda eðer cihaz dili Türkçe ise dil deðiþkeninini Türkçe'ye eþitliyor.
            if(Application.systemLanguage == SystemLanguage.Turkish)
            {
                Dil = "Turkish";
                PlayerPrefs.SetString("Dil", Dil);
            }
            // bu kýsýmda eðer cihaz dili Ýngilizce ise dil deðiþkeninini Ýngilizce'ye eþitliyor.
            else if (Application.systemLanguage == SystemLanguage.English)
            {
                Dil = "English";
                PlayerPrefs.SetString("Dil", Dil);
            }
            // bu kýsýmda eper cihaz dili yukarýda tanýmý dillerden biri deðilse sizin belirlediðiniz varsayýlan bir dile eþitliyor.
            // örneðin, Türkçe,Ýngilizce ve Rusça dillerini tanýmladýnýz ama Arapça bir dil ile oyuna giriþ yapýldýo haldeoyun Türkçe açýlacak gibi.
            else
            {
                Dil = "Turkish";
                PlayerPrefs.SetString("Dil", Dil);
            }

        }
        // burada da eðer dilTürkçe ise gerekli metin ayarlamalarýný yapýyoruz.
        //siz bu alaný kendi metinlerinize göredüzenleyin.
        if (Dil == "Turkish")
            {
                TurkceButton.interactable = false;
                IngilizceButton.interactable = true;
            Metinler[0].text = "Merhaba";
            Metinler[1].text = "Hoþ Geldiniz";
            Metinler[2].text = "Oyuna Baþla";
        }

            else if (Dil == "English")
            {
                TurkceButton.interactable = true;
                IngilizceButton.interactable = false;

            Metinler[0].text = "Hello";
            Metinler[1].text = "Welcome";
            Metinler[2].text = "Play Game";
        }
    }
    // Bu voidkullanýcýnýn Türkçe dilini seçmesi için oluþturuldu.
    // Eðer kullanýcý kendisi seçinyaparsa OtoDilDurum deðiþkeni 2 oluyor ve bundan sonra açýlýþta sistem dili otomatik deðil de kullanýcý seçmine göre belirliyor.
    public void TurkceSec()
    {
        OtoDilDurum = 2;
        Dil = "Turkish";
        PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
        PlayerPrefs.SetString("Dil", Dil);
        Start();

    }
    // Bu voidkullanýcýnýn Ýngilizce dilini seçmesi için oluþturuldu.
    // Eðer kullanýcý kendisi seçinyaparsa OtoDilDurum deðiþkeni 2 oluyor ve bundan sonra açýlýþta sistem dili otomatik deðil de kullanýcý seçmine göre belirliyor.
    public void IngilizceSec()
    {
        OtoDilDurum = 2;
        Dil = "English";
        PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
        PlayerPrefs.SetString("Dil", Dil);
        // Bursada kodu start a göndermesebebimiz,kodu en baþtan baþlatarak metinlerin güncellenmesini saðlamak.
        Start();

    }

    //Siz ekleyeceðiiz dillere göre IngýlýzceSec, TurkceSec gibi fonksiyonlarý RuscaSec vb. gibi çoðaltabilirsiniz.
    // Ayrýca startkýsmýndaki otomatik tanýmlama kýsmýný da çoðaltmayý unutmayýn.

    // Kolay gelsin.

    // NBlackDev || www.github.com/nblackdev
    // 25.04.2022


}
