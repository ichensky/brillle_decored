using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BrailleDecored
{
    class Item {
        public char Letter { get; set; }
        public byte Code { get; set; }
        public Item(char letter, byte code) {
            this.Letter = letter;
            this.Code = code;
        } 
    }
    public static class Helper {
        public static byte ToByte(this string str) {
            return Convert.ToByte(str, 2);
        }
    }
    

    class Program
    {
        static void Main(string[] args)
        {
            var table = new List<Item>() {
                new Item('A', 
               ("10" +
                "00" +
                "00").ToByte()),
                new Item('B', 
               ("10" +
                "10" +
                "00").ToByte()),
                new Item('C',
               ("11" +
                "00" +
                "00").ToByte()),
                new Item('D',
               ("11" +
                "01" +
                "00").ToByte()),
                new Item('E',
               ("10" +
                "01" +
                "00").ToByte()),
                new Item('F',
               ("11" +
                "10" +
                "00").ToByte()),
                new Item('G',
               ("11" +
                "11" +
                "00").ToByte()),
                new Item('H',
               ("10" +
                "11" +
                "00").ToByte()),
                new Item('I',
               ("01" +
                "10" +
                "00").ToByte()),
                new Item('J',
               ("01" +
                "11" +
                "00").ToByte()),
                new Item('K',
               ("10" +
                "00" +
                "10").ToByte()),
                new Item('L',
               ("10" +
                "10" +
                "10").ToByte()),
                new Item('M',
               ("11" +
                "00" +
                "10").ToByte()),
                new Item('N',
               ("11" +
                "01" +
                "10").ToByte()),
                new Item('O',
               ("10" +
                "01" +
                "10").ToByte()),
                new Item('P',
               ("11" +
                "10" +
                "10").ToByte()),
                new Item('Q',
               ("11" +
                "11" +
                "10").ToByte()),
                new Item('R',
               ("10" +
                "11" +
                "10").ToByte()),
                new Item('S',
               ("01" +
                "10" +
                "10").ToByte()),
                new Item('T',
               ("01" +
                "11" +
                "10").ToByte()),
                new Item('U',
               ("10" +
                "00" +
                "11").ToByte()),
                new Item('V',
               ("10" +
                "10" +
                "11").ToByte()),
                new Item('W',
               ("01" +
                "11" +
                "01").ToByte()),
                new Item('X',
               ("11" +
                "00" +
                "11").ToByte()),
                new Item('Y',
               ("11" +
                "01" +
                "11").ToByte()),
                new Item('Z',
               ("10" +
                "01" +
                "11").ToByte()),
                new Item('№',
               ("01" +
                "01" +
                "11").ToByte()),
                new Item('.',
               ("00" +
                "11" +
                "01").ToByte()),
                new Item(',',
               ("00" +
                "10" +
                "00").ToByte()),
                new Item('?',
               ("00" +
                "10" +
                "01").ToByte()),
                new Item(';',
               ("00" +
                "10" +
                "10").ToByte()),
                new Item('-',
               ("00" +
                "11" +
                "00").ToByte()),
            };


            var path = @"C:\Users\john\Desktop";
            var input = File.ReadAllLines(Path.Combine(path, "input.txt"));

            var str = new StringBuilder();
            for (int i = 0; i < input.Length; i += 3)
            {
                var line1 = input[i];
                var line2 = input[i + 1];
                var line3 = input[i + 2];
                var length = line1.Length;

                for (int j = 0; j < length; j += 2)
                {
                    var code = $"{line1[j]}{line1[j + 1]}{line2[j]}{line2[j + 1]}{line3[j]}{line3[j + 1]}".ToByte();
                    var letter = table.FirstOrDefault(x => x.Code == code).Letter;
                    str.Append(letter);
                }
            }
            Console.WriteLine(str);
        }
    }
}
