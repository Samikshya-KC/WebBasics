// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//byte age=12;
//Console.WriteLine(age);
//Allow user to enter their full name and print the name in uppercase
//Console.Write("Your Fullname:");
//string? fullname= Console.ReadLine();
//string nameInUpper = fullname.ToUpper();
//Console.WriteLine(nameInUpper);
// string firstFriend="Maria";
// string secondFriend="Scott";
// //$ is the string interpolation
// Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
// var y =23425530;
// if(y%2==0){
//     Console.WriteLine($"{y} is even");
// }
// else{
//     Console.WriteLine($"{y} is odd");

// }
// //Ternary Operator
// var output = y % 2 == 0 ?$"{y} is even":$"{y} is odd";
// Console.WriteLine(output);
// var r = 121;
// var divider =11;
// //Find if r is perfectly divisible by 13
// //Output:11 can divide 23456, 34 times.But it's not perfectly divisible by it.
// var quotient=r/divider;
// var outputs = r % divider == 0 ?$"{divider} can divide {r}, {quotient} times and perfectly divisible by it":$"{divider} can divide {r}, {quotient} times.But it's not perfectly divisible by it";
// Console.WriteLine(outputs);
// //Looping
// for(int i=1;i<=1000;i++){
//    // Console.Write(i+" ");
//    if(i%5==0 && i%7 ==0){
//      Console.Write($"{i} ");
//    }
// }
// //Print all numbers between 1-1000 which are divisible by 5 and 7.


// var r1=new Room();
// r1.paintColor="Red";
// r1.floor=3;
// r1.lengthFt=15.5;
// r1.widthFt=12.4;
// r1.heightFt=8;
// r1.DisplayInfo();

// var r2=new Room("Pink",4,13.5,12.9,8);
// r2.DisplayInfo();
// var r3=new HotelRoom();

var l1 = new Lake();
l1.name="RARA";
l1.location="Mugu district";
l1.depth= 167;
l1.altitude=2990;
l1.typeOfLake="Freshwater";
l1.LakeInfo();

var l2 = new Lake("Phewa","Pokhara",23,742,"Freshwater");
l2.LakeInfo();

var l3=new GlacierLake();
l3.LakeInfo();





