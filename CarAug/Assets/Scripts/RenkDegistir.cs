using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenkDegistir : MonoBehaviour
{

   [SerializeField] private GameObject[] arabalar;

   void Awake()
   {
   }
//GOVDE RENKLERİ
   private bool _sbActive = false;
   public GameObject govdeRenk;
   public void ShowBodyColors()
    { 
        if(!_sbActive){govdeRenk.SetActive(true); _sbActive = true;}
        else{govdeRenk.SetActive(false); _sbActive = false;}
    
    }

    private bool _sbActiveHB = false;
   public GameObject govdeRenk_HB;
   public void HBShowBodyColors()
    { 
        if(!_sbActiveHB){govdeRenk_HB.SetActive(true); _sbActiveHB = true;}
        else{govdeRenk_HB.SetActive(false); _sbActiveHB = false;}
    
    
    
    }

    private bool _sbActiveSC = false;
   public GameObject govdeRenk_SC;
   public void SCShowBodyColors()
    { 
        if(!_sbActiveSC){govdeRenk_SC.SetActive(true); _sbActiveSC = true;}
        else{govdeRenk_SC.SetActive(false); _sbActiveSC = false;}
    
    
    
    }
/////////////////////////////////////////////////////////


//TEKERLEK RENKLERİ
   private bool _swActive = false;
   public GameObject tekerlekRenk;
   public void ShowWheelColors()
    { 
        if(!_swActive){tekerlekRenk.SetActive(true); _swActive = true;}
        else{tekerlekRenk.SetActive(false); _swActive = false;}
    
    }
    private bool _swActiveHB = false;
   public GameObject tekerlekRenk_HB;
   public void HBShowWheelColors()
    { 
        if(!_swActiveHB){tekerlekRenk_HB.SetActive(true); _swActiveHB = true;}
        else{tekerlekRenk_HB.SetActive(false); _swActiveHB = false;}
    
    }

     private bool _swActiveSC = false;
   public GameObject tekerlekRenk_SC;
   public void SCShowWheelColors()
    { 
        if(!_swActiveSC){tekerlekRenk_SC.SetActive(true); _swActiveSC = true;}
        else{tekerlekRenk_SC.SetActive(false); _swActiveSC = false;}
    
    }
/////////////////////////////////////////////////////////

//CAM RENKLERİ
   private bool _wActive = false;
   public GameObject camRenk;
   public void ShowWindowColors()
    { 
        if(!_wActive){camRenk.SetActive(true); _wActive = true;}
        else{camRenk.SetActive(false); _wActive = false;}
    
    }
    private bool _wActiveHB = false;
    public GameObject camRenk_HB;
    public void HBShowWindowColors()
    { 
        if(!_wActiveHB){camRenk_HB.SetActive(true); _wActiveHB = true;}
        else{camRenk_HB.SetActive(false); _wActiveHB = false;}
    
    }

     private bool _wActiveSC = false;
    public GameObject camRenk_SC;
    public void SCShowWindowColors()
    { 
        if(!_wActiveSC){camRenk_SC.SetActive(true); _wActiveSC = true;}
        else{camRenk_SC.SetActive(false); _wActiveSC = false;}
    
    }

   
   public GameObject[] hatchback_butonlar;
   public GameObject[] sedan_butonlar;
   public GameObject[] sportscar_butonlar;

   public GameObject[] colorPickers;
   public int carIndex = 0;

public void ArabaDegis()
{
    // Renk butonlarını gizle
    foreach (GameObject renkButonlar in colorPickers)
    {
        renkButonlar.SetActive(false);
    }

    // Araba değişikliği yap
    arabalar[carIndex].SetActive(false);

    // Araba indeksini artır
    carIndex = (carIndex + 1) % arabalar.Length;

    // Yeni aracı aktif hale getir
    arabalar[carIndex].SetActive(true);

    // Araba türüne göre butonları ayarla
    AyarlaButonlar();

}

private void AyarlaButonlar()
{
    foreach (GameObject buton in hatchback_butonlar)
    {
        buton.SetActive(false);
    }
    foreach (GameObject buton2 in sedan_butonlar)
    {
        buton2.SetActive(false);
    }
    foreach (GameObject buton3 in sportscar_butonlar)
    {
        buton3.SetActive(false);
    }

    if (carIndex == 0)
    {
        foreach (GameObject buton in sedan_butonlar)
        {
            buton.SetActive(true);
        }
    }
    else if (carIndex == 1)
    {
        foreach (GameObject buton2 in hatchback_butonlar)
        {
            buton2.SetActive(true);
        }
    }
    else if (carIndex == 2)
    {
        foreach (GameObject buton3 in sportscar_butonlar)
        {
            buton3.SetActive(true);
        }
    }
}


//BİLGİ BUTONLARI
public GameObject[] bilgiButonlar;
private bool _sedanbilgiActive = false;
public void SedanBilgi(){
     if(!_sedanbilgiActive){
        bilgiButonlar[0].SetActive(true); _sedanbilgiActive = true;
        }else
        {
            bilgiButonlar[0].SetActive(false);
            _sedanbilgiActive = false;
            }
    }



private bool _hbbilgiActive = false;
public void HBBilgi(){
    
     if(!_hbbilgiActive){
        bilgiButonlar[1].SetActive(true); _hbbilgiActive = true;
        }else
        {
            bilgiButonlar[1].SetActive(false);
            _hbbilgiActive = false;
            }
    }
private bool _scbilgiActive = false;
    public void SCBilgi(){
     if(!_scbilgiActive){
        bilgiButonlar[2].SetActive(true); _scbilgiActive = true;
        }else
        {
            bilgiButonlar[2].SetActive(false);
            _scbilgiActive = false;
            }
    }

private bool rotateCar = false;
    public void RotateCar(){
        if(!rotateCar){rotateCar = true;}
        else{rotateCar = false;}
      
    }

    void Update(){
        float rotationSpeed = 20f;
        if(rotateCar){
            if(carIndex == 0){arabalar[0].transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);}
            else if(carIndex == 1){arabalar[1].transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);}
            else if(carIndex == 2){arabalar[2].transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);}
        }
    }
}
