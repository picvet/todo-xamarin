using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Views.FlyoutPages
{
    public class NotesFlyoutPageFlyoutMenuItem
    {
        public NotesFlyoutPageFlyoutMenuItem()
        {
            TargetType = typeof(NotesFlyoutPageFlyoutMenuItem);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }

        public string IconSource { get; set; }

    }
}