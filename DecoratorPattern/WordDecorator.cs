﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.DecoratorPattern
{
    public abstract class WordDecorator : IWord
    {
        public IWord Word { get; set; }
        public string Description;
        public string Tag;
        //public string TextInput { get; set; }

        public WordDecorator(IWord word)
        {
            Word = word;
        }
        public string GetDescription()
        {
            return Word.GetDescription() + ", " + Description;
        }

        public string GetTag()
        {
            return Word.GetTag() + Tag;
        }
    }
}
