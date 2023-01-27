using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        class Words
        {
            public Words(char l1, char l2 , char l3 , char l4 , char l5)
            {
                L1 = l1;
                L2 = l2;
                L3 = l3;
                L4 = l4;
                L5 = l5;
            }
            public char L1 { get; set; }
            public char L2 { get; set; }
            public char L3 { get; set; }
            public char L4 { get; set; }
            public char L5 { get; set; }

        }

        List<Words> words1 = new List<Words>();
        List<Words> wordschecked = new List<Words>();
        List<char> blacklist = new List<char>();
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();

           string filePath    = @"C:\\Users\\Rokas\\source\\repos\\WindowsFormsApp6\\WindowsFormsApp6\\valid-wordle-words.txt"; ;
            string[] lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                

                char[] charArray = line.ToCharArray();

                char l11 = charArray[0];
                char l21 = charArray[1];
                char l31 = charArray[2];
                char l41 = charArray[3];
                char l51 = charArray[4];

                words1.Add(new Words(l11, l21, l31, l41, l51));
             
            }
            foreach (var word in words1)
            {
                string words123 = word.L1.ToString() + word.L2.ToString() + word.L3.ToString() + word.L4.ToString() + word.L5.ToString();
                listBoxSolutions.Items.Add(words123);
            }
            label6.Text = words1.Count.ToString();
        }
        int abc123 = 0;
        int abc1234 = 0;
        int abc1235 = 0;
        int abc1236 = 0;
        int abc1237 = 0;
        private void buttonL1C_Click(object sender, EventArgs e)
        {
            
            abc123++;
            if(abc123 == 1)
            {
                buttonL1C.BackColor = Color.Gold;
            }
            else if (abc123 == 2)
            {
                buttonL1C.BackColor = Color.Green;
            }
            else if(abc123 == 3)
            {
               abc123 = abc123 - 3;
                buttonL1C.BackColor = Color.Gray;
            }

        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
        

        }

        private void buttonL2C_Click(object sender, EventArgs e)
        {
          
            abc1234++;
            if (abc1234 == 1)
            {
                buttonL2C.BackColor = Color.Yellow;
            }
            else if (abc1234 == 2)
            {
                buttonL2C.BackColor = Color.Green;
            }
            else if (abc1234 == 3)
            {
                abc1234 = abc1234 - 3;
                buttonL2C.BackColor = Color.Gray;
            }
        }

        private void buttonL3C_Click(object sender, EventArgs e)
        {
            abc1235++;
            if (abc1235 == 1)
            {
                buttonL3C.BackColor = Color.Yellow;
            }
            else if (abc1235 == 2)
            {
                buttonL3C.BackColor = Color.Green;
            }
            else if (abc1235 == 3)
            {
                abc1235 = abc1235 - 3;
                buttonL3C.BackColor = Color.Gray;
            }
        }

        private void buttonL4C_Click(object sender, EventArgs e)
        {
            abc1236++;
            if (abc1236 == 1)
            {
                buttonL4C.BackColor = Color.Yellow;
            }
            else if (abc1236 == 2)
            {
                buttonL4C.BackColor = Color.Green;
            }
            else if (abc1236 == 3)
            {
                abc1236 = abc1236 - 3;
                buttonL4C.BackColor = Color.Gray;
            }
        }

        private void buttonL5C_Click(object sender, EventArgs e)
        {
            abc1237++;
            if (abc1237 == 1)
            {
                buttonL5C.BackColor = Color.Yellow;
            }
            else if (abc1237 == 2)
            {
                buttonL5C.BackColor = Color.Green;
            }
            else if (abc1237 == 3)
            {
                abc1237 = abc1237 - 3;
                buttonL5C.BackColor = Color.Gray;
            }
        }


       

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            listBoxSolutions.Items.Clear();
            string pastword  = textBoxLetter1.Text.ToString()+ textBoxLetter2.Text.ToString() + textBoxLetter3.Text.ToString() + textBoxLetter4.Text.ToString() + textBoxLetter5.Text.ToString() ;
            textBoxPastTryes.Text += pastword + "\r\n"; // Pakeisti dydi texto

            int temp = 0;
            if( abc123 > 0)
            {
                temp++;
            }
            if(abc1234 > 0 )
            {
                temp++;
            }
            if (abc1235 > 0)
            {
                temp++;
            }
            if (abc1236 > 0)
            {
                temp++;
            }
            if (abc1237 > 0)
            {
                temp++;
            }

            if(abc123 == 0)
            {
                blacklist.Add(char.Parse(textBoxLetter1.Text));
            }
            if (abc1234 == 0)
            {
                blacklist.Add(char.Parse(textBoxLetter2.Text));
            }
            if (abc1235 == 0)
            {
                blacklist.Add(char.Parse(textBoxLetter3.Text));
            }
            if (abc1236 == 0)
            {
                blacklist.Add(char.Parse(textBoxLetter4.Text));
            }
            if (abc1237 == 0)
            {
                blacklist.Add(char.Parse(textBoxLetter5.Text));
            }



            if ( temp == 1)// 1 
                {

               if (abc123 == 2)
                {
                   
                        char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    

                }
                else if (abc123 == 1)
                {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);

                }
                else if (abc1234 == 2)
                {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                }
                else if (abc1234 == 1)
                {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character);
            }
                else if (abc1235 == 2)
                {
                 
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
            }
                else if (abc1235 == 1)
                {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character);
            }

               else if (abc1236 == 2)
                {
                    
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
            }
                else if (abc1236 == 1)
                {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character);
            }

                else if (abc1237 == 2)
                {
                   
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
            }
                else if (abc1237 == 1)
                {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character);
            }
            }
            
            // abc123  - 1
            // abc1234 - 2
            // abc1235 - 3
            // abc1236 - 4
            // abc1237 - 5

                //Zaili only

           if(temp == 2) {
                if(abc123 == 2 && abc1234 ==2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                }
                else if(abc123 == 2 && abc1235 ==2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                }
                else if(abc123 == 2 && abc1236 ==2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                }
                else if(abc123 == 2 && abc1237 ==2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                //2
                else if(abc1234 == 2 && abc1235 == 2)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character5);
                }
                else if (abc1234 == 2 && abc1236 == 2)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character5);
                }
                else if (abc1234 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                //3
                else if (abc1235 == 2 && abc1236 == 2)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character5);
                }
                else if (abc1235 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
            //4
                else if (abc1236 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                //1 zailias kitas geltonas
                else if(abc123 == 2 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character5);
                }
                else if(abc123 == 2 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character5);
                }
                else if (abc123 == 2 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character5);
                }
                else if (abc123 == 2 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
            // 2 zailas kitas geltonas 
            else if (abc1234 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1234 == 2 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1234 == 2 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1234 == 2 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character5);
            }
            // 3 zalias kitas geltonas 
            else if (abc1235 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1235 == 2 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1235 == 2 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1235 == 2 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character5);
            }
            // 4 zailas kitas geltonas 

            else if (abc1236 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1236 == 2 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1236 == 2 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1236 == 2 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character5);
            }
            // 5 zailas kitas geltonas 

            else if (abc1237 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1237 == 2 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1237 == 2 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1237 == 2 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character5);
            }
                // abu geltoni 
            else if(abc123 == 1 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc123 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc123 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc123 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1234 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1234 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1234 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1235 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character5);
            }
            else if (abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character5 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character5);
            }
}

            if (temp == 3)
                    {

            if(abc123 == 2 && abc1234 == 2 && abc1235 ==2 )
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith3OneGreen(character3);
            }
            else if (abc123 == 2 && abc1234 == 2 && abc1236 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character3);
            }
            else if (abc123 == 2 && abc1234 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character3);
            }
            else if (abc123 == 2 && abc1235 == 2 && abc1236 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character3);
            }
            else if (abc123 == 2 && abc1235 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character3);
            }
            else if (abc123 == 2 && abc1236 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character3);
            }
            else if (abc1234 == 2 && abc1235 == 2 && abc1236 == 2)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character3);
            }
            else if (abc1234 == 2 && abc1235 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character3);
            }
            else if (abc1234 == 2 && abc1236 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character3);
            }
            else if (abc1235 == 2 && abc1236 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character3);
            }
            // zaili done 
            else if (abc123 == 1 && abc1234 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 1 && abc1234 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 1 && abc1234 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 1 && abc1235 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 1 && abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 1 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 1 && abc1235 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 1 && abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 1 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 1 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            //geltoni done
            else if (abc123 == 2 && abc1234 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1234 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1234 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1235 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc123 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc123 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc123 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1235 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc123 == 1 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc123 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc123 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc1234 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc1234 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1236 == 2 && abc123 == 1 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1236 == 2 && abc123 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1236 == 2 && abc123 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1236 == 2 && abc1234 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1236 == 2 && abc1234 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1236 == 2 && abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1237 == 2 && abc123 == 1 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1237 == 2 && abc123 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1237 == 2 && abc123 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1237 == 2 && abc1234 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1237 == 2 && abc1234 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1237 == 2 && abc1236 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1234 == 2 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1234 == 2 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1234 == 2 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1235 == 2 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1235 == 2 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1235 == 2 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1236 == 2 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1236 == 2 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1236 == 2 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1237 == 2 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1237 == 2 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc123 == 2 && abc1237 == 2 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1235 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1235 == 2 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1235 == 2 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1236 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1236 == 2 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1236 == 2 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1237 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1237 == 2 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1234 == 2 && abc1237 == 2 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc1236 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc1236 == 2 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc1236 == 2 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc1237 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc1237 == 2 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1235 == 2 && abc1237 == 2 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1236 == 2 && abc1237 == 2 && abc123 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1236 == 2 && abc1237 == 2 && abc1234 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
            }
            else if (abc1236 == 2 && abc1237 == 2 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
            }
            }

            if(temp == 4)
            {

            if(abc123 ==2 && abc1234 ==2 && abc1235 == 2 && abc1236 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character4);
            }
            else if (abc123 == 2 && abc1234 == 2 && abc1235 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character4);
            }
            else if (abc123 == 2 && abc1235 == 2 && abc1236 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character4);
            }
            else if (abc1234 == 2 && abc1235 == 2 && abc1236 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character4);
            }
            // geltoni 
            if (abc123 == 2 && abc1234 == 2 && abc1235 == 2 && abc1236 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc123 == 2 && abc1234 == 2 && abc1235 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc123 == 2 && abc1235 == 2 && abc1236 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1234 == 2 && abc1235 == 2 && abc1236 == 2 && abc1237 == 2)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc123 == 2 && abc1234 == 1 && abc1235 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc123 == 2 && abc1234 == 1 && abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc123 == 2 && abc1234 == 1 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc123 == 2 && abc1235 == 1 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter1.Text);
                checkerWith1OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1234 == 2 && abc123 == 1 && abc1235 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1234 == 2 && abc123 == 1 && abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1234 == 2 && abc123 == 1 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1234 == 2 && abc1235 == 1 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter2.Text);
                checkerWith2OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1235 == 2 && abc123 == 1 && abc1234 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1235 == 2 && abc123 == 1 && abc1234 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1235 == 2 && abc123 == 1 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1235 == 2 && abc1234 == 1 && abc1236 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter3.Text);
                checkerWith3OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1236 == 2 && abc123 == 1 && abc1234 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1236 == 2 && abc123 == 1 && abc1234 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1236 == 2 && abc123 == 1 && abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1236 == 2 && abc1234 == 1 && abc1235 == 1 && abc1237 == 1)
            {
                char character = char.Parse(textBoxLetter4.Text);
                checkerWith4OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter5.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1237 == 2 && abc123 == 1 && abc1234 == 1 && abc1235 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1237 == 2 && abc123 == 1 && abc1234 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1237 == 2 && abc123 == 1 && abc1235 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter1.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character4);
            }
            else if (abc1237 == 2 && abc1234 == 1 && abc1235 == 1 && abc1236 == 1)
            {
                char character = char.Parse(textBoxLetter5.Text);
                checkerWith5OneGreen(character);
                resetwords();
                char character2 = char.Parse(textBoxLetter2.Text);
                checkerWith1eyellow(character2);
                resetwords();
                char character3 = char.Parse(textBoxLetter3.Text);
                checkerWith1eyellow(character3);
                resetwords();
                char character4 = char.Parse(textBoxLetter4.Text);
                checkerWith1eyellow(character4);
            }
                else if (abc123 == 2 && abc1234 == 2 && abc1235 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1234 == 2 && abc1235 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1234 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1235 == 2 && abc1234 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1235 == 2 && abc1234 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1235 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1236 == 2 && abc1235 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1236 == 2 && abc1235 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1236 == 2 && abc1234 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1237 == 2 && abc1235 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1237 == 2 && abc1235 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1237 == 2 && abc1234 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1235 == 2 && abc123 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1235 == 2 && abc123 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1235 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1236 == 2 && abc123 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1236 == 2 && abc123 == 1 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1236 == 2 && abc1237 == 1 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1237 == 2 && abc123 == 1 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1237 == 2 && abc123 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1237 == 2 && abc1235 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1235 == 2 && abc1237 == 2 && abc123 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1235 == 2 && abc1237 == 2 && abc123 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1235 == 2 && abc1237 == 2 && abc1234 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1235 == 2 && abc1236 == 2 && abc123 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1235 == 2 && abc1236 == 2 && abc123 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1235 == 2 && abc1236 == 2 && abc1234 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1236 == 2 && abc1237 == 2 && abc123 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1236 == 2 && abc1237 == 2 && abc123 == 1 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1236 == 2 && abc1237 == 2 && abc1234 == 1 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1234 == 2 && abc1235 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1234 == 2 && abc1235 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1234 == 2 && abc1235 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1234 == 2 && abc1236 == 1 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1234 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1234 == 2 && abc1237 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1234 == 2 && abc1237 == 1 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1235 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1235 == 2 && abc1236 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1235 == 2 && abc1237 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1235 == 2 && abc1237 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1236 == 2 && abc1237 == 1 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1236 == 2 && abc1237 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc123 == 2 && abc1236 == 2 && abc1237 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1235 == 2 && abc1236 == 1 && abc123 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1235 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1235 == 2 && abc1237 == 1 && abc1236 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1235 == 2 && abc1237 == 1 && abc123 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1236 == 2 && abc1237 == 1 && abc123 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1234 == 2 && abc1236 == 2 && abc1237 == 1 && abc1235 == 1)
                {
                    char character = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1235 == 2 && abc1236 == 2 && abc1237 == 1 && abc123 == 1)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character4);
                }
                else if (abc1235 == 2 && abc1236 == 2 && abc1237 == 1 && abc1234 == 1)
                {
                    char character = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character4);
                }



            }

            if(temp == 5)
            {
                if(abc123 == 2 && abc1234 == 2 && abc1235 == 2 && abc1236 ==2 && abc1237 ==2 )
                {
                        char character = char.Parse(textBoxLetter1.Text);
                        checkerWith1OneGreen(character);
                        resetwords();
                        char character2 = char.Parse(textBoxLetter2.Text);
                        checkerWith2OneGreen(character2);
                        resetwords();
                        char character3 = char.Parse(textBoxLetter3.Text);
                        checkerWith3OneGreen(character3);
                        resetwords();
                        char character4 = char.Parse(textBoxLetter4.Text);
                        checkerWith4OneGreen(character4);
                        resetwords();
                        char character5 = char.Parse(textBoxLetter5.Text);
                        checkerWith5OneGreen(character5); 
                }
                if (abc123 == 1 && abc1234 == 1 && abc1235 == 1 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if(abc123 == 2 && abc1234 == 1 && abc1235 == 1 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 1 && abc1234 == 2 && abc1235 == 1 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 1 && abc1234 == 1 && abc1235 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 1 && abc1234 == 1 && abc1235 == 1 && abc1236 == 2 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 1 && abc1234 == 1 && abc1235 == 1 && abc1236 == 1 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                   checkerWith5OneGreen(character5);
                }
                if (abc123 == 2 && abc1234 == 2 && abc1235 == 1 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 2 && abc1234 == 1 && abc1235 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 2 && abc1234 == 1 && abc1235 == 1 && abc1236 == 2 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 2 && abc1234 == 1 && abc1235 == 1 && abc1236 == 1 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 1 && abc1234 == 2 && abc1235 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 1 && abc1234 == 2 && abc1235 == 1 && abc1236 == 2 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 1 && abc1234 == 2 && abc1235 == 1 && abc1236 == 1 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 1 && abc1234 == 1 && abc1235 == 2 && abc1236 == 1 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 1 && abc1234 == 1 && abc1235 == 2 && abc1236 == 2 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 1 && abc1234 == 1 && abc1235 == 1 && abc1236 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 2 && abc1234 == 2 && abc1235 == 2 && abc1236 == 1 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 2 && abc1234 == 2 && abc1235 == 1 && abc1236 == 2 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 2 && abc1234 == 2 && abc1235 == 1 && abc1236 == 1 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 2 && abc1234 == 1 && abc1235 == 2 && abc1236 == 2 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 2 && abc1234 == 1 && abc1235 == 2 && abc1236 == 1 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 2 && abc1234 == 1 && abc1235 == 1 && abc1236 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 1 && abc1234 == 2 && abc1235 == 2 && abc1236 == 1 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 1 && abc1234 == 2 && abc1235 == 2 && abc1236 == 2 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 1 && abc1234 == 2 && abc1235 == 1 && abc1236 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 1 && abc1234 == 1 && abc1235 == 2 && abc1236 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 2 && abc1234 == 2 && abc1235 == 2 && abc1236 == 2 && abc1237 == 1)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith1eyellow(character5);
                }
                if (abc123 == 2 && abc1234 == 2 && abc1235 == 2 && abc1236 == 1 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith1eyellow(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 2 && abc1234 == 2 && abc1235 == 1 && abc1236 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith1eyellow(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 2 && abc1234 == 1 && abc1235 == 2 && abc1236 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                    checkerWith1OneGreen(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith1eyellow(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }
                if (abc123 == 1 && abc1234 == 2 && abc1235 == 2 && abc1236 == 2 && abc1237 == 2)
                {
                    char character = char.Parse(textBoxLetter1.Text);
                   checkerWith1eyellow(character);
                    resetwords();
                    char character2 = char.Parse(textBoxLetter2.Text);
                    checkerWith2OneGreen(character2);
                    resetwords();
                    char character3 = char.Parse(textBoxLetter3.Text);
                    checkerWith3OneGreen(character3);
                    resetwords();
                    char character4 = char.Parse(textBoxLetter4.Text);
                    checkerWith4OneGreen(character4);
                    resetwords();
                    char character5 = char.Parse(textBoxLetter5.Text);
                    checkerWith5OneGreen(character5);
                }




            }



            for(int i =0; i<wordschecked.Count; i++)
            {
                for(int j =0; j<blacklist.Count; j++)
                {
                    if (blacklist[j] == wordschecked[i].L1 || blacklist[j] == wordschecked[i].L2 || blacklist[j] == wordschecked[i].L3 || blacklist[j] == wordschecked[i].L4 || blacklist[j] == wordschecked[i].L5)
                    {
                   wordschecked.Remove(wordschecked[i]);
                        
                    }
                }
            }





            label6.Text = wordschecked.Count.ToString();
            foreach (var word in wordschecked)
            {
                string words123 = word.L1.ToString() + word.L2.ToString() + word.L3.ToString() + word.L4.ToString() + word.L5.ToString();
                listBoxSolutions.Items.Add(words123);
            }

            resetwords();

        }
        private void resetwords()
        {
            words1.Clear();
            label6.Text = wordschecked.Count.ToString();
            for (int i = 0; i < wordschecked.Count; i++)
            {
                words1.Add(wordschecked[i]);
            }
            wordschecked.Clear();   
        }
        private void checkerWith1OneGreen(char greenLetter)
        {
            for (int i = 0; i < words1.Count; i++)
            {
               if(words1[i].L1 == greenLetter)
                {
                    wordschecked.Add(words1[i]);
                    
                }

            }
        }
        private void checkerWith2OneGreen(char greenLetter)
        {
            for (int i = 0; i < words1.Count; i++)
            {
                if (words1[i].L2 == greenLetter)
                {
                    wordschecked.Add(words1[i]);
                  
                }

            }
        }
        private void checkerWith3OneGreen(char greenLetter)
        {
            for (int i = 0; i < words1.Count; i++)
            {
                if (words1[i].L3 == greenLetter)
                {
                    wordschecked.Add(words1[i]);
                }

            }
        }
        private void checkerWith4OneGreen(char greenLetter)
        {
            for (int i = 0; i < words1.Count; i++)
            {
                if (words1[i].L4 == greenLetter)
                {
                    wordschecked.Add(words1[i]);
                    
                }

            }
        }
        private void checkerWith5OneGreen(char greenLetter)
        {
            for (int i = 0; i < words1.Count; i++)
            {
                if (words1[i].L5 == greenLetter)
                {
                    wordschecked.Add(words1[i]);
                  
                }

            }
        }
        private void checkerWith1eyellow(char yellowletter)
        {
            for (int i = 0; i < words1.Count; i++)
            {
                if (yellowletter == words1[i].L1 || yellowletter == words1[i].L2 || yellowletter == words1[i].L3 || yellowletter == words1[i].L4 || yellowletter == words1[i].L5)
                {
                    wordschecked.Add(words1[i]);

                }

            }
        }

        private void buttonResset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
