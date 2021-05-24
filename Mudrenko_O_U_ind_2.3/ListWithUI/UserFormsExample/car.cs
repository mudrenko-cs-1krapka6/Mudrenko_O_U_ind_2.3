using System;

namespace UserFormsExample
{
    public class Car
    {
        public string nomer = "";
        public string when_obl_is_start = "";
        public string when_obl_is_end = "";
        public string year = "";
        public string color = "";
        public uint nomer_kuzov = 0;

        public Car()
        {
            nomer_kuzov = 0;
            nomer = when_obl_is_start = when_obl_is_end = year = color = " ";
        }
        public Car(string nomer, string when_obl_is_start, string when_obl_is_end, string year, string color, uint nomer_kuzov = 0)
        {
            this.nomer = nomer;
            this.when_obl_is_start = when_obl_is_start;
            this.when_obl_is_end = when_obl_is_end;
            this.year = year;
            this.color = color;
            this.nomer_kuzov = nomer_kuzov;
        }

        public Car(string[] list)
        {
            this.nomer = list[0];
            this.when_obl_is_start = list[1];
            this.when_obl_is_end = list[2];
            this.year = list[3];
            this.color = list[4];
            this.nomer_kuzov = uint.Parse(list[5]);
        }
        
    }
}