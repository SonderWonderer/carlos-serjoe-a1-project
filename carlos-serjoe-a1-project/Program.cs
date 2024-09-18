using System;

internal class TextGame
{
    static void Main(string[] args)
    {
        // Intro/Title sequence
        Console.WriteLine("Welcome to my Text-based Adventure Game!\n \nThe Apartment Complex...");
        Console.WriteLine("Please enter corresponding numbers as inputs. Failure to do so will result in a restart in story... \nType at your own discretion.");

        // Before entering apartment
        Console.WriteLine("\nYou regain consciousness, surrounded by fog. The only thing you can see is an eerie-looking apartment in front of you. It's oddly familiar but can't recall why that is. \nWhat would you like to do?");
        Console.WriteLine("1. Enter the apartment.");
        Console.WriteLine("2. Leave the premises.");

        string decision = Console.ReadLine();

        if (decision == "1")
        {
            EnterApartment();
        }
        else if (decision == "2")
        {
            LeavePremises();
        }
        else
        {
            Console.WriteLine("Invalid input. Your story is now restarting...");
        }
    }

    static void EnterApartment()
    {
        Console.WriteLine("You stumble through a set of creaky revolving doors into the apartment's lobby. You're on the floor, taking in this oddly familiar but new environment.");
        Console.WriteLine("Your eyes explore your surroundings and find an elderly concierge, asleep behind his workstation. \nFive options are presented to you:");
        Console.WriteLine("1. Speak to the concierge.");
        Console.WriteLine("2. Walk past them towards the elevator.");
        Console.WriteLine("3. Search your person.");
        Console.WriteLine("4. Search the lobby.");
        Console.WriteLine("5. Exit the apartment complex.");

        string decision = Console.ReadLine();
        if (decision == "1")
        {
            Console.WriteLine("You wake the concierge, shaking him from their shoulder...");
            // One-sided dialogue
            Console.WriteLine("The concierge opens their eyes, puzzled. They speak to you... \n\"It's you again... That makes it four consecutive nights you've been out this late.\" They say this whilst looking out the windows.");
            Console.WriteLine("\"You have yourself some S-Class friends there... Sending you off without supervision is just asking for trouble.\"");
            Console.WriteLine("The concierge stands up and inspects their bulletin board of keys, grabbing a set they walk towards you... \n\"Come on let's get you home...\"\n");
            Console.WriteLine("You follow them into the elevator... The ride up to your floor took two awkward minutes of silence. \nThe Concierge impatiently waits for the doors to open, repeatedly tapping their foot to the ground.");
            Console.WriteLine("You arrive at your door. It reads 217. The Concierge unlocks the door \n\"Don't expect me to tuck you in too... I don't get paid enough for that... Have yourself a goodnight now.\"");
            Console.WriteLine("Upon entering your apartment, a wave of tiredness hits your body... You find yourself walking to your bed, crashing down onto it. You decide to call it a night.");
            Console.WriteLine("\nYou've made it home safely with the aid of The Concierge!");
            Console.WriteLine("Ending #2: Help from The Concierge");
        }
        else if (decision == "2")
        {
            Console.WriteLine("You enter the elevator without waking the concierge. \nThe apartment has 7 floors.");
            Console.WriteLine("A buzzing headache is delaying your thought-process...");
            Console.WriteLine("What floor would you like to go to?");
            //Here I'll attempt to ask the player for their choice between floors 1-7
            //the interaction will be pointless though as all branches would lead to an interruption by the tenant/neighbour

            string floorChoice = Console.ReadLine();

            //i'd do a bunch of if statements here but i'm going to let the console ignore the users input instead
            //but i wanted to do if input is >=1 + <=7 they'd branch off into the tenant/neighbour interruption
            //and if the player inputted a alphabetical input they'd receive a different message but it seems like alot of unnecessary code
            Console.WriteLine("Before you could choose, a person enters the elevator. They reach in front of you and press the button for the second floor.");
            Console.WriteLine("They seem to be eyeing you from head to toe. You look at their face and they're displaying a look of disappointment...");
            Console.WriteLine("\"It's funny, we both end our nights at the same time...\"\n\"You come home shit-faced, while I can come home tired from work\"");
            Console.WriteLine("\"Well then, follow me... I'll bring you to your apartment.\"");
            Console.WriteLine("\n");
            Console.WriteLine("\nYou follow your neighbour to your apartment. You feel the need to search your person for your keys but it seems your neighbour has a spare set. \nShe opens the door for you");
            Console.WriteLine("As you enter, she shouts out while in the process of opening their own door: \"I expect some compensation for babysitting, it seems I'm always there for you when you need help finding home...\"");
            Console.WriteLine("\"I'll be over later this morning with breakfast... In return, I expect some tea regarding your outting\"");
            Console.WriteLine("Their door shuts before you could bid them farewell");
            //ending sequence
            Console.WriteLine("Upon entry, you feel a rush of relief flow through your body... You feel grateful for having such a caring neighbour... \nIt's odd it almost feels like you've sobered up from your outting");
            Console.WriteLine("You don't feel tired enough for bed. So you decide to kill some time...");
            Console.WriteLine("Self-care mode engaged... You hop into a steaming hot shower, with plans to clean yourself up before your breakfast date...");
            Console.WriteLine("\n");
            Console.WriteLine("Ending #3: Your Friendly Neighbourhood Neighbour!");

        }
        else if (decision == "3")
        {
            Console.WriteLine("You begin to search your pockets for something to guide you...");
            Console.WriteLine("You have no recollection of anything before you arrived at the apartment.");
            Console.WriteLine("You find something in you pant-pocket... It's a smartphone... \nThe lockscreen is you and somebody who seems to be your partner...");
            Console.WriteLine("The phone prompts for a passcode...");

            //passcode interaction - passcode input will be correct regardless of the input
            //passcode input will be displayed
            string Passcode = Console.ReadLine();
            Console.WriteLine("You've entered the passcode: " + Passcode);
            //text messages
            Console.WriteLine("You have gained access to the phone. The idea to check your text messages rings through your head.");
            Console.WriteLine("Your recent texts are from a contact titled NEIGHBOUR");
            Console.WriteLine("\nNEIGHBOUR: Hey, just wanted to check in... You haven't answered your phone all night, must be busy at that party... \nI'm heading home now, I'll come check on you once I arrive.");
            Console.WriteLine("Text me when you can! \nAnd FYI your keys should be in you innner coat pocket... You tend to forget things when inebriated lmao \nOK see ya!");

            //regaining memory
            Console.WriteLine("\n");
            Console.WriteLine("Your memories begin flooding back... It seems you were peer pressured into another party... Where you were eventually peer pressured into drinking a doubious amount of alcohol...");
            Console.WriteLine("And with the night's end, were shipped back home unattended... This seems to be a common trend with your friends... \nYou get the slight idea that this sort of lifestyle is unhealthy...");
            Console.WriteLine("You brush it off and head home... You'll probably end up at another party tomorrow night...");
            Console.WriteLine("\n");
            Console.WriteLine("Ending #4: The Cycle Continues...");
        }
        else if (decision == "4")
        {
            Console.WriteLine("You search the lobby...");
            Console.WriteLine("Aimlessly searching for something that may seem familiar...");
            Console.WriteLine("You find a callbox with a list of names and apartment numbers... You find your name and apartment number on the list...");
            Console.WriteLine("Your name is:");

            //determining the player's name
            string playerName = Console.ReadLine();
            //displaying the playerName 
            Console.WriteLine(playerName + " Apartment #217");

            Console.WriteLine("\n");
            Console.WriteLine("Before any sort of recollection could peer into you head, you are interrupted by The Concierge...");
            Console.WriteLine("\"What seems to be troubling ya friend?\"");
            Console.WriteLine("He answers the question for you, cutting you off before any sound left your mouth.");
            Console.WriteLine("\"Seems like ya had another fun night out...\"\n\"Would ya need help up to your apartment tonight?\"");
            Console.WriteLine("1.Yes \n2.No");

            String conciergeAnswer = Console.ReadLine();
            if (conciergeAnswer == "1")
            {
                Console.WriteLine("\"Well then, let's get ya to your apartment...\"");
                Console.WriteLine("\n");
                Console.WriteLine("You follow The Concierge into the elevator... They escort you to the second level, eventually bringing you to apartment number 217...\n");
                Console.WriteLine("This apartment number matches the one on the callbox list.");

                Console.WriteLine("\n");
                Console.WriteLine("You safely end the night in your apartment, with a slight recollection of your identity...");
                Console.WriteLine("Your name is " + playerName + "You live in apartment 217");
                Console.WriteLine("\n");
                Console.WriteLine("Ending #5: Who Am I?");
            }
            else if (conciergeAnswer == "2")
            {
                Console.WriteLine("\"I wanted to sleep anyway... Well, best of luck getting back home!\"");
                Console.WriteLine("\nYou decide to venture off on your own using the information gathered from the callbox");
                Console.WriteLine("Your name is: " + playerName + " You live in apartment 217");
                Console.WriteLine("You end the night safe in you apartment, with no aid from The Concierge... You have a slight recollection of your identity.");
                //i couldn't decide whether the information should be dislpayed twice... if this code remains it's because of a funny joke with the ending's name...
                Console.WriteLine("Your name is " + playerName + "You live in apartment 217");
                Console.WriteLine("\n");
                Console.WriteLine("Ending #6: Who Am I Again??");
            }
            //the else statement will follow the same path/route as conciergeAnswer #2
            //only change in this branch of code is the ending title... and The Concierge cutting you off in the beginning
            else
            {
                Console.WriteLine("The Concierge cuts you off");
                Console.WriteLine("\"I wanted to sleep anyway... Well, best of luck getting back home!\"");
                Console.WriteLine("\nYou decide to venture off on your own using the information gathered from the callbox");
                Console.WriteLine("Your name is: " + playerName + " You live in apartment 217");
                Console.WriteLine("You end the night safe in you apartment, with no aid from The Concierge... You have a slight recollection of your identity.");
                Console.WriteLine("Your name is " + playerName + "You live in apartment 217");
                Console.WriteLine("\n");
                Console.WriteLine("Ending #7: Who Am I Again Again???");
            }
        }
        else if (decision == "5")
        {
            Console.WriteLine("You exit the lobby into the foggy outdoors...");
            Console.WriteLine("The fogginess seems to envelop the apartment's surroundings...");
            Console.WriteLine("The fog is not only present outside, it's present inside... It's present inside your head");
            Console.WriteLine("You end of the night with no recollection of your past or identity...");
            Console.WriteLine("You are now aimlessly wandering the neighbouring areas of the apartment complex...");
            Console.WriteLine("The locals are writing you off as a drunkie... \nYou actually find yourself in a drunken brawl, where you were separated by local law enforcement and taken into custody...");
            Console.WriteLine("\n");
            Console.WriteLine("Ending #8: Drunken Fist");
        }
        else
        {
            Console.WriteLine("Invalid input... Your story is now restarting...");
        }
    }

    static void LeavePremises()
    {
        // Ending #1 Fill this ending out (CAPS LOCK FOR EMPHASISSSSS!!!!)
        Console.WriteLine("You don't enter the apartment");
        Console.WriteLine("You end the night exploring your foggy surroundings...");
        Console.WriteLine("\n");
        Console.WriteLine("Ending #1: Not entering the apartment...");
        Console.WriteLine("If you didn't want to play the game you could've just told me.");
    }
}
