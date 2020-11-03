﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssemblyGetInfoLib
{
    public class Node
    {
        public Node(string content = "")
        {
            Content = content;
            Nodes = new ObservableCollection<Node>();
        }

        public string Content { get; set; }
        public ObservableCollection<Node> Nodes { get; set; }
    }
}
