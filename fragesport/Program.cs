﻿string pText = "";
int points = 0;
int questions = 0;

Console.WriteLine("Welcome to code quiz");
Console.WriteLine("Get 3 or more answers correct to win");
Console.WriteLine("Type 1, 2 or 3 to answer");
Console.WriteLine("Write enter to begin");


while(pText != "enter"){    
pText = Console.ReadLine();
    if (pText != "enter"){
        Console.WriteLine("I said type \"enter\"");
    }
}

Console.Clear();
//First question
    Console.WriteLine("First question");
    Console.WriteLine("What can an int variabel store?");
    Console.WriteLine("1:Text\n2:Numbers\n3:Pictures");
while(questions != 1){
    pText = Console.ReadLine();
    if(pText == "2"){
        points++;
        questions++;
    }
    if(pText == "1" || pText == "3"){
        questions++;
    }
    if(pText != "1" && pText != "2" && pText != "3"){
        Console.WriteLine("Type 1, 2 or 3 to answer");
    }
}

//Second question
Console.Clear();
Console.WriteLine("Second question");
Console.WriteLine("What can an string variabel store?");
Console.WriteLine("1:Numbers\n2:True or False\n3:Text");
while(questions != 2){
    pText = Console.ReadLine();
    if(pText == "3"){
        points++;
        questions++;
    }
    if(pText == "1" || pText == "2"){
        questions++;
    }
    if(pText != "1" && pText != "2" && pText != "3"){
        Console.WriteLine("Type 1, 2 or 3 to answer");
    }
}



Console.ReadLine();