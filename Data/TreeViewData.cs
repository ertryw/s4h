using s4h.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtreme.NETCore.Demos.Models.SampleData
{
    public static class TreeViewPlainData
    {
        public static readonly IEnumerable<Menu> Items = new[] {
            new Menu {
                ID = "1",
                Text = "Pokoje",
                Expanded = false,
                Image = "filter",
            },
            // new Menu {
            //    ID = "2",
            //    Text = "Inne",
            //    Expanded = false,
            //    Image = "group",
            //},
        };
    }
}