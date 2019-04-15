using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class form : Form
    {

        char[] Array= new char[9];

        char currentTurn = 'X';
        public bool turn = false;
        public bool gameStatus = true;
        public int checkBoxes = 0;

        //PLayer vs Player Scores
        public int p1Score = 0; //player 1 Score
        public int p2Score = 0; //player 2 Score

        // Player vs Computer Scores
        public int pScore =  0; //Player Score
        public int cScore =  0; //Computer Score

        //if strategy true, then player vs player
        // if strategy false. then player vs computer
        public bool strategy = false;

        public form()
        {
            InitializeComponent();
        }

        public void updateTurn() {

            if (currentTurn == 'X')
            {
                currentTurn = 'O';
            }
            else {
                currentTurn = 'X';
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {


            Array[0] = currentTurn;
            button1.Text = Convert.ToString(currentTurn);
            checkBoxes = checkBoxes + 1;
            if (strategy == true)
            {
               
                checkState();
            }
            else if (strategy == false) {
                turn = true;
                checkState2();
               
            }
            //Skip 'O'
            if (strategy == true)
            {
                
                updateTurn();
                label7.Text = currentTurn.ToString();
            }
            button1.Enabled = false;
            
         
        }

        public void button2_Click(object sender, EventArgs e)
        {

        


            Array[1] = currentTurn;
            button2.Text = Convert.ToString(currentTurn);
            checkBoxes = checkBoxes + 1;
            if (strategy == true)
            {
                checkState();
            }
            else if (strategy == false)
            {
                turn = true;
                checkState2();
               
            }
            //Skip 'O'
            if (strategy == true)
            {
                updateTurn();
                label7.Text = currentTurn.ToString();
            }
            button2.Enabled = false;
            
        }


        public void button3_Click(object sender, EventArgs e)
        {

            Array[2] = currentTurn;
            button3.Text = Convert.ToString(currentTurn);
            checkBoxes = checkBoxes + 1;
            if (strategy == true)
            {
                checkState();
            }
            else if (strategy == false)
            {
                turn = true;
                checkState2();
                
            }
            //Skip 'O'
            if (strategy == true)
            {
                updateTurn();
                label7.Text = currentTurn.ToString();
            }
            button3.Enabled = false;
            
        }



        public void button4_Click(object sender, EventArgs e)
        {

           


            Array[3] = currentTurn;
            button4.Text = Convert.ToString(currentTurn);
            checkBoxes = checkBoxes + 1;
            if (strategy == true)
            {
                checkState();
            }
            else if (strategy == false)
            {
                turn = true;
                checkState2();
               
            }
            //Skip 'O'
            if (strategy == true)
            {
                updateTurn();
                label7.Text = currentTurn.ToString();
            }
            button4.Enabled = false;
            
        }

        public void button5_Click(object sender, EventArgs e)
        {

           


            Array[4] = currentTurn;
            button5.Text = Convert.ToString(currentTurn);
            checkBoxes = checkBoxes + 1;
            if (strategy == true)
            {
                checkState();
            }
            else if (strategy == false)
            {
                turn = true;
                checkState2();
                
            }
            //Skip 'O'
            if (strategy == true)
            {
                updateTurn();
                label7.Text = currentTurn.ToString();
            }
            button5.Enabled = false;
            
        }

        public void button6_Click(object sender, EventArgs e)
        {
          


            Array[5] = currentTurn;
            button6.Text = Convert.ToString(currentTurn);
            checkBoxes = checkBoxes + 1;
            if (strategy == true)
            {
                checkState();
            }
            else if (strategy == false)
            {
                turn = true;
                checkState2();
              
            }
            //Skip 'O'
            if (strategy == true)
            {
                updateTurn();
                label7.Text = currentTurn.ToString();
            }
            button6.Enabled = false;
            
        }

        public void button7_Click(object sender, EventArgs e)
        {

          


            Array[6] = currentTurn;
            button7.Text = Convert.ToString(currentTurn);
            checkBoxes = checkBoxes + 1;
            if (strategy == true)
            {
                checkState();
            }
            else if (strategy == false)
            {
                turn = true;
                checkState2();
                
            }
            //Skip 'O'
            if (strategy == true)
            {
                updateTurn();
                label7.Text = currentTurn.ToString();
            }
            button7.Enabled = false;
            
        }

        public void button8_Click(object sender, EventArgs e)
        {
            

            Array[7] = currentTurn;
            button8.Text = Convert.ToString(currentTurn);
            checkBoxes = checkBoxes + 1;
            if (strategy == true)
            {
                checkState();
            }
            else if (strategy == false)
            {
                turn = true;
                checkState2();
                
            }
            //Skip 'O'
            if (strategy == true)
            {
                updateTurn();
                label7.Text = currentTurn.ToString();
            }
            button8.Enabled = false;
            
        }

        public void button9_Click(object sender, EventArgs e)
        {
           

            Array[8] = currentTurn;
            button9.Text = Convert.ToString(currentTurn);
            checkBoxes = checkBoxes + 1;
            if (strategy == true)
            {
                checkState();
            }
            else if (strategy == false)
            {
                turn = true;
                checkState2();
                
            }

            //Skip 'O'
            if (strategy == true)
            {
                updateTurn();
                label7.Text = currentTurn.ToString();
            }
            button9.Enabled = false;
            
        }

        public void button10_Click(object sender, EventArgs e)
        {

            //  PLayer vs Player strategy\

            strategy = true;
               for (int i = 0; i <= 8; i++) {
               Array[i] = '\0';   //clearing array
            }
            
            clearButtons();
            enableButtons();
            //clear all buttons 
            currentTurn = 'X';    // set currentTurn to X 
            label1.Text = "Player vs Player Selected";
            label4.Text = "Player 1 Score:";
            label3.Text = "Player 2 Score:";

            //Score initialization
            label6.Text = Convert.ToString(p1Score);
            label5.Text = Convert.ToString(p2Score);

            label7.Text = "X";

        }

        public void checkState() {

            //Row 1 check
            if (Array[0] == Array[1] && Array[1] == Array[2]) {
                if (Array[0] != '\0')
                {
                    gameOver(Array[0]);
                }
            }

            //Row 2 check
            if (Array[3] == Array[4] && Array[4] == Array[5]) {
                if (Array[3] != '\0')
                {
                    gameOver(Array[3]);
                }
            }

            //Row 3 check
            if (Array[6] == Array[7] && Array[7] == Array[8])
            {
                if (Array[6] != '\0')
                {
                    gameOver(Array[6]);
                }
            }

            //Column 1 check
            if (Array[0] == Array[3] && Array[3] == Array[6])
            {
                if (Array[0] != '\0')
                {
                    gameOver(Array[0]);
                }
            }

            //Column 2 check
            if (Array[1] == Array[4] && Array[4] == Array[7])
            {
                if (Array[1] != '\0')
                {
                    gameOver(Array[1]);
                }
            }

            //Column 3 check
            if (Array[2] == Array[5] && Array[5] == Array[8])
            {
                if (Array[2] != '\0')
                {
                    gameOver(Array[2]);
                }
            }

            //Cross 1 check
            if (Array[0] == Array[4] && Array[4] == Array[8])
            {
                if (Array[0] != '\0')
                {
                    gameOver(Array[0]);
                }
            }

            //Cross 2 check
            if (Array[2] == Array[4] && Array[4] == Array[6])
            {
                if (Array[2] != '\0')
                {
                    gameOver(Array[2]);
                }
            }

            if (checkBoxes == 9)
            {

                label1.Text = "It's a draw";
                disableButtons();
                currentTurn = 'X';
            }


        }


        public void checkState2() {

            //Winning condition check
            

            checkState();

            //Logic check strategy 2, if 2 X's or 2 O's
            checkWinning();

            if(turn == true) {
                //   label1.Text = "Entered Random";

               int temp =  randomFunction();

                if (checkBoxes != 9)
                {
                    if (Array[temp] == '\0')
                    {

                        Array[temp] = 'O';
                        if (gameStatus == true)
                        {
                            updateButton(temp + 1);
                        }
                        checkBoxes = checkBoxes + 1;
                        voidButton(temp + 1);
                        turn = false;
                        checkState();

                    }

                }
            }


        }

        public int randomFunction() {

            int i = 0;

            for (i = 0; i <= 8; i++) {

                if (Array[i] == '\0')
                {
                    //label1.Text = i.ToString();
                    return i;
                    

                }
            }

            return i;
            
        }

        public void checkWinning() {

            //For Row 1
            if (Array[0] == Array[1] || Array[1] == Array[2] || Array[0] == Array[2])
            {
                if (Array[0] == Array[1])
                {
                    calculations(0, 2);
                }
                if (Array[1] == Array[2])
                {
                    calculations(1, 0);
                }
                if (Array[0] == Array[2])
                {
                    calculations(0, 1);
                }

            }

            //For Row 2
            if (Array[3] == Array[4] || Array[4] == Array[5] || Array[3] == Array[5])
            {
                if (Array[3] == Array[4])
                {
                    calculations(3, 5);
                }
                if (Array[4] == Array[5])
                {
                    calculations(4, 3);
                }
                if (Array[3] == Array[5])
                {
                    calculations(3, 4);
                }

            }

            //For Row 3
            if (Array[6] == Array[7] || Array[7] == Array[8] || Array[6] == Array[8])
            {
                if (Array[6] == Array[7])
                {
                    calculations(6, 8);
                }
                if (Array[7] == Array[8])
                {
                    calculations(7, 6);
                }
                if (Array[6] == Array[8])
                {
                    calculations(6, 7);
                }

            }

            //Column 1

            if (Array[0] == Array[3] || Array[3] == Array[6] || Array[0] == Array[6])
            {
                if (Array[0] == Array[3])
                {
                    calculations(0, 6);
                }
                if (Array[3] == Array[6])
                {
                    calculations(3, 0);
                }
                if (Array[0] == Array[6])
                {
                    calculations(0, 3);
                }

            }

            //Column 2

            if (Array[1] == Array[4] || Array[4] == Array[7] || Array[1] == Array[7])
            {
                if (Array[1] == Array[4])
                {
                    calculations(1, 7);
                }
                if (Array[4] == Array[7])
                {
                    calculations(4, 1);
                }
                if (Array[1] == Array[7])
                {
                    calculations(1, 4);
                }

            }

            //Column 3

            if (Array[2] == Array[5] || Array[5] == Array[8] || Array[2] == Array[8])
            {
                if (Array[2] == Array[5])
                {
                    calculations(2, 8);
                }
                if (Array[5] == Array[8])
                {
                    calculations(5, 2);
                }
                if (Array[2] == Array[8])
                {
                    calculations(2, 5);
                }

            }

            //Diagonal 1L

            if (Array[0] == Array[4] || Array[4] == Array[8] || Array[0] == Array[8])
            {
                if (Array[0] == Array[4])
                {
                    calculations(0, 8);
                }
                if (Array[4] == Array[8])
                {
                    calculations(4, 0);
                }
                if (Array[0] == Array[8])
                {
                    calculations(0, 4);
                }

            }

            //Diagonal 2L

            if (Array[6] == Array[4] || Array[4] == Array[2] || Array[6] == Array[2])
            {
                if (Array[6] == Array[4])
                {
                    calculations(6, 2);
                }
                if (Array[4] == Array[2])
                {
                    calculations(4, 6);
                }
                if (Array[6] == Array[2])
                {
                    calculations(6, 4);
                }

            }

        }

        //Calculations

        public void calculations( int i,  int j) {
            if (Array[i] == 'X')
            {
                if (Array[j] == '\0')
                {
                    //If computer turn
                    if (turn == true)
                    {
                        Array[j] = 'O';
                        if (gameStatus == true)
                        {

                            updateButton(j + 1);
                        }
                        checkBoxes = checkBoxes + 1;
                        voidButton(j+1);
                        checkState();
                        turn = false;
                    }

                }
            }
            if (Array[i] == 'O')
            {
                if (Array[j] == '\0')
                {
                    if (turn == true)
                    {
                        Array[j] = 'O';
                        if (gameStatus == true)
                        {
                            updateButton(j + 1);
                        }
                        checkBoxes = checkBoxes + 1;
                        voidButton(j + 1);
                        checkState();
                        turn = false;
                    }

                }
            }

        }

        public void updateButton(int m) {

            if (m == 1) { button1.Text = "O"; }
            if (m == 2) { button2.Text = "O"; }
            if (m == 3) { button3.Text = "O"; }
            if (m == 4) { button4.Text = "O"; }
            if (m == 5) { button5.Text = "O"; }
            if (m == 6) { button6.Text = "O"; }
            if (m == 7) { button7.Text = "O"; }
            if (m == 8) { button8.Text = "O"; }
            if (m == 9) { button9.Text = "O"; }

        }

        public void voidButton(int d) {

            if (d == 1) { button1.Enabled = false; }
            if (d == 2) { button2.Enabled = false; }
            if (d == 3) { button3.Enabled = false; }
            if (d == 4) { button4.Enabled = false; }
            if (d == 5) { button5.Enabled = false; }
            if (d == 6) { button6.Enabled = false; }
            if (d == 7) { button7.Enabled = false; }
            if (d == 8) { button8.Enabled = false; }
            if (d == 9) { button9.Enabled = false; }
            if (d == 10)  { button10.Enabled = false; }

        }

        //GameOVer
        public void gameOver(char win) {

            // Strategy player vs Player
            if (strategy == true)
            {
                if (win == 'X')
                {
                    //player wins
                    label1.Text = "Player 1 Wins";
                    disableButtons();
                    currentTurn = 'X';

                    checkBoxes = 0;

                    //playerScore
                    p1Score = p1Score + 1;
                    label6.Text = Convert.ToString(p1Score);
                }

                else if (win == 'O')
                {
                    label1.Text = "Player 2 Wins";
                    disableButtons();
                    currentTurn = 'X';

                    checkBoxes = 0;
                    // Computer wins

                    //player 2 score Update

                    p2Score = p2Score + 1;
                    label5.Text = Convert.ToString(p2Score);

                }

            }
            //Strategy player vs player ends


            if (strategy == false) {

                //player vs Computer Strategy

                if (win == 'X')
                {
                    label1.Text = "Player Wins";
                    disableButtons();
                    currentTurn = 'X';

                    checkBoxes = 0;
                    //PLayer Wins
                    pScore = pScore + 1;
                    label6.Text = Convert.ToString(pScore);
                    gameStatus = false;
                }

                else if (win == 'O')
                {
                    label1.Text = "Computer Wins";
                    disableButtons();
                    currentTurn = 'X';

                    checkBoxes = 0;
                    // Computer wins

                    //player 2 score Update
                    cScore = cScore + 1;
                    label5.Text = Convert.ToString(cScore);
                    gameStatus = false;


                }

                }

            } 

        public void clearButtons() {

            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
        }

        public void enableButtons()
        {

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        public void disableButtons() {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            //  PLayer vs Computer strategy\
            checkBoxes = 0;
            strategy = false;
            for (int i = 0; i <= 8; i++)
            {
                Array[i] = '\0';   //clearing array
            }

            clearButtons();
            enableButtons();
            //clear all buttons 
            currentTurn = 'X';    // set currentTurn to X 
            label1.Text = "Player vs Computer Selected";
            label4.Text = "Player Score:";
            label3.Text = "Computer Score:";

            //Initialize Scores
            label6.Text = Convert.ToString(pScore);
            label5.Text = Convert.ToString(cScore);

            gameStatus = true;
            label7.Text = "X";
        }

        private void reset_Click(object sender, EventArgs e)
        {
            clearButtons();
            label7.Text = "";
            label1.Text = "New Game";
            
        }

        private void form_Load(object sender, EventArgs e)
        {

        }
    }
}
