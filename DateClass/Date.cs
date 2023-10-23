using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateClass;
class Date
{
    private int day, month, year;

    public Date(int day, int month, int year)
    {
        setDay(day);
        setMonth(month);
        setYear(year);
    }
    public int getDay()
    {
        return day;
    }
    public void setDay(int value)
    {
        if (value < 0 || value > 31)
        {
            Console.WriteLine("Zadej platné číslo 1-31");
        }
        else
        {
            day = value;
        }
    }

    public int getMonth()
    {
        return month;
    }

    public void setMonth(int value)
    {
        if (value < 0 || value > 12)
        {
            Console.WriteLine("Zadej platné číslo 1-12");
        }
        else
        {
            month = value;
        }
    }

    public int getYear()
    {
        return year;
    }

    public void setYear(int value)
    {
        if (value < 1990 || value > 9999)
        {
            Console.WriteLine("Zadej platné číslo 1900-9999");
        }
        else
        {
            year = value;
        }
    }

    public override string ToString()
    {
        return $"{getDay()}/{getMonth()}/{getYear()}";
    }
}