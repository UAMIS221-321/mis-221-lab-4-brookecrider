// start main
int userChoice = GetUserChoice();
while(userChoice!=3) {
    RouteMenu(userChoice);
    userChoice=GetUserChoice();
    
}



// end main

static int GetUserChoice() {
    DisplayMenu();
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu() {
    Console.Clear();
    System.Console.WriteLine("Enter 1 for mint condition\nEnter 2 for modern day condition\nEnter 3 to exit");
}

static bool IsValidChoice(string userChoice) {
    if(userChoice=="1" || userChoice=="2" || userChoice=="3") {
        return true;
    }
    return false;

}




static void GetFull() {
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    for(int i=0; i < number; i++) {
        for(int j=0; j < i; j++) {
            Console.Write("o");
        }
        System.Console.WriteLine();
    } 
    PauseAction();

}

static void GetPartial(){
    Random rnd = new Random();
    int number = rnd.Next(3,10);
    for(int i=0; i < number; i++) {
        for(int j=0; j < i; j++) {
            int newNumber= rnd.Next(0,2);
            if(newNumber==0) {
                Console.Write("o");
            }
            else if (newNumber==1) {
                Console.Write(" ");
            }    
        }
        System.Console.WriteLine();

    }
    PauseAction();
}


static void SayInvalid() {
    System.Console.WriteLine("Invalid!");
    PauseAction();
}

static void RouteMenu(int userChoice) {
    if(userChoice==1) {
        GetFull();
    }
    else if(userChoice==2) {
        GetPartial();
    }
    else if(userChoice==3) {
        SayInvalid();
    }
    else if(userChoice!=1 && userChoice!=2 && userChoice!=3) {
        SayInvalid();
    }

    
    

}
static void PauseAction() {
    System.Console.WriteLine("Press any key to continue.");
    Console.ReadKey();
}

