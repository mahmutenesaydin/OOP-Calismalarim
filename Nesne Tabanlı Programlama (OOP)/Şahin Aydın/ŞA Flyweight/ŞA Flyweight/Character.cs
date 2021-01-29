using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞA_Flyweight
{
    public class Character
    {
        protected char symbol;
        protected int width;
        protected int height;

        public void Display(int pointSize,ListBox listBox)
        {
            listBox.Items.Add(this.symbol + "(pointsize " + pointSize + ")");
        }
    }
    public class CharacterFactory
    {
        private Dictionary<char, Character> _characters = new Dictionary<char, Character>();
        public Character this[char key]
        {
            get
            {
                Character character = null;
                if (_characters.ContainsKey(key))
                {
                    character = _characters[key];
                }
                else
                {
                    string name = this.GetType().Namespace + "." + "Character" + key.ToString();
                    character = (Character)Activator.CreateInstance(Type.GetType(name));
                }
                return character;
            }
        }
    }
    public class CharacterA : Character
    {
        public CharacterA()
        {
            symbol = 'A';
            width = 120;
            height = 100;
        }
    }
    public class CharacterB : Character
    {
        public CharacterB()
        {
            symbol = 'B';
            width = 120;
            height = 100;
        }
    }
    public class CharacterC : Character
    {
        public CharacterC()
        {
            symbol = 'C';
            width = 120;
            height = 100;
        }
    }
    /*.....*/
    public class CharacterZ : Character
    {
        public CharacterZ()
        {
            symbol = 'Z';
            width = 120;
            height = 100;
        }
    }
}
