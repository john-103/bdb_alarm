namespace bdb_alarm
{
    partial class Form__dashboard
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel__now = new System.Windows.Forms.Panel();
            this.label__now = new System.Windows.Forms.Label();
            this.groupBox__add = new System.Windows.Forms.GroupBox();
            this.comboBox__add_note = new System.Windows.Forms.ComboBox();
            this.button_add_clean = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.label__note = new System.Windows.Forms.Label();
            this.label__time = new System.Windows.Forms.Label();
            this.textBox__add_time = new System.Windows.Forms.TextBox();
            this.groupBox__alarm_list = new System.Windows.Forms.GroupBox();
            this.button__list_read = new System.Windows.Forms.Button();
            this.button__list_save = new System.Windows.Forms.Button();
            this.button__delete = new System.Windows.Forms.Button();
            this.listBox__alarm_list = new System.Windows.Forms.ListBox();
            this.panel__now.SuspendLayout();
            this.groupBox__add.SuspendLayout();
            this.groupBox__alarm_list.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel__now
            // 
            this.panel__now.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel__now.Controls.Add(this.label__now);
            this.panel__now.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel__now.Location = new System.Drawing.Point(0, 0);
            this.panel__now.Name = "panel__now";
            this.panel__now.Size = new System.Drawing.Size(884, 100);
            this.panel__now.TabIndex = 7;
            // 
            // label__now
            // 
            this.label__now.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label__now.Font = new System.Drawing.Font("굴림", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label__now.Location = new System.Drawing.Point(0, 0);
            this.label__now.Name = "label__now";
            this.label__now.Size = new System.Drawing.Size(882, 98);
            this.label__now.TabIndex = 1;
            this.label__now.Text = "now";
            this.label__now.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox__add
            // 
            this.groupBox__add.Controls.Add(this.comboBox__add_note);
            this.groupBox__add.Controls.Add(this.button_add_clean);
            this.groupBox__add.Controls.Add(this.button_add);
            this.groupBox__add.Controls.Add(this.label__note);
            this.groupBox__add.Controls.Add(this.label__time);
            this.groupBox__add.Controls.Add(this.textBox__add_time);
            this.groupBox__add.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox__add.Location = new System.Drawing.Point(557, 106);
            this.groupBox__add.Name = "groupBox__add";
            this.groupBox__add.Size = new System.Drawing.Size(315, 210);
            this.groupBox__add.TabIndex = 11;
            this.groupBox__add.TabStop = false;
            this.groupBox__add.Text = "add";
            // 
            // comboBox__add_note
            // 
            this.comboBox__add_note.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox__add_note.FormattingEnabled = true;
            this.comboBox__add_note.Location = new System.Drawing.Point(25, 147);
            this.comboBox__add_note.Name = "comboBox__add_note";
            this.comboBox__add_note.Size = new System.Drawing.Size(175, 32);
            this.comboBox__add_note.TabIndex = 12;
            this.comboBox__add_note.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox__add_note_KeyPress);
            // 
            // button_add_clean
            // 
            this.button_add_clean.Location = new System.Drawing.Point(215, 147);
            this.button_add_clean.Name = "button_add_clean";
            this.button_add_clean.Size = new System.Drawing.Size(75, 32);
            this.button_add_clean.TabIndex = 20;
            this.button_add_clean.Text = "clean";
            this.button_add_clean.UseVisualStyleBackColor = true;
            this.button_add_clean.Click += new System.EventHandler(this.button_add_clean_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(215, 58);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 35);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label__note
            // 
            this.label__note.AutoSize = true;
            this.label__note.Location = new System.Drawing.Point(25, 120);
            this.label__note.Name = "label__note";
            this.label__note.Size = new System.Drawing.Size(61, 24);
            this.label__note.TabIndex = 14;
            this.label__note.Text = "note";
            // 
            // label__time
            // 
            this.label__time.AutoSize = true;
            this.label__time.Location = new System.Drawing.Point(25, 31);
            this.label__time.Name = "label__time";
            this.label__time.Size = new System.Drawing.Size(235, 24);
            this.label__time.TabIndex = 13;
            this.label__time.Text = "time(24-hour clock)";
            // 
            // textBox__add_time
            // 
            this.textBox__add_time.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox__add_time.Location = new System.Drawing.Point(25, 58);
            this.textBox__add_time.MaxLength = 4;
            this.textBox__add_time.Name = "textBox__add_time";
            this.textBox__add_time.Size = new System.Drawing.Size(175, 35);
            this.textBox__add_time.TabIndex = 11;
            this.textBox__add_time.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox__add_time_KeyPress);
            // 
            // groupBox__alarm_list
            // 
            this.groupBox__alarm_list.Controls.Add(this.button__list_read);
            this.groupBox__alarm_list.Controls.Add(this.button__list_save);
            this.groupBox__alarm_list.Controls.Add(this.button__delete);
            this.groupBox__alarm_list.Controls.Add(this.listBox__alarm_list);
            this.groupBox__alarm_list.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox__alarm_list.Location = new System.Drawing.Point(12, 106);
            this.groupBox__alarm_list.Name = "groupBox__alarm_list";
            this.groupBox__alarm_list.Size = new System.Drawing.Size(528, 500);
            this.groupBox__alarm_list.TabIndex = 21;
            this.groupBox__alarm_list.TabStop = false;
            this.groupBox__alarm_list.Text = "alarm_list";
            // 
            // button__list_read
            // 
            this.button__list_read.Location = new System.Drawing.Point(181, 437);
            this.button__list_read.Name = "button__list_read";
            this.button__list_read.Size = new System.Drawing.Size(165, 50);
            this.button__list_read.TabIndex = 22;
            this.button__list_read.Text = "list_read";
            this.button__list_read.UseVisualStyleBackColor = true;
            this.button__list_read.Click += new System.EventHandler(this.button__list_read_Click);
            // 
            // button__list_save
            // 
            this.button__list_save.Location = new System.Drawing.Point(6, 437);
            this.button__list_save.Name = "button__list_save";
            this.button__list_save.Size = new System.Drawing.Size(165, 50);
            this.button__list_save.TabIndex = 21;
            this.button__list_save.Text = "list_save";
            this.button__list_save.UseVisualStyleBackColor = true;
            this.button__list_save.Click += new System.EventHandler(this.button__list_save_Click);
            // 
            // button__delete
            // 
            this.button__delete.Location = new System.Drawing.Point(356, 437);
            this.button__delete.Name = "button__delete";
            this.button__delete.Size = new System.Drawing.Size(165, 50);
            this.button__delete.TabIndex = 20;
            this.button__delete.Text = "delete";
            this.button__delete.UseVisualStyleBackColor = true;
            this.button__delete.Click += new System.EventHandler(this.button__delete_Click);
            // 
            // listBox__alarm_list
            // 
            this.listBox__alarm_list.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox__alarm_list.FormattingEnabled = true;
            this.listBox__alarm_list.ItemHeight = 24;
            this.listBox__alarm_list.Location = new System.Drawing.Point(6, 40);
            this.listBox__alarm_list.Name = "listBox__alarm_list";
            this.listBox__alarm_list.Size = new System.Drawing.Size(516, 388);
            this.listBox__alarm_list.TabIndex = 3;
            // 
            // Form__dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(884, 612);
            this.Controls.Add(this.groupBox__alarm_list);
            this.Controls.Add(this.groupBox__add);
            this.Controls.Add(this.panel__now);
            this.MaximizeBox = false;
            this.Name = "Form__dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.TopMost = true;
            this.panel__now.ResumeLayout(false);
            this.groupBox__add.ResumeLayout(false);
            this.groupBox__add.PerformLayout();
            this.groupBox__alarm_list.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel__now;
        private System.Windows.Forms.Label label__now;
        private System.Windows.Forms.GroupBox groupBox__add;
        private System.Windows.Forms.Button button_add_clean;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label__note;
        private System.Windows.Forms.Label label__time;
        private System.Windows.Forms.TextBox textBox__add_time;
        private System.Windows.Forms.GroupBox groupBox__alarm_list;
        private System.Windows.Forms.Button button__delete;
        private System.Windows.Forms.ListBox listBox__alarm_list;
        private System.Windows.Forms.Button button__list_save;
        private System.Windows.Forms.ComboBox comboBox__add_note;
        private System.Windows.Forms.Button button__list_read;
    }
}

