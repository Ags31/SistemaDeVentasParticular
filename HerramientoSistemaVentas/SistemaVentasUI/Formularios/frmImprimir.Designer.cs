namespace SistemaVentasUI.Formularios
{
    partial class frmImprimir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImprimir));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnimprimir = new FontAwesome.Sharp.IconButton();
            this.btnImpTick = new FontAwesome.Sharp.IconButton();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 51);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(741, 430);
            this.webBrowser1.TabIndex = 0;
            // 
            // btnimprimir
            // 
            this.btnimprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnimprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnimprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimir.ForeColor = System.Drawing.Color.White;
            this.btnimprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnimprimir.IconColor = System.Drawing.Color.White;
            this.btnimprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnimprimir.IconSize = 30;
            this.btnimprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnimprimir.Location = new System.Drawing.Point(173, 8);
            this.btnimprimir.Name = "btnimprimir";
            this.btnimprimir.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.btnimprimir.Size = new System.Drawing.Size(154, 37);
            this.btnimprimir.TabIndex = 4;
            this.btnimprimir.Text = "Imprimir Recibo";
            this.btnimprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnimprimir.UseVisualStyleBackColor = false;
            this.btnimprimir.Click += new System.EventHandler(this.btnimprimir_Click);
            // 
            // btnImpTick
            // 
            this.btnImpTick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(98)))), ((int)(((byte)(145)))));
            this.btnImpTick.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpTick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImpTick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImpTick.ForeColor = System.Drawing.Color.White;
            this.btnImpTick.IconChar = FontAwesome.Sharp.IconChar.Print;
            this.btnImpTick.IconColor = System.Drawing.Color.White;
            this.btnImpTick.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImpTick.IconSize = 30;
            this.btnImpTick.Location = new System.Drawing.Point(355, 8);
            this.btnImpTick.Name = "btnImpTick";
            this.btnImpTick.Size = new System.Drawing.Size(154, 37);
            this.btnImpTick.TabIndex = 6;
            this.btnImpTick.Text = "Imprimir ticket";
            this.btnImpTick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpTick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImpTick.UseVisualStyleBackColor = false;
            this.btnImpTick.Click += new System.EventHandler(this.btnImpTick_Click);
            // 
            // webBrowser2
            // 
            this.webBrowser2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.webBrowser2.AllowNavigation = false;
            this.webBrowser2.AllowWebBrowserDrop = false;
            this.webBrowser2.Location = new System.Drawing.Point(407, 63);
            this.webBrowser2.MaximumSize = new System.Drawing.Size(280, 0);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.ScrollBarsEnabled = false;
            this.webBrowser2.Size = new System.Drawing.Size(279, 391);
            this.webBrowser2.TabIndex = 7;
            this.webBrowser2.WebBrowserShortcutsEnabled = false;
            // 
            // frmImprimir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 482);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.btnImpTick);
            this.Controls.Add(this.btnimprimir);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 521);
            this.MinimumSize = new System.Drawing.Size(758, 521);
            this.Name = "frmImprimir";
            this.Text = "Detalle Documento";
            this.Load += new System.EventHandler(this.frmImprimir_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private FontAwesome.Sharp.IconButton btnimprimir;
        private FontAwesome.Sharp.IconButton btnImpTick;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}