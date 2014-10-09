using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classes_and_Object_Practice_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //HappyBirthday birthdayMessage;
            //birthdayMessage = new HappyBirthday();

            //MessageBox.Show(birthdayMessage.getMessage("Shane"));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HappyBirthday birthdayMessage = new HappyBirthday();
            string returnedMessage;

            birthdayMessage.PresentCount = 10;
            birthdayMessage.MyProperty = ("Shane");
            birthdayMessage.PartyStatus = true; //Why is this not working properly?...Isn't this new value supposed to be passed over to the "PartyStatus" property variable in the HappyBirthday class?....Same goes for the code beneath.....WTF?
            birthdayMessage.PartyAttendees = 27; //Why is this not working properly?...It seems to be set up the same as the value assignment for birthdayMessage.PresentCount
            returnedMessage = birthdayMessage.MyProperty;

            MessageBox.Show(returnedMessage);
        }
    }
}
