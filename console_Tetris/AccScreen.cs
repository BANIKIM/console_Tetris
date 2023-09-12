using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ACCSCREEN : TETRISSCREEN
{

    TETRISSCREEN Parent;
    // 부모님의 생성자를 호출
   public ACCSCREEN(TETRISSCREEN _Parent) :base(_Parent.X, _Parent.Y-2,false)
    {
        Parent = _Parent;
    }



    public override void Render()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                //  Console.Write("■");
                Parent.SetBlock(y + 1 ,x , BlockList[y][x]);
            }
        }
    }

    public void DestroyCheck()
    {
        for (int y = BlockList.Count-1; y >= 0; --y)
        {
            bool IsDestroy = true;
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
               if("□" == BlockList[y][x])
                {
                    IsDestroy = false;
                }
            }

            if(true == IsDestroy)
            {
                List<string> NewLine = new List<string>();

                for(int i = 0; i < X; i++)
                {
                    NewLine.Add("□");
                }

                
                //줄삭제
                BlockList.RemoveAt(BlockList.Count - 1);
                BlockList.Insert(0, NewLine);
                y = BlockList.Count - 1;
            }
        }
    }

}

