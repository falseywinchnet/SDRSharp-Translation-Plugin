using SDRSharp.Common;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace SDRSharp.TranslationPlugin
{
	public class MyPluginCollapsiblePanel : UserControl
	{
		private readonly ISharpControl _controlInterface;

		private readonly System.Windows.Forms.Timer _srTimer1 = new System.Windows.Forms.Timer();

		private IContainer components = null;

		public MyPluginCollapsiblePanel(ISharpControl control)
		{
			this._controlInterface = control;
			this.InitializeComponent();
			base.Load += new EventHandler(this.MyPluginPanelLoad);
            this._controlInterface.PropertyChanged += ControlInterface_PropertyChanged;
		}

        private void ControlInterface_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
			switch (e.PropertyName)
			{
			}
        }

        protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
            this.SuspendLayout();
          
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MyPluginCollapsiblePanel";
            this.Size = new System.Drawing.Size(294, 230);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void MyPluginPanelLoad(object sender, EventArgs e)
		{
		}
    }
}