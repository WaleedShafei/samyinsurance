using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SamyWeb
{
    public class GLobal
    {
        public static int pass { get; set; }
        public static string loggedUser { get; set; }
        public static string WelcomeUser { get { return "Welcome "; } }
    }
}