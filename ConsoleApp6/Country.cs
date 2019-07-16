using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Country
    {

        private string _name;
        private string _info;
        private Pole [] pole = new Pole[4];
        public Country()
        {

        }
        public Country(string name, string info)
        {
            _name = name;
            _info = info;
            for(int i = 0; i < pole.Length; i++)
            {
                pole[i].SetTypeCroops("none");
            }
        }
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            _name = name;
        }
        public string GetInfo()
        {
            return _info;
        }
        public void SetInfo(string info)
        {
            _info = info;
        }
        public void SetPole(string typeCroops)
        {
            pole[0].SetTypeCroops(typeCroops);
        }

    }
}
