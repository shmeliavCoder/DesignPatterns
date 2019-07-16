using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memento
{
    public class Context
    {

        TextCareTaker careTake = new TextCareTaker();

        public void Save(RichTextBox richTex)
        {
            careTake.AddMemento(new TextMemento(richTex.Text));
        }

        public void Load(RichTextBox richText)
        {
            TextMemento temp = careTake.GetLast();
            if (temp != null && temp.savedText != null)
                richText.Text = temp.savedText;
        }

        public void Redo(RichTextBox richText)
        {
            TextMemento temp = careTake.GetPrevious();
            if ( temp != null && temp.savedText != null)
                richText.Text = temp.savedText;
        }
    }
}
