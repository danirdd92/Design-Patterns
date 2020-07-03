using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Abstract
{
    public abstract class NodeComponent
    {
        public int Value { get; protected set; }

        public NodeComponent(int value)
        {
            Value = value;
        }
        public abstract int Sum();
        public abstract void Add(NodeComponent node);
        public abstract void Remove(NodeComponent node);
        public abstract bool IsEven();
        public abstract void CheckEven();

    }
}


//2 .ממש עץ מיספרים ופונקצית סכום אשר מחשבת את סכום המספרים מאותו ענף/עלה ועד לתחתית )לא
//ברקורסיה(. גם לעלה וגם לענף יש מספר. ממש גם פונקציה הבודקת אם כל הרכיבים בעץ מכילים
//מספרים זוגיים בלבד – כן ברקורסיה. 