﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace TP2.Classes
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Source { get; set; }
        public BitmapImage Profil => new BitmapImage(App.GetUri(Source));
        public List<User> Friends { get; set; }
        public override string ToString()
        {
            return Name + " " + LastName;
        }
    }

}