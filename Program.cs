// Fernando Aguilar
// 10-20-22
// Mini Challenge #3 Asking Questons Endpoint
// We will recreate mini challenge 3 where we ask two questions.
// We will take the answers from the two questions and display the answer in one sentence.
// Adding in data validation to ensure user inputs an appropriate response.
// Peer Reviewed By: Isaiah Ferguson

Console.Clear();

    bool playAgain = true;
    int noNum = 0;
    bool chooseNum;
    string endProj = "YES";

while(playAgain)
{
    Console.WriteLine(" WELCOME TO THE HALLOWEEN PARTY! wHAT IS YOUR NAME? TYPE END TO LEAVE THE PARTY AND GO HOME.. ");
    string myName = Console.ReadLine().ToUpper();
    chooseNum = Int32.TryParse(myName, out noNum);
    while(chooseNum == true)
    {
        Console.WriteLine(" UMM.. THAT NAME IS NOT ON THE GUEST LIST. WHAT'S YOUR REAL NAME? ");
        myName = Console.ReadLine().ToUpper();
        chooseNum = Int32.TryParse(myName, out noNum);
    }
    

    if(myName == "END".ToUpper())
    {
        Console.WriteLine(" HEY! WHERE ARE YOU GOING? YOU'RE ALREADY ALL DRESSED UP! ");
        break;
    }
    else
    {
    Console.WriteLine(" NICE TO MEET YOU " + myName + ", WHAT DID YOU DRESS UP AS FOR HALLOWEEN? ");
    string myCostume = Console.ReadLine().ToUpper();
    chooseNum = Int32.TryParse(myCostume, out noNum);
     while(chooseNum == true)
    {
        Console.WriteLine(" WHAT KIND OF COSTUME IS THAT?\nSTOP MESSING WITH ME, WHAT ARE YOU SUPPOSED TO BE?");
        myCostume = Console.ReadLine().ToUpper();
        chooseNum = Int32.TryParse(myCostume, out noNum);
        
    }
    
    {
        Console.WriteLine(" SWEET COSTUME!\n ");
    }
    Console.WriteLine(" THAT'S SO COOL! " + myCostume + " IS MY FAVORITE COSTUME AT THE PARTY SO FAR!\nCOME GET DOWN ON THE DANCE FLOOR! ");

    }

    Console.WriteLine(" WOULD YOU LIKE TO ATTEND THE PARTY AS A DIFFERENT PERSON OR IN A DIFFERENT COSTUME? YES OR NO? ");
    endProj = Console.ReadLine().ToUpper();
    if(endProj == "YES".ToUpper())
    {
        playAgain = true;
    }
    else
    {
    Console.WriteLine(" THANKS FOR COMING TO THE PARTY! SEE YOU AGAIN NEXT YEAR! ");
    break;
    }
}