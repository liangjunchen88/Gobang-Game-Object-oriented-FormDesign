using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;
namespace 五子棋Forms
{
    public partial class Form1 : Form
    {        
        private bool start;//游戏是否开始        
        private bool type = true;//下的是黑子还是白子
        private const int size = 15;//棋盘大小
        private int[,] ChessCheck = new int[size, size];//是否为空，空为0，不为空为1、2
        public int mode = 0;//判断模式，mode=1为人机，mode=2为双人
        bool machine = false;//用于辨识电脑是否下棋
        public int[] locationx = new int[200];
        public int[] locationy = new int[200];
        public bool[] types = new bool[200];
        public static int i=0, j=0,n=0;
        private object saveFileDialog;
        public int[,] rem = new int[3, 100];
        public Form1()
        {//播放音乐
            InitializeComponent();
            SoundPlayer sound=new SoundPlayer(Properties.Resources.ResourceManager.GetStream("music"));
            sound.Play();

        }

        //设置游戏窗体大小
        private void Form1_Load(object sender, EventArgs e)
        {
            start = false;
            //button1.Enabled = true;
            button2.Enabled = false;
            this.Width = MainSize.Wid;
            this.Height = MainSize.Hei;
            this.Location = new Point(260, 75);
        }


        //初始化
        private void InitializeThis()
        {
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                    ChessCheck[i, j] = 0;
            start = false;
            this.panel1.Invalidate();
            type = true;
        }

        //画棋盘
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics();
            ChessBoard.DrawCB(g);//重绘棋盘
            Chess.ReDrawC(panel1, ChessCheck);
        }

        //设置游戏控制界面的大小
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.Size = new Size(MainSize.Wid - MainSize.CBWid-20, MainSize.Hei);
        }
        
        //按开始键后的结果
        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = "游戏开始";
            start = true;
            button1.Enabled = false;
            button2.Enabled = true;           
            timer1.Start();
        }

        //按重置后的结果
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否开始新的棋局？", "温馨提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                start = false;
                button1.Enabled = true;
                button2.Enabled = false;
                timer1.Stop();
                count=0;
                textBox1.Text = " ";
                InitializeThis();
            }
        }

        //退出程序
        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        int count=0; int time = 600;//设置棋局时间为10分钟


        //根据鼠标点击的位置画棋子
        int x1;
        int y1;
        int num = 0;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {            
            if (mode==1)
            {
                //玩家先下棋
                machine = false;
                num +=1;
                button6.Enabled = true;
                button4.Enabled = true;
                locationx[i++] = e.X;
                locationy[j++] = e.Y;
                types[n++] = type;
                if (start)
                {
                    x1 = (e.X) / MainSize.CBGap;

                    y1 = (e.Y) / MainSize.CBGap;

                    try
                    {
                        //判断此位置是否为空
                        if (ChessCheck[x1, y1] != 0)
                        {
                            return;//已经有棋子占领这个位置了
                        }
                        else
                        {
                            rem[0, num - 1] = num;
                            rem[1, num - 1] = x1;
                            rem[2, num - 1] = y1;
                        }

                        //下黑子还是白子
                        ChessCheck[x1, y1] = 1;
                        //画棋子

                        Chess.DrawC(panel1, type, e);

                        //换颜色

                        type = !type;

                    }
                    catch (Exception)
                    {
                        //防止因鼠标点击边界，而导致数组越界，进而运行中断。
                    }

                    //判断是否胜利

                    if (IsFull(ChessCheck) && !BlackVictory(ChessCheck) && !WhiteVictory(ChessCheck))
                    {
                        MessageBox.Show("平局");
                        InitializeThis();
                        //label1.Text = "游戏尚未开始！";
                    }
                    if (BlackVictory(ChessCheck))
                    {
                        MessageBox.Show("黑方胜利(Black Win)"); timer1.Stop();
                        InitializeThis();
                        //label1.Text = "游戏尚未开始！";
                    }
                    if (WhiteVictory(ChessCheck))
                    {
                        MessageBox.Show("白方胜利(White Win)"); timer1.Stop();
                        InitializeThis();
                        // label1.Text = "游戏尚未开始！";
                    }
                }
                else
                {
                    MessageBox.Show("请先开始游戏！", "提示信息！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //电脑下棋
                num += 1;
                rem[0, num - 1] = num;
                types[n++] = type;//记录颜色
                machine = false;//用于辨识电脑是否下棋
                                //关注最新下的棋子ChessCheck[x1+1, y1]
                                //首先判断黑棋是不是即将赢得比赛，如果是就要立即堵上
  
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (ChessCheck[i, j] != 0)
                        {
                            //纵向判断
                            if (j < 11)
                            {
                                if (machine == false && ChessCheck[i, j] == 1 && ChessCheck[i, j + 1] == 1 
                                    && ChessCheck[i, j + 2] == 1 && ChessCheck[i, j + 3] == 1 
                                    && ChessCheck[i, j + 4] == 0)
                                {
                                    ChessCheck[i, j + 4] = 2;
                                    machine = true;
                                    rem[1, num - 1] = i;
                                    rem[2, num - 1] = j+4;//记录位置
                                }
                            }
                            //横向判断
                            if (i < 11)
                            {
                                if (machine == false && ChessCheck[i, j] == 1 &&ChessCheck[i + 1, j] == 1
                                    && ChessCheck[i + 2, j] == 1 && ChessCheck[i + 3, j] == 0 
                                    && ChessCheck[i + 4, j] == 0)
                                {
                                    ChessCheck[i + 4, j] = 2;
                                    machine = true;
                                    rem[1, num - 1] = i+4;
                                    rem[2, num - 1] = j ;//记录位置
                                }
                            }
                            //斜向右下判断
                            if (i < 11 && j < 11)
                            {
                                if (machine == false && ChessCheck[i, j] == 1 && ChessCheck[i + 1, j + 1] == 1
                                    && ChessCheck[i + 2, j + 2] == 1 && ChessCheck[i + 3, j + 3] == 1
                                    && ChessCheck[i + 4, j + 4] == 0)
                                {
                                    ChessCheck[i + 4, j + 4] = 2;
                                    machine = true;
                                    rem[1, num - 1] = i+4;
                                    rem[2, num - 1] = j + 4;//记录位置
                                }
                            }
                            //斜向左下判断
                            if (i >= 4 && j < 11)
                            {
                                if (machine == false && ChessCheck[i, j] == 1 && ChessCheck[i - 1, j + 1] == 1 
                                    && ChessCheck[i - 2, j + 2] == 1 && ChessCheck[i - 3, j + 3] == 1
                                    && ChessCheck[i - 4, j + 4] == 1)
                                {
                                    ChessCheck[i - 4, j + 4] = 2;
                                    machine = true;
                                    rem[1, num - 1] = i-4;
                                    rem[2, num - 1] = j + 4;//记录位置
                                }
                            }
                        }
                    }
                }
                if (machine == false)//如果黑棋没有形成4连，就在新下黑棋的四周下棋
                {
                    if (x1 + 1 < size && ChessCheck[x1 + 1, y1] == 0)
                    {
                        ChessCheck[x1 + 1, y1] = 2; machine = true;
                        rem[1, num - 1] = x1 + 1;
                        rem[2, num - 1] = y1;//记录位置
                    }
                    else if (x1 - 1 >= 0 && ChessCheck[x1 - 1, y1] == 0)
                    {
                        ChessCheck[x1 - 1, y1] = 2; machine = true;
                        rem[1, num - 1] = x1 - 1;
                        rem[2, num - 1] = y1;//记录位置
                    }
                    else if (y1 + 1 < size && ChessCheck[x1, y1 + 1] == 0)
                    {
                        ChessCheck[x1, y1 + 1] = 2; machine = true;
                        rem[1, num - 1] = x1 ;
                        rem[2, num - 1] = y1+1;//记录位置
                    }
                    else if (y1 - 1 >= 0 && ChessCheck[x1, y1 - 1] == 0)
                    {
                        ChessCheck[x1, y1 - 1] = 2; machine = true;
                        rem[1, num - 1] = x1 ;
                        rem[2, num - 1] = y1-1;//记录位置
                    }
                    //如果上下左右都没有空位，就下在一个无子的随机位置
                    else
                    {
                        int a = 0;
                        int b = 0;
                        int count2 = 0;
                        while (ChessCheck[a, b] != 0)
                        {
                            Random r1 = new Random(count2);
                            Random r2 = new Random(count2 + 1);
                            a = r1.Next(0, size);
                            b = r2.Next(0, size);
                            count2++;
                        }
                        ChessCheck[a, b] = 2;
                        machine = true;
                        rem[1, num - 1] = a;
                        rem[2, num - 1] = b;//记录位置
                    }
                }

                Chess.ReDrawC(panel1, ChessCheck);
                type = !type;
                //判断胜利与否
                if (IsFull(ChessCheck) && !BlackVictory(ChessCheck) && !WhiteVictory(ChessCheck))
                {
                    MessageBox.Show("平局");
                    InitializeThis();
                }
                if (BlackVictory(ChessCheck))
                {
                    MessageBox.Show("黑方胜利(Black Win)"); timer1.Stop();
                    InitializeThis();
                }
                if (WhiteVictory(ChessCheck))
                {
                    MessageBox.Show("白方胜利(White Win)"); timer1.Stop();
                    InitializeThis();
                }
            }
            //玩家对战
            if(mode==2)
            {
                
                num++;                
                button6.Enabled = true;
                button4.Enabled = true;
                locationx[i++] = e.X;
                locationy[j++] = e.Y;
                types[n++] = type;
                if (start)
                {
                    x1 = (e.X) / MainSize.CBGap;

                    y1 = (e.Y) / MainSize.CBGap;

                    try
                    {
                        //判断此位置是否为空
                        if (ChessCheck[x1, y1] != 0)
                        {
                            return;//如果位置有棋子就点不动
                        }
                        else
                        {
                            rem[0, num - 1] = num;
                            rem[1, num - 1] = x1;
                            rem[2, num - 1] = y1;
                        }
                        //棋色
                        if (type)
                        {
                            ChessCheck[x1, y1] = 1;
                        }
                        else
                        {
                            ChessCheck[x1, y1] = 2;
                        }
                        Chess.DrawC(panel1, type, e);
                        type = !type;//改变颜色

                    }
                    catch (Exception)
                    {
                        //防止因鼠标点击边界，而导致数组越界，进而运行中断。
                    }
                    //判断胜负，平局另外用计时器判断
                    if (IsFull(ChessCheck) && !BlackVictory(ChessCheck) && !WhiteVictory(ChessCheck))
                    {
                        MessageBox.Show("黑白平局");
                        InitializeThis();
                    }
                    if (BlackVictory(ChessCheck))
                    {
                        MessageBox.Show("黑方胜利(Black Win)"); timer1.Stop();
                        InitializeThis();
                    }
                    if (WhiteVictory(ChessCheck))
                    {
                        MessageBox.Show("白方胜利(White Win)"); timer1.Stop();
                        InitializeThis();
                    }
                }
                else
                {
                    MessageBox.Show("请先开始游戏！", "提示信息！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        //是否满格
        public bool IsFull(int[,] ChessCheck)
        {
            bool full = true;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (ChessCheck[i, j] == 0)
                        return full = false;
                }
            }
            return full;
        }

        //判断黑棋是否赢得比赛
        public bool BlackVictory( int[,] ChessBack)
        {
            bool Win = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (ChessCheck[i,j]!=0)
                    {
                        //纵向判断
                        if (j<11)
                        {
                            if (ChessCheck[i, j] == 1 && ChessCheck[i, j + 1] == 1 && ChessCheck[i, j + 2] == 1 && ChessCheck[i, j + 3] == 1 && ChessCheck[i, j + 4] == 1)
                            {
                                return Win = true;
                            }
                        }
                        //横向判断
                        if (i<11)
                        {
                            if (ChessCheck[i, j] == 1 && ChessCheck[i + 4, j] == 1 && ChessCheck[i + 1, j] == 1 && ChessCheck[i + 2, j] == 1 && ChessCheck[i + 3, j] == 1)
                            {
                                return Win = true;
                            }
                        }
                        //斜向右下判断
                        if (i<11&&j<11)
                        {
                            if (ChessCheck[i, j] == 1 && ChessCheck[i + 1, j + 1] == 1 && ChessCheck[i + 2, j + 2] == 1 && ChessCheck[i + 3, j + 3] == 1 && ChessCheck[i + 4, j + 4] == 1)
                            {
                                return Win = true;
                            }
                        }
                        //斜向左下判断
                        if (i>=4&&j<11)
                        {
                            if (ChessCheck[i, j] == 1 && ChessCheck[i - 1, j + 1] == 1 && ChessCheck[i - 2, j + 2] == 1 && ChessCheck[i - 3, j + 3] == 1 && ChessCheck[i - 4, j + 4] == 1)
                            {
                                return Win = true;
                            }
                        }
                    }
                }
            }
            return Win;
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }
        
        private void button6_Click(object sender, EventArgs e)
        {//悔棋
            if (mode == 1)
            {
                InitializeThis();
                for (int i = 0; i < num; i++)
                {
                    int a = rem[1, i];
                    int b = rem[2, i];
                    if (i % 2 == 1)
                    {
                        ChessCheck[a, b] = 2;
                    }
                    else
                    {
                        ChessCheck[a, b] = 1;
                    }
                }
                ChessCheck[rem[1, num - 1], rem[2, num - 1]] = 0;
                ChessCheck[rem[1, num - 2], rem[2, num - 2]] = 0;
                num =num-2;//步数减一
                Chess.ReDrawC(panel1, ChessCheck);//重新加载（画）棋子。
                //type = !type;
            }
            if (mode==2)
            {
                InitializeThis();
                for (int i = 0; i < num; i++)
                {
                    int a = rem[1, i];
                    int b = rem[2, i];
                    if (i % 2 == 1)
                    {
                        ChessCheck[a, b] = 2;
                    }
                    else
                    {
                        ChessCheck[a, b] = 1;
                    }
                }
                ChessCheck[rem[1, num - 1], rem[2, num - 1]] = 0;
                num--;//步数减一
                Chess.ReDrawC(panel1, ChessCheck);//重新加载（画）棋子。
                type = !type;
            }
            //ChessCheck[x1, y1] = 0;
            //Graphics g = panel1.CreateGraphics();
            //num--;//步数减一
            //ChessBoard.DrawCB(g);//重新加载（画）棋盘
            //Chess.ReDrawC(panel1, ChessCheck);//重新加载（画）棋子。
            //button6.Enabled = false;//只能悔自己的棋
            //type = !type;//保持颜色一致
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            count++;
            textBox1.Text = (time - count).ToString() + " S";
            if (count == time)
            {
                timer1.Stop();
                System.Media.SystemSounds.Asterisk.Play();
                //时间到则判定平局
                MessageBox.Show("时间到，双方战平！", "提示");
            }
        }

        public static int l = 0, s = 0, t = 0;

        private void 人机对战ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 1;
            button1.Enabled = true;//先选模式后开始
            button5.Enabled = true;//先选模式后复盘
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎来到五子棋局！\n"+
                "1.选择模式后点击 开始 按钮即可开启五子棋对战\n" +
                "2.相关功能可通过点击 菜单 或者 右侧按钮 实现\n" +
                "祝你玩的愉快！","帮助" );
        }

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎来到五子棋局！\n" +
              "1.此版本为3.0\n" +
              "2.版本作者：西安交通大学信计81 梁俊琛\n" +
              "3.联系我们：1808408718@qq.com\n" +
              "祝你玩的愉快！", "说明");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            count = 0;
            InitializeThis();
            timer2.Start();

        }
        public int Rem = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            Rem++;
            int a = rem[1, Rem - 1];
            int b = rem[2, Rem - 1];
            if (Rem % 2 == 1)
            {
                ChessCheck[a, b] = 1;
            }
            else
            {
                ChessCheck[a, b] = 2;
            }
            Chess.ReDrawC(panel1, ChessCheck);//重新加载（画）棋子。
            if(Rem==num)
            {
                timer2.Stop();
            }
        }

        private void 双人对战ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = 2;
            button1.Enabled = true;//先选模式后开始
            button5.Enabled = true;//先选模式后复盘
        }

        public void button5_Click(object sender, EventArgs e)
        {//复盘
            int[] temp = new int[size * size + 1];
            Graphics g = panel1.CreateGraphics();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog.FileName);

                while (reader.Peek() > -1)
                {
                    string r = reader.ReadLine();
                    string[] rs = new string[0];
                    int count1 = 0;
                    while (count1 < size * size)
                    {
                        rs = r.Split(' ');
                        count1++;
                    }
                    for (int k = 0; k < rs.Length; k++)
                    {
                        temp[k] = Convert.ToInt32(rs[k]);
                    }
                }
                reader.Close();
                int count = 1;
                while (count <= size * size )
                    for (int a = 0; a < size; a++)
                    {
                        for (int b = 0; b < size; b++)
                        {
                            ChessCheck[a, b] = temp[count];
                            count++;
                        }
                    }
                num = temp[0];
                Chess.ReDrawC(panel1, ChessCheck);//重新加载（画）棋子。
                if (num % 2 == 1)
                {
                    type = !type;//改变颜色   
                }
                button1.Enabled = true;
            }
        }

        //判断白棋是否赢得比赛
        public bool WhiteVictory(int[,] ChessBack)
        {
            bool Win = false;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (ChessCheck[i, j] != 0)
                    {
                        if (j < 11)
                        {
                            if (ChessCheck[i, j] == 2 && ChessCheck[i, j + 1] == 2 && ChessCheck[i, j + 2] == 2 && ChessCheck[i, j + 3] == 2 && ChessCheck[i, j + 4] == 2)
                            {
                                return Win = true;
                            }
                        }
                        if (i < 11)
                        {
                            if (ChessCheck[i, j] == 2 && ChessCheck[i + 4, j] == 2 && ChessCheck[i + 1, j] == 2 && ChessCheck[i + 2, j] == 2 && ChessCheck[i + 3, j] == 2)
                            {
                                return Win = true;
                            }
                        }
                        if (i < 11 && j < 11)
                        {
                            if (ChessCheck[i, j] == 2 && ChessCheck[i + 1, j + 1] == 2 && ChessCheck[i + 2, j + 2] == 2 && ChessCheck[i + 3, j + 3] == 2 && ChessCheck[i + 4, j + 4] == 2)
                            {
                                return Win = true;
                            }


                        }
                        if (i >= 4 && j < 11)
                            if (ChessCheck[i, j] == 2 && ChessCheck[i - 1, j + 1] == 2 && ChessCheck[i - 2, j + 2] == 2 && ChessCheck[i - 3, j + 3] == 2 && ChessCheck[i - 4, j + 4] == 2)
                            {
                                return Win = true;
                            }
                    }
                }
            }
            return Win;
        }

        
        public void button4_Click(object sender, EventArgs e)
        {//存盘
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                writer.Write(num + " ");
                for (int a = 0; a < size; a++)
                {
                    if (a < size - 1)
                    {
                        for (int b = 0; b < size; b++)
                        {
                            writer.Write(ChessCheck[a, b]);
                            writer.Write(" ");
                        }
                    }
                    else
                    {
                        for (int b = 0; b < size; b++)
                        {
                            writer.Write(ChessCheck[a, b]);
                        }
                    }

                }
                writer.Close();
                InitializeThis();
            }
        }
    }
}