using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Minesweeper
{
    public class Tile
    {
        
        public bool IsBomb { get; set; }
        public string Number { get; set; }
        public Visibility Visibility { get; set; }
        public event PropertyChangingEventHandler PropertyChanging;
        public Tile(string number, bool isBomb)
        {
            Number = number;
            Visibility= Visibility.Collapsed;
           this.IsBomb = isBomb;
        }
    }
}
