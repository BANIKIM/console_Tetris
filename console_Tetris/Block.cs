using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


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
    Random NewRandom = new Random();
    /* BLOCKDIR Dir = BLOCKDIR.BD_T;*/
    string[][] Arr = null;
    // List<List<string>> BlockData = new List<List<string>>();
    BLOCKTYPE CurBlockType = BLOCKTYPE.BT_T;
    BLOCKDIR CurDirType = BLOCKDIR.BD_T;

    TETRISSCREEN Screen = null;
    ACCSCREEN AccScreen = null;

    public Block(TETRISSCREEN _Screen, ACCSCREEN _AccScreen)
    {
        if (null == _Screen || null == _AccScreen)
        {
            return;
        }


        Screen = _Screen;
        AccScreen = _AccScreen;
        Datalnit();
        // 바꿀수 있는 인터페이스는 이것
        Reset();

    }

    public void RandomBlockType()
    {

        //int RandomIndex = NewRandom.Next((int)BLOCKTYPE.BT_I,(int)BLOCKTYPE.BT_MAX);
        int RandomIndex = (int)BLOCKTYPE.BT_I;
        CurBlockType = (BLOCKTYPE)RandomIndex;
    }

    private void SettingBlock(BLOCKTYPE _Type, BLOCKDIR _Dir)
    {
        Arr = AllBlock[(int)_Type][(int)_Dir];
    }


    public void SetAccScreen()
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if("▣" == Arr[y][x])
                {
                    AccScreen.SetBlock(Y+y-1, X+x, Arr[y][x]);
                }
               
            }
        }
    }

    public void Reset()
    {
        RandomBlockType();
        X = 0;
        Y = 1;
        SettingBlock(CurBlockType, CurDirType);
    }

    public bool DownCheck()
    {
        //더 이상 블럭이 내려 갈 수 없는 경우

        for(int y=0; y<4; y++)
        {
            for(int x=0; x<4; x++)
            {
                if ("▣"==Arr[y][x])
                {
                    if(AccScreen.Y == Y+y || true== AccScreen.IsBlock(Y + y,x +X ,"▣"))
                    {
                        // 쌓인다.
                        SetAccScreen();
                        //위로 올린다.
                        Reset();
                        return true;
                    }
                }
            }
        }

        return false;
    }


    public void Down()
    {
        //아래를 확인하고
        //내려갈수 없으면 쌓인다.
        if(true==DownCheck())
        {
            return;
        }
        Y += 1;
        // 새로운 블럭을 만들어 낸다.
    }


    private void Input()
    {
        
        if(false == DownCheck())
        {
            Thread.Sleep(500);
            Y += 1;
        }
        
        
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
            case ConsoleKey.Q://왼쪽으로 돌림
                //enum은 --가 된다
                --CurDirType;
                if(0> CurDirType)
                {
                    CurDirType = BLOCKDIR.BD_L;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            case ConsoleKey.E://오른쪽으로 돌림
                ++CurDirType;
                if (BLOCKDIR.BD_MAX==CurDirType)
                {
                    CurDirType = BLOCKDIR.BD_T;
                }
                SettingBlock(CurBlockType, CurDirType);
                break;
            case ConsoleKey.S:
                Down();
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

