using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        private readonly double[] _freqPlayer = { 0.18, 0.22, 0.22, 0.18, 0.1, 0.1};
        private readonly double[] _freqComputer = { 0.1, 0.16, 0.16, 0.16, 0.21, 0.21 };

        private readonly Player _player;
        private readonly Player _computer;

        int rollNum = 0;


        public Form1()
        {
            InitializeComponent();
            _player = new Player(_freqPlayer);
            _computer = new Player(_freqComputer);

        }


        private void Reset()
        {
            playerCube1.Text = playerCube2.Text = playerCube3.Text = "";
            computerCube1.Text = computerCube2.Text = computerCube3.Text = "";
            winnerBox.Text = "";
        }

        private string CalculateWinner()
        {
            if (_player.score > _computer.score) { return "The winner is Player!"; }
            if (_player.score < _computer.score) { return "The winner is Computer!"; }
            return (int)_player.score == (int)_computer.score ? "Draw" : "";
        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            int playerResult = _player.RollDice();
            int computerResult = _computer.RollDice();

            switch (rollNum)
            {
                case 0:
                    Reset();
                    _player.score = _computer.score = 0;
                    _player.score += playerResult; _computer.score += computerResult;

                    playerCube1.Text = playerResult + "";
                    computerCube1.Text = computerResult + "";
                    rollNum = 1;
                    break;
                case 1:
                    _player.score += playerResult; _computer.score += computerResult;

                    playerCube2.Text = playerResult + "";
                    computerCube2.Text = computerResult + "";
                    rollNum = 2;
                    break;
                case 2:
                    _player.score += playerResult; _computer.score += computerResult;

                    playerCube3.Text = playerResult + "";
                    computerCube3.Text = computerResult + "";
                    rollNum = 0;
                    winnerBox.Text = CalculateWinner();
                    break;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
