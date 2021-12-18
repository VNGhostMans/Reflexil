using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Reflexil.Handlers
{
    public partial class LinkedResourceHandler : System.Windows.Forms.UserControl
	{
		
		
		//UserControl remplace la mÃ©thode Dispose pour nettoyer la liste des composants.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && (components != null))
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Requise par le Concepteur Windows Form
		private System.ComponentModel.Container components = null;
		
		//REMARQUEÂ : la procÃ©dure suivante est requise par le Concepteur Windows Form
		//Elle peut Ãªtre modifiÃ©e Ã  l'aide du Concepteur Windows Form.
		//Ne la modifiez pas Ã  l'aide de l'Ã©diteur de code.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.TabResource = new System.Windows.Forms.TabControl();
            this.TabAttributes = new System.Windows.Forms.TabPage();
            this.Attributes = new Reflexil.Editors.LinkedResourceAttributesControl();
            this.TabResource.SuspendLayout();
            this.TabAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabResource
            // 
            this.TabResource.Controls.Add(this.TabAttributes);
            this.TabResource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabResource.Location = new System.Drawing.Point(0, 0);
            this.TabResource.Name = "TabResource";
            this.TabResource.SelectedIndex = 0;
            this.TabResource.Size = new System.Drawing.Size(499, 262);
            this.TabResource.TabIndex = 1;
            // 
            // TabAttributes
            // 
            this.TabAttributes.Controls.Add(this.Attributes);
            this.TabAttributes.Location = new System.Drawing.Point(4, 22);
            this.TabAttributes.Name = "TabAttributes";
            this.TabAttributes.Padding = new System.Windows.Forms.Padding(3);
            this.TabAttributes.Size = new System.Drawing.Size(491, 236);
            this.TabAttributes.TabIndex = 1;
            this.TabAttributes.Text = "Attributes";
            this.TabAttributes.UseVisualStyleBackColor = true;
            // 
            // Attributes
            // 
            this.Attributes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Attributes.Item = null;
            this.Attributes.Location = new System.Drawing.Point(3, 3);
            this.Attributes.Name = "Attributes";
            this.Attributes.ReadOnly = false;
            this.Attributes.Size = new System.Drawing.Size(485, 230);
            this.Attributes.TabIndex = 0;
            // 
            // LinkedResourceHandler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabResource);
            this.Name = "LinkedResourceHandler";
            this.Size = new System.Drawing.Size(499, 262);
            this.TabResource.ResumeLayout(false);
            this.TabAttributes.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TabControl TabResource;
        private System.Windows.Forms.TabPage TabAttributes;
        private Editors.LinkedResourceAttributesControl Attributes;
		
	}
}

