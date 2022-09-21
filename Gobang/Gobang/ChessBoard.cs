using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace 五子棋Forms
{
    //以下是ChessBoard类
    class ChessBoard
    {
        public static void DrawCB(Graphics g)
        {
            int num = MainSize.CBWid / MainSize.CBGap - 1;
            int gap = MainSize.CBGap;
            g.Clear(Color.LightSlateGray);
            for (int i = 0; i < num + 1; i++)
            {
                g.DrawLine(new Pen(Color.Black), 20, 20 + i * gap, 20 + num * gap, 20 + i * gap);
                g.DrawLine(new Pen(Color.Black), 20 + gap * i, 20, 20 + i * gap, 20 + gap * num);
            }
        }
    }
}
