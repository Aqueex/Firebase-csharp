
namespace csharp_firebase
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tx_name = new System.Windows.Forms.TextBox();
            this.tx_pass = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_pass = new System.Windows.Forms.Label();
            this.bt_ınsert = new System.Windows.Forms.Button();
            this.bt_update = new System.Windows.Forms.Button();
            this.bt_select = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.list_all = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(124, 9);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(100, 20);
            this.tx_name.TabIndex = 0;
            // 
            // tx_pass
            // 
            this.tx_pass.Location = new System.Drawing.Point(124, 54);
            this.tx_pass.Name = "tx_pass";
            this.tx_pass.Size = new System.Drawing.Size(100, 20);
            this.tx_pass.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(52, 9);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(35, 13);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Name";
            // 
            // lb_pass
            // 
            this.lb_pass.AutoSize = true;
            this.lb_pass.Location = new System.Drawing.Point(52, 54);
            this.lb_pass.Name = "lb_pass";
            this.lb_pass.Size = new System.Drawing.Size(53, 13);
            this.lb_pass.TabIndex = 3;
            this.lb_pass.Text = "Password";
            // 
            // bt_ınsert
            // 
            this.bt_ınsert.Location = new System.Drawing.Point(55, 109);
            this.bt_ınsert.Name = "bt_ınsert";
            this.bt_ınsert.Size = new System.Drawing.Size(75, 23);
            this.bt_ınsert.TabIndex = 4;
            this.bt_ınsert.Text = "Insert";
            this.bt_ınsert.UseVisualStyleBackColor = true;
            this.bt_ınsert.Click += new System.EventHandler(this.bt_ınsert_Click);
            // 
            // bt_update
            // 
            this.bt_update.Location = new System.Drawing.Point(169, 109);
            this.bt_update.Name = "bt_update";
            this.bt_update.Size = new System.Drawing.Size(75, 23);
            this.bt_update.TabIndex = 5;
            this.bt_update.Text = "Update";
            this.bt_update.UseVisualStyleBackColor = true;
            this.bt_update.Click += new System.EventHandler(this.bt_update_Click);
            // 
            // bt_select
            // 
            this.bt_select.Location = new System.Drawing.Point(55, 147);
            this.bt_select.Name = "bt_select";
            this.bt_select.Size = new System.Drawing.Size(75, 23);
            this.bt_select.TabIndex = 6;
            this.bt_select.Text = "Select";
            this.bt_select.UseVisualStyleBackColor = true;
            this.bt_select.Click += new System.EventHandler(this.bt_select_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(169, 147);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(75, 23);
            this.bt_delete.TabIndex = 7;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // list_all
            // 
            this.list_all.FormattingEnabled = true;
            this.list_all.Location = new System.Drawing.Point(292, 10);
            this.list_all.Name = "list_all";
            this.list_all.Size = new System.Drawing.Size(490, 160);
            this.list_all.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "All Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.list_all);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_select);
            this.Controls.Add(this.bt_update);
            this.Controls.Add(this.bt_ınsert);
            this.Controls.Add(this.lb_pass);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.tx_pass);
            this.Controls.Add(this.tx_name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.TextBox tx_pass;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_pass;
        private System.Windows.Forms.Button bt_ınsert;
        private System.Windows.Forms.Button bt_update;
        private System.Windows.Forms.Button bt_select;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.ListBox list_all;
        private System.Windows.Forms.Button button1;
    }
}

