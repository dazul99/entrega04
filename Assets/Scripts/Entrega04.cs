using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Entrega04 : MonoBehaviour
{
    // Start is called before the first frame update
    private bool valid;
    private int feb = 28;
    //EJERCICIO 1
    float Lowest(float x, float y)
    {
        if (x < y) return x;
        return y;
    }

    //EJERCICIO 2
    bool Vocal(string letra)
    {
        if(letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u") return true;
        return false;
    }

    //EJERCICIO 3
    bool Valid(int day, int month, int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    feb++;
                }
            }
            else
            {
                feb++;
            }
        }

        if (month == 2)
        {
            if (day > feb)
            {
                valid = false;
            }
        }
        else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if (day > 31)
            {
                valid = false;
            }
        }
        else if (0 > month || month > 12)
        {
            valid = false;
        }
        else
        {
            if (day > 30)
            {
                valid = false;
            }
        }

        feb = 28;

        if (day < 1)
        {
            valid = false;
        }

        return valid;
    }

    //EJERCICIO 4
    bool Bisiestificaneitor(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }
    }

    //EJERCICIO 5
    void NextDay(int day, int month, int year) 
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    feb++;
                }
            }
            else
            {
                feb++;
            }
        }

        if (month == 2)
        {
            if (day == feb)
            {
                Debug.Log("1/3/"+year);
            }
            else Debug.Log((day++) + "/" + (month++) + "/" + year);
        }
        else if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if (day == 31)
            {
                if (month != 12)
                {
                    Debug.Log("1/" + (month++) + "/" + year);
                }
                else
                {
                    Debug.Log("1/1/" + (year++));
                }
            }
            else Debug.Log((day++) + "/" + (month) + "/" + year);
        }
        else if (0 > month || month > 12)
        {
            valid = false;
        }
        else
        {
            if (day == 30)
            {
                Debug.Log("1/" + (month++) + "/" + year);
            }
            else Debug.Log((day++) + "/" + (month) + "/" + year);
        }
    }

    //ENTREGA 6
    void PreviousDay(int day, int month, int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    feb++;
                }
            }
            else
            {
                feb++;
            }
        }

        if(day == 1)
        {
            if (month == 1)
            {
                Debug.Log("31/12/" + year--);
            }
            else if (month == 5 || month == 7 || month == 10 || month == 12)
            {
                Debug.Log("30/" + month-- + "/" + year);
            }
            else if (month == 3)
            {
                Debug.Log(feb + "/" + month-- + "/" + year);
            }
            else Debug.Log("31/" + month-- + "/" + year);

        }
        else Debug.Log(day-- + "/" + month + "/" + year);

        feb = 28;

    }

    //EJERCICIO 7
    String Chinese(int chin)
    {
        if (chin % 12 == 0)
        {
            return"Chinese year of the monkey";
        }
        else if (chin % 12 == 1)
        {
            return "Chinese year of the rooster";

        }
        else if (chin % 12 == 2)
        {
            return "Chinese year of the dog";
        }
        else if (chin % 12 == 3)
        {
            return "Chinese year of the pig";
        }
        else if (chin % 12 == 4)
        {
            return "Chinese year of the rat";
        }
        else if (chin % 12 == 5)
        {
            return "Chinese year of the ox";
        }
        else if (chin % 12 == 6)
        {
            return "Chinese year of the tiger";
        }
        else if (chin % 12 == 7)
        {
            return "Chinese year of the rabbit";
        }
        else if (chin % 12 == 8)
        {
            return "Chinese year of the dragon";
        }
        else if (chin % 12 == 9)
        {
            return "Chinese year of the snake";
        }
        else if (chin % 12 == 10)
        {
            return "Chinese year of the horse";
        }
        else
        {
            return "Chinese year of the goat";
        }
    }

    //EJERCICIO 8
    float Area(float baset, float height)
    {
        if (baset <= 0 || height <= 0)
        {
            Debug.Log("datos no validos");
            return 0;
        }
        return (baset * height) / 2;
    }

    //EJERCICIO 9
    String Passed(int note)
    {
        if (note < 5)
        {
            if (note < 0)
            {
                return "nota no válida";          }
            return "D";      }
        else if (note < 7)
        {
            return "C";
        }
        else if (note < 9)
        {
            return "B";
        }
        else
        {
            return "A";
        }
    }

    //EJERCICIO 10
    bool Even(int x)
    {
        if(x%2 == 0) return true;
        else return false;
    }

    void Start()
    {
        Lowest(3.9f, 4.6f);
        Vocal("e");
        Valid(19, 9, 2002);
        Bisiestificaneitor(1);
        NextDay(19, 9, 2002); //XD
        PreviousDay(19, 9, 2002);
        Chinese(2890);
        Area(1.6f, 7.2f);
        Passed(3);
        Even(5);
    }

    // Update is called once per frame

}
