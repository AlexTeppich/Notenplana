﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notenplana23
{
    internal class FachHj2
    {
        private string fachname;

        public string Fachname { get => fachname; set => fachname = value; }

        public FachHj2(string fachname)
        {
            Fachname = fachname;
        }

        public FachHj2() {}
    }
}
