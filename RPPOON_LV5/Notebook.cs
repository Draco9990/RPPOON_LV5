using System;
using System.Collections.Generic;
using System.Text;

namespace RPPOON_LV5
{
    class Notebook
    {
        private List<Note> notes;
        private ITheme theme;

        public Notebook() { this.notes = new List<Note>(); }
        public Notebook(ITheme theme) { this.notes = new List<Note>(); this.theme = theme; }

        public void AddNote(Note note, bool keepTheme = false) {
            if(theme != null && !keepTheme)
            {
                note.Theme = theme;
            }
            this.notes.Add(note);
        }

        public void ChangeTheme(ITheme theme)
        {
            foreach (Note note in this.notes)
            {
                note.Theme = theme;
            }
        }
        public void Display()
        {
            foreach (Note note in this.notes)
            {
                note.Show();
                Console.WriteLine("\n");
            }
        }
    }
}
