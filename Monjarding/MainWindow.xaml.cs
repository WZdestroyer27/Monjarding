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
using System.Windows.Threading;

namespace Monjarding
{
    public partial class MainWindow : Window
    {
        private const string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private char[] rotor1Letters;
        private char[] rotor2Letters;
        private char[] rotor3Letters;
        private int rotor1Index = 0;
        private int rotor2Index = 0;
        private int rotor3Index = 0;

        public MainWindow()
        {
            InitializeComponent();
            InitializeRotors();
            KeyDown += MainWindow_KeyDown;
        }

        private void InitializeRotors()
        {
            rotor1Letters = Alphabet.ToCharArray().OrderBy(c => Guid.NewGuid()).ToArray(); // Random permutation
            rotor2Letters = Alphabet.ToCharArray().OrderBy(c => Guid.NewGuid()).ToArray(); // Random permutation
            rotor3Letters = Alphabet.ToCharArray().OrderBy(c => Guid.NewGuid()).ToArray(); // Random permutation

            UpdateRotorLabels();
        }

        private void RotateRotors()
        {
            rotor3Index = (rotor3Index + 1) % Alphabet.Length;
            if (rotor3Index == 0)
            {
                rotor2Index = (rotor2Index + 1) % Alphabet.Length;
                if (rotor2Index == 0)
                {
                    rotor1Index = (rotor1Index + 1) % Alphabet.Length;
                }
            }
        }

        private void UpdateRotorLabels()
        {
            rotor1_1.Content = rotor1Letters[rotor1Index];
            rotor1_2.Content = rotor1Letters[(rotor1Index + 1) % Alphabet.Length];
            rotor1_3.Content = rotor1Letters[(rotor1Index + 2) % Alphabet.Length];
            rotor1_4.Content = rotor1Letters[(rotor1Index + 3) % Alphabet.Length];
            rotor1_5.Content = rotor1Letters[(rotor1Index + 4) % Alphabet.Length];
            rotor1_6.Content = rotor1Letters[(rotor1Index + 5) % Alphabet.Length];
            rotor1_7.Content = rotor1Letters[(rotor1Index + 6) % Alphabet.Length];
            rotor1_8.Content = rotor1Letters[(rotor1Index + 7) % Alphabet.Length];
            rotor1_9.Content = rotor1Letters[(rotor1Index + 8) % Alphabet.Length];
            rotor1_10.Content = rotor1Letters[(rotor1Index + 9) % Alphabet.Length];
            rotor1_11.Content = rotor1Letters[(rotor1Index + 10) % Alphabet.Length];
            rotor1_12.Content = rotor1Letters[(rotor1Index + 11) % Alphabet.Length];
            rotor1_13.Content = rotor1Letters[(rotor1Index + 12) % Alphabet.Length];
            rotor1_14.Content = rotor1Letters[(rotor1Index + 13) % Alphabet.Length];
            rotor1_15.Content = rotor1Letters[(rotor1Index + 14) % Alphabet.Length];
            rotor1_16.Content = rotor1Letters[(rotor1Index + 15) % Alphabet.Length];
            rotor1_17.Content = rotor1Letters[(rotor1Index + 16) % Alphabet.Length];
            rotor1_18.Content = rotor1Letters[(rotor1Index + 17) % Alphabet.Length];
            rotor1_19.Content = rotor1Letters[(rotor1Index + 18) % Alphabet.Length];
            rotor1_20.Content = rotor1Letters[(rotor1Index + 19) % Alphabet.Length];
            rotor1_21.Content = rotor1Letters[(rotor1Index + 20) % Alphabet.Length];
            rotor1_22.Content = rotor1Letters[(rotor1Index + 21) % Alphabet.Length];
            rotor1_23.Content = rotor1Letters[(rotor1Index + 22) % Alphabet.Length];
            rotor1_24.Content = rotor1Letters[(rotor1Index + 23) % Alphabet.Length];
            rotor1_25.Content = rotor1Letters[(rotor1Index + 24) % Alphabet.Length];
            rotor1_26.Content = rotor1Letters[(rotor1Index + 25) % Alphabet.Length];
            // Update rotor1_3 to rotor1_26 similarly

            rotor2_1.Content = rotor2Letters[rotor2Index];
            rotor2_2.Content = rotor2Letters[(rotor2Index + 1) % Alphabet.Length];
            rotor2_3.Content = rotor2Letters[(rotor2Index + 2) % Alphabet.Length];
            rotor2_4.Content = rotor2Letters[(rotor2Index + 3) % Alphabet.Length];
            rotor2_5.Content = rotor2Letters[(rotor2Index + 4) % Alphabet.Length];
            rotor2_6.Content = rotor2Letters[(rotor2Index + 5) % Alphabet.Length];
            rotor2_7.Content = rotor2Letters[(rotor2Index + 6) % Alphabet.Length];
            rotor2_8.Content = rotor2Letters[(rotor2Index + 7) % Alphabet.Length];
            rotor2_9.Content = rotor2Letters[(rotor2Index + 8) % Alphabet.Length];
            rotor2_10.Content = rotor2Letters[(rotor2Index + 9) % Alphabet.Length];
            rotor2_11.Content = rotor2Letters[(rotor2Index + 10) % Alphabet.Length];
            rotor2_12.Content = rotor2Letters[(rotor2Index + 11) % Alphabet.Length];
            rotor2_13.Content = rotor2Letters[(rotor2Index + 12) % Alphabet.Length];
            rotor2_14.Content = rotor2Letters[(rotor2Index + 13) % Alphabet.Length];
            rotor2_15.Content = rotor2Letters[(rotor2Index + 14) % Alphabet.Length];
            rotor2_16.Content = rotor2Letters[(rotor2Index + 15) % Alphabet.Length];
            rotor2_17.Content = rotor2Letters[(rotor2Index + 16) % Alphabet.Length];
            rotor2_18.Content = rotor2Letters[(rotor2Index + 17) % Alphabet.Length];
            rotor2_19.Content = rotor2Letters[(rotor2Index + 18) % Alphabet.Length];
            rotor2_20.Content = rotor2Letters[(rotor2Index + 19) % Alphabet.Length];
            rotor2_21.Content = rotor2Letters[(rotor2Index + 20) % Alphabet.Length];
            rotor2_22.Content = rotor2Letters[(rotor2Index + 21) % Alphabet.Length];
            rotor2_23.Content = rotor2Letters[(rotor2Index + 22) % Alphabet.Length];
            rotor2_24.Content = rotor2Letters[(rotor2Index + 23) % Alphabet.Length];
            rotor2_25.Content = rotor2Letters[(rotor2Index + 24) % Alphabet.Length];
            rotor2_26.Content = rotor2Letters[(rotor2Index + 25) % Alphabet.Length];
            // Update rotor2_3 to rotor2_26 similarly

            rotor3_1.Content = rotor3Letters[rotor3Index];
            rotor3_2.Content = rotor3Letters[(rotor3Index + 1) % Alphabet.Length];
            rotor3_3.Content = rotor3Letters[(rotor3Index + 2) % Alphabet.Length];
            rotor3_4.Content = rotor3Letters[(rotor3Index + 3) % Alphabet.Length];
            rotor3_5.Content = rotor3Letters[(rotor3Index + 4) % Alphabet.Length];
            rotor3_6.Content = rotor3Letters[(rotor3Index + 5) % Alphabet.Length];
            rotor3_7.Content = rotor3Letters[(rotor3Index + 6) % Alphabet.Length];
            rotor3_8.Content = rotor3Letters[(rotor3Index + 7) % Alphabet.Length];
            rotor3_9.Content = rotor3Letters[(rotor3Index + 8) % Alphabet.Length];
            rotor3_10.Content = rotor3Letters[(rotor3Index + 9) % Alphabet.Length];
            rotor3_11.Content = rotor3Letters[(rotor3Index + 10) % Alphabet.Length];
            rotor3_12.Content = rotor3Letters[(rotor3Index + 11) % Alphabet.Length];
            rotor3_13.Content = rotor3Letters[(rotor3Index + 12) % Alphabet.Length];
            rotor3_14.Content = rotor3Letters[(rotor3Index + 13) % Alphabet.Length];
            rotor3_15.Content = rotor3Letters[(rotor3Index + 14) % Alphabet.Length];
            rotor3_16.Content = rotor3Letters[(rotor3Index + 15) % Alphabet.Length];
            rotor3_17.Content = rotor3Letters[(rotor3Index + 16) % Alphabet.Length];
            rotor3_18.Content = rotor3Letters[(rotor3Index + 17) % Alphabet.Length];
            rotor3_19.Content = rotor3Letters[(rotor3Index + 18) % Alphabet.Length];
            rotor3_20.Content = rotor3Letters[(rotor3Index + 19) % Alphabet.Length];
            rotor3_21.Content = rotor3Letters[(rotor3Index + 20) % Alphabet.Length];
            rotor3_22.Content = rotor3Letters[(rotor3Index + 21) % Alphabet.Length];
            rotor3_23.Content = rotor3Letters[(rotor3Index + 22) % Alphabet.Length];
            rotor3_24.Content = rotor3Letters[(rotor3Index + 23) % Alphabet.Length];
            rotor3_25.Content = rotor3Letters[(rotor3Index + 24) % Alphabet.Length];
            rotor3_26.Content = rotor3Letters[(rotor3Index + 25) % Alphabet.Length];

            // Update rotor3_3 to rotor3_26 similarly
        }

        private void UpdateInputLabel(char inputChar)
        {
            inputLabel.Content = inputChar.ToString();
        }

        private void MainWindow_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key >= System.Windows.Input.Key.A && e.Key <= System.Windows.Input.Key.Z)
            {
                char inputChar = e.Key.ToString()[0];
                RotateRotors();
                UpdateRotorLabels();
                UpdateInputLabel(inputChar);
            }
        }
    }
}


