using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


partial class Block
{

    List<List<string[][]>> AllBlock = new List<List<string[][]>>();
    //모든 블록의 모양을 관리
    void Datalnit()
    {
        for(int BT=0; BT< (int)BLOCKTYPE.BT_MAX; BT++)//(int)BLOCKTYPE.BT_MAX enum 형변환 
        {
            AllBlock.Add(new List<string[][]>());
            for(int BD=0; BD<(int)BLOCKDIR.BD_MAX; BD++)
            {
                AllBlock[BT].Add(null);
            }
        }
       

        #region S
        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_T]= new string[][]
        {
            //일자블럭 T
            new string[] { "▣", "□", "□", "□" },
            new string[] { "▣", "□", "□", "□" },
            new string[] { "▣", "□", "□", "□" },
            new string[] { "▣", "□", "□", "□" }
        };

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_R] = new string[][]
        {
            //일자블럭 R
            new string[] { "▣", "▣", "▣", "▣" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_B] = new string[][]
{
            //일자블럭 B
            new string[] { "▣", "□", "□", "□" },
            new string[] { "▣", "□", "□", "□" },
            new string[] { "▣", "□", "□", "□" },
            new string[] { "▣", "□", "□", "□" }
        };

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.BD_L] = new string[][]
{
            //일자블럭 L
            new string[] { "▣", "▣", "▣", "▣" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };

        /* string[] Arr = new string[] { "▣", "□", "□", "□" };
           string[] Arr = new string[] { "▣", "□", "□", "□" };
           string[] Arr = new string[] { "▣", "□", "□", "□" };
           string[] Arr = new string[] { "▣", "□", "□", "□" };*/
        #endregion
        #region T
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_T] = new string[][]
       {
            //ㅗ자블럭 T
            new string[] { "□", "▣", "□", "□" },
            new string[] { "▣", "▣", "▣", "□" },
            new string[] { "□", "□", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_R] = new string[][]
        {
            //ㅗ자블럭 R
            new string[] { "□", "▣", "□", "□" },
            new string[] { "□", "▣", "▣", "□" },
            new string[] { "□", "▣", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_B] = new string[][]
        {
            //ㅗ자블럭 R
            new string[] { "□", "□", "□", "□" },
            new string[] { "▣", "▣", "▣", "□" },
            new string[] { "□", "▣", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };
        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.BD_L] = new string[][]
        {
            //ㅗ자블럭 L
            new string[] { "□", "▣", "□", "□" },
            new string[] { "▣", "▣", "□", "□" },
            new string[] { "□", "▣", "□", "□" },
            new string[] { "□", "□", "□", "□" }
        };
        #endregion

    }
}

