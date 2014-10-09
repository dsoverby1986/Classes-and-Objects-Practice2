using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Object_Practice_2
{
    class HappyBirthday                         //WHEN THE TERM "PROPERLY" COMES UP IN THE COMMENTS BELOW, I UNDERSTAND THAT
    {                                           //ALL OF THE CODE HERE ACTUALLY IS WORKING PPROPERLY AND THAT  I AM JUST AN IDIOT AND
        private int numberOfPresents;           //CAN'T FIGURE OUT ON MY OWN WHAT I  HAVE DONE WRONG WHILE I WAS WRITING THIS CODE.
        private string birthdayMessage;
        private bool partyYayNay;
        private int partyComers;

        public HappyBirthday()
        {
            numberOfPresents = 0;
            partyYayNay = false; // Why is this not working properly?...I thought that this is just a default value that can be changed when the property that this variable belongs to is called up in the button code and assigned a new value....it doesn't change though.....it just remains whatever value is assigned in the class constructor....WTF?
            partyComers = 0; //Why is this not working properly?...it seems to be set up the same as the numberOfPresents variable.
        }

        private string getMessage(string givenName)//
        {
            string theMessage;

            theMessage = "Happy Birthday " + givenName + "\n";
            theMessage += "Number of presents = " + numberOfPresents.ToString() + "\n";
            if(partyYayNay == true)
            {
                theMessage += "Hope you enjoy the party!" + "\n";
            }
            else
            {
                theMessage += "No Party - Sorry!" + "\n";
            }
            theMessage += "Number of people attending your party = " + partyComers.ToString();
            return theMessage;
        }

        public string MyProperty
        {
            get { return birthdayMessage; }
            set { birthdayMessage = getMessage(value); } //Is this "(value)" where the birthday boy/girl name from the button code is being passed over to by saying 'birthdayMessage.MyProperty = "Shane";' and then constructed using the "givenName" variable from the getMessage method?
        }

        public int PresentCount 
        { 
            set { numberOfPresents = value; } 
        }
        
        public bool PartyStatus
        {
            set { partyYayNay = value; }
        }

        public int PartyAttendees //Why is this not working properly?...it seems to be set up the same as the PresentCount property.
        {
            set { partyComers = value; }
        }
    }
}
