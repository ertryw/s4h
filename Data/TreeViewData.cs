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
                Image = "../../images/ProductsLarge/1.png",
            },
        };
    }
}