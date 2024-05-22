using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operations : MonoBehaviour
{
    public Text first_number;//1.say�
    public Text second_number;//2.say�
    public Text operation1;//��lem de�i�keni
    public Text result;//Sonu� de�i�keni
    public Text answer;//Sonucu do�ru veya yanl�� yazan de�i�ken
    public InputField result_input;
    float number1, number2, process1, process_result;
    string division;//B�l�m i�in gerekli de�i�ken
    void Start()
    {
        New_Question();//Fonksiyonu �a��r
    }
    public void Answer_Control()
    {
        if (float.Parse(result.text) == process_result && process1 != 4) //Ger�ek sonu� ile girilen sonu� ayn� ve i�lem b�lme i�lemi de�il ise
        {
            answer.text = "TRUE";//Sonu� do�ru
        }
        else if (process1 == 4 && result.text == division)//Ger�ek sonu� ile girilen sonu� ayn� ve i�lem b�lme i�lemi ise
        {
            answer.text = "TRUE";//Sonu� do�ru
        }
        else
        {
            answer.text = "FALSE";//Sonu� yanl��
        }
    }
    public void New_Question()
    {
        result_input.text = "";
        answer.text = "";
        number1 = Random.Range(1, 101);
        number2 = Random.Range(1, 101);
        process1 = Random.Range(1, 5);//4 i�lem i�in
        if (process1 == 1)//��lem 1 ise
        {
            operation1.text = "+";//Toplama i�lemi
            process_result = number1 + number2;
        }
        else if(process1 == 2)//��lem 2 ise
        {
            operation1.text = "-";//��karma i�lemi
            process_result = number1 - number2;
        }
        else if (process1 == 3)//��lem 3 ise
        {
            operation1.text = "*";//�arpma i�lemi
            process_result = number1 * number2;
        }
        else if (process1 == 4)//��lem 4 i�e
        {
            operation1.text = "/";//B�lme i�lemi
            process_result = number1 / number2;
            division = process_result.ToString("0.##");//Virg�lden sonra 2 basamak yazd�rmak i�in         
        }
        /* switch (process1)
         {
             case 1:
                 operation1.text = "+";
                 process_result = number1 + number2;
                 break;
             case 2:
                 operation1.text = "-";
                 process_result = number1 - number2;
                 break;
             case 3:
                 operation1.text = "*";
                 process_result = number1 * number2;
                 break;
             case 4:
                 operation1.text = "/";
                 process_result = number1 / number2;
                 break;
         }*/
        first_number.text = number1 + "";
        second_number.text = number2 + "";
    }
    public void Quit_Game()
    {
        Application.Quit();//Oyundan ��k
    }
}
