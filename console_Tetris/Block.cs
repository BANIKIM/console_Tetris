using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum BLOCKDIR// 회전했을 때 모양
{    
    BD_T,
    BD_R,
    BD_B,
    BD_L,
    BD_MAX
}

enum BLOCKTYPE
{
    BT_I,// 한줄블럭
    BT_L, // 오른쪽 L
    BT_J, // 왼쪽 L
    BT_Z, // 왼쪽 N
    BT_S, // 오른쪽 N
    BT_T, // T자 블럭
    BT_O, // ㅁ자 블럭
    BT_MAX,
}

// 4 X 4의 배열 같은게 필요함


partial class Block
{
    int X =0;
    int Y =0;
   /* BLOCKDIR Dir = BLOCKDIR.BD_T;*/
    string[][] Arr = null;
   // List<List<string>> BlockData = new List<List<string>>();

    TETRISSCREEN Screen = null;

    public Block(TETRISSCREEN _Screen)
    {
        Screen = _Screen;
        Datalnit();

        SettingBlock(BLOCKTYPE.BT_T, BLOCKDIR.BD_R);
        

    }
    private void SettingBlock(BLOCKTYPE _Type, BLOCKDIR _Dir)
    {
        Arr = AllBlock[(int)_Type][(int)_Dir];
    }


    private void Input()
    {
        if (false == Console.KeyAvailable)
        {
            return; 
        }
        //Console.CursorLeft(40);
        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                X -= 1;
                break;
            case ConsoleKey.D:
                X += 1;
                break;
            case ConsoleKey.S:
                Y += 1;
                break;
            default:
                break;

        }
    }
    public void Move()
    {
        // Console.WriteLine(Console.ReadKey().Key);
        //내가 어떤 키든 눌렀을때만 input을 실행 
   
        Input();
        
        for(int y=0; y<4; ++y)
        {
            for(int x=0; x<4; ++x)
            {
                if (Arr[y][x] =="□")
                {
                    continue;
                }
                Screen.SetBlock(Y+y, X+x, Arr[y][x]);

            }
        }
       
       

    }
}

