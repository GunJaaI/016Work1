using System;
public class Program {
    public static string InputName() {
        Console.Write("Please input Name : ");

        return Console.ReadLine();
    }

    public static string InputNumber() {
        Console.Write("Please input Number : ");

        return Console.ReadLine();
    }

    public static string InputOwnerName() {
        Console.Write("Please input Owner Name : ");

        return Console.ReadLine();
    }

    public static string InputRV() {
        Console.Write("Please input Registered Value : ");

        return Console.ReadLine();
    }
    
    public static string InputMoney() {
        Console.Write("Please input money : ");

        return Console.ReadLine();
    }

    public static int ConvertStringToIntNumber(string value) {
        if (int.TryParse(value, out int number)) {
            return number;
         }  

       throw new Exception("Please input numbers."); 
    }

    public static long ConvertStringToIntRV(string value) {
        if (long.TryParse(value, out long number)) {
            return number;
         }  

       throw new Exception("Please input Registered Value."); 
    }

    public static float ConvertStringToIntMoney(string value) {
        if (float.TryParse(value, out float number)) {
            return number;
         }  

       throw new Exception("Please input money."); 
    }

    public static void Main(string[] args){

        string name = InputName();
        string number = InputNumber();
        string ownername = InputOwnerName();
        string rv = InputRV();
        int number1 = ConvertStringToIntNumber(number);
        long rv1 = ConvertStringToIntRV(rv);

        string money = InputMoney();
        float money1 = ConvertStringToIntMoney(money);
        float b1000 = Coin.B1000(money1);
        float b500 = Coin.B500(money1);
        float b100 = Coin.B100(money1);
        float b50 = Coin.B50(money1);
        float b20 = Coin.B20(money1);
        float b10 = Coin.B10(money1);
        float b5 = Coin.B5(money1);
        float b2 = Coin.B2(money1);
        float b1 = Coin.B1(money1);
        float b_50 = Coin.B_50(money1);
        float b_25 = Coin.B_25(money1);

        PrintShopInformation(name,number,ownername,rv);
        PrintMoney(b1000,b500,b100,b50,b20,b10,b5,b2,b1,b_50,b_25);

    }

    public static void PrintShopInformation(string name,string number,string ownername,string rv) {
        Console.WriteLine("_-*-_-*-_-*- Shop Information -*-_-*-_-*-_");
        Console.WriteLine("Name : {0}",name);
        Console.WriteLine("Number : {0}",number);
        Console.WriteLine("Owner Name : {0}",ownername);
        Console.WriteLine("Registered Value : {0}",rv);
        Console.WriteLine("_-*-_-*-_-*-_-*-_-*-_-*-_-*-_-*-_-*-_-*-_-*-_");

    }

    public static void PrintMoney(float b1000,float b500,float b100,float b50,float b20,float b10,float b5,float b2,float b1,float b_50,float b_25) {
        Console.WriteLine("_-*-_-*-_-*-_-*- Money -*-_-*-_-*-_-*-_");
        Console.WriteLine("1000 : {0}",Math.Floor(b1000));
        Console.WriteLine("500 : {0}",Math.Floor(b500));
        Console.WriteLine("100 : {0}",Math.Floor(b100));
        Console.WriteLine("50 : {0}",Math.Floor(b50));
        Console.WriteLine("20 : {0}",Math.Floor(b20));
        Console.WriteLine("10 : {0}",Math.Floor(b10));
        Console.WriteLine("5 : {0}",Math.Floor(b5));
        Console.WriteLine("2 : {0}",Math.Floor(b2));
        Console.WriteLine("1 : {0}",Math.Floor(b1));
        Console.WriteLine("0.50 : {0}",Math.Floor(b_50));
        Console.WriteLine("0.25 : {0}",Math.Floor(b_25));
        Console.WriteLine("_-*-_-*-_-*-_-*-_-*-_-*-_-*-_-*-_-*-_-*-_");
    }

}