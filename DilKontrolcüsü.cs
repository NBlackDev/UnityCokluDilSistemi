using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DilKontrolc�s� : MonoBehaviour
{
    public int OtoDilDurum;
    public string Dil;
    // bunlar dil se�im butonlar�, tercihinize g�re �o�alt�n
    public Button TurkceButton, IngilizceButton;
    // bu string, scene de bulunan yaz�lar�n bulundu�u listedir. Scenei�indeki yaz�lar�u listeye at�n�z.
    public List<Text> Metinler;

    private void Awake()
    {
       // otodildurum ded�imiz ise sisemin dili otomatik olarak � belirleyece�i, yoksa kullan�c�n�n daha �ceden belirleyip belirlemedi�ini kontrol eden sistemdir.
       // bu de�er 1 olursa sistem otomatikbelirler 2 olursa kullan�c�n�n dil tercihi hat�rlan�r.
       OtoDilDurum = PlayerPrefs.GetInt("OtoDilDurum", OtoDilDurum);
       Dil = PlayerPrefs.GetString("Dil", Dil);

    }
    void Start()
    { 
        // ilk giri�te otodildurumu de�i�keni 0 oldu�u i�in 1 yap�p sistemi oto halegtiriyor.
        if(OtoDilDurum == 0)
        {
            OtoDilDurum = 1;
            PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
        }
        // e�er otodil durum 1 ise otomatik dil belirleme sstemi �al���yor
        if(OtoDilDurum == 1)
        {
            // bu k�s�mda e�er cihaz dili T�rk�e ise dil de�i�keninini T�rk�e'ye e�itliyor.
            if(Application.systemLanguage == SystemLanguage.Turkish)
            {
                Dil = "Turkish";
                PlayerPrefs.SetString("Dil", Dil);
            }
            // bu k�s�mda e�er cihaz dili �ngilizce ise dil de�i�keninini �ngilizce'ye e�itliyor.
            else if (Application.systemLanguage == SystemLanguage.English)
            {
                Dil = "English";
                PlayerPrefs.SetString("Dil", Dil);
            }
            // bu k�s�mda eper cihaz dili yukar�da tan�m� dillerden biri de�ilse sizin belirledi�iniz varsay�lan bir dile e�itliyor.
            // �rne�in, T�rk�e,�ngilizce ve Rus�a dillerini tan�mlad�n�z ama Arap�a bir dil ile oyuna giri� yap�ld�o haldeoyun T�rk�e a��lacak gibi.
            else
            {
                Dil = "Turkish";
                PlayerPrefs.SetString("Dil", Dil);
            }

        }
        // burada da e�er dilT�rk�e ise gerekli metin ayarlamalar�n� yap�yoruz.
        //siz bu alan� kendi metinlerinize g�red�zenleyin.
        if (Dil == "Turkish")
            {
                TurkceButton.interactable = false;
                IngilizceButton.interactable = true;
            Metinler[0].text = "Merhaba";
            Metinler[1].text = "Ho� Geldiniz";
            Metinler[2].text = "Oyuna Ba�la";
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
    // Bu voidkullan�c�n�n T�rk�e dilini se�mesi i�in olu�turuldu.
    // E�er kullan�c� kendisi se�inyaparsa OtoDilDurum de�i�keni 2 oluyor ve bundan sonra a��l��ta sistem dili otomatik de�il de kullan�c� se�mine g�re belirliyor.
    public void TurkceSec()
    {
        OtoDilDurum = 2;
        Dil = "Turkish";
        PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
        PlayerPrefs.SetString("Dil", Dil);
        Start();

    }
    // Bu voidkullan�c�n�n �ngilizce dilini se�mesi i�in olu�turuldu.
    // E�er kullan�c� kendisi se�inyaparsa OtoDilDurum de�i�keni 2 oluyor ve bundan sonra a��l��ta sistem dili otomatik de�il de kullan�c� se�mine g�re belirliyor.
    public void IngilizceSec()
    {
        OtoDilDurum = 2;
        Dil = "English";
        PlayerPrefs.SetInt("OtoDilDurum", OtoDilDurum);
        PlayerPrefs.SetString("Dil", Dil);
        // Bursada kodu start a g�ndermesebebimiz,kodu en ba�tan ba�latarak metinlerin g�ncellenmesini sa�lamak.
        Start();

    }

    //Siz ekleyece�iiz dillere g�re Ing�l�zceSec, TurkceSec gibi fonksiyonlar� RuscaSec vb. gibi �o�altabilirsiniz.
    // Ayr�ca startk�sm�ndaki otomatik tan�mlama k�sm�n� da �o�altmay� unutmay�n.

    // Kolay gelsin.

    // NBlackDev || www.github.com/nblackdev
    // 25.04.2022


}
