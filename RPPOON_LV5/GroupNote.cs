using System;
using System.Collections.Generic;

namespace RPPOON_LV5
{
    class GroupNote : Note
    {
        private List<string> users;

        public GroupNote(string message, ITheme theme) : base(message, theme) { users = new List<string>(); }

        public void AddUser(string user)
        {
            users.Add(user);
        }

        public void RemoveUser(string user)
        {
            users.Remove(user);
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("GROUP REMINDER: ");
            string framedMessage = this.GetFramedMessage();
            Console.WriteLine(framedMessage);
            foreach (string user in users)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
    }
}
