using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Minesweeper
{
    public class Data
    {
        public List<List<Tile>> MatriceList { get; set; }
        public Data()
        {
            MatriceList = new List<List<Tile>>();
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                MatriceList.Add(new List<Tile>());
                for (int j = 0; j < 8; j++)
                {
                    //random bomb generate
                    int randomNumber = random.Next(0, 15);
                    if (randomNumber == 1)
                    {
                        MatriceList[i].Add(new Tile("B", true));
                    }
                    else
                    {
                        MatriceList[i].Add(new Tile("2", false));
                    }
                }
            }
            setNumbers();
        }
        public void setNumbers()
        {

            int numRows = MatriceList.Count;
            int numCols = MatriceList[0].Count;

            // Parcurgem fiecare element din matrice
            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (MatriceList[i][j].IsBomb==true)
                    {
                        continue;
                    }
                    Tile currentTile = MatriceList[i][j];
                    int count = 0;

                    // Verificăm vecinii în jurul elementului curent
                    for (int rowOffset = -1; rowOffset <= 1; rowOffset++)
                    {
                        for (int colOffset = -1; colOffset <= 1; colOffset++)
                        {
                            int neighborRow = i + rowOffset;
                            int neighborCol = j + colOffset;

                            // Verificăm dacă poziția vecinului este validă și diferită de poziția elementului curent
                            if (neighborRow >= 0 && neighborRow < numRows && neighborCol >= 0 && neighborCol < numCols &&
                                !(rowOffset == 0 && colOffset == 0))
                            {
                                if (MatriceList[neighborRow][neighborCol].IsBomb == true)
                                {
                                    count++;
                                }
                            }
                        }
                    }

                    MatriceList[i][j].Number = count.ToString();
                }
            }
        }
    }
}
