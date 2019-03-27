/* Nathan Peereboom
 * March 27, 2019
 * Translator: text shortforms to English
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U2NathanPeereboomTXTMSG
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new System.IO.StreamWriter("translate.txt");
                sw.WriteLine(txtInput.Text);
                sw.Flush();
                sw.Close();

                lblOutput.Content = "";
                System.IO.StreamReader sr = new System.IO.StreamReader("translate.txt");
                int end = 0;
                while (!sr.EndOfStream && end == 0)
                {
                    string CurrentLine = sr.ReadLine();
                    CurrentLine = CurrentLine.ToUpper();
                    switch (CurrentLine)
                    {
                        case "CU":
                            lblOutput.Content += "See you" + Environment.NewLine;
                            break;
                        case ":-)":
                            lblOutput.Content += "I'm happy" + Environment.NewLine;
                            break;
                        case ":-(":
                            lblOutput.Content += "I'm unhappy" + Environment.NewLine;
                            break;
                        case ";-)":
                            lblOutput.Content += "Wink" + Environment.NewLine;
                            break;
                        case ":-P":
                            lblOutput.Content += "Sitck out my tongue" + Environment.NewLine;
                            break;
                        case "(~.~)":
                            lblOutput.Content += "Sleepy" + Environment.NewLine;
                            break;
                        case "TA":
                            lblOutput.Content += "Totally Awesome" + Environment.NewLine;
                            break;
                        case "CCC":
                            lblOutput.Content += "Canadian Computing Competition" + Environment.NewLine;
                            break;
                        case "CUZ":
                            lblOutput.Content += "Because" + Environment.NewLine;
                            break;
                        case "TY":
                            lblOutput.Content += "Thank you" + Environment.NewLine;
                            break;
                        case "YW":
                            lblOutput.Content += "Your welcome" + Environment.NewLine;
                            break;
                        case "TTYL":
                            lblOutput.Content += "Talk to you later" + Environment.NewLine;
                            end = 1;
                            break;
                        default:
                            lblOutput.Content += CurrentLine + Environment.NewLine;
                            break;
                    }
                    
                }
                sr.Close();
                end = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
