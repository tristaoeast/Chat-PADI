namespace ChatClient
{
    partial class ChatClientForm
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
            this.tb_url = new System.Windows.Forms.TextBox();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.tb_nick = new System.Windows.Forms.TextBox();
            this.tb_msg = new System.Windows.Forms.TextBox();
            this.tb_conversation = new System.Windows.Forms.TextBox();
            this.bt_reg = new System.Windows.Forms.Button();
            this.bt_send = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_url
            // 
            this.tb_url.Location = new System.Drawing.Point(34, 31);
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(324, 20);
            this.tb_url.TabIndex = 0;
            // 
            // tb_port
            // 
            this.tb_port.Location = new System.Drawing.Point(34, 57);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(100, 20);
            this.tb_port.TabIndex = 1;
            // 
            // tb_nick
            // 
            this.tb_nick.Location = new System.Drawing.Point(34, 83);
            this.tb_nick.Name = "tb_nick";
            this.tb_nick.Size = new System.Drawing.Size(100, 20);
            this.tb_nick.TabIndex = 2;
            // 
            // tb_msg
            // 
            this.tb_msg.Location = new System.Drawing.Point(34, 135);
            this.tb_msg.Name = "tb_msg";
            this.tb_msg.Size = new System.Drawing.Size(324, 20);
            this.tb_msg.TabIndex = 3;
            // 
            // tb_conversation
            // 
            this.tb_conversation.Location = new System.Drawing.Point(34, 161);
            this.tb_conversation.Multiline = true;
            this.tb_conversation.Name = "tb_conversation";
            this.tb_conversation.Size = new System.Drawing.Size(411, 461);
            this.tb_conversation.TabIndex = 4;
            // 
            // bt_reg
            // 
            this.bt_reg.Location = new System.Drawing.Point(370, 83);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(75, 23);
            this.bt_reg.TabIndex = 5;
            this.bt_reg.Text = "Register";
            this.bt_reg.UseVisualStyleBackColor = true;
            this.bt_reg.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // bt_send
            // 
            this.bt_send.Location = new System.Drawing.Point(370, 135);
            this.bt_send.Name = "bt_send";
            this.bt_send.Size = new System.Drawing.Size(75, 23);
            this.bt_send.TabIndex = 6;
            this.bt_send.Text = "Send";
            this.bt_send.UseVisualStyleBackColor = true;
            // 
            // ChatClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 624);
            this.Controls.Add(this.bt_send);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.tb_conversation);
            this.Controls.Add(this.tb_msg);
            this.Controls.Add(this.tb_nick);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_url);
            this.Name = "ChatClientForm";
            this.Text = "ChatClientForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.TextBox tb_nick;
        private System.Windows.Forms.TextBox tb_msg;
        private System.Windows.Forms.TextBox tb_conversation;
        private System.Windows.Forms.Button bt_reg;
        private System.Windows.Forms.Button bt_send;
    }
}

