using System;
//git push sheck

class Program
{
    public void HelloWorld(string lang)
    {
        Console.WriteLine("Hello {0}!", lang);
    }
    public static void Main()
    {
    	//********************************
    	//変数の扱い方
    	//********************************
    	int x = 2; //整数を入れた変数
        string y = "test"; //文字列を入れた変数
        string fruits = "apple"; //変数名は任意につけられる
        Console.WriteLine(y);
        Console.WriteLine("私の好きな果物は" + fruits + "です");
        Console.WriteLine( x + "個は食べたい");

        //********************************
    	//配列とListは違うよ
    	//********************************
        int[] numbers = new int[3] { 4, 5, 6 };
        string[] numbers = new string[3] { "aaa", "BBBBB", "cc" };
        List<int> num = new List<int> {1,3,4,7};

        //********************************
        //if
        //********************************
        var num = 1;
        if (num == 1){
            Console.WriteLine("数値は1です");
        }
        else if(num > 1){
            Console.WriteLine("数値は1よりも大きいです");
        }
        else {
            Console.WriteLine("数値は1よりも小さいです");
        }

        //********************************
        //for, while
        //break, continue 共にあり
        //********************************
        for(int r = 1; r <= 10; r++){
        	i = i + r;
        }
        while(i > 0){
        	i = i - 1;
        	System.Console.WriteLine("iの値：" + i);
        }

        //********************************
        //foreachは配列を順番に
        //********************************
        List<int> num = new List<int> {1,3,4,7};
        int i = 1;
        foreach (int r in num){
            i = i + r;
            System.Console.WriteLine("rの値：" + r);
        }

        //********************************
        //関数の呼び出し
        //********************************
        Program obj = new Program();
        obj.HelloWorld("C#");
        obj.HelloWorld("C++");
    }
}