
//int razmer=69; //для компа
int razmer=15+4+4; //для панели
//int razmer=41+4+5; //для панели
path="\\ResidentFlash\\";
path_usb="\\Hard Disk\\";
//path="D:\\torrent\\BC_update\\Demo Project\\Vibrosi\\PCData\\ResidentFlash\\";
//path_usb="D:\\torrent\\BC_update\\Demo Project\\Vibrosi\\PCData\\Hard Disk\\";
//path="D:\\Projects\\Vibrosi\\PCData\\ResidentFlash\\";
//path_usb="D:\\Projects\\Vibrosi\\PCData\\Hard Disk\\";



///////if (IO_DI16_1_ch_06_neisp_rashod_a==0){R_A=0;}else{G_A=1;}
///////if (IO_DI16_1_ch_02_gazanal_b==0){G_B=1;}else{G_B=0;}


//STOP=IO_DI16_1_ch_03_ostanov_kotla;
//R_A=IO_DI16_1_ch_06_neisp_rashod_a; 

//////P_g=IO_AI6_2_ch_3;



if (poverka==1) {

G_A=0; // в режим поверки нет бита аварии газаанализатора

//0-2000
if ((poverka_AI6_1_ch_2<3500)||(poverka_AI6_1_ch_2>30000)){znach_1=0; G_A=1; Gl_Scr_2.DigitalBox60.ForeColor=System.Drawing.Color.Red;} else {znach_1=(((poverka_AI6_1_ch_2-4000.0)/(16000.0))*(ch02_Hi-ch02_Lo)+ch02_Lo);Gl_Scr_2.DigitalBox60.ForeColor=System.Drawing.Color.Black;}
//0-500
if ((poverka_AI6_1_ch_4<3500)||(poverka_AI6_1_ch_4>30000)){znach_2=0; G_A=1; Gl_Scr_2.DigitalBox59.ForeColor=System.Drawing.Color.Red;} else {znach_2=(((poverka_AI6_1_ch_4-4000.0)/(16000.0))*(ch04_Hi-ch04_Lo)+ch04_Lo);Gl_Scr_2.DigitalBox59.ForeColor=System.Drawing.Color.Black;}
//0-21
if ((poverka_AI6_1_ch_1<3500)||(poverka_AI6_1_ch_1>30000)){znach_4=0; G_A=1; Gl_Scr_2.DigitalBox577.ForeColor=System.Drawing.Color.Red;} else {znach_4=(((poverka_AI6_1_ch_1-4000.0)/(16000.0))*(ch01_Hi-ch01_Lo)+ch01_Lo);Gl_Scr_2.DigitalBox577.ForeColor=System.Drawing.Color.Black;}
//0-500
if ((poverka_AI6_1_ch_5<3500)||(poverka_AI6_1_ch_5>30000)){znach_7=0; G_A=1; Gl_Scr_2.DigitalBox580.ForeColor=System.Drawing.Color.Red;} else {znach_7=(((poverka_AI6_1_ch_5-4000.0)/(16000.0))*(ch05_Hi-ch05_Lo)+ch05_Lo);Gl_Scr_2.DigitalBox580.ForeColor=System.Drawing.Color.Black;}
//0-15
if ((poverka_AI6_1_ch_3<3500)||(poverka_AI6_1_ch_3>30000)){znach_6=0; G_A=1; Gl_Scr_2.DigitalBox1.ForeColor=System.Drawing.Color.Red;} else {znach_6=(((poverka_AI6_1_ch_3-4000.0)/(16000.0))*(ch03_Hi-ch03_Lo)+ch03_Lo);Gl_Scr_2.DigitalBox1.ForeColor=System.Drawing.Color.Black;}
//0-15000
if ((poverka_AI6_1_ch_6<3500)||(poverka_AI6_1_ch_6>30000)){znach_8=0; R_A=1; Gl_Scr_2.DigitalBox578.ForeColor=System.Drawing.Color.Red;} else {znach_8=(((poverka_AI6_1_ch_6-4000.0)/(16000.0))*(ch06_Hi-ch06_Lo)+ch06_Lo)/Ro_g; R_A=0; Gl_Scr_2.DigitalBox578.ForeColor=System.Drawing.Color.Blue;}
//0-21(second channel Oxigen)
if ((poverka_AI6_2_ch_6<3500)||(poverka_AI6_2_ch_6>30000)){znach_44=0;} else {znach_44=(((poverka_AI6_2_ch_6-4000.0)/(16000.0))*(Ai2ch06_Hi-Ai2ch06_Lo)+Ai2ch06_Lo);}



if (sim==0) {ras_const=1;}//расчет по константам;
          
Screen9.NumericUpDown25.Visible = true;
Screen9.NumericUpDown26.Visible = true;
Screen9.NumericUpDown27.Visible = true;
Screen9.NumericUpDown28.Visible = true;
Screen9.NumericUpDown29.Visible = true;
Screen9.NumericUpDown30.Visible = true;
Screen9.NumericUpDown31.Visible = true;  //O2second 
         }         
else     {

//инверсия аварий газанализатора
if (IO_DI16_1_ch_01_gazanal_a==0){G_A=1;}else{G_A=0;}


//0-2000
if ((IO_AI6_1_ch_2<3500)||(IO_AI6_1_ch_2>30000)){znach_1=0; G_A=1; Gl_Scr_2.DigitalBox60.ForeColor=System.Drawing.Color.Red;} else {znach_1=(((IO_AI6_1_ch_2-4000.0)/(16000.0))*(ch02_Hi-ch02_Lo)+ch02_Lo);Gl_Scr_2.DigitalBox60.ForeColor=System.Drawing.Color.Black;}
//0-500
if ((IO_AI6_1_ch_4<3500)||(IO_AI6_1_ch_4>30000)){znach_2=0; G_A=1; Gl_Scr_2.DigitalBox59.ForeColor=System.Drawing.Color.Red;} else {znach_2=(((IO_AI6_1_ch_4-4000.0)/(16000.0))*(ch04_Hi-ch04_Lo)+ch04_Lo);Gl_Scr_2.DigitalBox59.ForeColor=System.Drawing.Color.Black;}
//0-21
if ((IO_AI6_1_ch_1<3500)||(IO_AI6_1_ch_1>30000)){znach_4=0; G_A=1; Gl_Scr_2.DigitalBox577.ForeColor=System.Drawing.Color.Red;} else {znach_4=(((IO_AI6_1_ch_1-4000.0)/(16000.0))*(ch01_Hi-ch01_Lo)+ch01_Lo);Gl_Scr_2.DigitalBox577.ForeColor=System.Drawing.Color.Black;}
//0-500
if ((IO_AI6_1_ch_5<3500)||(IO_AI6_1_ch_5>30000)){znach_7=0; G_A=1; Gl_Scr_2.DigitalBox580.ForeColor=System.Drawing.Color.Red;} else {znach_7=(((IO_AI6_1_ch_5-4000.0)/(16000.0))*(ch05_Hi-ch05_Lo)+ch05_Lo);Gl_Scr_2.DigitalBox580.ForeColor=System.Drawing.Color.Black;}
//0-15
if ((IO_AI6_1_ch_3<3500)||(IO_AI6_1_ch_3>30000)){znach_6=0; G_A=1; Gl_Scr_2.DigitalBox1.ForeColor=System.Drawing.Color.Red;} else {znach_6=(((IO_AI6_1_ch_3-4000.0)/(16000.0))*(ch03_Hi-ch03_Lo)+ch03_Lo);Gl_Scr_2.DigitalBox1.ForeColor=System.Drawing.Color.Black;}
//0-15000
if ((IO_AI6_1_ch_6<3500)||(IO_AI6_1_ch_6>30000)){znach_8=0; R_A=1; Gl_Scr_2.DigitalBox578.ForeColor=System.Drawing.Color.Red;} else {znach_8=(((IO_AI6_1_ch_6-4000.0)/(16000.0))*(ch06_Hi-ch06_Lo)+ch06_Lo)/Ro_g; R_A=0; Gl_Scr_2.DigitalBox578.ForeColor=System.Drawing.Color.Blue;}

//0-21(second channel Oxigen)
if ((IO_AI6_2_ch_1<3500)||(IO_AI6_2_ch_1>30000)){znach_44=0;} else {znach_44=(((IO_AI6_2_ch_1-4000.0)/(16000.0))*(Ai2ch01_Hi-Ai2ch01_Lo)+Ai2ch01_Lo);}

          Screen9.NumericUpDown25.Visible = false;
          Screen9.NumericUpDown26.Visible = false;
          Screen9.NumericUpDown27.Visible = false;
          Screen9.NumericUpDown28.Visible = false;
          Screen9.NumericUpDown29.Visible = false;
          Screen9.NumericUpDown30.Visible = false;  
          Screen9.NumericUpDown31.Visible = false;  //O2second            
         }          
//registr = (IO_DI16_1_ch_03_ostanov_kotla + gaz_maz<<1 + IO_DI16_1_ch_01_gazanal_a<<8 + IO_DI16_1_ch_02_gazanal_b<<9 + IO_DI16_1_ch_06_neisp_rashod_a<<10 + IO_DI16_1_ch_07_neisp_rashod_b<<11 + ras_const<<15);


//0-160
if ((IO_AI6_2_ch_4<3500)||(IO_AI6_2_ch_4>30000)){ModbusSlaveTCP_HMI_CurDate_9=0;Gl_Scr_2.DigitalBox581.ForeColor=System.Drawing.Color.Red;} else {ModbusSlaveTCP_HMI_CurDate_9=(((IO_AI6_2_ch_4-4000.0)/(16000.0))*(Ai2ch04_Hi-Ai2ch04_Lo)+Ai2ch04_Lo);Gl_Scr_2.DigitalBox581.ForeColor=System.Drawing.Color.Black;} //P
//0-500
if ((IO_AI6_2_ch_5<3500)||(IO_AI6_2_ch_5>30000)){ModbusSlaveTCP_HMI_CurDate_10=0;Gl_Scr_2.DigitalBox582.ForeColor=System.Drawing.Color.Red;} else {ModbusSlaveTCP_HMI_CurDate_10=(((IO_AI6_2_ch_5-4000.0)/(16000.0))*(Ai2ch05_Hi-Ai2ch05_Lo)+Ai2ch05_Lo);Gl_Scr_2.DigitalBox582.ForeColor=System.Drawing.Color.Black;} //T


//blocked negotive data
if (ModbusSlaveTCP_HMI_CurDate_9<0) ModbusSlaveTCP_HMI_CurDate_9=0;  //P
if (ModbusSlaveTCP_HMI_CurDate_10<0) ModbusSlaveTCP_HMI_CurDate_10=0; //T

if (znach_1<0) {znach_1=0;} //CO
if (znach_2<0) znach_2=0; //NO
if (znach_4<0) {znach_4=0;} if (znach_4>21) {znach_4=21;} //O2
if (znach_7<0) znach_7=0; //CH4
if (znach_6<0) znach_6=0; //CO2
if (znach_8<0) znach_8=0; //Bg

//оборудование в работе!!!
STOP=1;                     //Real_time-->registr-->ModbusSlaveTCP_HMI_Alarm_0
//TurnBitOn(reg_alarm_20,0);  //reg_alarm_20-------------->ModbusSlaveTCP_Rezerv2_0  

//оборудование остановлено!!!
// Bmin || O2max
if ((znach_8<ModbusSlaveTCP_PC_MCD_9)||(znach_4>ModbusSlaveTCP_PC_MCD_10))//выполнится если одно из условий
{
STOP=0;                      //Real_time
STOP_hist=0;
TurnBitOff(reg_alarm_20,0);  //Hist_20 
}



if ((K_rasch!=0)&&(znach_44==0)) {G_A=1;K_rasch=0;}

Pref.Rect1.Visible = false;
Pref.Rect2.Visible = false;
//К=(О2с/О2в)+0,008
if (K_rasch==0){znach_K=ModbusSlaveTCP_PC_MCD_8; Pref.Rect1.Visible = true;} //К конст
else {znach_K=(znach_4/znach_44)+0.008; Pref.Rect2.Visible = true;Kizm=znach_K;} //К изм


//znach_1=IO_AI6_1_ch_2; //CO+
//znach_2=IO_AI6_1_ch_4; //NO+
//znach_4=IO_AI6_1_ch_1; //O2+
//znach_7=IO_AI6_1_ch_5; //CH4 +
///////znach_3; //SO2 -
//znach_6=IO_AI6_1_ch_3; //CO2 +
//znach_8=IO_AI6_1_ch_6/Ro_g; //Bg 7+ м3/ч
//znach_6=0.0395;
///////NOx тек нету



if ((G_A==0) && (R_A==0))//Если нет аварии газонализатора  нет аварии расходомера
{
//////////////////////////Забрал с IO 
///////////////////////////////////////////////////////////////////////////////////////////////////Топка А
}
else 
{
     ras_const=1;//расчет по константам
     
     if (gaz_maz==0) //Если топливо - газ
     {
    // znach_1=0; //CO_const_gaz_A
    // znach_2=0; //NO_const_gaz_A
    //znach_4=0; //O2_const_gaz_A
    // znach_7=0; //CH4_const_gaz_A 
     ////znach_3=ModbusSlaveTCP_PC_MCD_4; SO2_const_gaz_A -
    // znach_6=0; //CO2_const_gaz_A
     ////ModbusSlaveTCP_PC_MCD_6;NOx тек нету -

     //znach_8=0; //Bg 7+ м3/ч

     //T_g=ModbusSlaveTCP_PC_MCD_7; //Tg_const_gaz_A
     //P_g=ModbusSlaveTCP_PC_MCD_8; //Pg_const_gaz_A     
     }
     else           //Если топливо - мазут
     {
     znach_1=ModbusSlaveTCP_PC_MCD_21; //CO_const_maz_A
     znach_2=ModbusSlaveTCP_PC_MCD_22; //NO_const_maz_A
     znach_4=ModbusSlaveTCP_PC_MCD_23; //O2_const_maz_A
     znach_7=ModbusSlaveTCP_PC_MCD_24; //CH4_const_maz_A +
     //znach_3=ModbusSlaveTCP_PC_MCD_25; SO2_const_maz_A -
     znach_6=ModbusSlaveTCP_PC_MCD_26; //CO2_const_maz_A +
     //ModbusSlaveTCP_PC_MCD_27;NOx тек нету

     }
}

//////неиспр расходомера

gaz_maz=0;//газ всегда, мазута тут нет
//if (gaz_maz==0)//газ
//{
     //Если нет аварии разходомера газа
 //    if (R_A==0){znach_8=IO_AI6_1_ch_6*3600/Ro_g;}  //Bg 7+ м3/ч
//    else {znach_8=ModbusSlaveTCP_PC_MCD_7;} //Bg_const_A          
//}
    
registr= (STOP + G_A*256 + R_A*1024 + ras_const*32768);

if (G_A==1){TurnBitOn(reg_alarm_20,8);}//GA
if (R_A==1){TurnBitOn(reg_alarm_20,10);}//RA
if (ras_const==1){TurnBitOn(reg_alarm_20,15);}//Rasch_Const

ModbusSlaveTCP_HMI_Alarm_0 = registr;
ModbusSlaveTCP_Rezerv2_0=reg_alarm_20;

////////////////////////////////////////////////////////////////////////////////////////////////////////////////


///////////////после первого измерения 00:20:00 нулим сумму выбросов
if (conter_izm==1)
{
Gl_Scr_2.DigitalBox23.Value = 0.0;
Gl_Scr_2.DigitalBox24.Value = 0.0;
Gl_Scr_2.DigitalBox25.Value = 0.0;
Gl_Scr_2.DigitalBox26.Value = 0.0;
Gl_Scr_2.DigitalBox27.Value = 0.0;
Gl_Scr_2.DigitalBox28.Value =0.0;
Gl_Scr_2.Label2_22.Text= "";
}
/////////////////

/////////////Создание списка *.csv файлов
int N=0;
string[] csvList = System.IO.Directory.GetFiles(path+"Day\\","*.csv");  
//string[] csvList = System.IO.Directory.GetFiles(path,"*.csv");     //массив файликов
N=csvList.Length;
N_1=N;
int f=0;

//Gl_Scr_4.ComboBox1.Items.Clear();//нулим ComboBox
Gl_Scr_4.ComboBox2.Items.Clear();//нулим ComboBox
while (f<N) {
//Gl_Scr_4.ComboBox1.Items.Add("");
Gl_Scr_4.ComboBox2.Items.Add("");
string bred=csvList[(N-1)-f].Substring(0,csvList[(N-1)-f].Length - 0); 
//Gl_Scr_4.ComboBox1.Items[f]=bred;
Gl_Scr_4.ComboBox2.Items[f]=bred.Substring(razmer).Replace('_','_');
f++;
}
//добавляем полей сколько файлов нашли и заполняем в обратной последовательности




if (test){
///////Чтение и заполнение таблицы за сутки пздц...///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//System.IO.StreamReader fileDayArhiv = new System.IO.StreamReader(path+ @"Day\Day_"+DateTime.Now.ToString("dd.MM.yyyy").Replace('.','_')+".csv");
System.IO.StreamReader fileDayArhiv = new System.IO.StreamReader(path+ @"Day\Day_"+nameD+".csv");

string strokaArhiv = fileDayArhiv .ReadLine();int stArhiv=0;
    while ((strokaArhiv !=null) & (strokaArhiv !="null"))
    {
    string[] parts3 = strokaArhiv .Split(';');

    //Групповая обработка
    int b=0;
       while (b<=7)
       {
 //      ControlsLib.DigitalBox  D;           
          switch (b+stArhiv*8)
          {
          case 0:  Gl_Scr_3.Label22_1.Text=parts3[b];break;
          case 1:  Gl_Scr_3.DigitalBox2.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 2:  Gl_Scr_3.DigitalBox3.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 3:  Gl_Scr_3.DigitalBox4.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 4:  Gl_Scr_3.DigitalBox5.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 5:  Gl_Scr_3.DigitalBox6.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 6:  Gl_Scr_3.DigitalBox7.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 7:  Gl_Scr_3.DigitalBox8.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 8:  Gl_Scr_3.Label22_8.Text=parts3[b];break;
          case 9:  Gl_Scr_3.DigitalBox9.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 10: Gl_Scr_3.DigitalBox10.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 11: Gl_Scr_3.DigitalBox11.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 12: Gl_Scr_3.DigitalBox12.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 13: Gl_Scr_3.DigitalBox13.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 14: Gl_Scr_3.DigitalBox14.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 15: Gl_Scr_3.DigitalBox15.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 16: Gl_Scr_3.Label22_15.Text=parts3[b];break;
          case 17: Gl_Scr_3.DigitalBox16.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 18: Gl_Scr_3.DigitalBox17.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 19: Gl_Scr_3.DigitalBox18.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 20: Gl_Scr_3.DigitalBox19.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 21: Gl_Scr_3.DigitalBox20.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 22: Gl_Scr_3.DigitalBox21.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 23: Gl_Scr_3.DigitalBox22.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 24:  Gl_Scr_3.Label22_22.Text=parts3[b];break;
          case 25:  Gl_Scr_3.DigitalBox23.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 26:  Gl_Scr_3.DigitalBox24.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 27:  Gl_Scr_3.DigitalBox25.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 28:  Gl_Scr_3.DigitalBox26.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 29:  Gl_Scr_3.DigitalBox27.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 30:  Gl_Scr_3.DigitalBox28.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 31:  Gl_Scr_3.DigitalBox29.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 32:  Gl_Scr_3.Label22_29.Text=parts3[b];break;
          case 33:  Gl_Scr_3.DigitalBox30.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 34: Gl_Scr_3.DigitalBox31.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 35: Gl_Scr_3.DigitalBox32.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 36: Gl_Scr_3.DigitalBox33.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 37: Gl_Scr_3.DigitalBox34.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 38: Gl_Scr_3.DigitalBox35.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 39: Gl_Scr_3.DigitalBox36.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 40: Gl_Scr_3.Label22_36.Text=parts3[b];break;
          case 41: Gl_Scr_3.DigitalBox37.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 42: Gl_Scr_3.DigitalBox38.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 43: Gl_Scr_3.DigitalBox39.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 44: Gl_Scr_3.DigitalBox40.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 45: Gl_Scr_3.DigitalBox41.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 46: Gl_Scr_3.DigitalBox42.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 47: Gl_Scr_3.DigitalBox43.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break; 


          case 48:  Gl_Scr_3.Label22_43.Text=parts3[b];break;
          case 49:  Gl_Scr_3.DigitalBox44.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 50:  Gl_Scr_3.DigitalBox45.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 51:  Gl_Scr_3.DigitalBox46.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 52:  Gl_Scr_3.DigitalBox47.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 53:  Gl_Scr_3.DigitalBox48.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 54:  Gl_Scr_3.DigitalBox49.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 55:  Gl_Scr_3.DigitalBox50.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 56:  Gl_Scr_3.Label22_50.Text=parts3[b];break;
          case 57:  Gl_Scr_3.DigitalBox51.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 58: Gl_Scr_3.DigitalBox52.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 59: Gl_Scr_3.DigitalBox53.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 60: Gl_Scr_3.DigitalBox54.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 61: Gl_Scr_3.DigitalBox55.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 62: Gl_Scr_3.DigitalBox56.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 63: Gl_Scr_3.DigitalBox57.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 64: Gl_Scr_3.Label22_57.Text=parts3[b];break;
          case 65: Gl_Scr_3.DigitalBox58.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 66: Gl_Scr_3.DigitalBox59.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 67: Gl_Scr_3.DigitalBox60.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 68: Gl_Scr_3.DigitalBox61.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 69: Gl_Scr_3.DigitalBox62.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 70: Gl_Scr_3.DigitalBox63.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 71: Gl_Scr_3.DigitalBox64.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 72:  Gl_Scr_3.Label22_64.Text=parts3[b];break;
          case 73:  Gl_Scr_3.DigitalBox65.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 74:  Gl_Scr_3.DigitalBox66.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 75:  Gl_Scr_3.DigitalBox67.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 76:  Gl_Scr_3.DigitalBox68.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 77:  Gl_Scr_3.DigitalBox69.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 78:  Gl_Scr_3.DigitalBox70.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 79:  Gl_Scr_3.DigitalBox71.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 80:  Gl_Scr_3.Label22_71.Text=parts3[b];break;
          case 81:  Gl_Scr_3.DigitalBox72.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 82: Gl_Scr_3.DigitalBox73.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 83: Gl_Scr_3.DigitalBox74.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 84: Gl_Scr_3.DigitalBox75.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 85: Gl_Scr_3.DigitalBox76.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 86: Gl_Scr_3.DigitalBox77.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 87: Gl_Scr_3.DigitalBox78.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 88: Gl_Scr_3.Label22_78.Text=parts3[b];break;
          case 89: Gl_Scr_3.DigitalBox79.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 90: Gl_Scr_3.DigitalBox80.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 91: Gl_Scr_3.DigitalBox81.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 92: Gl_Scr_3.DigitalBox82.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 93: Gl_Scr_3.DigitalBox83.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 94: Gl_Scr_3.DigitalBox84.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 95: Gl_Scr_3.DigitalBox85.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;    




          case 96:  Gl_Scr_3.Label22_85.Text=parts3[b];break;
          case 97:  Gl_Scr_3.DigitalBox86.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 98:  Gl_Scr_3.DigitalBox87.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 99:  Gl_Scr_3.DigitalBox88.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 100:  Gl_Scr_3.DigitalBox89.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 101:  Gl_Scr_3.DigitalBox90.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 102:  Gl_Scr_3.DigitalBox91.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 103:  Gl_Scr_3.DigitalBox92.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 104:  Gl_Scr_3.Label22_92.Text=parts3[b];break;
          case 105:  Gl_Scr_3.DigitalBox93.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 106: Gl_Scr_3.DigitalBox94.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 107: Gl_Scr_3.DigitalBox95.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 108: Gl_Scr_3.DigitalBox96.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 109: Gl_Scr_3.DigitalBox97.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 110: Gl_Scr_3.DigitalBox98.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 111: Gl_Scr_3.DigitalBox99.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 112: Gl_Scr_3.Label22_99.Text=parts3[b];break;
          case 113: Gl_Scr_3.DigitalBox100.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 114: Gl_Scr_3.DigitalBox101.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 115: Gl_Scr_3.DigitalBox102.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 116: Gl_Scr_3.DigitalBox103.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 117: Gl_Scr_3.DigitalBox104.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 118: Gl_Scr_3.DigitalBox105.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 119: Gl_Scr_3.DigitalBox106.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 120:  Gl_Scr_3.Label22_106.Text=parts3[b];break;
          case 121:  Gl_Scr_3.DigitalBox107.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 122:  Gl_Scr_3.DigitalBox108.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 123:  Gl_Scr_3.DigitalBox109.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 124:  Gl_Scr_3.DigitalBox110.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 125:  Gl_Scr_3.DigitalBox111.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 126:  Gl_Scr_3.DigitalBox112.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 127:  Gl_Scr_3.DigitalBox113.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 128:  Gl_Scr_3.Label22_113.Text=parts3[b];break;
          case 129:  Gl_Scr_3.DigitalBox114.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 130: Gl_Scr_3.DigitalBox115.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 131: Gl_Scr_3.DigitalBox116.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 132: Gl_Scr_3.DigitalBox117.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 133: Gl_Scr_3.DigitalBox118.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 134: Gl_Scr_3.DigitalBox119.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 135: Gl_Scr_3.DigitalBox120.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 136: Gl_Scr_3.Label22_120.Text=parts3[b];break;
          case 137: Gl_Scr_3.DigitalBox121.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 138: Gl_Scr_3.DigitalBox122.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 139: Gl_Scr_3.DigitalBox123.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 140: Gl_Scr_3.DigitalBox124.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 141: Gl_Scr_3.DigitalBox125.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 142: Gl_Scr_3.DigitalBox126.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 143: Gl_Scr_3.DigitalBox127.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break; 


          case 144:  Gl_Scr_3.Label22_127.Text=parts3[b];break;
          case 145:  Gl_Scr_3.DigitalBox128.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 146:  Gl_Scr_3.DigitalBox129.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 147:  Gl_Scr_3.DigitalBox130.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 148:  Gl_Scr_3.DigitalBox131.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 149:  Gl_Scr_3.DigitalBox132.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 150:  Gl_Scr_3.DigitalBox133.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 151:  Gl_Scr_3.DigitalBox134.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 152:  Gl_Scr_3.Label22_134.Text=parts3[b];break;
          case 153:  Gl_Scr_3.DigitalBox135.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 154: Gl_Scr_3.DigitalBox136.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 155: Gl_Scr_3.DigitalBox137.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 156: Gl_Scr_3.DigitalBox138.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 157: Gl_Scr_3.DigitalBox139.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 158: Gl_Scr_3.DigitalBox140.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 159: Gl_Scr_3.DigitalBox141.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 160: Gl_Scr_3.Label22_141.Text=parts3[b];break;
          case 161: Gl_Scr_3.DigitalBox142.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 162: Gl_Scr_3.DigitalBox143.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 163: Gl_Scr_3.DigitalBox144.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 164: Gl_Scr_3.DigitalBox145.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 165: Gl_Scr_3.DigitalBox146.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 166: Gl_Scr_3.DigitalBox147.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 167: Gl_Scr_3.DigitalBox148.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 168:  Gl_Scr_3.Label22_148.Text=parts3[b];break;
          case 169:  Gl_Scr_3.DigitalBox149.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 170:  Gl_Scr_3.DigitalBox150.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 171:  Gl_Scr_3.DigitalBox151.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 172:  Gl_Scr_3.DigitalBox152.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 173:  Gl_Scr_3.DigitalBox153.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 174:  Gl_Scr_3.DigitalBox154.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 175:  Gl_Scr_3.DigitalBox155.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 176:  Gl_Scr_3.Label22_155.Text=parts3[b];break;
          case 177:  Gl_Scr_3.DigitalBox156.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 178: Gl_Scr_3.DigitalBox157.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 179: Gl_Scr_3.DigitalBox158.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 180: Gl_Scr_3.DigitalBox159.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 181: Gl_Scr_3.DigitalBox160.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 182: Gl_Scr_3.DigitalBox161.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 183: Gl_Scr_3.DigitalBox162.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 184: Gl_Scr_3.Label22_162.Text=parts3[b];break;
          case 185: Gl_Scr_3.DigitalBox163.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 186: Gl_Scr_3.DigitalBox164.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 187: Gl_Scr_3.DigitalBox165.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 188: Gl_Scr_3.DigitalBox166.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 189: Gl_Scr_3.DigitalBox167.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 190: Gl_Scr_3.DigitalBox168.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 191: Gl_Scr_3.DigitalBox169.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;  

          case 192: Gl_Scr_3.Label22_169.Text=parts3[b];break;
          case 193: Gl_Scr_3.DigitalBox170.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 194: Gl_Scr_3.DigitalBox171.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 195: Gl_Scr_3.DigitalBox172.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 196: Gl_Scr_3.DigitalBox173.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 197: Gl_Scr_3.DigitalBox174.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 198: Gl_Scr_3.DigitalBox175.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 199: Gl_Scr_3.DigitalBox176.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;           

          
          default: Gl_Scr_3.DigitalBox2.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          }
       b++;
       }
    strokaArhiv = fileDayArhiv .ReadLine();
    stArhiv++;
    }
fileDayArhiv .Close();
test=0;
}



if (luper){
///////Чтение и заполнение таблицы за сутки пздц...(Архив)////////////////////////////////////////////////////////////////////////////////////////////////////
System.IO.StreamReader fileDayArhiv = new System.IO.StreamReader(path+ @"Day\Day_"+Gl_Scr_4.ComboBox2.Items[Tag1].Replace('.','.'));

string strokaArhiv = fileDayArhiv .ReadLine();int stArhiv=0;
    while ((strokaArhiv !=null) & (strokaArhiv !="null"))
    {
    string[] parts3 = strokaArhiv .Split(';');

    //Групповая обработка
    int b=0;
       while (b<=7)
       {
 //      ControlsLib.DigitalBox  D;           
          switch (b+stArhiv*8)
          {
          case 0:  Gl_Scr_4.Label3_1.Text=parts3[b];break;
          case 1:  Gl_Scr_4.DigitalBox2.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 2:  Gl_Scr_4.DigitalBox3.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 3:  Gl_Scr_4.DigitalBox4.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 4:  Gl_Scr_4.DigitalBox5.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 5:  Gl_Scr_4.DigitalBox6.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 6:  Gl_Scr_4.DigitalBox7.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 7:  Gl_Scr_4.DigitalBox8.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 8:  Gl_Scr_4.Label3_8.Text=parts3[b];break;
          case 9:  Gl_Scr_4.DigitalBox9.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 10: Gl_Scr_4.DigitalBox10.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 11: Gl_Scr_4.DigitalBox11.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 12: Gl_Scr_4.DigitalBox12.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 13: Gl_Scr_4.DigitalBox13.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 14: Gl_Scr_4.DigitalBox14.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 15: Gl_Scr_4.DigitalBox15.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 16: Gl_Scr_4.Label3_15.Text=parts3[b];break;
          case 17: Gl_Scr_4.DigitalBox16.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 18: Gl_Scr_4.DigitalBox17.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 19: Gl_Scr_4.DigitalBox18.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 20: Gl_Scr_4.DigitalBox19.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 21: Gl_Scr_4.DigitalBox20.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 22: Gl_Scr_4.DigitalBox21.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 23: Gl_Scr_4.DigitalBox22.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 24:  Gl_Scr_4.Label3_22.Text=parts3[b];break;
          case 25:  Gl_Scr_4.DigitalBox23.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 26:  Gl_Scr_4.DigitalBox24.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 27:  Gl_Scr_4.DigitalBox25.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 28:  Gl_Scr_4.DigitalBox26.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 29:  Gl_Scr_4.DigitalBox27.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 30:  Gl_Scr_4.DigitalBox28.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 31:  Gl_Scr_4.DigitalBox29.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 32:  Gl_Scr_4.Label3_29.Text=parts3[b];break;
          case 33:  Gl_Scr_4.DigitalBox30.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 34: Gl_Scr_4.DigitalBox31.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 35: Gl_Scr_4.DigitalBox32.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 36: Gl_Scr_4.DigitalBox33.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 37: Gl_Scr_4.DigitalBox34.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 38: Gl_Scr_4.DigitalBox35.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 39: Gl_Scr_4.DigitalBox36.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 40: Gl_Scr_4.Label3_36.Text=parts3[b];break;
          case 41: Gl_Scr_4.DigitalBox37.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 42: Gl_Scr_4.DigitalBox38.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 43: Gl_Scr_4.DigitalBox39.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 44: Gl_Scr_4.DigitalBox40.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 45: Gl_Scr_4.DigitalBox41.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 46: Gl_Scr_4.DigitalBox42.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 47: Gl_Scr_4.DigitalBox43.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break; 


          case 48:  Gl_Scr_4.Label3_43.Text=parts3[b];break;
          case 49:  Gl_Scr_4.DigitalBox44.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 50:  Gl_Scr_4.DigitalBox45.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 51:  Gl_Scr_4.DigitalBox46.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 52:  Gl_Scr_4.DigitalBox47.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 53:  Gl_Scr_4.DigitalBox48.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 54:  Gl_Scr_4.DigitalBox49.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 55:  Gl_Scr_4.DigitalBox50.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 56:  Gl_Scr_4.Label3_50.Text=parts3[b];break;
          case 57:  Gl_Scr_4.DigitalBox51.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 58: Gl_Scr_4.DigitalBox52.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 59: Gl_Scr_4.DigitalBox53.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 60: Gl_Scr_4.DigitalBox54.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 61: Gl_Scr_4.DigitalBox55.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 62: Gl_Scr_4.DigitalBox56.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 63: Gl_Scr_4.DigitalBox57.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 64: Gl_Scr_4.Label3_57.Text=parts3[b];break;
          case 65: Gl_Scr_4.DigitalBox58.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 66: Gl_Scr_4.DigitalBox59.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 67: Gl_Scr_4.DigitalBox60.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 68: Gl_Scr_4.DigitalBox61.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 69: Gl_Scr_4.DigitalBox62.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 70: Gl_Scr_4.DigitalBox63.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 71: Gl_Scr_4.DigitalBox64.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 72:  Gl_Scr_4.Label3_64.Text=parts3[b];break;
          case 73:  Gl_Scr_4.DigitalBox65.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 74:  Gl_Scr_4.DigitalBox66.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 75:  Gl_Scr_4.DigitalBox67.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 76:  Gl_Scr_4.DigitalBox68.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 77:  Gl_Scr_4.DigitalBox69.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 78:  Gl_Scr_4.DigitalBox70.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 79:  Gl_Scr_4.DigitalBox71.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 80:  Gl_Scr_4.Label3_71.Text=parts3[b];break;
          case 81:  Gl_Scr_4.DigitalBox72.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 82: Gl_Scr_4.DigitalBox73.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 83: Gl_Scr_4.DigitalBox74.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 84: Gl_Scr_4.DigitalBox75.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 85: Gl_Scr_4.DigitalBox76.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 86: Gl_Scr_4.DigitalBox77.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 87: Gl_Scr_4.DigitalBox78.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 88: Gl_Scr_4.Label3_78.Text=parts3[b];break;
          case 89: Gl_Scr_4.DigitalBox79.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 90: Gl_Scr_4.DigitalBox80.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 91: Gl_Scr_4.DigitalBox81.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 92: Gl_Scr_4.DigitalBox82.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 93: Gl_Scr_4.DigitalBox83.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 94: Gl_Scr_4.DigitalBox84.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 95: Gl_Scr_4.DigitalBox85.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;    




          case 96:  Gl_Scr_4.Label3_85.Text=parts3[b];break;
          case 97:  Gl_Scr_4.DigitalBox86.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 98:  Gl_Scr_4.DigitalBox87.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 99:  Gl_Scr_4.DigitalBox88.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 100:  Gl_Scr_4.DigitalBox89.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 101:  Gl_Scr_4.DigitalBox90.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 102:  Gl_Scr_4.DigitalBox91.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 103:  Gl_Scr_4.DigitalBox92.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 104:  Gl_Scr_4.Label3_92.Text=parts3[b];break;
          case 105:  Gl_Scr_4.DigitalBox93.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 106: Gl_Scr_4.DigitalBox94.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 107: Gl_Scr_4.DigitalBox95.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 108: Gl_Scr_4.DigitalBox96.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 109: Gl_Scr_4.DigitalBox97.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 110: Gl_Scr_4.DigitalBox98.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 111: Gl_Scr_4.DigitalBox99.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 112: Gl_Scr_4.Label3_99.Text=parts3[b];break;
          case 113: Gl_Scr_4.DigitalBox100.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 114: Gl_Scr_4.DigitalBox101.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 115: Gl_Scr_4.DigitalBox102.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 116: Gl_Scr_4.DigitalBox103.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 117: Gl_Scr_4.DigitalBox104.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 118: Gl_Scr_4.DigitalBox105.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 119: Gl_Scr_4.DigitalBox106.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 120:  Gl_Scr_4.Label3_106.Text=parts3[b];break;
          case 121:  Gl_Scr_4.DigitalBox107.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 122:  Gl_Scr_4.DigitalBox108.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 123:  Gl_Scr_4.DigitalBox109.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 124:  Gl_Scr_4.DigitalBox110.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 125:  Gl_Scr_4.DigitalBox111.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 126:  Gl_Scr_4.DigitalBox112.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 127:  Gl_Scr_4.DigitalBox113.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 128:  Gl_Scr_4.Label3_113.Text=parts3[b];break;
          case 129:  Gl_Scr_4.DigitalBox114.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 130: Gl_Scr_4.DigitalBox115.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 131: Gl_Scr_4.DigitalBox116.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 132: Gl_Scr_4.DigitalBox117.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 133: Gl_Scr_4.DigitalBox118.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 134: Gl_Scr_4.DigitalBox119.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 135: Gl_Scr_4.DigitalBox120.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 136: Gl_Scr_4.Label3_120.Text=parts3[b];break;
          case 137: Gl_Scr_4.DigitalBox121.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 138: Gl_Scr_4.DigitalBox122.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 139: Gl_Scr_4.DigitalBox123.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 140: Gl_Scr_4.DigitalBox124.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 141: Gl_Scr_4.DigitalBox125.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 142: Gl_Scr_4.DigitalBox126.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 143: Gl_Scr_4.DigitalBox127.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break; 


          case 144:  Gl_Scr_4.Label3_127.Text=parts3[b];break;
          case 145:  Gl_Scr_4.DigitalBox128.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 146:  Gl_Scr_4.DigitalBox129.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 147:  Gl_Scr_4.DigitalBox130.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 148:  Gl_Scr_4.DigitalBox131.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 149:  Gl_Scr_4.DigitalBox132.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 150:  Gl_Scr_4.DigitalBox133.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 151:  Gl_Scr_4.DigitalBox134.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 152:  Gl_Scr_4.Label3_134.Text=parts3[b];break;
          case 153:  Gl_Scr_4.DigitalBox135.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 154: Gl_Scr_4.DigitalBox136.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 155: Gl_Scr_4.DigitalBox137.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 156: Gl_Scr_4.DigitalBox138.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 157: Gl_Scr_4.DigitalBox139.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 158: Gl_Scr_4.DigitalBox140.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 159: Gl_Scr_4.DigitalBox141.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 160: Gl_Scr_4.Label3_141.Text=parts3[b];break;
          case 161: Gl_Scr_4.DigitalBox142.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 162: Gl_Scr_4.DigitalBox143.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 163: Gl_Scr_4.DigitalBox144.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 164: Gl_Scr_4.DigitalBox145.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 165: Gl_Scr_4.DigitalBox146.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 166: Gl_Scr_4.DigitalBox147.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 167: Gl_Scr_4.DigitalBox148.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 168:  Gl_Scr_4.Label3_148.Text=parts3[b];break;
          case 169:  Gl_Scr_4.DigitalBox149.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 170:  Gl_Scr_4.DigitalBox150.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 171:  Gl_Scr_4.DigitalBox151.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 172:  Gl_Scr_4.DigitalBox152.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 173:  Gl_Scr_4.DigitalBox153.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 174:  Gl_Scr_4.DigitalBox154.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 175:  Gl_Scr_4.DigitalBox155.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 176:  Gl_Scr_4.Label3_155.Text=parts3[b];break;
          case 177:  Gl_Scr_4.DigitalBox156.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 178: Gl_Scr_4.DigitalBox157.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 179: Gl_Scr_4.DigitalBox158.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 180: Gl_Scr_4.DigitalBox159.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 181: Gl_Scr_4.DigitalBox160.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 182: Gl_Scr_4.DigitalBox161.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 183: Gl_Scr_4.DigitalBox162.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 184: Gl_Scr_4.Label3_162.Text=parts3[b];break;
          case 185: Gl_Scr_4.DigitalBox163.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 186: Gl_Scr_4.DigitalBox164.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 187: Gl_Scr_4.DigitalBox165.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 188: Gl_Scr_4.DigitalBox166.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 189: Gl_Scr_4.DigitalBox167.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 190: Gl_Scr_4.DigitalBox168.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 191: Gl_Scr_4.DigitalBox169.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;  

          case 192: Gl_Scr_4.Label3_169.Text=parts3[b];break;
          case 193: Gl_Scr_4.DigitalBox170.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 194: Gl_Scr_4.DigitalBox171.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 195: Gl_Scr_4.DigitalBox172.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 196: Gl_Scr_4.DigitalBox173.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 197: Gl_Scr_4.DigitalBox174.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 198: Gl_Scr_4.DigitalBox175.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 199: Gl_Scr_4.DigitalBox176.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;            

          
          default: Gl_Scr_4.DigitalBox2.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          }
       b++;
       }
    strokaArhiv = fileDayArhiv .ReadLine();
    stArhiv++;
    }
fileDayArhiv .Close();
luper=0;
}


Double B_o_cur=0;
Double B_o_cur_2=0;
//znach_8 - это либо газ, либо мазут в зависимости от DI и берется с разных AI_ch значение как на приборе








///////////////////////Переход газ/мазут, отдаю мгновенное знач уже нормализованное,(тут газ всегда!!!)
if (gaz_maz==0){Gl_Scr_2.DigitalBox578.Attribute1=" Газ"; Gl_Scr_2.DigitalBox578.Attribute2="м3/ч .";
                          ModbusSlaveTCP_HMI_CurDate_7=znach_8; 
                          //ModbusSlaveTCP_HMI_CurDate_8=0;
                          //B_o_cur=(12.37*273*P_g*znach_8)/((T_g+273)*101.32*0.988);

                          //ModbusSlaveTCP_HMI_CurDate_16=znach_2_8; 
                          //ModbusSlaveTCP_HMI_CurDate_17=0;
                          //B_o_cur_2=(12.37*273*P_g*znach_2_8)/((T_g+273)*101.32*0.988);
                     } 

              
///////////////////////

//////////////////////////отдаю на PC тек.данные
//Топка А
ModbusSlaveTCP_HMI_CurDate_0=znach_1; //CO
ModbusSlaveTCP_HMI_CurDate_1=znach_2; //NO
ModbusSlaveTCP_HMI_CurDate_2=znach_4; //O2
ModbusSlaveTCP_HMI_CurDate_3=znach_7; //CH4
ModbusSlaveTCP_HMI_CurDate_4=znach_3; //NO2!!! только в этой версии 
ModbusSlaveTCP_HMI_CurDate_5=znach_6; //CO2 %
ModbusSlaveTCP_HMI_CurDate_6=0.0; //NOx тек нету
//Bg 7
ModbusSlaveTCP_HMI_CurDate_8=znach_K; //K

//P и T значение
//ModbusSlaveTCP_HMI_CurDate_18=T_g;
//ModbusSlaveTCP_HMI_CurDate_19=P_g;

//Bo
//ModbusSlaveTCP_HMI_CurDate_20=B_o_cur;//Bo текущее
///////////////////////


////////////////////////Обратный отсчет для 20 мин
string[] parts1 = Gl_Scr_2.lblMillisecs.Text.Split(' ');
string[] partsa = parts1[0].Split(':');
string[] partsb = parts1[1].Split('.');

DateTime stopTime = new DateTime(
Convert.ToInt32(partsb[2]),
Convert.ToInt32(partsb[1]),
Convert.ToInt32(partsb[0]),
Convert.ToInt32(partsa[0]),
Convert.ToInt32(partsa[1]),
Convert.ToInt32(partsa[2]));

            long currTicks = DateTime.Now.Ticks;
            long stopTicks = stopTime.Ticks;


if (stopTicks - currTicks > 0)
{
DateTime timeToLeft = new DateTime(stopTicks - currTicks);
//Gl_Scr_2.Label27.Text = (timeToLeft.Day - 1).ToString("00") +":"+timeToLeft.ToLongTimeString();

Gl_Scr_2.Label27.Text = timeToLeft.Minute.ToString("00") +":"+timeToLeft.Second.ToString("00");
////////////////////////






////Достал млин этот Леша!!! Специально для него сред.конц в ppm!!!

//А
//total_1_ppm+=znach_1;           //конверсия в ppm CO +
//sred_konc_1_ppm=total_1_ppm/s;

//total_2_ppm+=znach_2;           //конверсия в ppm NO +
//sred_konc_2_ppm=total_2_ppm/s;

total_3_ppm+=znach_4;           //конверсия в % O2 +
sred_konc_3_ppm=total_3_ppm/s;

//total_4_ppm+=znach_7;           //конверсия в ppm CH4 +
//sred_konc_4_ppm=total_4_ppm/s;

//total_5_ppm+=znach_3;           //конверсия в ppm SO2 -
//sred_konc_5_ppm=total_5_ppm/s;

//total_6_ppm+=znach_6;           //конверсия в % CO2 +
//sred_konc_6_ppm=total_6_ppm/s;

//total_7_ppm+=znach_5;           //конверсия в ppm NOx -
//sred_konc_7_ppm=total_7_ppm/s;


//t&P
//total_T+=T_g;           //сред Tg
//sred_T=total_T/s;
//total_P+=P_g;           //сред Pg
//sred_P=total_P/s;



//////////////////////////////////////////////////////////////////////ТАБЛИЦА 2!!!!!!


if (gaz_maz==0){
total_8_g+=znach_8; sred_konc_8_g=total_8_g/s_g;
s_g++;}                                                                           //Bg среднее

                                                                       
if ((21-znach_4)!=0){

//total_8+=B_o_cur;            //Bo среднее
//sred_konc_8=total_8/s;

//полутока А
total_1+=znach_1 *1.25*( 21/(21-znach_4))/3.5;       //конверсия в мгнм3 CO +
sred_konc_1=total_1/s;

total_2+=(znach_2 *2.054*(21/(21-znach_4))/3.5)*0.13;              //конверсия в мг\нм3 NO +
sred_konc_2=total_2/s;

total_3+=(znach_2 *2.054*(21/(21-znach_4))/3.5)*0.8;            //конверсия в мг\нм NO2 + в этой версии
sred_konc_3=total_3/s;

//total_4+=znach_5 *2.054*(21/(21-znach_4))/3.5;            //конверсия в мг\нм3 NO2 -
//sred_konc_4=total_4/s;


total_5+=(znach_6 *1.96*(21/(21-znach_4))/3.5)*10000;             //конверсия в мг\нм3 CO2 +
sred_konc_5=total_5/s;

total_6+=znach_2 *2.054*(21/(21-znach_4))/3.5;            //конверсия в мг\нм3 NOx +
sred_konc_6=total_6/s;

total_7+=znach_7 *0.72*(21/(21-znach_4))/3.5;            //конверсия в мг\нм3 CH4 +
sred_konc_7=total_7/s;

total_8_m+=znach_K; sred_konc_8_m=total_8_m/s_m; //K

}

s_m++;   

s++;
////////////////////////
}
else
{   
out_off_time = 1;


//Вывод на экран HMI 20 мин концентрации
//время
Gl_Scr_2.Label3_1.Text=DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
//А
Gl_Scr_2.DigitalBox30.Value=sred_konc_1; //СО_20
//Gl_Scr_2.DigitalBox31.Value=sred_konc_2; //NO_20
//Gl_Scr_2.DigitalBox32.Value=sred_konc_3; //SO2_20
//Gl_Scr_2.DigitalBox33.Value=sred_konc_4; //NO2_20
Gl_Scr_2.DigitalBox34.Value=sred_konc_5; //CO2_20
Gl_Scr_2.DigitalBox35.Value=sred_konc_6; //NOx_20
Gl_Scr_2.DigitalBox36.Value=sred_konc_7; //CH4_20


if ((ras_const==1)||(STOP_hist==0))
{
// Сi(сред конц за 20 мин.)= ModbusSlaveTCP_PC_MCD_0 /( (0,001*35,16)/к * (сред за 20 мин. Вg)/3600  )
     if (STOP_hist==1)
     {
     sred_konc_1=ModbusSlaveTCP_PC_MCD_0 /  ( 10000.0/3600.0 * (0.001*35.16 /1.078)  );//CO
     sred_konc_2=ModbusSlaveTCP_PC_MCD_1 /  ( 10000.0/3600.0 * 35.16 /1.078 *0.001 );//NO     
     sred_konc_3=ModbusSlaveTCP_PC_MCD_4 /  ( 10000.0/3600.0 * 35.16 /1.078 *0.001 );//NO2
     sred_konc_5=ModbusSlaveTCP_PC_MCD_5 /  ( 10000.0/3600.0 * 35.16 /1.078 *0.001 );//CO2
     sred_konc_6=ModbusSlaveTCP_PC_MCD_6 /  ( 10000.0/3600.0 * 35.16 /1.078 *0.001 );//NOx
     sred_konc_7=ModbusSlaveTCP_PC_MCD_3 /  ( 10000.0/3600.0 * 35.16 /1.078 *0.001 );//CH4

     sred_konc_8_g=10000.0;//Bg
     sred_konc_8_m=1.078;//K
     }
     else
     {
     sred_konc_1=0.0;//CO
     sred_konc_2=0.0;//NO     
     sred_konc_3=0.0;//NO2
     sred_konc_5=0.0;//CO2
     sred_konc_6=0.0;//NOx
     sred_konc_7=0.0;//CH4
     }

     Gl_Scr_2.Label3_1.Text=DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
//А
     Gl_Scr_2.DigitalBox30.Value=0.0; //СО_20
     //Gl_Scr_2.DigitalBox31.Value=sred_konc_2; //NO_20
     //Gl_Scr_2.DigitalBox32.Value=sred_konc_3; //SO2_20
     //Gl_Scr_2.DigitalBox33.Value=sred_konc_4; //NO2_20
     Gl_Scr_2.DigitalBox34.Value=0.0; //CO2_20
     Gl_Scr_2.DigitalBox35.Value=0.0; //NOx_20
     Gl_Scr_2.DigitalBox36.Value=0.0; //CH4_20
}


total_1=0;
total_2=0;
total_3=0;
total_4=0;
total_5=0;
total_6=0;
total_7=0;


total_1_ppm=0;
total_2_ppm=0;
total_3_ppm=0;
total_4_ppm=0;
total_5_ppm=0;
total_6_ppm=0;
total_7_ppm=0;



total_8_g=0;
total_8_m=0;
total_8=0;


total_T=0;
total_P=0;


s_g=1;
s_m=1;
s=1;



//Отдаю на PC 20 мин концентрации
//А
ModbusSlaveTCP_HMI_AvgDate20_0=sred_konc_1;      //СО_20_PC
ModbusSlaveTCP_HMI_AvgDate20_1=sred_konc_2;      //NО_20_PC
ModbusSlaveTCP_HMI_AvgDate20_2=sred_konc_3_ppm;  //О2_20_PC % !!!
ModbusSlaveTCP_HMI_AvgDate20_3=sred_konc_7;      //CH4_20_PC
ModbusSlaveTCP_HMI_AvgDate20_4=sred_konc_3;      //NO2_20_PC только в этой версии
ModbusSlaveTCP_HMI_AvgDate20_5=sred_konc_5;      //CO2_20_PC
ModbusSlaveTCP_HMI_AvgDate20_6=sred_konc_6;      //NOx_20_PC
ModbusSlaveTCP_HMI_AvgDate20_7=sred_konc_8_g;    //Bg_20_PC
ModbusSlaveTCP_HMI_AvgDate20_8=sred_konc_8_m;    //K

//ModbusSlaveTCP_Rezerv2_0=reg_alarm_20;
//ModbusSlaveTCP_HMI_Alarm_0=reg_alarm_20;
reg_alarm_20=1;
//TurnBitOn(reg_alarm_20,0);  //Hist_20-------------->ModbusSlaveTCP_Rezerv2_0  
STOP_hist=1;
ras_const=0;//сброс тригера расчета по константам

//ModbusSlaveTCP_HMI_AvgDate20_18=sred_T;    //Tg_20_PC
//ModbusSlaveTCP_HMI_AvgDate20_19=sred_P;    //Pg_20_PC

//ModbusSlaveTCP_HMI_AvgDate20_20=sred_konc_8;    //Bo_20_PC

/////////////////////////H20M_Cnt++;   перенес в !!!!!!!!!!!!!!

///////Запись в csv файлик///////////////////////////////////
System.IO.StreamWriter file1 = new System.IO.StreamWriter(path+"Hour.csv");
System.IO.StreamWriter file_cur = new System.IO.StreamWriter(path+"current.csv",true);///для Лёши

// (0,001*35,16)/к * (сред за 20 мин. Вg)/3600 * Сi(сред конц за 20 мин.)
str00 = str40;
str40 = str20;
str20 = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + ";" + (sred_konc_1*sred_konc_8_g/3600 * 35.16 /sred_konc_8_m *0.001).ToString() + ";" + (sred_konc_2*sred_konc_8_g/3600 * 35.16 /sred_konc_8_m *0.001).ToString() + ";" + 
(0.0).ToString() + ";" + (sred_konc_3*sred_konc_8_g/3600 * 35.16 /sred_konc_8_m *0.001).ToString() + ";" + (sred_konc_5*sred_konc_8_g/3600 * 35.16 /sred_konc_8_m *0.001).ToString() + ";" + 
(sred_konc_6*sred_konc_8_g/3600 * 35.16 /sred_konc_8_m *0.001).ToString()+ ";" + (sred_konc_7*sred_konc_8_g/3600 * 35.16 /sred_konc_8_m *0.001).ToString();


double  proba_1; //CO
double  proba_2; //NO
double  proba_3; //O2 
double  proba_4; //CH4
double  proba_5; //NO2 !!!
double  proba_6; //CO2
double  proba_7; //NOx 
double  proba_8_g; //Bg
double  proba_8_m; //K


//double  proba_2_1=0; //CO
//double  proba_2_2=0; //NO
//double  proba_2_3=0; //O2 
//double  proba_2_4=0; //CH4
//double  proba_2_5=0; //SO2 
//double  proba_2_6=0; //CO2
//double  proba_2_7=0; //NOx 
//double  proba_2_8_g=0; //Bg
//double  proba_2_8_m=0; //Bm 


//double  proba_T; //Tg
//double  proba_P; //Pg

//double  proba_8;     //Bo
//double  proba_2_8=0;   //Bo

proba_1=sred_konc_1;      //СО_20_PC
proba_2=sred_konc_2;      //NО_20_PC
proba_3=sred_konc_3_ppm;  //О2_20_PC !!!
proba_4=sred_konc_7;      //CH4_20_PC
proba_5=sred_konc_3;      //NO2_20_PC !!!
proba_6=sred_konc_5;      //CO2_20_PC
proba_7=sred_konc_6;      //NOx_20_PC
proba_8_g=sred_konc_8_g;  //Bg_20_PC
proba_8_m=sred_konc_8_m;  //K_PC



//proba_T=sred_T;    //Tg_20_PC
//proba_P=sred_P;    //Pg_20_PC

//proba_8=sred_konc_8;        //Bo_20_PC



file_cur.WriteLine( DateTime.Now.ToString("dd.MM.yyyy H:mm:ss") + "=" + ModbusSlaveTCP_HMI_Alarm_0.ToString() + ";" + H20M_Cnt.ToString() + ";" + 
(System.Math.Round(proba_1,3)).ToString() + ";" + (System.Math.Round(proba_2,3)).ToString() + ";"  + (System.Math.Round(proba_3,3)).ToString() + ";" + (System.Math.Round(proba_4,3)).ToString() + ";" + 
(System.Math.Round(proba_5,3)).ToString() + ";" + (System.Math.Round(proba_6,3)).ToString() +  ";" + (System.Math.Round(proba_7,3)).ToString() +  ";" + (System.Math.Round(proba_8_g,3)).ToString() +  ";" + (System.Math.Round(proba_8_m,3)).ToString() );



file1.WriteLine(str20);
file1.WriteLine(str40);
file1.WriteLine(str00);
file1.Close();
file_cur.Close();

//////////////////////////////////////////////////////////////////////////////////////////

///////Чтение и заполнение таблицы нах.../////////////////////////////////////////
System.IO.StreamReader file2 = new System.IO.StreamReader(path+"Hour.csv");

string stroka = file2.ReadLine();int st=0;
    while ((stroka!=null) & (stroka!="null"))
    {
    string[] parts3 = stroka.Split(';');

    //Групповая обработка
    int b=0;
       while (b<=7)
       {
 //      ControlsLib.DigitalBox  D;           
          switch (b+st*8)
          {
          case 0:  Gl_Scr_2.Label2_1.Text=parts3[b];break;
          case 1:  Gl_Scr_2.DigitalBox2.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 2:  Gl_Scr_2.DigitalBox3.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 3:  Gl_Scr_2.DigitalBox4.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 4:  Gl_Scr_2.DigitalBox5.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 5:  Gl_Scr_2.DigitalBox6.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 6:  Gl_Scr_2.DigitalBox7.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 7:  Gl_Scr_2.DigitalBox8.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          case 8:  Gl_Scr_2.Label2_8.Text=parts3[b];break;
          case 9:  Gl_Scr_2.DigitalBox9.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 10: Gl_Scr_2.DigitalBox10.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 11: Gl_Scr_2.DigitalBox11.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 12: Gl_Scr_2.DigitalBox12.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 13: Gl_Scr_2.DigitalBox13.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 14: Gl_Scr_2.DigitalBox14.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 15: Gl_Scr_2.DigitalBox15.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;

          case 16: Gl_Scr_2.Label2_15.Text=parts3[b];break;
          case 17: Gl_Scr_2.DigitalBox16.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 18: Gl_Scr_2.DigitalBox17.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 19: Gl_Scr_2.DigitalBox18.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 20: Gl_Scr_2.DigitalBox19.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 21: Gl_Scr_2.DigitalBox20.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 22: Gl_Scr_2.DigitalBox21.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          case 23: Gl_Scr_2.DigitalBox22.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          
          default: Gl_Scr_2.DigitalBox2.Value=Convert.ToDouble(parts3[b].Replace(',','.'));break;
          }
       b++;
       }
    stroka = file2.ReadLine();
    st++;
    }
file2.Close();

znach_L_3=znach_L_2;
znach_L_2=znach_L_1;
znach_L_1=sredz;
Function1();
conter_izm++;



StartScheduler(2); ///Запуск скрипта синхронизации времени
 
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}
/////////////////////////////////////////////////////////

////////////Сумма за час///////
if (conter_izm==3)
{
//znach_Sum_3per=znach_L_1+znach_L_2+znach_L_3;
conter_izm=0;






Gl_Scr_2.DigitalBox23.Value = (Gl_Scr_2.DigitalBox2.Value + Gl_Scr_2.DigitalBox9.Value + Gl_Scr_2.DigitalBox16.Value)*1.2;
Gl_Scr_2.DigitalBox24.Value = (Gl_Scr_2.DigitalBox3.Value + Gl_Scr_2.DigitalBox10.Value + Gl_Scr_2.DigitalBox17.Value)*1.2;
Gl_Scr_2.DigitalBox25.Value = (Gl_Scr_2.DigitalBox4.Value + Gl_Scr_2.DigitalBox11.Value + Gl_Scr_2.DigitalBox18.Value)*1.2;
Gl_Scr_2.DigitalBox26.Value = (Gl_Scr_2.DigitalBox5.Value + Gl_Scr_2.DigitalBox12.Value + Gl_Scr_2.DigitalBox19.Value)*1.2;
Gl_Scr_2.DigitalBox27.Value = (Gl_Scr_2.DigitalBox6.Value + Gl_Scr_2.DigitalBox13.Value + Gl_Scr_2.DigitalBox20.Value)*1.2;
Gl_Scr_2.DigitalBox28.Value = (Gl_Scr_2.DigitalBox7.Value + Gl_Scr_2.DigitalBox14.Value + Gl_Scr_2.DigitalBox21.Value)*1.2;
Gl_Scr_2.DigitalBox29.Value = (Gl_Scr_2.DigitalBox8.Value + Gl_Scr_2.DigitalBox15.Value + Gl_Scr_2.DigitalBox22.Value)*1.2;
Gl_Scr_2.Label2_22.Text=DateTime.Now.ToString();






//Gl_Scr_3.Label22_22.Text=DateTime.Now.ToString() ;

///////Запись в csv файлик///////////////////////////////////
////////////////////////////////////////////////////System.IO.StreamWriter fileD = new System.IO.StreamWriter(path+"Day\\Day_"+nameD+".csv", true);
//System.IO.StreamWriter fileD = new System.IO.StreamWriter(path+"Day_"+ nameD+".csv", true);

          switch ( Convert.ToInt32(DateTime.Now.Hour) )
          {
          case 0:  Gl_Scr_3.Label22_162.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox163.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox164.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox165.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox166.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox167.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox168.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox169.Value=Gl_Scr_2.DigitalBox29.Value;

 Gl_Scr_3.Label22_169.Text=DateTime.Now.ToString(); 

 Gl_Scr_3.DigitalBox170.Value= Gl_Scr_3.DigitalBox2.Value + Gl_Scr_3.DigitalBox9.Value + Gl_Scr_3.DigitalBox16.Value + Gl_Scr_3.DigitalBox23.Value + Gl_Scr_3.DigitalBox30.Value + Gl_Scr_3.DigitalBox37.Value + 
                               Gl_Scr_3.DigitalBox44.Value + Gl_Scr_3.DigitalBox51.Value + Gl_Scr_3.DigitalBox58.Value + Gl_Scr_3.DigitalBox65.Value + Gl_Scr_3.DigitalBox72.Value + Gl_Scr_3.DigitalBox79.Value + 
                               Gl_Scr_3.DigitalBox86.Value + Gl_Scr_3.DigitalBox93.Value + Gl_Scr_3.DigitalBox100.Value + Gl_Scr_3.DigitalBox107.Value + Gl_Scr_3.DigitalBox114.Value + Gl_Scr_3.DigitalBox121.Value +
                               Gl_Scr_3.DigitalBox128.Value + Gl_Scr_3.DigitalBox135.Value + Gl_Scr_3.DigitalBox142.Value + Gl_Scr_3.DigitalBox149.Value + Gl_Scr_3.DigitalBox156.Value + Gl_Scr_3.DigitalBox163.Value;                               
 Gl_Scr_3.DigitalBox171.Value= Gl_Scr_3.DigitalBox3.Value + Gl_Scr_3.DigitalBox10.Value + Gl_Scr_3.DigitalBox17.Value + Gl_Scr_3.DigitalBox24.Value + Gl_Scr_3.DigitalBox31.Value + Gl_Scr_3.DigitalBox38.Value + 
                               Gl_Scr_3.DigitalBox45.Value + Gl_Scr_3.DigitalBox52.Value + Gl_Scr_3.DigitalBox59.Value + Gl_Scr_3.DigitalBox66.Value + Gl_Scr_3.DigitalBox73.Value + Gl_Scr_3.DigitalBox80.Value + 
                               Gl_Scr_3.DigitalBox87.Value + Gl_Scr_3.DigitalBox94.Value + Gl_Scr_3.DigitalBox101.Value + Gl_Scr_3.DigitalBox108.Value + Gl_Scr_3.DigitalBox115.Value + Gl_Scr_3.DigitalBox122.Value +
                               Gl_Scr_3.DigitalBox129.Value + Gl_Scr_3.DigitalBox136.Value + Gl_Scr_3.DigitalBox143.Value + Gl_Scr_3.DigitalBox150.Value + Gl_Scr_3.DigitalBox157.Value + Gl_Scr_3.DigitalBox164.Value;
 Gl_Scr_3.DigitalBox172.Value= Gl_Scr_3.DigitalBox4.Value + Gl_Scr_3.DigitalBox11.Value + Gl_Scr_3.DigitalBox18.Value + Gl_Scr_3.DigitalBox25.Value + Gl_Scr_3.DigitalBox32.Value + Gl_Scr_3.DigitalBox39.Value + 
                               Gl_Scr_3.DigitalBox46.Value + Gl_Scr_3.DigitalBox53.Value + Gl_Scr_3.DigitalBox60.Value + Gl_Scr_3.DigitalBox67.Value + Gl_Scr_3.DigitalBox74.Value + Gl_Scr_3.DigitalBox81.Value + 
                               Gl_Scr_3.DigitalBox88.Value + Gl_Scr_3.DigitalBox95.Value + Gl_Scr_3.DigitalBox102.Value + Gl_Scr_3.DigitalBox109.Value + Gl_Scr_3.DigitalBox116.Value + Gl_Scr_3.DigitalBox123.Value +
                               Gl_Scr_3.DigitalBox130.Value + Gl_Scr_3.DigitalBox137.Value + Gl_Scr_3.DigitalBox144.Value + Gl_Scr_3.DigitalBox151.Value + Gl_Scr_3.DigitalBox158.Value + Gl_Scr_3.DigitalBox165.Value;
 Gl_Scr_3.DigitalBox173.Value= Gl_Scr_3.DigitalBox5.Value + Gl_Scr_3.DigitalBox12.Value + Gl_Scr_3.DigitalBox19.Value + Gl_Scr_3.DigitalBox26.Value + Gl_Scr_3.DigitalBox33.Value + Gl_Scr_3.DigitalBox40.Value + 
                               Gl_Scr_3.DigitalBox47.Value + Gl_Scr_3.DigitalBox54.Value + Gl_Scr_3.DigitalBox61.Value + Gl_Scr_3.DigitalBox68.Value + Gl_Scr_3.DigitalBox75.Value + Gl_Scr_3.DigitalBox82.Value + 
                               Gl_Scr_3.DigitalBox89.Value + Gl_Scr_3.DigitalBox96.Value + Gl_Scr_3.DigitalBox103.Value + Gl_Scr_3.DigitalBox110.Value + Gl_Scr_3.DigitalBox117.Value + Gl_Scr_3.DigitalBox124.Value +
                               Gl_Scr_3.DigitalBox131.Value + Gl_Scr_3.DigitalBox138.Value + Gl_Scr_3.DigitalBox145.Value + Gl_Scr_3.DigitalBox152.Value + Gl_Scr_3.DigitalBox159.Value + Gl_Scr_3.DigitalBox166.Value;
 Gl_Scr_3.DigitalBox174.Value= Gl_Scr_3.DigitalBox6.Value + Gl_Scr_3.DigitalBox13.Value + Gl_Scr_3.DigitalBox20.Value + Gl_Scr_3.DigitalBox27.Value + Gl_Scr_3.DigitalBox34.Value + Gl_Scr_3.DigitalBox41.Value + 
                               Gl_Scr_3.DigitalBox48.Value + Gl_Scr_3.DigitalBox54.Value + Gl_Scr_3.DigitalBox62.Value + Gl_Scr_3.DigitalBox69.Value + Gl_Scr_3.DigitalBox76.Value + Gl_Scr_3.DigitalBox83.Value + 
                               Gl_Scr_3.DigitalBox90.Value + Gl_Scr_3.DigitalBox97.Value + Gl_Scr_3.DigitalBox104.Value + Gl_Scr_3.DigitalBox111.Value + Gl_Scr_3.DigitalBox118.Value + Gl_Scr_3.DigitalBox125.Value +
                               Gl_Scr_3.DigitalBox132.Value + Gl_Scr_3.DigitalBox139.Value + Gl_Scr_3.DigitalBox146.Value + Gl_Scr_3.DigitalBox153.Value + Gl_Scr_3.DigitalBox160.Value + Gl_Scr_3.DigitalBox167.Value;
 Gl_Scr_3.DigitalBox175.Value= Gl_Scr_3.DigitalBox7.Value + Gl_Scr_3.DigitalBox14.Value + Gl_Scr_3.DigitalBox21.Value + Gl_Scr_3.DigitalBox28.Value + Gl_Scr_3.DigitalBox35.Value + Gl_Scr_3.DigitalBox42.Value + 
                               Gl_Scr_3.DigitalBox49.Value + Gl_Scr_3.DigitalBox56.Value + Gl_Scr_3.DigitalBox63.Value + Gl_Scr_3.DigitalBox70.Value + Gl_Scr_3.DigitalBox77.Value + Gl_Scr_3.DigitalBox84.Value + 
                               Gl_Scr_3.DigitalBox91.Value + Gl_Scr_3.DigitalBox98.Value + Gl_Scr_3.DigitalBox105.Value + Gl_Scr_3.DigitalBox112.Value + Gl_Scr_3.DigitalBox119.Value + Gl_Scr_3.DigitalBox126.Value +
                               Gl_Scr_3.DigitalBox133.Value + Gl_Scr_3.DigitalBox140.Value + Gl_Scr_3.DigitalBox147.Value + Gl_Scr_3.DigitalBox154.Value + Gl_Scr_3.DigitalBox161.Value + Gl_Scr_3.DigitalBox168.Value;

 Gl_Scr_3.DigitalBox175.Value= Gl_Scr_3.DigitalBox8.Value + Gl_Scr_3.DigitalBox15.Value + Gl_Scr_3.DigitalBox22.Value + Gl_Scr_3.DigitalBox29.Value + Gl_Scr_3.DigitalBox36.Value + Gl_Scr_3.DigitalBox43.Value + 
                               Gl_Scr_3.DigitalBox50.Value + Gl_Scr_3.DigitalBox57.Value + Gl_Scr_3.DigitalBox64.Value + Gl_Scr_3.DigitalBox71.Value + Gl_Scr_3.DigitalBox78.Value + Gl_Scr_3.DigitalBox85.Value + 
                               Gl_Scr_3.DigitalBox92.Value + Gl_Scr_3.DigitalBox99.Value + Gl_Scr_3.DigitalBox106.Value + Gl_Scr_3.DigitalBox113.Value + Gl_Scr_3.DigitalBox120.Value + Gl_Scr_3.DigitalBox127.Value +
                               Gl_Scr_3.DigitalBox134.Value + Gl_Scr_3.DigitalBox141.Value + Gl_Scr_3.DigitalBox148.Value + Gl_Scr_3.DigitalBox155.Value + Gl_Scr_3.DigitalBox162.Value + Gl_Scr_3.DigitalBox169.Value;


nameD=DateTime.Now.ToString("dd.MM.yyyy"). Replace('.','_').Replace(':','_').Replace('-','_').Replace(' ','_');
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString()+ ";" +Gl_Scr_2.DigitalBox29.Value.ToString());
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_3.DigitalBox170.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox171.Value.ToString() + ";" + Gl_Scr_3.DigitalBox172.Value.ToString() + ";" + Gl_Scr_3.DigitalBox173.Value.ToString() + ";" +Gl_Scr_3.DigitalBox174.Value.ToString() + ";" +Gl_Scr_3.DigitalBox175.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox176.Value.ToString());
//fileD.Close();




break;
          case 1:  Gl_Scr_3.Label22_1.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox2.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox3.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox4.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox5.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox6.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox7.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox8.Value=Gl_Scr_2.DigitalBox29.Value;                   
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 2:  Gl_Scr_3.Label22_8.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox9.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox10.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox11.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox12.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox13.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox14.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox15.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 3:  Gl_Scr_3.Label22_15.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox16.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox17.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox18.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox19.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox20.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox21.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox22.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 4:  Gl_Scr_3.Label22_22.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox23.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox24.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox25.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox26.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox27.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox28.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox29.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 5:  Gl_Scr_3.Label22_29.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox30.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox31.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox32.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox33.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox34.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox35.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox36.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 6:  Gl_Scr_3.Label22_36.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox37.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox38.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox39.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox40.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox41.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox42.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox43.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 7:  Gl_Scr_3.Label22_43.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox44.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox45.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox46.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox47.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox48.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox49.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox50.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 8:  Gl_Scr_3.Label22_50.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox51.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox52.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox53.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox54.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox55.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox56.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox57.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 9:  Gl_Scr_3.Label22_57.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox58.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox59.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox60.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox61.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox62.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox63.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox64.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 10:  Gl_Scr_3.Label22_64.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox65.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox66.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox67.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox68.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox69.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox70.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox71.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 11:  Gl_Scr_3.Label22_71.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox72.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox73.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox74.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox75.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox76.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox77.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox78.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 12:  Gl_Scr_3.Label22_78.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox79.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox80.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox81.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox82.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox83.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox84.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox85.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 13:  Gl_Scr_3.Label22_85.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox86.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox87.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox88.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox89.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox90.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox91.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox92.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 14:  Gl_Scr_3.Label22_92.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox93.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox94.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox95.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox96.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox97.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox98.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox99.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 15:  Gl_Scr_3.Label22_99.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox100.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox101.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox102.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox103.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox104.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox105.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox106.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 16:  Gl_Scr_3.Label22_106.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox107.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox108.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox109.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox110.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox111.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox112.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox113.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 17:  Gl_Scr_3.Label22_113.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox114.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox115.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox116.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox117.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox118.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox119.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox120.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 18:  Gl_Scr_3.Label22_120.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox121.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox122.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox123.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox124.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox125.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox126.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox127.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 19:  Gl_Scr_3.Label22_127.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox128.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox129.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox130.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox131.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox132.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox133.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox134.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 20:  Gl_Scr_3.Label22_134.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox135.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox136.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox137.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox138.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox139.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox140.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox141.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 21:  Gl_Scr_3.Label22_141.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox142.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox143.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox144.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox145.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox146.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox147.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox148.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 22:  Gl_Scr_3.Label22_148.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox149.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox150.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox151.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox152.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox153.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox154.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox155.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          case 23:  Gl_Scr_3.Label22_155.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox156.Value=Gl_Scr_2.DigitalBox23.Value; 
                   Gl_Scr_3.DigitalBox157.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox158.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox159.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox160.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox161.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox162.Value=Gl_Scr_2.DigitalBox29.Value; 
//fileD.WriteLine(DateTime.Now.ToString() + ";" + Gl_Scr_2.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_2.DigitalBox24.Value.ToString() + ";" + Gl_Scr_2.DigitalBox25.Value.ToString() + ";" + Gl_Scr_2.DigitalBox26.Value.ToString() + ";" +Gl_Scr_2.DigitalBox27.Value.ToString() + ";" +Gl_Scr_2.DigitalBox28.Value.ToString());
//fileD.Close();
break;
          default:  Gl_Scr_3.Label22_141.Text=DateTime.Now.ToString(); 
                   Gl_Scr_3.DigitalBox142.Value=Gl_Scr_2.DigitalBox23.Value;
                   Gl_Scr_3.DigitalBox143.Value=Gl_Scr_2.DigitalBox24.Value; 
                   Gl_Scr_3.DigitalBox144.Value=Gl_Scr_2.DigitalBox25.Value;
                   Gl_Scr_3.DigitalBox145.Value=Gl_Scr_2.DigitalBox26.Value;
                   Gl_Scr_3.DigitalBox146.Value=Gl_Scr_2.DigitalBox27.Value;
                   Gl_Scr_3.DigitalBox147.Value=Gl_Scr_2.DigitalBox28.Value;
                   Gl_Scr_3.DigitalBox148.Value=Gl_Scr_2.DigitalBox29.Value; break;
          }




System.IO.StreamWriter fileDay = new System.IO.StreamWriter(path+"Day\\Day_"+nameD+".csv");
fileDay.WriteLine(Gl_Scr_3.Label22_1.Text + ";" + Gl_Scr_3.DigitalBox2.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox3.Value.ToString() + ";" + Gl_Scr_3.DigitalBox4.Value.ToString() + ";" + Gl_Scr_3.DigitalBox5.Value.ToString() + ";" +Gl_Scr_3.DigitalBox6.Value.ToString() + ";" +Gl_Scr_3.DigitalBox7.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox8.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_8.Text + ";" + Gl_Scr_3.DigitalBox9.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox10.Value.ToString() + ";" + Gl_Scr_3.DigitalBox11.Value.ToString() + ";" + Gl_Scr_3.DigitalBox12.Value.ToString() + ";" +Gl_Scr_3.DigitalBox13.Value.ToString() + ";" +Gl_Scr_3.DigitalBox14.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox15.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_15.Text + ";" + Gl_Scr_3.DigitalBox16.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox17.Value.ToString() + ";" + Gl_Scr_3.DigitalBox18.Value.ToString() + ";" + Gl_Scr_3.DigitalBox19.Value.ToString() + ";" +Gl_Scr_3.DigitalBox20.Value.ToString() + ";" +Gl_Scr_3.DigitalBox21.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox22.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_22.Text + ";" + Gl_Scr_3.DigitalBox23.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox24.Value.ToString() + ";" + Gl_Scr_3.DigitalBox25.Value.ToString() + ";" + Gl_Scr_3.DigitalBox26.Value.ToString() + ";" +Gl_Scr_3.DigitalBox27.Value.ToString() + ";" +Gl_Scr_3.DigitalBox28.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox29.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_29.Text + ";" + Gl_Scr_3.DigitalBox30.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox31.Value.ToString() + ";" + Gl_Scr_3.DigitalBox32.Value.ToString() + ";" + Gl_Scr_3.DigitalBox33.Value.ToString() + ";" +Gl_Scr_3.DigitalBox34.Value.ToString() + ";" +Gl_Scr_3.DigitalBox35.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox36.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_36.Text + ";" + Gl_Scr_3.DigitalBox37.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox38.Value.ToString() + ";" + Gl_Scr_3.DigitalBox39.Value.ToString() + ";" + Gl_Scr_3.DigitalBox40.Value.ToString() + ";" +Gl_Scr_3.DigitalBox41.Value.ToString() + ";" +Gl_Scr_3.DigitalBox42.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox43.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_43.Text + ";" + Gl_Scr_3.DigitalBox44.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox45.Value.ToString() + ";" + Gl_Scr_3.DigitalBox46.Value.ToString() + ";" + Gl_Scr_3.DigitalBox47.Value.ToString() + ";" +Gl_Scr_3.DigitalBox48.Value.ToString() + ";" +Gl_Scr_3.DigitalBox49.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox50.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_50.Text + ";" + Gl_Scr_3.DigitalBox51.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox52.Value.ToString() + ";" + Gl_Scr_3.DigitalBox53.Value.ToString() + ";" + Gl_Scr_3.DigitalBox54.Value.ToString() + ";" +Gl_Scr_3.DigitalBox55.Value.ToString() + ";" +Gl_Scr_3.DigitalBox56.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox57.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_57.Text + ";" + Gl_Scr_3.DigitalBox58.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox59.Value.ToString() + ";" + Gl_Scr_3.DigitalBox60.Value.ToString() + ";" + Gl_Scr_3.DigitalBox61.Value.ToString() + ";" +Gl_Scr_3.DigitalBox62.Value.ToString() + ";" +Gl_Scr_3.DigitalBox63.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox64.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_64.Text + ";" + Gl_Scr_3.DigitalBox65.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox66.Value.ToString() + ";" + Gl_Scr_3.DigitalBox67.Value.ToString() + ";" + Gl_Scr_3.DigitalBox68.Value.ToString() + ";" +Gl_Scr_3.DigitalBox69.Value.ToString() + ";" +Gl_Scr_3.DigitalBox70.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox71.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_71.Text + ";" + Gl_Scr_3.DigitalBox72.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox73.Value.ToString() + ";" + Gl_Scr_3.DigitalBox74.Value.ToString() + ";" + Gl_Scr_3.DigitalBox75.Value.ToString() + ";" +Gl_Scr_3.DigitalBox76.Value.ToString() + ";" +Gl_Scr_3.DigitalBox77.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox78.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_78.Text + ";" + Gl_Scr_3.DigitalBox79.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox80.Value.ToString() + ";" + Gl_Scr_3.DigitalBox81.Value.ToString() + ";" + Gl_Scr_3.DigitalBox82.Value.ToString() + ";" +Gl_Scr_3.DigitalBox83.Value.ToString() + ";" +Gl_Scr_3.DigitalBox84.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox85.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_85.Text + ";" + Gl_Scr_3.DigitalBox86.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox87.Value.ToString() + ";" + Gl_Scr_3.DigitalBox88.Value.ToString() + ";" + Gl_Scr_3.DigitalBox89.Value.ToString() + ";" +Gl_Scr_3.DigitalBox90.Value.ToString() + ";" +Gl_Scr_3.DigitalBox91.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox92.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_92.Text + ";" + Gl_Scr_3.DigitalBox93.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox94.Value.ToString() + ";" + Gl_Scr_3.DigitalBox95.Value.ToString() + ";" + Gl_Scr_3.DigitalBox96.Value.ToString() + ";" +Gl_Scr_3.DigitalBox97.Value.ToString() + ";" +Gl_Scr_3.DigitalBox98.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox99.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_99.Text + ";" + Gl_Scr_3.DigitalBox100.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox101.Value.ToString() + ";" + Gl_Scr_3.DigitalBox102.Value.ToString() + ";" + Gl_Scr_3.DigitalBox103.Value.ToString() + ";" +Gl_Scr_3.DigitalBox104.Value.ToString() + ";" +Gl_Scr_3.DigitalBox105.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox106.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_106.Text + ";" + Gl_Scr_3.DigitalBox107.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox108.Value.ToString() + ";" + Gl_Scr_3.DigitalBox109.Value.ToString() + ";" + Gl_Scr_3.DigitalBox110.Value.ToString() + ";" +Gl_Scr_3.DigitalBox111.Value.ToString() + ";" +Gl_Scr_3.DigitalBox112.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox113.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_113.Text + ";" + Gl_Scr_3.DigitalBox114.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox115.Value.ToString() + ";" + Gl_Scr_3.DigitalBox116.Value.ToString() + ";" + Gl_Scr_3.DigitalBox117.Value.ToString() + ";" +Gl_Scr_3.DigitalBox118.Value.ToString() + ";" +Gl_Scr_3.DigitalBox119.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox120.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_120.Text + ";" + Gl_Scr_3.DigitalBox121.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox122.Value.ToString() + ";" + Gl_Scr_3.DigitalBox123.Value.ToString() + ";" + Gl_Scr_3.DigitalBox124.Value.ToString() + ";" +Gl_Scr_3.DigitalBox125.Value.ToString() + ";" +Gl_Scr_3.DigitalBox126.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox127.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_127.Text + ";" + Gl_Scr_3.DigitalBox128.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox129.Value.ToString() + ";" + Gl_Scr_3.DigitalBox130.Value.ToString() + ";" + Gl_Scr_3.DigitalBox131.Value.ToString() + ";" +Gl_Scr_3.DigitalBox132.Value.ToString() + ";" +Gl_Scr_3.DigitalBox133.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox134.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_134.Text + ";" + Gl_Scr_3.DigitalBox135.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox136.Value.ToString() + ";" + Gl_Scr_3.DigitalBox137.Value.ToString() + ";" + Gl_Scr_3.DigitalBox138.Value.ToString() + ";" +Gl_Scr_3.DigitalBox139.Value.ToString() + ";" +Gl_Scr_3.DigitalBox140.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox141.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_141.Text + ";" + Gl_Scr_3.DigitalBox142.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox143.Value.ToString() + ";" + Gl_Scr_3.DigitalBox144.Value.ToString() + ";" + Gl_Scr_3.DigitalBox145.Value.ToString() + ";" +Gl_Scr_3.DigitalBox146.Value.ToString() + ";" +Gl_Scr_3.DigitalBox147.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox148.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_148.Text + ";" + Gl_Scr_3.DigitalBox149.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox150.Value.ToString() + ";" + Gl_Scr_3.DigitalBox151.Value.ToString() + ";" + Gl_Scr_3.DigitalBox152.Value.ToString() + ";" +Gl_Scr_3.DigitalBox153.Value.ToString() + ";" +Gl_Scr_3.DigitalBox154.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox155.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_155.Text + ";" + Gl_Scr_3.DigitalBox156.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox157.Value.ToString() + ";" + Gl_Scr_3.DigitalBox158.Value.ToString() + ";" + Gl_Scr_3.DigitalBox159.Value.ToString() + ";" +Gl_Scr_3.DigitalBox160.Value.ToString() + ";" +Gl_Scr_3.DigitalBox161.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox162.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_162.Text + ";" + Gl_Scr_3.DigitalBox163.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox164.Value.ToString() + ";" + Gl_Scr_3.DigitalBox165.Value.ToString() + ";" + Gl_Scr_3.DigitalBox166.Value.ToString() + ";" +Gl_Scr_3.DigitalBox167.Value.ToString() + ";" +Gl_Scr_3.DigitalBox168.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox169.Value.ToString());
fileDay.WriteLine(Gl_Scr_3.Label22_169.Text + ";" + Gl_Scr_3.DigitalBox170.Value.ToString() + ";" +  Gl_Scr_3.DigitalBox171.Value.ToString() + ";" + Gl_Scr_3.DigitalBox172.Value.ToString() + ";" + Gl_Scr_3.DigitalBox173.Value.ToString() + ";" +Gl_Scr_3.DigitalBox174.Value.ToString() + ";" +Gl_Scr_3.DigitalBox175.Value.ToString()+ ";" +Gl_Scr_3.DigitalBox176.Value.ToString());
fileDay.Close();

}
/////////////////////////////




//////////////////////////////////////////////////

string[] parts2 = Gl_Scr_2.Label13.Text.Split(' ');
string[] partsa2 = parts2[0].Split(':');
string[] partsb2 = parts2[1].Split('.');

DateTime stopTime2 = new DateTime(
Convert.ToInt32(partsb2[2]),
Convert.ToInt32(partsb2[1]),
Convert.ToInt32(partsb2[0]),
Convert.ToInt32(partsa2[0]),
Convert.ToInt32(partsa2[1]),
Convert.ToInt32(partsa2[2]));
//            long currTicks = DateTime.Now.Ticks;
            long stopTicks2 = stopTime2.Ticks;


if (stopTicks2 - currTicks > 0)
{
DateTime timeToLeft2 = new DateTime(stopTicks2 - currTicks);
Gl_Scr_2.Label14.Text =  timeToLeft2.Minute.ToString("00") +":"+timeToLeft2.Second.ToString("00");

}





//while (f<N) {Gl_Scr_4.ComboBox1.Items.Add("");string b=csvList[(N-1)-i].Substring(0,csvList[(N-1)-i].Length - 4); Gl_Scr_4.ComboBox1.Items[i]=b.Substring(razmer).Replace('_','.');f++;}
//добавляем полей сколько файлов нашли и заполняем в обратной последовательности


ModbusSlaveTCP_HMI_H20M_Cnt_0=H20M_Cnt;




//Забрал
DateTime TimeFromPC =DateTime.FromOADate(ModbusSlaveTCP_PC_DT_0);

Pref.LabelFromPC.Text="";
Pref.LabelFromPC.Text+=TimeFromPC .Hour.ToString("00")+":";
Pref.LabelFromPC.Text+=TimeFromPC .Minute.ToString("00")+":";
Pref.LabelFromPC.Text+=TimeFromPC .Second.ToString("00")+" ";

Pref.LabelFromPC.Text+=TimeFromPC .Day.ToString("00")+".";
Pref.LabelFromPC.Text+=TimeFromPC .Month.ToString("00")+".";
Pref.LabelFromPC.Text+=TimeFromPC .Year.ToString("0000");

///отдал бллллююааа
ModbusSlaveTCP_HMI_DateTime_0=Convert.ToDouble(DateTime.Now.ToOADate());

//retain
 CO_store = ModbusSlaveTCP_PC_MCD_0; //CO
 NO_store = ModbusSlaveTCP_PC_MCD_1; //NO     
 NO2_store = ModbusSlaveTCP_PC_MCD_4;//NO2
 CO2_store = ModbusSlaveTCP_PC_MCD_5;//CO2
 NOx_store = ModbusSlaveTCP_PC_MCD_6;//NOx
 CH4_store = ModbusSlaveTCP_PC_MCD_3;//CH4

K_store = ModbusSlaveTCP_PC_MCD_8; //k
B_min_store = ModbusSlaveTCP_PC_MCD_9; //Bmin
O2_max_store = ModbusSlaveTCP_PC_MCD_10;//O2_max



 