//// Homework


//Tasks:
//1.Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 

//2.Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram

//3.Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram
//(Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.

//4.Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram. Simvol +,-,* və ya / olmalıdır,
//əks halda simvolu yenidən daxil edilməsi istənilməlidir.(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)

//5.Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram

//6.Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram

//7.Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram. Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir

//8.Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.Əgər verilmiş dəyər
//"programming"dirsə console-da 400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.




//1.Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 

//string sentence = "How are you";
//string word = " ";

//for (int i = 0; i < sentence.Length; i++)
//{
//    char letter = sentence[i];

//    if (letter != ' ')
//    {
//        word += letter;
//    }
//}
//Console.WriteLine( "Answer:" + word);


//2.Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram

//string word = "How i cans speak English";
//char letter = 's';
//int count = 0;

//for (int i = 1; i < word.Length; i++)
//{
//    if (word[i]==letter)
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//3.Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram
//(Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.

//string input = "   salam necesen?   ";
//string result = "";
//int index = 0;

//while (index < input.Length)
//{
   
//    if (input[index] != ' ')
//    {
//        break;
//    }
//    index++;
//}


//for (int i = index; i < input.Length; i++)
//{
//    result += input[i];
//}

//Console.WriteLine("Answer: '" + result + "'");


//4.Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram. Simvol +,-,* və ya / olmalıdır,
//əks halda simvolu yenidən daxil edilməsi istənilməlidir.(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)

/// Answers
//////double num1 = 12;
//////double num2 = 6;
//////var Operation = 0;

//while (true)
//{
//    Console.Write("Birinci ededi daxil edin: ");
//    if (!double.TryParse(Console.ReadLine(), out double num1))
//    {
//        Console.WriteLine("duzgun eded daxil edin");
//        continue;
//    }

//    Console.Write("Ikinci ededi daxil edin: ");
//    if (!double.TryParse(Console.ReadLine(), out double num2))
//    {
//        Console.WriteLine("duzgun eded daxil edin");
//        continue;
//    }


//    Console.Write("Emeliyyatlardan birini sec (+, -, *, /) : ");
//    string operation = Console.ReadLine();

//    double result;
//    switch (operation)
//    {
//        case "+":
//            result = num1 + num2;
//            break;
//        case "-":
//            result = num1 - num2;
//            break;
//        case "*":
//            result = num1 * num2;
//            break;
//        case "/":
//            if (num2 == 0)
//            {
//                Console.WriteLine("Sifira bolmək olmaz.");
//                continue;
//            }
//            result = num1 / num2;
//            break;
//        default:
//            Console.WriteLine(" Tezelden simvol daxil edin +, -, * və ya / daxil edin.");
//            continue;
//    }

//    Console.WriteLine($"Answer: {result}");
//    break;
//}

//5.Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram

//string word = "How i cansAA speak English";

//bool letter = false;

//for (int i = 1; i < word.Length; i++)
//{
//    if (word[i] == 'A')
//    {
//        letter = true;
//        break;
//    }
//}
//if (letter)
//{
//    Console.WriteLine("Cumlenin icinde A var");
//}
//else
//{
//    Console.WriteLine("Cumlenin icinde A yoxdu");
//}


//6.Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram


//string sentence = "How i cansAA speak English";

//int count = sentence.Count(c => char.ToUpper(c) == 'A');

//Console.WriteLine("Answer:" + count );



//string statemnt = "What AAAAAAre doing";
//int count = 0;

//foreach (var letter in statemnt)
//{
//    if(letter == 'A')
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);


//7.Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram. Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir

//int number = 14;

//if(number%2==0)
//{
//    Console.WriteLine(number * number);
//}
//else
//{
//    Console.WriteLine("mubet ve ya cut eded daxil edin");

//}



//8.Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.Əgər verilmiş dəyər
//"programming"dirsə console-da 400 saat, "design"dırsa 250 saat, "system"dirsə 200 saat, heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.

//string number1 = "programing";
//string number2 = "design";
//string number3 = "system";


//Console.WriteLine(" Choose program");
//string number = Console.ReadLine();

//if (number ==number1 )
//{
//    Console.WriteLine("400 saat");
//}
//else if(number == number2)
//{
//    Console.WriteLine("250 saat");
//}
//else if(number == number3)
//{
//    Console.WriteLine("200 saat");
//}
//else
//{
//    Console.WriteLine("tehsil novu yoxdur");
//}












