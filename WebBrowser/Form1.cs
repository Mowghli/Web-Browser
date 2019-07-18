using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// This form is for the Browser, for Assignment 1 - task 5, and Assignment 2
namespace WebBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGo_Click(object sender, EventArgs e)    // Clicking this button will have the browser navigate to the webpage
        {                                                       // whose address is specified in textbox "txtUrl"
            Browser.Navigate(txtUrl.Text);
        }

        private void Button1_Click(object sender, EventArgs e)  // This button will perform addition in calculator
        {
            float a = float.Parse(textBox1.Text);               // "a" variable will get the value in left textbox "textBox1"
            float b = float.Parse(textBox2.Text);               // "b" variable will get the value in right textbox "textBox2"
            a = a + b;                                          // addition
            label4.Text = a.ToString();                         // label "label4" will get the value of "a" variable
        }

        private void Button2_Click(object sender, EventArgs e)  // This button will perform subtraction in calculator
        {
            float a = float.Parse(textBox1.Text);           // "a" variable will get the value in left textbox "textBox1"
            float b = float.Parse(textBox2.Text);           // "b" variable will get the value in right textbox "textBox2"
            a = a - b;                                      // subtraction
            label4.Text = a.ToString();                     // label "label4" will get the value of "a" variable
        }

        private void Button3_Click(object sender, EventArgs e)      // This button will perform multiplication in calculator
        {
            float a = float.Parse(textBox1.Text);           // "a" variable will get the value in left textbox "textBox1"
            float b = float.Parse(textBox2.Text);           // "b" variable will get the value in right textbox "textBox2"
            a = a * b;                                      // multiplication
            label4.Text = a.ToString();                     // label "label4" will get the value of "a" variable
        }

        private void Button4_Click(object sender, EventArgs e)       // This button will perform division in calculator
        {
            float a = float.Parse(textBox1.Text);           // dividend "a" variable will get the value in left textbox "textBox1"
            float b = float.Parse(textBox2.Text);           // divisor "b" variable will get the value in right textbox "textBox2"
            a = a / b;                                      // division
            label4.Text = a.ToString();                     // label "label4" will get the value of "a" variable
        }

        private void Encrypt_Click(object sender, EventArgs e)      // The encryptor and decryptor form (uses service at ASU reporsitory: 
        {                                                           // http://neptune.fulton.ad.asu.edu/WSRepository/Services/EncryptionWcf/Service.svc)
            EncryptServicer.ServiceClient Encrypter = new EncryptServicer.ServiceClient();  // initializing a client object of EncryptServcier
            try{ EncryptRes.Text = Encrypter.Encrypt(textBox3.Text); }              // try catch statement in which "EncryptRes" label is given the encrypted value of text in "textBox3", using Encrypt() function
            catch (Exception ec) { EncryptRes.Text = ec.Message.ToString(); }       // catch statement in which error message is stored into label "EncryptRes"
            try { DecryptRes.Text = Encrypter.Decrypt(EncryptRes.Text); }           // try catch statement in which "DecryptRes" label is given the decrypted value of text in "EncryptRes", using Decrypt() function
            catch (Exception ec) { DecryptRes.Text = ec.Message.ToString(); }       // catch statement in which error message is stored into label "DecryptRes"
        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void EncryptRes_Click(object sender, EventArgs e)
        {

        }

        

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        
    }
}
