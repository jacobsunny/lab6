using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTackToe
{
    public class tickTackToe
    {








        public enum Player
        {

            x,
            o
        }
        Player currentPlayer = Player.x;
        char[,] board = new char[3, 3];


        // creating board 

        public  int createBoard()
        {
            int[] board = new int[9];
            int x = board.Length;
            return x;
        }



        public char CurrentPlayer(int player1)
        {
            if (player1 == 0)
            {
                return 'x';
            }
            else
                return 'o';
        }

        public string ChangePlayer(int player)
        {
            if (player == 1)
            {
                return "player1";
            }
            else
                return "player2";
        }

        /*  void MakeMove()
          {



          }
          */
        /* bool SpaceInUSe()
         {




         }

     */
    }

}
