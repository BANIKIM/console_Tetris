using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


enum BLOCKTYPE
{
    BT_I,// 한줄블럭
    BT_L, // 오른쪽 L
    BT_J, // 왼쪽 L
    BT_Z, // 왼쪽 N
    BT_S, // 오른쪽 N
    BT_T, // T자 블럭
    BT_O // ㅁ자 블럭
}

// 4 X 4의 배열 같은게 필요함


class Block
{
    int X =0;
    int Y =0;
    List<List<string>> BlockData = new List<List<string>>();

    TETRISSCREEN Screen = null;

    public Block(TETRISSCREEN _Screen)
    {
        Screen = _Screen;
        
        for(int y=0; y<4 ; ++y)
        {
            BlockData.Add(new List<string>());
          
        }

        

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
        Screen.SetBlock(Y, X, "▣");
       
       

    }
}

