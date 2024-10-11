namespace Gitar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            leftToolStripMenuItem = new ToolStripMenuItem();
            upToolStripMenuItem = new ToolStripMenuItem();
            downToolStripMenuItem = new ToolStripMenuItem();
            leftToolStripMenuItem1 = new ToolStripMenuItem();
            rightToolStripMenuItem = new ToolStripMenuItem();
            sizeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            toolStripMenuItem4 = new ToolStripMenuItem();
            gitarToolStripMenuItem = new ToolStripMenuItem();
            fToolStripMenuItem = new ToolStripMenuItem();
            siToolStripMenuItem = new ToolStripMenuItem();
            solToolStripMenuItem = new ToolStripMenuItem();
            reToolStripMenuItem = new ToolStripMenuItem();
            laToolStripMenuItem = new ToolStripMenuItem();
            miToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { leftToolStripMenuItem, sizeToolStripMenuItem, gitarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1602, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // leftToolStripMenuItem
            // 
            leftToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { upToolStripMenuItem, downToolStripMenuItem, leftToolStripMenuItem1, rightToolStripMenuItem });
            leftToolStripMenuItem.Name = "leftToolStripMenuItem";
            leftToolStripMenuItem.Size = new Size(67, 20);
            leftToolStripMenuItem.Text = "Posishon";
            leftToolStripMenuItem.Click += leftToolStripMenuItem_Click;
            // 
            // upToolStripMenuItem
            // 
            upToolStripMenuItem.AutoSize = false;
            upToolStripMenuItem.Name = "upToolStripMenuItem";
            upToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Up;
            upToolStripMenuItem.Size = new Size(180, 22);
            upToolStripMenuItem.Text = "Up";
            upToolStripMenuItem.Click += upToolStripMenuItem_Click;
            // 
            // downToolStripMenuItem
            // 
            downToolStripMenuItem.Name = "downToolStripMenuItem";
            downToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Down;
            downToolStripMenuItem.Size = new Size(170, 22);
            downToolStripMenuItem.Text = "Down";
            downToolStripMenuItem.Click += downToolStripMenuItem_Click;
            // 
            // leftToolStripMenuItem1
            // 
            leftToolStripMenuItem1.Name = "leftToolStripMenuItem1";
            leftToolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.Left;
            leftToolStripMenuItem1.Size = new Size(170, 22);
            leftToolStripMenuItem1.Text = "Left";
            leftToolStripMenuItem1.Click += leftToolStripMenuItem1_Click;
            // 
            // rightToolStripMenuItem
            // 
            rightToolStripMenuItem.Name = "rightToolStripMenuItem";
            rightToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Right;
            rightToolStripMenuItem.Size = new Size(170, 22);
            rightToolStripMenuItem.Text = "Right";
            rightToolStripMenuItem.Click += rightToolStripMenuItem_Click;
            // 
            // sizeToolStripMenuItem
            // 
            sizeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItem1, toolStripMenuItem4 });
            sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            sizeToolStripMenuItem.Size = new Size(39, 20);
            sizeToolStripMenuItem.Text = "Size";
            sizeToolStripMenuItem.Click += sizeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.ShortcutKeys = Keys.Control | Keys.Oemplus;
            toolStripMenuItem2.Size = new Size(177, 22);
            toolStripMenuItem2.Text = "+";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(174, 6);
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.ShortcutKeys = Keys.Control | Keys.OemMinus;
            toolStripMenuItem4.Size = new Size(177, 22);
            toolStripMenuItem4.Text = "--";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // gitarToolStripMenuItem
            // 
            gitarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fToolStripMenuItem, siToolStripMenuItem, solToolStripMenuItem, reToolStripMenuItem, laToolStripMenuItem, miToolStripMenuItem });
            gitarToolStripMenuItem.Name = "gitarToolStripMenuItem";
            gitarToolStripMenuItem.Size = new Size(44, 20);
            gitarToolStripMenuItem.Text = "Gitar";
            // 
            // fToolStripMenuItem
            // 
            fToolStripMenuItem.Name = "fToolStripMenuItem";
            fToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            fToolStripMenuItem.Size = new Size(180, 22);
            fToolStripMenuItem.Text = "F";
            fToolStripMenuItem.Click += fToolStripMenuItem_Click;
            // 
            // siToolStripMenuItem
            // 
            siToolStripMenuItem.Name = "siToolStripMenuItem";
            siToolStripMenuItem.Size = new Size(180, 22);
            siToolStripMenuItem.Text = "Si";
            siToolStripMenuItem.Click += siToolStripMenuItem_Click;
            // 
            // solToolStripMenuItem
            // 
            solToolStripMenuItem.Name = "solToolStripMenuItem";
            solToolStripMenuItem.Size = new Size(180, 22);
            solToolStripMenuItem.Text = "Sol";
            solToolStripMenuItem.Click += solToolStripMenuItem_Click;
            // 
            // reToolStripMenuItem
            // 
            reToolStripMenuItem.Name = "reToolStripMenuItem";
            reToolStripMenuItem.Size = new Size(180, 22);
            reToolStripMenuItem.Text = "Re";
            reToolStripMenuItem.Click += reToolStripMenuItem_Click;
            // 
            // laToolStripMenuItem
            // 
            laToolStripMenuItem.Name = "laToolStripMenuItem";
            laToolStripMenuItem.Size = new Size(180, 22);
            laToolStripMenuItem.Text = "La";
            laToolStripMenuItem.Click += laToolStripMenuItem_Click;
            // 
            // miToolStripMenuItem
            // 
            miToolStripMenuItem.Name = "miToolStripMenuItem";
            miToolStripMenuItem.Size = new Size(180, 22);
            miToolStripMenuItem.Text = "Mi";
            miToolStripMenuItem.Click += miToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1602, 871);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem leftToolStripMenuItem;
        private ToolStripMenuItem upToolStripMenuItem;
        private ToolStripMenuItem downToolStripMenuItem;
        private ToolStripMenuItem leftToolStripMenuItem1;
        private ToolStripMenuItem rightToolStripMenuItem;
        private ToolStripMenuItem sizeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem gitarToolStripMenuItem;
        private ToolStripMenuItem fToolStripMenuItem;
        private ToolStripMenuItem siToolStripMenuItem;
        private ToolStripMenuItem solToolStripMenuItem;
        private ToolStripMenuItem reToolStripMenuItem;
        private ToolStripMenuItem laToolStripMenuItem;
        private ToolStripMenuItem miToolStripMenuItem;
    }
}
