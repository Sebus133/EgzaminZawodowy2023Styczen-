using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace pracownik_haslo_groupbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();

          
            List<string> comboBoxItems = new List<string>(){
        "Kierownik",
        "Starszy programista",
        "Młodszy programista",
        "Tester"
             };
            for (int i = 0; i < comboBoxItems.Count; i++)
            {
                comboBox1.Items.Add(comboBoxItems[i]);
            }

           
        }

         string generatedPassword="";
         string savedPassword = "";
        private void generatePassword(object sender, RoutedEventArgs e)
        {
            string allCharakters = "a b c d e f g h i j k l m n o p q r s t u w x y z A B C D E F G H I  J K L M N O P Q R S T U V W X Y Z";
            string numbers = "0 1 2 3 4 5 6 7 8 9";
            string specials = "! @ # $ % ^ & * ( ) _ + - =";
            
            string[] allCharaktersToUse = allCharakters.Split(' ');
            string[] numbersToUse = numbers.Split(' ');
            string[] specialsToUse = specials.Split(' ');

            string charakterCounterContent = charakterCounter.Text;
            int charakterCounterInt = Int32.Parse(charakterCounterContent);

         

            Random randomNumberGenerator = new Random();
            

            while (charakterCounterInt > 0) { 
            

            if (numbersCheck.IsChecked == true)
            {
                generatedPassword = generatedPassword + numbersToUse[randomNumberGenerator.Next(numbersToUse.Length)];
                    charakterCounterInt--;
                }

            if (specialCheck.IsChecked == true)
            {
                    generatedPassword = generatedPassword + specialsToUse[randomNumberGenerator.Next(specialsToUse.Length)];
                    charakterCounterInt--;
                }
            if (bigAndSmallCheck.IsChecked == true)
            {
                    for (int i = 0; i < charakterCounterInt; i++)
                    {
                        generatedPassword = generatedPassword + allCharaktersToUse[randomNumberGenerator.Next(allCharaktersToUse.Length)];
                    }
                }


                charakterCounterInt = 0;


           }


            MessageBox.Show(generatedPassword);
            savedPassword = generatedPassword;
            generatedPassword = "";
        }

        private void confirm(object sender, RoutedEventArgs e)
        {
            string selectedItemInComboBox = (string)comboBox1.SelectedValue;
            string nameInput = name.Text;
            string surnameInput = surname.Text;

           
            if (generatedPassword == "")
            {
                MessageBox.Show("Dane pracownika: " + nameInput + " " + surnameInput + " " + selectedItemInComboBox);
            }
            else
                MessageBox.Show("Dane pracownika: " + nameInput + " " + surnameInput + " " + selectedItemInComboBox + " Hasło: " + savedPassword);
        }
        
        
    }

}




