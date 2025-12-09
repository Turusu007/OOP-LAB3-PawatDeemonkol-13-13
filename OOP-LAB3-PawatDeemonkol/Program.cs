using System;

public class GradeChecker
{
    public static void Main(int p) //ประกาศเมธอด Main ที่รับพารามิเตอร์เป็นคะแนน p
    {
        switch (p) //ใช้ switch-case เพื่อตรวจสอบช่วงคะแนน
        {
            case >= 80 and <= 100: //กรณีคะแนนอยู่ในช่วง 80-100
                Console.WriteLine("A");     //แสดงผลเกรด A
                break;
            case >= 70 and < 80:
                Console.WriteLine("B");
                break;
            case >= 60 and < 70:
                Console.WriteLine("C");
                break;
            case >= 50 and < 60:
                Console.WriteLine("D");
                break;
            case >= 0 and < 50:
                Console.WriteLine("F");
                break;
            default:
                Console.WriteLine("????");
                break;
        }


    }

}

public class Program //ประกาศคลาส Program
{
    public static void Main()
    {
        Console.WriteLine("ใส่คะแนน : "); //แสดงข้อความใส่คะแนน
        string? input = Console.ReadLine(); //รับค่าจากผู้ใช้

        if (!int.TryParse(input, out int p)) //ตรวจสอบว่าค่าที่รับมาเป็นตัวเลขหรือไม่
        {
            Console.WriteLine("กรุณากรอกตัวเลขเท่านั้น"); //หากไม่ใช่ตัวเลขแสดงข้อความกรอกตัวเลขเท่านั้น
            return;
        }

        if (p < 0 || p > 100)
        {
            Console.WriteLine("คะแนนไม่ถูกต้อง"); //หากคะแนนไม่อยู่ในช่วง 0-100 แสดงข้อความคะแนนไม่ถูกต้อง
        }
        else
        {
            GradeChecker.Main(p); //เรียกใช้เมธอด Main ของคลาส GradeChecker เพื่อเช็คเกรด
        }





    }
}
