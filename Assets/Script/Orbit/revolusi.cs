using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class revolusi : MonoBehaviour {
private float period=1;
private float nilaiAwal;
private float nilaiRevolusi;
	void Start () {

		Double tanggal,bulan,tahun,jam,menit,detik;
           //jam=DateTime.Now.ToString("HH:mm:ss tt");

            tanggal=Convert.ToDouble(DateTime.Now.ToString("dd"));
            bulan=Convert.ToDouble(DateTime.Now.ToString("MM"));
            tahun=Convert.ToDouble(DateTime.Now.ToString("yyyy"));

            jam=Convert.ToDouble(DateTime.Now.ToString("HH"));
            menit=Convert.ToDouble(DateTime.Now.ToString("mm"));
            detik=Convert.ToDouble(DateTime.Now.ToString("ss"));
            
            double jd=Konversi.TanggalKeJulianDay(tahun,bulan,tanggal,jam,menit,detik);
            double bujur_m,lintang_m,jarakBm_M;

            bujur_m=hisabEp.Meeus(jd)[1];
			lintang_m=hisabEp.Meeus(jd)[2];
			jarakBm_M=hisabEp.Meeus(jd)[8];
			nilaiAwal=(float)bujur_m;


//  Console.WriteLine();
//   Console.WriteLine(jarakBB/1000000);
	transform.Rotate(0, (float)bujur_m, 0);
	

		

		
	}
	
	// Update is called once per frame
	void Update () {
	

		if (period > 1)
     {
        hisab();
         period = 0;
     }
     period += UnityEngine.Time.deltaTime;
	
transform.Rotate(0, nilaiRevolusi, 0);
	



		
		
	}

	void hisab(){
		 
			 Double tanggal,bulan,tahun,jam,menit,detik;
           //jam=DateTime.Now.ToString("HH:mm:ss tt");

            tanggal=Convert.ToDouble(DateTime.Now.ToString("dd"));
            bulan=Convert.ToDouble(DateTime.Now.ToString("MM"));
            tahun=Convert.ToDouble(DateTime.Now.ToString("yyyy"));

            jam=Convert.ToDouble(DateTime.Now.ToString("HH"));
            menit=Convert.ToDouble(DateTime.Now.ToString("mm"));
            detik=Convert.ToDouble(DateTime.Now.ToString("ss"));
            
            double jd=Konversi.TanggalKeJulianDay(tahun,bulan,tanggal,jam,menit,detik);
            
            // Console.WriteLine(tanggal+" - "+ bulan+" - "+ tahun+", "+ jam+ " : "+menit +" : "+ detik);
              double bujur_m,lintang_m,epsilon,jarakBm_M;

            bujur_m=hisabEp.Meeus(jd)[1];
			lintang_m=hisabEp.Meeus(jd)[2];

			epsilon=hisabEp.Meeus(jd)[6];
			jarakBm_M=hisabEp.Meeus(jd)[8];
			nilaiRevolusi=((float)bujur_m-nilaiAwal);
 //	Debug.Log((float)nilaiRevolusi);
	
//  Console.WriteLine();
//   Console.WriteLine(jarakBB/1000000);


  



	}
}
