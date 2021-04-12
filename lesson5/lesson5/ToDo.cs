using System;
using System.Collections.Generic;
using System.Text;

namespace lesson5
{
    public class ToDo
    {
        // класс ToDo = задание
        public string Title { get; set; }
        public bool IsDone { get; set; }

        public ToDo()
        { }

        public ToDo(string title)
        {
            Title = title;
            IsDone = false;
        }
    }
}
