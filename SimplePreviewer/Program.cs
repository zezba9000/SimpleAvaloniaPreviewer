namespace SimplePreviewer
{
    class Program
    {
		static void Main()
		{
			// if previewer is active don't run normal app logic !!!
			if (AvaloniaPV.SimplePreviewer.Init(true)) return;

			// do normal stuff (when previewer not active)...
		}
    }
}
