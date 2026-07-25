using Microsoft.AspNetCore.Components;

namespace the_landing_page.Components
{
    public struct NavBarItem
    {
        public required string path { get; set; }

        public required string description { get; set; }
        public string? icoPath { get; set; } // These have fallbacks if unset
        public string? name { get; set; }
        public bool localPath { get; set; }
        public bool enabled { get; set; }

        public NavBarItem()
        {
            this.path = "/"; // Whoopsies!
            this.localPath = false;
            this.enabled = true;
        }
    }
    public class NavBarContainer
    {
        public NavBarItem[] navigations = new NavBarItem[] {
            new NavBarItem()
            {
                path = "git",
                description = "<p>Local Repositories for various projects from the team</p>",
                name = "Git",
                enabled = false,
            },
            new NavBarItem()
            {
                path = "pelican",
                description = "<p>Use Pelican to manage the various types of game servers available here</p>",
                name = "Pelican",
            },
            new NavBarItem()
            {
                path = "seerr",
                description = "<p>Check what media is new right now, and make requests to see if it can be acquired for you.</p><br /><p>Not public.</p>",
                name = "Seerr",
            },

            };

        private bool _hidden = true;

        public bool navBarHidden
        {
            get => _hidden;
            set
            {
                _hidden = value;
                NotifyStateChanged();
            }
        }

        public event Action? OnChange;

        private void NotifyStateChanged() => OnChange?.Invoke();

        public void toggleBar()
        {
            navBarHidden = !navBarHidden;
        }
    }
}

