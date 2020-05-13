using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DeskStore.Models
{
    class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public BitmapImage Image { get; set; }
    }
}
