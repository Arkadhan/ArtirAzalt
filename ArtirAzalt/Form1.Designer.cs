
namespace ArtirAzalt
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
            this.tbSayi = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn10 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn30 = new System.Windows.Forms.Button();
            this.btn40 = new System.Windows.Forms.Button();
            this.rbArtir = new System.Windows.Forms.RadioButton();
            this.rbAzalt = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // tbSayi
            // 
            this.tbSayi.Location = new System.Drawing.Point(209, 94);
            this.tbSayi.Name = "tbSayi";
            this.tbSayi.Size = new System.Drawing.Size(207, 20);
            this.tbSayi.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(209, 135);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(42, 23);
            this.btn10.TabIndex = 2;
            this.btn10.Text = "10";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn20
            // 
            this.btn20.Location = new System.Drawing.Point(257, 135);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(43, 23);
            this.btn20.TabIndex = 3;
            this.btn20.Text = "20";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn30
            // 
            this.btn30.Location = new System.Drawing.Point(306, 135);
            this.btn30.Name = "btn30";
            this.btn30.Size = new System.Drawing.Size(48, 23);
            this.btn30.TabIndex = 4;
            this.btn30.Text = "30";
            this.btn30.UseVisualStyleBackColor = true;
            this.btn30.Click += new System.EventHandler(this.btn30_Click);
            // 
            // btn40
            // 
            this.btn40.Location = new System.Drawing.Point(370, 135);
            this.btn40.Name = "btn40";
            this.btn40.Size = new System.Drawing.Size(46, 23);
            this.btn40.TabIndex = 5;
            this.btn40.Text = "40";
            this.btn40.UseVisualStyleBackColor = true;
            this.btn40.Click += new System.EventHandler(this.btn40_Click);
            // 
            // rbArtir
            // 
            this.rbArtir.AutoSize = true;
            this.rbArtir.Location = new System.Drawing.Point(257, 181);
            this.rbArtir.Name = "rbArtir";
            this.rbArtir.Size = new System.Drawing.Size(43, 17);
            this.rbArtir.TabIndex = 6;
            this.rbArtir.TabStop = true;
            this.rbArtir.Text = "Artır";
            this.rbArtir.UseVisualStyleBackColor = true;
            // 
            // rbAzalt
            // 
            this.rbAzalt.AutoSize = true;
            this.rbAzalt.Location = new System.Drawing.Point(333, 181);
            this.rbAzalt.Name = "rbAzalt";
            this.rbAzalt.Size = new System.Drawing.Size(48, 17);
            this.rbAzalt.TabIndex = 7;
            this.rbAzalt.TabStop = true;
            this.rbAzalt.Text = "Azalt";
            this.rbAzalt.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbAzalt);
            this.Controls.Add(this.rbArtir);
            this.Controls.Add(this.btn40);
            this.Controls.Add(this.btn30);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.tbSayi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSayi;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Button btn30;
        private System.Windows.Forms.Button btn40;
        private System.Windows.Forms.RadioButton rbArtir;
        private System.Windows.Forms.RadioButton rbAzalt;
    }
}

