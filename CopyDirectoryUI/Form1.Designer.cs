namespace CopyDirectoryUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SourceText = new System.Windows.Forms.TextBox();
            this.DestinationText = new System.Windows.Forms.TextBox();
            this.SourceButton = new System.Windows.Forms.Button();
            this.DestinationButtton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.filesCopiedListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination:";
            // 
            // SourceText
            // 
            this.SourceText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceText.Location = new System.Drawing.Point(173, 32);
            this.SourceText.Name = "SourceText";
            this.SourceText.Size = new System.Drawing.Size(436, 27);
            this.SourceText.TabIndex = 4;
            this.SourceText.TextChanged += new System.EventHandler(this.SourceText_TextChanged);
            // 
            // DestinationText
            // 
            this.DestinationText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationText.Location = new System.Drawing.Point(173, 95);
            this.DestinationText.Name = "DestinationText";
            this.DestinationText.Size = new System.Drawing.Size(436, 25);
            this.DestinationText.TabIndex = 5;
            this.DestinationText.TextChanged += new System.EventHandler(this.DestinationText_TextChanged);
            // 
            // SourceButton
            // 
            this.SourceButton.Location = new System.Drawing.Point(629, 32);
            this.SourceButton.Name = "SourceButton";
            this.SourceButton.Size = new System.Drawing.Size(54, 35);
            this.SourceButton.TabIndex = 6;
            this.SourceButton.Text = "...";
            this.SourceButton.UseVisualStyleBackColor = true;
            this.SourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // DestinationButtton
            // 
            this.DestinationButtton.Location = new System.Drawing.Point(629, 95);
            this.DestinationButtton.Name = "DestinationButtton";
            this.DestinationButtton.Size = new System.Drawing.Size(54, 35);
            this.DestinationButtton.TabIndex = 7;
            this.DestinationButtton.Text = "...";
            this.DestinationButtton.UseVisualStyleBackColor = true;
            this.DestinationButtton.Click += new System.EventHandler(this.DestinationButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(603, 150);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(80, 48);
            this.CopyButton.TabIndex = 8;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // filesCopiedListbox
            // 
            this.filesCopiedListbox.FormattingEnabled = true;
            this.filesCopiedListbox.ItemHeight = 30;
            this.filesCopiedListbox.Location = new System.Drawing.Point(36, 162);
            this.filesCopiedListbox.Name = "filesCopiedListbox";
            this.filesCopiedListbox.Size = new System.Drawing.Size(546, 304);
            this.filesCopiedListbox.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(948, 683);
            this.Controls.Add(this.filesCopiedListbox);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.DestinationButtton);
            this.Controls.Add(this.SourceButton);
            this.Controls.Add(this.DestinationText);
            this.Controls.Add(this.SourceText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Copy Directory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SourceText;
        private System.Windows.Forms.TextBox DestinationText;
        private System.Windows.Forms.Button SourceButton;
        private System.Windows.Forms.Button DestinationButtton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.ListBox filesCopiedListbox;
    }
}

