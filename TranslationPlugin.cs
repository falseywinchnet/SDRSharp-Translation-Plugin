using SDRSharp.Common;
using System.Windows.Forms;
using System.Reflection;
using System.Configuration;
namespace SDRSharp.TranslationPlugin
{
	public class TranslationPlugin : ISharpPlugin
	{
		private const string MyDisplayName = "Translations and tooltips for sdrsharp";

		private ISharpControl _controlInterface;

		private MyPluginCollapsiblePanel _myPluginPanel;

		public string DisplayName
		{
			get
			{
				return MyDisplayName;
			}
		}

		public UserControl Gui => _myPluginPanel;

		public TranslationPlugin()
		{
            //Scenario 1:
            //we want to enumerate everything so we get an up to date list of controls.
            //we want to get all buttons, checkboxes, and sliders for tooltip text,
            //and all labels and listcontrols for replacement text.
            //we dont consider plugins.
            //this requires a parser for all controls in all forms, open or not.
            //scenario two: we want to enumerate and attempt to do a 1:1 transpose of texts
            //and tooltip text from our translation files. we use the system language
            //and look for a corresponding file. if none exists in our plugin info we 
            //say "translations not found for your language". We check one time when
            //"enable" is clicked. When disable is clicked we want to reset all strings and controls
            //back to normal. 
            //we want to track state so we can do translation on startup

            //if we detect a tooltip, we want to use it.
            //if there is no tooltip, we add one.
            //if we cant find a specific control we dont attempt to label it
            //we have two controls: disable/enable and export.
            //export is only to be offered if the current language file cant be found.
            //if export is clicked, we make a new file named systemlangprefixsuffix.config
            //ie DE-de.config which contains the following:
            //<?xml version="1.0" encoding="utf-8"?>
			//< configuration xmlns: xsi = "http://www.w3.org/2001/XMLSchema-instance" xmlns: xsd = "http://www.w3.org/2001/XMLSchema" >
			//< add key = "controlname.controltype.labeltext" value = "" />
			//< add key = "controlname.controltype.tooltip1.tooltiptext" value = "" />
			//and so forth to enumerate all available controls.

			


        }

		public void Close()
		{
		}

		public void Initialize(ISharpControl control)
		{
			this._controlInterface = control;
			this._myPluginPanel = new MyPluginCollapsiblePanel(this._controlInterface);
		}
	}
}