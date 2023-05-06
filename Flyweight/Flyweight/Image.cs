using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Image
    {
        public string Picture { get; private set; }
        public Image(string picture)
        {
            Picture = picture;
        }

        public static Image Load(string picture)
        {
            return new Image(picture);
        } 
    }
}
