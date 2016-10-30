using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMT281Scraper.Entities
{
    public enum EnumNodeOffset
    {
        NoOffset = 0,
        SinblingLeft = 1,
        SinblingRight = 2,
        Parent = 3,
        Child = 4
    }
    public class Enum
    {
        public static string NodeOffsetChinese(Entities.EnumNodeOffset offset)
        {
            switch (offset)
            {
                case EnumNodeOffset.NoOffset:
                    return "无";
                case EnumNodeOffset.SinblingLeft:
                    return "左";
                case EnumNodeOffset.SinblingRight:
                    return "右";
                case EnumNodeOffset.Parent:
                    return "父";
                case EnumNodeOffset.Child:
                    return "子";
                default:
                    return "无";
            }
        }
    }
}
