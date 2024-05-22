using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Operations : MonoBehaviour
{
    public Text first_number;//1.sayý
    public Text second_number;//2.sayý
    public Text operation1;//Ýþlem deðiþkeni
    public Text result;//Sonuç deðiþkeni
    public Text answer;//Sonucu doðru veya yanlýþ yazan deðiþken
    public InputField result_input;
    float number1, number2, process1, process_result;
    string division;//Bölüm için gerekli deðiþken
    void Start()
    {
        New_Question();//Fonksiyonu çaðýr
    }
    public void Answer_Control()
    {
        if (float.Parse(result.text) == process_result && process1 != 4) //Gerçek sonuç ile girilen sonuç ayný ve iþlem bölme iþlemi deðil ise
        {
            answer.text = "TRUE";//Sonuç doðru
        }
        else if (process1 == 4 && result.text == division)//Gerçek sonuç ile girilen sonuç ayný ve iþlem bölme iþlemi ise
        {
            answer.text = "TRUE";//Sonuç doðru
        }
        else
        {
            answer.text = "FALSE";//Sonuç yanlýþ
        }
    }
    public void New_Question()
    {
        result_input.text = "";
        answer.text = "";
        number1 = Random.Range(1, 101);
        number2 = Random.Range(1, 101);
        process1 = Random.Range(1, 5);//4 iþlem için
        if (process1 == 1)//Ýþlem 1 ise
        {
            operation1.text = "+";//Toplama iþlemi
            process_result = number1 + number2;
        }
        else if(process1 == 2)//Ýþlem 2 ise
        {
            operation1.text = "-";//Çýkarma iþlemi
            process_result = number1 - number2;
        }
        else if (process1 == 3)//Ýþlem 3 ise
        {
            operation1.text = "*";//Çarpma iþlemi
            process_result = number1 * number2;
        }
        else if (process1 == 4)//Ýþlem 4 iþe
        {
            operation1.text = "/";//Bölme iþlemi
            process_result = number1 / number2;
            division = process_result.ToString("0.##");//Virgülden sonra 2 basamak yazdýrmak için         
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
        Application.Quit();//Oyundan çýk
    }
}
