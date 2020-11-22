using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            // 实例化map类
            Map map = new Map();

            // 循环
            while (true)
            {
                // 遍历map，打印map
                map.TraverseMap();
                // 获取键盘输入，如果返回false，退出
                if (!map.ReadKey())
                {
                    map.ExitMap();
                    break;
                }
                // 在任意随机位置添加随机数字，如果没有空位置，失败退出
                if (!map.ShuffleMap())
                {
                    map.FailMap();
                    break;
                }
                // 清空控制台
                Console.Clear();
            }
            // 写入topPoints到文本中
            map.SetTopPoints();

            Console.ReadKey();
        }
    }
}
