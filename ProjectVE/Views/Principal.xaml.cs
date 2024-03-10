using Microsoft.Maui.Controls.PlatformConfiguration;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;


namespace ProjectVE.Views;

public partial class Principal : Microsoft.Maui.Controls.TabbedPage
{
	public Principal()
	{
        On<Microsoft.Maui.Controls.PlatformConfiguration.Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
        InitializeComponent();
	}
}