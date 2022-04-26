using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetinKontrolcusu : MonoBehaviour
{

    /*
    ÖNEMLİ!: Bu koların çalışma mantığını iyi bir şekilde anlamak için lütfen aşağıdaki linkte bulunan YouTube videosunu izleyin.
    https://youtu.be/6otMzicEsjI
    */

    // Burada diğer koda erişmek için gerekli ataaları yapıyoruz.
    public DilKontrolcusu DilKodu;
    public GameObject DilKoduObj;
    // bu string, scene de bulunan yazıların bulunduğu listedir. Sceneiçindeki yazılarıu listeye atınız.
    public List<Text> Metinler;
    void Start()
    {
        // Bu kısımdadiğer koda erişiyoruz.
        DilKodu = DilKoduObj.GetComponent<DilKontrolcusu>();
        // Burada Dilk kontrolcüsükodundakidil değişkenini playerprefseeşitliyoruz.
        DilKodu.Dil = DilKodu.Dil = PlayerPrefs.GetString("Dil");
       // Burada ise metinleri seçilen dile göredüzenliyoruz.
        if (DilKodu.Dil == "Turkish")
        {
            Metinler[0].text = "Merhaba";
            Metinler[1].text = "Hoş Geldiniz";
            Metinler[2].text = "Oyuna Başla";
        }
            else if (DilKodu.Dil == "English")
            {
                Metinler[0].text = "Hello";
                Metinler[1].text = "Welcome";
                Metinler[2].text = "Play Game";
            }
        
    }
    // Kolay gelsin.

    // NBlackDev || www.github.com/nblackdev
    // 26.04.2022
}
