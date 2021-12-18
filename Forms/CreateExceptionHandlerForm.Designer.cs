using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System;

namespace Reflexil.Forms
{

    public partial class CreateExceptionHandlerForm : ExceptionHandlerForm
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.ButAppend = new System.Windows.Forms.Button();
            this.ButInsertBefore = new System.Windows.Forms.Button();
            this.ButInsertAfter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButAppend
            // 
            this.ButAppend.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButAppend.Location = new System.Drawing.Point(401, 12);
            this.ButAppend.Name = "ButAppend";
            this.ButAppend.Size = new System.Drawing.Size(130, 23);
            this.ButAppend.TabIndex = 12;
            this.ButAppend.Text = "Append";
            this.ButAppend.UseVisualStyleBackColor = true;
            this.ButAppend.Click += new System.EventHandler(this.ButAppend_Click);
            // 
            // ButInsertBefore
            // 
            this.ButInsertBefore.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButInsertBefore.Location = new System.Drawing.Point(401, 39);
            this.ButInsertBefore.Name = "ButInsertBefore";
            this.ButInsertBefore.Size = new System.Drawing.Size(130, 23);
            this.ButInsertBefore.TabIndex = 13;
            this.ButInsertBefore.Text = "Insert before selection";
            this.ButInsertBefore.UseVisualStyleBackColor = true;
            this.ButInsertBefore.Click += new System.EventHandler(this.ButInsertBefore_Click);
            // 
            // ButInsertAfter
            // 
            this.ButInsertAfter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButInsertAfter.Location = new System.Drawing.Point(401, 67);
            this.ButInsertAfter.Name = "ButInsertAfter";
            this.ButInsertAfter.Size = new System.Drawing.Size(130, 23);
            this.ButInsertAfter.TabIndex = 14;
            this.ButInsertAfter.Text = "Insert after selection";
            this.ButInsertAfter.UseVisualStyleBackColor = true;
            this.ButInsertAfter.Click += new System.EventHandler(this.ButInsertAfter_Click);
            // 
            // CreateExceptionHandlerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(536, 203);
            this.Controls.Add(this.ButInsertAfter);
            this.Controls.Add(this.ButInsertBefore);
            this.Controls.Add(this.ButAppend);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateExceptionHandlerForm";
            this.ShowInTaskbar = false;
            this.Text = "Create new exception handler";
            this.Load += new System.EventHandler(this.CreateExceptionHandlerForm_Load);
            this.Controls.SetChildIndex(this.ButAppend, 0);
            this.Controls.SetChildIndex(this.ButInsertBefore, 0);
            this.Controls.SetChildIndex(this.ButInsertAfter, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button ButAppend;
		internal System.Windows.Forms.Button ButInsertBefore;
		internal System.Windows.Forms.Button ButInsertAfter;
		
	}
}


