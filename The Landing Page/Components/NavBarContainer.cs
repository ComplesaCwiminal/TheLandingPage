namespace the_landing_page.Components
{
    public class NavBarContainer
    {
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

