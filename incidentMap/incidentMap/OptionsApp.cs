using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incidentMap
{
    public static class OptionsApp
    {
        public static string department;
        public static string place;
        public static decimal beginX;
        public static decimal beginY;
        private static int usedMap;
        public static int id_us = 0;
        public static string usFio;
        public static string usRang;
        public static userRoles id_role = userRoles.Unknown;

        public static int UsedMap { get => (usedMap < 0 || usedMap > 1) ? 1 : usedMap; set => usedMap = value; }
    }
}
