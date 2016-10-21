using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace XMT281Scraper.Tools
{
    public static class Serializer
    {
        static JsonSerializer serializer = new JsonSerializer();
        public static void Serialize(string filename, Entities.Processor psr)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, psr);
                //{"Name":null,"StartURL":null,"XPath":null,"CssSelector":null,"NodeOffset":3,"NodeAttribute":null,"Remover":["FFFF","FFFFJJ"],"Replacer":{"s":"B","J":"k"}}
            }
        }
        public static Entities.Processor DeSerialize(string fileName)
        {
            using (StreamReader srr = new StreamReader(fileName))
            {
                using (Newtonsoft.Json.JsonReader jr = new JsonTextReader(srr))
                {
                    Entities.Processor psrr = serializer.Deserialize<Entities.Processor>(jr);
                    return psrr;
                }
            }
        }
        public static Entities.Processor DeSerializeFromJsonString(string json)
        {
            using (Newtonsoft.Json.JsonReader jr = new JsonTextReader(new StringReader(json)))
            {
                Entities.Processor psrr = serializer.Deserialize<Entities.Processor>(jr);
                    
                return psrr;
            }
            
        }
        public static string ShowJson(Entities.Processor psr)
        {
            return ConvertJsonStringFromPSR(psr);
        }
        public static string ConvertJsonString(string str)
        {
            //格式化json字符串
            JsonSerializer serializer = new JsonSerializer();
            TextReader tr = new StringReader(str);
            JsonTextReader jtr = new JsonTextReader(tr);
            object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return str;
            }          
        }
        public static string ConvertJsonStringFromPSR(Entities.Processor obj)
        {
            //格式化json字符串
            //JsonSerializer serializer = new JsonSerializer();
            //TextReader tr = new StringReader(psr);
            //JsonTextReader jtr = new JsonTextReader(tr);
            //object obj = serializer.Deserialize(jtr);
            if (obj != null)
            {
                StringWriter textWriter = new StringWriter();
                JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                {
                    Formatting = Formatting.Indented,
                    Indentation = 4,
                    IndentChar = ' '
                };
                serializer.Serialize(jsonWriter, obj);
                return textWriter.ToString();
            }
            else
            {
                return "Error!转换Json错误，对象为空";
            }
        }
    }
}
